using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.View;

namespace BrawijayaWorkshop.Presenter
{
    public class CreditListPresenter : BasePresenter<ICreditListView, CreditListModel>
    {
        public CreditListPresenter(ICreditListView view, CreditListModel model)
            : base(view, model) { }

        public void LoadSPKList()
        {
            View.InvoiceListData = Model.SearchTransaction(View.DateFromFilter, View.DateToFilter);
        }
    }
}
