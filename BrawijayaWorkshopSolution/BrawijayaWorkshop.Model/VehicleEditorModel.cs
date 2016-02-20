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
        private IUnitOfWork _unitOfWork;

        public VehicleEditorModel(ICustomerRepository customerRepository, IVehicleRepository vehicleRepository,
           IVehicleDetailRepository vehicleDetailRepository, IUnitOfWork unitOfWork) : base()
        {
            _customerRepository = customerRepository;
            _vehicleRepository = vehicleRepository;
            _vehicleDetailRepository = vehicleDetailRepository;
            _unitOfWork = unitOfWork;
        }

        public List<CustomerViewModel> RetrieveCustomer()
        {
            List<Customer> result = _customerRepository.GetAll().ToList();
            List<CustomerViewModel> mappedResult = new List<CustomerViewModel>();
            return Map(result, mappedResult);
        }

        public void InsertVehicle(VehicleViewModel vehicle, DateTime expirationDate, int userId)
        {
            DateTime serverTime = DateTime.Now;

            vehicle.CreateDate = serverTime;
            vehicle.CreateUserId = userId;
            vehicle.ModifyDate = serverTime;
            vehicle.ModifyUserId = userId;
            vehicle.Status = (int)DbConstant.DefaultDataStatus.Active;
            Vehicle entity = new Vehicle();
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
                Status = (int)DbConstant.LicenseNumberStatus.Expired
            };

            _vehicleDetailRepository.Add(vehicleDetail);

            _unitOfWork.SaveChanges();
        }

        public void UpdateVehicle(VehicleViewModel vehicle, int userId)
        {
            DateTime serverTime = DateTime.Now;

            vehicle.ModifyDate = serverTime;
            vehicle.ModifyUserId = userId;
            Vehicle entity = _vehicleRepository.GetById(vehicle.Id);
            Map(vehicle, entity);
            _vehicleRepository.Update(entity);

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
    }
}
