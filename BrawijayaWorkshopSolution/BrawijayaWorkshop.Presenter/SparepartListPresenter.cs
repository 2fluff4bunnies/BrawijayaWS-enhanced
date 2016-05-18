using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.Runtime;
using BrawijayaWorkshop.SharedObject.ViewModels;
using BrawijayaWorkshop.View;
using System.Collections.Generic;

namespace BrawijayaWorkshop.Presenter
{
    public class SparepartListPresenter : BasePresenter<ISparepartListView, SparepartListModel>
    {
        public SparepartListPresenter(ISparepartListView view, SparepartListModel model)
            : base(view, model) { }

        public void InitData()
        {
            List<ReferenceViewModel> result = Model.GetSparepartCategoryList();
            result.Insert(0, new ReferenceViewModel
            {
                Id = 0,
                Name = "-- Kategori --",
                Code = "-",
                Value = "-"
            });
            View.CategoryDropdownList = result;
        }

        public void LoadSparepart()
        {
            View.SparepartListData = Model.SearchSparepart(View.CategoryFilter, View.NameFilter);
        }

        public void DeleteSparepart()
        {
            Model.DeleteSparepart(View.SelectedSparepart, LoginInformation.UserId);
        }
    }
}
