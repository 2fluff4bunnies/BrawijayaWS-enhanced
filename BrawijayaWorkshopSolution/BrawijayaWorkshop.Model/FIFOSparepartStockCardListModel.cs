using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Database.Repositories;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BrawijayaWorkshop.Model
{
    public class FIFOSparepartStockCardListModel : AppBaseModel
    {
        private ISparepartStockCardDetailRepository _sparepartStockCardDetailRepository;
        private ISparepartStockCardRepository _sparepartStockCardRepository;
        private IPurchasingRepository _purchasingRepository;
        private IPurchasingDetailRepository _purchasingDetailRepository;
        private ISparepartManualTransactionRepository _sparepartManualTransactionRepository;
        private ISparepartRepository _sparepartRepository;

        public FIFOSparepartStockCardListModel(
            ISparepartStockCardDetailRepository sparepartStockCardDetailRepository,
            ISparepartStockCardRepository sparepartStockCardRepository,
            IPurchasingRepository purchasingRepository,
            IPurchasingDetailRepository purchasingDetailRepository,
            ISparepartManualTransactionRepository sparepartManualTransactionRepository,
            ISparepartRepository sparepartRepository
            )
        {
            _sparepartStockCardDetailRepository = sparepartStockCardDetailRepository;
            _sparepartStockCardRepository = sparepartStockCardRepository;
            _purchasingRepository = purchasingRepository;
            _purchasingDetailRepository = purchasingDetailRepository;
            _sparepartManualTransactionRepository = sparepartManualTransactionRepository;
            _sparepartRepository = sparepartRepository;
        }

        public List<GroupSparepartStockCardViewModel> RetrieveStockCards(DateTime fromDate, DateTime toDate, int sparepartId)
        {
            List<GroupSparepartStockCard> result = new List<GroupSparepartStockCard>();
            DateTime lastDay = toDate.AddDays(1).AddSeconds(-1);
            //result = _sparepartStockCardDetailRepository.RetrieveFIFOCurrentSparepart(fromDate, toDate, sparepartId);

            List<SparepartStockCardDetail> list = _sparepartStockCardDetailRepository.GetMany(sp => sp.ParentStockCard.PurchaseDate >= fromDate && sp.ParentStockCard.PurchaseDate <= lastDay &&
                               (sparepartId > 0 ? sp.ParentStockCard.SparepartId == sparepartId : true)).ToList();
            if (list != null)
            {
                var spp = from sp in list
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
                              Purchasing = gsp.Key.Purchasing,
                              PurchasingId = gsp.Key.PurchasingId,
                              SparepartManualTransaction = gsp.Key.SparepartManualTransaction,
                              SparepartManualTransactionId = gsp.Key.SparepartManualTransactionId,
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

                result = spp.ToList();
            }

            List<GroupSparepartStockCard> reportResult = result;
            //check if there are sparepartID not in range of filter, just fill with totalqtyfirst from the day close to start date filter
            if (sparepartId != 0)
            {
                var itemSparepart = _sparepartRepository.GetById(sparepartId);
                var listPurchasing = _purchasingDetailRepository.GetMany(x => x.SparepartId == sparepartId).Select(x=>x.Purchasing);
                var listSparepartManual = _sparepartManualTransactionRepository.GetMany(x=>x.SparepartId == sparepartId);
                if (reportResult == null || reportResult.Count() == 0)
                {
                    reportResult = new List<GroupSparepartStockCard>();
                }

                foreach (var itemPurchasing in listPurchasing)
                {
                    if (reportResult.Where(x => x.PurchasingId == itemPurchasing.Id).Count() == 0)
                    {
                        SparepartStockCardDetail firstInitData = _sparepartStockCardDetailRepository.GetMany(x => x.PurchasingId == itemPurchasing.Id && x.ParentStockCard.PurchaseDate < fromDate).LastOrDefault();
                        if (firstInitData != null)
                        {
                            GroupSparepartStockCard newItem = new GroupSparepartStockCard();
                            newItem.TotalQtyFirst = firstInitData.QtyLast;
                            newItem.TotalQtyFirstPrice = firstInitData.QtyLastPrice;
                            newItem.LastPurchaseDate = firstInitData.Purchasing.CreateDate;
                            newItem.Sparepart = firstInitData.ParentStockCard.Sparepart;
                            newItem.SparepartId = firstInitData.ParentStockCard.SparepartId;
                            newItem.Purchasing = firstInitData.Purchasing;
                            newItem.PurchasingId = firstInitData.PurchasingId;
                            newItem.PricePerItem = firstInitData.PricePerItem;
                            newItem.TotalQtyIn = 0;
                            newItem.TotalQtyInPrice = 0;
                            newItem.TotalQtyOut = 0;
                            newItem.TotalQtyOutPrice = 0;
                            newItem.TotalQtyLast = firstInitData.QtyLast;
                            newItem.TotalQtyLastPrice = firstInitData.QtyLastPrice;
                            reportResult.Add(newItem);
                        }
                    }
                }
                foreach (var itemSpManual in listSparepartManual)
                {
                    if (reportResult.Where(x => x.SparepartManualTransactionId == itemSpManual.Id).Count() == 0)
                    {
                        SparepartStockCardDetail firstInitData = _sparepartStockCardDetailRepository.GetMany(x => x.SparepartManualTransactionId == itemSpManual.Id && x.ParentStockCard.PurchaseDate < fromDate).LastOrDefault();
                        if (firstInitData != null)
                        {
                            GroupSparepartStockCard newItem = new GroupSparepartStockCard();
                            newItem.TotalQtyFirst = firstInitData.QtyLast;
                            newItem.TotalQtyFirstPrice = firstInitData.QtyLastPrice;
                            newItem.LastPurchaseDate = firstInitData.SparepartManualTransaction.CreateDate;
                            newItem.Sparepart = firstInitData.ParentStockCard.Sparepart;
                            newItem.SparepartId = firstInitData.ParentStockCard.SparepartId;
                            newItem.SparepartManualTransaction = firstInitData.SparepartManualTransaction;
                            newItem.SparepartManualTransactionId = firstInitData.SparepartManualTransactionId;
                            newItem.PricePerItem = firstInitData.PricePerItem;
                            newItem.TotalQtyIn = 0;
                            newItem.TotalQtyInPrice = 0;
                            newItem.TotalQtyOut = 0;
                            newItem.TotalQtyOutPrice = 0;
                            newItem.TotalQtyLast = firstInitData.QtyLast;
                            newItem.TotalQtyLastPrice = firstInitData.QtyLastPrice;
                            reportResult.Add(newItem);
                        }
                    }
                }
            }
            List<GroupSparepartStockCardViewModel> mappedResult = new List<GroupSparepartStockCardViewModel>();
            mappedResult = Map(reportResult, mappedResult);
            return mappedResult.OrderBy(x => x.Sparepart.Code).ToList();
        }
    }
}
