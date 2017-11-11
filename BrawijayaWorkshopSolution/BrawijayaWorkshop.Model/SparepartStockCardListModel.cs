using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Database.Repositories;
using BrawijayaWorkshop.SharedObject.ViewModels;
using BrawijayaWorkshop.Utils;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BrawijayaWorkshop.Model
{
    public class SparepartStockCardListModel : AppBaseModel
    {
        private ISparepartStockCardRepository _sparepartStockCardRepository;
        private ISparepartRepository _sparepartRepository;

        public SparepartStockCardListModel(ISparepartRepository sparepartRepository,
            ISparepartStockCardRepository sparepartStockCardRepository)
        {
            _sparepartRepository = sparepartRepository;
            _sparepartStockCardRepository = sparepartStockCardRepository;
        }

        public List<SparepartViewModel> RetrieveAllSpareparts()
        {
            List<Sparepart> result = _sparepartRepository.GetAll().ToList();
            result.Insert(0, new Sparepart {
                Id = 0,
                Code = "-",
                Name = "-- Pilih Sparepart --"
            });
            List<SparepartViewModel> mappedResult = new List<SparepartViewModel>();
            return Map(result, mappedResult);
        }

        public List<GroupSparepartStockCardViewModel> RetrieveStockCards(DateTime fromDate, DateTime toDate, int sparepartId)
        {
            List<GroupSparepartStockCard> result = new List<GroupSparepartStockCard>();
            DateTime lastDay = toDate.AddDays(1).AddSeconds(-1);
            //result = _sparepartStockCardRepository.RetrieveCurrentStock(fromDate, toDate, sparepartId);

            List<SparepartStockCard> list = _sparepartStockCardRepository.GetMany(sp => sp.PurchaseDate >= fromDate && sp.PurchaseDate <= lastDay &&
                               (sparepartId > 0 ? sp.SparepartId == sparepartId : true)).ToList();
            if(list != null && list.Count > 0)
            {
                var spp = from sp in list
                         group sp by new
                         {
                             sp.Sparepart,
                             sp.SparepartId,
                         } into gsp
                         select new GroupSparepartStockCard
                         {
                             LastPurchaseDate = gsp.Max(g => g.PurchaseDate),
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

                result = spp.ToList();
            }

            List<GroupSparepartStockCard> reportResult = result;
            //check if there are sparepartID not in range of filter, just fill with totalqtyfirst from the day close to start date filter
            if (sparepartId == 0)
            {
                var listSparepart = _sparepartRepository.GetAll();
                if (reportResult == null || reportResult.Count() == 0)
                {
                    reportResult = new List<GroupSparepartStockCard>();
                    foreach (var itemSparepart in listSparepart)
                    {
                        SparepartStockCard firstInitData = _sparepartStockCardRepository.GetMany(x => x.SparepartId == itemSparepart.Id && x.PurchaseDate < fromDate).LastOrDefault();
                        if (firstInitData != null)
                        {
                            GroupSparepartStockCard newItem = new GroupSparepartStockCard();
                            newItem.TotalQtyFirst = firstInitData.QtyLast;
                            newItem.TotalQtyFirstPrice = firstInitData.QtyLastPrice;
                            newItem.LastPurchaseDate = firstInitData.PurchaseDate;
                            newItem.Sparepart = firstInitData.Sparepart;
                            newItem.SparepartId = firstInitData.SparepartId;
                            newItem.PricePerItem = firstInitData.PricePerItem;
                            newItem.TotalQtyIn = 0;
                            newItem.TotalQtyInPrice = 0;
                            newItem.TotalQtyOut = 0;
                            newItem.TotalQtyOutPrice =0;
                            newItem.TotalQtyLast = firstInitData.QtyLast;
                            newItem.TotalQtyLastPrice = firstInitData.QtyLastPrice;
                            reportResult.Add(newItem);
                        }
                    }
                }
                else if (reportResult.Count != listSparepart.Count())
                {
                    foreach (var itemSparepart in listSparepart)
                    {
                        if (reportResult.Where(x => x.SparepartId == itemSparepart.Id).Count() == 0)
                        {
                            SparepartStockCard firstInitData = _sparepartStockCardRepository.GetMany(x => x.SparepartId == itemSparepart.Id && x.PurchaseDate < fromDate).LastOrDefault();
                            if (firstInitData != null)
                            {
                                GroupSparepartStockCard newItem = new GroupSparepartStockCard();
                                newItem.TotalQtyFirst = firstInitData.QtyLast;
                                newItem.TotalQtyFirstPrice = firstInitData.QtyLastPrice;
                                newItem.LastPurchaseDate = firstInitData.PurchaseDate;
                                newItem.Sparepart = firstInitData.Sparepart;
                                newItem.SparepartId = firstInitData.SparepartId;
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
            }
            else
            {
                var itemSparepart = _sparepartRepository.GetById(sparepartId);
                if (reportResult == null || reportResult.Count() == 0)
                {
                    reportResult = new List<GroupSparepartStockCard>();
                    SparepartStockCard firstInitData = _sparepartStockCardRepository.GetMany(x => x.SparepartId == sparepartId && x.PurchaseDate < fromDate).LastOrDefault();
                    if (firstInitData != null)
                    {
                        GroupSparepartStockCard newItem = new GroupSparepartStockCard();
                        newItem.TotalQtyFirst = firstInitData.QtyLast;
                        newItem.TotalQtyFirstPrice = firstInitData.QtyLastPrice;
                        newItem.LastPurchaseDate = firstInitData.PurchaseDate;
                        newItem.Sparepart = firstInitData.Sparepart;
                        newItem.SparepartId = firstInitData.SparepartId;
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


            List <GroupSparepartStockCardViewModel> mappedResult = new List<GroupSparepartStockCardViewModel>();
            mappedResult = Map(reportResult, mappedResult);
            return mappedResult.OrderBy(x => x.Sparepart.Code).ToList();
        }
    }
}
