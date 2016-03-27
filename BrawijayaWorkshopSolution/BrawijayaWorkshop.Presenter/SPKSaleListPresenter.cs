using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.View;

namespace BrawijayaWorkshop.Presenter
{
    public class SPKSaleListPresenter: BasePresenter<ISPKSaleListView, SPKSaleListModel>
    {
        public SPKSaleListPresenter(ISPKSaleListView view, SPKSaleListModel model)
            : base(view, model) { }

        public void LoadSPK()
        {
            View.SPKListData = Model.SearchSPKSales(View.DateFilterFrom, View.DateFilterTo);
        }
    }
}
