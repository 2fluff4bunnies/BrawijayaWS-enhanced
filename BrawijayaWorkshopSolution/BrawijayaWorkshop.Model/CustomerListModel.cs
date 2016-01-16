using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Database.Repositories;
using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Infrastructure.Repository;
using BrawijayaWorkshop.Model.Mappers;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace BrawijayaWorkshop.Model
{
    public class CustomerListModel : BaseModel
    {
        private ICustomerRepository _customerRepository;
        private IUnitOfWork _unitOfWork;

        public CustomerListModel(ICustomerRepository customerRepository, IUnitOfWork unitOfWork)
        {
            _customerRepository = customerRepository;
            _unitOfWork = unitOfWork;

            AutoMapperConfiguration.Configure();
        }

        public List<CustomerViewModel> SearchCustomer(string companyName)
        {
            List<Customer> result = _customerRepository.GetMany(c => c.CompanyName.Contains(companyName)).OrderBy(c => c.CompanyName).ToList();
            List<CustomerViewModel> mappedResult = new List<CustomerViewModel>();
            AutoMapper.Mapper.Map(result, mappedResult);
            return mappedResult;
        }

        public void DeleteCustomer(CustomerViewModel customer)
        {
            Customer selectedCustomer = _customerRepository.GetById<int>(customer.Id);
            _customerRepository.Delete(selectedCustomer);
            _unitOfWork.SaveChanges();
        }
    }
}
