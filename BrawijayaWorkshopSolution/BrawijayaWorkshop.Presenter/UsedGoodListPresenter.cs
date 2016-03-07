using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.View;

namespace BrawijayaWorkshop.Presenter
{
    public class UsedGoodListPresenter : BasePresenter<IUsedGoodListView, UsedGoodListModel>
    {
        public UsedGoodListPresenter(IUsedGoodListView view, UsedGoodListModel model)
            : base(view, model) { }

        public void LoadUsedGood()
        {
            View.UsedGoodListData = Model.SearchUsedGood(View.SparepartNameFilter);
        }

        public void DeleteUsedGood()
        {
            Model.DeleteUsedGood(View.SelectedUsedGood);
        }
    }
}
