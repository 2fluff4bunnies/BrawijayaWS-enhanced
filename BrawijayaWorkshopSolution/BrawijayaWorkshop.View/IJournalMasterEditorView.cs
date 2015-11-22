using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Infrastructure.MVP;
using System.Collections.Generic;

namespace BrawijayaWorkshop.View
{
    public interface IJournalMasterEditorView : IView
    {
        JournalMaster SelectedJournalMaster { get; set; }

        int ParentId { get; set; }

        List<JournalMaster> ParentDropdownList { get; set; }

        string Code { get; set; }

        string JournalName { get; set; }
    }
}
