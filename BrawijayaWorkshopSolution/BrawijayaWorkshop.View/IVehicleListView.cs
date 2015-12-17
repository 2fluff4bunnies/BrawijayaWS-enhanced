﻿using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Infrastructure.MVP;
using System.Collections.Generic;

namespace BrawijayaWorkshop.View
{
    public interface IVehicleListView : IView
    {
        Vehicle SelectedVehicle { get; set; }

        string ActiveLicenseNumberFilter { get; set; }

        List<Vehicle> VehicleListData { get; set; }

    }
}