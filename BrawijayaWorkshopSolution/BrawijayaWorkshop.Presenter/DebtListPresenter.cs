using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.View;

namespace BrawijayaWorkshop.Presenter
{
    public class DebtListPresenter : BasePresenter<IDebtListView, DebtListModel>
    {
        public DebtListPresenter(IDebtListView view, DebtListModel model)
            : base(view, model) { }

        public void LoadPurchasingList()
        {
            View.PurchasingListData = Model.SearchTransaction(View.DateFromFilter, View.DateToFilter);
        }
    }
}
