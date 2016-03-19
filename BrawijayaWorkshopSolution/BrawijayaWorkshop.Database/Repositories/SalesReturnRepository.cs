using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Infrastructure.Repository;

namespace BrawijayaWorkshop.Database.Repositories
{
    public class SalesReturnRepositoryRepository : AppBaseRepository<SalesReturn>, ISalesReturnRepository
    {
        public SalesReturnRepositoryRepository(IDatabaseFactory<BrawijayaWorkshopDbContext> databaseFactory)
            : base(databaseFactory) { }
    }

    public interface ISalesReturnRepository : IRepository<SalesReturn, BrawijayaWorkshopDbContext>
    {
    }
}
