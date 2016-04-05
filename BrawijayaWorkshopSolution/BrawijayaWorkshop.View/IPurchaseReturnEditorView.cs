using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System;
using System.Collections.Generic;

namespace BrawijayaWorkshop.View
{
    public interface IPurchaseReturnEditorView : IView
    {
        PurchasingViewModel SelectedPurchasing { get; set; }
        PurchaseReturnViewModel SelectedPurchaseReturn { get; set; }
        DateTime Date { get; set; }
        string SupplierName { get; set; }

        List<ReturnViewModel> ListReturn { get; set; }
        List<PurchaseReturnDetailViewModel> ListPurchaseReturnDetail { get; set; }
    }
}
