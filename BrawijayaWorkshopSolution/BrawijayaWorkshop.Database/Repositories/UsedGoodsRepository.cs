using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Infrastructure.Repository;

namespace BrawijayaWorkshop.Database.Repositories
{
    public class UsedGoodsRepository : AppBaseRepository<UsedGoods>, IUsedGoodsRepository
    {
        public UsedGoodsRepository(IDatabaseFactory<BrawijayaWorkshopDbContext> databaseFactory)
            : base(databaseFactory) { }
    }

    public interface IUsedGoodsRepository : IRepository<UsedGoods, BrawijayaWorkshopDbContext>
    {
    }
}
