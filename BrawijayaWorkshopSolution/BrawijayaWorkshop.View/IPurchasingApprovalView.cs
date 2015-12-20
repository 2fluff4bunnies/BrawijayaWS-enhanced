using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System;
using System.Collections.Generic;

namespace BrawijayaWorkshop.View
{
    public interface IPurchasingApprovalView : IView
    {
        Purchasing SelectedPurchasing { get; set; }

        PurchasingDetail SelectedPurchasingDetail { get; set; }

        DateTime Date { get; set; }
        int SupplierId { get; set; }
        decimal TotalPrice { get; set; }
        string SupplierName { get; set; }
        string DateStr { get; set; }
        List<PurchasingDetail> ListPurchasingDetail { get; set; }
        List<Sparepart> ListSparepart { get; set; }
        List<Reference> ListPaymentMethod { get; set; }
        int PaymentMethodId { get; set; }
        decimal TotalHasPaid { get; set; }
    }
}
