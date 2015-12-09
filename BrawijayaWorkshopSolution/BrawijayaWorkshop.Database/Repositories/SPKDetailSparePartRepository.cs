using BrawijayaWorkshop.Infrastructure.Repository;
using BrawijayaWorkshop.Database.Entities;

namespace BrawijayaWorkshop.Database.Repositories
{
    public class SPKDetailSparepartRepository : AppBaseRepository<SPKDetailSparepart>, ISPKDetailSparepartRepository
    {
     public SPKDetailSparepartRepository(IDatabaseFactory<BrawijayaWorkshopDbContext> databaseFactory)
            : base(databaseFactory) { }
    }

    public interface ISPKDetailSparepartRepository : IRepository<SPKDetailSparepart, BrawijayaWorkshopDbContext>
    {
    }
}
