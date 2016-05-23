using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.Runtime;
using BrawijayaWorkshop.View;

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
                View.PaymentMethodId = View.SelectedPurchasing.PaymentMethodId;
                View.ListPurchasingDetail = Model.RetrievePurchasingDetail(View.SelectedPurchasing.Id);
                View.ListPaymentMethod = Model.RetrievePaymentMethod();                
            }
        }

        public void Approve()
        {
            View.SelectedPurchasing.PaymentMethodId = View.PaymentMethodId;
            View.SelectedPurchasing.TotalHasPaid = View.TotalHasPaid;
            Model.Approve(View.SelectedPurchasing, LoginInformation.UserId);
        }

        public void Reject()
        {
            Model.Reject(View.SelectedPurchasing, LoginInformation.UserId);
        }
    }
}
