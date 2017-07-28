using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System;
using System.Collections.Generic;

namespace BrawijayaWorkshop.View
{
    public interface IRecapPurchasingBySupplierView : IView
    {
        DateTime DateFrom { get; set; }
        DateTime DateTo { get; set; }

        int SelectedSupplier { get; set; }
        List<SupplierViewModel> ListSupplier { get; set; }

        List<RecapPurchasingItemViewModel> ListPurchasing { get; set; }
    }
}
