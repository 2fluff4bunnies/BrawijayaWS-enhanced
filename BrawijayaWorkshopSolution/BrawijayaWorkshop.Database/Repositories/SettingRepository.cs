using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Infrastructure.Repository;

namespace BrawijayaWorkshop.Database.Repositories
{
    public class SettingRepository : AppBaseRepository<Setting>, ISettingRepository
    {
        public SettingRepository(IDatabaseFactory<BrawijayaWorkshopDbContext> databaseFactory)
            : base(databaseFactory) { }
    }

    public interface ISettingRepository : IRepository<Setting, BrawijayaWorkshopDbContext>
    {
    }
}
