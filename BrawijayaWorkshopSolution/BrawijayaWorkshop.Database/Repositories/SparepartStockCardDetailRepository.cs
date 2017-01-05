using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BrawijayaWorkshop.Database.Repositories
{
    public class SparepartStockCardDetailRepository : AppBaseRepository<SparepartStockCardDetail>, ISparepartStockCardDetailRepository
    {
        public SparepartStockCardDetailRepository(IDatabaseFactory<BrawijayaWorkshopDbContext> databaseFactory)
            : base(databaseFactory) { }

        public List<GroupSparepartStockCard> RetrieveFIFOCurrentSparepart(DateTime dateFrom, DateTime dateTo, int sparepartId)
        {
            var result = from sp in DbSet
                         where sp.ParentStockCard.PurchaseDate >= dateFrom && sp.ParentStockCard.PurchaseDate <= dateTo &&
                               sp.ParentStockCard.SparepartId == sparepartId
                         group sp by new
                         {
                             sp.ParentStockCard.PurchaseDate,
                             sp.ParentStockCard.Sparepart,
                             sp.ParentStockCard.SparepartId,
                             sp.PricePerItem
                         } into gsp
                         select new GroupSparepartStockCard
                         {
                             LastPurchaseDate = gsp.Key.PurchaseDate,
                             Sparepart = gsp.Key.Sparepart,
                             SparepartId = gsp.Key.SparepartId,
                             PricePerItem = gsp.Key.PricePerItem,
                             TotalQtyFirst = gsp.Sum(g => g.QtyFirst),
                             TotalQtyFirstPrice = gsp.Sum(g => g.QtyFirstPrice),
                             TotalQtyIn = gsp.Sum(g => g.QtyIn),
                             TotalQtyInPrice = gsp.Sum(g => g.QtyInPrice),
                             TotalQtyOut = gsp.Sum(g => g.QtyOut),
                             TotalQtyOutPrice = gsp.Sum(g => g.QtyOutPrice),
                             TotalQtyLast = gsp.Sum(g => g.QtyLast),
                             TotalQtyLastPrice = gsp.Sum(g => g.QtyLastPrice)
                         };

            return result.ToList();
        }

        public SparepartStockCardDetail RetrieveLastCardDetailByPurchasingId(int sparepartId, int purchasingID)
        {
            return GetMany(sp => sp.ParentStockCard.SparepartId == sparepartId && sp.PurchasingId == purchasingID).OrderByDescending(sp => sp.ParentStockCard.PurchaseDate).FirstOrDefault();
        }

        public SparepartStockCardDetail RetrieveLastCardDetailByTransactionManualId(int sparepartId, int transactionManualId)
        {
            return GetMany(sp => sp.ParentStockCard.SparepartId == sparepartId && sp.SparepartManualTransactionId == transactionManualId).OrderByDescending(sp => sp.ParentStockCard.PurchaseDate).FirstOrDefault();
        }
    }

    public interface ISparepartStockCardDetailRepository : IRepository<SparepartStockCardDetail, BrawijayaWorkshopDbContext>
    {
        List<GroupSparepartStockCard> RetrieveFIFOCurrentSparepart(DateTime dateFrom, DateTime dateTo, int sparepartId);

        SparepartStockCardDetail RetrieveLastCardDetailByPurchasingId(int sparepartId, int purchasingID);
        SparepartStockCardDetail RetrieveLastCardDetailByTransactionManualId(int sparepartId, int transactionManualId);
    }
}