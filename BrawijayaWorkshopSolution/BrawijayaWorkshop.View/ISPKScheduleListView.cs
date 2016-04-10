using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System;
using System.Collections.Generic;

namespace BrawijayaWorkshop.View
{
    public interface ISPKScheduleListView : IView
    {
        SPKScheduleViewModel SelectedSPKSchedule { get; set; }

        int SPKId{ get; set; }
        List<FilterSPKVechile> SPKVehicleList { get; set; }

        int MechanicId { get; set; }
        List<MechanicViewModel> MechanicList { get; set; }

        DateTime CreatedDateFilter { get; set; }

        List<SPKScheduleViewModel> SPKScheduleListData { get; set; }
    }

    public class FilterSPKVechile
    {
        public int Id { get; set; }
        public string SPKCode { get; set; }
        public string ActiveLicenseNumber { get; set; }
    }
}
