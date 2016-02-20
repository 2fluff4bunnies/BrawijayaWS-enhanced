using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Database.Repositories;
using BrawijayaWorkshop.Infrastructure.Repository;
using BrawijayaWorkshop.SharedObject.ViewModels;

namespace BrawijayaWorkshop.Model
{
    public class SupplierEditorModel : AppBaseModel
    {
        private ISupplierRepository _supplierRepository;
        private IUnitOfWork _unitOfWork;

        public SupplierEditorModel(ISupplierRepository supplierRepository, IUnitOfWork unitOfWork)
            : base()
        {
            _supplierRepository = supplierRepository;
            _unitOfWork = unitOfWork;
        }

        public void InsertSupplier(SupplierViewModel supplier)
        {
            Supplier entity = new Supplier();
            Map(supplier, entity);
            _supplierRepository.Add(entity);
            _unitOfWork.SaveChanges();
        }

        public void UpdateSupplier(SupplierViewModel supplier)
        {
            Supplier entity = _supplierRepository.GetById(supplier.Id);
            Map(supplier, entity);
            _supplierRepository.Update(entity);
            _unitOfWork.SaveChanges();
        }
    }
}
