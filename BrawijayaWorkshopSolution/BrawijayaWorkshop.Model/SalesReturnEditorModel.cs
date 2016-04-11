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
        private ISparepartDetailRepository _sparepartDetailRepository;
        private IReferenceRepository _referenceRepository;
        private ITransactionRepository _transactionRepository;
        private ITransactionDetailRepository _transactionDetailRepository;
        private IJournalMasterRepository _journalMasterRepository;
        private IUnitOfWork _unitOfWork;

        public SalesReturnEditorModel(
            ISalesReturnRepository salesReturnRepository,
            ISalesReturnDetailRepository salesReturnDetailRepository,
            IInvoiceRepository invoiceRepository,
            IInvoiceDetailRepository invoiceDetailRepository,
            ISparepartRepository sparepartRepository,
            ISparepartDetailRepository sparepartDetailRepository,
            IReferenceRepository referenceRepository,
            ITransactionRepository transactionRepository,
            ITransactionDetailRepository transactionDetailRepository,
            IJournalMasterRepository journalMasterRepository,
            IUnitOfWork unitOfWork)
            : base()
        {
            _salesReturnRepository = salesReturnRepository;
            _salesReturnDetailRepository = salesReturnDetailRepository;
            _invoiceRepository = invoiceRepository;
            _invoiceDetailRepository = invoiceDetailRepository;
            _sparepartRepository = sparepartRepository;
            _sparepartDetailRepository = sparepartDetailRepository;
            _transactionRepository = transactionRepository;
            _transactionDetailRepository = transactionDetailRepository;
            _journalMasterRepository = journalMasterRepository;
            _referenceRepository = referenceRepository;
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
                    int[] sparepartIDs = listInvoiceDetail.Select(x => x.SPKDetailSparepartDetail.SparepartDetail.SparepartId).Distinct().ToArray();
                    foreach (var sparepartID in sparepartIDs)
                    {
                        result.Add(new ReturnViewModel
                        {
                            SparepartId = sparepartID,
                            SparepartName = _sparepartRepository.GetById(sparepartID).Name,
                            ReturQty = listDetail.Where(x => x.InvoiceDetail.SPKDetailSparepartDetail.SparepartDetail.SparepartId == sparepartID).Count(),
                            ReturQtyLimit = listInvoiceDetail.Where(x => x.SPKDetailSparepartDetail.SparepartDetail.SparepartId == sparepartID).Count()
                        });
                    }
                }
            }
            else
            {
                int[] sparepartIDs = listInvoiceDetail.Select(x => x.SPKDetailSparepartDetail.SparepartDetail.SparepartId).Distinct().ToArray();
                foreach (var sparepartID in sparepartIDs)
                {
                    result.Add(new ReturnViewModel
                    {
                        SparepartId = sparepartID,
                        SparepartName = _sparepartRepository.GetById(sparepartID).Name,
                        ReturQty = listInvoiceDetail.Where(x => x.SPKDetailSparepartDetail.SparepartDetail.SparepartId == sparepartID).Count(),
                        ReturQtyLimit = listInvoiceDetail.Where(x => x.SPKDetailSparepartDetail.SparepartDetail.SparepartId == sparepartID).Count()
                    });
                }
            }
            return result;
        }

        public void InsertSalesReturn(int invoiceID, List<ReturnViewModel> listReturn, int userID)
        {
            DateTime serverTime = DateTime.Now;
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

            salesReturn = _salesReturnRepository.Add(salesReturn);
            List<SalesReturnDetail> listReturnDetail = new List<SalesReturnDetail>();

            decimal totalTransaction = 0;
            foreach (var itemReturn in listReturn)
            {
                List<InvoiceDetail> invoiceDetails = _invoiceDetailRepository.GetMany(x => x.SPKDetailSparepartDetail.SparepartDetail.SparepartId == itemReturn.SparepartId
                    && x.InvoiceId == invoiceID
                    && (x.SPKDetailSparepartDetail.SparepartDetail.Status == (int)DbConstant.SparepartDetailDataStatus.OutPurchase
                    || x.SPKDetailSparepartDetail.SparepartDetail.Status == (int)DbConstant.SparepartDetailDataStatus.OutService)
                    ).OrderByDescending(x => x.CreateDate)
                    .Take(itemReturn.ReturQty).ToList();

                foreach (var invoiceDetail in invoiceDetails)
                {
                    listReturnDetail.Add(new SalesReturnDetail
                    {
                        CreateDate = serverTime,
                        CreateUserId = userID,
                        ModifyDate = serverTime,
                        ModifyUserId = userID,
                        SalesReturn = salesReturn,
                        InvoiceDetailId = invoiceDetail.Id,
                        Status = (int)DbConstant.DefaultDataStatus.Active
                    });
                    totalTransaction += invoiceDetail.SubTotalPrice.AsDecimal();

                    SparepartDetail spDetail = _sparepartDetailRepository.GetById(invoiceDetail.SPKDetailSparepartDetail.SparepartDetailId);
                    spDetail.ModifyDate = serverTime;
                    spDetail.ModifyUserId = userID;
                    spDetail.Status = (int)DbConstant.SparepartDetailDataStatus.Active;
                    _sparepartDetailRepository.Update(spDetail);
                }

                Sparepart sparepart = _sparepartRepository.GetById(itemReturn.SparepartId);
                sparepart.ModifyDate = serverTime;
                sparepart.ModifyUserId = userID;
                sparepart.StockQty += itemReturn.ReturQty;
                _sparepartRepository.Update(sparepart);
            }

            foreach (var itemReturnDetail in listReturnDetail)
            {
                _salesReturnDetailRepository.Add(itemReturnDetail);
            }

            Reference transactionReferenceTable = _referenceRepository.GetMany(c => c.Code == DbConstant.REF_TRANSTBL_SALESRETURN).FirstOrDefault();
            Transaction transaction = new Transaction();
            transaction.CreateDate = serverTime;
            transaction.CreateUserId = userID;
            transaction.ModifyDate = serverTime;
            transaction.ModifyUserId = userID;
            transaction.PrimaryKeyValue = 0;
            transaction.ReferenceTableId = transactionReferenceTable.Id;
            transaction.TotalPayment = totalTransaction.AsDouble();
            transaction.TotalTransaction = totalTransaction.AsDouble();
            transaction.Status = (int)DbConstant.DefaultDataStatus.Active;
            transaction.Description = "Retur Penjualan";
            transaction.TransactionDate = serverTime;
            transaction = _transactionRepository.Add(transaction);

            TransactionDetail transCredit = new TransactionDetail();
            transCredit.Debit = totalTransaction;
            transCredit.Parent = transaction;
            transCredit.JournalId = _journalMasterRepository.GetMany(j => j.Code == "1.01.03.01.01").FirstOrDefault().Id;
            _transactionDetailRepository.Add(transCredit);

            TransactionDetail transDebit = new TransactionDetail();
            transDebit.Debit = totalTransaction;
            transDebit.Parent = transaction;
            transDebit.JournalId = _journalMasterRepository.GetMany(j => j.Code == "1.01.04.01").FirstOrDefault().Id;
            _transactionDetailRepository.Add(transDebit);

            _unitOfWork.SaveChanges();

            transaction.PrimaryKeyValue = salesReturn.Id;
            _transactionRepository.Update(transaction);
            _unitOfWork.SaveChanges();
        }

        public void UpdateSalesReturn(int invoiceID, int salesReturnID, List<ReturnViewModel> listReturn, int userID)
        {
            DateTime serverTime = DateTime.Now;

            List<SalesReturnDetail> listReturnDetail = _salesReturnDetailRepository.GetMany(x => x.SalesReturnId == salesReturnID).ToList();
            Transaction transaction = _transactionRepository.GetMany(x => x.PrimaryKeyValue == salesReturnID).FirstOrDefault();
            decimal totalTransaction = transaction.TotalTransaction.AsDecimal();
            foreach (var itemReturn in listReturn)
            {
                int oldReturQty = listReturnDetail.Where(x => x.InvoiceDetail.SPKDetailSparepartDetail.SparepartDetail.SparepartId == itemReturn.SparepartId).Count();
                if (itemReturn.ReturQty > oldReturQty)
                {
                    int diffQty = itemReturn.ReturQty - oldReturQty;
                    List<SalesReturnDetail> newReturnDetail = new List<SalesReturnDetail>();

                    List<InvoiceDetail> invoiceDetails = _invoiceDetailRepository.GetMany(x => x.SPKDetailSparepartDetail.SparepartDetail.SparepartId == itemReturn.SparepartId
                    && x.InvoiceId == invoiceID 
                    && (x.SPKDetailSparepartDetail.SparepartDetail.Status == (int)DbConstant.SparepartDetailDataStatus.OutPurchase
                    || x.SPKDetailSparepartDetail.SparepartDetail.Status == (int)DbConstant.SparepartDetailDataStatus.OutService) 
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

                        SparepartDetail spDetail = _sparepartDetailRepository.GetById(invoiceDetail.SPKDetailSparepartDetail.SparepartDetailId);
                        spDetail.ModifyDate = serverTime;
                        spDetail.ModifyUserId = userID;
                        spDetail.Status = (int)DbConstant.SparepartDetailDataStatus.Active;
                        _sparepartDetailRepository.Update(spDetail);
                    }

                    Sparepart sparepart = _sparepartRepository.GetById(itemReturn.SparepartId);
                    sparepart.ModifyDate = serverTime;
                    sparepart.ModifyUserId = userID;
                    sparepart.StockQty += diffQty;
                    _sparepartRepository.Update(sparepart);

                    foreach (var itemNewReturnDetail in newReturnDetail)
                    {
                        _salesReturnDetailRepository.Add(itemNewReturnDetail);
                    }
                }
                else if (itemReturn.ReturQty < oldReturQty)
                {
                    int diffQty = oldReturQty - itemReturn.ReturQty;
                    InvoiceDetail InvoiceDetail = _invoiceDetailRepository.GetMany(x => x.SPKDetailSparepartDetail.SparepartDetail.SparepartId == itemReturn.SparepartId && x.InvoiceId == invoiceID).FirstOrDefault();

                    List<SalesReturnDetail> listDeletedDetail = listReturnDetail.Where(x => x.InvoiceDetailId == InvoiceDetail.Id).OrderByDescending(x => x.CreateDate).Take(diffQty).ToList();
                    foreach (var itemDeleted in listDeletedDetail)
                    {
                        totalTransaction -= itemDeleted.InvoiceDetail.SubTotalPrice.AsDecimal();
                        _salesReturnDetailRepository.Delete(itemDeleted);

                        SparepartDetail spDetail = _sparepartDetailRepository.GetById(itemDeleted.InvoiceDetail.SPKDetailSparepartDetail.SparepartDetailId);
                        spDetail.ModifyDate = serverTime;
                        spDetail.ModifyUserId = userID;
                        spDetail.Status = (int)DbConstant.SparepartDetailDataStatus.OutPurchase;
                        _sparepartDetailRepository.Update(spDetail);
                    }

                    Sparepart sparepart = _sparepartRepository.GetById(itemReturn.SparepartId);
                    sparepart.ModifyDate = serverTime;
                    sparepart.ModifyUserId = userID;
                    sparepart.StockQty -= diffQty;
                    _sparepartRepository.Update(sparepart);
                }
            }

            transaction.TotalPayment = totalTransaction.AsDouble();
            transaction.TotalTransaction = totalTransaction.AsDouble();
            _transactionRepository.Update(transaction);

            TransactionDetail transDebit = _transactionDetailRepository.GetMany(x => x.ParentId == transaction.Id && x.Debit > 0).FirstOrDefault();
            transDebit.Debit = totalTransaction;
            _transactionDetailRepository.Update(transDebit);

            TransactionDetail transCredit = _transactionDetailRepository.GetMany(x => x.ParentId == transaction.Id && x.Credit > 0).FirstOrDefault();
            transCredit.Credit = totalTransaction;
            _transactionDetailRepository.Update(transCredit);

            _unitOfWork.SaveChanges();
        }

    }
}
