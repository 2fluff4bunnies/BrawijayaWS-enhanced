using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.Runtime;
using BrawijayaWorkshop.SharedObject.ViewModels;
using BrawijayaWorkshop.View;
using System.Collections.Generic;

namespace BrawijayaWorkshop.Presenter
{
    public class WheelListPresenter : BasePresenter<IWheelListView, WheelListModel>
    {
        
        public WheelListPresenter(IWheelListView view, WheelListModel model)
            : base(view, model) { }

        //public void InitData()
        //{
            
        //}

        public void LoadWheel()
        {
            View.WheelListData = Model.SearchWheel(View.NameFilter);
        }

        public void DeleteWheel()
        {
            Model.DeleteWheel(View.SelectedWheel, LoginInformation.UserId);
        }
    }
}
