using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Infrastructure.Repository;

namespace BrawijayaWorkshop.Database.Repositories
{
    public class MechanicRepository : AppBaseRepository<Mechanic>, IMechanicRepository
    {
        public MechanicRepository(IDatabaseFactory<BrawijayaWorkshopDbContext> databaseFactory)
            : base(databaseFactory) { }
    }

    public interface IMechanicRepository : IRepository<Mechanic, BrawijayaWorkshopDbContext>
    {
    }
}
