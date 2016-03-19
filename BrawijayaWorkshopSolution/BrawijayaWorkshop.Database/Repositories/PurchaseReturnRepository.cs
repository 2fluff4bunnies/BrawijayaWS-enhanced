using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Infrastructure.Repository;

namespace BrawijayaWorkshop.Database.Repositories
{
    public class PurchaseReturnRepositoryRepository : AppBaseRepository<PurchaseReturn>, IPurchaseReturnRepository
    {
        public PurchaseReturnRepositoryRepository(IDatabaseFactory<BrawijayaWorkshopDbContext> databaseFactory)
            : base(databaseFactory) { }
    }

    public interface IPurchaseReturnRepository : IRepository<PurchaseReturn, BrawijayaWorkshopDbContext>
    {
    }
}
