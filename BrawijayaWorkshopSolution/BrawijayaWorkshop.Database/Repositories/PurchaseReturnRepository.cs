using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Infrastructure.Repository;

namespace BrawijayaWorkshop.Database.Repositories
{
    public class PurchaseReturnRepository : AppBaseRepository<PurchaseReturn>, IPurchaseReturnRepository
    {
        public PurchaseReturnRepository(IDatabaseFactory<BrawijayaWorkshopDbContext> databaseFactory)
            : base(databaseFactory) { }
    }

    public interface IPurchaseReturnRepository : IRepository<PurchaseReturn, BrawijayaWorkshopDbContext>
    {
    }
}
