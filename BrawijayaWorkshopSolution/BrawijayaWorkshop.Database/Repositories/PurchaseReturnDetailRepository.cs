using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Infrastructure.Repository;

namespace BrawijayaWorkshop.Database.Repositories
{
    public class PurchaseReturnDetailRepository : AppBaseRepository<PurchaseReturnDetail>, IPurchaseReturnDetailRepository
    {
        public PurchaseReturnDetailRepository(IDatabaseFactory<BrawijayaWorkshopDbContext> databaseFactory)
            : base(databaseFactory) { }
    }

    public interface IPurchaseReturnDetailRepository : IRepository<PurchaseReturnDetail, BrawijayaWorkshopDbContext>
    {
    }
}
