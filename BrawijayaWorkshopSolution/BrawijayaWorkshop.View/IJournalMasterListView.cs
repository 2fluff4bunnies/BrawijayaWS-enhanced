using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System.Collections.Generic;

namespace BrawijayaWorkshop.View
{
    public interface IJournalMasterListView : IView
    {
        string NameFilter { get; set; }
        int ParentId { get; set; }

        List<JournalMasterViewModel> ParentDropdownList { get; set; }

        List<JournalMasterViewModel> JournalMasterListData { get; set; }

        JournalMasterViewModel SelectedJournalMaster { get; set; }

        string ExportFileName { get; }
    }
}
