using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Infrastructure.MVP;
using System.Collections.Generic;

namespace BrawijayaWorkshop.View
{
    public interface ISparepartListView : IView
    {
        int CategoryFilter { get; set; }

        string NameFilter { get; set; }

        List<Reference> CategoryDropdownList { get; set; }

        List<Sparepart> SparepartListData { get; set; }

        Sparepart SelectedSparepart { get; set; }
    }
}
