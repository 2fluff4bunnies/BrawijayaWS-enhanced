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
    public class VehicleGroupEditorModel : AppBaseModel
    {
        private ICustomerRepository _customerRepository;
        private IVehicleGroupRepository _vehicleGroupRepository;
        private IVehicleRepository _vehicleRepository;
        private IUnitOfWork _unitOfWork;

        public VehicleGroupEditorModel(ICustomerRepository customerRepository, IVehicleRepository vehicleRepository,
            IVehicleGroupRepository vehicleGroupRepository, IUnitOfWork unitOfWork)
            : base()
        {
            _customerRepository = customerRepository;
            _vehicleGroupRepository = vehicleGroupRepository;
            _vehicleRepository = vehicleRepository;
            _unitOfWork = unitOfWork;
        }

        public List<CustomerViewModel> RetrieveAllCustomer()
        {
            List<Customer> result = _customerRepository.GetMany(c => c.Status == (int)DbConstant.DefaultDataStatus.Active).ToList();
            List<CustomerViewModel> mappedResult = new List<CustomerViewModel>();
            return Map(result, mappedResult);
        }

        public void InsertNewGroup(VehicleGroupViewModel vehicleGroup, int userId)
        {
            using (var trans = _unitOfWork.BeginTransaction())
            {
                try
                {
                    VehicleGroup entity = new VehicleGroup();
                    Map(vehicleGroup, entity);
                    _vehicleGroupRepository.AttachNavigation<Customer>(entity.Customer);
                    entity.CreateUserId = entity.ModifyUserId = userId;
                    entity.CreateDate = entity.ModifyDate = DateTime.Now;
                    entity.Status = (int)DbConstant.DefaultDataStatus.Active;
                    _vehicleGroupRepository.Add(entity);
                    _unitOfWork.SaveChanges();

                    trans.Commit();
                }
                catch (System.Exception ex)
                {
                    trans.Rollback();
                    throw ex;
                }
            }
        }

        public void UpdateGroup(VehicleGroupViewModel vehicleGroup, int userId)
        {
            using (var trans = _unitOfWork.BeginTransaction())
            {
                try
                {
                    // insert new group
                    VehicleGroup entity = new VehicleGroup();
                    Map(vehicleGroup, entity);
                    _vehicleGroupRepository.AttachNavigation<Customer>(entity.Customer);
                    entity.Id = 0;
                    entity.CreateUserId = entity.ModifyUserId = userId;
                    entity.CreateDate = entity.ModifyDate = DateTime.Now;
                    entity.ModifyUserId = entity.ModifyUserId = userId;
                    entity.ModifyDate = entity.ModifyDate = DateTime.Now;
                    entity.Status = (int)DbConstant.DefaultDataStatus.Active;
                    VehicleGroup insertedVehicleGroup = _vehicleGroupRepository.Add(entity);
                    _unitOfWork.SaveChanges();
                  
                    // update last group status to deleted
                    _vehicleGroupRepository.AttachNavigation<Customer>(entity.Customer);
                    entity = _vehicleGroupRepository.GetById(vehicleGroup.Id);
                    entity.Status = (int)DbConstant.DefaultDataStatus.Deleted;
                    _vehicleGroupRepository.Update(entity);
                    _unitOfWork.SaveChanges();

                    //update all vehicle to new group
                    foreach (var vehicle in _vehicleRepository.GetMany(v => v.VehicleGroupId == vehicleGroup.Id && v.Status == (int) DbConstant.DefaultDataStatus.Active))
                    {
                        _vehicleRepository.AttachNavigation<Customer>(vehicle.Customer);
                        _vehicleRepository.AttachNavigation<Brand>(vehicle.Brand);
                        _vehicleRepository.AttachNavigation<BrawijayaWorkshop.Database.Entities.Type>(vehicle.Type);
                        _vehicleRepository.AttachNavigation<VehicleGroup>(vehicle.VehicleGroup);
                        vehicle.VehicleGroup = insertedVehicleGroup;
                        vehicle.ModifyUserId = entity.ModifyUserId = userId;
                        vehicle.ModifyDate = entity.ModifyDate = DateTime.Now;

                        _vehicleRepository.Update(vehicle);
                        _unitOfWork.SaveChanges();
                    }

                    trans.Commit();
                }
                catch (System.Exception ex)
                {
                    trans.Rollback();
                    throw ex;
                }
            }
        }
    }
}
