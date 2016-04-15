using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.Runtime;
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

        public void GetPurchaseReturn()
        {
            View.SelectedPurchaseReturn = Model.GetPurchaseReturn(View.SelectedPurchasing.Id);
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
            View.SelectedPurchaseReturn.ReturnList = Model.GetReturnListDetail(View.SelectedPurchaseReturn.Id, View.SelectedPurchasing.Id);
        }
    }
}
