using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System.Collections.Generic;

namespace BrawijayaWorkshop.View
{
    public interface IBalanceHelperListView : IView
    {
        int SelectedMonth { get; set; }
        int SelectedYear { get; set; }

        Dictionary<int, string> ListMonth { get; set; }
        List<int> ListYear { get; set; }

        int SelectedJournal { get; set; }
        List<JournalMasterViewModel> ListJournal { get; set; }

        List<BalanceHelperItemViewModel> ListHelper { get; set; }
    }
}
