using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Infrastructure.Repository;

namespace BrawijayaWorkshop.Database.Repositories
{
    public class SparepartRepository : AppBaseRepository<Sparepart>, ISparepartRepository
    {
        public SparepartRepository(IDatabaseFactory<BrawijayaWorkshopDbContext> databaseFactory)
            : base(databaseFactory) { }
    }

    public interface ISparepartRepository : IRepository<Sparepart>
    {
    }
}
