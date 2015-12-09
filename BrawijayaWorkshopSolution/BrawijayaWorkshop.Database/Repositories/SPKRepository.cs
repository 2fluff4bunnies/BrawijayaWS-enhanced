using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Infrastructure.Repository;

namespace BrawijayaWorkshop.Database.Repositories
{
    public class SPKRepository : AppBaseRepository<SPK>, ISPKRepository
    {
        public SPKRepository(IDatabaseFactory<BrawijayaWorkshopDbContext> databaseFactory)
             : base(databaseFactory) { }
    }

    public interface ISPKRepository : IRepository<SPK, BrawijayaWorkshopDbContext>
    {
    }
}
