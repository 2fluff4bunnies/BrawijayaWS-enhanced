using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Infrastructure.Repository;

namespace BrawijayaWorkshop.Database.Repositories
{
    public class TransactionRepository : AppBaseRepository<Transaction>, ITransactionRepository
    {
        public TransactionRepository(IDatabaseFactory<BrawijayaWorkshopDbContext> databaseFactory)
            : base(databaseFactory) { }
    }

    public interface ITransactionRepository :  IRepository<Transaction, BrawijayaWorkshopDbContext>
    {
    }
}
