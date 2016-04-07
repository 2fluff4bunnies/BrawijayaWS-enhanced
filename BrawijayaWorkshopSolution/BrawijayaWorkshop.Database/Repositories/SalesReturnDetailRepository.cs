using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Infrastructure.Repository;

namespace BrawijayaWorkshop.Database.Repositories
{
    public class SalesReturnDetailRepository : AppBaseRepository<SalesReturnDetail>, ISalesReturnDetailRepository
    {
        public SalesReturnDetailRepository(IDatabaseFactory<BrawijayaWorkshopDbContext> databaseFactory)
            : base(databaseFactory) { }
    }

    public interface ISalesReturnDetailRepository : IRepository<SalesReturnDetail, BrawijayaWorkshopDbContext>
    {
    }
}
