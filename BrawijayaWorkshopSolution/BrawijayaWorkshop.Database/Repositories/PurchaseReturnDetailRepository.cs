using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Infrastructure.Repository;

namespace BrawijayaWorkshop.Database.Repositories
{
    public class PurchaseReturnDetailRepositoryRepository : AppBaseRepository<PurchaseReturnDetail>, IPurchaseReturnDetailRepository
    {
        public PurchaseReturnDetailRepositoryRepository(IDatabaseFactory<BrawijayaWorkshopDbContext> databaseFactory)
            : base(databaseFactory) { }
    }

    public interface IPurchaseReturnDetailRepository : IRepository<PurchaseReturnDetail, BrawijayaWorkshopDbContext>
    {
    }
}
