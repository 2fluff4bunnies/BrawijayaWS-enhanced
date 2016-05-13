using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System;
using System.Collections.Generic;

namespace BrawijayaWorkshop.View
{
    public interface ISPKHistoryDetailView : IView
    {
        SPKViewModel SelectedSPK { get; set; }
        List<VehicleWheelViewModel> VehicleWheelList { get; set; }
        List<SPKDetailSparepartViewModel> SPKSparepartList { get; set; }
        List<MechanicViewModel> SPKMechanicList { get; set; }
    }
}
