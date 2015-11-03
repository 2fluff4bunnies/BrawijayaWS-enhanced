using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Infrastructure.Repository;

namespace BrawijayaWorkshop.Database.Repositories
{
    public class ReferenceDetailRepository : AppBaseRepository<ReferenceDetail>, IReferenceDetailRepository
    {
        public ReferenceDetailRepository(IDatabaseFactory<BrawijayaWorkshopDbContext> databaseFactory)
            : base(databaseFactory) { }
    }

    public interface IReferenceDetailRepository : IRepository<ReferenceDetail>
    {
    }
}
