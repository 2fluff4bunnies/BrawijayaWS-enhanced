using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Infrastructure.Repository;

namespace BrawijayaWorkshop.Database.Repositories
{
    public class ApplicationModulRepository : AppBaseRepository<ApplicationModul>, IApplicationModulRepository
    {
        public ApplicationModulRepository(IDatabaseFactory<BrawijayaWorkshopDbContext> databaseFactory)
            : base(databaseFactory) { }
    }

    public interface IApplicationModulRepository : IRepository<ApplicationModul>
    {
    }
}
