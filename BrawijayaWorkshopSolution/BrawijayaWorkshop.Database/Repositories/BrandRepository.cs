using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Infrastructure.Repository;

namespace BrawijayaWorkshop.Database.Repositories
{
    public class BrandRepository : AppBaseRepository<Brand>, IBrandRepository
    {
        public BrandRepository(IDatabaseFactory<BrawijayaWorkshopDbContext> databaseFactory)
            : base(databaseFactory) { }
    }

    public interface IBrandRepository : IRepository<Brand, BrawijayaWorkshopDbContext>
    {
    }
}
