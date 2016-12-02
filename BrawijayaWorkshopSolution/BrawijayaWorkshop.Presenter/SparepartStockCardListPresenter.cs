using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.View;

namespace BrawijayaWorkshop.Presenter
{
    public class SparepartStockCardListPresenter : BasePresenter<ISparepartStockCardListView, SparepartStockCardListModel>
    {
        public SparepartStockCardListPresenter(ISparepartStockCardListView view, SparepartStockCardListModel model)
            : base(view, model) { }

        public void LoadSparepart()
        {
            View.ListSparepart = Model.RetrieveAllSpareparts();
        }

        public void LoadStockCard()
        {
            View.ListStockCard = Model.RetrieveStockCards(View.DateFromFilter, View.DateToFilter, View.SelectedSparepartId);
        }
    }
}
