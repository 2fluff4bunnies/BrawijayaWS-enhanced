using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Infrastructure.Repository;
using System.Collections.Generic;
using System.Linq;


namespace BrawijayaWorkshop.Database.Repositories
{
    public class WheelDetailRepository : AppBaseRepository<WheelDetail>, IWheelDetailRepository
    {
        public WheelDetailRepository(IDatabaseFactory<BrawijayaWorkshopDbContext> databaseFactory)
            : base(databaseFactory) { }
    }


    public interface IWheelDetailRepository : IRepository<WheelDetail, BrawijayaWorkshopDbContext>
    {
    }
}
