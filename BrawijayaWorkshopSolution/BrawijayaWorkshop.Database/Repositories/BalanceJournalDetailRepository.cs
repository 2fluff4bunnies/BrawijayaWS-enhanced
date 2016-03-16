using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Infrastructure.Repository;

namespace BrawijayaWorkshop.Database.Repositories
{
    public class BalanceJournalDetailRepository: AppBaseRepository<BalanceJournalDetail>, IBalanceJournalDetailRepository
    {
        public BalanceJournalDetailRepository(IDatabaseFactory<BrawijayaWorkshopDbContext> databaseFactory)
            : base(databaseFactory) { }
    }

    public interface IBalanceJournalDetailRepository : IRepository<BalanceJournalDetail, BrawijayaWorkshopDbContext>
    {
    }
}