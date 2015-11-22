using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.Runtime;
using BrawijayaWorkshop.View;

namespace BrawijayaWorkshop.Presenter
{
    public class SparepartListPresenter : BasePresenter<ISparepartListView, SparepartListModel>
    {
        public SparepartListPresenter(ISparepartListView view, SparepartListModel model)
            : base(view, model) { }

        public void InitData()
        {
            View.CategoryDropdownList = Model.GetSparepartCategoryList();
        }

        public void LoadSparepart()
        {
            View.SparepartListData = Model.SearchSparepart(View.CategoryFilter, View.NameFilter);
        }

        public void DeleteSparepart()
        {
            Model.DeleteSparepart(View.SelectedSparepart, LoginInformation.UserId);
        }
    }
}
