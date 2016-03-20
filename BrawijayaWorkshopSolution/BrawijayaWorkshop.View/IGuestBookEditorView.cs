using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System;
using System.Collections.Generic;

namespace BrawijayaWorkshop.View
{
    public interface IGuestBookEditorView : IView
    {
        int VehicleId { get; set; }

        List<VehicleViewModel> VehicleList { get; set; }

        GuestBookViewModel SelectedGuestBook { get; set; }

        string Description { get; set; }

        List<VehicleWheelViewModel> VehicleWheelList { get; set; }

        string Brand { get; set; }

        string Type { get; set; }

        string YearOfPurchase { get; set; }

        string ExpirationDate { get; set; }

        string Customer { get; set; }

        VehicleViewModel SelectedVehicle { get; set; }
    }
}
