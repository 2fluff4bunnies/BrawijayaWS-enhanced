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
    public class SPKHistoryDetailPresenter : BasePresenter<ISPKHistoryDetailView, SPKHistoryDetailModel>
    {
        public SPKHistoryDetailPresenter(ISPKHistoryDetailView view, SPKHistoryDetailModel model)
            : base(view, model) { }


        public void InitFormData()
        {
            View.SPKMechanicList = Model.GetInvolvedMechanic(View.SelectedSPK.Id);
            View.SPKSparepartList = Model.GetSPKSparepartList(View.SelectedSPK.Id);
            View.VehicleWheelList = Model.GetCurrentVehicleWheel(View.SelectedSPK.VehicleId, View.SelectedSPK.Id);
        }
    }
}
