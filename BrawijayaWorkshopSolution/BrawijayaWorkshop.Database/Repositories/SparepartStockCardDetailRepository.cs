using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Infrastructure.Repository;
using System;
using System.Collections.Generic;

namespace BrawijayaWorkshop.Database.Repositories
{
    public class SparepartStockCardDetailRepository : AppBaseRepository<SparepartStockCardDetail>, ISparepartStockCardDetailRepository
    {
        public SparepartStockCardDetailRepository(IDatabaseFactory<BrawijayaWorkshopDbContext> databaseFactory)
            : base(databaseFactory) { }

        public List<GroupSparepartStockCard> RetrieveFIFOCurrentSparepart(DateTime dateFrom, DateTime dateTo, int sparepartId)
        {
            throw new NotImplementedException();
        }
    }

    public interface ISparepartStockCardDetailRepository : IRepository<SparepartStockCardDetail, BrawijayaWorkshopDbContext>
    {
        List<GroupSparepartStockCard> RetrieveFIFOCurrentSparepart(DateTime dateFrom, DateTime dateTo, int sparepartId);
    }
}