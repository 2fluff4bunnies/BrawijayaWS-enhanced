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
                               (sparepartId > 0 ? sp.ParentStockCard.SparepartId == sparepartId : true)
                         group sp by new
                         {
                             sp.ParentStockCard.Sparepart,
                             sp.ParentStockCard.SparepartId,
                             sp.Purchasing,
                             sp.PurchasingId,
                             sp.SparepartManualTransaction,
                             sp.SparepartManualTransactionId
                         } into gsp
                         select new GroupSparepartStockCard
                         {
                             LastPurchaseDate = gsp.FirstOrDefault().Purchasing != null ? gsp.FirstOrDefault().Purchasing.Date : gsp.FirstOrDefault().SparepartManualTransaction.CreateDate,
                             Sparepart = gsp.Key.Sparepart,
                             SparepartId = gsp.Key.SparepartId,
                             PricePerItem = gsp.LastOrDefault().PricePerItem,
                             TotalQtyFirst = gsp.FirstOrDefault().QtyFirst,
                             TotalQtyFirstPrice = gsp.FirstOrDefault().QtyFirstPrice,
                             TotalQtyIn = gsp.Sum(g => g.QtyIn),
                             TotalQtyInPrice = gsp.Sum(g => g.QtyInPrice),
                             TotalQtyOut = gsp.Sum(g => g.QtyOut),
                             TotalQtyOutPrice = gsp.Sum(g => g.QtyOutPrice),
                             TotalQtyLast = gsp.LastOrDefault().QtyLast,
                             TotalQtyLastPrice = gsp.LastOrDefault().QtyLastPrice
                         };


            List<GroupSparepartStockCard> reportResult = result.ToList();
            //check if there are sparepartID not in range of filter, just fill with totalqtyfirst from the day close to start date filter
            if (sparepartId == 0)
            {
                var listSparepartID = DbSet.Select(x => x.ParentStockCard.SparepartId).Distinct();
                if (reportResult == null || reportResult.Count() == 0)
                {
                    reportResult = new List<GroupSparepartStockCard>();
                    foreach (var itemSparepartID in listSparepartID)
                    {
                        SparepartStockCardDetail firstInitData = DbSet.Where(x => x.ParentStockCard.SparepartId == itemSparepartID && x.ParentStockCard.PurchaseDate < dateFrom).LastOrDefault();
                        if (firstInitData != null)
                        {
                            GroupSparepartStockCard newItem = new GroupSparepartStockCard();
                            newItem.TotalQtyFirst = firstInitData.QtyLast;
                            newItem.TotalQtyFirstPrice = firstInitData.QtyLastPrice;
                            reportResult.Add(newItem);
                        }
                    }
                }
                else if (reportResult.Count != listSparepartID.Count())
                {
                    foreach (var itemSparepartID in listSparepartID)
                    {
                        if (reportResult.Where(x => x.SparepartId == itemSparepartID).Count() == 0)
                        {
                            SparepartStockCardDetail firstInitData = DbSet.Where(x => x.ParentStockCard.SparepartId == itemSparepartID && x.ParentStockCard.PurchaseDate < dateFrom).LastOrDefault();
                            if (firstInitData != null)
                            {
                                GroupSparepartStockCard newItem = new GroupSparepartStockCard();
                                newItem.TotalQtyFirst = firstInitData.QtyLast;
                                newItem.TotalQtyFirstPrice = firstInitData.QtyLastPrice;
                                reportResult.Add(newItem);
                            }
                        }
                    }
                }
            }
            else
            {
                if (reportResult == null || reportResult.Count() == 0)
                {
                    reportResult = new List<GroupSparepartStockCard>();
                    SparepartStockCardDetail firstInitData = DbSet.Where(x => x.ParentStockCard.SparepartId == sparepartId && x.ParentStockCard.PurchaseDate < dateFrom).LastOrDefault();
                    if (firstInitData != null)
                    {
                        GroupSparepartStockCard newItem = new GroupSparepartStockCard();
                        newItem.TotalQtyFirst = firstInitData.QtyLast;
                        newItem.TotalQtyFirstPrice = firstInitData.QtyLastPrice;
                        reportResult.Add(newItem);
                    }
                }
            }

            return reportResult;
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