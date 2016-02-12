using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Infrastructure.Repository;

namespace BrawijayaWorkshop.Database.Repositories
{
    public class UsedGoodsTransactionRepository : AppBaseRepository<UsedGoodsTransaction>, IUsedGoodsTransactionRepository
    {
        public UsedGoodsTransactionRepository(IDatabaseFactory<BrawijayaWorkshopDbContext> databaseFactory)
            : base(databaseFactory) { }
    }

    public interface IUsedGoodsTransactionRepository : IRepository<UsedGoodsTransaction, BrawijayaWorkshopDbContext>
    {
    }
}
