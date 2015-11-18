using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Infrastructure.Repository;

namespace BrawijayaWorkshop.Database.Repositories
{
    public class JournalMasterRepository : AppBaseRepository<JournalMaster>, IJournalMasterRepository
    {
        public JournalMasterRepository(IDatabaseFactory<BrawijayaWorkshopDbContext> databaseFactory)
            : base(databaseFactory) { }
    }

    public interface IJournalMasterRepository : IRepository<JournalMaster>
    {
    }
}
