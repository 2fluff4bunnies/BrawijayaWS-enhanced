using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.Runtime;
using BrawijayaWorkshop.View;

namespace BrawijayaWorkshop.Presenter
{
    public class MechanicListPresenter : BasePresenter<IMechanicListView, MechanicListModel>
    {
        public MechanicListPresenter(IMechanicListView view, MechanicListModel model)
            : base(view, model) { }

        public void LoadMechanic()
        {
            View.FingerprintIP = Model.GetFingerprintIpAddress();
            View.FingerpringPort = Model.GetFingerprintPort();
            View.MechanicListData = Model.SearchMechanic(View.MechanicNameFilter);
        }

        public void DeleteMechanic()
        {
            Model.DeleteMechanic(View.SelectedMechanic, LoginInformation.UserId);
        }
    }
}
