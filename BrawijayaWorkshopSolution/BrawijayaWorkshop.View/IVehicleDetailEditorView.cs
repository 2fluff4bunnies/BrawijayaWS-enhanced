using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System;

namespace BrawijayaWorkshop.View
{
    public interface IVehicleDetailEditorView : IView
    {
        VehicleDetailViewModel SelectedVehicleDetail { get; set; }
        string LicenseNumber { get; set; }
        DateTime ExpirationDate { get; set; }
        VehicleViewModel SelectedVehicle { get; set; }
    }
}
