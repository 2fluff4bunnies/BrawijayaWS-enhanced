using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System;
using System.Collections.Generic;

namespace BrawijayaWorkshop.View
{
    public interface IBalanceJournalListView : IView
    {
        int SelectedMonth { get; set; }
        int SelectedYear { get; set; }

        Dictionary<int, string> ListMonth { get; set; }
        List<int> ListYear { get; set; }

        BalanceJournalViewModel AvailableBalanceJournal { get; set; }
        List<BalanceJournalDetailViewModel> BalanceJournalDetailList { get; set; }

        decimal? ProfitLossDebitTemp { get; set; }
        decimal? ProfitLossCreditTemp { get; set; }

        decimal? ProfitLossDebitResult { get; set; }
        decimal? ProfitLossCreditResult { get; set; }

        decimal? LastDebitTemp { get; set; }
        decimal? LastCreditTemp { get; set; }

        decimal? LastDebitResult { get; set; }
        decimal? LastCreditResult { get; set; }
    }
}
