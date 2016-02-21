using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System.Collections.Generic;

namespace BrawijayaWorkshop.View
{
    public interface IVehicleDetailListView : IView
    {
        List<VehicleDetailViewModel> VehicleDetailListData { get; set; }

        VehicleDetailViewModel SelectedVehicleDetail { get; set; }

        VehicleViewModel SelectedVehicle { get; set; }
    }
}
