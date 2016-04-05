using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System.Collections.Generic;

namespace BrawijayaWorkshop.View
{
    public interface ISPKViewDetailView : IView
    {
        string ApprovalEmailBody { get; set; }
        string ApprovalEmailFrom { get; set; }
        string ApprovalEmailTo { get; set; }

        SPKViewModel SelectedSPK { get; set; }
        SPKViewModel ParentSPK { get; set; }

        List<VehicleWheelViewModel> VehicleWheelList { get; set; }

        List<SPKDetailSparepartViewModel> SPKSparepartList { get; set; }
        List<SPKDetailSparepartDetailViewModel> SPKSparepartDetailList { get; set; }
    }
}
