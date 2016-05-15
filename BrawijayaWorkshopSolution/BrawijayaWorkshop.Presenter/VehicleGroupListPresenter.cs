using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.Runtime;
using BrawijayaWorkshop.View;

namespace BrawijayaWorkshop.Presenter
{
    public class VehicleGroupListPresenter : BasePresenter<IVehicleGroupListView, VehicleGroupListModel>
    {
        public VehicleGroupListPresenter(IVehicleGroupListView view, VehicleGroupListModel model)
            : base(view, model) { }

        public void InitFormData()
        {
            View.ListCustomer = Model.RetrieveAllCustomer();
        }

        public void LoadData()
        {
            View.ListVehicleGroupData = Model.RetrieveVehicleGroup(View.SelectedCustomerId, View.GroupNameFilter);
        }

        public void DeleteSelectedGroup()
        {
            Model.DeleteVehicleGroup(View.SelectedGroup, LoginInformation.UserId);
        }
    }
}
