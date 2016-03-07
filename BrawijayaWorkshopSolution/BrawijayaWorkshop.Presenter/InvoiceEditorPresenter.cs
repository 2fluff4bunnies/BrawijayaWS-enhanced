using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.SharedObject.ViewModels;
using BrawijayaWorkshop.View;
using BrawijayaWorkshop.Utils;

namespace BrawijayaWorkshop.Presenter
{
    public class InvoiceEditorPresenter : BasePresenter<IInvoiceEditorView, InvoiceEditorModel>
    {
        public InvoiceEditorPresenter(IInvoiceEditorView view, InvoiceEditorModel model)
            : base(view, model) { }

        public void InitFormData()
        {
            View.ListPaymentMethod = Model.RetrievePaymentMethod();
            if (View.SelectedInvoice != null)
            {
                View.ListInvoiceDetail = Model.RetrieveInvoiceDetail(View.SelectedInvoice.Id);
                View.Date = View.SelectedInvoice.CreateDate;
                View.TotalTransaction = View.SelectedInvoice.TotalPrice;
                View.CustomerName = View.SelectedInvoice.SPK.Vehicle.Customer.CompanyName;
                View.SelectedTransaction = Model.RetrieveTransaction(View.SelectedInvoice.Id);
                if(View.SelectedTransaction != null)
                {
                    View.TotalPayment = View.SelectedTransaction.TotalPayment.AsDecimal();
                }
            }
        }

        public void SaveChanges()
        {
            if (View.SelectedInvoice == null)
            {
                View.SelectedInvoice = new InvoiceViewModel();
            }
            if (View.SelectedTransaction == null)
            {
                View.SelectedTransaction = new TransactionViewModel();
            }

            View.SelectedTransaction.PrimaryKeyValue = View.SelectedInvoice.Id;
            View.SelectedTransaction.TotalTransaction = View.TotalTransaction.AsDouble();
            View.SelectedTransaction.TotalPayment = View.TotalPayment.AsDouble();

            if (View.SelectedInvoice.Id > 0)
            {
                Model.UpdateInvoice(View.SelectedInvoice, View.ListInvoiceDetail, View.SelectedTransaction);
            }
        }
    }
}
