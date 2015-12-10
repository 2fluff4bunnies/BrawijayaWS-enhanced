using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Database.Repositories;
using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Infrastructure.Repository;
using System;
using System.Collections.Generic;

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

        public void InsertVehicleDetail(VehicleDetail vehicleDetail, int userId)
        {
            DateTime serverTime = DateTime.Now;
            vehicleDetail.CreateDate = serverTime;
            vehicleDetail.CreateUserId = userId;
            _vehicleDetailRepository.Add(vehicleDetail);
            _unitOfWork.SaveChanges();
        }

        public void UpdateVehicleDetail(VehicleDetail vehicleDetail, int userId)
        {
            DateTime serverTime = DateTime.Now;
            vehicleDetail.ModifyDate = serverTime;
            vehicleDetail.ModifyUserId = userId;
            _vehicleDetailRepository.Update(vehicleDetail);
            _unitOfWork.SaveChanges();
        }
    }
}
