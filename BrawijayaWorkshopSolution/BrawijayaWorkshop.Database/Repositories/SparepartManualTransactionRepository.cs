using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Infrastructure.Repository;

namespace BrawijayaWorkshop.Database.Repositories
{
    public class SparepartManualTransactionRepository : AppBaseRepository<SparepartManualTransaction>, ISparepartManualTransactionRepository
    {
        public SparepartManualTransactionRepository(IDatabaseFactory<BrawijayaWorkshopDbContext> databaseFactory)
            : base(databaseFactory) { }
    }

    public interface ISparepartManualTransactionRepository : IRepository<SparepartManualTransaction, BrawijayaWorkshopDbContext>
    {
    }
}
