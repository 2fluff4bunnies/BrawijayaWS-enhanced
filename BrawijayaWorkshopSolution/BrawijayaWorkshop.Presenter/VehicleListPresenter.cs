using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.View;

namespace BrawijayaWorkshop.Presenter
{
    public class VehicleListPresenter : BasePresenter<IVehicleListView, VehicleListModel>
    {
        public VehicleListPresenter(IVehicleListView view, VehicleListModel model) : base(view, model) { }

        public void LoadVehicle()
        {
            View.VehicleListData = Model.SearchVehicle(View.ActiveLicenseNumberFilter);
        }

        public void DeleteVehicle()
        {
            Model.DeleteVehicle(View.SelectedVehicle);
        }
    }
}
