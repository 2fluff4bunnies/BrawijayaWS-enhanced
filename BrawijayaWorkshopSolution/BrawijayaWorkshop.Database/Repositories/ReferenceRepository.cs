using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Infrastructure.Repository;

namespace BrawijayaWorkshop.Database.Repositories
{
    public class ReferenceRepository : AppBaseRepository<Reference>, IReferenceRepository
    {
        public ReferenceRepository(IDatabaseFactory<BrawijayaWorkshopDbContext> databaseFactory)
            : base(databaseFactory) { }
    }

    public interface IReferenceRepository : IRepository<Reference, BrawijayaWorkshopDbContext>
    {
    }
}
