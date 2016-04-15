using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.Runtime;
using BrawijayaWorkshop.View;

namespace BrawijayaWorkshop.Presenter
{
    public class SalesReturnTransactionListPresenter : BasePresenter<ISalesReturnTransactionListView, SalesReturnTransactionListModel>
    {
        public SalesReturnTransactionListPresenter(ISalesReturnTransactionListView view, SalesReturnTransactionListModel model)
            : base(view, model) { }

        public void LoadSalesReturn()
        {
            if (View.SelectedSalesReturn == null)
            {
                View.SalesReturnListData = Model.SearchSalesReturnList(View.DateFilterFrom, View.DateFilterTo, 0);
            }
            else
            {
                View.SalesReturnListData = Model.SearchSalesReturnList(View.DateFilterFrom, View.DateFilterTo, View.SelectedInvoice.Id);
            }

        }

        public void DeleteData()
        {
            if (View.SelectedSalesReturn != null)
            {
                Model.DeleteSalesReturn(View.SelectedSalesReturn.Id, LoginInformation.UserId);
            }

        }

        public void GetReturnList()
        {
            View.ListReturnDetail = Model.GetReturnListDetail(View.SelectedSalesReturn.Id, View.SelectedInvoice.Id);
        }
    }
}
