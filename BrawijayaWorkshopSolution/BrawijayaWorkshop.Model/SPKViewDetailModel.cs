﻿using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Database.Repositories;
using BrawijayaWorkshop.Infrastructure.Repository;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using BrawijayaWorkshop.Utils;

namespace BrawijayaWorkshop.Model
{
    public class SPKViewDetailModel : AppBaseModel
    {
        private IReferenceRepository _referenceRepository;
        private IVehicleRepository _vehicleRepository;
        private ISPKRepository _SPKRepository;
        private ISPKDetailSparepartRepository _SPKDetailSparepartRepository;
        private ISPKDetailSparepartDetailRepository _SPKDetailSparepartDetailRepository;
        private ISparepartRepository _sparepartRepository;
        //private ISparepartDetailRepository _sparepartDetailRepository;
        private IInvoiceRepository _invoiceRepository;
        private IInvoiceDetailRepository _invoiceDetailRepository;
        private IUsedGoodRepository _usedGoodRepository;
        private IUsedGoodTransactionRepository _usedGoodTransactionRepository;
        private IVehicleWheelRepository _vehicleWheelRepository;
        private IUnitOfWork _unitOfWork;
        private ISPKScheduleRepository _SPKScheduleRepository;
        private IMechanicRepository _mechanicRepository;
        private IWheelExchangeHistoryRepository _wheelExchangeHistoryRepository;
        //private ISpecialSparepartRepository _specialSparepartRepository;
        private ISpecialSparepartDetailRepository _specialSparepartDetailRepository;
        private ISparepartStockCardRepository _sparepartStokCardRepository;
        private ISparepartStockCardDetailRepository _sparepartStokCardDetailRepository;
        private ISettingRepository _settingRepository;
        private IPurchasingDetailRepository _purchasingDetailRepository;
        private ISparepartManualTransactionRepository _sparepartManualTransactionRepository;

        public SPKViewDetailModel(
            IReferenceRepository referenceRepository, 
            IVehicleRepository vehicleRepository,
            ISPKRepository SPKRepository, 
            ISPKDetailSparepartRepository SPKDetailSparePartRepository,
            ISPKDetailSparepartDetailRepository SPKDetailSparepartDetailRepository, 
            ISparepartRepository sparepartRepository,
            ISettingRepository settingRepository,
            IInvoiceRepository invoiceRepository,
            IInvoiceDetailRepository invoiceDetailRepository,
            IUsedGoodRepository usedGoodrepository,
            IUsedGoodTransactionRepository usedGoodTransactionRepository,
            IVehicleWheelRepository vehicleWheelRepository,
            ISPKScheduleRepository SPKScheduleReposistory,
            IMechanicRepository mechanicRepository,
            IWheelExchangeHistoryRepository wheelExchangeHistoryRepository,
            ISpecialSparepartDetailRepository specialSparepartDetailRepository,
            ISparepartStockCardRepository sparepartStockCardRepository,
            ISparepartStockCardDetailRepository sparepartStockCardDetailRepository,
            IPurchasingDetailRepository purchasingDetailRepository,
            ISparepartManualTransactionRepository sparepartManualTransactionRepository,
            IUnitOfWork unitOfWork)
            : base()
        {
            _referenceRepository = referenceRepository;
            _vehicleRepository = vehicleRepository;
            _SPKRepository = SPKRepository;
            _SPKDetailSparepartRepository = SPKDetailSparePartRepository;
            _SPKDetailSparepartDetailRepository = SPKDetailSparepartDetailRepository;
            _sparepartRepository = sparepartRepository;
            //_sparepartDetailRepository = sparepartDetailRepository;
            _settingRepository = settingRepository;
            _invoiceRepository = invoiceRepository;
            _invoiceDetailRepository = invoiceDetailRepository;
            _vehicleWheelRepository = vehicleWheelRepository;
            _usedGoodRepository = usedGoodrepository;
            _usedGoodTransactionRepository = usedGoodTransactionRepository;
            _SPKScheduleRepository = SPKScheduleReposistory;
            _mechanicRepository = mechanicRepository;
            _wheelExchangeHistoryRepository = wheelExchangeHistoryRepository;
            _specialSparepartDetailRepository = specialSparepartDetailRepository;
            //_specialSparepartRepository = specialSparepartRepository;
            _sparepartStokCardRepository = sparepartStockCardRepository;
            _sparepartStokCardDetailRepository = sparepartStockCardDetailRepository;
            _purchasingDetailRepository = purchasingDetailRepository;
            _sparepartManualTransactionRepository = sparepartManualTransactionRepository;
            _unitOfWork = unitOfWork;
        }

        public List<SPKDetailSparepartViewModel> GetSPKSparepartList(int spkId)
        {
            List<SPKDetailSparepart> result = _SPKDetailSparepartRepository.GetMany(sds => sds.SPKId == spkId).ToList();
            List<SPKDetailSparepartViewModel> mappedResult = new List<SPKDetailSparepartViewModel>();
            return Map(result, mappedResult);
        }

        public List<SPKDetailSparepartDetailViewModel> GetSPKSparepartDetailList(int spkId)
        {
            List<SPKDetailSparepartDetail> result = _SPKDetailSparepartDetailRepository.GetMany(sdsd => sdsd.SPKDetailSparepart.SPK.Id == spkId).ToList();
            List<SPKDetailSparepartDetailViewModel> mappedResult = new List<SPKDetailSparepartDetailViewModel>();
            return Map(result, mappedResult);
        }

        public bool ApproveSPK(SPKViewModel spk, List<SPKDetailSparepartViewModel> spkSparepartList, List<SPKDetailSparepartDetailViewModel> spkSparepartDetailList, int userId, bool isApproved, out List<SparepartViewModel> warningList)
        {
            bool result = false;
            using (var trans = _unitOfWork.BeginTransaction())
            {
                try
                {
                    bool hasParent = false;

                    warningList = new List<SparepartViewModel>();

                    DateTime serverTime = DateTime.Now;
                    SPK spkParent = _SPKRepository.GetById(spk.SPKParentId);

                    if (spkParent != null)
                    {
                        hasParent = true;
                    }

                    if (isApproved)
                    {
                        SPK entity = _SPKRepository.GetById(spk.Id);
                        entity.StatusApprovalId = (int)DbConstant.ApprovalStatus.Approved;
                        entity.StatusPrintId = (int)DbConstant.SPKPrintStatus.Ready;
                        entity.ModifyDate = serverTime;
                        entity.ModifyUserId = userId;

                        _SPKRepository.Update(entity);
                        _unitOfWork.SaveChanges();

                        foreach (var item in spkSparepartList)
                        {
                            Sparepart sparepart = _sparepartRepository.GetById(item.Sparepart.Id);
                            sparepart.StockQty = sparepart.StockQty - item.TotalQuantity;
                            sparepart.ModifyDate = serverTime;
                            sparepart.ModifyUserId = userId;

                            _sparepartRepository.Update(sparepart);

                            //if (sparepart.StockQty <= GetStockThreshold())
                            //{
                            //    SparepartViewModel viewModel = new SparepartViewModel();
                            //    Map(sparepart, viewModel);
                            //    warningList.Add(viewModel);
                            //}
                        }

                        _unitOfWork.SaveChanges();

                        List<PurchasingDetail> listPurchasingDetail = new List<PurchasingDetail>();
                        List<SparepartManualTransaction> listSparepartManualTrans = new List<SparepartManualTransaction>();
                        foreach (var spkSparepartDetail in spkSparepartDetailList)
                        {
                            if (spkSparepartDetail.PurchasingDetailId > 0)
                            {
                                PurchasingDetail pdt = _purchasingDetailRepository.GetById(spkSparepartDetail.PurchasingDetailId);

                                pdt.QtyRemaining = spkSparepartDetail.PurchasingDetail.QtyRemaining;
                                pdt.ModifyDate = serverTime;
                                pdt.ModifyUserId = userId;

                                _purchasingDetailRepository.Update(pdt);

                                listPurchasingDetail.Add(new PurchasingDetail
                                {
                                    PurchasingId = pdt.PurchasingId,
                                    Qty = spkSparepartDetail.Qty,
                                    Price = pdt.Price
                                });
                            }
                            else if (spkSparepartDetail.SparepartManualTransactionId > 0)
                            {
                                SparepartManualTransaction spm = _sparepartManualTransactionRepository.GetById(spkSparepartDetail.SparepartManualTransactionId);

                                spm.QtyRemaining = spkSparepartDetail.SparepartManualTransaction.QtyRemaining;
                                spm.ModifyDate = serverTime;
                                spm.ModifyUserId = userId;

                                _sparepartManualTransactionRepository.Update(spm);

                                listSparepartManualTrans.Add(new SparepartManualTransaction
                                {
                                    Id = spm.Id,
                                    Qty = spkSparepartDetail.Qty,
                                    Price = spm.Price
                                });
                            }

                            _unitOfWork.SaveChanges();
                        }

                        foreach (var item in spkSparepartList)
                        {
                            SparepartStockCard stockCard = new SparepartStockCard();
                            Reference transactionReferenceTable = _referenceRepository.GetMany(r => r.Code == DbConstant.REF_TRANSTBL_SPK).FirstOrDefault();

                            stockCard.CreateUserId = userId;
                            stockCard.PurchaseDate = serverTime;
                            stockCard.PrimaryKeyValue = spk.Id;
                            stockCard.ReferenceTableId = transactionReferenceTable.Id;
                            stockCard.SparepartId = item.Id;
                            stockCard.Description = "SPK";
                            stockCard.QtyOut = item.TotalQuantity;
                            stockCard.QtyOutPrice = Convert.ToDouble(listPurchasingDetail.Sum(x => x.Price * x.Qty) + listSparepartManualTrans.Sum(x => x.Price * x.Qty));

                            SparepartStockCard lastStockCard = _sparepartStokCardRepository.RetrieveLastCard(item.Id);
                            double lastStock = 0;
                            double lastStockPrice = 0;
                            if (lastStockCard != null)
                            {
                                lastStock = lastStockCard.QtyLast;
                                lastStockPrice = lastStockCard.QtyLastPrice;
                            }
                            stockCard.QtyFirst = lastStock;
                            stockCard.QtyFirstPrice = lastStockPrice;
                            stockCard.QtyLast = lastStock - stockCard.QtyOut;
                            stockCard.QtyLastPrice = lastStockPrice - stockCard.QtyOutPrice;

                            _sparepartStokCardRepository.AttachNavigation(stockCard.CreateUser);
                            _sparepartStokCardRepository.AttachNavigation(stockCard.Sparepart);
                            _sparepartStokCardRepository.AttachNavigation(stockCard.ReferenceTable);

                            stockCard = _sparepartStokCardRepository.Add(stockCard);
                            _unitOfWork.SaveChanges();

                            if (listPurchasingDetail.Count > 0)
                            {
                                List<PurchasingDetailViewModel> listPurchasing = listPurchasingDetail
                                                .GroupBy(l => l.PurchasingId)
                                                .Select(cl => new PurchasingDetailViewModel
                                                {
                                                    PurchasingId = cl.Key,
                                                    Qty = cl.Sum(x => x.Qty),
                                                    Price = cl.First().Price
                                                }).ToList();

                                foreach (var itemPurchasing in listPurchasing)
                                {
                                    SparepartStockCardDetail stockCardDtail = new SparepartStockCardDetail();
                                    stockCardDtail.ParentStockCard = stockCard;
                                    stockCardDtail.PricePerItem = Convert.ToDouble(itemPurchasing.Price);
                                    stockCardDtail.QtyOut = itemPurchasing.Qty;
                                    stockCardDtail.QtyOutPrice = Convert.ToDouble(itemPurchasing.Qty * itemPurchasing.Price);
                                    SparepartStockCardDetail lastStockCardDetail = _sparepartStokCardDetailRepository.RetrieveLastCardDetailByPurchasingId(item.Id, itemPurchasing.PurchasingId);
                                    double lastStockDetail = 0;
                                    double lastStockDetailPrice = 0;
                                    if (lastStockCardDetail != null)
                                    {
                                        lastStockDetail = lastStockCardDetail.QtyLast;
                                        lastStockDetailPrice = lastStockCardDetail.QtyLastPrice;
                                    }
                                    stockCardDtail.QtyFirst = lastStockDetail;
                                    stockCardDtail.QtyFirstPrice = lastStockDetailPrice;
                                    stockCardDtail.QtyLast = lastStockDetail - stockCardDtail.QtyOut;
                                    stockCardDtail.QtyLastPrice = lastStockDetailPrice - stockCardDtail.QtyOutPrice;
                                    stockCardDtail.PurchasingId = itemPurchasing.PurchasingId;

                                    _sparepartStokCardDetailRepository.AttachNavigation(stockCardDtail.ParentStockCard);
                                    _sparepartStokCardDetailRepository.Add(stockCardDtail);
                                    _unitOfWork.SaveChanges();
                                }
                            }

                            if (listSparepartManualTrans.Count > 0)
                            {
                                List<SparepartManualTransactionViewModel> listSpManual = listSparepartManualTrans
                                                .GroupBy(l => l.Id)
                                                .Select(cl => new SparepartManualTransactionViewModel
                                                {
                                                    Id = cl.Key,
                                                    Qty = cl.Sum(x => x.Qty),
                                                    Price = cl.First().Price
                                                }).ToList();
                                foreach (var itemSpTrans in listSpManual)
                                {
                                    SparepartStockCardDetail stockCardDtail = new SparepartStockCardDetail();
                                    stockCardDtail.ParentStockCard = stockCard;
                                    stockCardDtail.PricePerItem = Convert.ToDouble(itemSpTrans.Price);
                                    stockCardDtail.QtyOut = itemSpTrans.Qty;
                                    stockCardDtail.QtyOutPrice = Convert.ToDouble(itemSpTrans.Qty * itemSpTrans.Price);
                                    SparepartStockCardDetail lastStockCardDetail = _sparepartStokCardDetailRepository.RetrieveLastCardDetailByTransactionManualId(item.Id, itemSpTrans.Id);
                                    double lastStockDetail = 0;
                                    double lastStockDetailPrice = 0;
                                    if (lastStockCardDetail != null)
                                    {
                                        lastStockDetail = lastStockCardDetail.QtyLast;
                                        lastStockDetailPrice = lastStockCardDetail.QtyLastPrice;
                                    }
                                    stockCardDtail.QtyFirst = lastStockDetail;
                                    stockCardDtail.QtyFirstPrice = lastStockDetailPrice;
                                    stockCardDtail.QtyLast = lastStockDetail - stockCardDtail.QtyOut;
                                    stockCardDtail.QtyLastPrice = lastStockDetailPrice - stockCardDtail.QtyOutPrice;
                                    stockCardDtail.SparepartManualTransactionId = itemSpTrans.Id;

                                    _sparepartStokCardDetailRepository.AttachNavigation(stockCardDtail.ParentStockCard);
                                    _sparepartStokCardDetailRepository.Add(stockCardDtail);
                                    _unitOfWork.SaveChanges();
                                }
                            }
                        }
                        _unitOfWork.SaveChanges();

                        result = true;
                    }
                    else
                    {

                        SPK entity = _SPKRepository.GetById(spk.Id);
                        entity.StatusApprovalId = (int)DbConstant.ApprovalStatus.Approved;
                        entity.StatusPrintId = (int)DbConstant.SPKPrintStatus.Ready;
                        entity.ModifyDate = serverTime;
                        entity.ModifyUserId = userId;

                        if (spk.SPKParent == null)
                        {
                            entity.SPKParent = null;
                        }
                        _SPKRepository.Update(entity);

                        _unitOfWork.SaveChanges();

                        if (hasParent)
                        {
                            spkParent.StatusApprovalId = (int)DbConstant.ApprovalStatus.Approved;
                            spkParent.StatusCompletedId = (int)DbConstant.SPKCompletionStatus.InProgress;
                            spkParent.Status = (int)DbConstant.DefaultDataStatus.Active;

                            spkParent.ModifyDate = serverTime;
                            spkParent.ModifyUserId = userId;

                            _SPKRepository.Update(spkParent);

                            _unitOfWork.SaveChanges();
                        }
                        result = true;
                    }

                    trans.Commit();
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    throw;
                }
            }

            warningList = new List<SparepartViewModel>();

            return result;
        }

        public void PrintSPK(SPKViewModel spk, int userId)
        {
            DateTime serverTime = DateTime.Now;
            SPK entity = _SPKRepository.GetById(spk.Id);
            entity.StatusPrintId = (int)DbConstant.SPKPrintStatus.Printed;
            entity.ModifyDate = serverTime;
            entity.ModifyUserId = userId;
            _SPKRepository.Update(entity);

            _unitOfWork.SaveChanges();
        }


        public void AbortSPK(SPKViewModel spk, List<SPKDetailSparepartViewModel> spkSparepartList, List<SPKDetailSparepartDetailViewModel> spkSparepartDetailList, int userId)
        {
            DateTime serverTime = DateTime.Now;

            SPK entity = _SPKRepository.GetById(spk.Id);
            entity.Status = (int)DbConstant.DefaultDataStatus.Deleted;
            entity.ModifyDate = serverTime;
            entity.ModifyUserId = userId;

            _SPKRepository.Update(entity);

            foreach (var item in spkSparepartList)
            {
                Sparepart sparepart = _sparepartRepository.GetById(item.Sparepart.Id);
                sparepart.StockQty = sparepart.StockQty + item.TotalQuantity;
                sparepart.ModifyDate = serverTime;
                sparepart.ModifyUserId = userId;

                _sparepartRepository.Update(sparepart);
            }

            List<PurchasingDetail> listPurchasingDetail = new List<PurchasingDetail>();
            List<SparepartManualTransaction> listSparepartManualTrans = new List<SparepartManualTransaction>();

            foreach (var spkSparepartDetail in spkSparepartDetailList)
            {
                if (spkSparepartDetail.PurchasingDetailId > 0)
                {
                    PurchasingDetail pdt = _purchasingDetailRepository.GetById(spkSparepartDetail.PurchasingDetailId);
                    listPurchasingDetail.Add(pdt);
                }
                else if (spkSparepartDetail.SparepartManualTransactionId > 0)
                {
                    SparepartManualTransaction spm = _sparepartManualTransactionRepository.GetById(spkSparepartDetail.SparepartManualTransactionId);
                    listSparepartManualTrans.Add(spm);
                }

                if (spkSparepartDetail.SPKDetailSparepart.Sparepart.IsWheel)
                {
                    SpecialSparepartDetail sspd = _specialSparepartDetailRepository.GetById(spkSparepartDetail.SpecialSparepartDetailId);
                    sspd.Status = (int)DbConstant.WheelDetailStatus.Ready;
                }
            }

            _unitOfWork.SaveChanges();

            foreach (var spkSp in _SPKDetailSparepartRepository.GetMany(sds => sds.SPKId == entity.Id))
            {
                SparepartStockCard stockCard = new SparepartStockCard();
                Reference transactionReferenceTable = _referenceRepository.GetMany(r => r.Code == DbConstant.REF_TRANSTBL_SPK).FirstOrDefault();

                stockCard.CreateUserId = userId;
                stockCard.PurchaseDate = serverTime;
                stockCard.PrimaryKeyValue = spk.Id;
                stockCard.ReferenceTableId = transactionReferenceTable.Id;
                stockCard.SparepartId = spkSp.SparepartId;
                stockCard.Description = "Pembatalan SPK";
                stockCard.QtyIn = spkSp.TotalQuantity;
                stockCard.QtyInPrice = Convert.ToDouble(listPurchasingDetail.Sum(x => x.Price) + listSparepartManualTrans.Sum(x => x.Price));

                SparepartStockCard lastStockCard = _sparepartStokCardRepository.RetrieveLastCard(spkSp.SparepartId);
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

                if (listPurchasingDetail.Count > 0)
                {
                    List<PurchasingDetailViewModel> listPurchasing = listPurchasingDetail
                                    .GroupBy(l => l.PurchasingId)
                                    .Select(cl => new PurchasingDetailViewModel
                                    {
                                        PurchasingId = cl.Key,
                                        Qty = cl.Count(),
                                        Price = cl.First().Price,
                                        SparepartId = cl.First().SparepartId
                                    }).ToList();

                    foreach (var itemPurchasing in listPurchasing)
                    {
                        SparepartStockCardDetail stockCardDtail = new SparepartStockCardDetail();
                        stockCardDtail.ParentStockCard = stockCard;
                        stockCardDtail.PricePerItem = Convert.ToDouble(itemPurchasing.Price);
                        stockCardDtail.QtyIn = itemPurchasing.Qty;
                        stockCardDtail.QtyInPrice = Convert.ToDouble(itemPurchasing.Qty * itemPurchasing.Price);
                        SparepartStockCardDetail lastStockCardDetail = _sparepartStokCardDetailRepository.RetrieveLastCardDetailByPurchasingId(itemPurchasing.SparepartId, itemPurchasing.PurchasingId);
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
                        stockCardDtail.PurchasingId = itemPurchasing.PurchasingId;

                        _sparepartStokCardDetailRepository.AttachNavigation(stockCardDtail.ParentStockCard);
                        _sparepartStokCardDetailRepository.Add(stockCardDtail);
                        _unitOfWork.SaveChanges();
                    }
                }

                if (listSparepartManualTrans.Count > 0)
                {
                    List<SparepartManualTransactionViewModel> listSpManual = listSparepartManualTrans
                                    .GroupBy(l => l.Id)
                                    .Select(cl => new SparepartManualTransactionViewModel
                                    {
                                        Id = cl.Key,
                                        Qty = cl.Count(),
                                        Price = cl.First().Price,
                                        SparepartId = cl.First().SparepartId
                                    }).ToList();
                    foreach (var itemSpTrans in listSpManual)
                    {
                        SparepartStockCardDetail stockCardDtail = new SparepartStockCardDetail();
                        stockCardDtail.ParentStockCard = stockCard;
                        stockCardDtail.PricePerItem = Convert.ToDouble(itemSpTrans.Price);
                        stockCardDtail.QtyIn = itemSpTrans.Qty;
                        stockCardDtail.QtyInPrice = Convert.ToDouble(itemSpTrans.Qty * itemSpTrans.Price);
                        SparepartStockCardDetail lastStockCardDetail = _sparepartStokCardDetailRepository.RetrieveLastCardDetailByTransactionManualId(itemSpTrans.SparepartId, itemSpTrans.Id);
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
                        stockCardDtail.SparepartManualTransactionId = itemSpTrans.Id;

                        _sparepartStokCardDetailRepository.AttachNavigation(stockCardDtail.ParentStockCard);
                        _sparepartStokCardDetailRepository.Add(stockCardDtail);
                        _unitOfWork.SaveChanges();
                    }
                }


            }

            List<SPKSchedule> scheduleList = _SPKScheduleRepository.GetMany(sched => sched.SPKId == spk.Id).ToList();

            foreach (SPKSchedule schedule in scheduleList)
            {
                _SPKScheduleRepository.Delete(schedule);
            }

            List<WheelExchangeHistory> wehList = _wheelExchangeHistoryRepository.GetMany(weh => weh.SPKId == spk.Id).ToList();

            foreach (var item in wehList)
            {
                _wheelExchangeHistoryRepository.Delete(item);

            }

            _unitOfWork.SaveChanges();
        }

        public void RequestPrintSPK(SPKViewModel spk, int userId)
        {
            DateTime serverTime = DateTime.Now;
            SPK entity = _SPKRepository.GetById(spk.Id);
            entity.StatusPrintId = (int)DbConstant.SPKPrintStatus.Pending;
            entity.ModifyDate = serverTime;
            entity.ModifyUserId = userId;
            _SPKRepository.Update(entity);

            _unitOfWork.SaveChanges();
        }

        public void ApprovePrintSPK(SPKViewModel spk, int userId, bool isApproved)
        {
            DateTime serverTime = DateTime.Now;
            SPK entity = _SPKRepository.GetById(spk.Id);
            if (isApproved)
            {
                entity.StatusPrintId = (int)DbConstant.SPKPrintStatus.Ready;
            }
            else
            {
                entity.StatusPrintId = (int)DbConstant.SPKPrintStatus.Printed;
            }

            entity.ModifyDate = serverTime;
            entity.ModifyUserId = userId;

            _SPKRepository.Update(entity);

            _unitOfWork.SaveChanges();
        }

        public void SetAsCompletedSPK(SPKViewModel spk, int userId)
        {
            using (var trans = _unitOfWork.BeginTransaction())
            {
                try
                {
                    DateTime serverTime = DateTime.Now;

                    SPK entity = _SPKRepository.GetById(spk.Id);
                    entity.StatusCompletedId = (int)DbConstant.SPKCompletionStatus.Completed;
                    entity.ModifyDate = serverTime;
                    entity.ModifyUserId = userId;

                    _SPKRepository.Update(entity);

                    Invoice invc = new Invoice();
                    invc.CreateDate = serverTime;
                    invc.ModifyDate = serverTime;
                    invc.ModifyUserId = userId;
                    invc.CreateUserId = userId;

                    invc.Code = spk.Code.Replace("SPK", "INVC");

                    invc.TotalSparepart = spk.TotalSparepartPrice;
                    invc.TotalFeeSparepart = 0;
                    invc.TotalSparepartPlusFee = invc.TotalSparepart + invc.TotalFeeSparepart;

                    invc.PaymentStatus = (int)DbConstant.PaymentStatus.NotSettled;
                    invc.Status = (int)DbConstant.InvoiceStatus.FeeNotFixed;
                    invc.PaymentMethod = _referenceRepository.GetMany(r => r.Code == DbConstant.REF_INVOICE_PAYMENTMETHOD_PIUTANG).FirstOrDefault();
                    invc.TotalHasPaid = 0;
                    invc.SPKId = spk.Id;

                    if (spk.isContractWork)
                    {
                        invc.TotalService = spk.ContractWorkFee;
                        invc.TotalFeeService = (spk.ContractWorkFee * (0.2).AsDecimal());
                    }
                    else
                    {
                        decimal ServiceFee = 0;

                        TimeSpan SPKTimeSpan = serverTime - spk.CreateDate;
                        int SPKWorkingDays = Math.Ceiling(SPKTimeSpan.TotalDays).AsInteger();

                        for (int i = 0; i < SPKWorkingDays; i++)
                        {
                            List<Mechanic> involvedMechanic = (from sched in _SPKScheduleRepository.GetMany(sc => sc.Date.Day == spk.CreateDate.Day + i && sc.SPKId == spk.Id).ToList()
                                                               select sched.Mechanic).ToList();

                            foreach (Mechanic mechanic in involvedMechanic)
                            {
                                int mechanicJobForToday = _SPKScheduleRepository.GetMany(sc => sc.Date.Day == spk.CreateDate.Day + i && sc.MechanicId == mechanic.Id).Count();

                                decimal mechanicFeeForToday = mechanic.BaseFee / mechanicJobForToday;

                                ServiceFee = ServiceFee + mechanicFeeForToday;
                            }
                        }

                        invc.TotalService = ServiceFee;
                        invc.TotalFeeService = 0;
                    }
                    invc.TotalServicePlusFee = invc.TotalService + invc.TotalFeeService;
                    invc.TotalSparepartAndService = invc.TotalSparepartPlusFee + invc.TotalServicePlusFee;
                    invc.TotalValueAdded = (invc.TotalSparepartAndService * (0.1).AsDecimal());
                    invc.TotalPrice = invc.TotalValueAdded + invc.TotalSparepartAndService;

                    _invoiceRepository.AttachNavigation<SPK>(invc.SPK);
                    _invoiceRepository.AttachNavigation<Reference>(invc.PaymentMethod);
                    Invoice insertedInvoice = _invoiceRepository.Add(invc);

                    List<SPKDetailSparepart> SPKSpList = _SPKDetailSparepartRepository.GetMany(sp => sp.SPKId == spk.Id).ToList();
                    List<SPKDetailSparepartDetail> SPKSpDetailList = _SPKDetailSparepartDetailRepository.GetMany(spdt => spdt.SPKDetailSparepart.SPKId == spk.Id).ToList();

                    foreach (SPKDetailSparepart spkSp in SPKSpList)
                    {
                        UsedGood foundUsedGood = _usedGoodRepository.GetMany(ug => ug.SparepartId == spkSp.SparepartId && ug.Status == (int)DbConstant.DefaultDataStatus.Active).FirstOrDefault();
                        if (foundUsedGood != null)
                        {
                            int usedGoodQty = SPKSpDetailList.Where(sp => sp.SPKDetailSparepart.SparepartId == foundUsedGood.SparepartId).ToList().Count;
                            foundUsedGood.Stock = foundUsedGood.Stock + usedGoodQty;
                            _usedGoodRepository.Update(foundUsedGood);
                            _unitOfWork.SaveChanges();

                            UsedGoodTransaction usedGoodTrans = new UsedGoodTransaction();
                            usedGoodTrans.CreateDate = usedGoodTrans.ModifyDate = serverTime;
                            usedGoodTrans.CreateUserId = usedGoodTrans.ModifyUserId = userId;
                            usedGoodTrans.UsedGoodId = foundUsedGood.Id;
                            usedGoodTrans.TransactionDate = spk.CreateDate;
                            usedGoodTrans.Qty = usedGoodQty;
                            usedGoodTrans.ItemPrice = 0;
                            usedGoodTrans.TotalPrice = 0;
                            usedGoodTrans.TypeReferenceId = _referenceRepository.GetMany(r => r.Code == DbConstant.REF_USEDGOOD_TRANSACTION_TYPE_SPK).FirstOrDefault().Id;
                            usedGoodTrans.Remark = string.Format("SPK Code: {0}", spk.Code);
                            _usedGoodTransactionRepository.Add(usedGoodTrans);
                            _unitOfWork.SaveChanges();
                        }

                        //Replace Vehicle Wheel
                        foreach (var item in getCurrentVehicleWheel(spk.VehicleId, spk.Id).Where(w => w.ReplaceWithWheelDetailId > 0))
                        {
                            VehicleWheel vw = _vehicleWheelRepository.GetById(item.Id);

                            vw.WheelDetailId = item.ReplaceWithWheelDetailId;
                            vw.ModifyDate = serverTime;
                            vw.ModifyUserId = userId;

                            _vehicleWheelRepository.Update(vw);

                            //UsedGood usedWHeel = _usedGoodRepository.GetMany(ug => ug.SparepartId == item.WheelDetail.SparepartDetail.SparepartId).FirstOrDefault();
                            //if (usedWHeel != null)
                            //{
                            //    usedWHeel.Stock++;

                            //    _usedGoodRepository.Update(usedWHeel);
                            //}
                        }
                        _unitOfWork.SaveChanges();

                        //Remove Wheel Exchange
                        List<WheelExchangeHistory> wehList = _wheelExchangeHistoryRepository.GetMany(weh => weh.SPKId == spk.Id).ToList();

                        foreach (var item in wehList)
                        {
                            _wheelExchangeHistoryRepository.Delete(item);
                        }
                        _unitOfWork.SaveChanges();

                    }

                    foreach (SPKDetailSparepartDetail spkSpDtl in SPKSpDetailList)
                    {
                        InvoiceDetail invcDtl = new InvoiceDetail();

                        invcDtl.Invoice = insertedInvoice;
                        invcDtl.SPKDetailSparepartDetail = spkSpDtl;

                        if (spkSpDtl.PurchasingDetailId > 0)
                        {
                            invcDtl.SubTotalPrice = spkSpDtl.PurchasingDetail.Price.AsDouble();
                        }
                        else if (spkSpDtl.SparepartManualTransactionId > 0)
                        {
                            invcDtl.SubTotalPrice = spkSpDtl.SparepartManualTransaction.Price.AsDouble();
                        }

                        invcDtl.Status = (int)DbConstant.DefaultDataStatus.Active;

                        invcDtl.CreateDate = serverTime;
                        invcDtl.ModifyDate = serverTime;
                        invcDtl.ModifyUserId = userId;
                        invcDtl.CreateUserId = userId;

                        _invoiceDetailRepository.Add(invcDtl);
                    }

                    _unitOfWork.SaveChanges();
                    trans.Commit();
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    throw;
                }
            }

        }


        public int GetStockThreshold()
        {
            int result = 0;

            string threshold = _settingRepository.GetMany(s => s.Key == DbConstant.SETTING_SPK_THRESHOLD_P).FirstOrDefault().Value;

            int.TryParse(threshold, out result);

            return result;
        }

        public List<VehicleWheelViewModel> getCurrentVehicleWheel(int vehicleId, int SPKId)
        {
            List<VehicleWheel> result = _vehicleWheelRepository.GetMany(
                  vw => vw.Vehicle.Id == vehicleId && vw.Status == (int)DbConstant.DefaultDataStatus.Active).ToList();

            List<VehicleWheelViewModel> mappedResult = new List<VehicleWheelViewModel>();

            Map(result, mappedResult);

            foreach (var item in mappedResult)
            {
                WheelExchangeHistory wheel = _wheelExchangeHistoryRepository.GetMany(w => w.SPKId == SPKId && w.OriginalWheelId == item.WheelDetailId).FirstOrDefault();
                if (wheel != null)
                {
                    item.ReplaceWithWheelDetailId = wheel.ReplaceWheelId;
                    item.ReplaceWithWheelDetailSerialNumber = wheel.ReplaceWheel.SerialNumber;

                    if (wheel.ReplaceWheel.PurchasingDetailId > 0)
                    {
                        item.Price = wheel.ReplaceWheel.PurchasingDetail.Price;
                    }
                    else if (wheel.ReplaceWheel.SparepartManualTransactionId > 0)
                    {
                        item.Price = wheel.ReplaceWheel.SparepartManualTransaction.Price;
                    }
                }
            }

            return mappedResult;
        }
    }
}
