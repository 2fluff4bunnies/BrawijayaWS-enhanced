using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Infrastructure.MVP;
using System;
using System.Collections.Generic;

namespace BrawijayaWorkshop.View
{
    public interface IPurchasingEditorView : IView
    {
        Purchasing SelectedPurchasing { get; set; }

        PurchasingDetail SelectedPurchasingDetail { get; set; }

        DateTime Date { get; set; }
        int SupplierId { get; set; }
        decimal TotalPrice { get; set; }
        List<Supplier> ListSupplier { get; set; }
        List<PurchasingDetail> ListPurchasingDetail { get; set; }
        List<Sparepart> ListSparepart { get; set; }
    }
}
