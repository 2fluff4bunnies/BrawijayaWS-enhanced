using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Infrastructure.Repository;

namespace BrawijayaWorkshop.Database.Repositories
{
    public class TypeRepository : AppBaseRepository<Type>, ITypeRepository
    {
        public TypeRepository(IDatabaseFactory<BrawijayaWorkshopDbContext> databaseFactory)
            : base(databaseFactory) { }
    }

    public interface ITypeRepository : IRepository<Type, BrawijayaWorkshopDbContext>
    {
    }
}
