using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.Runtime;
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
                View.ActiveLicenseNumber = View.SelectedVehicle.ActiveLicenseNumber;
                View.Brand = View.SelectedVehicle.Brand;
                View.Type = View.SelectedVehicle.Type;
                View.CustomerId = View.SelectedVehicle.CustomerId;
                View.YearOfPurchase = View.SelectedVehicle.YearOfPurchase;
            }
        }

        public void SaveChanges()
        {
            if (View.SelectedVehicle == null)
            {
                View.SelectedVehicle = new Vehicle();
            }

            View.SelectedVehicle.Brand = View.Brand;
            View.SelectedVehicle.Type = View.Type;
            View.SelectedVehicle.CustomerId = View.CustomerId;
            View.SelectedVehicle.ActiveLicenseNumber = View.ActiveLicenseNumber;
            View.SelectedVehicle.YearOfPurchase = View.YearOfPurchase;

            if (View.SelectedVehicle.Id > 0)
            {
                Model.UpdateVehicle(View.SelectedVehicle, LoginInformation.UserId);
            }
            else
            {
                Model.InsertVehicle(View.SelectedVehicle, View.ExpirationDate, LoginInformation.UserId);
            }
        }
    }
}
