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

        public void InsertCustomer(CustomerViewModel customer, int userId)
        {
            using(var trans = _unitOfWork.BeginTransaction())
            {
                try
                {
                    Customer entity = new Customer();
                    Map(customer, entity);
                    _customerRepository.AttachNavigation<City>(entity.City);
                    entity.CreateUserId = entity.ModifyUserId = userId;
                    entity.CreateDate = entity.ModifyDate = DateTime.Now;
                    entity.Status = (int)DbConstant.DefaultDataStatus.Active;
                    _customerRepository.Add(entity);
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

        public void UpdateCustomer(CustomerViewModel customer, int userId)
        {
            Customer entity = _customerRepository.GetById<int>(customer.Id);
            Map(customer, entity);
            _customerRepository.AttachNavigation<City>(entity.City);
            entity.ModifyDate = DateTime.Now;
            entity.ModifyUserId = userId;
            _customerRepository.Update(entity);
            _unitOfWork.SaveChanges();
        }
    }
}
