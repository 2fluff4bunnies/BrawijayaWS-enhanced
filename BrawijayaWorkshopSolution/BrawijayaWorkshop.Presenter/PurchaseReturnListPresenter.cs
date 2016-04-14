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
            View.PurchasingListData = Model.SearchPurchasingList(View.DateFilterFrom, View.DateFilterTo);
        }

        public bool IsHasReturnActive()
        {
            return Model.IsHasReturnActive(View.SelectedPurchasing.Id);
        }
    }
}
