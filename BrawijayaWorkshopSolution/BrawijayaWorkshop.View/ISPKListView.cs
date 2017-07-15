using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System;
using System.Collections.Generic;

namespace BrawijayaWorkshop.View
{
    public interface ISPKListView : IView
    {
        DateTime DateFrom { get; set; }
        DateTime DateTo { get; set; }

        int ApprovalStatusFilter { get; set; }

        int PrintStatusFilter { get; set; }

        string CodeFilter { get; set; }

        int CategoryFilter { get; set; }

        string LicenseNumberFilter { get; set; }

        int CompletedStatusFilter { get; set; }

        int ContractWorkStatusFilter { get; set; }

        List<ReferenceViewModel> CategoryDropdownList { get; set; }

        List<SPKViewModel> SPKListData { get; set; }

        SPKViewModel SelectedSPK { get; set; }

        List<SPKStatusItem> ApprovalStatusDropdownList { get; set; }

        List<SPKStatusItem> PrintStatusDropdownList { get; set; }

        List<SPKStatusItem> CompletedStatusDropdownList { get; set; }

        List<SPKStatusItem> ContractWorkStatusDropdownList { get; set; }

        string ExportFileName { get; }
    }

    public class SPKStatusItem
    {
        public int Status { get; set; }
        public string Description { get; set; }
    }
}
