using BrawijayaWorkshop.Infrastructure.Repository;

namespace BrawijayaWorkshop.Database.Repositories
{
    public class AppUnitOfWork : UnitOfWork<BrawijayaWorkshopDbContext>
    {
        public AppUnitOfWork(IDatabaseFactory<BrawijayaWorkshopDbContext> databaseFactory)
            : base(databaseFactory) { }
    }
}