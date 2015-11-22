using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Infrastructure.Repository;

namespace BrawijayaWorkshop.Database.Repositories
{
    public class CityRepository : AppBaseRepository<City>, ICityRepository
    {
        public CityRepository(IDatabaseFactory<BrawijayaWorkshopDbContext> databaseFactory)
            : base(databaseFactory) { }
    }

    public interface ICityRepository : IRepository<City, BrawijayaWorkshopDbContext>
    {
    }
}
