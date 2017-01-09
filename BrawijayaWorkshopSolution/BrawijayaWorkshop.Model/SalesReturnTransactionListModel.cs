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
    public class SalesReturnTransactionListModel : AppBaseModel
    {
        private ITransactionRepository _transactionRepository;
        private IInvoiceRepository _invoiceRepository;
        private IInvoiceDetailRepository _invoiceDetailRepository;
        private ISalesReturnRepository _salesReturnRepository;
        private ISalesReturnDetailRepository _salesReturnDetailRepository;
        private ISparepartRepository _sparepartRepository;
        private ISparepartDetailRepository _sparepartDetailRepository;
        private IReferenceRepository _referenceRepository;
        private ISparepartStockCardRepository _sparepartStokCardRepository;
        private ISparepartStockCardDetailRepository _sparepartStokCardDetailRepository;
        private IUnitOfWork _unitOfWork;

        public SalesReturnTransactionListModel(ITransactionRepository transactionRepository,
            IInvoiceRepository invoiceRepository, IInvoiceDetailRepository invoiceDetailRepository, ISalesReturnRepository salesReturnRepository,
            ISalesReturnDetailRepository salesReturnDetailRepository,
            ISparepartRepository sparepartRepository, ISparepartDetailRepository sparepartDetailRepository,
            IReferenceRepository referenceRepository,
            ISparepartStockCardRepository sparepartStockCardRepository,
            ISparepartStockCardDetailRepository sparepartStockCardDetailRepository,
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
            _sparepartStokCardRepository = sparepartStockCardRepository;
            _sparepartStokCardDetailRepository = sparepartStockCardDetailRepository;
            _unitOfWork = unitOfWork;
        }

        public List<SalesReturnViewModel> SearchSalesReturnList(DateTime? dateFrom, DateTime? dateTo, int invoiceID)
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

            if (invoiceID > 0)
            {
                result = result.Where(x => x.InvoiceId == invoiceID).OrderByDescending(c => c.Date).ToList();
            }

            List<SalesReturnViewModel> mappedResult = new List<SalesReturnViewModel>();
            return Map(result, mappedResult);
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

                        Sparepart sparepart = _sparepartRepository.GetById(spDetail.SparepartId);
                        sparepart.StockQty -= 1;

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
                        stockCard.QtyOut = 1;
                        stockCard.QtyOutPrice = Convert.ToDouble(spDetail.PurchasingDetail != null ? spDetail.PurchasingDetail.Price : spDetail.SparepartManualTransaction != null ? spDetail.SparepartManualTransaction.Price : 0);
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
                        stockCard.QtyLast = lastStock - 1;
                        stockCard.QtyLastPrice = lastStockPrice - Convert.ToDouble(spDetail.PurchasingDetail != null ? spDetail.PurchasingDetail.Price : spDetail.SparepartManualTransaction != null ? spDetail.SparepartManualTransaction.Price : 0);
                        _sparepartStokCardRepository.AttachNavigation(stockCard.CreateUser);
                        _sparepartStokCardRepository.AttachNavigation(stockCard.Sparepart);
                        _sparepartStokCardRepository.AttachNavigation(stockCard.ReferenceTable);
                        stockCard =_sparepartStokCardRepository.Add(stockCard);

                        _unitOfWork.SaveChanges();

                        if(spDetail.PurchasingDetail != null)
                        {
                            SparepartStockCardDetail stockCardDtail = new SparepartStockCardDetail();
                            stockCardDtail.ParentStockCard = stockCard;
                            stockCardDtail.PricePerItem = Convert.ToDouble(spDetail.PurchasingDetail.Price);
                            stockCardDtail.QtyOut = 1;
                            stockCardDtail.QtyOutPrice = Convert.ToDouble(spDetail.PurchasingDetail.Price);
                            SparepartStockCardDetail lastStockCardDetail = _sparepartStokCardDetailRepository.RetrieveLastCardDetailByPurchasingId(sparepart.Id, spDetail.PurchasingDetail.PurchasingId);
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
                            stockCardDtail.PurchasingId = spDetail.PurchasingDetail.PurchasingId;

                            _sparepartStokCardDetailRepository.AttachNavigation(stockCardDtail.ParentStockCard);
                            _sparepartStokCardDetailRepository.Add(stockCardDtail);
                            _unitOfWork.SaveChanges();
                        }

                        if (spDetail.SparepartManualTransaction != null)
                        {
                            SparepartStockCardDetail stockCardDtail = new SparepartStockCardDetail();
                            stockCardDtail.ParentStockCard = stockCard;
                            stockCardDtail.PricePerItem = Convert.ToDouble(spDetail.PurchasingDetail.Price);
                            stockCardDtail.QtyOut = 1;
                            stockCardDtail.QtyOutPrice = Convert.ToDouble(spDetail.PurchasingDetail.Price);
                            SparepartStockCardDetail lastStockCardDetail = _sparepartStokCardDetailRepository.RetrieveLastCardDetailByTransactionManualId(sparepart.Id, spDetail.SparepartManualTransaction.Id);
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
                            stockCardDtail.SparepartManualTransactionId = spDetail.SparepartManualTransaction.Id;

                            _sparepartStokCardDetailRepository.AttachNavigation(stockCardDtail.ParentStockCard);
                            _sparepartStokCardDetailRepository.Add(stockCardDtail);
                            _unitOfWork.SaveChanges();
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
            return result;
        }
    }
}
