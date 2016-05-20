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
    public class InvoiceEditorModel : AppBaseModel
    {
        private IInvoiceRepository _invoiceRepository;
        private IInvoiceDetailRepository _invoiceDetailRepository;
        private IReferenceRepository _referenceRepository;
        private ITransactionRepository _transactionRepository;
        private ITransactionDetailRepository _transactionDetailRepository;
        private IJournalMasterRepository _journalMasterRepository;
        private IUnitOfWork _unitOfWork;

        public InvoiceEditorModel(IInvoiceRepository invoiceRepository,
            IInvoiceDetailRepository invoiceDetailRepository,
            IReferenceRepository referenceRepository,
            ITransactionRepository transactionRepository,
            ITransactionDetailRepository transactionDetailRepository,
            IJournalMasterRepository journalMasterRepository,
            IUnitOfWork unitOfWork)
            : base()
        {
            _invoiceRepository = invoiceRepository;
            _invoiceDetailRepository = invoiceDetailRepository;
            _transactionRepository = transactionRepository;
            _transactionDetailRepository = transactionDetailRepository;
            _journalMasterRepository = journalMasterRepository;
            _referenceRepository = referenceRepository;
            _unitOfWork = unitOfWork;
        }

        public List<ReferenceViewModel> RetrievePaymentMethod()
        {
            Reference parent = _referenceRepository
                .GetMany(c => c.Code == DbConstant.REF_INVOICE_PAYMENTMETHOD).FirstOrDefault();
            List<Reference> list = new List<Reference>();
            if (parent != null)
            {
                list = _referenceRepository.GetMany(c => c.ParentId == parent.Id).ToList();
            }
            List<ReferenceViewModel> mappedResult = new List<ReferenceViewModel>();
            return Map(list, mappedResult);
        }

        public List<InvoiceDetailViewModel> RetrieveInvoiceDetail(int invoiceID)
        {
            List<InvoiceDetail> result = _invoiceDetailRepository.GetMany(x => x.InvoiceId == invoiceID).ToList();
            List<InvoiceDetailViewModel> mappedResult = new List<InvoiceDetailViewModel>();
            Map(result, mappedResult);
            foreach (var itemMappedResult in mappedResult)
            {
                if (itemMappedResult.FeePctg == null)
                {
                    itemMappedResult.FeePctg = 0;
                }
            }
            return mappedResult;
        }

        public void UpdateInvoice(InvoiceViewModel invoice, List<InvoiceDetailViewModel> invoiceDetails, int userId)
        {
            using(var trans = _unitOfWork.BeginTransaction())
            {
                try 
	            {	        
		            DateTime serverTime = DateTime.Now;

                    Invoice entity = _invoiceRepository.GetById<int>(invoice.Id);
                    entity.PaymentMethodId = invoice.PaymentMethodId;
                    entity.TotalHasPaid = invoice.TotalHasPaid;
                    entity.TotalPrice = invoice.TotalPrice;

                    entity.TotalService = invoice.TotalService;
                    entity.TotalFeeService = invoice.TotalFeeService;                    
                    entity.TotalServicePlusFee = invoice.TotalServicePlusFee;
                    entity.TotalSparepart = invoice.TotalSparepart;
                    entity.TotalFeeSparepart = invoice.TotalFeeSparepart;
                    entity.TotalSparepartPlusFee = invoice.TotalSparepartPlusFee;
                    entity.TotalSparepartAndService = invoice.TotalSparepartAndService;
                    entity.TotalValueAdded = invoice.TotalValueAdded;

                    //Map(invoice, entity);
                    entity.ModifyDate = serverTime;
                    entity.ModifyUserId = userId;
                    entity.Status = (int)DbConstant.InvoiceStatus.NotPrinted;

                    if (entity.TotalHasPaid == entity.TotalPrice)
                    {
                        entity.PaymentStatus = (int)DbConstant.PaymentStatus.Settled;
                    }
                    else
                    {
                        entity.PaymentStatus = (int)DbConstant.PaymentStatus.NotSettled;
                    }

                    _invoiceRepository.AttachNavigation(entity.CreateUser); // yang inherit ke base modifier harus ada ini, klo gak user e dobel2
                    _invoiceRepository.AttachNavigation(entity.ModifyUser); // yang inherit ke base modifier harus ada ini, klo gak user e dobel2
                    _invoiceRepository.AttachNavigation(entity.SPK);
                    _invoiceRepository.AttachNavigation(entity.PaymentMethod);

                    _invoiceRepository.Update(entity);
                    _unitOfWork.SaveChanges();

                    foreach (var invoiceDetail in invoiceDetails)
                    {
                        InvoiceDetail entityDetail = _invoiceDetailRepository.GetById<int>(invoiceDetail.Id);
                        entityDetail.FeePctg = invoiceDetail.FeePctg;
                        entityDetail.SubTotalPrice = invoiceDetail.SubTotalPrice;
                        //Map(invoiceDetail, entityDetail);

                        entityDetail.ModifyDate = serverTime;
                        entityDetail.ModifyUserId = userId;

                        _invoiceDetailRepository.AttachNavigation(entityDetail.CreateUser);
                        _invoiceDetailRepository.AttachNavigation(entityDetail.ModifyUser);
                        _invoiceDetailRepository.AttachNavigation(entityDetail.Invoice);
                        _invoiceDetailRepository.AttachNavigation(entityDetail.SPKDetailSparepartDetail);
                        _invoiceDetailRepository.Update(entityDetail);
                    }
                    _unitOfWork.SaveChanges();

                    Reference transactionReferenceTable = _referenceRepository.GetMany(c => c.Code == DbConstant.REF_TRANSTBL_INVOICE).FirstOrDefault();
                    Transaction transaction = _transactionRepository.GetMany(x =>x.ReferenceTableId == transactionReferenceTable.Id &&
                        x.PrimaryKeyValue == invoice.Id).OrderBy(x => x.CreateDate).FirstOrDefault();
                    Reference paymentMethod = _referenceRepository.GetById(invoice.PaymentMethodId);
                
                    if (transaction != null)
                    {
                        transaction.ModifyDate = serverTime;
                        transaction.ModifyUserId = userId;
                        transaction.TotalTransaction = invoice.TotalPrice.AsDouble();
                        transaction.TotalPayment = invoice.TotalHasPaid.AsDouble();
                        transaction.PaymentMethodId = invoice.PaymentMethodId;
                        _transactionRepository.AttachNavigation(transaction.CreateUser);
                        _transactionRepository.AttachNavigation(transaction.ModifyUser);
                        _transactionRepository.AttachNavigation(transaction.ReferenceTable);
                        _transactionRepository.AttachNavigation(transaction.PaymentMethod);
                        _transactionRepository.Update(transaction);
                        _unitOfWork.SaveChanges();

                        List<TransactionDetail> transactionDetails = _transactionDetailRepository.GetMany(x => x.ParentId == transaction.Id).ToList();
                        foreach (TransactionDetail transactionDetail in transactionDetails)
                        {
                            _transactionDetailRepository.Delete(transactionDetail);
                        }
                        _unitOfWork.SaveChanges();
                    }
                    else
                    {
                        transaction = new Transaction();
                        transaction.CreateDate = serverTime;
                        transaction.CreateUserId = userId;
                        transaction.ModifyDate = serverTime;
                        transaction.ModifyUserId = userId;
                        transaction.Description = "pembayaran invoice";
                        transaction.TotalTransaction = invoice.TotalPrice.AsDouble();
                        transaction.TotalPayment = invoice.TotalHasPaid.AsDouble();
                        transaction.ReferenceTableId = transactionReferenceTable.Id;
                        transaction.PrimaryKeyValue = invoice.Id;
                        transaction.TransactionDate = serverTime;
                        transaction.PaymentMethodId = invoice.PaymentMethodId;
                        transaction.Status = (int)DbConstant.DefaultDataStatus.Active;

                        _transactionRepository.AttachNavigation(transaction.CreateUser);
                        _transactionRepository.AttachNavigation(transaction.ModifyUser);
                        _transactionRepository.AttachNavigation(transaction.ReferenceTable);
                        _transactionRepository.AttachNavigation(transaction.PaymentMethod);
                        transaction = _transactionRepository.Add(transaction);
                        _unitOfWork.SaveChanges();
                    }

                    switch (paymentMethod.Code)
                    {
                        case DbConstant.REF_INVOICE_PAYMENTMETHOD_BANK_EKONOMI:
                        case DbConstant.REF_INVOICE_PAYMENTMETHOD_BANK_BCA1:
                        case DbConstant.REF_INVOICE_PAYMENTMETHOD_BANK_BCA2:
                            {
                                // Bank Debet --> Karena bertmbah
                                TransactionDetail detailBank = new TransactionDetail();
                                detailBank.Debit = invoice.TotalHasPaid;
                                if (paymentMethod.Code == DbConstant.REF_INVOICE_PAYMENTMETHOD_BANK_EKONOMI)
                                {
                                    detailBank.JournalId = _journalMasterRepository.GetMany(j => j.Code == "1.01.02.01").FirstOrDefault().Id;
                                }
                                else if (paymentMethod.Code == DbConstant.REF_INVOICE_PAYMENTMETHOD_BANK_BCA1)
                                {
                                    detailBank.JournalId = _journalMasterRepository.GetMany(j => j.Code == "1.01.02.02").FirstOrDefault().Id;
                                }
                                else if (paymentMethod.Code == DbConstant.REF_INVOICE_PAYMENTMETHOD_BANK_BCA2)
                                {
                                    detailBank.JournalId = _journalMasterRepository.GetMany(j => j.Code == "1.01.02.03").FirstOrDefault().Id;
                                }
                                detailBank.ParentId = transaction.Id;

                                _transactionDetailRepository.AttachNavigation(detailBank.Journal);
                                _transactionDetailRepository.AttachNavigation(detailBank.Parent);
                                _transactionDetailRepository.Add(detailBank);
                                break;
                            }

                        case DbConstant.REF_INVOICE_PAYMENTMETHOD_KAS:
                            // Kas Debit --> Karena bertambah
                            TransactionDetail detailKas = new TransactionDetail();
                            detailKas.Debit = invoice.TotalHasPaid;
                            detailKas.JournalId = _journalMasterRepository.GetMany(j => j.Code == "1.01.01.01").FirstOrDefault().Id;
                            detailKas.ParentId = transaction.Id;

                            _transactionDetailRepository.AttachNavigation(detailKas.Journal);
                            _transactionDetailRepository.AttachNavigation(detailKas.Parent);
                            _transactionDetailRepository.Add(detailKas);
                            break;

                        case DbConstant.REF_INVOICE_PAYMENTMETHOD_UANGMUKA_KAS:
                            // Kas Debit --> Karena bertambah
                            TransactionDetail detailKasKarenaUangMuka = new TransactionDetail();
                            detailKasKarenaUangMuka.Debit = invoice.TotalHasPaid;
                            detailKasKarenaUangMuka.JournalId = _journalMasterRepository.GetMany(j => j.Code == "1.01.01.01").FirstOrDefault().Id;
                            detailKasKarenaUangMuka.ParentId = transaction.Id;
                    
                            _transactionDetailRepository.AttachNavigation(detailKasKarenaUangMuka.Journal);
                            _transactionDetailRepository.AttachNavigation(detailKasKarenaUangMuka.Parent);
                            _transactionDetailRepository.Add(detailKasKarenaUangMuka);

                            // Uang Muka Debit --> Karena bertambah
                            TransactionDetail detailUangMukaBertambahKarenaKas = new TransactionDetail();
                            detailUangMukaBertambahKarenaKas.Debit = invoice.TotalHasPaid;
                            detailUangMukaBertambahKarenaKas.JournalId = _journalMasterRepository.GetMany(j => j.Code == "1.01.05.01.01").FirstOrDefault().Id;
                            detailUangMukaBertambahKarenaKas.ParentId = transaction.Id;

                            _transactionDetailRepository.AttachNavigation(detailUangMukaBertambahKarenaKas.Journal);
                            _transactionDetailRepository.AttachNavigation(detailUangMukaBertambahKarenaKas.Parent);
                            _transactionDetailRepository.Add(detailUangMukaBertambahKarenaKas);

                            // Uang Muka Kredit --> Karena berkurang
                            TransactionDetail detailUangMukaBerkurangKarenaKas = new TransactionDetail();
                            detailUangMukaBerkurangKarenaKas.Credit = invoice.TotalHasPaid;
                            detailUangMukaBerkurangKarenaKas.JournalId = _journalMasterRepository.GetMany(j => j.Code == "1.01.05.01.01").FirstOrDefault().Id;
                            detailUangMukaBerkurangKarenaKas.ParentId = transaction.Id;
                    
                            _transactionDetailRepository.AttachNavigation(detailUangMukaBerkurangKarenaKas.Journal);
                            _transactionDetailRepository.AttachNavigation(detailUangMukaBerkurangKarenaKas.Parent);
                            _transactionDetailRepository.Add(detailUangMukaBerkurangKarenaKas);
                            break;

                        case DbConstant.REF_INVOICE_PAYMENTMETHOD_UANGMUKA_BANK_EKONOMI:
                        case DbConstant.REF_INVOICE_PAYMENTMETHOD_UANGMUKA_BANK_BCA1:
                        case DbConstant.REF_INVOICE_PAYMENTMETHOD_UANGMUKA_BANK_BCA2:
                            {
                                // Bank Debit --> Karena bertambah
                                TransactionDetail detailBankKarenaUangMuka = new TransactionDetail();
                                detailBankKarenaUangMuka.Debit = invoice.TotalHasPaid;
                                if (paymentMethod.Code == DbConstant.REF_INVOICE_PAYMENTMETHOD_UANGMUKA_BANK_EKONOMI)
                                {
                                    detailBankKarenaUangMuka.JournalId = _journalMasterRepository.GetMany(j => j.Code == "1.01.02.01").FirstOrDefault().Id;
                                }
                                else if (paymentMethod.Code == DbConstant.REF_INVOICE_PAYMENTMETHOD_UANGMUKA_BANK_BCA1)
                                {
                                    detailBankKarenaUangMuka.JournalId = _journalMasterRepository.GetMany(j => j.Code == "1.01.02.02").FirstOrDefault().Id;
                                }
                                else if (paymentMethod.Code == DbConstant.REF_INVOICE_PAYMENTMETHOD_UANGMUKA_BANK_BCA2)
                                {
                                    detailBankKarenaUangMuka.JournalId = _journalMasterRepository.GetMany(j => j.Code == "1.01.02.03").FirstOrDefault().Id;
                                }
                                detailBankKarenaUangMuka.ParentId = transaction.Id;
                        
                                _transactionDetailRepository.AttachNavigation(detailBankKarenaUangMuka.Journal);
                                _transactionDetailRepository.AttachNavigation(detailBankKarenaUangMuka.Parent);
                                _transactionDetailRepository.Add(detailBankKarenaUangMuka);

                                // Uang Muka Debit --> Karena bertambah
                                TransactionDetail detailUangMukaBertambahKarenaBank = new TransactionDetail();
                                detailUangMukaBertambahKarenaBank.Debit = invoice.TotalHasPaid;
                                detailUangMukaBertambahKarenaBank.JournalId = _journalMasterRepository.GetMany(j => j.Code == "1.01.05.01.01").FirstOrDefault().Id;
                                detailUangMukaBertambahKarenaBank.ParentId = transaction.Id;
                        
                                _transactionDetailRepository.AttachNavigation(detailUangMukaBertambahKarenaBank.Journal);
                                _transactionDetailRepository.AttachNavigation(detailUangMukaBertambahKarenaBank.Parent);
                                _transactionDetailRepository.Add(detailUangMukaBertambahKarenaBank);

                                // Uang Muka Kredit --> Karena berkurang
                                TransactionDetail detailUangMukaBerkurangKarenaBank = new TransactionDetail();
                                detailUangMukaBerkurangKarenaBank.Credit = invoice.TotalHasPaid;
                                detailUangMukaBerkurangKarenaBank.JournalId = _journalMasterRepository.GetMany(j => j.Code == "1.01.05.01.01").FirstOrDefault().Id;
                                detailUangMukaBerkurangKarenaBank.ParentId = transaction.Id;
                        
                                _transactionDetailRepository.AttachNavigation(detailUangMukaBerkurangKarenaBank.Journal);
                                _transactionDetailRepository.AttachNavigation(detailUangMukaBerkurangKarenaBank.Parent);
                                _transactionDetailRepository.Add(detailUangMukaBerkurangKarenaBank);
                                break;
                            }

                        case DbConstant.REF_INVOICE_PAYMENTMETHOD_PIUTANG:
                            TransactionDetail piutang = new TransactionDetail();
                            piutang.Debit = invoice.TotalPrice - invoice.TotalHasPaid;
                            piutang.JournalId = _journalMasterRepository.GetMany(j => j.Code == "1.01.03.01.01").FirstOrDefault().Id;
                            piutang.ParentId = transaction.Id;
                    
                            _transactionDetailRepository.AttachNavigation(piutang.Journal);
                            _transactionDetailRepository.AttachNavigation(piutang.Parent);
                            _transactionDetailRepository.Add(piutang);
                            break;
                    }

                    if (paymentMethod.Code == DbConstant.REF_INVOICE_PAYMENTMETHOD_UANGMUKA_BANK_EKONOMI ||
                        paymentMethod.Code == DbConstant.REF_INVOICE_PAYMENTMETHOD_UANGMUKA_BANK_BCA1 ||
                        paymentMethod.Code == DbConstant.REF_INVOICE_PAYMENTMETHOD_UANGMUKA_BANK_BCA2 ||
                       paymentMethod.Code == DbConstant.REF_INVOICE_PAYMENTMETHOD_UANGMUKA_KAS)
                    {
                        if (invoice.TotalPrice > invoice.TotalHasPaid)
                        {
                            // Piutang Debit --> Karena bertambah
                            TransactionDetail piutang = new TransactionDetail();
                            piutang.Debit = invoice.TotalPrice - invoice.TotalHasPaid;
                            piutang.JournalId = _journalMasterRepository.GetMany(j => j.Code == "1.01.03.01.01").FirstOrDefault().Id;
                            piutang.Parent = transaction;
                    
                            _transactionDetailRepository.AttachNavigation(piutang.Journal);
                            _transactionDetailRepository.AttachNavigation(piutang.Parent);
                            _transactionDetailRepository.Add(piutang);
                        }
                    }

                    // Sales Kredit --> Karena berkurang
                    TransactionDetail sales = new TransactionDetail();
                    sales.Credit = invoice.TotalSparepartAndService;
                    sales.JournalId = _journalMasterRepository.GetMany(j => j.Code == "3.01.01").FirstOrDefault().Id;
                    sales.ParentId = transaction.Id;
            
                    _transactionDetailRepository.AttachNavigation(sales.Journal);
                    _transactionDetailRepository.AttachNavigation(sales.Parent);
                    _transactionDetailRepository.Add(sales);

                    // Service Income Kredit --> Karena berkurang
                    TransactionDetail serviceIncome = new TransactionDetail();
                    serviceIncome.Credit = invoice.TotalValueAdded + invoice.TotalFeeSparepart;
                    serviceIncome.JournalId = _journalMasterRepository.GetMany(j => j.Code == "3.01.04").FirstOrDefault().Id;
                    serviceIncome.ParentId = transaction.Id;
            
                    _transactionDetailRepository.AttachNavigation(serviceIncome.Journal);
                    _transactionDetailRepository.AttachNavigation(serviceIncome.Parent);
                    _transactionDetailRepository.Add(serviceIncome);

                    // HPP Sparepart Debit --> Karena bertambah
                    TransactionDetail hppSparepart = new TransactionDetail();
                    hppSparepart.Debit = invoice.TotalSparepartPlusFee;
                    hppSparepart.JournalId = _journalMasterRepository.GetMany(j => j.Code == "3.04.01").FirstOrDefault().Id;
                    hppSparepart.ParentId = transaction.Id;

                    _transactionDetailRepository.AttachNavigation(hppSparepart.Journal);
                    _transactionDetailRepository.AttachNavigation(hppSparepart.Parent);
                    _transactionDetailRepository.Add(hppSparepart);

                    if(invoice.TotalServicePlusFee > 0)
                    {
                        if (entity.SPK.isContractWork)
                        {
                            // HPP Tukang Harian Debit --> Karena bertambah
                            TransactionDetail hppTukang = new TransactionDetail();
                            hppTukang.Debit = invoice.TotalServicePlusFee;
                            hppTukang.JournalId = _journalMasterRepository.GetMany(j => j.Code == "3.04.05").FirstOrDefault().Id;
                            hppTukang.ParentId = transaction.Id;

                            _transactionDetailRepository.AttachNavigation(hppTukang.Journal);
                            _transactionDetailRepository.AttachNavigation(hppTukang.Parent);
                            _transactionDetailRepository.Add(hppTukang);
                        }
                        else
                        {
                            // HPP Tukang Borongan Debit --> Karena bertambah
                            TransactionDetail hppTukang = new TransactionDetail();
                            hppTukang.Debit = invoice.TotalServicePlusFee;
                            hppTukang.JournalId = _journalMasterRepository.GetMany(j => j.Code == "3.04.04").FirstOrDefault().Id;
                            hppTukang.ParentId = transaction.Id;

                            _transactionDetailRepository.AttachNavigation(hppTukang.Journal);
                            _transactionDetailRepository.AttachNavigation(hppTukang.Parent);
                            _transactionDetailRepository.Add(hppTukang);
                        }
                    }

                    // Sparepart Kredit --> Karena berkurang
                    TransactionDetail detailSparepart = new TransactionDetail();
                    detailSparepart.Credit = invoice.TotalSparepart;
                    detailSparepart.JournalId = _journalMasterRepository.GetMany(j => j.Code == "1.01.04.01").FirstOrDefault().Id;
                    detailSparepart.ParentId = transaction.Id;
            
                    _transactionDetailRepository.AttachNavigation(detailSparepart.Journal);
                    _transactionDetailRepository.AttachNavigation(detailSparepart.Parent);
                    _transactionDetailRepository.Add(detailSparepart);


                    if (invoice.TotalServicePlusFee > 0)
                    {
                        // SDM Kredit --> Karena berkurang
                        TransactionDetail detailSDM = new TransactionDetail();
                        detailSDM.Credit = invoice.TotalServicePlusFee;
                        detailSDM.JournalId = _journalMasterRepository.GetMany(j => j.Code == "1.01.04.04").FirstOrDefault().Id;
                        detailSDM.ParentId = transaction.Id;

                        _transactionDetailRepository.AttachNavigation(detailSDM.Journal);
                        _transactionDetailRepository.AttachNavigation(detailSDM.Parent);
                        _transactionDetailRepository.Add(detailSDM);
                    }

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
