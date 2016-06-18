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
    public class VehicleListModel : AppBaseModel
    {
        private IVehicleRepository _vehicleRepository;
        private IVehicleWheelRepository _vehicleWheelRepository;
        private IUsedGoodRepository _usedGoodRepository;
        private ISpecialSparepartDetailRepository _specialSparepartDetailRepository;
        private ISparepartRepository _sparepartRepository;
        private ISparepartDetailRepository _sparepartDetailRepository;
        private IUnitOfWork _unitOfWork;

        public VehicleListModel(IVehicleRepository vehicleRepository, 
            IVehicleWheelRepository vehicleWheelRepository, 
            IUsedGoodRepository usedGoodRepository,
            ISparepartRepository sparepartRepository, 
            ISparepartDetailRepository sparepartDetailRepository,
            ISpecialSparepartDetailRepository specialSparepartDetailRepository,
            IUnitOfWork unitOfWork)
            : base()
        {
            _vehicleRepository = vehicleRepository;
            _vehicleWheelRepository = vehicleWheelRepository;
            _usedGoodRepository = usedGoodRepository;
            _specialSparepartDetailRepository = specialSparepartDetailRepository;
            _sparepartDetailRepository = sparepartDetailRepository;
            _sparepartRepository = sparepartRepository;
            _unitOfWork = unitOfWork;
        }

        public List<VehicleViewModel> SearchVehicle(string licenseNumber)
        {
            List<Vehicle> result = _vehicleRepository.GetMany(v => v.ActiveLicenseNumber.Contains(licenseNumber) &&
                v.Status == (int)DbConstant.DefaultDataStatus.Active).OrderBy(c => c.VehicleGroupId).ToList();
            List<VehicleViewModel> mappedResult = new List<VehicleViewModel>();
            return Map(result, mappedResult);
        }

        public void DeleteVehicle(VehicleViewModel vehicle, int userId)
        {
            DateTime serverTime = DateTime.Now;

            vehicle.ModifyDate = serverTime;
            vehicle.ModifyUserId = userId;
            vehicle.Status = (int)DbConstant.DefaultDataStatus.Deleted;
            Vehicle entity = _vehicleRepository.GetById(vehicle.Id);
            Map(vehicle, entity);

            _vehicleRepository.AttachNavigation(entity.Brand);
            _vehicleRepository.AttachNavigation(entity.Type);
            _vehicleRepository.AttachNavigation(entity.VehicleGroup);
            _vehicleRepository.AttachNavigation(entity.Customer);
            _vehicleRepository.AttachNavigation(entity.CreateUser);
            _vehicleRepository.AttachNavigation(entity.ModifyUser);
            _vehicleRepository.Update(entity);
            _unitOfWork.SaveChanges();

            foreach (var item in _vehicleWheelRepository.GetMany(vw => vw.VehicleId == vehicle.Id && vw.Status ==(int) DbConstant.DefaultDataStatus.Active))
            {
                item.ModifyDate = serverTime;
                item.ModifyUserId = userId;
                item.Status = (int)DbConstant.DefaultDataStatus.Deleted;

                _vehicleWheelRepository.AttachNavigation(item.Vehicle);
                _vehicleWheelRepository.AttachNavigation(item.WheelDetail);
                _vehicleWheelRepository.AttachNavigation(item.CreateUser);
                _vehicleWheelRepository.AttachNavigation(item.ModifyUser);
                _vehicleWheelRepository.Update(item);
                _unitOfWork.SaveChanges();

                SpecialSparepartDetail wdEntity = _specialSparepartDetailRepository.GetById(item.WheelDetailId);
                wdEntity.ModifyDate = serverTime;
                wdEntity.ModifyUserId = userId;
                wdEntity.Status = (int)DbConstant.WheelDetailStatus.Ready;

                _specialSparepartDetailRepository.AttachNavigation(wdEntity.SpecialSparepart);
                _specialSparepartDetailRepository.AttachNavigation(wdEntity.SparepartDetail);
                _specialSparepartDetailRepository.AttachNavigation(wdEntity.CreateUser);
                _specialSparepartDetailRepository.AttachNavigation(wdEntity.ModifyUser);
                _specialSparepartDetailRepository.Update(wdEntity);
                _unitOfWork.SaveChanges();

                SparepartDetail spdEntity = _sparepartDetailRepository.GetById(wdEntity.SparepartDetailId);
                spdEntity.ModifyDate = serverTime;
                spdEntity.ModifyUserId = userId;
                spdEntity.Status = (int)DbConstant.SparepartDetailDataStatus.Active;

                _sparepartDetailRepository.AttachNavigation(spdEntity.Sparepart);
                _sparepartDetailRepository.AttachNavigation(spdEntity.SparepartManualTransaction);
                _sparepartDetailRepository.AttachNavigation(spdEntity.PurchasingDetail);
                _sparepartDetailRepository.AttachNavigation(spdEntity.CreateUser);
                _sparepartDetailRepository.AttachNavigation(spdEntity.ModifyUser);
                _sparepartDetailRepository.Update(spdEntity);
                _unitOfWork.SaveChanges();

                Sparepart spEntity = _sparepartRepository.GetById(wdEntity.SparepartDetail.SparepartId);
                spEntity.ModifyDate = serverTime;
                spEntity.ModifyUserId = userId;
                spEntity.StockQty = spEntity.StockQty + 1;

                _sparepartRepository.AttachNavigation(spEntity.UnitReference);
                _sparepartRepository.AttachNavigation(spEntity.CategoryReference);
                _sparepartRepository.AttachNavigation(spEntity.CreateUser);
                _sparepartRepository.AttachNavigation(spEntity.ModifyUser);
                _sparepartRepository.Update(spEntity);
                _unitOfWork.SaveChanges();
            }

            
        }
    }
}
