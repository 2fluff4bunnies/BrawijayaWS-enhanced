using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.View;

namespace BrawijayaWorkshop.Presenter
{
    public class VehicleEditorPresenter : BasePresenter<IVehicleEditorView, VehicleEditorModel>
    {
        public VehicleEditorPresenter(IVehicleEditorView view, VehicleEditorModel model)
            : base(view, model) { }


        public void InitFormData()
        {
            View.CustomerList = Model.RetrieveCustomer();

            if (View.SelectedVehicle != null)
            {
                View.Brand = View.SelectedVehicle.Brand;
                View.Type = View.SelectedVehicle.Type;
                View.CustomerId = View.SelectedVehicle.CustomerId;
            }
        }

        public void SaveChanges()
        {
            if (View.SelectedVehicle == null)
            {
                View.SelectedVehicle = new Vehicle();
            }

            View.Brand = View.SelectedVehicle.Brand;
            View.Type = View.SelectedVehicle.Type;
            View.CustomerId = View.SelectedVehicle.CustomerId;


            if (View.SelectedVehicle.Id > 0)
            {
                Model.UpdateVehicle(View.SelectedVehicle);
            }
            else
            {
                Model.InsertVehicle(View.SelectedVehicle);
            }
        }
    }
}
