using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Database.Repositories;
using BrawijayaWorkshop.Infrastructure.Repository;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace BrawijayaWorkshop.Model
{
    public class CustomerEditorModel : AppBaseModel
    {
        private ICustomerRepository _customerRepository;
        private ICityRepository _cityRepository;
        private IUnitOfWork _unitOfWork;

        public CustomerEditorModel(ICustomerRepository customerRepository, ICityRepository cityRepository,
            IUnitOfWork unitOfWork)
            : base()
        {
            _customerRepository = customerRepository;
            _cityRepository = cityRepository;
            _unitOfWork = unitOfWork;
        }

        public List<CityViewModel> RetrieveCity()
        {
            List<City> result = _cityRepository.GetAll().ToList();
            List<CityViewModel> mappedResult = new List<CityViewModel>();
            return Map(result, mappedResult);
        }

        public void InsertCustomer(CustomerViewModel customer)
        {
            Customer entity = new Customer();
            Map(customer, entity);
            _customerRepository.AttachNavigation<City>(entity.City);
            _customerRepository.Add(entity);
            _unitOfWork.SaveChanges();
        }

        public void UpdateCustomer(CustomerViewModel customer)
        {
            Customer entity = _customerRepository.GetById<int>(customer.Id);
            Map(customer, entity);
            _customerRepository.AttachNavigation<City>(entity.City);
            _customerRepository.Update(entity);
            _unitOfWork.SaveChanges();
        }
    }
}
