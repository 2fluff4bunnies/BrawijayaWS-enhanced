using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System.Collections.Generic;

namespace BrawijayaWorkshop.View
{
    public interface IBalanceBaseView : IView
    {
        int SelectedMonth { get; set; }
        int SelectedYear { get; set; }

        Dictionary<int, string> ListMonth { get; set; }
        List<int> ListYear { get; set; }

        BalanceJournalViewModel AvailableBalanceJournal { get; set; }
    }
}
