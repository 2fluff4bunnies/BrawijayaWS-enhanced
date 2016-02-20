using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System;
using System.Collections.Generic;

namespace BrawijayaWorkshop.View
{
    public interface IPurchasingApprovalView : IView
    {
        PurchasingViewModel SelectedPurchasing { get; set; }

        PurchasingDetailViewModel SelectedPurchasingDetail { get; set; }

        DateTime Date { get; set; }
        int SupplierId { get; set; }
        decimal TotalPrice { get; set; }
        string SupplierName { get; set; }
        string DateStr { get; set; }
        List<PurchasingDetailViewModel> ListPurchasingDetail { get; set; }
        List<SparepartViewModel> ListSparepart { get; set; }
        List<ReferenceViewModel> ListPaymentMethod { get; set; }
        int PaymentMethodId { get; set; }
        decimal TotalHasPaid { get; set; }
    }
}
