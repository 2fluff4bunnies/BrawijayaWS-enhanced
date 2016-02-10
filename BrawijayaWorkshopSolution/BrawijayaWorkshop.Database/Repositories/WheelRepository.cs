using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Infrastructure.Repository;
using System.Collections.Generic;
using System.Linq;


namespace BrawijayaWorkshop.Database.Repositories
{
    public class WheelRepository : AppBaseRepository<Wheel>, IWheelRepository
    {
        public WheelRepository(IDatabaseFactory<BrawijayaWorkshopDbContext> databaseFactory)
            : base(databaseFactory) { }
    }


    public interface IWheelRepository : IRepository<Wheel, BrawijayaWorkshopDbContext>
    {
    }
}
