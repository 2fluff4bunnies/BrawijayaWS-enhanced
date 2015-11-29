using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.View;

namespace BrawijayaWorkshop.Presenter
{
    public class MechanicListPresenter : BasePresenter<IMechanicListView, MechanicListModel>
    {
        public MechanicListPresenter(IMechanicListView view, MechanicListModel model)
            : base(view, model) { }

        public void LoadMechanic()
        {
            View.MechanicListData = Model.SearchMechanic(View.MechanicNameFilter);
        }

        public void DeleteMechanic()
        {
            Model.DeleteMechanic(View.SelectedMechanic);
        }
    }
}
