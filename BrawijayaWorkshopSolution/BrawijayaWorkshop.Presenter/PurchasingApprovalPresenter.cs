using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.Runtime;
using BrawijayaWorkshop.SharedObject.ViewModels;
using BrawijayaWorkshop.View;
using System.Collections.Generic;

namespace BrawijayaWorkshop.Presenter
{
    public class PurchasingApprovalPresenter : BasePresenter<IPurchasingApprovalView, PurchasingApprovalModel>
    {
        public PurchasingApprovalPresenter(IPurchasingApprovalView view, PurchasingApprovalModel model)
            : base(view, model) { }

        public void InitFormData()
        {
            View.ListSparepart = Model.RetrieveSparepart();
            if (View.SelectedPurchasing != null)
            {
                View.Date = View.SelectedPurchasing.Date;
                View.SupplierId = View.SelectedPurchasing.SupplierId;
                View.TotalPrice = View.SelectedPurchasing.TotalPrice;
                View.DateStr = View.SelectedPurchasing.Date.ToString("dd-MM-yyyy");
                View.SupplierName = View.SelectedPurchasing.Supplier.Name;
                View.ListPurchasingDetail = Model.RetrievePurchasingDetail(View.SelectedPurchasing.Id);
            }
        }

        public void Approve()
        {
            Model.Approve(View.SelectedPurchasing);
        }

        public void Reject()
        {
            Model.Reject(View.SelectedPurchasing);
        }
    }
}
