﻿using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.View;

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
