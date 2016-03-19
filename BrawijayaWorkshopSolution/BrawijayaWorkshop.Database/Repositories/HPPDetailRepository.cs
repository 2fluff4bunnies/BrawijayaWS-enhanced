using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Infrastructure.Repository;

namespace BrawijayaWorkshop.Database.Repositories
{
    public class HPPDetailRepository : AppBaseRepository<HPPDetail>, IHPPDetailRepository
    {
        public HPPDetailRepository(IDatabaseFactory<BrawijayaWorkshopDbContext> databaseFactory)
            : base(databaseFactory) { }
    }

    public interface IHPPDetailRepository : IRepository<HPPDetail, BrawijayaWorkshopDbContext>
    {
    }
}
