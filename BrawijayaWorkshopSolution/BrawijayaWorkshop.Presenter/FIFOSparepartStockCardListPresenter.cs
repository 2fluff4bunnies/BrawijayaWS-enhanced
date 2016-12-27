using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.View;

namespace BrawijayaWorkshop.Presenter
{
    public class FIFOSparepartStockCardListPresenter : BasePresenter<IFIFOSparepartStockCardListView, FIFOSparepartStockCardListModel>
    {
        public FIFOSparepartStockCardListPresenter(IFIFOSparepartStockCardListView view, FIFOSparepartStockCardListModel model)
            : base(view, model) { }

        public void LoadFIFOData()
        {
            View.ListStockCard = Model.RetrieveStockCards(View.DateFromFilter, View.DateToFilter, View.SelectedSparepart.Id);
        }
    }
}
