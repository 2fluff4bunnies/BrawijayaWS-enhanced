using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Infrastructure.Repository;

namespace BrawijayaWorkshop.Database.Repositories
{
    public class UserRepository : AppBaseRepository<User>, IUserRepository
    {
        public UserRepository(IDatabaseFactory<BrawijayaWorkshopDbContext> databaseFactory)
            : base(databaseFactory) { }
    }

    public interface IUserRepository : IRepository<User>
    {
    }
}
