using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.SharedObject.ViewModels;
using BrawijayaWorkshop.View;
using BrawijayaWorkshop.Utils;

namespace BrawijayaWorkshop.Presenter
{
    public class CreditEditorPresenter : BasePresenter<ICreditEditorView, CreditEditorModel>
    {
        public CreditEditorPresenter(ICreditEditorView view, CreditEditorModel model)
            : base(view, model) { }

        public void InitFormData()
        {
            View.ListPaymentMethod = Model.RetrievePaymentMethod();

            if (View.SelectedCredit != null)
            {
                View.Date = View.SelectedCredit.CreateDate;
                View.TotalTransaction =  View.SelectedInvoice.TotalPrice;
                View.TotalPaid = View.SelectedInvoice.TotalHasPaid;
                View.TotalNotPaid = View.SelectedInvoice.TotalPrice - View.SelectedInvoice.TotalHasPaid;
            }
        }

        public void SaveChanges()
        {
            if (View.SelectedCredit == null)
            {
                View.SelectedCredit = new TransactionViewModel();
            }

            View.SelectedCredit.PrimaryKeyValue = View.SelectedInvoice.Id;
            View.SelectedCredit.TotalTransaction = View.TotalTransaction.AsDouble();
            View.SelectedCredit.TotalPayment = View.TotalPayment.AsDouble();

            if (View.SelectedCredit.Id > 0)
            {
                Model.UpdateCredit(View.SelectedCredit);
            }
            else
            {
                Model.InsertCredit(View.SelectedCredit);
            }
        }
    }
}
