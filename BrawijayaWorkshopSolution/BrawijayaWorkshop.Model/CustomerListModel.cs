using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Database.Repositories;
using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Infrastructure.Repository;
using System.Collections.Generic;
using System.Linq;

namespace BrawijayaWorkshop.Model
{
    public class CustomerListModel : BaseModel
    {
        private ICustomerRepository _customerRepository;
        private IUnitOfWork _unitOfWork;

        public CustomerListModel(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
            _unitOfWork = new AppUnitOfWork(_customerRepository.DatabaseFactory);
        }

        public List<Customer> SearchCustomer(string companyName)
        {
            return _customerRepository.GetMany(c => c.CompanyName.Contains(companyName)).OrderBy(c => c.CompanyName).ToList();
        }

        public void DeleteCustomer(Customer customer)
        {
            _customerRepository.Delete(customer);
            _unitOfWork.SaveChanges();
        }
    }
}
