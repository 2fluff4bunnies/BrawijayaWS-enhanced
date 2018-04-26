using BrawijayaWorkshop.Constant;
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
    public class SalesReturnEditorModel : AppBaseModel
    {
        private ISalesReturnRepository _salesReturnRepository;
        private ISalesReturnDetailRepository _salesReturnDetailRepository;
        private IInvoiceRepository _invoiceRepository;
        private IInvoiceDetailRepository _invoiceDetailRepository;
        private ISparepartRepository _sparepartRepository;
        private IReferenceRepository _referenceRepository;
        private ITransactionRepository _transactionRepository;
        private ITransactionDetailRepository _transactionDetailRepository;
        private IJournalMasterRepository _journalMasterRepository;
        private ISpecialSparepartDetailRepository _specialSparepartDetailRepository;
        private ISparepartStockCardRepository _sparepartStokCardRepository;
        private ISparepartStockCardDetailRepository _sparepartStokCardDetailRepository;
        private IPurchasingDetailRepository _purchasingDetailRepository;
        private ISparepartManualTransactionRepository _sparepartManualTransactionRepository;
        IUnitOfWork _unitOfWork;

        public SalesReturnEditorModel(
            ISalesReturnRepository salesReturnRepository,
            ISalesReturnDetailRepository salesReturnDetailRepository,
            IInvoiceRepository invoiceRepository,
            IInvoiceDetailRepository invoiceDetailRepository,
            ISparepartRepository sparepartRepository,
            IReferenceRepository referenceRepository,
            ITransactionRepository transactionRepository,
            ITransactionDetailRepository transactionDetailRepository,
            IJournalMasterRepository journalMasterRepository,
            ISpecialSparepartDetailRepository specialSparepartDetailRepository,
            ISparepartStockCardRepository sparepartStockCardRepository,
            ISparepartStockCardDetailRepository sparepartStockCardDetailRepository,
            IPurchasingDetailRepository purchasingDetailRepository,
            ISparepartManualTransactionRepository sparepartManualTransactionRepository,
            IUnitOfWork unitOfWork)
            : base()
        {
            _salesReturnRepository = salesReturnRepository;
            _salesReturnDetailRepository = salesReturnDetailRepository;
            _invoiceRepository = invoiceRepository;
            _invoiceDetailRepository = invoiceDetailRepository;
            _sparepartRepository = sparepartRepository;
            _transactionRepository = transactionRepository;
            _transactionDetailRepository = transactionDetailRepository;
            _journalMasterRepository = journalMasterRepository;
            _referenceRepository = referenceRepository;
            _specialSparepartDetailRepository = specialSparepartDetailRepository;
            _sparepartStokCardRepository = sparepartStockCardRepository;
            _sparepartStokCardDetailRepository = sparepartStockCardDetailRepository;
            _purchasingDetailRepository = purchasingDetailRepository;
            _sparepartManualTransactionRepository = sparepartManualTransactionRepository;
            _unitOfWork = unitOfWork;
        }

        public List<SalesReturnDetail> RetrieveSalesReturnDetail(int salesReturnID)
        {
            List<SalesReturnDetail> result = _salesReturnDetailRepository.GetMany(x => x.SalesReturnId == salesReturnID).ToList();
            return result;
        }

        public List<ReturnViewModel> RetrieveReturnList(int salesReturnID, int invoiceID)
        {
            List<ReturnViewModel> result = new List<ReturnViewModel>();
            List<InvoiceDetail> listInvoiceDetail = _invoiceDetailRepository.GetMany(x => x.InvoiceId == invoiceID).ToList();

            if (salesReturnID > 0)
            {
                List<SalesReturnDetail> listDetail = this.RetrieveSalesReturnDetail(salesReturnID);
                if (listDetail != null && listDetail.Count > 0)
                {
                    int[] sparepartIDs = listInvoiceDetail.Select(x => x.SPKDetailSparepartDetail.SPKDetailSparepart.SparepartId).Distinct().ToArray();
                    foreach (var sparepartID in sparepartIDs)
                    {
                        bool isSpecial = _sparepartRepository.GetMany(x => x.Id == sparepartID && x.IsSpecialSparepart).Count() > 0;
                        if(isSpecial)
                        {
                            List<InvoiceDetail> listInvoiceDetailSparepart = listInvoiceDetail.Where(x => x.SPKDetailSparepartDetail.SPKDetailSparepart.SparepartId == sparepartID).ToList();
                            foreach (var itemInvoiceSparepart in listInvoiceDetailSparepart)
                            {
                                result.Add(new ReturnViewModel
                                {
                                    SparepartId = sparepartID,
                                    SparepartName = _sparepartRepository.GetById(sparepartID).Name,
                                    ReturQty = listDetail.Where(x => x.InvoiceDetailId == itemInvoiceSparepart.Id).Count(),
                                    ReturQtyLimit = 1,
                                    SerialNumber = itemInvoiceSparepart.SPKDetailSparepartDetail.PurchasingDetail != null ? _specialSparepartDetailRepository.GetMany(x => x.PurchasingDetailId == itemInvoiceSparepart.SPKDetailSparepartDetail.PurchasingDetailId).FirstOrDefault().SerialNumber
                                    : _specialSparepartDetailRepository.GetMany(x => x.SparepartManualTransactionId == itemInvoiceSparepart.SPKDetailSparepartDetail.SparepartManualTransactionId).FirstOrDefault().SerialNumber
                                });
                            }
                        }
                        else
                        {
                            result.Add(new ReturnViewModel
                            {
                                SparepartId = sparepartID,
                                SparepartName = _sparepartRepository.GetById(sparepartID).Name,
                                ReturQty = listDetail.Where(x => x.InvoiceDetail.SPKDetailSparepartDetail.SPKDetailSparepart.SparepartId == sparepartID).Count(),
                                ReturQtyLimit = listInvoiceDetail.Where(x => x.SPKDetailSparepartDetail.SPKDetailSparepart.SparepartId == sparepartID).Count()
                            });
                        }
                        
                    }
                }
            }
            else
            {
                int[] sparepartIDs = listInvoiceDetail.Select(x => x.SPKDetailSparepartDetail.SPKDetailSparepart.SparepartId).Distinct().ToArray();
                foreach (var sparepartID in sparepartIDs)
                {
                    bool isSpecial = _sparepartRepository.GetMany(x => x.Id == sparepartID && x.IsSpecialSparepart).Count() > 0;
                    if (isSpecial)
                    {
                        List<InvoiceDetail> listInvoiceDetailSparepart = listInvoiceDetail.Where(x => x.SPKDetailSparepartDetail.SPKDetailSparepart.SparepartId == sparepartID).ToList();
                        foreach (var itemInvoiceSparepart in listInvoiceDetailSparepart)
                        {
                            result.Add(new ReturnViewModel
                            {
                                SparepartId = sparepartID,
                                SparepartName = _sparepartRepository.GetById(sparepartID).Name,
                                ReturQty = 1,
                                ReturQtyLimit = 1,
                                SerialNumber = itemInvoiceSparepart.SPKDetailSparepartDetail.PurchasingDetail != null ? _specialSparepartDetailRepository.GetMany(x => x.PurchasingDetailId == itemInvoiceSparepart.SPKDetailSparepartDetail.PurchasingDetailId).FirstOrDefault().SerialNumber
                                    : _specialSparepartDetailRepository.GetMany(x => x.SparepartManualTransactionId == itemInvoiceSparepart.SPKDetailSparepartDetail.SparepartManualTransactionId).FirstOrDefault().SerialNumber
                            });
                        }
                    }
                    else
                    {
                        result.Add(new ReturnViewModel
                        {
                            SparepartId = sparepartID,
                            SparepartName = _sparepartRepository.GetById(sparepartID).Name,
                            ReturQty = listInvoiceDetail.Where(x => x.SPKDetailSparepartDetail.SPKDetailSparepart.SparepartId == sparepartID).Count(),
                            ReturQtyLimit = listInvoiceDetail.Where(x => x.SPKDetailSparepartDetail.SPKDetailSparepart.SparepartId == sparepartID).Count()
                        });
                    }
                }
            }
            return result;
        }

        public void InsertSalesReturn(int invoiceID, List<ReturnViewModel> listReturn, int userID)
        {
            using(var trans = _unitOfWork.BeginTransaction())
            {
                try
                {
                    InsertSalesReturnFunc(invoiceID, listReturn, userID);
                    trans.Commit();
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    throw;
                }
            }
        }

        public void UpdateSalesReturn(int invoiceID, int salesReturnID, List<ReturnViewModel> listReturn, int userID)
        {
            using (var trans = _unitOfWork.BeginTransaction())
            {
                try
                {
                    DeleteSalesReturnFunc(salesReturnID, userID);
                    InsertSalesReturnFunc(invoiceID, listReturn, userID);
                    trans.Commit();
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    throw;
                }
            }
        }

        public void InsertSalesReturnFunc(int invoiceID, List<ReturnViewModel> listReturn, int userID)
        {
            DateTime serverTime = DateTime.Now;
            
            Reference transactionReferenceTable = _referenceRepository.GetMany(c => c.Code == DbConstant.REF_TRANSTBL_SALESRETURN).FirstOrDefault();
            
            SalesReturn salesReturn = new SalesReturn();
            salesReturn.CreateDate = serverTime;
            salesReturn.CreateUserId = userID;
            salesReturn.ModifyDate = serverTime;
            salesReturn.ModifyUserId = userID;
            salesReturn.InvoiceId = invoiceID;
            salesReturn.Date = serverTime;
            salesReturn.Status = (int)DbConstant.DefaultDataStatus.Active;

            string code = "SLR" + "-" + serverTime.Month.ToString() + serverTime.Day.ToString() + "-";
            //get total sales return created today
            List<SalesReturn> todaySLR = _salesReturnRepository.GetMany(s => s.Code.ToString().Contains(code) && s.CreateDate.Year == serverTime.Year).ToList();
            code = code + (todaySLR.Count + 1);
            salesReturn.Code = code;

            _salesReturnRepository.AttachNavigation(salesReturn.CreateUser);
            _salesReturnRepository.AttachNavigation(salesReturn.ModifyUser);
            _salesReturnRepository.AttachNavigation(salesReturn.Invoice);
            salesReturn = _salesReturnRepository.Add(salesReturn);

            _unitOfWork.SaveChanges();

            List<SalesReturnDetail> listReturnDetail = new List<SalesReturnDetail>();

            decimal totalTransaction = 0;
            foreach (var itemReturn in listReturn)
            {
                List<InvoiceDetail> invoiceDetails = _invoiceDetailRepository.GetMany(x => x.SPKDetailSparepartDetail.SPKDetailSparepart.SparepartId == itemReturn.SparepartId
                    && x.InvoiceId == invoiceID
                    //&& (x.SPKDetailSparepartDetail.SparepartDetail.Status == (int)DbConstant.SparepartDetailDataStatus.OutPurchase
                    //|| x.SPKDetailSparepartDetail.SparepartDetail.Status == (int)DbConstant.SparepartDetailDataStatus.OutService
                    //|| x.SPKDetailSparepartDetail.SparepartDetail.Status == (int)DbConstant.SparepartDetailDataStatus.OutInstalled)
                    ).OrderByDescending(x => x.CreateDate)
                    .Take(itemReturn.ReturQty).ToList();

                List<PurchasingDetail> listPurchasingDetail = new List<PurchasingDetail>();
                List<SparepartManualTransaction> listSparepartManualTrans = new List<SparepartManualTransaction>();
                foreach (var invoiceDetail in invoiceDetails)
                {
                    listReturnDetail.Add(new SalesReturnDetail
                    {
                        CreateDate = serverTime,
                        CreateUserId = userID,
                        ModifyDate = serverTime,
                        ModifyUserId = userID,
                        SalesReturnId = salesReturn.Id,
                        InvoiceDetailId = invoiceDetail.Id,
                        Status = (int)DbConstant.DefaultDataStatus.Active
                    });
                    totalTransaction += invoiceDetail.SubTotalPrice.AsDecimal();

                    //temp delete
                    //SparepartDetail spDetail = _sparepartDetailRepository.GetById(invoiceDetail.SPKDetailSparepartDetail.SparepartDetailId);
                    //spDetail.ModifyDate = serverTime;
                    //spDetail.ModifyUserId = userID;
                    //spDetail.Status = (int)DbConstant.SparepartDetailDataStatus.Active;

                    //if(spDetail.PurchasingDetail != null)
                    //{
                    //    listPurchasingDetail.Add(spDetail.PurchasingDetail);
                    //}
                    //if (spDetail.SparepartManualTransaction != null)
                    //{
                    //    listSparepartManualTrans.Add(spDetail.SparepartManualTransaction);
                    //}

                    //_sparepartDetailRepository.AttachNavigation(spDetail.CreateUser);
                    //_sparepartDetailRepository.AttachNavigation(spDetail.ModifyUser);
                    //_sparepartDetailRepository.AttachNavigation(spDetail.PurchasingDetail);
                    //_sparepartDetailRepository.AttachNavigation(spDetail.Sparepart);
                    //_sparepartDetailRepository.AttachNavigation(spDetail.SparepartManualTransaction);
                    //_sparepartDetailRepository.Update(spDetail);
                }
                Sparepart sparepart = _sparepartRepository.GetById(itemReturn.SparepartId);
                sparepart.ModifyDate = serverTime;
                sparepart.ModifyUserId = userID;
                sparepart.StockQty += itemReturn.ReturQty;

                _sparepartRepository.AttachNavigation(sparepart.CreateUser);
                _sparepartRepository.AttachNavigation(sparepart.ModifyUser);
                _sparepartRepository.AttachNavigation(sparepart.CategoryReference);
                _sparepartRepository.AttachNavigation(sparepart.UnitReference);
                _sparepartRepository.Update(sparepart);

                SparepartStockCard stockCard = new SparepartStockCard();
                stockCard.CreateUserId = userID;
                stockCard.PurchaseDate = serverTime;
                stockCard.PrimaryKeyValue = salesReturn.Id;
                stockCard.ReferenceTableId = transactionReferenceTable.Id;
                stockCard.SparepartId = sparepart.Id;
                stockCard.Description = "Retur Penjualan";
                stockCard.QtyIn = itemReturn.ReturQty;
                stockCard.QtyInPrice = Convert.ToDouble(listPurchasingDetail.Sum(x => x.Price) + listSparepartManualTrans.Sum(x => x.Price));
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

                if (listPurchasingDetail.Count > 0)
                {
                    List<PurchasingDetailViewModel> listPurchasing = listPurchasingDetail
                                    .GroupBy(l => l.PurchasingId)
                                    .Select(cl => new PurchasingDetailViewModel
                                    {
                                        PurchasingId = cl.Key,
                                        Qty = cl.Count(),
                                        Price = cl.First().Price
                                    }).ToList();

                    foreach (var itemPurchasing in listPurchasing)
                    {
                        SparepartStockCardDetail stockCardDtail = new SparepartStockCardDetail();
                        stockCardDtail.ParentStockCard = stockCard;
                        stockCardDtail.PricePerItem = Convert.ToDouble(itemPurchasing.Price);
                        stockCardDtail.QtyIn = itemPurchasing.Qty;
                        stockCardDtail.QtyInPrice = Convert.ToDouble(itemPurchasing.Qty * itemPurchasing.Price);
                        SparepartStockCardDetail lastStockCardDetail = _sparepartStokCardDetailRepository.RetrieveLastCardDetailByPurchasingId(sparepart.Id, itemPurchasing.PurchasingId);
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

                        PurchasingDetail pDetail = _purchasingDetailRepository.GetById(itemPurchasing.Id);
                        pDetail.ModifyDate = serverTime;
                        pDetail.ModifyUserId = userID;
                        pDetail.QtyRemaining = pDetail.QtyRemaining + itemPurchasing.Qty;

                        _purchasingDetailRepository.AttachNavigation(pDetail.Purchasing);
                        _purchasingDetailRepository.AttachNavigation(pDetail.Sparepart);
                        _purchasingDetailRepository.AttachNavigation(pDetail.CreateUser);
                        _purchasingDetailRepository.AttachNavigation(pDetail.ModifyUser);
                        _purchasingDetailRepository.Update(pDetail);
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
                                            Price = cl.First().Price
                                        }).ToList();
                    foreach (var itemSpTrans in listSpManual)
                    {
                        SparepartStockCardDetail stockCardDtail = new SparepartStockCardDetail();
                        stockCardDtail.ParentStockCard = stockCard;
                        stockCardDtail.PricePerItem = Convert.ToDouble(itemSpTrans.Price);
                        stockCardDtail.QtyIn = itemSpTrans.Qty;
                        stockCardDtail.QtyInPrice = Convert.ToDouble(itemSpTrans.Qty * itemSpTrans.Price);
                        SparepartStockCardDetail lastStockCardDetail = _sparepartStokCardDetailRepository.RetrieveLastCardDetailByTransactionManualId(sparepart.Id, itemSpTrans.Id);
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

                        SparepartManualTransaction spManual = _sparepartManualTransactionRepository.GetById(itemSpTrans.Id);
                        spManual.ModifyDate = serverTime;
                        spManual.ModifyUserId = userID;
                        spManual.QtyRemaining = spManual.QtyRemaining + itemSpTrans.Qty;

                        _sparepartManualTransactionRepository.AttachNavigation(spManual.UpdateType);
                        _sparepartManualTransactionRepository.AttachNavigation(spManual.Sparepart);
                        _sparepartManualTransactionRepository.AttachNavigation(spManual.CreateUser);
                        _sparepartManualTransactionRepository.AttachNavigation(spManual.ModifyUser);
                        _sparepartManualTransactionRepository.Update(spManual);
                        _unitOfWork.SaveChanges();
                    }
                }
                
            }

            _unitOfWork.SaveChanges();

            foreach (var itemReturnDetail in listReturnDetail)
            {
                _salesReturnDetailRepository.AttachNavigation(itemReturnDetail.CreateUser);
                _salesReturnDetailRepository.AttachNavigation(itemReturnDetail.ModifyUser);
                _salesReturnDetailRepository.AttachNavigation(itemReturnDetail.SalesReturn);
                _salesReturnDetailRepository.AttachNavigation(itemReturnDetail.InvoiceDetail);
                _salesReturnDetailRepository.Add(itemReturnDetail);
            }

            Invoice invoice = _invoiceRepository.GetById(salesReturn.InvoiceId);
            invoice.Status = (int)DbConstant.InvoiceStatus.HasReturn;
            invoice.ModifyDate = serverTime;
            invoice.ModifyUserId = userID;
            if (invoice.TotalPrice != invoice.TotalHasPaid && (invoice.TotalPrice - invoice.TotalHasPaid) >= totalTransaction)
            {
                invoice.TotalHasPaid += totalTransaction;
            }

            if (invoice.TotalPrice == invoice.TotalHasPaid)
            {
                invoice.PaymentStatus = (int)DbConstant.PaymentStatus.Settled;
            }
            else
            {
                invoice.PaymentStatus = (int)DbConstant.PaymentStatus.NotSettled;
            }

            _invoiceRepository.AttachNavigation(invoice.CreateUser);
            _invoiceRepository.AttachNavigation(invoice.ModifyUser);
            _invoiceRepository.AttachNavigation(invoice.PaymentMethod);
            _invoiceRepository.AttachNavigation(invoice.SPK);

            _unitOfWork.SaveChanges();

            Transaction transaction = new Transaction();
            transaction.CreateDate = serverTime;
            transaction.CreateUserId = userID;
            transaction.ModifyDate = serverTime;
            transaction.ModifyUserId = userID;
            transaction.PrimaryKeyValue = salesReturn.Id;
            transaction.ReferenceTableId = transactionReferenceTable.Id;
            transaction.TotalPayment = totalTransaction.AsDouble();
            transaction.TotalTransaction = totalTransaction.AsDouble();
            transaction.Status = (int)DbConstant.DefaultDataStatus.Active;
            transaction.Description = "Retur Penjualan";
            transaction.TransactionDate = serverTime;

            _transactionRepository.AttachNavigation(transaction.CreateUser);
            _transactionRepository.AttachNavigation(transaction.ModifyUser);
            _transactionRepository.AttachNavigation(transaction.PaymentMethod);
            _transactionRepository.AttachNavigation(transaction.ReferenceTable);
            transaction = _transactionRepository.Add(transaction);

            _unitOfWork.SaveChanges();

            TransactionDetail transCredit = new TransactionDetail();
            transCredit.Credit = totalTransaction;
            transCredit.ParentId = transaction.Id;
            transCredit.JournalId = _journalMasterRepository.GetMany(j => j.Code == "1.01.03.01.01").FirstOrDefault().Id;

            _transactionDetailRepository.AttachNavigation(transCredit.Journal);
            _transactionDetailRepository.AttachNavigation(transCredit.Parent);
            _transactionDetailRepository.Add(transCredit);

            TransactionDetail transDebit = new TransactionDetail();
            transDebit.Debit = totalTransaction;
            transDebit.ParentId = transaction.Id;
            transDebit.JournalId = _journalMasterRepository.GetMany(j => j.Code == "1.01.04.01").FirstOrDefault().Id;

            _transactionDetailRepository.AttachNavigation(transCredit.Journal);
            _transactionDetailRepository.AttachNavigation(transCredit.Parent);
            _transactionDetailRepository.Add(transDebit);

            _unitOfWork.SaveChanges();
        }

        public void DeleteSalesReturnFunc(int salesReturnID, int userID)
        {
            DateTime serverTime = DateTime.Now;

            Reference transactionReferenceTable = _referenceRepository.GetMany(c => c.Code == DbConstant.REF_TRANSTBL_SALESRETURN).FirstOrDefault();
            
            SalesReturn salesReturn = _salesReturnRepository.GetById(salesReturnID);
            salesReturn.Status = (int)DbConstant.DefaultDataStatus.Deleted;
            salesReturn.ModifyDate = serverTime;
            salesReturn.ModifyUserId = userID;

            _salesReturnRepository.AttachNavigation(salesReturn.CreateUser);
            _salesReturnRepository.AttachNavigation(salesReturn.ModifyUser);
            _salesReturnRepository.AttachNavigation(salesReturn.Invoice);
            _salesReturnRepository.Update(salesReturn);
            _unitOfWork.SaveChanges();

            List<SalesReturnDetail> listDetail = _salesReturnDetailRepository.GetMany(x => x.SalesReturnId == salesReturnID).ToList();

            List<ReturnViewModel> listReturn = listDetail
                                    .GroupBy(l => l.InvoiceDetail.SPKDetailSparepartDetail.SPKDetailSparepart.SparepartId)
                                    .Select(cl => new ReturnViewModel
                                    {
                                        SparepartId = cl.First().InvoiceDetail.SPKDetailSparepartDetail.SPKDetailSparepart.SparepartId,
                                        ReturQty = cl.Count(),
                                    }).ToList();
            List<PurchasingDetail> listPurchasingDetail = new List<PurchasingDetail>();
            List<SparepartManualTransaction> listSparepartManualTrans = new List<SparepartManualTransaction>();
            foreach (var itemDetail in listDetail)
            {
                itemDetail.Status = (int)DbConstant.DefaultDataStatus.Deleted;
                itemDetail.ModifyDate = serverTime;
                itemDetail.ModifyUserId = userID;

                _salesReturnDetailRepository.AttachNavigation(itemDetail.CreateUser);
                _salesReturnDetailRepository.AttachNavigation(itemDetail.ModifyUser);
                _salesReturnDetailRepository.AttachNavigation(itemDetail.SalesReturn);
                _salesReturnDetailRepository.AttachNavigation(itemDetail.InvoiceDetail);
                _salesReturnDetailRepository.Update(itemDetail);

                //temp delete
                //SparepartDetail spDetail = _sparepartDetailRepository.GetById(itemDetail.InvoiceDetail.SPKDetailSparepartDetail.SparepartDetailId);
                //spDetail.Status = (int)DbConstant.SparepartDetailDataStatus.OutPurchase;

                //_sparepartDetailRepository.AttachNavigation(spDetail.CreateUser);
                //_sparepartDetailRepository.AttachNavigation(spDetail.ModifyUser);
                //_sparepartDetailRepository.AttachNavigation(spDetail.PurchasingDetail);
                //_sparepartDetailRepository.AttachNavigation(spDetail.Sparepart);
                //_sparepartDetailRepository.AttachNavigation(spDetail.SparepartManualTransaction);
                //_sparepartDetailRepository.Update(spDetail);

                //if (spDetail.PurchasingDetail != null)
                //{
                //    listPurchasingDetail.Add(spDetail.PurchasingDetail);
                //}
                //if (spDetail.SparepartManualTransaction != null)
                //{
                //    listSparepartManualTrans.Add(spDetail.SparepartManualTransaction);
                //}
            }

            foreach (var itemReturn in listReturn)
            {
                Sparepart sparepart = _sparepartRepository.GetById(itemReturn.SparepartId);
                sparepart.StockQty -= itemReturn.ReturQty;

                _sparepartRepository.AttachNavigation(sparepart.CreateUser);
                _sparepartRepository.AttachNavigation(sparepart.ModifyUser);
                _sparepartRepository.AttachNavigation(sparepart.CategoryReference);
                _sparepartRepository.AttachNavigation(sparepart.UnitReference);
                _sparepartRepository.Update(sparepart);

                SparepartStockCard stockCard = new SparepartStockCard();
                stockCard.CreateUserId = userID;
                stockCard.PurchaseDate = serverTime;
                stockCard.PrimaryKeyValue = salesReturn.Id;
                stockCard.ReferenceTableId = transactionReferenceTable.Id;
                stockCard.SparepartId = sparepart.Id;
                stockCard.Description = "Pembatalan Retur Penjualan";
                stockCard.QtyOut = itemReturn.ReturQty;
                stockCard.QtyOutPrice = Convert.ToDouble(listPurchasingDetail.Sum(x => x.Price) + listSparepartManualTrans.Sum(x => x.Price));
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
                                        Qty = cl.Count(),
                                        Price = cl.First().Price
                                    }).ToList();

                    foreach (var itemPurchasing in listPurchasing)
                    {
                        SparepartStockCardDetail stockCardDtail = new SparepartStockCardDetail();
                        stockCardDtail.ParentStockCard = stockCard;
                        stockCardDtail.PricePerItem = Convert.ToDouble(itemPurchasing.Price);
                        stockCardDtail.QtyOut = itemPurchasing.Qty;
                        stockCardDtail.QtyOutPrice = Convert.ToDouble(itemPurchasing.Qty * itemPurchasing.Price);
                        SparepartStockCardDetail lastStockCardDetail = _sparepartStokCardDetailRepository.RetrieveLastCardDetailByPurchasingId(sparepart.Id, itemPurchasing.PurchasingId);
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

                        PurchasingDetail pDetail = _purchasingDetailRepository.GetById(itemPurchasing.Id);
                        pDetail.ModifyDate = serverTime;
                        pDetail.ModifyUserId = userID;
                        pDetail.QtyRemaining = pDetail.QtyRemaining - itemPurchasing.Qty;

                        _purchasingDetailRepository.AttachNavigation(pDetail.Purchasing);
                        _purchasingDetailRepository.AttachNavigation(pDetail.Sparepart);
                        _purchasingDetailRepository.AttachNavigation(pDetail.CreateUser);
                        _purchasingDetailRepository.AttachNavigation(pDetail.ModifyUser);
                        _purchasingDetailRepository.Update(pDetail);
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
                                            Price = cl.First().Price
                                        }).ToList();
                    foreach (var itemSpTrans in listSpManual)
                    {
                        SparepartStockCardDetail stockCardDtail = new SparepartStockCardDetail();
                        stockCardDtail.ParentStockCard = stockCard;
                        stockCardDtail.PricePerItem = Convert.ToDouble(itemSpTrans.Price);
                        stockCardDtail.QtyOut = 1;
                        stockCardDtail.QtyOutPrice = Convert.ToDouble(1 * itemSpTrans.Price);
                        SparepartStockCardDetail lastStockCardDetail = _sparepartStokCardDetailRepository.RetrieveLastCardDetailByTransactionManualId(sparepart.Id, itemSpTrans.Id);
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
                        stockCardDtail.QtyLastPrice = lastStockDetailPrice - stockCardDtail.QtyOut;
                        stockCardDtail.SparepartManualTransactionId = itemSpTrans.Id;

                        _sparepartStokCardDetailRepository.AttachNavigation(stockCardDtail.ParentStockCard);
                        _sparepartStokCardDetailRepository.Add(stockCardDtail);
                        _unitOfWork.SaveChanges();

                        SparepartManualTransaction spManual = _sparepartManualTransactionRepository.GetById(itemSpTrans.Id);
                        spManual.ModifyDate = serverTime;
                        spManual.ModifyUserId = userID;
                        spManual.QtyRemaining = spManual.QtyRemaining - 1;

                        _sparepartManualTransactionRepository.AttachNavigation(spManual.UpdateType);
                        _sparepartManualTransactionRepository.AttachNavigation(spManual.Sparepart);
                        _sparepartManualTransactionRepository.AttachNavigation(spManual.CreateUser);
                        _sparepartManualTransactionRepository.AttachNavigation(spManual.ModifyUser);
                        _sparepartManualTransactionRepository.Update(spManual);
                        _unitOfWork.SaveChanges();
                    }
                }
            } 

            _unitOfWork.SaveChanges();

            Transaction transaction = _transactionRepository.GetMany(x => x.PrimaryKeyValue == salesReturnID && x.ReferenceTableId == transactionReferenceTable.Id).FirstOrDefault();
            transaction.Status = (int)DbConstant.DefaultDataStatus.Deleted;
            transaction.ModifyDate = serverTime;
            transaction.ModifyUserId = userID;

            _transactionRepository.AttachNavigation(transaction.CreateUser);
            _transactionRepository.AttachNavigation(transaction.ModifyUser);
            _transactionRepository.AttachNavigation(transaction.PaymentMethod);
            _transactionRepository.AttachNavigation(transaction.ReferenceTable);
            _transactionRepository.Update(transaction);

            Invoice invoice = _invoiceRepository.GetById(salesReturn.InvoiceId);
            if (invoice.TotalPrice != invoice.TotalHasPaid && (invoice.TotalPrice - invoice.TotalHasPaid) >= (decimal)transaction.TotalTransaction)
            {
                invoice.TotalHasPaid -= (decimal)transaction.TotalTransaction;
            }

            if (invoice.TotalPrice == invoice.TotalHasPaid)
            {
                invoice.PaymentStatus = (int)DbConstant.PaymentStatus.Settled;
            }
            else
            {
                invoice.PaymentStatus = (int)DbConstant.PaymentStatus.NotSettled;
            }

            invoice.Status = (int)DbConstant.InvoiceStatus.Printed;

            _invoiceRepository.AttachNavigation(invoice.CreateUser);
            _invoiceRepository.AttachNavigation(invoice.ModifyUser);
            _invoiceRepository.AttachNavigation(invoice.PaymentMethod);
            _invoiceRepository.AttachNavigation(invoice.SPK);

            _unitOfWork.SaveChanges();
        }

        public void UpdateSalesReturnOldMthod(int invoiceID, int salesReturnID, List<ReturnViewModel> listReturn, int userID)
        {
            using(var trans = _unitOfWork.BeginTransaction())
            {
                try
                {
                    DateTime serverTime = DateTime.Now;

                    //List<SalesReturnDetail> listReturnDetail = _salesReturnDetailRepository.GetMany(x => x.SalesReturnId == salesReturnID).ToList();
                    Reference transactionReferenceTable = _referenceRepository.GetMany(c => c.Code == DbConstant.REF_TRANSTBL_SALESRETURN).FirstOrDefault();
                    Transaction transaction = _transactionRepository.GetMany(x => x.PrimaryKeyValue == salesReturnID && x.ReferenceTableId == transactionReferenceTable.Id).FirstOrDefault();
                    decimal totalTransaction = transaction.TotalTransaction.AsDecimal();
                    foreach (var itemReturn in listReturn)
                    {
                        int oldReturQty = _salesReturnDetailRepository.GetMany(x => x.SalesReturnId == salesReturnID
                            && x.InvoiceDetail.SPKDetailSparepartDetail.SPKDetailSparepart.SparepartId == itemReturn.SparepartId).Count();
                        if (itemReturn.ReturQty > oldReturQty)
                        {
                            int diffQty = itemReturn.ReturQty - oldReturQty;
                            List<SalesReturnDetail> newReturnDetail = new List<SalesReturnDetail>();

                            List<InvoiceDetail> invoiceDetails = _invoiceDetailRepository.GetMany(x => x.SPKDetailSparepartDetail.SPKDetailSparepart.SparepartId == itemReturn.SparepartId
                            && x.InvoiceId == invoiceID
                            //&& (x.SPKDetailSparepartDetail.SparepartDetail.Status == (int)DbConstant.SparepartDetailDataStatus.OutPurchase
                            //|| x.SPKDetailSparepartDetail.SparepartDetail.Status == (int)DbConstant.SparepartDetailDataStatus.OutService)
                            ).OrderByDescending(x => x.CreateDate)
                            .Take(diffQty).ToList();
                            foreach (var invoiceDetail in invoiceDetails)
                            {
                                newReturnDetail.Add(new SalesReturnDetail
                                {
                                    CreateDate = serverTime,
                                    CreateUserId = userID,
                                    ModifyDate = serverTime,
                                    ModifyUserId = userID,
                                    SalesReturnId = salesReturnID,
                                    InvoiceDetailId = invoiceDetail.Id,
                                    Status = (int)DbConstant.DefaultDataStatus.Active
                                });
                                totalTransaction += invoiceDetail.SubTotalPrice.AsDecimal();

                                //temp delete
                                //SparepartDetail spDetail = _sparepartDetailRepository.GetById(invoiceDetail.SPKDetailSparepartDetail.SparepartDetailId);
                                //spDetail.ModifyDate = serverTime;
                                //spDetail.ModifyUserId = userID;
                                //spDetail.Status = (int)DbConstant.SparepartDetailDataStatus.Active;

                                //_sparepartDetailRepository.AttachNavigation(spDetail.CreateUser);
                                //_sparepartDetailRepository.AttachNavigation(spDetail.ModifyUser);
                                //_sparepartDetailRepository.AttachNavigation(spDetail.PurchasingDetail);
                                //_sparepartDetailRepository.AttachNavigation(spDetail.Sparepart);
                                //_sparepartDetailRepository.AttachNavigation(spDetail.SparepartManualTransaction);
                                //_sparepartDetailRepository.Update(spDetail);
                            }

                            Sparepart sparepart = _sparepartRepository.GetById(itemReturn.SparepartId);
                            sparepart.ModifyDate = serverTime;
                            sparepart.ModifyUserId = userID;
                            sparepart.StockQty += diffQty;

                            _sparepartRepository.AttachNavigation(sparepart.CreateUser);
                            _sparepartRepository.AttachNavigation(sparepart.ModifyUser);
                            _sparepartRepository.AttachNavigation(sparepart.CategoryReference);
                            _sparepartRepository.AttachNavigation(sparepart.UnitReference);
                            _sparepartRepository.Update(sparepart);

                            foreach (var itemNewReturnDetail in newReturnDetail)
                            {
                                _salesReturnDetailRepository.AttachNavigation(itemNewReturnDetail.CreateUser);
                                _salesReturnDetailRepository.AttachNavigation(itemNewReturnDetail.ModifyUser);
                                _salesReturnDetailRepository.AttachNavigation(itemNewReturnDetail.SalesReturn);
                                _salesReturnDetailRepository.AttachNavigation(itemNewReturnDetail.InvoiceDetail);
                                _salesReturnDetailRepository.Add(itemNewReturnDetail);
                            }
                        }
                        else if (itemReturn.ReturQty < oldReturQty)
                        {
                            int diffQty = oldReturQty - itemReturn.ReturQty;
                            InvoiceDetail InvoiceDetail = _invoiceDetailRepository.GetMany(x => x.SPKDetailSparepartDetail.SPKDetailSparepart.SparepartId == itemReturn.SparepartId && x.InvoiceId == invoiceID).FirstOrDefault();

                            List<SalesReturnDetail> listDeletedDetail = _salesReturnDetailRepository.GetMany(x => x.SalesReturnId == salesReturnID
                            && x.InvoiceDetailId == InvoiceDetail.Id).OrderByDescending(x => x.CreateDate).Take(diffQty).ToList();
                            foreach (var itemDeleted in listDeletedDetail)
                            {
                                totalTransaction -= itemDeleted.InvoiceDetail.SubTotalPrice.AsDecimal();
                                _salesReturnDetailRepository.Delete(itemDeleted);

                                //temp delete
                                //SparepartDetail spDetail = _sparepartDetailRepository.GetById(itemDeleted.InvoiceDetail.SPKDetailSparepartDetail.SparepartDetailId);
                                //spDetail.ModifyDate = serverTime;
                                //spDetail.ModifyUserId = userID;
                                //spDetail.Status = (int)DbConstant.SparepartDetailDataStatus.OutPurchase;

                                //_sparepartDetailRepository.AttachNavigation(spDetail.CreateUser);
                                //_sparepartDetailRepository.AttachNavigation(spDetail.ModifyUser);
                                //_sparepartDetailRepository.AttachNavigation(spDetail.PurchasingDetail);
                                //_sparepartDetailRepository.AttachNavigation(spDetail.Sparepart);
                                //_sparepartDetailRepository.AttachNavigation(spDetail.SparepartManualTransaction);
                                //_sparepartDetailRepository.Update(spDetail);
                            }

                            Sparepart sparepart = _sparepartRepository.GetById(itemReturn.SparepartId);
                            sparepart.ModifyDate = serverTime;
                            sparepart.ModifyUserId = userID;
                            sparepart.StockQty -= diffQty;

                            _sparepartRepository.AttachNavigation(sparepart.CreateUser);
                            _sparepartRepository.AttachNavigation(sparepart.ModifyUser);
                            _sparepartRepository.AttachNavigation(sparepart.CategoryReference);
                            _sparepartRepository.AttachNavigation(sparepart.UnitReference);
                            _sparepartRepository.Update(sparepart);
                        }
                    }

                    _unitOfWork.SaveChanges();

                    transaction.TotalPayment = totalTransaction.AsDouble();
                    transaction.TotalTransaction = totalTransaction.AsDouble();

                    _transactionRepository.AttachNavigation(transaction.CreateUser);
                    _transactionRepository.AttachNavigation(transaction.ModifyUser);
                    _transactionRepository.AttachNavigation(transaction.PaymentMethod);
                    _transactionRepository.AttachNavigation(transaction.ReferenceTable);
                    _transactionRepository.Update(transaction);

                    TransactionDetail transDebit = _transactionDetailRepository.GetMany(x => x.ParentId == transaction.Id && x.Debit > 0).FirstOrDefault();
                    transDebit.Debit = totalTransaction;

                    _transactionDetailRepository.AttachNavigation(transDebit.Journal);
                    _transactionDetailRepository.AttachNavigation(transDebit.Parent);
                    _transactionDetailRepository.Update(transDebit);

                    TransactionDetail transCredit = _transactionDetailRepository.GetMany(x => x.ParentId == transaction.Id && x.Credit > 0).FirstOrDefault();
                    transCredit.Credit = totalTransaction;

                    _transactionDetailRepository.AttachNavigation(transCredit.Journal);
                    _transactionDetailRepository.AttachNavigation(transCredit.Parent);
                    _transactionDetailRepository.Update(transCredit);

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

    }
}
