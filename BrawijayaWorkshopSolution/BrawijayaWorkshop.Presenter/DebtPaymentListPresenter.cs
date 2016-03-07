using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.View;

namespace BrawijayaWorkshop.Presenter
{
    public class DebtPaymentListPresenter : BasePresenter<IDebtPaymentListView, DebtPaymentListModel>
    {
        public DebtPaymentListPresenter(IDebtPaymentListView view, DebtPaymentListModel model)
            : base(view, model) { }

        public void LoadTransactionList()
        {
            View.TransactionListData = Model.SearchTransactionByTableRef(View.SelectedPurchasing.Id);
        }
    }
}
