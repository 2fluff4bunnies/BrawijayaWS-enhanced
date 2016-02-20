using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System;
using System.Collections.Generic;

namespace BrawijayaWorkshop.View
{
    public interface IPurchasingEditorView : IView
    {
        PurchasingViewModel SelectedPurchasing { get; set; }

        PurchasingDetailViewModel SelectedPurchasingDetail { get; set; }

        DateTime Date { get; set; }
        int SupplierId { get; set; }
        decimal TotalPrice { get; set; }
        List<SupplierViewModel> ListSupplier { get; set; }
        List<PurchasingDetailViewModel> ListPurchasingDetail { get; set; }
        List<SparepartViewModel> ListSparepart { get; set; }
    }
}
