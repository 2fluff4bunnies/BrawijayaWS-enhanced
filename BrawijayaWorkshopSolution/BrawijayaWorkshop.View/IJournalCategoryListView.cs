using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System.Collections.Generic;

namespace BrawijayaWorkshop.View
{
    public interface IJournalCategoryListView : IView
    {
        int ParentId { get; set; }

        List<ReferenceViewModel> ParentDropdownList { get; set; }

        List<ReferenceViewModel> ChildrenListData { get; set; }

        ReferenceViewModel SelectedChildren { get; set; }
    }
}
