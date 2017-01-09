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
        private ISparepartStockCardRepository _sparepartStockCardRepository;
        private ISparepartStockCardDetailRepository _sparepartStockCardDetailRepository;
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
            ISparepartStockCardRepository sparepartStockCardRepository,
            ISparepartStockCardDetailRepository sparepartStockCardDetailRepository,
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
            _sparepartStockCardRepository = sparepartStockCardRepository;
            _sparepartStockCardDetailRepository = sparepartStockCardDetailRepository;
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

                        Reference transactionReferenceTable = _referenceRepository.GetMany(c => c.Code == DbConstant.REF_TRANSTBL_SPAREPARTMANUAL).FirstOrDefault();
                        SparepartStockCard stockCard = new SparepartStockCard();
                        stockCard.CreateUserId = userId;
                        stockCard.PurchaseDate = serverTime;
                        stockCard.PrimaryKeyValue = manualTransaction.Id;
                        stockCard.ReferenceTableId = transactionReferenceTable.Id;
                        stockCard.SparepartId = manualTransaction.SparepartId;

                        if (updateType.Code == DbConstant.REF_SPAREPART_TRANSACTION_MANUAL_TYPE_PLUS)
                        {
                            stockCard.Description = "Penambahan stok awal";
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
                            stockCard.QtyIn = sparepartManualTransaction.Qty;
                            stockCard.QtyInPrice = (sparepartManualTransaction.Qty * sparepartManualTransaction.Price).AsDouble();

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
                            stockCard.Description = "Pengurangan stok awal";
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
                            stockCard.QtyOut = sparepartManualTransaction.Qty;
                            stockCard.QtyOutPrice = (sparepartManualTransaction.Qty * sparepartManualTransaction.Price).AsDouble();

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

                        SparepartStockCard lastStockCard = _sparepartStockCardRepository.RetrieveLastCard(manualTransaction.SparepartId);
                        double lastStock = 0;
                        double lastStockPrice = 0;
                        if (lastStockCard != null)
                        {
                            lastStock = lastStockCard.QtyLast;
                            lastStockPrice = lastStockCard.QtyLastPrice;
                        }
                        stockCard.QtyFirst = lastStock;
                        stockCard.QtyFirstPrice = lastStockPrice;
                        stockCard.QtyLast = lastStock + (stockCard.QtyIn - stockCard.QtyOut);
                        stockCard.QtyLastPrice = lastStockPrice + (stockCard.QtyInPrice - stockCard.QtyOutPrice);

                        _sparepartStockCardRepository.AttachNavigation(stockCard.CreateUser);
                        _sparepartStockCardRepository.AttachNavigation(stockCard.Sparepart);
                        _sparepartStockCardRepository.AttachNavigation(stockCard.ReferenceTable);
                        stockCard = _sparepartStockCardRepository.Add(stockCard);
                        _unitOfWork.SaveChanges();

                        SparepartStockCardDetail stockCardDetail = new SparepartStockCardDetail();
                        stockCardDetail.ParentStockCard = stockCard;
                        stockCardDetail.PricePerItem = Convert.ToDouble(manualTransaction.Price);
                        stockCardDetail.QtyIn = manualTransaction.Qty;
                        stockCardDetail.QtyInPrice = Convert.ToDouble(manualTransaction.Price * manualTransaction.Qty);
                        stockCardDetail.QtyOut = 0;
                        stockCardDetail.QtyOutPrice = 0;
                        SparepartStockCardDetail lastStockCardDetail = _sparepartStockCardDetailRepository.RetrieveLastCardDetailByPurchasingId(manualTransaction.SparepartId, manualTransaction.Id);
                        double lastStockDetail = 0;
                        double lastStockDetailPrice = 0;
                        if (lastStockCardDetail != null)
                        {
                            lastStockDetail = lastStockCardDetail.QtyLast;
                            lastStockDetailPrice = lastStockCardDetail.QtyLastPrice;
                        }
                        stockCardDetail.QtyFirst = lastStockDetail;
                        stockCardDetail.QtyFirstPrice = lastStockDetailPrice;
                        stockCardDetail.QtyLast = manualTransaction.Qty;
                        stockCardDetail.QtyLastPrice = Convert.ToDouble(manualTransaction.Price * manualTransaction.Qty);
                        stockCardDetail.SparepartManualTransactionId = manualTransaction.Id;
                        _sparepartStockCardDetailRepository.AttachNavigation(stockCardDetail.ParentStockCard);
                        _sparepartStockCardDetailRepository.Add(stockCardDetail);

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
                catch (Exception ex)
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

                Reference transactionReferenceTable = _referenceRepository.GetMany(c => c.Code == DbConstant.REF_TRANSTBL_SPAREPARTMANUAL).FirstOrDefault();
                SparepartStockCard stockCard = new SparepartStockCard();
                stockCard.CreateUserId = userId;
                stockCard.PurchaseDate = serverTime;
                stockCard.ReferenceTableId = transactionReferenceTable.Id;
                stockCard.PrimaryKeyValue = manualTransactionOld.Id;
                stockCard.SparepartId = sparepartManualTransaction.SparepartId;

                SparepartStockCardDetail stockCardDetail = new SparepartStockCardDetail();
                stockCardDetail.SparepartManualTransactionId = manualTransactionOld.Id;

                SparepartStockCard lastStockCard = _sparepartStockCardRepository.RetrieveLastCard(sparepartManualTransaction.SparepartId);
                double lastStock = 0;
                double lastPrice = 0;
                if (lastStockCard != null)
                {
                    lastStock = lastStockCard.QtyLast;
                    lastPrice = lastStockCard.PricePerItem;
                }

                stockCard.QtyFirst = lastStock;
                stockCard.QtyFirstPrice = (stockCard.QtyFirst * lastPrice).AsDouble();
                stockCardDetail.QtyFirst = stockCard.QtyFirst;
                stockCardDetail.QtyFirstPrice = stockCard.QtyFirstPrice;

                if (updateTypeOld.Code == (DbConstant.REF_SPAREPART_TRANSACTION_MANUAL_TYPE_PLUS))
                {
                    stockCard.Description = "Revisi pembatalan penambahan stok awal";
                    stockCard.QtyOut = manualTransactionOld.Qty;
                    stockCard.QtyOutPrice = stockCard.QtyOut * manualTransactionOld.Price.AsDouble();

                    stockCardDetail.QtyOut = manualTransactionOld.Qty;
                    stockCardDetail.QtyOutPrice = stockCardDetail.QtyOut * manualTransactionOld.Price.AsDouble();

                    sparepartUpdated.StockQty -= manualTransactionOld.Qty;
                }
                else if (updateTypeOld.Code == DbConstant.REF_SPAREPART_TRANSACTION_MANUAL_TYPE_MINUS)
                {
                    stockCard.Description = "Revisi pembatalan pengurangan stok awal";
                    stockCard.QtyIn = manualTransactionOld.Qty;
                    stockCard.QtyInPrice = stockCard.QtyIn * manualTransactionOld.Price.AsDouble();

                    stockCardDetail.QtyIn = manualTransactionOld.Qty;
                    stockCardDetail.QtyInPrice = stockCardDetail.QtyIn * manualTransactionOld.Price.AsDouble();

                    sparepartUpdated.StockQty += manualTransactionOld.Qty;
                }

                stockCard.QtyLast = stockCard.QtyFirst + (stockCard.QtyIn - stockCard.QtyOut);
                stockCard.QtyLastPrice = stockCard.QtyLast * lastPrice;

                stockCardDetail.QtyLast = stockCard.QtyLast;
                stockCardDetail.QtyLastPrice = stockCard.QtyLastPrice;

                _sparepartStockCardRepository.AttachNavigation(stockCard.CreateUser);
                _sparepartStockCardRepository.AttachNavigation(stockCard.Sparepart);
                _sparepartStockCardRepository.AttachNavigation(stockCard.ReferenceTable);
                stockCard = _sparepartStockCardRepository.Add(stockCard);

                stockCardDetail.ParentStockCard = stockCard;
                _sparepartStockCardDetailRepository.AttachNavigation(stockCardDetail.ParentStockCard);
                _sparepartStockCardDetailRepository.Add(stockCardDetail);

                _unitOfWork.SaveChanges();

                SparepartStockCard revStockCard = new SparepartStockCard();
                revStockCard.CreateUserId = userId;
                revStockCard.PurchaseDate = serverTime;
                revStockCard.ReferenceTableId = transactionReferenceTable.Id;
                revStockCard.PrimaryKeyValue = manualTransactionOld.Id;
                revStockCard.SparepartId = sparepartManualTransaction.SparepartId;

                SparepartStockCardDetail revStockCardDetail = new SparepartStockCardDetail();
                revStockCardDetail.SparepartManualTransactionId = sparepartManualTransaction.Id;

                lastStockCard = _sparepartStockCardRepository.RetrieveLastCard(sparepartManualTransaction.SparepartId);
                lastStock = 0;
                lastPrice = 0;
                if (lastStockCard != null)
                {
                    lastStock = lastStockCard.QtyLast;
                    lastPrice = lastStockCard.PricePerItem;
                }

                revStockCard.QtyFirst = lastStock;
                revStockCard.QtyFirstPrice = revStockCard.QtyFirst * lastPrice;

                revStockCardDetail.QtyFirst = revStockCard.QtyFirst;
                revStockCardDetail.QtyFirstPrice = revStockCard.QtyFirstPrice;

                if (updateTypeNew.Code == DbConstant.REF_SPAREPART_TRANSACTION_MANUAL_TYPE_PLUS)
                {
                    revStockCard.Description = "Revisi penambahan stok awal";
                    revStockCard.QtyIn = sparepartManualTransaction.Qty;
                    revStockCard.QtyInPrice = revStockCard.QtyIn * lastPrice;

                    revStockCardDetail.QtyIn = revStockCard.QtyIn;
                    revStockCardDetail.QtyInPrice = revStockCard.QtyInPrice;

                    sparepartUpdated.StockQty += sparepartManualTransaction.Qty;
                }
                else if (updateTypeNew.Code == DbConstant.REF_SPAREPART_TRANSACTION_MANUAL_TYPE_MINUS)
                {
                    revStockCard.Description = "Revisi pengurangan stok awal";
                    revStockCard.QtyOut = sparepartManualTransaction.Qty;
                    revStockCard.QtyOutPrice = revStockCard.QtyOut * lastPrice;

                    revStockCardDetail.QtyOut = revStockCard.QtyOut;
                    revStockCardDetail.QtyOutPrice = revStockCard.QtyOutPrice;

                    sparepartUpdated.StockQty -= sparepartManualTransaction.Qty;
                }

                revStockCard.QtyLast = revStockCard.QtyFirst + (revStockCard.QtyIn - revStockCard.QtyOut);
                revStockCard.QtyLastPrice = revStockCard.QtyLast * lastPrice;

                revStockCardDetail.QtyLast = revStockCard.QtyLast;
                revStockCardDetail.QtyLastPrice = revStockCard.QtyLastPrice;

                _sparepartStockCardRepository.AttachNavigation(revStockCard.CreateUser);
                _sparepartStockCardRepository.AttachNavigation(revStockCard.Sparepart);
                _sparepartStockCardRepository.AttachNavigation(revStockCard.ReferenceTable);
                revStockCard = _sparepartStockCardRepository.Add(revStockCard);

                revStockCardDetail.ParentStockCard = revStockCard;
                _sparepartStockCardDetailRepository.AttachNavigation(revStockCardDetail.ParentStockCard);
                _sparepartStockCardDetailRepository.Add(revStockCardDetail);

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
