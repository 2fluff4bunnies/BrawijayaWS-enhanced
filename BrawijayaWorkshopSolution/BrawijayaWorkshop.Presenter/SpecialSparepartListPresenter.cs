using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.Runtime;
using BrawijayaWorkshop.SharedObject.ViewModels;
using BrawijayaWorkshop.View;
using System.Collections.Generic;

namespace BrawijayaWorkshop.Presenter
{
    public class SpecialSparepartListPresenter : BasePresenter<ISpecialSparepartListView, SpecialSparepartListModel>
    {
        
        public SpecialSparepartListPresenter(ISpecialSparepartListView view, SpecialSparepartListModel model)
            : base(view, model) { }

        //public void InitData()
        //{
            
        //}

        public void LoadSpecialSparepart()
        {
            View.SpecialSparepartListData = Model.SearchWheel(View.NameFilter);
        }

        public void DeleteWheel()
        {
            Model.DeleteWheel(View.SelectedSpecialSparepart, LoginInformation.UserId);
        }
    }
}
