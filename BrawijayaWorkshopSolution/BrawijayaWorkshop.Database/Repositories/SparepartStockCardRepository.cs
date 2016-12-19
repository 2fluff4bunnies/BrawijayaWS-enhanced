using System;
using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Infrastructure.Repository;
using System.Linq;
using System.Collections.Generic;

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

        public List<SparepartStockCard> RetrieveLifoFifoTransaction(DateTime from, DateTime to, int sparepartId)
        {
            throw new NotImplementedException();
        }

        public List<SparepartStockCard> RetrieveCurrentStock(DateTime from, DateTime to, int sparepartId = 0)
        {
            throw new NotImplementedException();
        }
    }

    public interface ISparepartStockCardRepository : IRepository<SparepartStockCard, BrawijayaWorkshopDbContext>
    {
        SparepartStockCard RetrieveLastCard(int sparepartId);
        List<SparepartStockCard> RetrieveLifoFifoTransaction(DateTime from, DateTime to, int sparepartId);
        List<SparepartStockCard> RetrieveCurrentStock(DateTime from, DateTime to, int sparepartId = 0);
    }
}
