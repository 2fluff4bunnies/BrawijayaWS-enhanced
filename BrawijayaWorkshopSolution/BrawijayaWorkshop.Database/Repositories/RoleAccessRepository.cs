using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Infrastructure.Repository;

namespace BrawijayaWorkshop.Database.Repositories
{
    public class RoleAccessRepository : AppBaseRepository<RoleAccess>, IRoleAccessRepository
    {
        public RoleAccessRepository(IDatabaseFactory<BrawijayaWorkshopDbContext> databaseFactory)
            : base(databaseFactory) { }
    }

    public interface IRoleAccessRepository : IRepository<RoleAccess, BrawijayaWorkshopDbContext>
    {
    }
}
