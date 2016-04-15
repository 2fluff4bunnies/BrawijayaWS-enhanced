using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.Runtime;
using BrawijayaWorkshop.View;

namespace BrawijayaWorkshop.Presenter
{
    public class SalesReturnListPresenter : BasePresenter<ISalesReturnListView, SalesReturnListModel>
    {
        public SalesReturnListPresenter(ISalesReturnListView view, SalesReturnListModel model)
            : base(view, model) { }

        public void LoadSalesReturn()
        {
            View.InvoiceListData = Model.SearchInvoiceList(View.DateFilterFrom, View.DateFilterTo);
        }

        public bool IsHasReturnActive()
        {
            return Model.IsHasReturnActive(View.SelectedInvoice.Id);
        }

        public void GetSalesReturn()
        {
            View.SelectedSalesReturn = Model.GetSalesReturn(View.SelectedInvoice.Id);
        }

        public void DeleteData()
        {
            if (View.SelectedSalesReturn != null)
            {
                Model.DeletePurchaseReturn(View.SelectedSalesReturn.Id, LoginInformation.UserId);
            }

        }
        public void GetReturnList()
        {
            View.SelectedSalesReturn.ReturnList = Model.GetReturnListDetail(View.SelectedSalesReturn.Id, View.SelectedInvoice.Id);
            View.SelectedSalesReturn.SalesReturnDetails = Model.RetrieveSalesReturnDetailView(View.SelectedSalesReturn.Id);
        }
    }
}
