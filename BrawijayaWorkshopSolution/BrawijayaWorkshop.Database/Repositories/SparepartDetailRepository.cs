using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Infrastructure.Repository;

namespace BrawijayaWorkshop.Database.Repositories
{
    public class SparepartDetailRepository : AppBaseRepository<SparepartDetail>, ISparepartDetailRepository
    {
        public SparepartDetailRepository(IDatabaseFactory<BrawijayaWorkshopDbContext> databaseFactory)
            : base(databaseFactory) { }
    }

    public interface ISparepartDetailRepository : IRepository<SparepartDetail, BrawijayaWorkshopDbContext>
    {
    }
}
