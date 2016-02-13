using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Infrastructure.Repository;

namespace BrawijayaWorkshop.Database.Repositories
{
    public class UsedGoodsRepository : AppBaseRepository<UsedGood>, IUsedGoodsRepository
    {
        public UsedGoodsRepository(IDatabaseFactory<BrawijayaWorkshopDbContext> databaseFactory)
            : base(databaseFactory) { }
    }

    public interface IUsedGoodsRepository : IRepository<UsedGood, BrawijayaWorkshopDbContext>
    {
    }
}
