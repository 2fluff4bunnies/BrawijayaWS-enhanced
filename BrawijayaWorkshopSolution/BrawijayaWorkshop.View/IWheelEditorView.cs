using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System.Collections.Generic;

namespace BrawijayaWorkshop.View
{
    public interface IWheelEditorView : IView
    {
        WheelViewModel SelectedWheel { get; set; }

        List<SparepartViewModel> SparepartList { get; set; }
        int SparepartId { get; set; }

        string Category { get; set; }
        string Unit { get; set; }

        string Code { get; set; }
    }
}
