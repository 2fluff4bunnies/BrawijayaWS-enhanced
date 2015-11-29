using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.Runtime;
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
                View.SelectedStatus = View.SelectedVehicleDetail.Status;
            }
        }

        public void SaveChanges()
        {
            if (View.SelectedVehicleDetail == null)
            {
                View.SelectedVehicleDetail = new VehicleDetail();
            }

            View.SelectedVehicleDetail.LicenseNumber = View.LicenseNumber;
            View.SelectedVehicleDetail.ExpirationDate = View.ExpirationDate;
            View.SelectedVehicleDetail.Status = View.SelectedStatus;

            //todo set status current data to inactive then create new data for history purpose
            //code here
            Model.InsertVehicleDetail(View.SelectedVehicleDetail, LoginInformation.UserId);

        }
    }
}
