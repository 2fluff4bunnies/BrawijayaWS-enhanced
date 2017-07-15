using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System.Collections.Generic;

namespace BrawijayaWorkshop.View
{
    public interface IVehicleListView : IView
    {
        VehicleViewModel SelectedVehicle { get; set; }

        string ActiveLicenseNumberFilter { get; set; }

        List<VehicleViewModel> VehicleListData { get; set; }

        string ExportFileName { get; }
    }
}
