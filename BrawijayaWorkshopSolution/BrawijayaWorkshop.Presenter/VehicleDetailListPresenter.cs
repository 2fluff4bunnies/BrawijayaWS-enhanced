using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrawijayaWorkshop.Presenter
{
    public class VehicleDetailListPresenter : BasePresenter<IVehicleDetailListView, VehicleDetailListModel>
    {
       
        public VehicleDetailListPresenter(IVehicleDetailListView view, VehicleDetailListModel model)
            : base(view, model) { }

        public void LoadVehicleDetail()
        {
            View.VehicleDetailListData = Model.SearchVehicleDetail(View.SelectedVehicle.Id);
        }
    }
}
