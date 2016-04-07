using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Infrastructure.Repository;
using System.Collections.Generic;
using System.Linq;

namespace BrawijayaWorkshop.Database.Repositories
{
    public class WheelExchangeHistoryRepository : AppBaseRepository<WheelExchangeHistory>, IWheelExchangeHistoryRepository
    {
        public WheelExchangeHistoryRepository(IDatabaseFactory<BrawijayaWorkshopDbContext> databaseFactory)
            : base(databaseFactory) { }
    }

    public interface IWheelExchangeHistoryRepository : IRepository<WheelExchangeHistory, BrawijayaWorkshopDbContext>
    {
    }
}
