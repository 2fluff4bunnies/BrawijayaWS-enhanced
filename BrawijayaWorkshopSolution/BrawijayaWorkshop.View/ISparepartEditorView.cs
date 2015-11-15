using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Infrastructure.MVP;
using System.Collections.Generic;

namespace BrawijayaWorkshop.View
{
    public interface ISparepartEditorView : IView
    {
        Sparepart SelectedSparepart { get; set; }

        List<Reference> CategoryDropdownList { get; set; }
        List<Reference> UnitDropdownList { get; set; }

        int CategoryId { get; set; }
        int UnitId { get; set; }

        string Code { get; set; }
        string SparepartName { get; set; }
    }
}
