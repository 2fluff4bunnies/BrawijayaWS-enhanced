using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Database.Repositories;
using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Infrastructure.Repository;
using BrawijayaWorkshop.SharedObject.ViewModels;
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
            _unitOfWork = unitOfWork;
        }

        public List<CityViewModel> RetrieveCity()
        {
            List<City> result = _cityRepository.GetAll().ToList();
            List<CityViewModel> mappedResult = new List<CityViewModel>();
            AutoMapper.Mapper.Map(result, mappedResult);
            return mappedResult;
        }

        public void InsertCustomer(CustomerViewModel customer)
        {
            Customer entity = new Customer();
            AutoMapper.Mapper.Map(customer, entity);
            _customerRepository.Add(entity);
            _unitOfWork.SaveChanges();
        }

        public void UpdateCustomer(CustomerViewModel customer)
        {
            Customer entity = _customerRepository.GetById<int>(customer.Id);
            AutoMapper.Mapper.Map(customer, entity);
            _customerRepository.Update(entity);
            _unitOfWork.SaveChanges();
        }
    }
}
