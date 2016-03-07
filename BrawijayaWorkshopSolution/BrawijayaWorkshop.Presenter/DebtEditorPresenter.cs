using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.SharedObject.ViewModels;
using BrawijayaWorkshop.View;
using BrawijayaWorkshop.Utils;

namespace BrawijayaWorkshop.Presenter
{
    public class DebtEditorPresenter : BasePresenter<IDebtEditorView, DebtEditorModel>
    {
        public DebtEditorPresenter(IDebtEditorView view, DebtEditorModel model)
            : base(view, model) { }

        public void InitFormData()
        {
            View.ListPaymentMethod = Model.RetrievePaymentMethod();

            if (View.SelectedDebt != null)
            {
                View.Date = View.SelectedPurchasing.Date;
                View.TotalTransaction = View.SelectedPurchasing.TotalPrice;
                View.TotalPaid = View.SelectedPurchasing.TotalHasPaid;
                View.TotalNotPaid = View.SelectedPurchasing.TotalPrice - View.SelectedPurchasing.TotalHasPaid;
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

            if (View.SelectedDebt.Id > 0)
            {
                Model.UpdateDebt(View.SelectedDebt);
            }
            else
            {
                Model.InsertDebt(View.SelectedDebt);
            }
        }
    }
}
