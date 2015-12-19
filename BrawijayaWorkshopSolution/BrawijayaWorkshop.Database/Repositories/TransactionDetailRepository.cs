using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Infrastructure.Repository;

namespace BrawijayaWorkshop.Database.Repositories
{
    public class TransactionDetailRepository : AppBaseRepository<TransactionDetail>, ITransactionDetailRepository
    {
        public TransactionDetailRepository(IDatabaseFactory<BrawijayaWorkshopDbContext> databaseFactory)
            : base(databaseFactory) { }
    }

    public interface ITransactionDetailRepository : IRepository<TransactionDetail, BrawijayaWorkshopDbContext>
    {
    }
}
