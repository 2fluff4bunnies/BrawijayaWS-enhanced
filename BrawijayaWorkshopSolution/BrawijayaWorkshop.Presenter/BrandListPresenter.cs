using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.View;

namespace BrawijayaWorkshop.Presenter
{
    public class BrandListPresenter : BasePresenter<IBrandListView, BrandListModel>
    {
        public BrandListPresenter(IBrandListView view, BrandListModel model)
            : base(view, model) { }

        public void LoadBrand()
        {
            View.BrandListData = Model.SearchBrand(View.NameFilter);
        }

        public void DeleteBrand()
        {
            Model.DeleteBrand(View.SelectedBrand);
        }
    }
}
