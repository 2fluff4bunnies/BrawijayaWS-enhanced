using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Database.Repositories;
using BrawijayaWorkshop.Infrastructure.Repository;
using BrawijayaWorkshop.SharedObject.ViewModels;
using BrawijayaWorkshop.Utils;
using MoreLinq;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace BrawijayaWorkshop.Model
{
    public class BalanceSheetBaseModel : AppBaseModel
    {
        protected IBalanceJournalRepository _balanceJournalRepository;
        protected IBalanceJournalDetailRepository _balanceJournalDetailRepository;

        protected IJournalMasterRepository _journalMasterRepository;
        protected IReferenceRepository _referenceRepository;

        protected IPurchasingRepository _purchasingRepository;

        protected ISparepartRepository _sparepartRepository;
        protected ISparepartDetailRepository _sparepartDetailRepository;

        protected ITransactionRepository _transactionRepository;
        protected ITransactionDetailRepository _transactionDetailRepository;

        protected IInvoiceRepository _invoiceRepository;

        protected IUnitOfWork _unitOfWork;

        public BalanceSheetBaseModel(IBalanceJournalRepository balanceJournalRepository, IBalanceJournalDetailRepository balanceJournalDetailRepository,
            IJournalMasterRepository journalMasterRepository, IReferenceRepository referenceRepository,
            IPurchasingRepository purchasingRepository, ISparepartRepository sparepartRepository,
            ISparepartDetailRepository sparepartDetailRepository, ITransactionRepository transactionRepository,
            ITransactionDetailRepository transactionDetailRepository,
            IInvoiceRepository invoiceRepository,
            IUnitOfWork unitOfWork)
            : base()
        {
            _balanceJournalRepository = balanceJournalRepository;
            _balanceJournalDetailRepository = balanceJournalDetailRepository;
            _journalMasterRepository = journalMasterRepository;
            _referenceRepository = referenceRepository;
            _purchasingRepository = purchasingRepository;
            _sparepartRepository = sparepartRepository;
            _sparepartDetailRepository = sparepartDetailRepository;
            _transactionRepository = transactionRepository;
            _transactionDetailRepository = transactionDetailRepository;
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

        public BalanceJournalViewModel RetrieveBalanceJournalHeader(int month, int year)
        {
            BalanceJournal result = _balanceJournalRepository.GetMany(bj => bj.Month == month && bj.Year == year &&
                bj.Status == (int)DbConstant.DefaultDataStatus.Active).FirstOrDefault();
            BalanceJournalViewModel mappedResult = new BalanceJournalViewModel();
            return Map(result, mappedResult);
        }

        public List<BalanceJournalDetailViewModel> RetrieveBalanceJournalDetailsByHeaderId(int headerId)
        {
            List<BalanceJournalDetail> result = _balanceJournalDetailRepository.GetMany(bj => bj.ParentId == headerId).ToList();
            List<BalanceJournalDetailViewModel> mappedResult = new List<BalanceJournalDetailViewModel>();
            return Map(result, mappedResult);
        }

        public void RecalculateBalanceJournal(int month, int year, int userId)
        {
            BalanceJournalViewModel prevCalculated = RetrieveBalanceJournalHeader(month, year);
            if (prevCalculated != null)
            {
                DeleteBalanceJournal(prevCalculated.Id, userId);
            }

            DateTime firstDay = new DateTime(year, month, 1);
            DateTime lastDay = new DateTime(year, month, DateTime.DaysInMonth(year, month));
            DateTime prevMonth = firstDay.AddDays(-1);

            List<JournalMaster> listAllJournal = _journalMasterRepository.GetAll().ToList();

            Reference catJournalService = _referenceRepository.GetMany(r => r.Code == DbConstant.REF_CAT_JOURNAL_SERVICE).FirstOrDefault();
            Reference catJournalCost = _referenceRepository.GetMany(r => r.Code == DbConstant.REF_CAT_JOURNAL_COST).FirstOrDefault();
            Reference catJournalIncome = _referenceRepository.GetMany(r => r.Code == DbConstant.REF_CAT_JOURNAL_INCOME).FirstOrDefault();

            List<string> catJournalServiceCodeList = _referenceRepository.GetMany(r => r.ParentId == catJournalService.Id).Select(r => r.Value).ToList();
            List<string> catJournalCostCodeList = _referenceRepository.GetMany(r => r.ParentId == catJournalCost.Id).Select(r => r.Value).ToList();
            List<string> catJournalIncomeCodeList = _referenceRepository.GetMany(r => r.ParentId == catJournalIncome.Id).Select(r => r.Value).ToList();

            List<JournalMaster> listProfitLossJournalParents = listAllJournal.Where(j =>
                catJournalServiceCodeList.Contains(j.Code) ||
                catJournalCostCodeList.Contains(j.Code) ||
                catJournalIncomeCodeList.Contains(j.Code)).ToList();
            List<JournalMasterViewModel> mappedListProfitLossJournalParents = new List<JournalMasterViewModel>();
            Map(listProfitLossJournalParents, mappedListProfitLossJournalParents);

            // calculate neraca
            // ------------------------------------------------------------------------------
            // List semua akun jurnal dari tabel transaksi
            List<TransactionDetail> listTransaction = _transactionDetailRepository.GetMany(t =>
                t.Parent.TransactionDate >= firstDay && t.Parent.TransactionDate <= lastDay &&
                t.Parent.Status == (int)DbConstant.DefaultDataStatus.Active).ToList();

            var journalTransactionList = listTransaction.DistinctBy(t => t.JournalId).Select(t => t.JournalId);
            List<BalanceJournalDetailViewModel> tempListBalanceDetailViewModel = new List<BalanceJournalDetailViewModel>();
            foreach (var item in journalTransactionList)
            {
                BalanceJournalDetailViewModel detailViewModel = new BalanceJournalDetailViewModel();
                detailViewModel.JournalId = item;
                tempListBalanceDetailViewModel.Add(detailViewModel);
            }
            // end init semua akun

            // 1. Ambil Saldo Awal dari Saldo Akhir Bulan Sebelumnya
            BalanceJournal lastJournal = _balanceJournalRepository.GetMany(bj =>
                bj.Month == prevMonth.Month && bj.Year == prevMonth.Year &&
                bj.Status == (int)DbConstant.DefaultDataStatus.Active).FirstOrDefault();

            if (lastJournal != null)
            {
                // check apakah semua jurnal di last journal ada di temp list
                List<BalanceJournalDetail> lastJournalDetail = _balanceJournalDetailRepository.GetMany(bjd => bjd.ParentId == lastJournal.Id).ToList();
                foreach (var item in lastJournalDetail)
                {
                    if (tempListBalanceDetailViewModel.Where(temp => temp.JournalId == item.JournalId).Count() == 0)
                    {
                        JournalMasterViewModel mappedJournal = new JournalMasterViewModel();
                        tempListBalanceDetailViewModel.Add(new BalanceJournalDetailViewModel
                        {
                            Journal = Map(item.Journal, mappedJournal),
                            JournalId = item.JournalId
                        });
                    }
                }

                // update temp list untuk saldo awal
                foreach (var item in tempListBalanceDetailViewModel)
                {
                    BalanceJournalDetail entityDetail = lastJournalDetail.Where(i => i.JournalId == item.JournalId).FirstOrDefault();
                    item.FirstDebit = entityDetail.LastDebit;
                    item.FirstCredit = entityDetail.LastCredit;
                }
            }

            // 2. Ambil mutasi Debet Kredit dari transaksi bulan berjalan
            foreach (var item in listTransaction)
            {
                if (tempListBalanceDetailViewModel.Where(t => t.JournalId == item.JournalId).Count() == 0)
                {
                    tempListBalanceDetailViewModel.Add(new BalanceJournalDetailViewModel
                    {
                        JournalId = item.JournalId
                    });
                }

                BalanceJournalDetailViewModel currentViewModel = tempListBalanceDetailViewModel.Where(t => t.JournalId == item.JournalId).FirstOrDefault();
                int currentIndex = tempListBalanceDetailViewModel.IndexOf(currentViewModel);
                currentViewModel.MutationDebit = currentViewModel.MutationDebit ?? 0;
                currentViewModel.MutationCredit = currentViewModel.MutationCredit ?? 0;
                currentViewModel.ReconciliationDebit = currentViewModel.ReconciliationDebit ?? 0;
                currentViewModel.ReconciliationCredit = currentViewModel.ReconciliationCredit ?? 0;

                if (!item.Parent.IsReconciliation)
                {
                    currentViewModel.MutationCredit += item.Credit ?? 0;
                    currentViewModel.MutationDebit += item.Debit ?? 0;
                }
                else
                {
                    currentViewModel.ReconciliationDebit += item.Debit ?? 0;
                    currentViewModel.ReconciliationCredit += item.Credit ?? 0;
                }

                tempListBalanceDetailViewModel[currentIndex] = currentViewModel;
            }

            // 4. Hitung Saldo Akhir
            foreach (var item in tempListBalanceDetailViewModel)
            {
                // update saldo awal (saldo akhir + mutasi)
                item.BalanceAfterMutationDebit = item.FirstDebit ?? 0 + item.MutationDebit ?? 0;
                item.BalanceAfterMutationCredit = item.FirstCredit ?? 0 + item.MutationCredit ?? 0;

                decimal totalAfterReconciliation =
                    (item.BalanceAfterMutationDebit ?? 0 + item.ReconciliationDebit ?? 0) -
                    (item.BalanceAfterMutationCredit ?? 0 + item.ReconciliationCredit ?? 0);
                if (totalAfterReconciliation > 0)
                {
                    item.BalanceAfterReconciliationDebit = totalAfterReconciliation;
                    item.BalanceAfterReconciliationCredit = 0;
                }
                else
                {
                    item.BalanceAfterReconciliationDebit = 0;
                    item.BalanceAfterReconciliationCredit = Math.Abs(totalAfterReconciliation);
                }

                bool isProfitLoss = false;
                foreach (var iJournalParent in mappedListProfitLossJournalParents)
                {
                    isProfitLoss = IsCurrentJournalValid(item.Journal, iJournalParent.Code);

                    if (isProfitLoss) break;
                }

                JournalMaster currentJournal = listAllJournal.Where(cj => cj.Id == item.JournalId).FirstOrDefault();
                if (isProfitLoss)
                {
                    item.ProfitLossDebit = item.BalanceAfterReconciliationDebit ?? 0;
                    item.ProfitLossCredit = item.BalanceAfterReconciliationCredit ?? 0;
                }
                else
                {
                    item.LastDebit = item.BalanceAfterReconciliationDebit;
                    item.LastCredit = item.BalanceAfterReconciliationCredit;
                }

                item.LastDebit = item.BalanceAfterReconciliationDebit;
                item.LastCredit = item.BalanceAfterReconciliationCredit;
            }

            // 5. Insert Keb Balance Header & Balance Detail
            BalanceJournal newBalanceHeader = new BalanceJournal();
            newBalanceHeader.Month = month;
            newBalanceHeader.Year = year;
            newBalanceHeader.Status = (int)DbConstant.DefaultDataStatus.Active;
            newBalanceHeader.CreateDate = newBalanceHeader.ModifyDate = DateTime.Now;
            newBalanceHeader.CreateUserId = newBalanceHeader.ModifyUserId = userId;
            newBalanceHeader = _balanceJournalRepository.Add(newBalanceHeader);
            _unitOfWork.SaveChanges();

            foreach (var item in tempListBalanceDetailViewModel)
            {
                item.Journal = null;
                BalanceJournalDetail newBalanceDetail = new BalanceJournalDetail();
                Map(item, newBalanceDetail);
                newBalanceDetail.ParentId = newBalanceHeader.Id;
                _balanceJournalDetailRepository.Add(newBalanceDetail);
            }
            _unitOfWork.SaveChanges();
        }

        public void DeleteBalanceJournal(int headerId, int userId)
        {
            BalanceJournal entity = _balanceJournalRepository.GetById(headerId);
            entity.Status = (int)DbConstant.DefaultDataStatus.Deleted;
            entity.ModifyDate = DateTime.Now;
            entity.ModifyUserId = userId;
            _balanceJournalRepository.Update(entity);
            _unitOfWork.SaveChanges();
        }

        protected bool IsCurrentJournalValid(JournalMasterViewModel currentJournal, string codeToCompare)
        {
            if (currentJournal.Code == codeToCompare) return true;

            if (currentJournal.Parent != null)
            {
                return IsCurrentJournalValid(currentJournal.Parent, codeToCompare);
            }

            return false;
        }
    }
}
