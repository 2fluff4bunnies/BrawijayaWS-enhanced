using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Infrastructure.Repository;

namespace BrawijayaWorkshop.Database.Repositories
{
    public class UsedGoodTransactionRepository : AppBaseRepository<UsedGoodTransaction>, IUsedGoodTransactionRepository
    {
        public UsedGoodTransactionRepository(IDatabaseFactory<BrawijayaWorkshopDbContext> databaseFactory)
            : base(databaseFactory) { }
    }

    public interface IUsedGoodTransactionRepository : IRepository<UsedGoodTransaction, BrawijayaWorkshopDbContext>
    {
    }
}
