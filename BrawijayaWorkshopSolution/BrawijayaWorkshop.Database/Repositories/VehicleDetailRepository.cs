using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Infrastructure.Repository;

namespace BrawijayaWorkshop.Database.Repositories
{
    public class VehicleDetailRepository : AppBaseRepository<VehicleDetail>, IVehicleDetailRepository
    {
        public VehicleDetailRepository(IDatabaseFactory<BrawijayaWorkshopDbContext> databaseFactory)
            : base(databaseFactory) { }
    }

    public interface IVehicleDetailRepository : IRepository<VehicleDetail>
    {
    }
}
