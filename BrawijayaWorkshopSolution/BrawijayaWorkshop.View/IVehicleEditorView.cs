using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System;
using System.Collections.Generic;

namespace BrawijayaWorkshop.View
{
    public interface IVehicleEditorView : IView
    {
        VehicleViewModel SelectedVehicle { get; set; }

        string Brand { get; set; }

        string Type { get; set; }

        int YearOfPurchase { get; set; }

        string ActiveLicenseNumber { get; set; }

        DateTime ExpirationDate { get; set; }

        int CustomerId { get; set; }

        List<CustomerViewModel> CustomerList { get; set; }
    }
}
