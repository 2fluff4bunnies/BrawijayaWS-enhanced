using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Infrastructure.Repository;

namespace BrawijayaWorkshop.Database.Repositories
{
    public class BalanceJournalRepository : AppBaseRepository<BalanceJournal>, IBalanceJournalRepository
    {
        public BalanceJournalRepository(IDatabaseFactory<BrawijayaWorkshopDbContext> databaseFactory)
            : base(databaseFactory) { }
    }

    public interface IBalanceJournalRepository : IRepository<BalanceJournal, BrawijayaWorkshopDbContext>
    {
    }
}
