using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Database.Repositories;
using BrawijayaWorkshop.Infrastructure.MVP;
using System.Collections.Generic;
using System.Linq;

namespace BrawijayaWorkshop.Model
{
    public class SupplierEditorModel : BaseModel
    {
        private ISupplierRepository _SupplierRepository;

        public SupplierEditorModel(ISupplierRepository SupplierRepository)
        {
            _SupplierRepository = SupplierRepository;
        }

        public void InsertSupplier(Supplier Supplier)
        {
            _SupplierRepository.Add(Supplier);
        }

        public void UpdateSupplier(Supplier Supplier)
        {
            _SupplierRepository.Update(Supplier);
        }
    }
}
