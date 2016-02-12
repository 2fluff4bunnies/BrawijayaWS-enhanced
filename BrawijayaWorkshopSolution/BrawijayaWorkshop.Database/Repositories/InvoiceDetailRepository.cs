using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Infrastructure.Repository;

namespace BrawijayaWorkshop.Database.Repositories
{
    public class InvoiceDetailRepository : AppBaseRepository<InvoiceDetail>, IInvoiceDetailRepository
    {
        public InvoiceDetailRepository(IDatabaseFactory<BrawijayaWorkshopDbContext> databaseFactory)
            : base(databaseFactory) { }
    }

    public interface IInvoiceDetailRepository : IRepository<InvoiceDetail, BrawijayaWorkshopDbContext>
    {
    }
}
