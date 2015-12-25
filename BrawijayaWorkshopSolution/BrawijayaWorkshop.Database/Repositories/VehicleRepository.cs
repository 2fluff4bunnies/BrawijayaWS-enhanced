using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Infrastructure.Repository;
using System.Collections.Generic;
using System.Linq;

namespace BrawijayaWorkshop.Database.Repositories
{
    public class VehicleRepository : AppBaseRepository<Vehicle>, IVehicleRepository
    {
        public VehicleRepository(IDatabaseFactory<BrawijayaWorkshopDbContext> databaseFactory)
            : base(databaseFactory) { }

        public List<Vehicle> GetVehicleForLookUp()
        {
            return DataContext.Vehicles.Include("Customer").Where(v => v.Status == (int)DbConstant.DefaultDataStatus.Active).ToList();
        }
    }

    public interface IVehicleRepository : IRepository<Vehicle, BrawijayaWorkshopDbContext>
    {
        List<Vehicle> GetVehicleForLookUp();
    }
}
