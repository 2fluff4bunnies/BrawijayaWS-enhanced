using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System.Collections.Generic;

namespace BrawijayaWorkshop.View
{
    public interface IJournalCategoryEditorView : IView
    {
        int SelectedParentId { get; set; }
        List<ReferenceViewModel> ParentDropdownList { get; set; }

        JournalMasterViewModel SelectedJournal { get; set; }
        List<JournalMasterViewModel> JournalMasterList { get; set; }

        ReferenceViewModel SelectedChildren { get; set; }

        string Code { get; set; }
        string CategoryName { get; set; }
        string CategoryDescription { get; set; }
    }
}
