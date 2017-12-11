using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrawijayaWorkshop.View
{
    public interface IVehicleWheelSwapView : IView
    {
        List<VehicleViewModel> VehicleList1 { get; set; }
        List<VehicleViewModel> VehicleList2 { get; set; }

        int SelectedVehicle1 { get; set; }
        int SelectedVehicle2 { get; set; }

        List<VehicleWheelViewModel> VehicleWheel1 { get; set; }
        List<VehicleWheelViewModel> VehicleWheel2 { get; set; }
    }
}
