using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Infrastructure.Repository;

namespace BrawijayaWorkshop.Database.Repositories
{
    public class SalesReturnDetailRepositoryRepository : AppBaseRepository<SalesReturnDetail>, ISalesReturnDetailRepository
    {
        public SalesReturnDetailRepositoryRepository(IDatabaseFactory<BrawijayaWorkshopDbContext> databaseFactory)
            : base(databaseFactory) { }
    }

    public interface ISalesReturnDetailRepository : IRepository<SalesReturnDetail, BrawijayaWorkshopDbContext>
    {
    }
}
