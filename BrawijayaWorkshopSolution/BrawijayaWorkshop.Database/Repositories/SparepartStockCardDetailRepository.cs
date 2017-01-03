using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Infrastructure.Repository;

namespace BrawijayaWorkshop.Database.Repositories
{
    public class SparepartStockCardDetailRepository : AppBaseRepository<SparepartStockCardDetail>, ISparepartStockCardDetailRepository
    {
        public SparepartStockCardDetailRepository(IDatabaseFactory<BrawijayaWorkshopDbContext> databaseFactory)
            : base(databaseFactory) { }
    }

    public interface ISparepartStockCardDetailRepository : IRepository<SparepartStockCardDetail, BrawijayaWorkshopDbContext>
    {

    }
}