using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.View;
using System;

namespace BrawijayaWorkshop.Presenter
{
    public class SPKScheduleListPresenter : BasePresenter<ISPKScheduleListView, SPKScheduleListModel>
    {
        public SPKScheduleListPresenter(ISPKScheduleListView view, SPKScheduleListModel model) : base(view, model) { }


        public void InitData()
        {
            View.MechanicList = Model.LoadMechanic();
            View.CreatedDateFilter = DateTime.Now;

            View.SPKVehicleList = new System.Collections.Generic.List<FilterSPKVechile>();
            var spkList = Model.LoadSPK();
            
            foreach (var item in spkList)
            {
                View.SPKVehicleList.Add(new FilterSPKVechile
                    {
                       Id = item.Id,
                       SPKCode = item.Code,
                       ActiveLicenseNumber = item.Vehicle.ActiveLicenseNumber
                    });
            }
        }

        public void LoadSPKSchedule()
        {
            View.SPKScheduleListData = Model.SearchSPKSchedule(View.MechanicId, View.SPKId, View.CreatedDateFilter);
        }

        public void DeleteSPKSchedule()
        {
            Model.DeleteSPKSchedule(View.SelectedSPKSchedule);
        }
    }
}
