using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Database.Repositories;
using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Infrastructure.Repository;
using System.Collections.Generic;
using System.Linq;

namespace BrawijayaWorkshop.Model
{
    public class SupplierEditorModel : BaseModel
    {
        private ISupplierRepository _SupplierRepository;
        private IUnitOfWork _unitOfWork;

        public SupplierEditorModel(ISupplierRepository SupplierRepository, IUnitOfWork unitOfWork)
        {
            _SupplierRepository = SupplierRepository;
            _unitOfWork = unitOfWork;
        }

        public void InsertSupplier(Supplier Supplier)
        {
            _SupplierRepository.Add(Supplier);
            _unitOfWork.SaveChanges();
        }

        public void UpdateSupplier(Supplier Supplier)
        {
            _SupplierRepository.Update(Supplier);
            _unitOfWork.SaveChanges();
        }
    }
}
