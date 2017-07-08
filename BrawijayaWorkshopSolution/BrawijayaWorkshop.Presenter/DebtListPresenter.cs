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
            int paymentStatus = -1;
            if (string.Compare(View.DebtStatusPayment, "Belum Lunas", true) == 0)
            {
                paymentStatus = 0;
            }
            if (string.Compare(View.DebtStatusPayment, "Lunas", true) == 0)
            {
                paymentStatus = 1;
            }
            View.PurchasingListData = Model.SearchTransaction(View.DateFromFilter, View.DateToFilter, paymentStatus);
            
        }
    }
}
