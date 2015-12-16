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
    public class VehicleEditorModel : BaseModel
    {
        private ICustomerRepository _customerRepository;
        private IVehicleRepository _vehicleRepository;
        private IVehicleDetailRepository _vehicleDetailRepository;
        private IUnitOfWork _unitOfWork;

        public VehicleEditorModel(ICustomerRepository customerRepository, IVehicleRepository vehicleRepository,
           IVehicleDetailRepository vehicleDetailRepository, IUnitOfWork unitOfWork)
        {
            _customerRepository = customerRepository;
            _vehicleRepository = vehicleRepository;
            _vehicleDetailRepository = vehicleDetailRepository;
            _unitOfWork = unitOfWork;
        }

        public List<Customer> RetrieveCustomer()
        {
            return _customerRepository.GetAll().ToList();
        }

        public void InsertVehicle(Vehicle vehicle, DateTime expirationDate, int userId)
        {
            DateTime serverTime = DateTime.Now;

            vehicle.CreateDate = serverTime;
            vehicle.CreateUserId = userId;
            vehicle.ModifyDate = serverTime;
            vehicle.ModifyUserId = userId;
            vehicle.Status = (int)DbConstant.DefaultDataStatus.Active;

            var insertedVehicle = _vehicleRepository.Add(vehicle);

            VehicleDetail vehicleDetail = new VehicleDetail
            {
                VehicleId = insertedVehicle.Id,
                LicenseNumber = insertedVehicle.ActiveLicenseNumber,
                ExpirationDate = expirationDate,
                CreateDate = serverTime,
                ModifyDate = serverTime,
                ModifyUserId = userId,
                CreateUserId = userId,
                Status = (int)DbConstant.LicenseNumberStatus.Expired
            };

            _vehicleDetailRepository.Add(vehicleDetail);

            _unitOfWork.SaveChanges();
        }

        public void UpdateVehicle(Vehicle vehicle, int userId)
        {
            DateTime serverTime = DateTime.Now;

            vehicle.ModifyDate = serverTime;
            vehicle.ModifyUserId = userId;

            _vehicleRepository.Update(vehicle);

            _unitOfWork.SaveChanges();
        }

        public void DeleteVehicle(Vehicle vehicle, int userId)
        {
            DateTime serverTime = DateTime.Now;

            vehicle.ModifyDate = serverTime;
            vehicle.ModifyUserId = userId;
            vehicle.Status = (int)DbConstant.DefaultDataStatus.Deleted;

            _vehicleRepository.Update(vehicle);

            _unitOfWork.SaveChanges();
        }
    }
}
