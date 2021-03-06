﻿using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Database.Repositories;
using BrawijayaWorkshop.Infrastructure.Repository;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BrawijayaWorkshop.Model
{
    public class PurchaseReturnTransactionListModel : AppBaseModel
    {
        private ITransactionRepository _transactionRepository;
        private IPurchasingRepository _purchasingRepository;
        private IPurchasingDetailRepository _purchasingDetailRepository;
        private IPurchaseReturnRepository _purchaseReturnRepository;
        private IPurchaseReturnDetailRepository _purchaseReturnDetailRepository;
        private ISparepartRepository _sparepartRepository;
        private IReferenceRepository _referenceRepository;
        private ISparepartStockCardRepository _sparepartStokCardRepository;
        private ISparepartStockCardDetailRepository _sparepartStokCardDetailRepository;
        private IUnitOfWork _unitOfWork;

        public PurchaseReturnTransactionListModel(ITransactionRepository transactionRepository,
            IPurchasingRepository purchasingRepository, IPurchasingDetailRepository purchasingDetailRepository, IPurchaseReturnRepository purchaseReturnRepository,
            IPurchaseReturnDetailRepository purchaseReturnDetailRepository,
            ISparepartRepository sparepartRepository,
            IReferenceRepository referenceRepository,
            ISparepartStockCardRepository sparepartStockCardRepository,
            ISparepartStockCardDetailRepository sparepartStockCardDetailRepository,
            IUnitOfWork unitOfWork)
            : base()
        {
            _transactionRepository = transactionRepository;
            _purchasingRepository = purchasingRepository;
            _purchasingDetailRepository = purchasingDetailRepository;
            _purchaseReturnRepository = purchaseReturnRepository;
            _purchaseReturnDetailRepository = purchaseReturnDetailRepository;
            _sparepartRepository = sparepartRepository;
            _referenceRepository = referenceRepository;
            _sparepartStokCardRepository = sparepartStockCardRepository;
            _sparepartStokCardDetailRepository = sparepartStockCardDetailRepository;
            _unitOfWork = unitOfWork;
        }

        public List<PurchaseReturnViewModel> SearchPurchaseReturnList(DateTime? dateFrom, DateTime? dateTo, int purchasingID)
        {
            List<PurchaseReturn> result = null;
            if (dateFrom.HasValue && dateTo.HasValue)
            {
                dateFrom = dateFrom.Value.Date;
                dateTo = dateTo.Value.Date.AddDays(1).AddSeconds(-1);
                result = _purchaseReturnRepository.GetMany(c => c.Date >= dateFrom && c.CreateDate <= dateTo && c.Status == (int)DbConstant.DefaultDataStatus.Active).OrderByDescending(c => c.Date).ToList();
            }
            else
            {
                result = _purchaseReturnRepository.GetMany(c=>c.Status == (int)DbConstant.DefaultDataStatus.Active).OrderByDescending(c => c.Date).ToList();
            }

            if(purchasingID > 0)
            {
                result = result.Where(x => x.PurchasingId == purchasingID).OrderByDescending(c => c.Date).ToList();
            }

            List<PurchaseReturnViewModel> mappedResult = new List<PurchaseReturnViewModel>();
            return Map(result, mappedResult);
        }

        public void DeletePurchaseReturn(int purchaseReturnID, int userID)
        {
            using(var trans = _unitOfWork.BeginTransaction())
            {
                try
                {
                    DateTime serverTime = DateTime.Now;

                    Reference transactionReferenceTable = _referenceRepository.GetMany(c => c.Code == DbConstant.REF_TRANSTBL_PURCHASERETURN).FirstOrDefault();
                    
                    PurchaseReturn purchaseReturn = _purchaseReturnRepository.GetById(purchaseReturnID);
                    purchaseReturn.Status = (int)DbConstant.DefaultDataStatus.Deleted;
                    purchaseReturn.ModifyDate = serverTime;
                    purchaseReturn.ModifyUserId = userID;

                    _purchaseReturnRepository.AttachNavigation(purchaseReturn.CreateUser);
                    _purchaseReturnRepository.AttachNavigation(purchaseReturn.ModifyUser);
                    _purchaseReturnRepository.AttachNavigation(purchaseReturn.Purchasing);
                    _purchaseReturnRepository.Update(purchaseReturn);
                    _unitOfWork.SaveChanges();

                    List<PurchaseReturnDetail> listDetail = _purchaseReturnDetailRepository.GetMany(x => x.PurchaseReturnId == purchaseReturnID).ToList();
                    foreach (var itemDetail in listDetail)
                    {
                        itemDetail.Status = (int)DbConstant.DefaultDataStatus.Deleted;
                        itemDetail.ModifyDate = serverTime;
                        itemDetail.ModifyUserId = userID;

                        _purchaseReturnDetailRepository.AttachNavigation(itemDetail.CreateUser);
                        _purchaseReturnRepository.AttachNavigation(itemDetail.ModifyUser);
                        _purchaseReturnRepository.AttachNavigation(itemDetail.PurchaseReturn);
                        _purchaseReturnRepository.AttachNavigation(itemDetail.PurchasingDetail);
                        _purchaseReturnRepository.AttachNavigation(itemDetail.SparepartManualTransaction);
                        _purchaseReturnDetailRepository.Update(itemDetail);

                        Sparepart sparepart = _sparepartRepository.GetById(itemDetail.PurchasingDetail.SparepartId);
                        sparepart.StockQty += 1;


                        PurchasingDetail purchasingDetail = _purchasingDetailRepository.GetById(itemDetail.PurchasingDetailId);
                        purchasingDetail.QtyRemaining += itemDetail.Qty;
                        _purchasingDetailRepository.AttachNavigation(purchasingDetail.CreateUser);
                        _purchasingDetailRepository.AttachNavigation(purchasingDetail.ModifyUser);
                        _purchasingDetailRepository.Update(purchasingDetail);

                        _sparepartRepository.AttachNavigation(sparepart.CreateUser);
                        _sparepartRepository.AttachNavigation(sparepart.ModifyUser);
                        _sparepartRepository.AttachNavigation(sparepart.CategoryReference);
                        _sparepartRepository.AttachNavigation(sparepart.UnitReference);
                        _sparepartRepository.Update(sparepart);

                        SparepartStockCard stockCard = new SparepartStockCard();
                        stockCard.CreateUserId = userID;
                        stockCard.PurchaseDate = serverTime;
                        stockCard.PrimaryKeyValue = purchaseReturn.Id;
                        stockCard.ReferenceTableId = transactionReferenceTable.Id;
                        stockCard.SparepartId = sparepart.Id;
                        stockCard.Description = "Pembatalan Retur Pembelian";
                        stockCard.QtyIn = 1;
                        stockCard.QtyInPrice = Convert.ToDouble(itemDetail.PurchasingDetail.Price);
                        SparepartStockCard lastStockCard = _sparepartStokCardRepository.RetrieveLastCard(sparepart.Id);
                        double lastStock = 0;
                        double lastStockPrice = 0;
                        if (lastStockCard != null)
                        {
                            lastStock = lastStockCard.QtyLast;
                            lastStockPrice = lastStockCard.QtyLastPrice;
                        }
                        stockCard.QtyFirst = lastStock;
                        stockCard.QtyFirstPrice = lastStockPrice;
                        stockCard.QtyLast = lastStock + stockCard.QtyIn;
                        stockCard.QtyLastPrice = lastStockPrice + stockCard.QtyInPrice;
                        _sparepartStokCardRepository.AttachNavigation(stockCard.CreateUser);
                        _sparepartStokCardRepository.AttachNavigation(stockCard.Sparepart);
                        _sparepartStokCardRepository.AttachNavigation(stockCard.ReferenceTable);
                        stockCard = _sparepartStokCardRepository.Add(stockCard);
                        _unitOfWork.SaveChanges();

                        SparepartStockCardDetail stockCardDtail = new SparepartStockCardDetail();
                        stockCardDtail.ParentStockCard = stockCard;
                        stockCardDtail.PricePerItem = Convert.ToDouble(itemDetail.PurchasingDetail.Price);
                        stockCardDtail.QtyIn = 1;
                        stockCardDtail.QtyInPrice = Convert.ToDouble(itemDetail.PurchasingDetail.Price);
                        SparepartStockCardDetail lastStockCardDetail = _sparepartStokCardDetailRepository.RetrieveLastCardDetailByPurchasingId(sparepart.Id, purchaseReturn.PurchasingId);
                        double lastStockDetail = 0;
                        double lastStockDetailPrice = 0;
                        if (lastStockCardDetail != null)
                        {
                            lastStockDetail = lastStockCardDetail.QtyLast;
                            lastStockDetailPrice = lastStockCardDetail.QtyLastPrice;
                        }
                        stockCardDtail.QtyFirst = lastStockDetail;
                        stockCardDtail.QtyFirstPrice = lastStockDetailPrice;
                        stockCardDtail.QtyLast = lastStockDetail + stockCardDtail.QtyIn;
                        stockCardDtail.QtyLastPrice = lastStockDetailPrice + stockCardDtail.QtyInPrice;
                        stockCardDtail.PurchasingId = purchaseReturn.PurchasingId;

                        _sparepartStokCardDetailRepository.AttachNavigation(stockCardDtail.ParentStockCard);
                        _sparepartStokCardDetailRepository.Add(stockCardDtail);
                        _unitOfWork.SaveChanges();
                    }

                    _unitOfWork.SaveChanges();

                    Transaction transaction = _transactionRepository.GetMany(x => x.PrimaryKeyValue == purchaseReturnID && x.ReferenceTableId == transactionReferenceTable.Id).FirstOrDefault();
                    transaction.Status = (int)DbConstant.DefaultDataStatus.Deleted;
                    transaction.ModifyDate = serverTime;
                    transaction.ModifyUserId = userID;

                    _transactionRepository.AttachNavigation(transaction.CreateUser);
                    _transactionRepository.AttachNavigation(transaction.ModifyUser);
                    _transactionRepository.AttachNavigation(transaction.PaymentMethod);
                    _transactionRepository.AttachNavigation(transaction.ReferenceTable);
                    _transactionRepository.Update(transaction);

                    _unitOfWork.SaveChanges();
                    trans.Commit();
                }
                catch (Exception)
                {
                    trans.Rollback();
                    throw;
                }
            }
            
        }

        public List<PurchaseReturnDetail> RetrievePurchaseReturnDetail(int purchaseReturnID)
        {
            List<PurchaseReturnDetail> result = _purchaseReturnDetailRepository.GetMany(x => x.PurchaseReturnId == purchaseReturnID).ToList();
            return result;
        }

        public List<ReturnViewModel> GetReturnListDetail(int purchaseReturnID, int purchasingID)
        {
            List<ReturnViewModel> result = new List<ReturnViewModel>();
            List<PurchasingDetail> listPurchasingDetail = _purchasingDetailRepository.GetMany(x => x.PurchasingId == purchasingID).ToList();

            if (purchaseReturnID > 0)
            {
                List<PurchaseReturnDetail> listDetail = this.RetrievePurchaseReturnDetail(purchaseReturnID);
                if (listDetail != null && listDetail.Count > 0)
                {
                    foreach (var itemDetail in listPurchasingDetail)
                    {
                        result.Add(new ReturnViewModel
                        {
                            SparepartId = itemDetail.SparepartId,
                            SparepartName = itemDetail.Sparepart.Name,
                            //temp delete
                            //ReturQty = Convert.ToDecimal(listDetail.Where(x => x.Qty).Sum()),
                            ReturQtyLimit = itemDetail.Qty,
                            PricePerItem = itemDetail.Price,
                            SparepartCode = itemDetail.Sparepart.Code,
                            UnitName = itemDetail.Sparepart.UnitReference.Name
                        });
                    }
                }
            }
            return result;
        }
    }
}
