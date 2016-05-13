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
    public class SupplierEditorModel : AppBaseModel
    {
        private ISupplierRepository _supplierRepository;
        private ICityRepository _cityRepository;
        private IUnitOfWork _unitOfWork;

        public SupplierEditorModel(ISupplierRepository supplierRepository, ICityRepository cityRepository, IUnitOfWork unitOfWork)
            : base()
        {
            _supplierRepository = supplierRepository;
            _cityRepository = cityRepository;
            _unitOfWork = unitOfWork;
        }

        public void InsertSupplier(SupplierViewModel supplier, int userId)
        {
            Supplier entity = new Supplier();
            Map(supplier, entity);
            _supplierRepository.AttachNavigation(entity.City);
            entity.CreateUserId = entity.ModifyUserId = userId;
            entity.CreateDate = entity.ModifyDate = DateTime.Now;
            entity.Status = (int)DbConstant.DefaultDataStatus.Active;
            _supplierRepository.Add(entity);
            _unitOfWork.SaveChanges();
        }

        public List<CityViewModel> RetrieveCity()
        {
            List<City> result = _cityRepository.GetAll().ToList();
            List<CityViewModel> mappedResult = new List<CityViewModel>();
            return Map(result, mappedResult);
        }

        public void UpdateSupplier(SupplierViewModel supplier, int userId)
        {
            Supplier entity = _supplierRepository.GetById(supplier.Id);
            Map(supplier, entity);
            _supplierRepository.AttachNavigation(entity.City);
            entity.ModifyDate = DateTime.Now;
            entity.ModifyUserId = userId;
            _supplierRepository.Update(entity);
            _unitOfWork.SaveChanges();
        }
    }
}
