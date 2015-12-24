using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Infrastructure.MVP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrawijayaWorkshop.View
{
    public interface ISPKListView : IView
    {
        int ApprovalStatusFilter { get; set; }

        int PrintStatusFilter { get; set; }

        string CodeFilter { get; set; }

        DateTime? CreateDateFilter { get; set; }

        DateTime? DueDateFilter { get; set; }

        int CategoryFilter { get; set; }

        string LicenseNumberFilter { get; set; }

        List<Reference> CategoryDropdownList { get; set; }

        List<SPK> SPKListData { get; set; }

        SPK SelectedSPK { get; set; }

        List<SPKStatusItem> ApprovalStatusDropdownList { get; set; }

        List<SPKStatusItem> PrintStatusDropDownList { get; set; }
    }

    public class SPKStatusItem
    {
        public int Status { get; set; }
        public string Description { get; set; }
    }
}
