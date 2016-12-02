using System;
using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Infrastructure.Repository;
using System.Linq;

namespace BrawijayaWorkshop.Database.Repositories
{
    public class SparepartStockCardRepository : AppBaseRepository<SparepartStockCard>, ISparepartStockCardRepository
    {
        public SparepartStockCardRepository(IDatabaseFactory<BrawijayaWorkshopDbContext> databaseFactory)
            : base(databaseFactory) { }

        public SparepartStockCard RetrieveLastCard(int sparepartId)
        {
            return GetMany(sp => sp.SparepartId == sparepartId).OrderByDescending(sp => sp.Id).FirstOrDefault();
        }
    }

    public interface ISparepartStockCardRepository : IRepository<SparepartStockCard, BrawijayaWorkshopDbContext>
    {
        SparepartStockCard RetrieveLastCard(int sparepartId);
    }
}
