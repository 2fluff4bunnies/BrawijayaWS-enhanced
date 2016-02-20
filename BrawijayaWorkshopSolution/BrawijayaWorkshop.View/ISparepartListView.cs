using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System.Collections.Generic;

namespace BrawijayaWorkshop.View
{
    public interface ISparepartListView : IView
    {
        int CategoryFilter { get; set; }

        string NameFilter { get; set; }

        List<ReferenceViewModel> CategoryDropdownList { get; set; }

        List<SparepartViewModel> SparepartListData { get; set; }

        SparepartViewModel SelectedSparepart { get; set; }
    }
}
