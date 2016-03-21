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
                .GetMany(c => c.Code == DbConstant.REF_PURCHASE_PAYMENTMETHOD).FirstOrDefault();
            List<Reference> list = new List<Reference>();
            if (parent != null)
            {
                list = _referenceRepository.GetMany(c => c.ParentId == parent.Id).ToList();
            }
            List<ReferenceViewModel> mappedResult = new List<ReferenceViewModel>();
            return Map(list, mappedResult);
        }

        public void InsertDebt(TransactionViewModel transaction, PurchasingViewModel purchasing,int userID)
        {
            DateTime serverTime = DateTime.Now;
            Reference transactionReferenceTable = _referenceRepository.GetMany(c => c.Code == DbConstant.REF_TRANSTBL_PURCHASING).FirstOrDefault();
            transaction.CreateDate = serverTime;
            transaction.ModifyDate = serverTime;
            transaction.CreateUserId = userID;
            transaction.ModifyUserId = userID;
            transaction.TransactionDate = serverTime;
            transaction.TotalTransaction = purchasing.TotalPrice.AsDouble();
            transaction.ReferenceTableId = transactionReferenceTable.Id;

            Transaction entity = new Transaction();
            Map(transaction, entity);
            Transaction transactionInserted = _transactionRepository.Add(entity);
            Purchasing purchasingEntity = _purchasingRepository.GetById(transaction.PrimaryKeyValue);
            purchasingEntity.TotalHasPaid += transaction.TotalPayment.AsDecimal();
            if(purchasingEntity.TotalHasPaid == purchasingEntity.TotalPrice)
            {
                purchasingEntity.PaymentStatus = (int)DbConstant.PaymentStatus.Settled;
            }
            _purchasingRepository.Update(purchasingEntity);

            switch (purchasing.PaymentMethod.Code)
            {
                case DbConstant.REF_PURCHASE_PAYMENTMETHOD_BANK_EKONOMI:
                case DbConstant.REF_PURCHASE_PAYMENTMETHOD_BANK_BCA1:
                case DbConstant.REF_PURCHASE_PAYMENTMETHOD_BANK_BCA2:
                    {
                        // Bank Kredit --> Karena berkurang
                        TransactionDetail detailBank = new TransactionDetail();
                        detailBank.Credit = purchasing.TotalHasPaid;
                        if (purchasing.PaymentMethod.Code == DbConstant.REF_PURCHASE_PAYMENTMETHOD_BANK_EKONOMI)
                        {
                            detailBank.JournalId = _journalMasterRepository.GetMany(j => j.Code == "1.01.02.01").FirstOrDefault().Id;
                        }
                        else if (purchasing.PaymentMethod.Code == DbConstant.REF_PURCHASE_PAYMENTMETHOD_BANK_BCA1)
                        {
                            detailBank.JournalId = _journalMasterRepository.GetMany(j => j.Code == "1.01.02.02").FirstOrDefault().Id;
                        }
                        else if (purchasing.PaymentMethod.Code == DbConstant.REF_PURCHASE_PAYMENTMETHOD_BANK_BCA2)
                        {
                            detailBank.JournalId = _journalMasterRepository.GetMany(j => j.Code == "1.01.02.03").FirstOrDefault().Id;
                        }
                        detailBank.Parent = transactionInserted;
                        _transactionDetailRepository.Add(detailBank);
                        break;
                    }

                case DbConstant.REF_PURCHASE_PAYMENTMETHOD_KAS:
                    // Kas Kredit --> Karena berkurang
                    TransactionDetail detailKas = new TransactionDetail();
                    detailKas.Credit = purchasing.TotalHasPaid;
                    detailKas.JournalId = _journalMasterRepository.GetMany(j => j.Code == "1.01.01.01").FirstOrDefault().Id;
                    detailKas.Parent = transactionInserted;
                    _transactionDetailRepository.Add(detailKas);
                    break;

                case DbConstant.REF_PURCHASE_PAYMENTMETHOD_UANGMUKA_KAS:
                    // Kas Kredit --> Karena berkurang
                    TransactionDetail detailKasKarenaUangMuka = new TransactionDetail();
                    detailKasKarenaUangMuka.Credit = purchasing.TotalHasPaid;
                    detailKasKarenaUangMuka.JournalId = _journalMasterRepository.GetMany(j => j.Code == "1.01.01.01").FirstOrDefault().Id;
                    detailKasKarenaUangMuka.Parent = transactionInserted;
                    _transactionDetailRepository.Add(detailKasKarenaUangMuka);

                    // Uang Muka Debit --> Karena bertambah
                    TransactionDetail detailUangMukaBertambahKarenaKas = new TransactionDetail();
                    detailUangMukaBertambahKarenaKas.Debit = purchasing.TotalHasPaid;
                    detailUangMukaBertambahKarenaKas.JournalId = _journalMasterRepository.GetMany(j => j.Code == "1.01.05.01.01").FirstOrDefault().Id;
                    detailUangMukaBertambahKarenaKas.Parent = transactionInserted;
                    _transactionDetailRepository.Add(detailUangMukaBertambahKarenaKas);
                    break;

                case DbConstant.REF_PURCHASE_PAYMENTMETHOD_UANGMUKA_BANK_EKONOMI:
                case DbConstant.REF_PURCHASE_PAYMENTMETHOD_UANGMUKA_BANK_BCA1:
                case DbConstant.REF_PURCHASE_PAYMENTMETHOD_UANGMUKA_BANK_BCA2:
                    {
                        // Bank Kredit --> Karena berkurang
                        TransactionDetail detailBankKarenaUangMuka = new TransactionDetail();
                        detailBankKarenaUangMuka.Credit = purchasing.TotalHasPaid;
                        if (purchasing.PaymentMethod.Code == DbConstant.REF_PURCHASE_PAYMENTMETHOD_UANGMUKA_BANK_EKONOMI)
                        {
                            detailBankKarenaUangMuka.JournalId = _journalMasterRepository.GetMany(j => j.Code == "1.01.02.01").FirstOrDefault().Id;
                        }
                        else if (purchasing.PaymentMethod.Code == DbConstant.REF_PURCHASE_PAYMENTMETHOD_UANGMUKA_BANK_BCA1)
                        {
                            detailBankKarenaUangMuka.JournalId = _journalMasterRepository.GetMany(j => j.Code == "1.01.02.02").FirstOrDefault().Id;
                        }
                        else if (purchasing.PaymentMethod.Code == DbConstant.REF_PURCHASE_PAYMENTMETHOD_UANGMUKA_BANK_BCA2)
                        {
                            detailBankKarenaUangMuka.JournalId = _journalMasterRepository.GetMany(j => j.Code == "1.01.02.03").FirstOrDefault().Id;
                        }
                        detailBankKarenaUangMuka.Parent = transactionInserted;
                        _transactionDetailRepository.Add(detailBankKarenaUangMuka);

                        // Uang Muka Debit --> Karena bertambah
                        TransactionDetail detailUangMukaBertambahKarenaBank = new TransactionDetail();
                        detailUangMukaBertambahKarenaBank.Debit = purchasing.TotalHasPaid;
                        detailUangMukaBertambahKarenaBank.JournalId = _journalMasterRepository.GetMany(j => j.Code == "1.01.05.01.01").FirstOrDefault().Id;
                        detailUangMukaBertambahKarenaBank.Parent = transactionInserted;
                        _transactionDetailRepository.Add(detailUangMukaBertambahKarenaBank);
                        break;
                    }

                case DbConstant.REF_PURCHASE_PAYMENTMETHOD_UTANG:
                    TransactionDetail utang = new TransactionDetail();
                    utang.Credit = purchasing.TotalPrice - purchasing.TotalPrice;
                    utang.JournalId = _journalMasterRepository.GetMany(j => j.Code == "2.01.01.01").FirstOrDefault().Id;
                    utang.Parent = transactionInserted;
                    _transactionDetailRepository.Add(utang);
                    break;
            }
            _unitOfWork.SaveChanges();
        }

        public void UpdateDebt(TransactionViewModel transaction)
        {
            Transaction entity = _transactionRepository.GetById<int>(transaction.Id);
            Map(transaction, entity);
            _transactionRepository.Update(entity);
            _unitOfWork.SaveChanges();
        }
    }
}
