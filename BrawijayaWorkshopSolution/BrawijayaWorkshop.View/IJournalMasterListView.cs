using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Infrastructure.MVP;
using System.Collections.Generic;

namespace BrawijayaWorkshop.View
{
    public interface IJournalMasterListView : IView
    {
        string NameFilter { get; set; }
        int ParentId { get; set; }

        List<JournalMaster> ParentDropdownList { get; set; }

        List<JournalMaster> JournalMasterListData { get; set; }

        JournalMaster SelectedJournalMaster { get; set; }
    }
}
