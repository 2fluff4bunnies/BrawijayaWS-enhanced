using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System;
using System.Collections.Generic;

namespace BrawijayaWorkshop.View
{
    public interface ISPKWheelChangeView : IView
    {
        SPKViewModel SelectedSPK { get; set; }
        List<SparepartViewModel> SparepartWheelLookupList { get; set; }
        List<SpecialSparepartDetailViewModel> WheelDetailList { get; set; }
        List<SpecialSparepartDetailViewModel> WheelDetailChangedList { get; set; }
        List<VehicleWheelViewModel> VehicleWheelList { get; set; }
        VehicleWheelViewModel SelectedVehicleWheel { get; set; }
        SpecialSparepartDetailViewModel SelectedWheelDetailToChange { get; set; }
        SparepartViewModel SelectedSparepartWheel { get; set; }

        int VehicleId { get; set; }
        string SelectedWheelName { get; set; }
        string SelectedWHeelSerialNumber { get; set; }
        string SelectedWHeelSparepartCode { get; set; }
        decimal Price { get; set; }
    }
}
