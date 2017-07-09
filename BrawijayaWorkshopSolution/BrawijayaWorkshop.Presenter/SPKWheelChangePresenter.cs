using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.Runtime;
using BrawijayaWorkshop.SharedObject.ViewModels;
using BrawijayaWorkshop.Utils;
using BrawijayaWorkshop.View;
using System.Collections.Generic;

namespace BrawijayaWorkshop.Presenter
{
    public class SPKWheelChangePresenter : BasePresenter<ISPKWheelChangeView, SPKEditorModel>
    {
        public SPKWheelChangePresenter(ISPKWheelChangeView view, SPKEditorModel model)
            : base(view, model) { }

        public void InitFormData()
        {
            View.SparepartWheelLookupList = Model.LoadSparepartWheel();

            if (View.VehicleWheelList == null)
            {
                if (View.SelectedSPK != null)
                {
                    View.VehicleWheelList = Model.getCurrentVehicleWheel(View.VehicleId, View.SelectedSPK.Id);
                }
                else
                {
                    View.VehicleWheelList = Model.getCurrentVehicleWheel(View.VehicleId, 0);
                }
            }
        }

        public void SaveChanges()
        {

        }


        public void SetSelectedWheelDetailToChange(int wheelDetailId)
        {
            View.SelectedWheelDetailToChange = Model.GetWheelDetailById(wheelDetailId);
        }

        public void LoadWheelDetail(int sparepartId)
        {
            View.WheelDetailList = Model.RetrieveReadyWheelDetails(sparepartId);
        }

        public VehicleWheelViewModel ResetSelectedWheel(int VehicleWheelId)
        {
            return Model.GetVehicleWHeelById(VehicleWheelId);
        }

    }
}
