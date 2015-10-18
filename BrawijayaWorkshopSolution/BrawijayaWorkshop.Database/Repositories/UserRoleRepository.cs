using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Infrastructure.Repository;

namespace BrawijayaWorkshop.Database.Repositories
{
    public class UserRoleRepository : AppBaseRepository<UserRole>, IUserRoleRepository
    {
        public UserRoleRepository(IDatabaseFactory<BrawijayaWorkshopDbContext> databaseFactory)
            : base(databaseFactory) { }
    }

    public interface IUserRoleRepository : IRepository<UserRole>
    {
    }
}
