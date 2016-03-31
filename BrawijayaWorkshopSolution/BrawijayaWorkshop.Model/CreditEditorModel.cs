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
    public class CreditEditorModel : AppBaseModel
    {
        private ITransactionRepository _transactionRepository;
        private IInvoiceRepository _invoiceRepository;
        private IJournalMasterRepository _journalMasterRepository;
        private ITransactionDetailRepository _transactionDetailRepository;
        private IReferenceRepository _referenceRepository;
        private IUnitOfWork _unitOfWork;

        public CreditEditorModel(ITransactionRepository transactionRepository,
            IInvoiceRepository invoiceRepository,
            IJournalMasterRepository journalMasterRepository,
             ITransactionDetailRepository transactionDetailRepository,
            IReferenceRepository referenceRepository,
            IUnitOfWork unitOfWork)
            : base()
        {
            _transactionRepository = transactionRepository;
            _invoiceRepository = invoiceRepository;
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

        public InvoiceViewModel GetSelectedInvoiceByTransaction(int InvoiceID)
        {
            Invoice Invoice = _invoiceRepository
                .GetById(InvoiceID);
            InvoiceViewModel mappedResult = new InvoiceViewModel();
            return Map(Invoice, mappedResult);
        }

        public void InsertCredit(TransactionViewModel transaction, decimal InvoicePrice, int userID)
        {
            DateTime serverTime = DateTime.Now;
            Reference transactionReferenceTable = _referenceRepository.GetMany(c => c.Code == DbConstant.REF_TRANSTBL_INVOICE).FirstOrDefault();
            transaction.CreateDate = serverTime;
            transaction.ModifyDate = serverTime;
            transaction.CreateUserId = userID;
            transaction.ModifyUserId = userID;
            transaction.TransactionDate = serverTime;
            transaction.TotalTransaction = InvoicePrice.AsDouble();
            transaction.ReferenceTableId = transactionReferenceTable.Id;
            transaction.Status = (int)DbConstant.DefaultDataStatus.Active;
            transaction.Description = "Pembayaran piutang";

            Transaction entity = new Transaction();
            Map(transaction, entity);
            Transaction transactionInserted = _transactionRepository.Add(entity);

            Invoice invoiceEntity = _invoiceRepository.GetById(transaction.PrimaryKeyValue);
            invoiceEntity.TotalHasPaid += transaction.TotalPayment.AsDecimal();
            if (invoiceEntity.TotalHasPaid == invoiceEntity.TotalPrice)
            {
                invoiceEntity.PaymentStatus = (int)DbConstant.PaymentStatus.Settled;
            }
            _invoiceRepository.Update(invoiceEntity);

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

            TransactionDetail detailCredit = new TransactionDetail();
            detailCredit.Debit = transaction.TotalPayment.AsDecimal();
            detailCredit.JournalId = _journalMasterRepository.GetMany(j => j.Code == "2.01.01.01").FirstOrDefault().Id;
            detailCredit.Parent = transactionInserted;
            _transactionDetailRepository.Add(detailCredit);
            _unitOfWork.SaveChanges();
        }

        public void UpdateCredit(TransactionViewModel transaction, int userID)
        {
            DateTime serverTime = DateTime.Now;

            transaction.ModifyDate = serverTime;
            transaction.CreateUserId = userID;

            Transaction transactionUpdated = _transactionRepository.GetById<int>(transaction.Id);
            Transaction transactionOld = transactionUpdated;

            Invoice invoiceEntity = _invoiceRepository.GetById(transaction.PrimaryKeyValue);
            NeutralizeInvoice(ref invoiceEntity, transactionOld);

            invoiceEntity.TotalHasPaid += transaction.TotalPayment.AsDecimal();
            if (invoiceEntity.TotalHasPaid == invoiceEntity.TotalPrice)
            {
                invoiceEntity.PaymentStatus = (int)DbConstant.PaymentStatus.Settled;
            }
            _invoiceRepository.Update(invoiceEntity);

            Map(transaction, transactionUpdated);
            _transactionRepository.Update(transactionUpdated);

            Reference paymentMethod = _referenceRepository.GetById(transaction.PaymentMethodId);

            TransactionDetail debitDetail = _transactionDetailRepository.GetMany(x => x.ParentId == transaction.Id && x.Credit == null).FirstOrDefault();
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

        public void NeutralizeInvoice(ref Invoice invoice, Transaction oldTransaction)
        {
            invoice.TotalHasPaid -= oldTransaction.TotalPayment.AsDecimal();
            if (invoice.TotalHasPaid != invoice.TotalPrice)
            {
                invoice.PaymentStatus = (int)DbConstant.PaymentStatus.NotSettled;
            }
        }
    }
}
