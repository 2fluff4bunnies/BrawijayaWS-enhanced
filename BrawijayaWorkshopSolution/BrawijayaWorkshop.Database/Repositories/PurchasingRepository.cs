using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Infrastructure.Repository;

namespace BrawijayaWorkshop.Database.Repositories
{
    public class PurchasingRepository : AppBaseRepository<Purchasing>, IPurchasingRepository
    {
        public PurchasingRepository(IDatabaseFactory<BrawijayaWorkshopDbContext> databaseFactory)
            : base(databaseFactory) { }
    }

    public interface IPurchasingRepository : IRepository<Purchasing, BrawijayaWorkshopDbContext>
    {
    }
}
