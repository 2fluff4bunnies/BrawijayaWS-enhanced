using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Database.Repositories;
using BrawijayaWorkshop.Infrastructure.Repository;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BrawijayaWorkshop.Model
{
    public class VehicleGroupListModel : AppBaseModel
    {
        private ICustomerRepository _customerRepository;
        private IVehicleGroupRepository _vehicleGroupRepository;
        private IUnitOfWork _unitOfWork;

        public VehicleGroupListModel(ICustomerRepository customerRepository,
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

        public List<VehicleGroupViewModel> RetrieveVehicleGroup(int customerId, string name)
        {
            List<VehicleGroup> result = new List<VehicleGroup>();
            List<VehicleGroupViewModel> mappedResult = new List<VehicleGroupViewModel>();
            if(customerId > 0)
            {
                result = _vehicleGroupRepository.GetMany(vg =>
                    vg.Status == (int)BrawijayaWorkshop.Constant.DbConstant.DefaultDataStatus.Active &&
                    vg.CustomerId == customerId && vg.Name.Contains(name)).ToList();
            }
            else
            {
                result = _vehicleGroupRepository.GetMany(vg =>
                    vg.Status == (int)BrawijayaWorkshop.Constant.DbConstant.DefaultDataStatus.Active &&
                    vg.Name.Contains(name)).ToList();
            }

            return Map(result, mappedResult);
        }

        public void DeleteVehicleGroup(VehicleGroupViewModel selectedGroup, int userId)
        {
            using (var trans = _unitOfWork.BeginTransaction())
            {
                try
                {
                    VehicleGroup entity = _vehicleGroupRepository.GetById(selectedGroup.Id);
                    Map(selectedGroup, entity);
                    _vehicleGroupRepository.AttachNavigation<Customer>(entity.Customer);
                    entity.Status = (int)BrawijayaWorkshop.Constant.DbConstant.DefaultDataStatus.Deleted;
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
