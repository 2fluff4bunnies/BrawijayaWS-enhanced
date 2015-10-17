using BrawijayaWorkshop.Infrastructure.Repository;

namespace BrawijayaWorkshop.Database.Repositories
{
    public abstract class AppBaseRepository<T> : BaseRepository<T, BrawijayaWorkshopDbContext> where T : class, new()
    {
        protected AppBaseRepository(IDatabaseFactory<BrawijayaWorkshopDbContext> databaseFactory)
            : base(databaseFactory) { }
    }
}
