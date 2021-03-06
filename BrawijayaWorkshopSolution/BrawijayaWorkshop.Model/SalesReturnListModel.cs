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
    public class SalesReturnListModel : AppBaseModel
    {
        private ITransactionRepository _transactionRepository;
        private IInvoiceRepository _invoiceRepository;
        private IInvoiceDetailRepository _invoiceDetailRepository;
        private ISalesReturnRepository _salesReturnRepository;
        private ISalesReturnDetailRepository _salesReturnDetailRepository;
        private ISparepartRepository _sparepartRepository;
        private IReferenceRepository _referenceRepository;
        private ICustomerRepository _customerRepository;
        private ISparepartStockCardRepository _sparepartStokCardRepository;
        private ISparepartStockCardDetailRepository _sparepartStokCardDetailRepository;
        private IPurchasingDetailRepository _purchasingDetailRepository;
        private ISparepartManualTransactionRepository _sparepartManualTransactionRepository;
        private IUnitOfWork _unitOfWork;

        public SalesReturnListModel(ITransactionRepository transactionRepository,
            IInvoiceRepository invoiceRepository, IInvoiceDetailRepository invoiceDetailRepository, ISalesReturnRepository salesReturnRepository,
            ISalesReturnDetailRepository salesReturnDetailRepository,
            ISparepartRepository sparepartRepository,
            IReferenceRepository referenceRepository,
            ICustomerRepository customerRepository,
            ISparepartStockCardRepository sparepartStockCardRepository,
            ISparepartStockCardDetailRepository sparepartStockCardDetailRepository,
            IPurchasingDetailRepository purchasingDetailRepository,
            ISparepartManualTransactionRepository sparepartManualTransactionRepository,
            IUnitOfWork unitOfWork)
            : base()
        {
            _transactionRepository = transactionRepository;
            _invoiceRepository = invoiceRepository;
            _invoiceDetailRepository = invoiceDetailRepository;
            _salesReturnRepository = salesReturnRepository;
            _salesReturnDetailRepository = salesReturnDetailRepository;
            _sparepartRepository = sparepartRepository;
            _referenceRepository = referenceRepository;
            _customerRepository = customerRepository;
            _sparepartStokCardRepository = sparepartStockCardRepository;
            _sparepartStokCardDetailRepository = sparepartStockCardDetailRepository;
            _purchasingDetailRepository = purchasingDetailRepository;
            _sparepartManualTransactionRepository = sparepartManualTransactionRepository;
            _unitOfWork = unitOfWork;
        }

        public List<CustomerViewModel> GetCustomerFilterList()
        {
            List<Customer> result = null;
            result = _customerRepository.GetMany(c => c.Status == (int)DbConstant.DefaultDataStatus.Active).ToList();

            List<CustomerViewModel> mappedResult = new List<CustomerViewModel>();
            return Map(result, mappedResult);
        }

        public bool IsHasReturnActive(int invoiceID)
        {
            return _salesReturnRepository.GetMany(x => x.InvoiceId == invoiceID && x.Status == (int)DbConstant.DefaultDataStatus.Active).Count() > 0;
        }

        public List<SalesReturnViewModel> SearchSalesReturnList(DateTime? dateFrom, DateTime? dateTo, int customerID)
        {
            List<SalesReturn> result = null;
            if (dateFrom.HasValue && dateTo.HasValue)
            {
                dateFrom = dateFrom.Value.Date;
                dateTo = dateTo.Value.Date.AddDays(1).AddSeconds(-1);
                result = _salesReturnRepository.GetMany(c => c.Date >= dateFrom && c.CreateDate <= dateTo && c.Status == (int)DbConstant.DefaultDataStatus.Active).OrderByDescending(c => c.Date).ToList();
            }
            else
            {
                result = _salesReturnRepository.GetMany(c => c.Status == (int)DbConstant.DefaultDataStatus.Active).OrderByDescending(c => c.Date).ToList();
            }

            List<SalesReturnViewModel> mappedResult = new List<SalesReturnViewModel>();
            Map(result, mappedResult);
            foreach (var itemMapped in mappedResult)
            {
                itemMapped.TotalPriceReturn = CalculateTotalReturn(itemMapped.Id);
            }

            return mappedResult;
        }

        public decimal CalculateTotalReturn(int salesReturnID)
        {
            decimal result = 0;
            List<SalesReturnDetail> listReturnDetail = _salesReturnDetailRepository.GetMany(x => x.SalesReturnId == salesReturnID).ToList();

            if (listReturnDetail != null && listReturnDetail.Count > 0)
            {
                foreach (var itemReturn in listReturnDetail)
                {
                    //result += itemReturn.InvoiceDetail.SPKDetailSparepartDetail.SparepartDetail.PurchasingDetail != null ? itemReturn.InvoiceDetail.SPKDetailSparepartDetail.SparepartDetail.PurchasingDetail.Price : itemReturn.InvoiceDetail.SPKDetailSparepartDetail.SparepartDetail.SparepartManualTransaction.Price;

                    //new get price plus fee
                    result += Convert.ToDecimal(itemReturn.InvoiceDetail.SubTotalPrice);
                }
            }

            return result;
        }

        public SalesReturnViewModel GetSalesReturn(int invoiceID)
        {
            SalesReturn salesReturn = _salesReturnRepository.GetMany(x => x.InvoiceId == invoiceID && x.Status == (int)DbConstant.DefaultDataStatus.Active).FirstOrDefault();
            SalesReturnViewModel viewModel = new SalesReturnViewModel();
            return Map(salesReturn, viewModel);
        }

        public void DeleteSalesReturn(int salesReturnID, int userID)
        {
            using (var trans = _unitOfWork.BeginTransaction())
            {
                try
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

                        if (itemDetail.InvoiceDetail.SPKDetailSparepartDetail.PurchasingDetail != null)
                        {
                            listPurchasingDetail.Add(itemDetail.InvoiceDetail.SPKDetailSparepartDetail.PurchasingDetail);
                        }
                        if (itemDetail.InvoiceDetail.SPKDetailSparepartDetail.SparepartManualTransaction != null)
                        {
                            listSparepartManualTrans.Add(itemDetail.InvoiceDetail.SPKDetailSparepartDetail.SparepartManualTransaction);
                        }
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
                                stockCardDtail.QtyLastPrice = lastStockDetailPrice - stockCardDtail.QtyOutPrice;
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
                    invoice.Status = (int)DbConstant.InvoiceStatus.Printed;
                    invoice.ModifyDate = serverTime;
                    invoice.ModifyUserId = userID; 
                    if (invoice.TotalPrice != invoice.TotalHasPaid && (invoice.TotalPrice - invoice.TotalHasPaid) >= (decimal)transaction.TotalTransaction)
                    {
                        invoice.TotalHasPaid -= (decimal)transaction.TotalTransaction;
                    }

                    if (invoice.TotalPrice == invoice.TotalHasPaid)
                    {
                        invoice.PaymentStatus = (int) DbConstant.PaymentStatus.Settled;
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
                    trans.Commit();
                }
                catch (Exception)
                {
                    trans.Rollback();
                    throw;
                }
            }

        }

        public List<SalesReturnDetail> RetrieveSalesReturnDetail(int salesReturnID)
        {
            List<SalesReturnDetail> result = _salesReturnDetailRepository.GetMany(x => x.SalesReturnId == salesReturnID).ToList();
            return result;
        }

        public List<SalesReturnDetailViewModel> RetrieveSalesReturnDetailView(int salesReturnID)
        {
            List<SalesReturnDetail> result = _salesReturnDetailRepository.GetMany(x => x.SalesReturnId == salesReturnID).ToList();
            List<SalesReturnDetailViewModel> mappedResult = new List<SalesReturnDetailViewModel>();
            return Map(result, mappedResult);
        }

        public List<ReturnViewModel> GetReturnListDetail(int salesReturnID, int invoiceID)
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
                        if (listDetail.Where(x => x.InvoiceDetail.SPKDetailSparepartDetail.SPKDetailSparepart.SparepartId == sparepartID).Count() > 0)
                        {
                            result.Add(new ReturnViewModel
                            {
                                SparepartId = sparepartID,
                                SparepartName = _sparepartRepository.GetById(sparepartID).Name,
                                ReturQty = listDetail.Where(x => x.InvoiceDetail.SPKDetailSparepartDetail.SPKDetailSparepart.SparepartId == sparepartID).Count(),
                                ReturQtyLimit = listInvoiceDetail.Where(x => x.SPKDetailSparepartDetail.SPKDetailSparepart.SparepartId == sparepartID).Count(),
                                SparepartCode = _sparepartRepository.GetById(sparepartID).Code,
                                UnitName = _sparepartRepository.GetById(sparepartID).UnitReference.Name,
                                SubTotalFee = (listDetail.Where(x => x.InvoiceDetail.SPKDetailSparepartDetail.SPKDetailSparepart.SparepartId == sparepartID).Sum(x => x.InvoiceDetail.SubTotalPrice)).AsDecimal()
                            });
                        }
                    }
                }
            }
            return result;
        }
    }
}
