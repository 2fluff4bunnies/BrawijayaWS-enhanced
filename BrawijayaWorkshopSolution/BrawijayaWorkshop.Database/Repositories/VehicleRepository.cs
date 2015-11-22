using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Infrastructure.Repository;

namespace BrawijayaWorkshop.Database.Repositories
{
    public class VehicleRepository : AppBaseRepository<Vehicle>, IVehicleRepository
    {
        public VehicleRepository(IDatabaseFactory<BrawijayaWorkshopDbContext> databaseFactory)
            : base(databaseFactory) { }
    }

    public interface IVehicleRepository : IRepository<Vehicle, BrawijayaWorkshopDbContext>
    {
    }
}
