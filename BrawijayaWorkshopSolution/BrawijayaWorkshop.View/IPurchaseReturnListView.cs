using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System;
using System.Collections.Generic;

namespace BrawijayaWorkshop.View
{
    public interface IPurchaseReturnListView : IView
    {
        DateTime? DateFilterFrom { get; set; }
        DateTime? DateFilterTo { get; set; }
        int SupplierFilter { get; set; }
        List<PurchaseReturnViewModel> PurchaseReturnListData { get; set; }

        PurchaseReturnViewModel SelectedPurchaseReturn { get; set; }
        List<SupplierViewModel> SupplierFilterList { get; set; }

        string ExportFileName { get; }
    }
}
