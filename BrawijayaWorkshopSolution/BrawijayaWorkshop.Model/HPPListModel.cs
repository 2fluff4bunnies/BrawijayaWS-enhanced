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

        private IUnitOfWork _unitOfWork;

        public HPPListModel(IHPPHeaderRepository hppHeaderRepository, IHPPDetailRepository hppDetailRepository,
            IBalanceJournalRepository balanceJournalRepository, IBalanceJournalDetailRepository balanceJournalDetailRepository,
            IJournalMasterRepository journalMasterRepository, IReferenceRepository referenceRepository,
            IPurchasingRepository purchasingRepository, ISparepartRepository sparepartRepository,
            ISparepartDetailRepository sparepartDetailRepository, IUnitOfWork unitOfWork)
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

            // HPP sparepart this month
            double lastSparepartBalance = 0;
            double totalPurchase = 0;
            if(lastJournal != null)
            {
                string stockSparepartCode = stockJournalList.Where(j => j.Code == DbConstant.REF_STOCK_JOURNAL_SPAREPART).FirstOrDefault().Value;
                JournalMaster sparepartStockJournal = _journalMasterRepository.GetMany(jm => jm.Code == stockSparepartCode).FirstOrDefault();
                BalanceJournalDetail details = _balanceJournalDetailRepository.GetMany(d => d.ParentId == lastJournal.Id &&
                    d.JournalId == sparepartStockJournal.Id).FirstOrDefault();
                // persediaan awal (bulan sebelumnya)
                lastSparepartBalance = details.LastDebit.AsDouble();

                // pembelian sparepart
                List<Purchasing> listPurchasing = _purchasingRepository.GetMany(p =>
                    p.Status == (int)DbConstant.PurchasingStatus.Active &&
                    p.Date >= firstDay && p.Date <= lastDay).ToList();
                totalPurchase = listPurchasing.Sum(p => p.TotalPrice).AsDouble();

                // persediaan akhir

            }
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
