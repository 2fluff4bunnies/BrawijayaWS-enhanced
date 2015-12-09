using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Infrastructure.MVP;
using System.Collections.Generic;

namespace BrawijayaWorkshop.View
{
    public interface IVehicleDetailListView : IView
    {
        string LicenseNumberFilter { get; set; }

        List<VehicleDetail> VehicleDetailListData { get; set; }

        VehicleDetail SelectedVehicleDetail { get; set; }

        Vehicle SelectedVehicle { get; set; }
    }
}
