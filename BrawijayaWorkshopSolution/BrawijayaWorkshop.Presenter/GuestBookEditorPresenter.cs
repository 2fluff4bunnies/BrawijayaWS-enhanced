using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.Runtime;
using BrawijayaWorkshop.SharedObject.ViewModels;
using BrawijayaWorkshop.View;

namespace BrawijayaWorkshop.Presenter
{
    public class GuestBookEditorPresenter : BasePresenter<IGuestBookEditorView, GuestBookEditorModel>
    {
        public GuestBookEditorPresenter(IGuestBookEditorView view, GuestBookEditorModel model)
            : base(view, model) { }

        public void InitFormData()
        {
            View.VehicleList = Model.GetVehiclesList();
            View.VehicleWheelList = new System.Collections.Generic.List<VehicleWheelViewModel>();

            if (View.SelectedGuestBook != null)
            {
                View.VehicleId = View.SelectedGuestBook.VehicleId;
                View.Description = View.SelectedGuestBook.Description;
            }
        }

        public void SaveChanges()
        {
            if (View.SelectedGuestBook == null)
            {
                View.SelectedGuestBook = new GuestBookViewModel();
            }

            View.SelectedGuestBook.VehicleId = View.VehicleId;
            View.SelectedGuestBook.Description = View.Description;

            if (View.SelectedGuestBook.Id > 0)
            {
                Model.UpdateGuestBook(View.SelectedGuestBook, LoginInformation.UserId);
            }
            else
            {
                Model.InsertGuestBook(View.SelectedGuestBook, LoginInformation.UserId);
            }
        }

        public void LoadDataVehicle()
        {
            View.Brand = View.SelectedVehicle.Brand.Name;
            View.Type = View.SelectedVehicle.Type.Name;
            View.YearOfPurchase = View.SelectedVehicle.YearOfPurchase.ToString();
            View.Customer = View.SelectedVehicle.Customer.CompanyName;
            View.ExpirationDate = Model.GetLicenseNumberExpirationDate(View.SelectedVehicle.ActiveLicenseNumber).ToShortDateString();
            View.VehicleWheelList = Model.getCurrentVehicleWheel(View.VehicleId);
        }
    }

}
