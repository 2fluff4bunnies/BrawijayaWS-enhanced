using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Database.Repositories;
using BrawijayaWorkshop.Infrastructure.Repository;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace BrawijayaWorkshop.Model
{
    public class CustomerListModel : AppBaseModel
    {
        private ICustomerRepository _customerRepository;
        private IUnitOfWork _unitOfWork;

        public CustomerListModel(ICustomerRepository customerRepository, IUnitOfWork unitOfWork)
            : base()
        {
            _customerRepository = customerRepository;
            _unitOfWork = unitOfWork;
        }

        public List<CustomerViewModel> SearchCustomer(string companyName)
        {
            List<Customer> result = _customerRepository.GetMany(c => c.CompanyName.Contains(companyName) &&
                c.Status == (int)DbConstant.DefaultDataStatus.Active).OrderBy(c => c.CompanyName).AsQueryable().Include(c => c.City).ToList();
            List<CustomerViewModel> mappedResult = new List<CustomerViewModel>();
            return Map(result, mappedResult);
        }

        public void DeleteCustomer(CustomerViewModel customer, int userId)
        {
            Customer selectedCustomer = _customerRepository.GetById<int>(customer.Id);
            selectedCustomer.Status = (int)DbConstant.DefaultDataStatus.Deleted;
            selectedCustomer.ModifyUserId = userId;
            selectedCustomer.ModifyDate = DateTime.Now;
            _unitOfWork.SaveChanges();
        }
    }
}
