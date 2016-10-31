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
    public class JournalTransactionListModel : AppBaseModel
    {
        private ITransactionRepository _transactionRepository;
        private ITransactionDetailRepository _transactionDetailRepository;

        public JournalTransactionListModel(ITransactionRepository transactionRepository,
            ITransactionDetailRepository transactionDetailRepository)
            : base()
        {
            _transactionDetailRepository = transactionDetailRepository;
            _transactionRepository = transactionRepository;
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

        public List<TransactionDetailViewModel> RetrieveAllTransaction(int month, int year)
        {
            DateTime firstDay = new DateTime(year, month, 1);
            //DateTime lastDay = new DateTime(year, month, DateTime.DaysInMonth(year, month));
            DateTime lastDay = firstDay.AddMonths(1).AddSeconds(-1);

            List<TransactionDetail> result = _transactionDetailRepository.GetMany(t =>
                t.Parent.TransactionDate >= firstDay && t.Parent.TransactionDate <= lastDay &&
                t.Parent.Status == (int)DbConstant.DefaultDataStatus.Active).ToList();

            List<TransactionDetailViewModel> mappedResult = new List<TransactionDetailViewModel>();
            return Map(result, mappedResult);
        }
    }
}
