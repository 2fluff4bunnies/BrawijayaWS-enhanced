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
    public class CreditEditorPresenter : BasePresenter<ICreditEditorView, CreditEditorModel>
    {
        public CreditEditorPresenter(ICreditEditorView view, CreditEditorModel model)
            : base(view, model) { }

        public void InitFormData()
        {
            View.ListPaymentMethod = Model.RetrievePaymentMethod();

            if (View.SelectedCredit != null && View.SelectedCredit.Id > 0)
            {
                View.SelectedInvoice = Model.GetSelectedInvoiceByTransaction(View.SelectedCredit.PrimaryKeyValue);
                if (View.SelectedInvoice != null)
                {
                    View.Date = View.SelectedInvoice.CreateDate;
                    View.TotalTransaction = View.SelectedInvoice.TotalPrice;
                    View.TotalPaid = View.SelectedInvoice.TotalHasPaid;
                    View.TotalNotPaid = View.SelectedInvoice.TotalPrice - View.SelectedInvoice.TotalHasPaid;
                    View.CustomerName = View.SelectedInvoice.SPK.Vehicle.Customer.CompanyName;
                    View.PaymentMethodId = View.SelectedCredit.PaymentMethodId.Value;
                    View.TotalPayment = View.SelectedCredit.TotalPayment.AsDecimal();
                }
            }
            else
            {
                View.Date = View.SelectedInvoice.CreateDate;
                View.TotalTransaction = View.SelectedInvoice.TotalPrice;
                View.TotalPaid = View.SelectedInvoice.TotalHasPaid;
                View.TotalNotPaid = View.SelectedInvoice.TotalPrice - View.SelectedInvoice.TotalHasPaid;
                View.CustomerName = View.SelectedInvoice.SPK.Vehicle.Customer.CompanyName;
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
            View.SelectedCredit.PaymentMethodId = View.PaymentMethodId;

            if (View.SelectedCredit.Id > 0)
            {
                Model.UpdateCredit(View.SelectedCredit, LoginInformation.UserId);
            }
            else
            {
                Model.InsertCredit(View.SelectedCredit, View.SelectedInvoice.TotalPrice, LoginInformation.UserId);
            }
        }
    }
}
