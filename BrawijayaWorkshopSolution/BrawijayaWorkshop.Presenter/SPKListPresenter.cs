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
            View.ApprovalStatusDropdownList = GetApprovalStatusDropdownList();
            View.PrintStatusDropDownList = GetPrintStatusDropdownList();
        }

        public void LoadSPK()
        {
            View.SPKListData = Model.SearchSPK(View.LicenseNumberFilter, View.CodeFilter, View.CreateDateFilter, View.DueDateFilter, View.CategoryFilter, (DbConstant.ApprovalStatus)View.ApprovalStatusFilter, (DbConstant.SPKPrintStatus)View.PrintStatusFilter));
        }

        public List<SPKStatusItem> GetApprovalStatusDropdownList()
        {
            List<SPKStatusItem> result = new List<SPKStatusItem>();

            result.Add(new SPKStatusItem
            {
                Status = (int)DbConstant.ApprovalStatus.Pending,
                Description = "Menunggu Persetujuan"
            });

            result.Add(new SPKStatusItem
            {
                Status = (int)DbConstant.ApprovalStatus.Approved,
                Description = "Disetujui"
            });

            result.Add(new SPKStatusItem
            {
                Status = (int)DbConstant.ApprovalStatus.Endorsed,
                Description = "Direvisi"
            });

            result.Add(new SPKStatusItem
            {
                Status = (int)DbConstant.ApprovalStatus.Rejected,
                Description = "Ditolak"
            });

            result.Add(new SPKStatusItem
            {
                Status = 9,
                Description = "Semua Status"
            });

            return result;
        }

        public List<SPKStatusItem> GetPrintStatusDropdownList()
        {
            List<SPKStatusItem> result = new List<SPKStatusItem>();

            result.Add(new SPKStatusItem
            {
                Status = (int)DbConstant.SPKPrintStatus.Pending,
                Description = "Menunggu Persetujuan"
            });

            result.Add(new SPKStatusItem
            {
                Status = (int)DbConstant.SPKPrintStatus.Ready,
                Description = "Siap Print"
            });

            result.Add(new SPKStatusItem
            {
                Status = (int)DbConstant.SPKPrintStatus.Printed,
                Description = "Sudah Diprint"
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
