using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.View;

namespace BrawijayaWorkshop.Presenter
{
    public class CreditPaymentListPresenter : BasePresenter<ICreditPaymentListView, CreditPaymentListModel>
    {
        public CreditPaymentListPresenter(ICreditPaymentListView view, CreditPaymentListModel model)
            : base(view, model) { }

        public void LoadTransactionList()
        {
            View.TransactionListData = Model.SearchTransactionByTableRef(View.SelectedInvoice.Id);
        }
    }
}
