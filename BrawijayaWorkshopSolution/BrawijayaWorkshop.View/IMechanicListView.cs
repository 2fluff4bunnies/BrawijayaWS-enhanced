using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Infrastructure.MVP;
using System.Collections.Generic;

namespace BrawijayaWorkshop.View
{
    public interface IMechanicListView : IView
    {
        string FingerprintIP { get; set; }
        string FingerpringPort { get; set; }

        string MechanicNameFilter { get; set; }

        List<Mechanic> MechanicListData { get; set; }

        Mechanic SelectedMechanic { get; set; }
    }
}
