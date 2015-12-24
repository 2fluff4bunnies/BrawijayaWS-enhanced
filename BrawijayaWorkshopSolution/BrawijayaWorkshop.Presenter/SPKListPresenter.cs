using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.View;
using System.Collections.Generic;

namespace BrawijayaWorkshop.Presenter
{
    public class SPKListPresenter : BasePresenter<ISPKListView, SPKListModel>
    {
        public SPKListPresenter(ISPKListView view, SPKListModel model)
            : base(view, model) { }

        public void InitData()
        {
            View.CategoryDropdownList = Model.GetSPKCategoryList();
            View.StatusDropdownList = GetStatustDropdownList();
        }

        public void LoadSPK()
        {
            View.SPKListData = Model.SearchSPK(View.LicenseNumberFilter, View.CodeFilter, View.CreateDateFilter, View.DueDateFilter, View.CategoryFilter, (DbConstant.ApprovalStatus)View.StatusFilter);
        }

        public List<SPKStatusItem> GetStatustDropdownList()
        {
            List<SPKStatusItem> result = new List<SPKStatusItem>();

            result.Add(new SPKStatusItem
            {
                Status = (int)DbConstant.ApprovalStatus.Pending,
                Description = "Pending"
            });

            result.Add(new SPKStatusItem
            {
                Status = (int)DbConstant.ApprovalStatus.Approved,
                Description = "Approved"
            });

            result.Add(new SPKStatusItem
            {
                Status = (int)DbConstant.ApprovalStatus.Endorsed,
                Description = "Endorsed"
            });

            result.Add(new SPKStatusItem
            {
                Status = (int)DbConstant.ApprovalStatus.Rejected,
                Description = "Rejected"
            });

            result.Add(new SPKStatusItem
            {
                Status = 9,
                Description = "Semua Status"
            });

            return result;
        }
    }
}
