using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Database.Repositories;
using BrawijayaWorkshop.Infrastructure.Repository;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BrawijayaWorkshop.Model
{
    public class PurchasingApprovalModel : AppBaseModel
    {
        private IPurchasingRepository _purchasingRepository;
        private IPurchasingDetailRepository _purchasingDetailRepository;
        private ISupplierRepository _supplierRepository;
        private ISparepartRepository _sparepartRepository;
        private ISparepartDetailRepository _sparepartDetailRepository;
        private IReferenceRepository _referenceRepository;
        private ITransactionRepository _transactionRepository;
        private ITransactionDetailRepository _transactionDetailRepository;
        private IJournalMasterRepository _journalMasterRepository;
        private ISpecialSparepartRepository _specialSparepartRepository;
        private ISpecialSparepartDetailRepository _specialSparepartDetailRepository;
        private ISparepartStockCardRepository _sparepartStokCardRepository;
        private ISparepartStockCardDetailRepository _sparepartStokCardDetailRepository;
        private IUnitOfWork _unitOfWork;

        public PurchasingApprovalModel(IPurchasingRepository purchasingRepository, ISupplierRepository supplierRepository,
            IPurchasingDetailRepository purchasingDetailRepository,
            ISparepartRepository sparepartRepository,
            ISparepartDetailRepository sparepartDetailRepository,
            IReferenceRepository referenceRepository,
            ITransactionRepository transactionRepository,
            ITransactionDetailRepository transactionDetailRepository,
            IJournalMasterRepository journalMasterRepository,
            ISpecialSparepartRepository wheelRepository,
            ISpecialSparepartDetailRepository wheelDetailRepository,
            ISparepartStockCardRepository sparepartStockCardRepository,
            ISparepartStockCardDetailRepository sparepartStockCardDetailRepository,
            IUnitOfWork unitOfWork)
            : base()
        {
            _purchasingDetailRepository = purchasingDetailRepository;
            _purchasingRepository = purchasingRepository;
            _supplierRepository = supplierRepository;
            _sparepartRepository = sparepartRepository;
            _sparepartDetailRepository = sparepartDetailRepository;
            _referenceRepository = referenceRepository;
            _transactionRepository = transactionRepository;
            _transactionDetailRepository = transactionDetailRepository;
            _journalMasterRepository = journalMasterRepository;
            _specialSparepartRepository = wheelRepository;
            _specialSparepartDetailRepository = wheelDetailRepository;
            _sparepartStokCardRepository = sparepartStockCardRepository;
            _sparepartStokCardDetailRepository = sparepartStockCardDetailRepository;
            _unitOfWork = unitOfWork;
        }

        public List<PurchasingDetailViewModel> RetrievePurchasingDetail(int purchasingID)
        {
            List<PurchasingDetail> result = _purchasingDetailRepository.GetMany(c => c.PurchasingId == purchasingID).ToList();
            List<PurchasingDetailViewModel> mappedResult = new List<PurchasingDetailViewModel>();
            return Map(result, mappedResult);
        }
        public List<SparepartViewModel> RetrieveSparepart()
        {
            List<Sparepart> result = _sparepartRepository.GetAll().ToList();
            List<SparepartViewModel> mappedResult = new List<SparepartViewModel>();
            return Map(result, mappedResult);
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

        public void Approve(PurchasingViewModel purchasing, int userID)
        {
            using (var trans = _unitOfWork.BeginTransaction())
            {
                try
                {
                    DateTime serverTime = DateTime.Now;

                    Reference transactionReferenceTable = _referenceRepository.GetMany(c => c.Code == DbConstant.REF_TRANSTBL_PURCHASING).FirstOrDefault();
                    
                    List<PurchasingDetail> listPurchasingDetail = _purchasingDetailRepository
                        .GetMany(c => c.PurchasingId == purchasing.Id).ToList();
                    foreach (var purchasingDetail in listPurchasingDetail)
                    {
                        Sparepart sparepartDB = _sparepartRepository.GetById(purchasingDetail.SparepartId);

                        SparepartDetail lastSPDetail = _sparepartDetailRepository.
                            GetMany(c => c.SparepartId == purchasingDetail.SparepartId).OrderByDescending(c => c.Id)
                            .FirstOrDefault();
                        string lastSPID = string.Empty;
                        if (lastSPDetail != null) lastSPID = lastSPDetail.Code;

                        SpecialSparepart specialSparepart = _specialSparepartRepository.GetMany(w => w.SparepartId == sparepartDB.Id && w.Status == (int)DbConstant.DefaultDataStatus.Active).FirstOrDefault();

                        for (int i = 1; i <= purchasingDetail.Qty; i++)
                        {
                            SparepartDetail spDetail = new SparepartDetail();
                            if (string.IsNullOrEmpty(lastSPID))
                            {
                                lastSPID = sparepartDB.Code + "0000000001";
                            }
                            else
                            {
                                lastSPID = sparepartDB.Code + (Convert.ToInt32(lastSPID.Substring(lastSPID.Length - 10)) + 1)
                                    .ToString("D10");
                            }
                            spDetail.PurchasingDetailId = purchasingDetail.Id;
                            spDetail.SparepartId = sparepartDB.Id;
                            spDetail.Code = lastSPID;
                            spDetail.CreateDate = serverTime;
                            spDetail.CreateUserId = userID;
                            spDetail.ModifyUserId = userID;
                            spDetail.ModifyDate = serverTime;
                            spDetail.Status = (int)DbConstant.SparepartDetailDataStatus.Active;

                            _sparepartDetailRepository.AttachNavigation(spDetail.CreateUser);
                            _sparepartDetailRepository.AttachNavigation(spDetail.ModifyUser);
                            _sparepartDetailRepository.AttachNavigation(spDetail.PurchasingDetail);
                            _sparepartDetailRepository.AttachNavigation(spDetail.Sparepart);
                            _sparepartDetailRepository.AttachNavigation(spDetail.SparepartManualTransaction);
                            SparepartDetail insertedSpDetail = _sparepartDetailRepository.Add(spDetail);

                            if (!string.IsNullOrEmpty(purchasingDetail.SerialNumber) && specialSparepart != null)
                            {
                                SpecialSparepartDetail wd = new SpecialSparepartDetail();
                                wd.SerialNumber = purchasingDetail.SerialNumber;
                                wd.CreateUserId = userID;
                                wd.CreateDate = serverTime;
                                wd.ModifyUserId = userID;
                                wd.ModifyDate = serverTime;
                                wd.SpecialSparepartId = specialSparepart.Id;
                                wd.SparepartDetail = insertedSpDetail;
                                wd.Status = (int)DbConstant.WheelDetailStatus.Ready;

                                _specialSparepartDetailRepository.AttachNavigation(spDetail.CreateUser);
                                _specialSparepartDetailRepository.AttachNavigation(spDetail.ModifyUser);
                                _specialSparepartDetailRepository.AttachNavigation(spDetail.PurchasingDetail);
                                _specialSparepartDetailRepository.AttachNavigation(spDetail.Sparepart);
                                _specialSparepartDetailRepository.AttachNavigation(spDetail.SparepartManualTransaction);
                                _specialSparepartDetailRepository.Add(wd);
                            }
                        }

                        purchasingDetail.Status = (int)DbConstant.PurchasingStatus.Active;
                        _purchasingDetailRepository.AttachNavigation(purchasingDetail.CreateUser);
                        _purchasingDetailRepository.AttachNavigation(purchasingDetail.ModifyUser);
                        _purchasingDetailRepository.AttachNavigation(purchasingDetail.Purchasing);
                        _purchasingDetailRepository.AttachNavigation(purchasingDetail.Sparepart);
                        _purchasingDetailRepository.Update(purchasingDetail);

                        Sparepart sparepart = _sparepartRepository.GetById(purchasingDetail.SparepartId);
                        sparepart.StockQty += purchasingDetail.Qty;

                        _sparepartRepository.AttachNavigation(sparepart.CreateUser);
                        _sparepartRepository.AttachNavigation(sparepart.ModifyUser);
                        _sparepartRepository.AttachNavigation(sparepart.CategoryReference);
                        _sparepartRepository.AttachNavigation(sparepart.UnitReference);
                        _sparepartRepository.Update(sparepart);

                        SparepartStockCard stockCard = new SparepartStockCard();
                        stockCard.CreateUserId = userID;
                        stockCard.PurchaseDate = serverTime;
                        stockCard.PrimaryKeyValue = purchasing.Id;
                        stockCard.ReferenceTableId = transactionReferenceTable.Id;
                        stockCard.SparepartId = sparepart.Id;
                        stockCard.Description = "Purchasing";
                        stockCard.QtyIn = purchasingDetail.Qty;
                        stockCard.QtyInPrice = Convert.ToDouble(purchasingDetail.Price * purchasingDetail.Qty);
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
                        stockCard.QtyLast = lastStock + stockCard.QtyIn;
                        stockCard.QtyLastPrice = lastStockPrice + stockCard.QtyInPrice;
                        _sparepartStokCardRepository.AttachNavigation(stockCard.CreateUser);
                        _sparepartStokCardRepository.AttachNavigation(stockCard.Sparepart);
                        _sparepartStokCardRepository.AttachNavigation(stockCard.ReferenceTable);
                        stockCard = _sparepartStokCardRepository.Add(stockCard);
                        _unitOfWork.SaveChanges();


                        SparepartStockCardDetail stockCardDtail = new SparepartStockCardDetail();
                        stockCardDtail.ParentStockCard = stockCard;
                        stockCardDtail.PricePerItem = Convert.ToDouble(purchasingDetail.Price);
                        stockCardDtail.QtyIn = purchasingDetail.Qty;
                        stockCardDtail.QtyInPrice = Convert.ToDouble(purchasingDetail.Price * purchasingDetail.Qty);
                        SparepartStockCardDetail lastStockCardDetail = _sparepartStokCardDetailRepository.RetrieveLastCardDetailByPurchasingId(sparepart.Id, purchasing.Id);
                        double lastStockDetail = 0;
                        double lastStockDetailPrice = 0;
                        if (lastStockCardDetail != null)
                        {
                            lastStockDetail = lastStockCardDetail.QtyLast;
                            lastStockDetailPrice = lastStockCardDetail.QtyLastPrice;
                        }
                        stockCardDtail.QtyFirst = lastStockDetail;
                        stockCardDtail.QtyFirstPrice = lastStockDetailPrice;
                        stockCardDtail.QtyLast = lastStockDetail + stockCardDtail.QtyIn;
                        stockCardDtail.QtyLastPrice = lastStockDetailPrice + stockCardDtail.QtyInPrice;
                        stockCardDtail.PurchasingId = purchasing.Id;
                        _sparepartStokCardDetailRepository.AttachNavigation(stockCardDtail.ParentStockCard);
                        _sparepartStokCardDetailRepository.Add(stockCardDtail);
                        _unitOfWork.SaveChanges();
                    }

                    Reference refSelected = _referenceRepository.GetById(purchasing.PaymentMethodId);
                    purchasing.Status = (int)DbConstant.PurchasingStatus.Active;
                    if (refSelected != null &&
                        (refSelected.Code == DbConstant.REF_PURCHASE_PAYMENTMETHOD_BANK_EKONOMI
                        || refSelected.Code == DbConstant.REF_PURCHASE_PAYMENTMETHOD_BANK_BCA1
                        || refSelected.Code == DbConstant.REF_PURCHASE_PAYMENTMETHOD_BANK_BCA2
                        || refSelected.Code == DbConstant.REF_PURCHASE_PAYMENTMETHOD_KAS)
                       )
                    {
                        purchasing.TotalHasPaid = purchasing.TotalPrice;
                    }

                    if (purchasing.TotalHasPaid != purchasing.TotalPrice)
                    {
                        purchasing.PaymentStatus = (int)DbConstant.PaymentStatus.NotSettled;
                    }
                    else
                    {
                        purchasing.PaymentStatus = (int)DbConstant.PaymentStatus.Settled;
                    }
                    Purchasing entity = _purchasingRepository.GetById(purchasing.Id);
                    //Map(purchasing, entity);
                    entity.PaymentStatus = purchasing.PaymentStatus;
                    entity.Status = purchasing.Status;
                    entity.TotalHasPaid = purchasing.TotalHasPaid;
                    entity.TotalPrice = purchasing.TotalPrice;
                    entity.PaymentMethodId = purchasing.PaymentMethodId;
                    _purchasingRepository.AttachNavigation(entity.CreateUser);
                    _purchasingRepository.AttachNavigation(entity.ModifyUser);
                    _purchasingRepository.AttachNavigation(entity.PaymentMethod);
                    _purchasingRepository.AttachNavigation(entity.Supplier);
                    _purchasingRepository.Update(entity);
                    _unitOfWork.SaveChanges();

                    Transaction transaction = new Transaction();
                    transaction.TransactionDate = purchasing.Date;
                    transaction.TotalPayment = Convert.ToDouble(purchasing.TotalHasPaid);
                    transaction.TotalTransaction = Convert.ToDouble(purchasing.TotalPrice);
                    transaction.ReferenceTableId = transactionReferenceTable.Id;
                    transaction.PrimaryKeyValue = purchasing.Id;
                    transaction.CreateDate = serverTime;
                    transaction.CreateUserId = userID;
                    transaction.ModifyUserId = userID;
                    transaction.ModifyDate = serverTime;
                    transaction.Status = (int)DbConstant.DefaultDataStatus.Active;
                    transaction.Description = "Pembelian sparepart";
                    transaction.PaymentMethodId = purchasing.PaymentMethodId;

                    _transactionRepository.AttachNavigation(transaction.CreateUser);
                    _transactionRepository.AttachNavigation(transaction.ModifyUser);
                    _transactionRepository.AttachNavigation(transaction.PaymentMethod);
                    _transactionRepository.AttachNavigation(transaction.ReferenceTable);
                    Transaction transactionInserted = _transactionRepository.Add(transaction);
                    _unitOfWork.SaveChanges();

                    switch (refSelected.Code)
                    {
                        case DbConstant.REF_PURCHASE_PAYMENTMETHOD_BANK_EKONOMI:
                        case DbConstant.REF_PURCHASE_PAYMENTMETHOD_BANK_BCA1:
                        case DbConstant.REF_PURCHASE_PAYMENTMETHOD_BANK_BCA2:
                            {
                                // Bank Kredit --> Karena berkurang
                                TransactionDetail detailBank = new TransactionDetail();
                                detailBank.Credit = purchasing.TotalHasPaid;
                                if (refSelected.Code == DbConstant.REF_PURCHASE_PAYMENTMETHOD_BANK_EKONOMI)
                                {
                                    detailBank.JournalId = _journalMasterRepository.GetMany(j => j.Code == "1.01.02.01").FirstOrDefault().Id;
                                }
                                else if (refSelected.Code == DbConstant.REF_PURCHASE_PAYMENTMETHOD_BANK_BCA1)
                                {
                                    detailBank.JournalId = _journalMasterRepository.GetMany(j => j.Code == "1.01.02.02").FirstOrDefault().Id;
                                }
                                else if (refSelected.Code == DbConstant.REF_PURCHASE_PAYMENTMETHOD_BANK_BCA2)
                                {
                                    detailBank.JournalId = _journalMasterRepository.GetMany(j => j.Code == "1.01.02.03").FirstOrDefault().Id;
                                }
                                detailBank.ParentId = transactionInserted.Id;

                                _transactionDetailRepository.AttachNavigation(detailBank.Journal);
                                _transactionDetailRepository.AttachNavigation(detailBank.Parent);
                                _transactionDetailRepository.Add(detailBank);
                                break;
                            }

                        case DbConstant.REF_PURCHASE_PAYMENTMETHOD_KAS:
                            // Kas Kredit --> Karena berkurang
                            TransactionDetail detailKas = new TransactionDetail();
                            detailKas.Credit = purchasing.TotalHasPaid;
                            detailKas.JournalId = _journalMasterRepository.GetMany(j => j.Code == "1.01.01.01").FirstOrDefault().Id;
                            detailKas.ParentId = transactionInserted.Id;

                            _transactionDetailRepository.AttachNavigation(detailKas.Journal);
                            _transactionDetailRepository.AttachNavigation(detailKas.Parent);
                            _transactionDetailRepository.Add(detailKas);
                            break;

                        case DbConstant.REF_PURCHASE_PAYMENTMETHOD_UANGMUKA_KAS:
                            // Kas Kredit --> Karena berkurang
                            TransactionDetail detailKasKarenaUangMuka = new TransactionDetail();
                            detailKasKarenaUangMuka.Credit = purchasing.TotalHasPaid;
                            detailKasKarenaUangMuka.JournalId = _journalMasterRepository.GetMany(j => j.Code == "1.01.01.01").FirstOrDefault().Id;
                            detailKasKarenaUangMuka.ParentId = transactionInserted.Id;

                            _transactionDetailRepository.AttachNavigation(detailKasKarenaUangMuka.Journal);
                            _transactionDetailRepository.AttachNavigation(detailKasKarenaUangMuka.Parent);
                            _transactionDetailRepository.Add(detailKasKarenaUangMuka);

                            // Uang Muka Debit --> Karena bertambah
                            TransactionDetail detailUangMukaBertambahKarenaKas = new TransactionDetail();
                            detailUangMukaBertambahKarenaKas.Debit = purchasing.TotalHasPaid;
                            detailUangMukaBertambahKarenaKas.JournalId = _journalMasterRepository.GetMany(j => j.Code == "1.01.05.01.01").FirstOrDefault().Id;
                            detailUangMukaBertambahKarenaKas.ParentId = transactionInserted.Id;

                            _transactionDetailRepository.AttachNavigation(detailUangMukaBertambahKarenaKas.Journal);
                            _transactionDetailRepository.AttachNavigation(detailUangMukaBertambahKarenaKas.Parent);
                            _transactionDetailRepository.Add(detailUangMukaBertambahKarenaKas);

                            // Uang Muka Kredit --> Karena berkurang
                            TransactionDetail detailUangMukaBerkurangKarenaKas = new TransactionDetail();
                            detailUangMukaBerkurangKarenaKas.Credit = purchasing.TotalHasPaid;
                            detailUangMukaBerkurangKarenaKas.JournalId = _journalMasterRepository.GetMany(j => j.Code == "1.01.05.01.01").FirstOrDefault().Id;
                            detailUangMukaBerkurangKarenaKas.ParentId = transactionInserted.Id;

                            _transactionDetailRepository.AttachNavigation(detailUangMukaBerkurangKarenaKas.Journal);
                            _transactionDetailRepository.AttachNavigation(detailUangMukaBerkurangKarenaKas.Parent);
                            _transactionDetailRepository.Add(detailUangMukaBerkurangKarenaKas);
                            break;

                        case DbConstant.REF_PURCHASE_PAYMENTMETHOD_UANGMUKA_BANK_EKONOMI:
                        case DbConstant.REF_PURCHASE_PAYMENTMETHOD_UANGMUKA_BANK_BCA1:
                        case DbConstant.REF_PURCHASE_PAYMENTMETHOD_UANGMUKA_BANK_BCA2:
                            {
                                // Bank Kredit --> Karena berkurang
                                TransactionDetail detailBankKarenaUangMuka = new TransactionDetail();
                                detailBankKarenaUangMuka.Credit = purchasing.TotalHasPaid;
                                if (refSelected.Code == DbConstant.REF_PURCHASE_PAYMENTMETHOD_UANGMUKA_BANK_EKONOMI)
                                {
                                    detailBankKarenaUangMuka.JournalId = _journalMasterRepository.GetMany(j => j.Code == "1.01.02.01").FirstOrDefault().Id;
                                }
                                else if (refSelected.Code == DbConstant.REF_PURCHASE_PAYMENTMETHOD_UANGMUKA_BANK_BCA1)
                                {
                                    detailBankKarenaUangMuka.JournalId = _journalMasterRepository.GetMany(j => j.Code == "1.01.02.02").FirstOrDefault().Id;
                                }
                                else if (refSelected.Code == DbConstant.REF_PURCHASE_PAYMENTMETHOD_UANGMUKA_BANK_BCA2)
                                {
                                    detailBankKarenaUangMuka.JournalId = _journalMasterRepository.GetMany(j => j.Code == "1.01.02.03").FirstOrDefault().Id;
                                }
                                detailBankKarenaUangMuka.ParentId = transactionInserted.Id;

                                _transactionDetailRepository.AttachNavigation(detailBankKarenaUangMuka.Journal);
                                _transactionDetailRepository.AttachNavigation(detailBankKarenaUangMuka.Parent);
                                _transactionDetailRepository.Add(detailBankKarenaUangMuka);

                                // Uang Muka Debit --> Karena bertambah
                                TransactionDetail detailUangMukaBertambahKarenaBank = new TransactionDetail();
                                detailUangMukaBertambahKarenaBank.Debit = purchasing.TotalHasPaid;
                                detailUangMukaBertambahKarenaBank.JournalId = _journalMasterRepository.GetMany(j => j.Code == "1.01.05.01.01").FirstOrDefault().Id;
                                detailUangMukaBertambahKarenaBank.ParentId = transactionInserted.Id;

                                _transactionDetailRepository.AttachNavigation(detailUangMukaBertambahKarenaBank.Journal);
                                _transactionDetailRepository.AttachNavigation(detailUangMukaBertambahKarenaBank.Parent);
                                _transactionDetailRepository.Add(detailUangMukaBertambahKarenaBank);

                                // Uang Muka Kredit --> Karena berkurang
                                TransactionDetail detailUangMukaBerkurangKarenaBank = new TransactionDetail();
                                detailUangMukaBerkurangKarenaBank.Credit = purchasing.TotalHasPaid;
                                detailUangMukaBerkurangKarenaBank.JournalId = _journalMasterRepository.GetMany(j => j.Code == "1.01.05.01.01").FirstOrDefault().Id;
                                detailUangMukaBerkurangKarenaBank.ParentId = transactionInserted.Id;

                                _transactionDetailRepository.AttachNavigation(detailUangMukaBerkurangKarenaBank.Journal);
                                _transactionDetailRepository.AttachNavigation(detailUangMukaBerkurangKarenaBank.Parent);
                                _transactionDetailRepository.Add(detailUangMukaBerkurangKarenaBank);
                                break;
                            }

                        case DbConstant.REF_PURCHASE_PAYMENTMETHOD_UTANG:
                            TransactionDetail utang = new TransactionDetail();
                            utang.Credit = purchasing.TotalPrice - purchasing.TotalHasPaid;
                            utang.JournalId = _journalMasterRepository.GetMany(j => j.Code == "2.01.01.01").FirstOrDefault().Id;
                            utang.ParentId = transactionInserted.Id;

                            _transactionDetailRepository.AttachNavigation(utang.Journal);
                            _transactionDetailRepository.AttachNavigation(utang.Parent);
                            _transactionDetailRepository.Add(utang);
                            break;
                    }

                    if (refSelected.Code == DbConstant.REF_PURCHASE_PAYMENTMETHOD_UANGMUKA_BANK_EKONOMI ||
                        refSelected.Code == DbConstant.REF_PURCHASE_PAYMENTMETHOD_UANGMUKA_BANK_BCA1 ||
                       refSelected.Code == DbConstant.REF_PURCHASE_PAYMENTMETHOD_UANGMUKA_BANK_BCA2 ||
                       refSelected.Code == DbConstant.REF_PURCHASE_PAYMENTMETHOD_UANGMUKA_KAS)
                    {
                        if (purchasing.TotalPrice > purchasing.TotalHasPaid)
                        {
                            // Utang Kredit --> Karena bertambah
                            TransactionDetail utang = new TransactionDetail();
                            utang.Credit = purchasing.TotalPrice - purchasing.TotalHasPaid;
                            utang.JournalId = _journalMasterRepository.GetMany(j => j.Code == "2.01.01.01").FirstOrDefault().Id;
                            utang.ParentId = transactionInserted.Id;

                            _transactionDetailRepository.AttachNavigation(utang.Journal);
                            _transactionDetailRepository.AttachNavigation(utang.Parent);
                            _transactionDetailRepository.Add(utang);
                        }
                    }

                    // Sparepart Debit --> Karena bertambah
                    TransactionDetail detailSparepart = new TransactionDetail();
                    detailSparepart.Debit = purchasing.TotalPrice;
                    detailSparepart.JournalId = _journalMasterRepository.GetMany(j => j.Code == "1.01.04.01").FirstOrDefault().Id;
                    detailSparepart.ParentId = transactionInserted.Id;

                    _transactionDetailRepository.AttachNavigation(detailSparepart.Journal);
                    _transactionDetailRepository.AttachNavigation(detailSparepart.Parent);
                    _transactionDetailRepository.Add(detailSparepart);

                    _unitOfWork.SaveChanges();

                    trans.Commit();
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    throw;
                }
            }
        }

        public void Reject(PurchasingViewModel purchasing, int userID)
        {
            using (var trans = _unitOfWork.BeginTransaction())
            {
                try
                {
                    List<PurchasingDetail> listPurchasingDetail = _purchasingDetailRepository
                .GetMany(c => c.PurchasingId == purchasing.Id).ToList();
                    foreach (var purchasingDetail in listPurchasingDetail)
                    {
                        purchasingDetail.Status = (int)DbConstant.PurchasingStatus.Deleted;
                        purchasingDetail.ModifyUserId = userID;
                        purchasingDetail.ModifyDate = DateTime.Now;
                        _purchasingDetailRepository.Update(purchasingDetail);
                    }
                    Purchasing entity = _purchasingRepository.GetById(purchasing.Id);
                    entity.Status = (int)DbConstant.PurchasingStatus.Deleted;
                    entity.ModifyUserId = userID;
                    entity.ModifyDate = DateTime.Now;
                    _purchasingRepository.Update(entity);
                    _unitOfWork.SaveChanges();
                    trans.Commit();
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    throw;
                }
            }
        }
    }
}
