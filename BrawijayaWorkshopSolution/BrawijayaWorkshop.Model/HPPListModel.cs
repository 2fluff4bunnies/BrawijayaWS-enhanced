using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Database.Repositories;
using BrawijayaWorkshop.Infrastructure.Repository;
using BrawijayaWorkshop.SharedObject.ViewModels;
using BrawijayaWorkshop.Utils;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace BrawijayaWorkshop.Model
{
    public class HPPListModel : AppBaseModel
    {
        private IHPPHeaderRepository _hppHeaderRepository;
        private IHPPDetailRepository _hppDetailRepository;

        private IBalanceJournalRepository _balanceJournalRepository;
        private IBalanceJournalDetailRepository _balanceJournalDetailRepository;

        private IJournalMasterRepository _journalMasterRepository;
        private IReferenceRepository _referenceRepository;

        private IPurchasingRepository _purchasingRepository;

        private ISparepartRepository _sparepartRepository;
        private ISparepartDetailRepository _sparepartDetailRepository;

        private IInvoiceRepository _invoiceRepository;

        private IUnitOfWork _unitOfWork;

        public HPPListModel(IHPPHeaderRepository hppHeaderRepository, IHPPDetailRepository hppDetailRepository,
            IBalanceJournalRepository balanceJournalRepository, IBalanceJournalDetailRepository balanceJournalDetailRepository,
            IJournalMasterRepository journalMasterRepository, IReferenceRepository referenceRepository,
            IPurchasingRepository purchasingRepository, ISparepartRepository sparepartRepository,
            ISparepartDetailRepository sparepartDetailRepository, IInvoiceRepository invoiceRepository,
            IUnitOfWork unitOfWork)
            : base()
        {
            _hppHeaderRepository = hppHeaderRepository;
            _hppDetailRepository = hppDetailRepository;
            _balanceJournalRepository = balanceJournalRepository;
            _balanceJournalDetailRepository = balanceJournalDetailRepository;
            _journalMasterRepository = journalMasterRepository;
            _referenceRepository = referenceRepository;
            _purchasingRepository = purchasingRepository;
            _sparepartRepository = sparepartRepository;
            _sparepartDetailRepository = sparepartDetailRepository;
            _invoiceRepository = invoiceRepository;
            _unitOfWork = unitOfWork;
        }

        public Dictionary<int, string> GenerateMonth()
        {
            Dictionary<int, string> result = new Dictionary<int, string>();
            for (int i = 1; i <= 12; i++)
            {
                result.Add(i, DateTimeFormatInfo.CurrentInfo.GetMonthName(i));
            }
            return result;
        }

        public List<int> GenerateYear()
        {
            List<int> result = new List<int>();
            for (int i = 2016; i <= DateTime.Today.Year; i++)
            {
                result.Add(i);
            }
            return result;
        }

        public HPPHeaderViewModel RetrieveHPPHeader(int month, int year)
        {
            HPPHeader result = _hppHeaderRepository.GetMany(hpp => hpp.Month == month && hpp.Year == year &&
                hpp.Status == (int)DbConstant.DefaultDataStatus.Active).FirstOrDefault();
            HPPHeaderViewModel mappedResult = new HPPHeaderViewModel();
            return Map(result, mappedResult);
        }

        public List<HPPDetailViewModel> RetrieveHPPDetailsByHeaderId(int headerId)
        {
            List<HPPDetail> result = _hppDetailRepository.GetMany(hpp => hpp.HeaderId == headerId).ToList();
            List<HPPDetailViewModel> mappedResult = new List<HPPDetailViewModel>();
            return Map(result, mappedResult);
        }

        public void RecalculateHPP(int month, int year, int userId)
        {
            HPPHeaderViewModel header = RetrieveHPPHeader(month, year);
            if(header != null)
            {
                DeleteHPP(header.Id, userId);
            }

            HPPHeader newHeader = new HPPHeader();
            newHeader.CreateUserId = newHeader.ModifyUserId = userId;
            newHeader.CreateDate = newHeader.ModifyDate = DateTime.Now;
            newHeader.Month = month;
            newHeader.Year = year;
            newHeader.Status = (int)DbConstant.DefaultDataStatus.Active;
            newHeader = _hppHeaderRepository.Add(newHeader);
            _unitOfWork.SaveChanges();

            // TODO : Recalculate
            // 1. Ambil persediaan awal sparepart (Akhir bulan sebelumnya) + Pembelian sparepart bulan ini
            // 2. Ambil persediaan awal tukang harian (akhir bulan sebelumnya) + Pemakaian tukang bulan ini
            // 3. Ambil persediaan awal tukang borongan (akhir bulan sebelumnya) + Pemakaian borongan bulan ini

            // step 1 --> Ambil persediaan awal sparepart (Akhir bulan sebelumnya) + Pembelian sparepart bulan ini
            DateTime firstDay = new DateTime(year, month, 1);
            DateTime lastDay = new DateTime(year, month, DateTime.DaysInMonth(year, month));
            DateTime prevMonth = firstDay.AddDays(-1);
            BalanceJournal lastJournal = _balanceJournalRepository.GetMany(bj =>
                bj.Month == prevMonth.Month && bj.Year == prevMonth.Year &&
                bj.Status == (int)DbConstant.DefaultDataStatus.Active).FirstOrDefault();

            // daftar kode akun untuk HPP
            Reference hppJournal = _referenceRepository.GetMany(r => r.Code == DbConstant.REF_HPP_JOURNAL).FirstOrDefault();
            List<Reference> hppJournalList = _referenceRepository.GetMany(r => r.ParentId == hppJournal.Id).ToList();

            // daftar kode akun untuk stok / persediaan
            Reference stockJournal = _referenceRepository.GetMany(r => r.Code == DbConstant.REF_STOCK_JOURNAL).FirstOrDefault();
            List<Reference> stockJournalList = _referenceRepository.GetMany(r => r.ParentId == stockJournal.Id).ToList();

            // Calculate HPP sparepart this month
            double lastPrevSparepartBalance = 0;
            double totalPurchase = 0;
            double lastSparepartBalance = 0;
            if(lastJournal != null)
            {
                string stockSparepartCode = stockJournalList.Where(j => j.Code == DbConstant.REF_STOCK_JOURNAL_SPAREPART).FirstOrDefault().Value;
                JournalMaster sparepartStockJournal = _journalMasterRepository.GetMany(jm => jm.Code == stockSparepartCode).FirstOrDefault();
                BalanceJournalDetail details = _balanceJournalDetailRepository.GetMany(d => d.ParentId == lastJournal.Id &&
                    d.JournalId == sparepartStockJournal.Id).FirstOrDefault();
                // persediaan awal (bulan sebelumnya)
                lastPrevSparepartBalance = details.LastDebit.AsDouble();

                // pembelian sparepart
                List<Purchasing> listPurchasing = _purchasingRepository.GetMany(p =>
                    p.Status == (int)DbConstant.PurchasingStatus.Active &&
                    p.Date >= firstDay && p.Date <= lastDay).ToList();
                totalPurchase = listPurchasing.Sum(p => p.TotalPrice).AsDouble();

                // persediaan akhir
                List<SparepartDetail> sparepartDetailList = _sparepartDetailRepository.GetMany(sp =>
                    sp.Status == (int)DbConstant.SparepartDetailDataStatus.Active).ToList();
                lastSparepartBalance = sparepartDetailList.Sum(sp =>
                    sp.PurchasingDetailId.HasValue ? sp.PurchasingDetail.Price :
                                                     sp.SparepartManualTransaction.Price).AsDouble();
            }
            double hppSparepartAmount = lastPrevSparepartBalance + totalPurchase - lastSparepartBalance;
            double hppSparepartWithFeeAmount = hppSparepartAmount + (hppSparepartAmount * 0.1);

            string sparepartHPPCode = hppJournalList.Where(r => r.Code == DbConstant.REF_HPP_JOURNAL_SPAREPART).FirstOrDefault().Value;
            JournalMaster sparepartHPPJournal = _journalMasterRepository.GetMany(jm => jm.Code == sparepartHPPCode).FirstOrDefault();

            HPPDetail hppSparepartDetail = new HPPDetail();
            hppSparepartDetail.HeaderId = newHeader.Id;
            hppSparepartDetail.JournalId = sparepartHPPJournal.Id;

            hppSparepartDetail.BaseAmount = hppSparepartAmount.AsDecimal();
            hppSparepartDetail.ServicePercentage = 10;
            hppSparepartDetail.ServiceAmount = hppSparepartWithFeeAmount.AsDecimal();
            hppSparepartDetail.TotalAmount = hppSparepartDetail.BaseAmount + hppSparepartDetail.ServiceAmount;
            
            _hppDetailRepository.Add(hppSparepartDetail);
            // End calculate HPP sparepart this month

            string dailyMechanicHPPCode = hppJournalList.Where(r => r.Code == DbConstant.REF_HPP_JOURNAL_DAILYMECHANIC).FirstOrDefault().Value;
            JournalMaster dailyMechanicHPPJournal = _journalMasterRepository.GetMany(jm => jm.Code == dailyMechanicHPPCode).FirstOrDefault();
            // Calculate Daily Tukang
            List<Invoice> listMonthlyInvoices = _invoiceRepository.GetMany(i => i.CreateDate >= firstDay && i.CreateDate <= lastDay).ToList();
            decimal hppDailyMechanicAmount = 0;
            decimal hppDailyMechanicFeeAmount = 0;
            foreach (var item in listMonthlyInvoices)
            {
                if (item.SPK.isContractWork) continue;
                hppDailyMechanicAmount += item.TotalService;
                hppDailyMechanicFeeAmount += item.TotalServicePlusFee - item.TotalService;
            }
            HPPDetail hppDailyMechanic = new HPPDetail();
            hppDailyMechanic.HeaderId = newHeader.Id;
            hppDailyMechanic.JournalId = dailyMechanicHPPJournal.Id;

            hppDailyMechanic.BaseAmount = hppDailyMechanicAmount;
            hppDailyMechanic.ServicePercentage = 10;
            hppDailyMechanic.ServiceAmount = hppDailyMechanicFeeAmount;
            hppDailyMechanic.TotalAmount = hppDailyMechanic.BaseAmount + hppDailyMechanic.ServiceAmount;

            _hppDetailRepository.Add(hppDailyMechanic);
            // End calculate HPP daily mechanic this month

            string outSourceMechanicHPPCode = hppJournalList.Where(r => r.Code == DbConstant.REF_HPP_JOURNAL_OUTSOURCEMECHANIC).FirstOrDefault().Value;
            JournalMaster outSourceMechanicHPPJournal = _journalMasterRepository.GetMany(jm => jm.Code == outSourceMechanicHPPCode).FirstOrDefault();
            // Calculate Borongan Tukang
            decimal hppOutSourceMechanicAmount = 0;
            decimal hppOutSourceMechanicFeeAmount = 0;
            decimal hppOutSourceMechanicAddInAmount = 0;
            foreach (var item in listMonthlyInvoices)
            {
                if (!item.SPK.isContractWork) continue;
                hppOutSourceMechanicAmount += item.TotalService;
                hppOutSourceMechanicFeeAmount += item.TotalService * 0.1M;
                hppOutSourceMechanicAddInAmount += item.TotalService * 0.2M;
            }

            HPPDetail hppOutSourceMechanic = new HPPDetail();
            hppOutSourceMechanic.HeaderId = newHeader.Id;
            hppOutSourceMechanic.JournalId = outSourceMechanicHPPJournal.Id;

            hppOutSourceMechanic.BaseAmount = hppOutSourceMechanicAmount;
            hppOutSourceMechanic.ServicePercentage = 10;
            hppOutSourceMechanic.ServiceAmount = hppOutSourceMechanicFeeAmount;
            hppOutSourceMechanic.BaseAmountModifierPercentage = 20;
            hppOutSourceMechanic.BaseAmountWithModifierPercentageResult = hppOutSourceMechanicAddInAmount;
            hppOutSourceMechanic.TotalAmount = hppOutSourceMechanic.BaseAmount + hppOutSourceMechanic.ServiceAmount + hppOutSourceMechanic.BaseAmountWithModifierPercentageResult;

            _hppDetailRepository.Add(hppOutSourceMechanic);
            // End calculate HPP outsource mechanic this month

            _unitOfWork.SaveChanges();
        }

        public void DeleteHPP(int headerId, int userId)
        {
            HPPHeader entity = _hppHeaderRepository.GetById(headerId);
            entity.Status = (int)DbConstant.DefaultDataStatus.Deleted;
            entity.ModifyUserId = userId;
            entity.ModifyDate = DateTime.Now;
            _hppHeaderRepository.Update(entity);
        }
    }
}
