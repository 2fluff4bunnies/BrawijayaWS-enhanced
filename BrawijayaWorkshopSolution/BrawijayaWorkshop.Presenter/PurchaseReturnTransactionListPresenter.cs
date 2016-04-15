using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.Runtime;
using BrawijayaWorkshop.View;

namespace BrawijayaWorkshop.Presenter
{
    public class PurchaseReturnTransactionListPresenter : BasePresenter<IPurchaseReturnTransactionListView, PurchaseReturnTransactionListModel>
    {
        public PurchaseReturnTransactionListPresenter(IPurchaseReturnTransactionListView view, PurchaseReturnTransactionListModel model)
            : base(view, model) { }

        public void LoadPurchaseReturn()
        {
            if(View.SelectedPurchaseReturn == null)
            {
                View.PurchaseReturnListData = Model.SearchPurchaseReturnList(View.DateFilterFrom, View.DateFilterTo, 0);
            }
            else
            {
                View.PurchaseReturnListData = Model.SearchPurchaseReturnList(View.DateFilterFrom, View.DateFilterTo, View.SelectedPurchasing.Id);
            }
            
        }

        public void DeleteData()
        {
            if (View.SelectedPurchaseReturn != null)
            {
                Model.DeletePurchaseReturn(View.SelectedPurchaseReturn.Id, LoginInformation.UserId);
            }

        }

        public void GetReturnList()
        {
            View.ListReturnDetail = Model.GetReturnListDetail(View.SelectedPurchaseReturn.Id, View.SelectedPurchasing.Id);
        }
    }
}
