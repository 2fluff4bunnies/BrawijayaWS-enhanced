using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System;
using System.Collections.Generic;

namespace BrawijayaWorkshop.View
{
    public interface IFirstBalanceEditorView : IView
    {
        DateTime FirstBalanceDate { get; set; }

        List<JournalMasterViewModel> JournalList { get; set; }
        BalanceJournalViewModel SelectedFirstBalanceJournal { get; set; }
        BalanceJournalDetailViewModel SelectedFirstBalanceDetailJournal { get; set; }
        List<BalanceJournalDetailViewModel> FirstBalanceJournalDetailList { get; set; }

        List<BalanceJournalDetailViewModel> DeletedDetailList { get; set; }
    }
}
