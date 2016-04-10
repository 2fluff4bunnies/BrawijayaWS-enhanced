using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Database.Repositories;
using BrawijayaWorkshop.Infrastructure.Repository;
using BrawijayaWorkshop.SharedObject.ViewModels;
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

        public void InsertSupplier(SupplierViewModel supplier)
        {
            Supplier entity = new Supplier();
            Map(supplier, entity);
            _supplierRepository.AttachNavigation(entity.City);
            _supplierRepository.Add(entity);
            _unitOfWork.SaveChanges();
        }

        public List<CityViewModel> RetrieveCity()
        {
            List<City> result = _cityRepository.GetAll().ToList();
            List<CityViewModel> mappedResult = new List<CityViewModel>();
            return Map(result, mappedResult);
        }

        public void UpdateSupplier(SupplierViewModel supplier)
        {
            Supplier entity = _supplierRepository.GetById(supplier.Id);
            Map(supplier, entity);
            _supplierRepository.AttachNavigation(entity.City);
            _supplierRepository.Update(entity);
            _unitOfWork.SaveChanges();
        }
    }
}
