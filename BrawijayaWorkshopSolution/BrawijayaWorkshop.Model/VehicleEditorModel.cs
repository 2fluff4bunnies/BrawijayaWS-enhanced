using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Database.Repositories;
using BrawijayaWorkshop.Infrastructure.Repository;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BrawijayaWorkshop.Model
{
    public class VehicleEditorModel : AppBaseModel
    {
        private ICustomerRepository _customerRepository;
        private IVehicleGroupRepository _vehicleGroupRepository;
        private IVehicleRepository _vehicleRepository;
        private IVehicleDetailRepository _vehicleDetailRepository;
        private IVehicleWheelRepository _vehicleWheelRepository;
        private ISpecialSparepartDetailRepository _wheelDetailRepository;
        private ISparepartRepository _sparepartRepository;
        private ISparepartDetailRepository _sparepartDetailRepository;
        private ITypeRepository _typeRepository;
        private IBrandRepository _brandRepository;
        private IUnitOfWork _unitOfWork;

        public VehicleEditorModel(ICustomerRepository customerRepository, IVehicleGroupRepository vehicleGroupRepository,
            IVehicleRepository vehicleRepository,
            IVehicleDetailRepository vehicleDetailRepository, IVehicleWheelRepository vehicleWheelRepository,
            ISparepartRepository sparepartRepository, ITypeRepository typeRepository,
            ISpecialSparepartDetailRepository wheelDetailRepository, IBrandRepository brandRepository,
            ISparepartDetailRepository sparepartDetailRepository,
            IUnitOfWork unitOfWork)
            : base()
        {
            _customerRepository = customerRepository;
            _vehicleGroupRepository = vehicleGroupRepository;
            _vehicleRepository = vehicleRepository;
            _vehicleDetailRepository = vehicleDetailRepository;
            _vehicleWheelRepository = vehicleWheelRepository;
            _wheelDetailRepository = wheelDetailRepository;
            _sparepartDetailRepository = sparepartDetailRepository;
            _sparepartRepository = sparepartRepository;
            _typeRepository = typeRepository;
            _brandRepository = brandRepository;

            _unitOfWork = unitOfWork;
        }

        public List<CustomerViewModel> GetCustomersList()
        {
            List<Customer> result = _customerRepository.GetMany(c => c.Status == (int)DbConstant.DefaultDataStatus.Active).ToList();
            List<CustomerViewModel> mappedResult = new List<CustomerViewModel>();
            return Map(result, mappedResult);
        }

        public List<VehicleGroupViewModel> GetVehicleGroupByCustomer(int customerId)
        {
            List<VehicleGroup> result = _vehicleGroupRepository.GetMany(vg => vg.Status == (int)DbConstant.DefaultDataStatus.Active &&
                vg.CustomerId == customerId).ToList();
            List<VehicleGroupViewModel> mappedResult = new List<VehicleGroupViewModel>();
            return Map(result, mappedResult);
        }

        public List<SpecialSparepartDetailViewModel> RetrieveAllWheelDetails(int vehicleId)
        {
            var currentVehicleWHeel = getCurrentVehicleWheel(vehicleId);
            if (currentVehicleWHeel != null && currentVehicleWHeel.Count > 0)
            {

                List<SpecialSparepartDetail> result = _wheelDetailRepository.GetMany(wd => (wd.Status == (int)DbConstant.WheelDetailStatus.Ready
                                                                                || wd.Status == (int)DbConstant.WheelDetailStatus.Installed)
                                                                                && wd.SpecialSparepart.ReferenceCategory.Code == DbConstant.REF_SPECIAL_SPAREPART_TYPE_WHEEL
                                                                                && !currentVehicleWHeel.Any(vw => vw.WheelDetailId == wd.Id)
                                                                          ).ToList();
                List<SpecialSparepartDetailViewModel> mappedResult = new List<SpecialSparepartDetailViewModel>();
                return Map(result, mappedResult);
            }
            else
                return new List<SpecialSparepartDetailViewModel>();
        }

        public List<SpecialSparepartDetailViewModel> RetrieveReadyWheelDetails()
        {
            List<SpecialSparepartDetail> result = _wheelDetailRepository.GetMany(wd => wd.Status == (int)DbConstant.WheelDetailStatus.Ready
                                                                                       && wd.SpecialSparepart.ReferenceCategory.Code == DbConstant.REF_SPECIAL_SPAREPART_TYPE_WHEEL).ToList();
            List<SpecialSparepartDetailViewModel> mappedResult = new List<SpecialSparepartDetailViewModel>();
            return Map(result, mappedResult);
        }

        public void InsertVehicle(VehicleViewModel vehicle, DateTime expirationDate,
             List<VehicleWheelViewModel> vehicleWheels, int userId)
        {
            DateTime serverTime = DateTime.Now;

            Vehicle entity = new Vehicle();
            Map(vehicle, entity);
            entity.CreateDate = entity.ModifyDate = serverTime;
            entity.CreateUserId = entity.ModifyUserId = userId;
            entity.Status = (int)DbConstant.DefaultDataStatus.Active;
            var insertedVehicle = _vehicleRepository.Add(entity);

            VehicleDetail vehicleDetail = new VehicleDetail
            {
                Vehicle = insertedVehicle,
                LicenseNumber = insertedVehicle.ActiveLicenseNumber,
                ExpirationDate = expirationDate,
                CreateDate = serverTime,
                ModifyDate = serverTime,
                ModifyUserId = userId,
                CreateUserId = userId,
                Status = (int)DbConstant.LicenseNumberStatus.Active
            };

            _vehicleDetailRepository.Add(vehicleDetail);

            foreach (var vw in vehicleWheels)
            {
                if (vw.WheelDetailId > 0)
                {
                    VehicleWheel vwEntity = new VehicleWheel();
                    Map(vw, vwEntity);
                    vwEntity.Vehicle = insertedVehicle;
                    vwEntity.WheelDetailId = vw.WheelDetailId;
                    vwEntity.CreateDate = vwEntity.ModifyDate = serverTime;
                    vwEntity.CreateUserId = vwEntity.ModifyUserId = userId;
                    vwEntity.VehicleId = insertedVehicle.Id;
                    vwEntity.Status = (int)DbConstant.DefaultDataStatus.Active;

                    _vehicleWheelRepository.Add(vwEntity);

                    SpecialSparepartDetail wdEntity = _wheelDetailRepository.GetById(vw.WheelDetailId);
                    wdEntity.ModifyDate = serverTime;
                    wdEntity.ModifyUserId = userId;
                    wdEntity.Status = (int)DbConstant.WheelDetailStatus.Installed;

                    _wheelDetailRepository.Update(wdEntity);

                    SparepartDetail spdEntity = _sparepartDetailRepository.GetById(wdEntity.SparepartDetailId);
                    spdEntity.ModifyDate = serverTime;
                    spdEntity.ModifyUserId = userId;
                    spdEntity.Status = (int)DbConstant.SparepartDetailDataStatus.OutInstalled;

                    _sparepartDetailRepository.Update(spdEntity);

                    Sparepart spEntity = _sparepartRepository.GetById(wdEntity.SparepartDetail.SparepartId);
                    spEntity.ModifyDate = serverTime;
                    spEntity.ModifyUserId = userId;
                    spEntity.StockQty = spEntity.StockQty - 1;
                }
            }

            _unitOfWork.SaveChanges();
        }

        public void UpdateVehicle(VehicleViewModel vehicle, List<VehicleWheelViewModel> vehicleWheels,
            List<VehicleWheelViewModel> vehicleWheelExchanged, int userId)
        {
            DateTime serverTime = DateTime.Now;

            vehicle.ModifyDate = serverTime;
            vehicle.ModifyUserId = userId;
            Vehicle entity = _vehicleRepository.GetById(vehicle.Id);
            Map(vehicle, entity);
            _vehicleRepository.Update(entity);

            if (vehicleWheelExchanged.Count > 0)
            {
                foreach (var vw in vehicleWheelExchanged)
                {
                    VehicleWheel vwEntity = _vehicleWheelRepository.GetById(vw.Id);
                    vwEntity.WheelDetailId = vw.WheelDetailId;
                    vwEntity.ModifyDate = serverTime;
                    vwEntity.ModifyUserId = userId;

                    _vehicleWheelRepository.AttachNavigation<Vehicle>(vwEntity.Vehicle);
                    _vehicleWheelRepository.AttachNavigation<SpecialSparepartDetail>(vwEntity.WheelDetail);
                    _vehicleWheelRepository.Update(vwEntity);
                }
            }

            foreach (var vw in vehicleWheels)
            {
                if (vw.Id > 0)
                {
                    VehicleWheel vwEntity = _vehicleWheelRepository.GetById(vw.Id);
                    vwEntity.WheelDetailId = vw.WheelDetailId;
                    vwEntity.ModifyDate = serverTime;
                    vwEntity.ModifyUserId = userId;

                    _vehicleWheelRepository.AttachNavigation<Vehicle>(vwEntity.Vehicle);
                    _vehicleWheelRepository.AttachNavigation<SpecialSparepartDetail>(vwEntity.WheelDetail);
                    _vehicleWheelRepository.Update(vwEntity);
                }
                else
                {
                    VehicleWheel vwEntity = new VehicleWheel();
                    Map(vw, vwEntity);
                    vwEntity.VehicleId = vehicle.Id;
                    vwEntity.WheelDetailId = vw.WheelDetailId;
                    vwEntity.CreateDate = vwEntity.ModifyDate = serverTime;
                    vwEntity.CreateUserId = vwEntity.ModifyUserId = userId;
                    vwEntity.Status = (int)DbConstant.DefaultDataStatus.Active;

                    _vehicleWheelRepository.Add(vwEntity);
                }
            }

            _unitOfWork.SaveChanges();
        }

        public void DeleteVehicle(VehicleViewModel vehicle, int userId)
        {
            DateTime serverTime = DateTime.Now;

            vehicle.ModifyDate = serverTime;
            vehicle.ModifyUserId = userId;
            vehicle.Status = (int)DbConstant.DefaultDataStatus.Deleted;
            Vehicle entity = _vehicleRepository.GetById(vehicle.Id);
            Map(vehicle, entity);
            _vehicleRepository.Update(entity);

            _unitOfWork.SaveChanges();
        }

        public List<VehicleWheelViewModel> getCurrentVehicleWheel(int vehicleId)
        {
            List<VehicleWheel> result = _vehicleWheelRepository.GetMany(
                vw => vw.Vehicle.Id == vehicleId && vw.Status == (int)DbConstant.DefaultDataStatus.Active).ToList();

            List<VehicleWheelViewModel> mappedResult = new List<VehicleWheelViewModel>();

            return Map(result, mappedResult);
        }


        public VehicleWheelViewModel IsWheelUsedByOtherVehicle(int wheelDetailId, int vehicleId)
        {
            VehicleWheel result = _vehicleWheelRepository.GetMany(
                vw => vw.VehicleId != vehicleId && vw.WheelDetailId == wheelDetailId).FirstOrDefault();

            VehicleWheelViewModel mappedResult = new VehicleWheelViewModel();

            return Map(result, mappedResult);
        }

        public int GetCurrentWheelDetailId(int vehicleWheelId)
        {
            VehicleWheel result = _vehicleWheelRepository.GetById(vehicleWheelId);

            return result.WheelDetailId;
        }

        public List<TypeViewModel> GetTypeList()
        {
            List<BrawijayaWorkshop.Database.Entities.Type> result = _typeRepository.GetMany(t => t.Status == (int)DbConstant.DefaultDataStatus.Active).ToList();

            List<TypeViewModel> mappedResult = new List<TypeViewModel>();

            return Map(result, mappedResult);
        }

        public List<BrandViewModel> GetBrandList()
        {
            List<Brand> result = _brandRepository.GetMany(b => b.Status == (int)DbConstant.DefaultDataStatus.Active).ToList();

            List<BrandViewModel> mappedResult = new List<BrandViewModel>();

            return Map(result, mappedResult);
        }

        public bool IsCodeExist(string code, VehicleViewModel selectedVehicle)
        {
            Vehicle result = new Vehicle();

            if (selectedVehicle != null)
            {
                result = _vehicleRepository.GetMany(v =>
                   v.Status == (int)DbConstant.DefaultDataStatus.Active &&
                   v.Code.ToLower() == code.ToLower() &&
                   v.Id != selectedVehicle.Id
                   ).FirstOrDefault();
            }
            else
            {
                result = _vehicleRepository.GetMany(v =>
                   v.Status == (int)DbConstant.DefaultDataStatus.Active &&
                   v.Code.ToLower() == code.ToLower()
                   ).FirstOrDefault();
            }

            return result != null;
        }
    }
}
