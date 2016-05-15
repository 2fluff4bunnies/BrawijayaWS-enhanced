using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Infrastructure.Repository;

namespace BrawijayaWorkshop.Database.Repositories
{
    public class VehicleGroupRepository : AppBaseRepository<VehicleGroup>, IVehicleGroupRepository
    {
        public VehicleGroupRepository(IDatabaseFactory<BrawijayaWorkshopDbContext> databaseFactory)
            : base(databaseFactory) { }
    }

    public interface IVehicleGroupRepository : IRepository<VehicleGroup, BrawijayaWorkshopDbContext>
    {
    }
}
