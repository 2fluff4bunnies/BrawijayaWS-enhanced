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
    public class SalesReturnListModel : AppBaseModel
    {
        private ITransactionRepository _transactionRepository;
        private IInvoiceRepository _invoiceRepository;
        private IInvoiceDetailRepository _invoiceDetailRepository;
        private ISalesReturnRepository _salesReturnRepository;
        private ISalesReturnDetailRepository _salesReturnDetailRepository;
        private ISparepartRepository _sparepartRepository;
        private ISparepartDetailRepository _sparepartDetailRepository;
        private IReferenceRepository _referenceRepository;
        private ICustomerRepository _customerRepository;
        private ISparepartStockCardRepository _sparepartStokCardRepository;
        private IUnitOfWork _unitOfWork;

        public SalesReturnListModel(ITransactionRepository transactionRepository,
            IInvoiceRepository invoiceRepository, IInvoiceDetailRepository invoiceDetailRepository, ISalesReturnRepository salesReturnRepository,
            ISalesReturnDetailRepository salesReturnDetailRepository,
            ISparepartRepository sparepartRepository, ISparepartDetailRepository sparepartDetailRepository,
            IReferenceRepository referenceRepository,
            ICustomerRepository customerRepository,
            ISparepartStockCardRepository sparepartStockCardRepository,
            IUnitOfWork unitOfWork)
            : base()
        {
            _transactionRepository = transactionRepository;
            _invoiceRepository = invoiceRepository;
            _invoiceDetailRepository = invoiceDetailRepository;
            _salesReturnRepository = salesReturnRepository;
            _salesReturnDetailRepository = salesReturnDetailRepository;
            _sparepartRepository = sparepartRepository;
            _sparepartDetailRepository = sparepartDetailRepository;
            _referenceRepository = referenceRepository;
            _customerRepository = customerRepository;
            _sparepartStokCardRepository = sparepartStockCardRepository;
            _unitOfWork = unitOfWork;
        }

        public List<CustomerViewModel> GetCustomerFilterList()
        {
            List<Customer> result = null;
            result = _customerRepository.GetMany(c => c.Status == (int)DbConstant.DefaultDataStatus.Active).ToList();

            List<CustomerViewModel> mappedResult = new List<CustomerViewModel>();
            return Map(result, mappedResult);
        }

        public List<InvoiceViewModel> SearchInvoiceList(DateTime? dateFrom, DateTime? dateTo, int customerID)
        {
            List<Invoice> result = null;
            if (dateFrom.HasValue && dateTo.HasValue)
            {
                dateFrom = dateFrom.Value.Date;
                dateTo = dateTo.Value.Date.AddDays(1).AddSeconds(-1);
                result = _invoiceRepository.GetMany(c => c.CreateDate >= dateFrom && c.CreateDate <= dateTo && (c.Status == (int) DbConstant.InvoiceStatus.Printed || c.Status == (int) DbConstant.InvoiceStatus.HasReturn) && c.SPK.CategoryReference.Code == DbConstant.REF_SPK_CATEGORY_SALE).OrderBy(c => c.CreateDate).ToList();
            }
            else
            {
                result = _invoiceRepository.GetMany(c => (c.Status == (int) DbConstant.InvoiceStatus.Printed || c.Status == (int) DbConstant.InvoiceStatus.HasReturn) && c.SPK.CategoryReference.Code == DbConstant.REF_SPK_CATEGORY_SALE).OrderBy(c => c.CreateDate).ToList();
            }
            if (customerID != 0)
            {
                result = result.Where(p => p.SPK.Vehicle.CustomerId == customerID).ToList();
            } 

            List<InvoiceViewModel> mappedResult = new List<InvoiceViewModel>();
            Map(result, mappedResult);

            foreach (var itemMapped in mappedResult)
            {
                itemMapped.IsHasReturn = IsHasReturnActive(itemMapped.Id);
            }

            return mappedResult;
        }

        public bool IsHasReturnActive(int invoiceID)
        {
            return _salesReturnRepository.GetMany(x => x.InvoiceId == invoiceID && x.Status == (int)DbConstant.DefaultDataStatus.Active).Count() > 0;
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
                                    .GroupBy(l => l.InvoiceDetail.SPKDetailSparepartDetail.SparepartDetail.SparepartId)
                                    .Select(cl => new ReturnViewModel
                                    {
                                        SparepartId = cl.First().InvoiceDetail.SPKDetailSparepartDetail.SparepartDetail.SparepartId,
                                        ReturQty = cl.Count(),
                                    }).ToList();
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

                        SparepartDetail spDetail = _sparepartDetailRepository.GetById(itemDetail.InvoiceDetail.SPKDetailSparepartDetail.SparepartDetailId);
                        spDetail.Status = (int)DbConstant.SparepartDetailDataStatus.OutPurchase;

                        _sparepartDetailRepository.AttachNavigation(spDetail.CreateUser);
                        _sparepartDetailRepository.AttachNavigation(spDetail.ModifyUser);
                        _sparepartDetailRepository.AttachNavigation(spDetail.PurchasingDetail);
                        _sparepartDetailRepository.AttachNavigation(spDetail.Sparepart);
                        _sparepartDetailRepository.AttachNavigation(spDetail.SparepartManualTransaction);
                        _sparepartDetailRepository.Update(spDetail);
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
                        SparepartStockCard lastStockCard = _sparepartStokCardRepository.RetrieveLastCard(sparepart.Id);
                        double lastStock = 0;
                        if (lastStockCard != null)
                        {
                            lastStock = lastStockCard.QtyLast;
                        }
                        stockCard.QtyFirst = lastStock;
                        stockCard.QtyLast = lastStock - stockCard.QtyOut;
                        _sparepartStokCardRepository.AttachNavigation(stockCard.CreateUser);
                        _sparepartStokCardRepository.AttachNavigation(stockCard.Sparepart);
                        _sparepartStokCardRepository.AttachNavigation(stockCard.ReferenceTable);
                        _sparepartStokCardRepository.Add(stockCard);
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
                    int[] sparepartIDs = listInvoiceDetail.Select(x => x.SPKDetailSparepartDetail.SparepartDetail.SparepartId).Distinct().ToArray();
                    foreach (var sparepartID in sparepartIDs)
                    {
                        if (listDetail.Where(x => x.InvoiceDetail.SPKDetailSparepartDetail.SparepartDetail.SparepartId == sparepartID).Count() > 0)
                        {
                            result.Add(new ReturnViewModel
                            {
                                SparepartId = sparepartID,
                                SparepartName = _sparepartRepository.GetById(sparepartID).Name,
                                ReturQty = listDetail.Where(x => x.InvoiceDetail.SPKDetailSparepartDetail.SparepartDetail.SparepartId == sparepartID).Count(),
                                ReturQtyLimit = listInvoiceDetail.Where(x => x.SPKDetailSparepartDetail.SparepartDetail.SparepartId == sparepartID).Count(),
                                SparepartCode = _sparepartRepository.GetById(sparepartID).Code,
                                UnitName = _sparepartRepository.GetById(sparepartID).UnitReference.Name,
                                SubTotalFee = (listInvoiceDetail.Where(x => x.SPKDetailSparepartDetail.SparepartDetail.SparepartId == sparepartID).Sum(x => x.SubTotalPrice)).AsDecimal()
                            });
                        }
                    }
                }
            }
            return result;
        }
    }
}
