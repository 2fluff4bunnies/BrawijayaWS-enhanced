using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System.Collections.Generic;

namespace BrawijayaWorkshop.View
{
    public interface ISparepartEditorView : IView
    {
        SparepartViewModel SelectedSparepart { get; set; }

        List<ReferenceViewModel> CategoryDropdownList { get; set; }
        List<ReferenceViewModel> UnitDropdownList { get; set; }

        int CategoryId { get; set; }
        int UnitId { get; set; }

        string Code { get; set; }
        string SparepartName { get; set; }
        bool IsSpecialSparepart { get; set; }
    }
}
