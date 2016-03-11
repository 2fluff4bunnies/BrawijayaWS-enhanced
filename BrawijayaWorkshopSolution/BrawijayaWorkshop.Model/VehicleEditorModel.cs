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
        private IVehicleRepository _vehicleRepository;
        private IVehicleDetailRepository _vehicleDetailRepository;
        private IVehicleWheelRepository _vehicleWheelRepository;
        private IWheelDetailRepository _wheelDetailRepository;
        private ISparepartDetailRepository _sparepartDetailRepository;
        private IUnitOfWork _unitOfWork;

        public VehicleEditorModel(ICustomerRepository customerRepository, IVehicleRepository vehicleRepository,
           IVehicleDetailRepository vehicleDetailRepository, IVehicleWheelRepository vehicleWheelRepository,
            IWheelDetailRepository wheelDetailRepository, ISparepartDetailRepository sparepartDetailRepository, IUnitOfWork unitOfWork)
            : base()
        {
            _customerRepository = customerRepository;
            _vehicleRepository = vehicleRepository;
            _vehicleDetailRepository = vehicleDetailRepository;
            _vehicleWheelRepository = vehicleWheelRepository;
            _wheelDetailRepository = wheelDetailRepository;
            _sparepartDetailRepository = sparepartDetailRepository;
            _unitOfWork = unitOfWork;
        }

        public List<CustomerViewModel> GetCustomersList()
        {
            List<Customer> result = _customerRepository.GetAll().ToList();
            List<CustomerViewModel> mappedResult = new List<CustomerViewModel>();
            return Map(result, mappedResult);
        }

        public List<WheelDetailViewModel> RetrieveAllWheelDetails()
        {
            List<WheelDetail> result = _wheelDetailRepository.GetMany(wd => wd.Status == (int)DbConstant.WheelDetailStatus.Ready ||
                                                                            wd.Status == (int)DbConstant.WheelDetailStatus.Installed
                                                                      ).ToList();
            List<WheelDetailViewModel> mappedResult = new List<WheelDetailViewModel>();
            return Map(result, mappedResult);
        }

        public List<WheelDetailViewModel> RetrieveReadyWheelDetails()
        {
            List<WheelDetail> result = _wheelDetailRepository.GetMany(wd => wd.Status == (int)DbConstant.WheelDetailStatus.Ready).ToList();
            List<WheelDetailViewModel> mappedResult = new List<WheelDetailViewModel>();
            return Map(result, mappedResult);
        }

        public void InsertVehicle(VehicleViewModel vehicle, DateTime expirationDate,
             List<VehicleWheelViewModel> vehicleWheels, int userId)
        {
            DateTime serverTime = DateTime.Now;

            vehicle.CreateDate = serverTime;
            vehicle.CreateUserId = userId;
            vehicle.ModifyDate = serverTime;
            vehicle.ModifyUserId = userId;
            vehicle.Status = (int)DbConstant.DefaultDataStatus.Active;
            Vehicle entity = new Vehicle();
            Map(vehicle, entity);

            var insertedVehicle = _vehicleRepository.Add(entity);

            VehicleDetail vehicleDetail = new VehicleDetail
            {
                VehicleId = insertedVehicle.Id,
                LicenseNumber = insertedVehicle.ActiveLicenseNumber,
                ExpirationDate = expirationDate,
                CreateDate = serverTime,
                ModifyDate = serverTime,
                ModifyUserId = userId,
                CreateUserId = userId,
                Status = (int)DbConstant.LicenseNumberStatus.Active
            };

            foreach (var vw in vehicleWheels)
            {
                vw.CreateDate = serverTime;
                vw.CreateUserId = userId;
                vw.ModifyDate = serverTime;
                vw.ModifyUserId = userId;
                vw.Status = (int)DbConstant.DefaultDataStatus.Active;
                VehicleWheel vwEntity = new VehicleWheel();
                Map(vw, vwEntity);
                vwEntity.Vehicle = insertedVehicle;

                _vehicleWheelRepository.Add(vwEntity);

                WheelDetail wdEntity = _wheelDetailRepository.GetById(vw.WheelDetailId);
                wdEntity.ModifyDate = serverTime;
                wdEntity.ModifyUserId = userId;
                wdEntity.Status = (int)DbConstant.WheelDetailStatus.Installed;

                _wheelDetailRepository.Update(wdEntity);

                SparepartDetail spdEntity = _sparepartDetailRepository.GetById(wdEntity.SparepartDetailId);
                spdEntity.ModifyDate = serverTime;
                spdEntity.ModifyUserId = userId;
                spdEntity.Status = (int)DbConstant.SparepartDetailDataStatus.OutInstalled;

                _sparepartDetailRepository.Update(spdEntity);
            }

            _vehicleDetailRepository.Add(vehicleDetail);

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

            foreach (var vw in vehicleWheels)
            {
                VehicleWheel vwEntity = _vehicleWheelRepository.GetById(vw.Id);
                vwEntity.ModifyDate = serverTime;
                vwEntity.ModifyUserId = userId;
                _vehicleWheelRepository.Update(vwEntity);
            }

            if (vehicleWheelExchanged.Count > 0)
            {
                foreach (var vw in vehicleWheelExchanged)
                {
                    VehicleWheel vwEntity = _vehicleWheelRepository.GetById(vw.Id);
                    vwEntity.ModifyDate = serverTime;
                    vwEntity.ModifyUserId = userId;
                    _vehicleWheelRepository.Update(vwEntity);
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
    }
}
