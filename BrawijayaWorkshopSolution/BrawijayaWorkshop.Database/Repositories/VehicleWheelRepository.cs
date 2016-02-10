using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Infrastructure.Repository;
using System.Collections.Generic;
using System.Linq;


namespace BrawijayaWorkshop.Database.Repositories
{
    public class VehicleWheelRepository : AppBaseRepository<VehicleWheel>, IVehicleWheelRepository
    {
        public VehicleWheelRepository(IDatabaseFactory<BrawijayaWorkshopDbContext> databaseFactory)
            : base(databaseFactory) { }
    }


    public interface IVehicleWheelRepository : IRepository<VehicleWheel, BrawijayaWorkshopDbContext>
    {
    }
}
