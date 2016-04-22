using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.View;

namespace BrawijayaWorkshop.Presenter
{
    public class TypeListPresenter : BasePresenter<ITypeListView, TypeListModel>
    {
        public TypeListPresenter(ITypeListView view, TypeListModel model)
            : base(view, model) { }

        public void LoadType()
        {
            View.TypeListData = Model.SearchType(View.NameFilter);
        }

        public void DeleteType()
        {
            Model.DeleteType(View.SelectedType);
        }
    }
}
