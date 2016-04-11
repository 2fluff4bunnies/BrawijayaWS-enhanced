using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Database.Repositories;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace BrawijayaWorkshop.Model
{
    public class BalanceHelperListModel : AppBaseModel
    {
        private ITransactionRepository _transactionRepository;
        private ITransactionDetailRepository _transactionDetailRepository;
        private IBalanceJournalRepository _balanceJournalRepository;
        private IBalanceJournalDetailRepository _balanceJournalDetailRepository;
        private IJournalMasterRepository _journalMasterRepository;

        public BalanceHelperListModel(ITransactionRepository transactionRepository,
            ITransactionDetailRepository transactionDetailRepository,
            IBalanceJournalRepository balanceJournalRepository,
            IBalanceJournalDetailRepository balanceJournalDetailRepository,
            IJournalMasterRepository journalMasterRepository)
            : base()
        {
            _transactionRepository = transactionRepository;
            _transactionDetailRepository = transactionDetailRepository;
            _balanceJournalRepository = balanceJournalRepository;
            _balanceJournalDetailRepository = balanceJournalDetailRepository;
            _journalMasterRepository = journalMasterRepository;
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

        public List<JournalMasterViewModel> RetrieveAllJournal()
        {
            List<JournalMaster> result = _journalMasterRepository.GetAll().ToList();
            List<JournalMasterViewModel> mappedResult = new List<JournalMasterViewModel>();
            return Map(result, mappedResult);
        }

        public List<BalanceHelperItemViewModel> RetrieveBalanceHelper(int year, int month, int journalId)
        {
            List<BalanceHelperItemViewModel> result = new List<BalanceHelperItemViewModel>();

            JournalMaster currentJournal = _journalMasterRepository.GetById(journalId);
            JournalMasterViewModel mappedCurrentJournal = new JournalMasterViewModel();
            Map(currentJournal, mappedCurrentJournal);

            DateTime firstDay = new DateTime(year, month, 1);
            DateTime lastDay = new DateTime(year, month, DateTime.DaysInMonth(year, month));
            DateTime prevMonth = firstDay.AddDays(-1);

            List<TransactionDetail> listTransaction = _transactionDetailRepository.GetMany(t =>
                t.Parent.TransactionDate >= firstDay && t.Parent.TransactionDate <= lastDay &&
                t.JournalId == journalId &&
                t.Parent.Status == (int)DbConstant.DefaultDataStatus.Active).ToList();
            List<TransactionDetailViewModel> mappedListTransaction = new List<TransactionDetailViewModel>();
            Map(listTransaction, mappedListTransaction);

            BalanceJournal lastJournal = _balanceJournalRepository.GetMany(bj =>
                bj.Month == prevMonth.Month && bj.Year == prevMonth.Year &&
                bj.Status == (int)DbConstant.DefaultDataStatus.Active).FirstOrDefault();

            if (lastJournal != null)
            {
                List<BalanceJournalDetail> lastJournalDetail = _balanceJournalDetailRepository.GetMany(bjd =>
                    bjd.ParentId == lastJournal.Id && bjd.JournalId == journalId).ToList();
                foreach (var item in lastJournalDetail)
                {
                    BalanceHelperItemViewModel firstBalanceItem = new BalanceHelperItemViewModel();
                    firstBalanceItem.TransactionDate = prevMonth;
                    firstBalanceItem.JournalCode = item.Journal.Code;
                    firstBalanceItem.JournalName = item.Journal.Name;
                    firstBalanceItem.Balance = (item.LastDebit ?? 0) - (item.LastCredit ?? 0);
                    result.Add(firstBalanceItem);
                }
            }

            foreach (var transItem in mappedListTransaction)
            {
                decimal prevBalance = 0;
                if(result.Count > 0)
                {
                    prevBalance = result[result.Count - 1].Balance;
                }

                if (IsCurrentJournalValid(transItem.Journal, mappedCurrentJournal.Code))
                {
                    BalanceHelperItemViewModel transBalanceItem = new BalanceHelperItemViewModel();
                    transBalanceItem.TransactionDate = transItem.Parent.TransactionDate;
                    transBalanceItem.JournalCode = transItem.Journal.Code;
                    transBalanceItem.JournalName = transItem.Journal.Name;
                    transBalanceItem.MutationDebit = (transItem.Debit ?? 0);
                    transBalanceItem.MutationCredit = (transItem.Credit ?? 0);
                    transBalanceItem.Balance = (transBalanceItem.MutationDebit - transBalanceItem.MutationCredit) + prevBalance;
                    result.Add(transBalanceItem);
                }
            }

            return result;
        }

        private bool IsCurrentJournalValid(JournalMasterViewModel currentJournal, string codeToCompare)
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
