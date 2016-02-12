using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Infrastructure.Repository;

namespace BrawijayaWorkshop.Database.Repositories
{
    public class SPKScheduleRepository : AppBaseRepository<SPKSchedule>, ISPKScheduleRepository
    {
        public SPKScheduleRepository(IDatabaseFactory<BrawijayaWorkshopDbContext> databaseFactory)
            : base(databaseFactory) { }
    }

    public interface ISPKScheduleRepository : IRepository<SPKSchedule, BrawijayaWorkshopDbContext>
    {
    }
}
