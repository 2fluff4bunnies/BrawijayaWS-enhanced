using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.SharedObject.ViewModels;
using BrawijayaWorkshop.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrawijayaWorkshop.Presenter
{
    public class VehicleWheelSwapPresenter : BasePresenter<IVehicleWheelSwapView, VehicleWheelSwapModel>
    {
        public VehicleWheelSwapPresenter(IVehicleWheelSwapView view, VehicleWheelSwapModel model) : base(view, model) { }


        public void InitData()
        {
            var vehicles = Model.GetVehicleList();

            View.VehicleList1 = vehicles;
            View.VehicleList2 = vehicles;
        }

        public List<VehicleWheelViewModel> LoadVehicleWhel(int vehicleId)
        {
            return Model.GetVehicleWheels(vehicleId);
        }
    }
}
