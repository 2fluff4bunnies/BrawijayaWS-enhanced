using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Infrastructure.Repository;

namespace BrawijayaWorkshop.Database.Repositories
{
    public class HPPHeaderRepository : AppBaseRepository<HPPHeader>, IHPPHeaderRepository
    {
        public HPPHeaderRepository(IDatabaseFactory<BrawijayaWorkshopDbContext> databaseFactory)
            : base(databaseFactory) { }
    }

    public interface IHPPHeaderRepository : IRepository<HPPHeader, BrawijayaWorkshopDbContext>
    {
    }
}
