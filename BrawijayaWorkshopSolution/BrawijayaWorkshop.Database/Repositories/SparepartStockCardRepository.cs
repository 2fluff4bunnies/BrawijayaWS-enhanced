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
            return GetMany(sp => sp.SparepartId == sparepartId).OrderByDescending(sp => sp.PurchaseDate).FirstOrDefault();
        }

        public List<GroupSparepartStockCard> RetrieveLifoFifoTransaction(DateTime dateFrom, DateTime dateTo, int sparepartId)
        {
            var result = from sp in DbSet
                            where sp.PurchaseDate >= dateFrom && sp.PurchaseDate <= dateTo.AddDays(1).AddSeconds(-1) &&
                                  sp.SparepartId == sparepartId
                            group sp by new
                            {
                                sp.PurchaseDate,
                                sp.Sparepart,
                                sp.SparepartId,
                                sp.PricePerItem,
                                sp.QtyFirst,
                                sp.QtyFirstPrice,
                                sp.QtyIn,
                                sp.QtyInPrice,
                                sp.QtyOut,
                                sp.QtyOutPrice,
                                sp.QtyLast,
                                sp.QtyLastPrice
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

        public List<GroupSparepartStockCard> RetrieveCurrentStock(DateTime dateFrom, DateTime dateTo, int sparepartId = 0)
        {
            var result = from sp in DbSet
                            where sp.PurchaseDate >= dateFrom && sp.PurchaseDate <= dateTo.AddDays(1).AddSeconds(-1) &&
                                  (sparepartId > 0 ? sp.SparepartId == sparepartId : true)
                            group sp by new
                            {
                                sp.Sparepart,
                                sp.SparepartId,
                                sp.PricePerItem,
                                sp.QtyFirst,
                                sp.QtyFirstPrice,
                                sp.QtyIn,
                                sp.QtyInPrice,
                                sp.QtyOut,
                                sp.QtyOutPrice,
                                sp.QtyLast,
                                sp.QtyLastPrice
                            } into gsp
                            select new GroupSparepartStockCard
                            {
                                LastPurchaseDate = gsp.Max(g => g.PurchaseDate),
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
    }

    public interface ISparepartStockCardRepository : IRepository<SparepartStockCard, BrawijayaWorkshopDbContext>
    {
        SparepartStockCard RetrieveLastCard(int sparepartId);
        List<GroupSparepartStockCard> RetrieveLifoFifoTransaction(DateTime dateFrom, DateTime dateTo, int sparepartId);
        List<GroupSparepartStockCard> RetrieveCurrentStock(DateTime dateFrom, DateTime dateTo, int sparepartId = 0);
    }
}
