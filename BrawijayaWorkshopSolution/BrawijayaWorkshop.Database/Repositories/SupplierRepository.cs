using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Infrastructure.Repository;

namespace BrawijayaWorkshop.Database.Repositories
{
    public class SupplierRepository : AppBaseRepository<Supplier>, ISupplierRepository
    {
        public SupplierRepository(IDatabaseFactory<BrawijayaWorkshopDbContext> databaseFactory)
            : base(databaseFactory) { }
    }

    public interface ISupplierRepository : IRepository<Supplier>
    {
    }
}
