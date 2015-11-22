using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Infrastructure.Repository;

namespace BrawijayaWorkshop.Database.Repositories
{
    public class CustomerRepository : AppBaseRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository(IDatabaseFactory<BrawijayaWorkshopDbContext> databaseFactory)
            : base(databaseFactory) { }
    }

    public interface ICustomerRepository : IRepository<Customer, BrawijayaWorkshopDbContext>
    {
    }
}
