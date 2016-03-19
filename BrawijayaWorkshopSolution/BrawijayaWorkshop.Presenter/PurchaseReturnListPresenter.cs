using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.View;

namespace BrawijayaWorkshop.Presenter
{
    public class PurchaseReturnListPresenter : BasePresenter<IPurchaseReturnListView, PurchaseReturnListModel>
    {
        public PurchaseReturnListPresenter(IPurchaseReturnListView view, PurchaseReturnListModel model)
            : base(view, model) { }

        public void LoadPurchaseReturn()
        {
            View.PurchaseReturnListData = Model.SearchPurchaseReturnList(View.DateFilterFrom, View.DateFilterTo);
        }
    }
}
