using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Infrastructure.Repository;

namespace BrawijayaWorkshop.Database.Repositories
{
    public class InvoiceRepository : AppBaseRepository<Invoice>, IInvoiceRepository
    {
        public InvoiceRepository(IDatabaseFactory<BrawijayaWorkshopDbContext> databaseFactory)
            : base(databaseFactory) { }
    }

    public interface IInvoiceRepository : IRepository<Invoice, BrawijayaWorkshopDbContext>
    {
    }
}
