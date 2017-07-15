using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System;
using System.Collections.Generic;

namespace BrawijayaWorkshop.View
{
    public interface IPurchasingListView : IView
    {
        DateTime? DateFilterFrom { get; set; }
        DateTime? DateFilterTo { get; set; }
        int PurchasingStatusFilter { get; set; }
        List<PurchasingViewModel> PurchasingListData { get; set; }

        PurchasingViewModel SelectedPurchasing { get; set; }
        List<PurchasingStatusItem> PurchasingStatusList { get; set; }

        string ExportFileName { get; }
    }

    public class PurchasingStatusItem
    {
        public int Status { get; set; }
        public string Description { get; set; }
    }
}
