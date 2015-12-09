using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Infrastructure.Repository;

namespace BrawijayaWorkshop.Database.Repositories
{
    public class SPKDetailSparepartDetailRepository : AppBaseRepository<SPKDetailSparepartDetail>, ISPKDetailSparepartDetailRepository
    {
     public SPKDetailSparepartDetailRepository(IDatabaseFactory<BrawijayaWorkshopDbContext> databaseFactory)
            : base(databaseFactory) { }
    }

    public interface ISPKDetailSparepartDetailRepository : IRepository<SPKDetailSparepartDetail, BrawijayaWorkshopDbContext>
    {
    }
}
