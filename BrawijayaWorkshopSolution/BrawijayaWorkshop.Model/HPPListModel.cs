using BrawijayaWorkshop.Database.Repositories;
using BrawijayaWorkshop.Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace BrawijayaWorkshop.Model
{
    public class HPPListModel : BalanceSheetBaseModel
    {
        public HPPListModel(IBalanceJournalRepository balanceJournalRepository,
            IBalanceJournalDetailRepository balanceJournalDetailRepository,
            IJournalMasterRepository journalMasterRepository, IReferenceRepository referenceRepository,
            IPurchasingRepository purchasingRepository, ISparepartRepository sparepartRepository,
            ISparepartDetailRepository sparepartDetailRepository, ITransactionRepository transactionRepository,
            ITransactionDetailRepository transactionDetailRepository,
            IHPPHeaderRepository hppHeaderRepository, IHPPDetailRepository hppDetailRepository,
            IInvoiceRepository invoiceRepository,
            IUnitOfWork unitOfWork)
            : base(balanceJournalRepository, balanceJournalDetailRepository, journalMasterRepository,
                   referenceRepository, purchasingRepository, sparepartRepository, sparepartDetailRepository,
                   transactionRepository, transactionDetailRepository, hppHeaderRepository,
                   hppDetailRepository, invoiceRepository, unitOfWork) { }

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
    }
}
