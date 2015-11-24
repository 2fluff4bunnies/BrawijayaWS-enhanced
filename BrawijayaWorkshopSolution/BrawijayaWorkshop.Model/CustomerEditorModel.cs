using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Database.Repositories;
using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Infrastructure.Repository;
using System.Collections.Generic;
using System.Linq;

namespace BrawijayaWorkshop.Model
{
    public class CustomerEditorModel : BaseModel
    {
        private ICustomerRepository _customerRepository;
        private ICityRepository _cityRepository;
        private IUnitOfWork _unitOfWork;

        public CustomerEditorModel(ICustomerRepository customerRepository, ICityRepository cityRepository,
            IUnitOfWork unitOfWork)
        {
            _customerRepository = customerRepository;
            _cityRepository = cityRepository;
            _unitOfWork = _unitOfWork;
        }

        public List<City> RetrieveCity()
        {
            return _cityRepository.GetAll().ToList();
        }

        public void InsertCustomer(Customer customer)
        {
            _customerRepository.Add(customer);
            _unitOfWork.SaveChanges();
        }

        public void UpdateCustomer(Customer customer)
        {
            _customerRepository.Update(customer);
            _unitOfWork.SaveChanges();
        }
    }
}
