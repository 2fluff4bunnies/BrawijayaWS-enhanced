using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Database.Repositories;
using BrawijayaWorkshop.Infrastructure.Repository;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System.Collections.Generic;
using System.Linq;
using BrawijayaWorkshop.Utils;
using System;

namespace BrawijayaWorkshop.Model
{
    public class DebtEditorModel : AppBaseModel
    {
        private ITransactionRepository _transactionRepository;
        private IPurchasingRepository _purchasingRepository;
        private IJournalMasterRepository _journalMasterRepository;
        private ITransactionDetailRepository _transactionDetailRepository;
        private IReferenceRepository _referenceRepository;
        private IUnitOfWork _unitOfWork;

        public DebtEditorModel(ITransactionRepository transactionRepository,
            IPurchasingRepository purchasingRepository,
            IJournalMasterRepository journalMasterRepository,
             ITransactionDetailRepository transactionDetailRepository,
            IReferenceRepository referenceRepository,
            IUnitOfWork unitOfWork)
            : base()
        {
            _transactionRepository = transactionRepository;
            _purchasingRepository = purchasingRepository;
            _journalMasterRepository = journalMasterRepository;
            _transactionDetailRepository = transactionDetailRepository;
            _referenceRepository = referenceRepository;
            _unitOfWork = unitOfWork;
        }

        public List<ReferenceViewModel> RetrievePaymentMethod()
        {
            Reference parent = _referenceRepository
                .GetMany(c => c.Code == DbConstant.REF_DEBT_PAYMENTMETHOD).FirstOrDefault();
            List<Reference> list = new List<Reference>();
            if (parent != null)
            {
                list = _referenceRepository.GetMany(c => c.ParentId == parent.Id).ToList();
            }
            List<ReferenceViewModel> mappedResult = new List<ReferenceViewModel>();
            return Map(list, mappedResult);
        }

        public PurchasingViewModel GetSelectedPurchasingByTransaction(int purchasingID)
        {
            Purchasing purchasing = _purchasingRepository
                .GetById(purchasingID);
            PurchasingViewModel mappedResult = new PurchasingViewModel();
            return Map(purchasing, mappedResult);
        }

        public void InsertDebt(TransactionViewModel transaction, decimal purchasingPrice, int userID)
        {
            DateTime serverTime = DateTime.Now;
            Reference transactionReferenceTable = _referenceRepository.GetMany(c => c.Code == DbConstant.REF_TRANSTBL_PURCHASING).FirstOrDefault();
            transaction.CreateDate = serverTime;
            transaction.ModifyDate = serverTime;
            transaction.CreateUserId = userID;
            transaction.ModifyUserId = userID;
            transaction.TransactionDate = serverTime;
            transaction.TotalTransaction = purchasingPrice.AsDouble();
            transaction.ReferenceTableId = transactionReferenceTable.Id;
            transaction.Status = (int)DbConstant.DefaultDataStatus.Active;
            transaction.Description = "Pembayaran hutang";

            Transaction entity = new Transaction();
            Map(transaction, entity);
            Transaction transactionInserted = _transactionRepository.Add(entity);

            Purchasing purchasingEntity = _purchasingRepository.GetById(transaction.PrimaryKeyValue);
            purchasingEntity.TotalHasPaid += transaction.TotalPayment.AsDecimal();
            if (purchasingEntity.TotalHasPaid == purchasingEntity.TotalPrice)
            {
                purchasingEntity.PaymentStatus = (int)DbConstant.PaymentStatus.Settled;
            }
            _purchasingRepository.Update(purchasingEntity);

            Reference paymentMethod = _referenceRepository.GetById(transaction.PaymentMethodId);

            switch (paymentMethod.Code)
            {
                case DbConstant.REF_DEBT_PAYMENTMETHOD_BANK_EKONOMI:
                case DbConstant.REF_DEBT_PAYMENTMETHOD_BANK_BCA1:
                case DbConstant.REF_DEBT_PAYMENTMETHOD_BANK_BCA2:
                    {
                        // Bank Kredit --> Karena berkurang
                        TransactionDetail detailBank = new TransactionDetail();
                        detailBank.Credit = transaction.TotalPayment.AsDecimal();
                        if (paymentMethod.Code == DbConstant.REF_DEBT_PAYMENTMETHOD_BANK_EKONOMI)
                        {
                            detailBank.JournalId = _journalMasterRepository.GetMany(j => j.Code == "1.01.02.01").FirstOrDefault().Id;
                        }
                        else if (paymentMethod.Code == DbConstant.REF_DEBT_PAYMENTMETHOD_BANK_BCA1)
                        {
                            detailBank.JournalId = _journalMasterRepository.GetMany(j => j.Code == "1.01.02.02").FirstOrDefault().Id;
                        }
                        else if (paymentMethod.Code == DbConstant.REF_DEBT_PAYMENTMETHOD_BANK_BCA2)
                        {
                            detailBank.JournalId = _journalMasterRepository.GetMany(j => j.Code == "1.01.02.03").FirstOrDefault().Id;
                        }
                        detailBank.Parent = transactionInserted;
                        _transactionDetailRepository.Add(detailBank);
                        break;
                    }

                case DbConstant.REF_DEBT_PAYMENTMETHOD_KAS:
                    // Kas Kredit --> Karena berkurang
                    TransactionDetail detailKas = new TransactionDetail();
                    detailKas.Credit = transaction.TotalPayment.AsDecimal();
                    detailKas.JournalId = _journalMasterRepository.GetMany(j => j.Code == "1.01.01.01").FirstOrDefault().Id;
                    detailKas.Parent = transactionInserted;
                    _transactionDetailRepository.Add(detailKas);
                    break;
            }

            TransactionDetail detailDebt = new TransactionDetail();
            detailDebt.Debit = transaction.TotalPayment.AsDecimal();
            detailDebt.JournalId = _journalMasterRepository.GetMany(j => j.Code == "2.01.01.01").FirstOrDefault().Id;
            detailDebt.Parent = transactionInserted;
            _transactionDetailRepository.Add(detailDebt);
            _unitOfWork.SaveChanges();
        }

        public void UpdateDebt(TransactionViewModel transaction, int userID)
        {
            DateTime serverTime = DateTime.Now;

            transaction.ModifyDate = serverTime;
            transaction.CreateUserId = userID;

            Transaction transactionUpdated = _transactionRepository.GetById<int>(transaction.Id);
            Transaction transactionOld = transactionUpdated;
            
            Purchasing purchasingEntity = _purchasingRepository.GetById(transaction.PrimaryKeyValue);
            NeutralizePurchasing(ref purchasingEntity, transactionOld);

            purchasingEntity.TotalHasPaid += transaction.TotalPayment.AsDecimal();
            if (purchasingEntity.TotalHasPaid == purchasingEntity.TotalPrice)
            {
                purchasingEntity.PaymentStatus = (int)DbConstant.PaymentStatus.Settled;
            }
            _purchasingRepository.Update(purchasingEntity);

            Map(transaction, transactionUpdated);
            _transactionRepository.Update(transactionUpdated);

            Reference paymentMethod = _referenceRepository.GetById(transaction.PaymentMethodId);
            
            TransactionDetail debitDetail = _transactionDetailRepository.GetMany(x=>x.ParentId == transaction.Id && x.Credit == null).FirstOrDefault();
            TransactionDetail creditDetail = _transactionDetailRepository.GetMany(x => x.ParentId == transaction.Id && x.Debit == null).FirstOrDefault();
                        
            switch (paymentMethod.Code)
            {
                case DbConstant.REF_DEBT_PAYMENTMETHOD_BANK_EKONOMI:
                case DbConstant.REF_DEBT_PAYMENTMETHOD_BANK_BCA1:
                case DbConstant.REF_DEBT_PAYMENTMETHOD_BANK_BCA2:
                    {
                        // Bank Kredit --> Karena berkurang
                        creditDetail.Credit = transaction.TotalPayment.AsDecimal();
                        if (paymentMethod.Code == DbConstant.REF_DEBT_PAYMENTMETHOD_BANK_EKONOMI)
                        {
                            creditDetail.JournalId = _journalMasterRepository.GetMany(j => j.Code == "1.01.02.01").FirstOrDefault().Id;
                        }
                        else if (paymentMethod.Code == DbConstant.REF_DEBT_PAYMENTMETHOD_BANK_BCA1)
                        {
                            creditDetail.JournalId = _journalMasterRepository.GetMany(j => j.Code == "1.01.02.02").FirstOrDefault().Id;
                        }
                        else if (paymentMethod.Code == DbConstant.REF_DEBT_PAYMENTMETHOD_BANK_BCA2)
                        {
                            creditDetail.JournalId = _journalMasterRepository.GetMany(j => j.Code == "1.01.02.03").FirstOrDefault().Id;
                        }
                        _transactionDetailRepository.Update(creditDetail);
                        break;
                    }

                case DbConstant.REF_DEBT_PAYMENTMETHOD_KAS:
                    // Kas Kredit --> Karena berkurang
                    creditDetail.Credit = transaction.TotalPayment.AsDecimal();
                    creditDetail.JournalId = _journalMasterRepository.GetMany(j => j.Code == "1.01.01.01").FirstOrDefault().Id;
                    _transactionDetailRepository.Update(creditDetail);
                    break;
            }

            debitDetail.Debit = transaction.TotalPayment.AsDecimal();
            debitDetail.JournalId = _journalMasterRepository.GetMany(j => j.Code == "2.01.01.01").FirstOrDefault().Id;
            _transactionDetailRepository.Update(debitDetail);
            _unitOfWork.SaveChanges();
        }

        public void NeutralizePurchasing(ref Purchasing purchasing, Transaction oldTransaction)
        {
            purchasing.TotalHasPaid -= oldTransaction.TotalPayment.AsDecimal();
            if (purchasing.TotalHasPaid != purchasing.TotalPrice)
            {
                purchasing.PaymentStatus = (int)DbConstant.PaymentStatus.NotSettled;
            }
        }
    }
}
