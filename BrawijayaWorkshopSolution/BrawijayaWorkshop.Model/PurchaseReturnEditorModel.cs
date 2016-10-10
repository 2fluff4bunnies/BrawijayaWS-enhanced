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

            if (purchaseReturnID > 0)
            {
                List<PurchaseReturnDetail> listDetail = this.RetrievePurchaseReturnDetail(purchaseReturnID);
                if (listDetail != null && listDetail.Count > 0)
                {
                    foreach (var itemDetail in listPurchasingDetail)
                    {
                        if (string.IsNullOrEmpty(itemDetail.SerialNumber))
                        {
                            result.Add(new ReturnViewModel
                            {
                                SparepartId = itemDetail.SparepartId,
                                SparepartName = itemDetail.Sparepart.Name,
                                ReturQty = listDetail.Where(x => x.SparepartDetail.SparepartId == itemDetail.SparepartId).Count(),
                                ReturQtyLimit = itemDetail.Qty,
                                SerialNumber = itemDetail.SerialNumber
                            });
                        }
                        else
                        {
                            result.Add(new ReturnViewModel
                            {
                                SparepartId = itemDetail.SparepartId,
                                SparepartName = itemDetail.Sparepart.Name,
                                ReturQty = listDetail.Where(x => x.PurchasingDetailId == itemDetail.Id).Count(),
                                ReturQtyLimit = itemDetail.Qty,
                                SerialNumber = itemDetail.SerialNumber
                            });
                        }

                    }
                }
            }
            else
            {
                foreach (var itemDetail in listPurchasingDetail)
                {
                    List<SparepartDetail> listSparepartDetail = _sparepartDetailRepository.GetMany(x => x.PurchasingDetailId == itemDetail.Id
                        && x.Status == (int)DbConstant.SparepartDetailDataStatus.Active).ToList();
                    result.Add(new ReturnViewModel
                    {
                        SparepartId = itemDetail.SparepartId,
                        SparepartName = itemDetail.Sparepart.Name,
                        ReturQty = listSparepartDetail != null ? listSparepartDetail.Count > 0 ? listSparepartDetail.Count : 0 : 0,
                        ReturQtyLimit = listSparepartDetail != null ? listSparepartDetail.Count > 0 ? listSparepartDetail.Count : 0 : 0,
                        SerialNumber = itemDetail.SerialNumber
                    });
                }
            }
            return result;
        }

        public void InsertPurchaseReturn(int purchasingID, List<ReturnViewModel> listReturn, int userID)
        {
            using (var trans = _unitOfWork.BeginTransaction())
            {
                try
                {
                    InsertPurchaseReturnFunc(purchasingID, listReturn, userID);
                    trans.Commit();
                }
                catch (Exception)
                {
                    trans.Rollback();
                    throw;
                }
            }
        }

        public void UpdatePurchaseReturn(int purchasingID, int purchaseReturnID, List<ReturnViewModel> listReturn, int userID)
        {
            using (var trans = _unitOfWork.BeginTransaction())
            {
                try
                {
                    DeletePurchaseReturnFunc(purchaseReturnID, userID);
                    InsertPurchaseReturnFunc(purchasingID, listReturn, userID);
                    trans.Commit();
                }
                catch (Exception)
                {
                    trans.Rollback();
                    throw;
                }
            }
        }

        public void InsertPurchaseReturnFunc(int purchasingID, List<ReturnViewModel> listReturn, int userID)
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

            _purchaseReturnRepository.AttachNavigation(purchaseReturn.CreateUser);
            _purchaseReturnRepository.AttachNavigation(purchaseReturn.ModifyUser);
            _purchaseReturnRepository.AttachNavigation(purchaseReturn.Purchasing);
            purchaseReturn = _purchaseReturnRepository.Add(purchaseReturn);

            
            _unitOfWork.SaveChanges();

            List<PurchaseReturnDetail> listReturnDetail = new List<PurchaseReturnDetail>();

            decimal totalTransaction = 0;
            foreach (var itemReturn in listReturn)
            {
                PurchasingDetail purchasingDetail = _purchasingDetailRepository.GetMany(x => x.SparepartId == itemReturn.SparepartId && x.PurchasingId == purchasingID).FirstOrDefault();
                List<SparepartDetail> listSpDetail = _sparepartDetailRepository.GetMany(x => x.PurchasingDetailId == purchasingDetail.Id && x.Status == (int)DbConstant.SparepartDetailDataStatus.Active).OrderByDescending(x => x.CreateDate).Take(itemReturn.ReturQty).ToList();

                foreach (var spDetail in listSpDetail)
                {
                    listReturnDetail.Add(new PurchaseReturnDetail
                    {
                        CreateDate = serverTime,
                        CreateUserId = userID,
                        ModifyDate = serverTime,
                        ModifyUserId = userID,
                        PurchaseReturnId = purchaseReturn.Id,
                        PurchasingDetailId = purchasingDetail.Id,
                        SparepartDetailId = spDetail.Id,
                        Status = (int)DbConstant.DefaultDataStatus.Active
                    });
                    totalTransaction += spDetail.PurchasingDetail.Price;

                    spDetail.ModifyDate = serverTime;
                    spDetail.ModifyUserId = userID;
                    spDetail.Status = (int)DbConstant.SparepartDetailDataStatus.Deleted;

                    _sparepartDetailRepository.AttachNavigation(spDetail.CreateUser);
                    _sparepartDetailRepository.AttachNavigation(spDetail.ModifyUser);
                    _sparepartDetailRepository.AttachNavigation(spDetail.PurchasingDetail);
                    _sparepartDetailRepository.AttachNavigation(spDetail.Sparepart);
                    _sparepartDetailRepository.AttachNavigation(spDetail.SparepartManualTransaction);
                    _sparepartDetailRepository.Update(spDetail);
                }

                Sparepart sparepart = _sparepartRepository.GetById(itemReturn.SparepartId);
                sparepart.ModifyDate = serverTime;
                sparepart.ModifyUserId = userID;
                sparepart.StockQty -= itemReturn.ReturQty;

                _sparepartRepository.AttachNavigation(sparepart.CreateUser);
                _sparepartRepository.AttachNavigation(sparepart.ModifyUser);
                _sparepartRepository.AttachNavigation(sparepart.CategoryReference);
                _sparepartRepository.AttachNavigation(sparepart.UnitReference);
                _sparepartRepository.Update(sparepart);
            }

            Purchasing purchasing = _purchasingRepository.GetById(purchaseReturn.PurchasingId);
            if(purchasing.TotalPrice != purchasing.TotalHasPaid && (purchasing.TotalPrice - purchasing.TotalHasPaid) >= totalTransaction)
            {
                purchasing.TotalHasPaid += totalTransaction;
            }

            if (purchasing.TotalPrice == purchasing.TotalHasPaid)
            {
                purchasing.PaymentStatus = (int)DbConstant.PaymentStatus.Settled;
            }
            else
            {
                purchasing.PaymentStatus = (int)DbConstant.PaymentStatus.NotSettled;
            }

            _purchasingRepository.AttachNavigation(purchasing.CreateUser);
            _purchasingRepository.AttachNavigation(purchasing.ModifyUser);
            _purchasingRepository.AttachNavigation(purchasing.PaymentMethod);
            _purchasingRepository.AttachNavigation(purchasing.Supplier);

            _unitOfWork.SaveChanges();

            foreach (var itemReturnDetail in listReturnDetail)
            {
                _purchaseReturnDetailRepository.AttachNavigation(itemReturnDetail.CreateUser);
                _purchaseReturnRepository.AttachNavigation(itemReturnDetail.ModifyUser);
                _purchaseReturnRepository.AttachNavigation(itemReturnDetail.PurchaseReturn);
                _purchaseReturnRepository.AttachNavigation(itemReturnDetail.PurchasingDetail);
                _purchaseReturnRepository.AttachNavigation(itemReturnDetail.SparepartDetail);
                _purchaseReturnDetailRepository.Add(itemReturnDetail);
            }

            _unitOfWork.SaveChanges();

            Reference transactionReferenceTable = _referenceRepository.GetMany(c => c.Code == DbConstant.REF_TRANSTBL_PURCHASERETURN).FirstOrDefault();
            Transaction transaction = new Transaction();
            transaction.CreateDate = serverTime;
            transaction.CreateUserId = userID;
            transaction.ModifyDate = serverTime;
            transaction.ModifyUserId = userID;
            transaction.PrimaryKeyValue = purchaseReturn.Id;
            transaction.ReferenceTableId = transactionReferenceTable.Id;
            transaction.TotalPayment = totalTransaction.AsDouble();
            transaction.TotalTransaction = totalTransaction.AsDouble();
            transaction.Status = (int)DbConstant.DefaultDataStatus.Active;
            transaction.Description = "Retur Pembelian";
            transaction.TransactionDate = serverTime;

            _transactionRepository.AttachNavigation(transaction.CreateUser);
            _transactionRepository.AttachNavigation(transaction.ModifyUser);
            _transactionRepository.AttachNavigation(transaction.PaymentMethod);
            _transactionRepository.AttachNavigation(transaction.ReferenceTable);
            transaction = _transactionRepository.Add(transaction);

            _unitOfWork.SaveChanges();

            TransactionDetail transDebit = new TransactionDetail();
            transDebit.Debit = totalTransaction;
            transDebit.ParentId = transaction.Id;
            transDebit.JournalId = _journalMasterRepository.GetMany(j => j.Code == "2.01.01.01").FirstOrDefault().Id;

            _transactionDetailRepository.AttachNavigation(transDebit.Journal);
            _transactionDetailRepository.AttachNavigation(transDebit.Parent);
            _transactionDetailRepository.Add(transDebit);

            TransactionDetail transCredit = new TransactionDetail();
            transCredit.Credit = totalTransaction;
            transCredit.ParentId = transaction.Id;
            transCredit.JournalId = _journalMasterRepository.GetMany(j => j.Code == "1.01.04.01").FirstOrDefault().Id;

            _transactionDetailRepository.AttachNavigation(transCredit.Journal);
            _transactionDetailRepository.AttachNavigation(transCredit.Parent);
            _transactionDetailRepository.Add(transCredit);

            _unitOfWork.SaveChanges();
        }

        public void DeletePurchaseReturnFunc(int purchaseReturnID, int userID)
        {
            //delete old purchase return
            DateTime serverTime = DateTime.Now;
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

            List<ReturnViewModel> listReturn = listDetail
                                    .GroupBy(l => l.SparepartDetail.Sparepart)
                                    .Select(cl => new ReturnViewModel
                                    {
                                        SparepartId = cl.First().SparepartDetail.SparepartId,
                                        ReturQty = cl.Count(),
                                    }).ToList();

            foreach (var itemDetail in listDetail)
            {
                itemDetail.Status = (int)DbConstant.DefaultDataStatus.Deleted;
                itemDetail.ModifyDate = serverTime;
                itemDetail.ModifyUserId = userID;

                _purchaseReturnDetailRepository.AttachNavigation(itemDetail.CreateUser);
                _purchaseReturnRepository.AttachNavigation(itemDetail.ModifyUser);
                _purchaseReturnRepository.AttachNavigation(itemDetail.PurchaseReturn);
                _purchaseReturnRepository.AttachNavigation(itemDetail.PurchasingDetail);
                _purchaseReturnRepository.AttachNavigation(itemDetail.SparepartDetail);
                _purchaseReturnDetailRepository.Update(itemDetail);

                SparepartDetail spDetail = _sparepartDetailRepository.GetById(itemDetail.SparepartDetailId);
                spDetail.Status = (int)DbConstant.DefaultDataStatus.Active;

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
            }
            
            _unitOfWork.SaveChanges();

            Reference transactionReferenceTable = _referenceRepository.GetMany(c => c.Code == DbConstant.REF_TRANSTBL_PURCHASERETURN).FirstOrDefault();
            Transaction transaction = _transactionRepository.GetMany(x => x.PrimaryKeyValue == purchaseReturnID && x.ReferenceTableId == transactionReferenceTable.Id).FirstOrDefault();
            transaction.Status = (int)DbConstant.DefaultDataStatus.Deleted;
            transaction.ModifyDate = serverTime;
            transaction.ModifyUserId = userID;

            _transactionRepository.AttachNavigation(transaction.CreateUser);
            _transactionRepository.AttachNavigation(transaction.ModifyUser);
            _transactionRepository.AttachNavigation(transaction.PaymentMethod);
            _transactionRepository.AttachNavigation(transaction.ReferenceTable);
            _transactionRepository.Update(transaction);

            Purchasing purchasing = _purchasingRepository.GetById(purchaseReturn.PurchasingId);
            if (purchasing.TotalPrice != purchasing.TotalHasPaid && (purchasing.TotalPrice - purchasing.TotalHasPaid) >= (decimal) transaction.TotalTransaction)
            {
                purchasing.TotalHasPaid -= (decimal) transaction.TotalTransaction;
            }

            if (purchasing.TotalPrice == purchasing.TotalHasPaid)
            {
                purchasing.PaymentStatus = (int)DbConstant.PaymentStatus.Settled;
            }
            else
            {
                purchasing.PaymentStatus = (int)DbConstant.PaymentStatus.NotSettled;
            }

            _purchasingRepository.AttachNavigation(purchasing.CreateUser);
            _purchasingRepository.AttachNavigation(purchasing.ModifyUser);
            _purchasingRepository.AttachNavigation(purchasing.PaymentMethod);
            _purchasingRepository.AttachNavigation(purchasing.Supplier);


            _unitOfWork.SaveChanges();
        }

        public void UpdatePurchaseReturnOldMethod(int purchasingID, int purchaseReturnID, List<ReturnViewModel> listReturn, int userID)
        {
            using (var trans = _unitOfWork.BeginTransaction())
            {
                try
                {
                    DateTime serverTime = DateTime.Now;

                    //List<PurchaseReturnDetail> listReturnDetail = _purchaseReturnDetailRepository.GetMany(x => x.PurchaseReturnId == purchaseReturnID).ToList();
                    Reference transactionReferenceTable = _referenceRepository.GetMany(c => c.Code == DbConstant.REF_TRANSTBL_PURCHASERETURN).FirstOrDefault();
                    Transaction transaction = _transactionRepository.GetMany(x => x.PrimaryKeyValue == purchaseReturnID && x.ReferenceTableId == transactionReferenceTable.Id).FirstOrDefault();
                    decimal totalTransaction = transaction.TotalTransaction.AsDecimal();
                    foreach (var itemReturn in listReturn)
                    {
                        int oldReturQty = 0;
                        List<PurchaseReturnDetail> listReturnUpdated = _purchaseReturnDetailRepository.GetMany(x => x.PurchaseReturnId == purchaseReturnID
                            && x.SparepartDetail.SparepartId == itemReturn.SparepartId).ToList();
                        oldReturQty = listReturnUpdated != null ? listReturnUpdated.Count > 0 ? listReturnUpdated.Count : 0 : 0;
                        if (itemReturn.ReturQty > oldReturQty)
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

                                _sparepartDetailRepository.AttachNavigation(spDetail.CreateUser);
                                _sparepartDetailRepository.AttachNavigation(spDetail.ModifyUser);
                                _sparepartDetailRepository.AttachNavigation(spDetail.PurchasingDetail);
                                _sparepartDetailRepository.AttachNavigation(spDetail.Sparepart);
                                _sparepartDetailRepository.AttachNavigation(spDetail.SparepartManualTransaction);
                                _sparepartDetailRepository.Update(spDetail);
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

                            foreach (var itemNewReturnDetail in newReturnDetail)
                            {
                                _purchaseReturnDetailRepository.AttachNavigation(itemNewReturnDetail.CreateUser);
                                _purchaseReturnRepository.AttachNavigation(itemNewReturnDetail.ModifyUser);
                                _purchaseReturnRepository.AttachNavigation(itemNewReturnDetail.PurchaseReturn);
                                _purchaseReturnRepository.AttachNavigation(itemNewReturnDetail.PurchasingDetail);
                                _purchaseReturnRepository.AttachNavigation(itemNewReturnDetail.SparepartDetail);
                                _purchaseReturnDetailRepository.Add(itemNewReturnDetail);
                            }
                        }
                        else if (itemReturn.ReturQty < oldReturQty)
                        {
                            int diffQty = oldReturQty - itemReturn.ReturQty;
                            PurchasingDetail purchasingDetail = _purchasingDetailRepository.GetMany(x => x.SparepartId == itemReturn.SparepartId && x.PurchasingId == purchasingID).FirstOrDefault();

                            List<PurchaseReturnDetail> listDeletedDetail = _purchaseReturnDetailRepository.GetMany(x => x.PurchaseReturnId == purchaseReturnID
                                && x.PurchasingDetailId == purchasingDetail.Id).OrderByDescending(x => x.CreateDate).Take(diffQty).ToList();
                            foreach (var itemDeleted in listDeletedDetail)
                            {
                                totalTransaction -= itemDeleted.PurchasingDetail.Price;
                                _purchaseReturnDetailRepository.Delete(itemDeleted);

                                SparepartDetail spDetail = _sparepartDetailRepository.GetById(itemDeleted.SparepartDetailId);
                                spDetail.ModifyDate = serverTime;
                                spDetail.ModifyUserId = userID;
                                spDetail.Status = (int)DbConstant.SparepartDetailDataStatus.Active;

                                _sparepartDetailRepository.AttachNavigation(spDetail.CreateUser);
                                _sparepartDetailRepository.AttachNavigation(spDetail.ModifyUser);
                                _sparepartDetailRepository.AttachNavigation(spDetail.PurchasingDetail);
                                _sparepartDetailRepository.AttachNavigation(spDetail.Sparepart);
                                _sparepartDetailRepository.AttachNavigation(spDetail.SparepartManualTransaction);
                                _sparepartDetailRepository.Update(spDetail);
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
