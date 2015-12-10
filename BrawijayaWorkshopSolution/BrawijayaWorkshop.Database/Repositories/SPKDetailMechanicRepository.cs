using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Infrastructure.Repository;

namespace BrawijayaWorkshop.Database.Repositories
{
    public class SPKDetailMechanicRepository : AppBaseRepository<SPKDetailMechanic>, ISPKDetailMechanicRepository
    {
        public SPKDetailMechanicRepository(IDatabaseFactory<BrawijayaWorkshopDbContext> databaseFactory)
            : base(databaseFactory) { }
    }

    public interface ISPKDetailMechanicRepository : IRepository<SPKDetailMechanic, BrawijayaWorkshopDbContext>
    {
    }
}
