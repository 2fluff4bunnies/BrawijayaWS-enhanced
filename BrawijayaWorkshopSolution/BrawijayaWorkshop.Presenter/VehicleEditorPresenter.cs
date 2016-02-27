using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.Runtime;
using BrawijayaWorkshop.SharedObject.ViewModels;
using BrawijayaWorkshop.View;

namespace BrawijayaWorkshop.Presenter
{
    public class VehicleEditorPresenter : BasePresenter<IVehicleEditorView, VehicleEditorModel>
    {
        public VehicleEditorPresenter(IVehicleEditorView view, VehicleEditorModel model)
            : base(view, model) { }


        public void InitFormData()
        {
            View.CustomerList = Model.RetrieveCustomers();
            View.WheelDetailList = Model.RetrieveWheelDetails();

            if (View.SelectedVehicle != null)
            {
                View.ActiveLicenseNumber = View.SelectedVehicle.ActiveLicenseNumber;
                View.Brand = View.SelectedVehicle.Brand;
                View.Type = View.SelectedVehicle.Type;
                View.CustomerId = View.SelectedVehicle.CustomerId;
                View.YearOfPurchase = View.SelectedVehicle.YearOfPurchase;
                View.VehicleWheelList = Model.getCurrentVehicleWheel(View.SelectedVehicle.Id);
            }

            View.VehicleWheelExchangedList = new System.Collections.Generic.List<VehicleWheelViewModel>();
        }

        public void SaveChanges()
        {
            if (View.SelectedVehicle == null)
            {
                View.SelectedVehicle = new VehicleViewModel();
            }

            View.SelectedVehicle.Brand = View.Brand;
            View.SelectedVehicle.Type = View.Type;
            View.SelectedVehicle.CustomerId = View.CustomerId;
            View.SelectedVehicle.ActiveLicenseNumber = View.ActiveLicenseNumber;
            View.SelectedVehicle.YearOfPurchase = View.YearOfPurchase;

            if (View.SelectedVehicle.Id > 0)
            {
                Model.UpdateVehicle(View.SelectedVehicle, LoginInformation.UserId, View.VehicleWheelList, View.VehicleWheelExchangedList);
            }
            else
            {
                Model.InsertVehicle(View.SelectedVehicle, View.ExpirationDate, LoginInformation.UserId);
            }
        }

        public VehicleWheelViewModel IsWheelUsedByOtherVehicle(int wheelDetailId)
        {
            return Model.IsWheelUsedByOtherVehicle(wheelDetailId, View.SelectedVehicle.Id);
        }

        public int GetCurrentInstalledWheel(int wheelDetailId)
        {
            return Model.GetCurrentWheelDetailId(wheelDetailId);
        }

    }
}
