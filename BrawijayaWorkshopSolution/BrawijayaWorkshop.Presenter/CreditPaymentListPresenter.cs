using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.Runtime;
using BrawijayaWorkshop.View;

namespace BrawijayaWorkshop.Presenter
{
    public class CreditPaymentListPresenter : BasePresenter<ICreditPaymentListView, CreditPaymentListModel>
    {
        public CreditPaymentListPresenter(ICreditPaymentListView view, CreditPaymentListModel model)
            : base(view, model) { }

        public void LoadTransactionList()
        {
            if (View.SelectedInvoice != null)
            {
                //get latest Invoice info
                View.SelectedInvoice = Model.GetLatestInvoiceInfo(View.SelectedInvoice.Id);

                View.CustomerName = View.SelectedInvoice.SPK.Vehicle.Customer.CompanyName;
                View.TransactionDate = View.SelectedInvoice.CreateDate;
                View.TotalPrice = View.SelectedInvoice.TotalPrice;
                View.TotalHasPaid = View.SelectedInvoice.TotalHasPaid;
                View.TotalNotPaid = View.SelectedInvoice.TotalPrice - View.SelectedInvoice.TotalHasPaid;
            }
            View.TransactionListData = Model.SearchTransactionByTableRefPK(View.SelectedInvoice.Id);
        }

        public void DeleteData()
        {
            Model.DeleteCredit(View.SelectedTransaction, LoginInformation.UserId);
        }
    }
}
