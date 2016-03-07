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
        private IWheelRepository _wheelRepository;
        private IWheelDetailRepository _wheelDetailRepository;
        private IUnitOfWork _unitOfWork;

        public PurchasingApprovalModel(IPurchasingRepository purchasingRepository, ISupplierRepository supplierRepository,
            IPurchasingDetailRepository purchasingDetailRepository,
            ISparepartRepository sparepartRepository,
            ISparepartDetailRepository sparepartDetailRepository,
            IReferenceRepository referenceRepository,
            ITransactionRepository transactionRepository,
            ITransactionDetailRepository transactionDetailRepository,
            IJournalMasterRepository journalMasterRepository,
            IWheelRepository wheelRepository,
            IWheelDetailRepository wheelDetailRepository,
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
            _wheelRepository = wheelRepository;
            _wheelDetailRepository = wheelDetailRepository;
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
            DateTime serverTime = DateTime.Now;

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

                Wheel wheel = _wheelRepository.GetMany(w => w.SparepartId == sparepartDB.Id && w.Status == (int)DbConstant.DefaultDataStatus.Active).FirstOrDefault();

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
                    spDetail.PurchasingDetail = purchasingDetail;
                    spDetail.SparepartId = sparepartDB.Id;
                    spDetail.Code = lastSPID;
                    spDetail.CreateDate = serverTime;
                    spDetail.CreateUserId = userID;
                    spDetail.ModifyUserId = userID;
                    spDetail.ModifyDate = serverTime;
                    spDetail.Status = (int)DbConstant.SparepartDetailDataStatus.Active;
                    SparepartDetail insertedSpDetail = _sparepartDetailRepository.Add(spDetail);

                    if (wheel != null)
                    {
                        WheelDetail wd = new WheelDetail();
                        wd.CreateUserId = userID;
                        wd.CreateDate = serverTime;
                        wd.ModifyUserId = userID;
                        wd.ModifyDate = serverTime;
                        wd.WheelId = wheel.Id;
                        wd.SparepartDetailId = insertedSpDetail.Id;
                        wd.Status = (int)DbConstant.WheelDetailStatus.Ready;

                        _wheelDetailRepository.Add(wd);
                    }
                }

                purchasingDetail.Status = (int)DbConstant.PurchasingStatus.Active;
                _purchasingDetailRepository.Update(purchasingDetail);

                Sparepart sparepart = _sparepartRepository.GetById(purchasingDetail.SparepartId);
                sparepart.StockQty += purchasingDetail.Qty;
                _sparepartRepository.Update(sparepart);
            }

            Reference refSelected = _referenceRepository.GetById(purchasing.PaymentMethodId);
            purchasing.Status = (int)DbConstant.PurchasingStatus.Active;
            if (refSelected != null &&
                (refSelected.Code == DbConstant.REF_PURCHASE_PAYMENTMETHOD_BANK
                || refSelected.Code == DbConstant.REF_PURCHASE_PAYMENTMETHOD_KAS)
               )
            {
                purchasing.TotalHasPaid = purchasing.TotalPrice;
            }
            Purchasing entity = _purchasingRepository.GetById(purchasing.Id);
            Map(purchasing, entity);
            _purchasingRepository.Update(entity);

            Reference transactionReferenceTable = _referenceRepository.GetMany(c => c.Code == DbConstant.REF_TRANSTBL_PURCHASING).FirstOrDefault();
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
            Transaction transactionInserted = _transactionRepository.Add(transaction);

            switch (purchasing.PaymentMethod.Code)
            {
                case DbConstant.REF_PURCHASE_PAYMENTMETHOD_BANK:

                    // Bank Kredit --> Karena berkurang
                    TransactionDetail detailBank = new TransactionDetail();
                    detailBank.Credit = purchasing.TotalHasPaid;
                    detailBank.JournalId = _journalMasterRepository.GetMany(j => j.Code == "1.01.02").FirstOrDefault().Id;
                    detailBank.Parent = transactionInserted;
                    _transactionDetailRepository.Add(detailBank);

                    break;
                case DbConstant.REF_PURCHASE_PAYMENTMETHOD_KAS:

                    // Kas Kredit --> Karena berkurang
                    TransactionDetail detailKas = new TransactionDetail();
                    detailKas.Credit = purchasing.TotalHasPaid;
                    detailKas.JournalId = _journalMasterRepository.GetMany(j => j.Code == "1.01.01").FirstOrDefault().Id;
                    detailKas.Parent = transactionInserted;
                    _transactionDetailRepository.Add(detailKas);

                    break;
                case DbConstant.REF_PURCHASE_PAYMENTMETHOD_UANGMUKA_KAS:

                    // Kas Kredit --> Karena berkurang
                    TransactionDetail detailKasKarenaUangMuka = new TransactionDetail();
                    detailKasKarenaUangMuka.Credit = purchasing.TotalHasPaid;
                    detailKasKarenaUangMuka.JournalId = _journalMasterRepository.GetMany(j => j.Code == "1.01.01").FirstOrDefault().Id;
                    detailKasKarenaUangMuka.Parent = transactionInserted;
                    _transactionDetailRepository.Add(detailKasKarenaUangMuka);

                    // Uang Muka Debit --> Karena bertambah
                    TransactionDetail detailUangMukaBertambahKarenaKas = new TransactionDetail();
                    detailUangMukaBertambahKarenaKas.Debit = purchasing.TotalHasPaid;
                    detailUangMukaBertambahKarenaKas.JournalId = _journalMasterRepository.GetMany(j => j.Code == "1.01.05").FirstOrDefault().Id;
                    detailUangMukaBertambahKarenaKas.Parent = transactionInserted;
                    _transactionDetailRepository.Add(detailUangMukaBertambahKarenaKas);

                    // Uang Muka Kredit --> Karena berkurang
                    TransactionDetail detailUangMukaKasBerkurang = new TransactionDetail();
                    detailUangMukaKasBerkurang.Credit = purchasing.TotalHasPaid;
                    detailUangMukaKasBerkurang.JournalId = _journalMasterRepository.GetMany(j => j.Code == "1.01.05").FirstOrDefault().Id;
                    detailUangMukaKasBerkurang.Parent = transactionInserted;
                    _transactionDetailRepository.Add(detailUangMukaKasBerkurang);

                    break;
                case DbConstant.REF_PURCHASE_PAYMENTMETHOD_UANGMUKA_BANK:

                    // Bank Kredit --> Karena berkurang
                    TransactionDetail detailBankKarenaUangMuka = new TransactionDetail();
                    detailBankKarenaUangMuka.Credit = purchasing.TotalHasPaid;
                    detailBankKarenaUangMuka.JournalId = _journalMasterRepository.GetMany(j => j.Code == "1.01.02").FirstOrDefault().Id;
                    detailBankKarenaUangMuka.Parent = transactionInserted;
                    _transactionDetailRepository.Add(detailBankKarenaUangMuka);

                    // Uang Muka Debit --> Karena bertambah
                    TransactionDetail detailUangMukaBertambahKarenaBank = new TransactionDetail();
                    detailUangMukaBertambahKarenaBank.Debit = purchasing.TotalHasPaid;
                    detailUangMukaBertambahKarenaBank.JournalId = _journalMasterRepository.GetMany(j => j.Code == "1.01.05").FirstOrDefault().Id;
                    detailUangMukaBertambahKarenaBank.Parent = transactionInserted;
                    _transactionDetailRepository.Add(detailUangMukaBertambahKarenaBank);

                    // Uang Muka Kredit --> Karena berkurang
                    TransactionDetail detailUangMukaBankBerkurang = new TransactionDetail();
                    detailUangMukaBankBerkurang.Credit = purchasing.TotalHasPaid;
                    detailUangMukaBankBerkurang.JournalId = _journalMasterRepository.GetMany(j => j.Code == "1.01.05").FirstOrDefault().Id;
                    detailUangMukaBankBerkurang.Parent = transactionInserted;
                    _transactionDetailRepository.Add(detailUangMukaBankBerkurang);

                    break;
                case DbConstant.REF_PURCHASE_PAYMENTMETHOD_UTANG:
                    break;
            }

            if (purchasing.PaymentMethod.Code == DbConstant.REF_PURCHASE_PAYMENTMETHOD_UANGMUKA_BANK ||
               purchasing.PaymentMethod.Code == DbConstant.REF_PURCHASE_PAYMENTMETHOD_UANGMUKA_KAS)
            {
                if (purchasing.TotalPrice > purchasing.TotalHasPaid)
                {
                    // Utang Kredit --> Karena bertambah
                    TransactionDetail utang = new TransactionDetail();
                    utang.Credit = purchasing.TotalPrice - purchasing.TotalHasPaid;
                    utang.JournalId = _journalMasterRepository.GetMany(j => j.Code == "2.01").FirstOrDefault().Id;
                    utang.Parent = transactionInserted;
                    _transactionDetailRepository.Add(utang);
                }
            }

            // Sparepart Debit --> Karena bertambah
            TransactionDetail detailSparepart = new TransactionDetail();
            detailSparepart.Debit = purchasing.TotalPrice;
            detailSparepart.JournalId = _journalMasterRepository.GetMany(j => j.Code == "1.01").FirstOrDefault().Id;
            detailSparepart.Parent = transactionInserted;
            _transactionDetailRepository.Add(detailSparepart);

            _unitOfWork.SaveChanges();
        }

        public void Reject(PurchasingViewModel purchasing)
        {
            List<PurchasingDetail> listPurchasingDetail = _purchasingDetailRepository
                .GetMany(c => c.PurchasingId == purchasing.Id).ToList();
            foreach (var purchasingDetail in listPurchasingDetail)
            {
                List<SparepartDetail> listSparepartDetail = _sparepartDetailRepository
                    .GetMany(c => c.PurchasingDetailId == purchasingDetail.Id).ToList();
                foreach (var sparepartDetail in listSparepartDetail)
                {
                    _sparepartDetailRepository.Delete(sparepartDetail);

                }
                _purchasingDetailRepository.Delete(purchasingDetail);
            }
            Purchasing entity = _purchasingRepository.GetById(purchasing.Id);
            _purchasingRepository.Delete(entity);
            _unitOfWork.SaveChanges();
        }
    }
}
