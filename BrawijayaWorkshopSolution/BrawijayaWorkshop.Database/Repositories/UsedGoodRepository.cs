using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Infrastructure.Repository;

namespace BrawijayaWorkshop.Database.Repositories
{
    public class UsedGoodRepository : AppBaseRepository<UsedGood>, IUsedGoodRepository
    {
        public UsedGoodRepository(IDatabaseFactory<BrawijayaWorkshopDbContext> databaseFactory)
            : base(databaseFactory) { }
    }

    public interface IUsedGoodRepository : IRepository<UsedGood, BrawijayaWorkshopDbContext>
    {
    }
}
