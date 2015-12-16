using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Infrastructure.MVP;
using System;
using System.Collections.Generic;

namespace BrawijayaWorkshop.View
{
    public interface IVehicleDetailEditorView : IView
    {
        VehicleDetail SelectedVehicleDetail { get; set; }
        string LicenseNumber { get; set; }
        DateTime ExpirationDate { get; set; }
        Vehicle SelectedVehicle { get; set; }
    }
}
