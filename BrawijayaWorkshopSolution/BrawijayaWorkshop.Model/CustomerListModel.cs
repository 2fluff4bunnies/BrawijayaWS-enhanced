using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Database.Repositories;
using BrawijayaWorkshop.Infrastructure.Repository;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System.Collections.Generic;
using System.Linq;

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
            List<Customer> result = _customerRepository.GetMany(c => c.CompanyName.Contains(companyName)).OrderBy(c => c.CompanyName).ToList();
            List<CustomerViewModel> mappedResult = new List<CustomerViewModel>();
            return Map(result, mappedResult);
        }

        public void DeleteCustomer(CustomerViewModel customer)
        {
            Customer selectedCustomer = _customerRepository.GetById<int>(customer.Id);
            _customerRepository.Delete(selectedCustomer);
            _unitOfWork.SaveChanges();
        }
    }
}
