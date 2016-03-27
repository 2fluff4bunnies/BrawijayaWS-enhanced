using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.SharedObject.ViewModels;
using BrawijayaWorkshop.View;
using BrawijayaWorkshop.Utils;
using BrawijayaWorkshop.Runtime;

namespace BrawijayaWorkshop.Presenter
{
    public class DebtEditorPresenter : BasePresenter<IDebtEditorView, DebtEditorModel>
    {
        public DebtEditorPresenter(IDebtEditorView view, DebtEditorModel model)
            : base(view, model) { }

        public void InitFormData()
        {
            View.ListPaymentMethod = Model.RetrievePaymentMethod();

            if (View.SelectedDebt != null && View.SelectedDebt.Id > 0)
            {
                View.SelectedPurchasing = Model.GetSelectedPurchasingByTransaction(View.SelectedDebt.PrimaryKeyValue);
                if (View.SelectedPurchasing != null)
                {
                    View.Date = View.SelectedPurchasing.Date;
                    View.TotalTransaction = View.SelectedPurchasing.TotalPrice;
                    View.TotalPaid = View.SelectedPurchasing.TotalHasPaid;
                    View.TotalNotPaid = View.SelectedPurchasing.TotalPrice - View.SelectedPurchasing.TotalHasPaid;
                    View.SuppierName = View.SelectedPurchasing.Supplier.Name;
                    View.PaymentMethodId = View.SelectedDebt.PaymentMethodId.Value;
                    View.TotalPayment = View.SelectedDebt.TotalPayment.AsDecimal();
                }
            }
            else
            {
                View.Date = View.SelectedPurchasing.Date;
                View.TotalTransaction = View.SelectedPurchasing.TotalPrice;
                View.TotalPaid = View.SelectedPurchasing.TotalHasPaid;
                View.TotalNotPaid = View.SelectedPurchasing.TotalPrice - View.SelectedPurchasing.TotalHasPaid;
                View.SuppierName = View.SelectedPurchasing.Supplier.Name;
            }
        }

        public void SaveChanges()
        {
            if (View.SelectedDebt == null)
            {
                View.SelectedDebt = new TransactionViewModel();
            }

            View.SelectedDebt.PrimaryKeyValue = View.SelectedPurchasing.Id;
            View.SelectedDebt.TotalTransaction = View.TotalTransaction.AsDouble();
            View.SelectedDebt.TotalPayment = View.TotalPayment.AsDouble();
            View.SelectedDebt.PaymentMethodId = View.PaymentMethodId;

            if (View.SelectedDebt.Id > 0)
            {
                Model.UpdateDebt(View.SelectedDebt, LoginInformation.UserId);
            }
            else
            {
                Model.InsertDebt(View.SelectedDebt,View.SelectedPurchasing.TotalPrice, LoginInformation.UserId);
            }
        }
    }
}
