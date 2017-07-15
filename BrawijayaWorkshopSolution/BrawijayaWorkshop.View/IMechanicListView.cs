using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System.Collections.Generic;

namespace BrawijayaWorkshop.View
{
    public interface IMechanicListView : IView
    {
        string FingerprintIP { get; set; }
        string FingerpringPort { get; set; }

        string MechanicNameFilter { get; set; }

        List<MechanicViewModel> MechanicListData { get; set; }

        MechanicViewModel SelectedMechanic { get; set; }

        string ExportFileName { get; }
    }
}
