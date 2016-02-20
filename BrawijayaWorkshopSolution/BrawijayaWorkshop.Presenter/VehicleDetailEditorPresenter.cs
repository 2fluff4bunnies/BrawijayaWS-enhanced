using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.Runtime;
using BrawijayaWorkshop.SharedObject.ViewModels;
using BrawijayaWorkshop.View;

namespace BrawijayaWorkshop.Presenter
{
    public class VehicleDetailEditorPresenter : BasePresenter<IVehicleDetailEditorView, VehicleDetailEditorModel>
    {
        public VehicleDetailEditorPresenter(IVehicleDetailEditorView view, VehicleDetailEditorModel model)
            : base(view, model) { }


        public void InitFormData()
        {
            if (View.SelectedVehicleDetail != null)
            {
                View.LicenseNumber = View.SelectedVehicleDetail.LicenseNumber;
                View.ExpirationDate = View.SelectedVehicleDetail.ExpirationDate;
            }
        }

        public void SaveChanges()
        {
            if (View.SelectedVehicleDetail == null)
            {
                View.SelectedVehicleDetail = new VehicleDetailViewModel();
            }

            View.SelectedVehicleDetail.LicenseNumber = View.LicenseNumber;
            View.SelectedVehicleDetail.ExpirationDate = View.ExpirationDate;

            //todo set status current data to inactive then create new data for history purpose
            //code here
            Model.UpdateVehicleDetail(View.SelectedVehicleDetail, View.SelectedVehicle, LoginInformation.UserId);

        }
    }
}
