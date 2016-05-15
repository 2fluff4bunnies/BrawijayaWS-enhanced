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
        private IUnitOfWork _unitOfWork;

        public VehicleGroupEditorModel(ICustomerRepository customerRepository,
            IVehicleGroupRepository vehicleGroupRepository, IUnitOfWork unitOfWork)
            : base()
        {
            _customerRepository = customerRepository;
            _vehicleGroupRepository = vehicleGroupRepository;
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
                    VehicleGroup entity = _vehicleGroupRepository.GetById(vehicleGroup.Id);
                    Map(vehicleGroup, entity);
                    _vehicleGroupRepository.AttachNavigation<Customer>(entity.Customer);
                    entity.ModifyUserId = userId;
                    entity.ModifyDate = DateTime.Now;
                    _vehicleGroupRepository.Update(entity);
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
    }
}
