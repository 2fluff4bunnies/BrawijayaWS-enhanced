using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.View;

namespace BrawijayaWorkshop.Presenter
{
    public class PurchasingListPresenter : BasePresenter<IPurchasingListView, PurchasingListModel>
    {
        public PurchasingListPresenter(IPurchasingListView view, PurchasingListModel model)
            : base(view, model) { }

        public void LoadPurchasing()
        {
            View.PurchasingListData = Model.SearchPurchasing(View.DateFilterFrom, View.DateFilterTo);
        }
    }
}
