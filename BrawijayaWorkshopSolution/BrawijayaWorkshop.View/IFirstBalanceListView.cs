using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System.Collections.Generic;

namespace BrawijayaWorkshop.View
{
    public interface IFirstBalanceListView : IView
    {
        BalanceJournalViewModel SelectedFirstBalanceJournal { get; set; }
        List<BalanceJournalDetailViewModel> FirstBalanceJournalDetailList { get; set; }

        string ExportFileName { get; }
    }
}
