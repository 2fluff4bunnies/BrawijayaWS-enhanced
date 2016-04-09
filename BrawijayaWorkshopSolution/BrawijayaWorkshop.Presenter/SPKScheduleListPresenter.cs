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
            View.SPKList = Model.LoadSPK();
            View.CreatedDateFilter = DateTime.Now;
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
