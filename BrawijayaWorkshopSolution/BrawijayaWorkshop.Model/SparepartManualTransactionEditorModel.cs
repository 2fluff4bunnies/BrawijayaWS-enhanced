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
    public class SparepartManualTransactionEditorModel : AppBaseModel
    {
        private ISparepartManualTransactionRepository _sparepartManualTransactionRepository;
        private ISparepartRepository _sparepartRepository;
        private ISparepartDetailRepository _sparepartDetailRepository;
        private ISpecialSparepartRepository _specialSparepartRepository;
        private ISpecialSparepartDetailRepository _specialSparepartDetailRepository;
        private IReferenceRepository _referenceRepository;
        private ITransactionRepository _transactionRepository;
        private ITransactionDetailRepository _transactionDetailRepository;
        private IJournalMasterRepository _journalMasterRepository;
        private IUnitOfWork _unitOfWork;

        public SparepartManualTransactionEditorModel(ISparepartManualTransactionRepository sparepartManualTransactionRepository,
            ISparepartRepository sparepartRepository,
            ISparepartDetailRepository sparepartDetailRepository,
            ISpecialSparepartRepository wheelRepository,
            ISpecialSparepartDetailRepository wheelDetailRepository,
            IReferenceRepository referenceRepository,
            ITransactionRepository transactionRepository,
            ITransactionDetailRepository transactionDetailRepository,
            IJournalMasterRepository journalMasterRepository,
            IUnitOfWork unitOfWork)
            : base()
        {
            _sparepartManualTransactionRepository = sparepartManualTransactionRepository;
            _sparepartRepository = sparepartRepository;
            _sparepartDetailRepository = sparepartDetailRepository;
            _specialSparepartRepository = wheelRepository;
            _specialSparepartDetailRepository = wheelDetailRepository;
            _referenceRepository = referenceRepository;
            _transactionRepository = transactionRepository;
            _transactionDetailRepository = transactionDetailRepository;
            _journalMasterRepository = journalMasterRepository;
            _unitOfWork = unitOfWork;
        }

        public List<ReferenceViewModel> RetrieveTransactionType()
        {
            Reference parent = null;
            parent = _referenceRepository
               .GetMany(c => c.Code == DbConstant.REF_SPAREPART_TRANSACTION_MANUAL_TYPE).FirstOrDefault();
            List<Reference> list = new List<Reference>();
            if (parent != null)
            {
                list = _referenceRepository.GetMany(c => c.ParentId == parent.Id).ToList();
            }
            List<ReferenceViewModel> mappedResult = new List<ReferenceViewModel>();
            return Map(list, mappedResult);
        }

        public void InsertSparepartManualTransaction(SparepartManualTransactionViewModel sparepartManualTransaction, decimal totalPrice, int userId)
        {
            using (var trans = _unitOfWork.BeginTransaction())
            {
                try
                {
                    DateTime serverTime = DateTime.Now;
                    sparepartManualTransaction.CreateDate = serverTime;
                    sparepartManualTransaction.CreateUserId = userId;
                    sparepartManualTransaction.ModifyDate = serverTime;
                    sparepartManualTransaction.ModifyUserId = userId;
                    sparepartManualTransaction.TransactionDate = serverTime;
                    Reference updateType = _referenceRepository.GetById(sparepartManualTransaction.UpdateTypeId);
                    Sparepart sparepartUpdated = _sparepartRepository.GetById(sparepartManualTransaction.SparepartId);
                    if (updateType != null && sparepartUpdated != null)
                    {
                        SparepartManualTransaction entity = new SparepartManualTransaction();
                        Map(sparepartManualTransaction, entity);

                        _sparepartManualTransactionRepository.AttachNavigation(entity.CreateUser);
                        _sparepartManualTransactionRepository.AttachNavigation(entity.ModifyUser);
                        _sparepartManualTransactionRepository.AttachNavigation(entity.Sparepart);
                        _sparepartManualTransactionRepository.AttachNavigation(entity.UpdateType);
                        SparepartManualTransaction manualTransaction = _sparepartManualTransactionRepository.Add(entity);
                        _unitOfWork.SaveChanges();

                        //Reference referenceTransaction = _referenceRepository.GetMany(x=>x.Code == DbConstant.REF_TRANSTBL_SPAREPARTMANUAL).FirstOrDefault();
                        //Transaction transaction = new Transaction();
                        //transaction.CreateDate = serverTime;
                        //transaction.CreateUserId = userId;
                        //transaction.ModifyDate = serverTime;
                        //transaction.ModifyUserId = userId;
                        //transaction.Description = "Transaksi sparepart manual";
                        //transaction.ReferenceTableId = referenceTransaction.Id;
                        //transaction.PrimaryKeyValue = 0;
                        //transaction.TotalPayment = totalPrice.AsDouble();
                        //transaction.TotalTransaction = totalPrice.AsDouble();
                        //transaction.TransactionDate = serverTime;
                        //transaction.Status = (int)DbConstant.DefaultDataStatus.Active;
                        //transaction =_transactionRepository.Add(transaction);


                        if (updateType.Code == DbConstant.REF_SPAREPART_TRANSACTION_MANUAL_TYPE_PLUS)
                        {
                            //TransactionDetail transDebit = new TransactionDetail();
                            //transDebit.Debit = totalPrice;
                            //transDebit.JournalId = _journalMasterRepository.GetMany(x => x.Code == "1.01.04.01").FirstOrDefault().Id;
                            //transDebit.Parent = transaction;
                            //_transactionDetailRepository.Add(transDebit);

                            //TransactionDetail transCredit = new TransactionDetail();
                            //transCredit.Credit = totalPrice;
                            //transCredit.JournalId = _journalMasterRepository.GetMany(x => x.Code == "9.9").FirstOrDefault().Id;
                            //transCredit.Parent = transaction;
                            //_transactionDetailRepository.Add(transCredit);

                            sparepartUpdated.StockQty += sparepartManualTransaction.Qty;

                            SparepartDetail lastSPDetail = _sparepartDetailRepository.
                            GetMany(c => c.SparepartId == sparepartManualTransaction.SparepartId).OrderByDescending(c => c.Id)
                            .FirstOrDefault();
                            string lastSPID = string.Empty;
                            if (lastSPDetail != null) lastSPID = lastSPDetail.Code;
                            for (int i = 1; i <= sparepartManualTransaction.Qty; i++)
                            {
                                SparepartDetail spDetail = new SparepartDetail();
                                if (string.IsNullOrEmpty(lastSPID))
                                {
                                    lastSPID = sparepartUpdated.Code + "0000000001";
                                }
                                else
                                {
                                    lastSPID = sparepartUpdated.Code + (Convert.ToInt32(lastSPID.Substring(lastSPID.Length - 10)) + 1)
                                        .ToString("D10");
                                }
                                spDetail.SparepartManualTransaction = manualTransaction;
                                spDetail.SparepartId = sparepartUpdated.Id;
                                spDetail.Code = lastSPID;
                                spDetail.CreateDate = serverTime;
                                spDetail.CreateUserId = userId;
                                spDetail.ModifyUserId = userId;
                                spDetail.ModifyDate = serverTime;
                                spDetail.Status = (int)DbConstant.SparepartDetailDataStatus.Active;

                                _sparepartDetailRepository.AttachNavigation(spDetail.CreateUser);
                                _sparepartDetailRepository.AttachNavigation(spDetail.ModifyUser);
                                _sparepartDetailRepository.AttachNavigation(spDetail.PurchasingDetail);
                                _sparepartDetailRepository.AttachNavigation(spDetail.Sparepart);
                                _sparepartDetailRepository.AttachNavigation(spDetail.SparepartManualTransaction);
                                SparepartDetail insertedSpDetail = _sparepartDetailRepository.Add(spDetail);

                                if (!string.IsNullOrEmpty(sparepartManualTransaction.SerialNumber))
                                {
                                    SpecialSparepart specialSparepart = _specialSparepartRepository.GetMany(w => w.SparepartId == sparepartUpdated.Id && w.Status == (int)DbConstant.DefaultDataStatus.Active ).FirstOrDefault();

                                    if (specialSparepart != null)
                                    {
                                        SpecialSparepartDetail wDetail = new SpecialSparepartDetail();
                                        wDetail.SparepartDetail = insertedSpDetail;
                                        wDetail.SpecialSparepartId = specialSparepart.Id;
                                        wDetail.SerialNumber = sparepartManualTransaction.SerialNumber;
                                        wDetail.CreateDate = serverTime;
                                        wDetail.CreateUserId = userId;
                                        wDetail.ModifyUserId = userId;
                                        wDetail.ModifyDate = serverTime;
                                        wDetail.Status = (int)DbConstant.WheelDetailStatus.Ready;

                                        _specialSparepartDetailRepository.AttachNavigation(spDetail.CreateUser);
                                        _specialSparepartDetailRepository.AttachNavigation(spDetail.ModifyUser);
                                        _specialSparepartDetailRepository.AttachNavigation(spDetail.PurchasingDetail);
                                        _specialSparepartDetailRepository.AttachNavigation(spDetail.Sparepart);
                                        _specialSparepartDetailRepository.AttachNavigation(spDetail.SparepartManualTransaction);
                                        _specialSparepartDetailRepository.Add(wDetail);

                                        _unitOfWork.SaveChanges();
                                    }
                                }

                            }
                        }
                        else if (updateType.Code == DbConstant.REF_SPAREPART_TRANSACTION_MANUAL_TYPE_MINUS)
                        {
                            //TransactionDetail transCredit = new TransactionDetail();
                            //transCredit.Credit = totalPrice;
                            //transCredit.JournalId = _journalMasterRepository.GetMany(x => x.Code == "1.01.04.01").FirstOrDefault().Id;
                            //transCredit.Parent = transaction;
                            //_transactionDetailRepository.Add(transCredit);

                            //TransactionDetail transDebit = new TransactionDetail();
                            //transDebit.Debit = totalPrice;
                            //transDebit.JournalId = _journalMasterRepository.GetMany(x => x.Code == "9.9").FirstOrDefault().Id;
                            //transDebit.Parent = transaction;
                            //_transactionDetailRepository.Add(transDebit);

                            sparepartUpdated.StockQty -= sparepartManualTransaction.Qty;

                            List<SparepartDetail> spDetails = _sparepartDetailRepository.
                            GetMany(c => c.SparepartId == sparepartManualTransaction.SparepartId).OrderByDescending(c => c.Id)
                            .Take(sparepartManualTransaction.Qty).ToList();
                            foreach (var spDetail in spDetails)
                            {
                                spDetail.ModifyUserId = userId;
                                spDetail.ModifyDate = serverTime;
                                spDetail.Status = (int)DbConstant.SparepartDetailDataStatus.Deleted;
                                _sparepartDetailRepository.Update(spDetail);
                            }
                        }

                        _sparepartRepository.AttachNavigation(sparepartUpdated.CreateUser);
                        _sparepartRepository.AttachNavigation(sparepartUpdated.ModifyUser);
                        _sparepartRepository.AttachNavigation(sparepartUpdated.CategoryReference);
                        _sparepartRepository.AttachNavigation(sparepartUpdated.UnitReference);
                        _sparepartRepository.Update(sparepartUpdated);
                        _unitOfWork.SaveChanges();

                        //transaction.PrimaryKeyValue = manualTransaction.Id;
                        //_transactionRepository.Update(transaction);
                        //_unitOfWork.SaveChanges();
                        trans.Commit();
                    }
                }
                catch (Exception)
                {
                    trans.Rollback();
                    throw;
                }
            }

        }

        public void UpdateSparepartManualTransaction(SparepartManualTransactionViewModel sparepartManualTransaction, int userId)
        {
            DateTime serverTime = DateTime.Now;
            sparepartManualTransaction.ModifyDate = serverTime;
            sparepartManualTransaction.ModifyUserId = userId;
            Reference updateTypeNew = _referenceRepository.GetById(sparepartManualTransaction.UpdateTypeId);
            SparepartManualTransaction manualTransactionOld = _sparepartManualTransactionRepository.GetById(sparepartManualTransaction.Id);
            Sparepart sparepartUpdated = _sparepartRepository.GetById(sparepartManualTransaction.SparepartId);
            if (manualTransactionOld != null && updateTypeNew != null && sparepartUpdated != null)
            {
                Reference updateTypeOld = _referenceRepository.GetById(manualTransactionOld.UpdateTypeId);

                if (updateTypeOld.Code == (DbConstant.REF_SPAREPART_TRANSACTION_MANUAL_TYPE_PLUS))
                {
                    sparepartUpdated.StockQty -= manualTransactionOld.Qty;
                }
                else if (updateTypeOld.Code == DbConstant.REF_SPAREPART_TRANSACTION_MANUAL_TYPE_MINUS)
                {
                    sparepartUpdated.StockQty += manualTransactionOld.Qty;
                }

                if (updateTypeNew.Code == DbConstant.REF_SPAREPART_TRANSACTION_MANUAL_TYPE_PLUS)
                {
                    sparepartUpdated.StockQty += sparepartManualTransaction.Qty;
                }
                else if (updateTypeNew.Code == DbConstant.REF_SPAREPART_TRANSACTION_MANUAL_TYPE_MINUS)
                {
                    sparepartUpdated.StockQty -= sparepartManualTransaction.Qty;
                }
                SparepartManualTransaction entity = new SparepartManualTransaction();
                Map(sparepartManualTransaction, entity);
                _sparepartManualTransactionRepository.Update(entity);
                _sparepartRepository.Update(sparepartUpdated);
                _unitOfWork.SaveChanges();
            }
        }

        public bool IsThisWheel(int sparepartId)
        {
            SpecialSparepart specialSparepart = _specialSparepartRepository.GetMany(w => w.SparepartId == sparepartId && w.Status == (int)DbConstant.DefaultDataStatus.Active).FirstOrDefault();

            return specialSparepart != null;
        }

        public bool IsSerialNumberExist(string sn)
        {
            SpecialSparepartDetail ssd = _specialSparepartDetailRepository.GetMany(dtl => dtl.SerialNumber.ToLower() == sn.ToLower() && dtl.Status != (int)DbConstant.WheelDetailStatus.Deleted).FirstOrDefault();

            if (ssd != null)
            {
                if (ssd.SparepartDetail.Status == (int)DbConstant.SparepartDetailDataStatus.OutService)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
