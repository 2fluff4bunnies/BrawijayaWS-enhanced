using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.Runtime;
using BrawijayaWorkshop.SharedObject.ViewModels;
using BrawijayaWorkshop.View;

namespace BrawijayaWorkshop.Presenter
{
    public class VehicleGroupEditorPresenter : BasePresenter<IVehicleGroupEditorView, VehicleGroupEditorModel>
    {
        public VehicleGroupEditorPresenter(IVehicleGroupEditorView view, VehicleGroupEditorModel model)
            : base(view, model) { }

        public void InitFormData()
        {
            View.ListCustomer = Model.RetrieveAllCustomer();

            if(View.SelectedGroup != null)
            {
                View.CustomerId = View.SelectedGroup.CustomerId;
                View.GroupName = View.SelectedGroup.Name;
            }
        }

        public void SaveChanges()
        {
            if(View.SelectedGroup == null)
            {
                View.SelectedGroup = new VehicleGroupViewModel();
            }

            View.SelectedGroup.CustomerId = View.CustomerId;
            View.SelectedGroup.Name = View.GroupName;

            if (View.SelectedGroup.Id > 0)
            {
                Model.UpdateGroup(View.SelectedGroup, LoginInformation.UserId);
            }
            else
            {
                Model.InsertNewGroup(View.SelectedGroup, LoginInformation.UserId);
            }
        }
    }
}
