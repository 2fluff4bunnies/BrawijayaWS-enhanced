using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.View;

namespace BrawijayaWorkshop.Presenter
{
    public class PurchaseReturnTransactionListPresenter : BasePresenter<IPurchaseReturnTransactionListView, PurchaseReturnTransactionListModel>
    {
        public PurchaseReturnTransactionListPresenter(IPurchaseReturnTransactionListView view, PurchaseReturnTransactionListModel model)
            : base(view, model) { }

        public void LoadPurchaseReturn()
        {
            View.PurchaseReturnListData = Model.SearchPurchaseReturnList(View.DateFilterFrom, View.DateFilterTo, View.SelectedPurchasing.Id);
        }
    }
}
