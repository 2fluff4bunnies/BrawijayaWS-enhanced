using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Database.Repositories;
using BrawijayaWorkshop.Infrastructure.MVP;
using System.Collections.Generic;
using System.Linq;

namespace BrawijayaWorkshop.Model
{
    public class CustomerEditorModel : BaseModel
    {
        private ICustomerRepository _customerRepository;
        private ICityRepository _cityRepository;

        public CustomerEditorModel(ICustomerRepository customerRepository, ICityRepository cityRepository)
        {
            _customerRepository = customerRepository;
            _cityRepository = cityRepository;
        }

        public List<City> RetrieveCity()
        {
            return _cityRepository.GetAll().ToList();
        }

        public void InsertCustomer(Customer customer)
        {
            _customerRepository.Add(customer);
        }

        public void UpdateCustomer(Customer customer)
        {
            _customerRepository.Update(customer);
        }
    }
}
