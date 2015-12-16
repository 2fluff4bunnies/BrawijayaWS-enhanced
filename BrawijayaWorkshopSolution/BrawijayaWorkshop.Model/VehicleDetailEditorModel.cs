using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Database.Repositories;
using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BrawijayaWorkshop.Model
{
    public class VehicleDetailEditorModel : BaseModel
    {
        private IVehicleRepository _vehicleRepository;
        private IVehicleDetailRepository _vehicleDetailRepository;
        private IReferenceRepository _referenceRepository;
        private IUnitOfWork _unitOfWork;

        public VehicleDetailEditorModel(IVehicleRepository vehicleRepository, IReferenceRepository referenceRepository,
            IVehicleDetailRepository vehicleDetailRepository, IUnitOfWork unitOfWork)
        {
            _vehicleRepository = vehicleRepository;
            _vehicleDetailRepository = vehicleDetailRepository;
            _referenceRepository = referenceRepository;
            _unitOfWork = unitOfWork;
        }

        public void UpdateVehicleDetail(VehicleDetail vehicleDetail, Vehicle vehicle, int userId)
        {
            DateTime serverTime = DateTime.Now;

            //set current active detail to expired if any
            VehicleDetail toBeExpired = _vehicleDetailRepository.GetMany(vd => vd.Status == (int)DbConstant.LicenseNumberStatus.Active).FirstOrDefault();
            if (toBeExpired != null)
            {
                toBeExpired.ModifyDate = serverTime;
                toBeExpired.ModifyUserId = userId;
                toBeExpired.Status = (int)DbConstant.LicenseNumberStatus.Expired;
                _vehicleDetailRepository.Update(toBeExpired);
            }

            //insert new detail as active detail
            vehicleDetail.CreateDate = serverTime;
            vehicleDetail.CreateUserId = userId;
            vehicleDetail.ModifyUserId = userId;
            vehicleDetail.VehicleId = vehicle.Id;
            vehicleDetail.Status = (int)DbConstant.LicenseNumberStatus.Active;
            _vehicleDetailRepository.Add(vehicleDetail);

            //update active license number in vehicle
            if (vehicle != null)
            {
                vehicle.ModifyDate = serverTime;
                vehicle.ModifyUserId = userId;
                vehicle.ActiveLicenseNumber = vehicleDetail.LicenseNumber;
                _vehicleRepository.Update(vehicle);
            }

            _unitOfWork.SaveChanges();
        }

    }
}
