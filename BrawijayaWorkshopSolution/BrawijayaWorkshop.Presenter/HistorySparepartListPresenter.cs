using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.SharedObject.ViewModels;
using BrawijayaWorkshop.View;
using System;

namespace BrawijayaWorkshop.Presenter
{
    public class HistorySparepartListPresenter : BasePresenter<IHistorySparepartListView, HistorySparepartListModel>
    {
        public HistorySparepartListPresenter(IHistorySparepartListView view, HistorySparepartListModel model)
            : base(view, model) { }

        public void InitData()
        {
            View.DateFromFilter = DateTime.Now;
            View.DateToFilter = DateTime.Now;
            View.SparepartFilterList = Model.GetAllSparepart();
            View.VehicleFilterList = Model.GetAllVehicle();
        }

        public void LoadHistorySparepartList()
        {
            View.SparepartListData = Model.SearchHistorySparepart(View.DateFromFilter, View.DateToFilter, View.VehicleFilter, View.SparepartFilter);
        }
    }
}
