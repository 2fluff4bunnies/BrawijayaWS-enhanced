using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System;
using System.Collections.Generic;

namespace BrawijayaWorkshop.View
{
    public interface IVehicleEditorView : IView
    {
        VehicleViewModel SelectedVehicle { get; set; }

        VehicleWheelViewModel SelectedVehicleWheel { get; set; }

        string Brand { get; set; }

        string Type { get; set; }

        int YearOfPurchase { get; set; }

        string ActiveLicenseNumber { get; set; }

        DateTime ExpirationDate { get; set; }

        int CustomerId { get; set; }

        List<CustomerViewModel> CustomerList { get; set; }

        List<VehicleWheelViewModel> VehicleWheelList { get; set; }

        List<VehicleWheelViewModel> VehicleWheelExchangedList { get; set; }

        List<SpecialSparepartDetailViewModel> WheelDetailList { get; set; }
    }
}
