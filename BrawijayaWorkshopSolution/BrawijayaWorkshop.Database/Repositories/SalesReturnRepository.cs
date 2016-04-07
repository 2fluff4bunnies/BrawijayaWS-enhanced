using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Infrastructure.Repository;

namespace BrawijayaWorkshop.Database.Repositories
{
    public class SalesReturnRepository : AppBaseRepository<SalesReturn>, ISalesReturnRepository
    {
        public SalesReturnRepository(IDatabaseFactory<BrawijayaWorkshopDbContext> databaseFactory)
            : base(databaseFactory) { }
    }

    public interface ISalesReturnRepository : IRepository<SalesReturn, BrawijayaWorkshopDbContext>
    {
    }
}
