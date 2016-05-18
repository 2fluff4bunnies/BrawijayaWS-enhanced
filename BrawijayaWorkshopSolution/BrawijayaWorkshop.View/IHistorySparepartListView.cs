using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System;
using System.Collections.Generic;

namespace BrawijayaWorkshop.View
{
    public interface IHistorySparepartListView : IView
    {
        DateTime? DateFromFilter { get; set; }
        DateTime? DateToFilter { get; set; }
        int VehicleFilter { get; set; }
        List<SparepartViewModel> SparepartFilterList { get; set; }
        List<VehicleViewModel> VehicleFilterList { get; set; }
        int SparepartFilter { get; set; }
        List<SPKDetailSparepartViewModel> SparepartListData { get; set; }
    }
}
