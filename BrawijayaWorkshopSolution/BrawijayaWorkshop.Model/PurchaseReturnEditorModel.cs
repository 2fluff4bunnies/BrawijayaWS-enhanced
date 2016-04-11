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
    public class PurchaseReturnEditorModel : AppBaseModel
    {
        private IPurchaseReturnRepository _purchaseReturnRepository;
        private IPurchaseReturnDetailRepository _purchaseReturnDetailRepository;
        private IPurchasingRepository _purchasingRepository;
        private IPurchasingDetailRepository _purchasingDetailRepository;
        private ISparepartRepository _sparepartRepository;
        private ISparepartDetailRepository _sparepartDetailRepository;
        private IReferenceRepository _referenceRepository;
        private ITransactionRepository _transactionRepository;
        private ITransactionDetailRepository _transactionDetailRepository;
        private IJournalMasterRepository _journalMasterRepository;
        private IUnitOfWork _unitOfWork;

        public PurchaseReturnEditorModel(
            IPurchaseReturnRepository purchaseReturnRepository,
            IPurchaseReturnDetailRepository purchaseReturnDetailRepository,
            IPurchasingRepository purchasingRepository,
            IPurchasingDetailRepository purchasingDetailRepository,
            ISparepartRepository sparepartRepository,
            ISparepartDetailRepository sparepartDetailRepository,
            IReferenceRepository referenceRepository,
            ITransactionRepository transactionRepository,
            ITransactionDetailRepository transactionDetailRepository,
            IJournalMasterRepository journalMasterRepository,
            IUnitOfWork unitOfWork)
            : base()
        {
            _purchaseReturnRepository = purchaseReturnRepository;
            _purchaseReturnDetailRepository = purchaseReturnDetailRepository;
            _purchasingRepository = purchasingRepository;
            _purchasingDetailRepository = purchasingDetailRepository;
            _sparepartRepository = sparepartRepository;
            _sparepartDetailRepository = sparepartDetailRepository;
            _transactionRepository = transactionRepository;
            _transactionDetailRepository = transactionDetailRepository;
            _journalMasterRepository = journalMasterRepository;
            _referenceRepository = referenceRepository;
            _unitOfWork = unitOfWork;
        }

        public List<PurchaseReturnDetail> RetrievePurchaseReturnDetail(int purchaseReturnID)
        {
            List<PurchaseReturnDetail> result = _purchaseReturnDetailRepository.GetMany(x => x.PurchaseReturnId == purchaseReturnID).ToList();
            return result;
        }

        public List<ReturnViewModel> RetrieveReturnList(int purchaseReturnID, int purchasingID)
        {
            List<ReturnViewModel> result = new List<ReturnViewModel>();
            List<PurchasingDetail> listPurchasingDetail = _purchasingDetailRepository.GetMany(x => x.PurchasingId == purchasingID).ToList();
            
            if(purchaseReturnID > 0)
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
                            ReturQty = listDetail.Where(x => x.SparepartDetail.SparepartId == itemDetail.SparepartId).Count(),
                            ReturQtyLimit = itemDetail.Qty
                        });
                    }
                }
            }
            else
            {
                foreach (var itemDetail in listPurchasingDetail)
                {
                    result.Add(new ReturnViewModel
                    {
                        SparepartId = itemDetail.SparepartId,
                        SparepartName = itemDetail.Sparepart.Name,
                        ReturQty = itemDetail.Qty,
                        ReturQtyLimit = itemDetail.Qty
                    });
                }
            }
            return result;
        }

        public void InsertPurchaseReturn(int purchasingID, List<ReturnViewModel> listReturn, int userID)
        {
            DateTime serverTime = DateTime.Now;
            PurchaseReturn purchaseReturn = new PurchaseReturn();
            purchaseReturn.CreateDate = serverTime;
            purchaseReturn.CreateUserId = userID;
            purchaseReturn.ModifyDate = serverTime;
            purchaseReturn.ModifyUserId = userID;
            purchaseReturn.PurchasingId = purchasingID;
            purchaseReturn.Date = serverTime;
            purchaseReturn.Status = (int)DbConstant.DefaultDataStatus.Active;

            string code = "PRR" + "-" + serverTime.Month.ToString() + serverTime.Day.ToString() + "-";
            //get total purchasing return created today
            List<PurchaseReturn> todayPRR = _purchaseReturnRepository.GetMany(s => s.Code.ToString().Contains(code) && s.CreateDate.Year == serverTime.Year).ToList();
            code = code + (todayPRR.Count + 1);
            purchaseReturn.Code = code;

            purchaseReturn = _purchaseReturnRepository.Add(purchaseReturn);

            List<PurchaseReturnDetail> listReturnDetail = new List<PurchaseReturnDetail>();

            decimal totalTransaction = 0;
            foreach (var itemReturn in listReturn)
	        {
		        PurchasingDetail purchasingDetail = _purchasingDetailRepository.GetMany(x=>x.SparepartId == itemReturn.SparepartId && x.PurchasingId == purchasingID).FirstOrDefault();
                List<SparepartDetail> listSpDetail = _sparepartDetailRepository.GetMany(x => x.PurchasingDetailId == purchasingDetail.Id && x.Status == (int)DbConstant.SparepartDetailDataStatus.Active).OrderByDescending(x => x.CreateDate).Take(itemReturn.ReturQty).ToList();

                foreach (var spDetail in listSpDetail)
                {
                    listReturnDetail.Add(new PurchaseReturnDetail
                    {
                        CreateDate = serverTime,
                        CreateUserId = userID,
                        ModifyDate = serverTime,
                        ModifyUserId = userID,
                        PurchaseReturn = purchaseReturn,
                        PurchasingDetailId = purchasingDetail.Id,
                        SparepartDetailId = spDetail.Id,
                        Status = (int)DbConstant.DefaultDataStatus.Active
                    });
                    totalTransaction += spDetail.PurchasingDetail.Price;

                    spDetail.ModifyDate = serverTime;
                    spDetail.ModifyUserId = userID;
                    spDetail.Status = (int)DbConstant.SparepartDetailDataStatus.Deleted;
                    _sparepartDetailRepository.Update(spDetail);
                }

                Sparepart sparepart = _sparepartRepository.GetById(itemReturn.SparepartId);
                sparepart.ModifyDate = serverTime;
                sparepart.ModifyUserId = userID;
                sparepart.StockQty -= itemReturn.ReturQty;
                _sparepartRepository.Update(sparepart);
	        }

            foreach (var itemReturnDetail in listReturnDetail)
	        {
                _purchaseReturnDetailRepository.Add(itemReturnDetail);
	        }

            Reference transactionReferenceTable = _referenceRepository.GetMany(c => c.Code == DbConstant.REF_TRANSTBL_PURCHASERETURN).FirstOrDefault();
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
            transaction.Description = "Retur Pembelian";
            transaction.TransactionDate = serverTime;
            transaction = _transactionRepository.Add(transaction);

            TransactionDetail transDebit = new TransactionDetail();
            transDebit.Debit = totalTransaction;
            transDebit.Parent = transaction;
            transDebit.JournalId = _journalMasterRepository.GetMany(j => j.Code == "2.01.01.01").FirstOrDefault().Id;
            _transactionDetailRepository.Add(transDebit);

            TransactionDetail transCredit = new TransactionDetail();
            transCredit.Credit = totalTransaction;
            transCredit.Parent = transaction;
            transCredit.JournalId = _journalMasterRepository.GetMany(j => j.Code == "1.01.04.01").FirstOrDefault().Id;
            _transactionDetailRepository.Add(transCredit);

            _unitOfWork.SaveChanges();

            transaction.PrimaryKeyValue = purchaseReturn.Id;
            _transactionRepository.Update(transaction);
            _unitOfWork.SaveChanges();
        }

        public void UpdatePurchaseReturn(int purchasingID, int purchaseReturnID, List<ReturnViewModel> listReturn, int userID)
        {
            DateTime serverTime = DateTime.Now;
            
            List<PurchaseReturnDetail> listReturnDetail = _purchaseReturnDetailRepository.GetMany(x => x.PurchaseReturnId == purchaseReturnID).ToList();
            Transaction transaction = _transactionRepository.GetMany(x => x.PrimaryKeyValue == purchaseReturnID).FirstOrDefault();
            decimal totalTransaction = transaction.TotalTransaction.AsDecimal();
            foreach (var itemReturn in listReturn)
            {
                int oldReturQty = listReturnDetail.Where(x => x.SparepartDetail.SparepartId == itemReturn.SparepartId).Count();
                if(itemReturn.ReturQty > oldReturQty)
                {
                    int diffQty = itemReturn.ReturQty - oldReturQty;
                    List<PurchaseReturnDetail> newReturnDetail = new List<PurchaseReturnDetail>();
                    PurchasingDetail purchasingDetail = _purchasingDetailRepository.GetMany(x => x.SparepartId == itemReturn.SparepartId && x.PurchasingId == purchasingID).FirstOrDefault();
                    List<SparepartDetail> listSpDetail = _sparepartDetailRepository.GetMany(x => x.PurchasingDetailId == purchasingDetail.Id && x.Status == (int)DbConstant.SparepartDetailDataStatus.Active).OrderByDescending(x => x.CreateDate).Take(diffQty).ToList();

                    foreach (var spDetail in listSpDetail)
                    {
                        newReturnDetail.Add(new PurchaseReturnDetail
                        {
                            CreateDate = serverTime,
                            CreateUserId = userID,
                            ModifyDate = serverTime,
                            ModifyUserId = userID,
                            PurchaseReturnId = purchaseReturnID,
                            PurchasingDetailId = purchasingDetail.Id,
                            SparepartDetailId = spDetail.Id,
                            Status = (int)DbConstant.DefaultDataStatus.Active
                        });
                        totalTransaction += spDetail.PurchasingDetail.Price;

                        spDetail.ModifyDate = serverTime;
                        spDetail.ModifyUserId = userID;
                        spDetail.Status = (int)DbConstant.SparepartDetailDataStatus.Deleted;
                        _sparepartDetailRepository.Update(spDetail);
                    }

                    Sparepart sparepart = _sparepartRepository.GetById(itemReturn.SparepartId);
                    sparepart.ModifyDate = serverTime;
                    sparepart.ModifyUserId = userID;
                    sparepart.StockQty -= diffQty;
                    _sparepartRepository.Update(sparepart);

                    foreach (var itemNewReturnDetail in newReturnDetail)
                    {
                        _purchaseReturnDetailRepository.Add(itemNewReturnDetail);
                    }
                }
                else if(itemReturn.ReturQty < oldReturQty)
                {
                    int diffQty = oldReturQty - itemReturn.ReturQty;
                    PurchasingDetail purchasingDetail = _purchasingDetailRepository.GetMany(x => x.SparepartId == itemReturn.SparepartId && x.PurchasingId == purchasingID).FirstOrDefault();

                    List<PurchaseReturnDetail> listDeletedDetail = listReturnDetail.Where(x => x.PurchasingDetailId == purchasingDetail.Id).OrderByDescending(x => x.CreateDate).Take(diffQty).ToList();
                    foreach (var itemDeleted in listDeletedDetail)
                    {
                        totalTransaction -= itemDeleted.PurchasingDetail.Price;
                        _purchaseReturnDetailRepository.Delete(itemDeleted);

                        SparepartDetail spDetail = _sparepartDetailRepository.GetById(itemDeleted.SparepartDetailId);
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
                }
            }

            transaction.TotalPayment = totalTransaction.AsDouble();
            transaction.TotalTransaction = totalTransaction.AsDouble();
            _transactionRepository.Update(transaction);

            TransactionDetail transDebit = _transactionDetailRepository.GetMany(x=>x.ParentId == transaction.Id && x.Debit > 0).FirstOrDefault();
            transDebit.Debit = totalTransaction;
            _transactionDetailRepository.Update(transDebit);

            TransactionDetail transCredit = _transactionDetailRepository.GetMany(x => x.ParentId == transaction.Id && x.Credit > 0).FirstOrDefault();
            transCredit.Credit = totalTransaction;
            _transactionDetailRepository.Update(transCredit);

            _unitOfWork.SaveChanges();
        }

    }
}
