using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Infrastructure.Repository;

namespace BrawijayaWorkshop.Database.Repositories
{
    public class RoleRepository : AppBaseRepository<Role>, IRoleRepository
    {
        public RoleRepository(IDatabaseFactory<BrawijayaWorkshopDbContext> databaseFactory)
            : base(databaseFactory) { }
    }

    public interface IRoleRepository : IRepository<Role>
    {
    }
}
