using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Database.Repositories;
using BrawijayaWorkshop.Infrastructure.Repository;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System;
using System.Linq;

namespace BrawijayaWorkshop.Model
{
    public class VehicleDetailEditorModel : AppBaseModel
    {
        private IVehicleRepository _vehicleRepository;
        private IVehicleDetailRepository _vehicleDetailRepository;
        private IReferenceRepository _referenceRepository;
        private IUnitOfWork _unitOfWork;

        public VehicleDetailEditorModel(IVehicleRepository vehicleRepository, IReferenceRepository referenceRepository,
            IVehicleDetailRepository vehicleDetailRepository, IUnitOfWork unitOfWork)
            : base()
        {
            _vehicleRepository = vehicleRepository;
            _vehicleDetailRepository = vehicleDetailRepository;
            _referenceRepository = referenceRepository;
            _unitOfWork = unitOfWork;
        }

        public void UpdateVehicleDetail(VehicleDetailViewModel vehicleDetail, VehicleViewModel vehicle, int userId)
        {
            DateTime serverTime = DateTime.Now;

            //set current active detail to expired if any
            VehicleDetail toBeExpired = _vehicleDetailRepository.GetMany(vd => vd.Status == (int)DbConstant.LicenseNumberStatus.Active).FirstOrDefault();
            if (toBeExpired != null)
            {
                toBeExpired.ModifyDate = serverTime;
                toBeExpired.ModifyUserId = userId;
                toBeExpired.Status = (int)DbConstant.LicenseNumberStatus.Expired;

                _vehicleDetailRepository.AttachNavigation<Vehicle>(toBeExpired.Vehicle);
                _vehicleDetailRepository.Update(toBeExpired);
                _unitOfWork.SaveChanges();
            }

            //insert new detail as active detail
            vehicleDetail.CreateDate = serverTime;
            vehicleDetail.CreateUserId = userId;
            vehicleDetail.ModifyUserId = userId;
            vehicleDetail.VehicleId = vehicle.Id;
            vehicleDetail.Status = (int)DbConstant.LicenseNumberStatus.Active;
            VehicleDetail entityDetail = new VehicleDetail();

            Map(vehicleDetail, entityDetail);

            _vehicleDetailRepository.AttachNavigation<Vehicle>(entityDetail.Vehicle);
            _vehicleDetailRepository.Add(entityDetail);
            _unitOfWork.SaveChanges();

            //update active license number in vehicle
            if (vehicle != null)
            {
                vehicle.ModifyDate = serverTime;
                vehicle.ModifyUserId = userId;
                vehicle.ActiveLicenseNumber = vehicleDetail.LicenseNumber;
                Vehicle entity = _vehicleRepository.GetById(vehicle.Id);
                Map(vehicle, entity);

                _vehicleRepository.AttachNavigation<Customer>(entity.Customer);
                _vehicleRepository.Update(entity);
                _unitOfWork.SaveChanges();
            }

            _unitOfWork.SaveChanges();
        }
    }
}
