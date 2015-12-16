using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Infrastructure.MVP;
using System.Collections.Generic;
using System;

namespace BrawijayaWorkshop.View
{
    public interface IVehicleEditorView : IView
    {
        Vehicle SelectedVehicle { get; set; }

        string Brand { get; set; }

        string Type { get; set; }

        int YearOfPurchase { get; set; }

        string ActiveLicenseNumber { get; set; }

        DateTime ExpirationDate { get; set; }

        int CustomerId { get; set; }

        List<Customer> CustomerList { get; set; }
    }
}
