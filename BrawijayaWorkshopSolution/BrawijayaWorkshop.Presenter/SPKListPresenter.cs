using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.View;

namespace BrawijayaWorkshop.Presenter
{
    public class SPKListPresenter : BasePresenter<ISPKListView, SPKListModel>
    {
        public SPKListPresenter(ISPKListView view, SPKListModel model)
            : base(view, model) { }

        public void InitData()
        {
            View.CategoryDropdownList = Model.GetSPKCategoryList();
        }

        public void LoadSPK()
        {
            View.SPKListData = Model.SearchSPK(View.LicenseNumberFilter, View.CodeFilter, View.CreateDateFilter, View.DueDateFilter, View.CategoryFilter, (DbConstant.ApprovalStatus)View.StatusFilter);
        }
    }
}
