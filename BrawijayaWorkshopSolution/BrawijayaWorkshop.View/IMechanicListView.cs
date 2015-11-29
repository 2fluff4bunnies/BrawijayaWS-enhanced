using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Infrastructure.MVP;
using System.Collections.Generic;

namespace BrawijayaWorkshop.View
{
    public interface IMechanicListView : IView
    {
        string MechanicNameFilter { get; set; }

        List<Mechanic> MechanicListData { get; set; }

        Mechanic SelectedMechanic { get; set; }
    }
}
