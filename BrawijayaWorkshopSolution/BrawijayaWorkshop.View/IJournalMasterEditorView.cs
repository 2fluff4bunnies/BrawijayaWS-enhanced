using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System.Collections.Generic;

namespace BrawijayaWorkshop.View
{
    public interface IJournalMasterEditorView : IView
    {
        JournalMasterViewModel SelectedJournalMaster { get; set; }

        int ParentId { get; set; }

        List<JournalMasterViewModel> ParentDropdownList { get; set; }

        string Code { get; set; }

        string JournalName { get; set; }
    }
}
