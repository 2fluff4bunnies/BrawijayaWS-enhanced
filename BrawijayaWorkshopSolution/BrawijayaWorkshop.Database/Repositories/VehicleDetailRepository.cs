using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrawijayaWorkshop.Database.Repositories
{
    public class VehicleDetailRepository : AppBaseRepository<Vehicle>, IVehicleDetailRepository
    {
        public VehicleDetailRepository(IDatabaseFactory<BrawijayaWorkshopDbContext> databaseFactory)
            : base(databaseFactory) { }
    }

    public interface IVehicleDetailRepository : IRepository<VehicleDetail>
    {
    }
}
