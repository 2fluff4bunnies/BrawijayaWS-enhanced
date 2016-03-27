using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System;
using System.Collections.Generic;

namespace BrawijayaWorkshop.View
{
    public interface ISPKScheduleEditorView : IView
    {
        SPKScheduleViewModel SelectedSPKSchedule { get; set; }

        string SPKVehicleCustomer{ get; set; }
        string SPKCategory { get; set; }
        string SPKDescription { get; set; }

        int SPKId { get; set; }
        List<SPKViewModel> SPKList { get; set; }

        int MechanicId { get; set; }
        List<MechanicViewModel> MechanicList { get; set; }

        string Description { get; set; }

    }
}
