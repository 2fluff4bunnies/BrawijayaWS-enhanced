using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System;
using System.Collections.Generic;

namespace BrawijayaWorkshop.View
{
    public interface ISPKHistoryListView : IView
    {
        int CategoryFilter { get; set; }
        string LicenseNumberFilter { get; set; }
        int ContractWorkStatusFilter { get; set; }
        int CustomerFIlter { get; set; }
        DateTime? DateFilterFrom { get; set; }
        DateTime? DateFilterTo { get; set; }
        string CodeFilter { get; set; }

        List<ReferenceViewModel> CategoryDropdownList { get; set; }
        List<SPKViewModel> SPKListData { get; set; }
        SPKViewModel SelectedSPK { get; set; }
        List<SPKStatusItem> ContractWorkStatusDropdownList { get; set; }
        List<CustomerViewModel> CustomerDropdownList { get; set; }

    }
}
