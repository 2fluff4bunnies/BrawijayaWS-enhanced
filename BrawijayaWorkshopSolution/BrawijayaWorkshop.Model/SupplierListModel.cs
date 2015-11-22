using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Database.Repositories;
using BrawijayaWorkshop.Infrastructure.MVP;
using System.Collections.Generic;
using System.Linq;

namespace BrawijayaWorkshop.Model
{
    public class SupplierListModel : BaseModel
    {
        private ISupplierRepository _SupplierRepository;

        public SupplierListModel(ISupplierRepository SupplierRepository)
        {
            _SupplierRepository = SupplierRepository;
        }

        public List<Supplier> SearchSupplier(string supplierName)
        {
            return _SupplierRepository.GetMany(c => c.Name.Contains(supplierName)).OrderBy(c => c.Name).ToList();
        }

        public void DeleteSupplier(Supplier Supplier)
        {
            _SupplierRepository.Delete(Supplier);
        }
    }
}
