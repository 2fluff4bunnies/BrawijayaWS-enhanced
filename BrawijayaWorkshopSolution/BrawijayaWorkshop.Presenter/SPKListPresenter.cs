using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.Runtime;
using BrawijayaWorkshop.View;
using System;
using System.Collections.Generic;

namespace BrawijayaWorkshop.Presenter
{
    public class SPKListPresenter : BasePresenter<ISPKListView, SPKListModel>
    {
        public SPKListPresenter(ISPKListView view, SPKListModel model)
            : base(view, model) { }

        public void InitData()
        {
            View.DateFrom = View.DateTo = DateTime.Today;
            View.CategoryDropdownList = Model.GetSPKCategoryList();
            View.ApprovalStatusDropdownList = GetApprovalStatusDropdownList();
            View.PrintStatusDropdownList = GetPrintStatusDropdownList();
            View.CompletedStatusDropdownList = GetCompletedStatusDropdownList();
            View.ContractWorkStatusDropdownList = GetContractWorkStatusDropdownList();
        }

        public void LoadSPK()
        {
            View.SPKListData = Model.SearchSPK(View.DateFrom, View.DateTo, View.LicenseNumberFilter, View.CodeFilter, View.CategoryFilter, (DbConstant.ApprovalStatus)View.ApprovalStatusFilter, (DbConstant.SPKPrintStatus)View.PrintStatusFilter, (DbConstant.SPKCompletionStatus)View.CompletedStatusFilter, View.ContractWorkStatusFilter);
        }

        public void PrintSPK()
        {
            Model.PrintSPK(View.SelectedSPK, LoginInformation.UserId);
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

        public List<SPKStatusItem> GetCompletedStatusDropdownList()
        {
            List<SPKStatusItem> result = new List<SPKStatusItem>();

            result.Add(new SPKStatusItem
            {
                Status = (int)DbConstant.SPKPrintStatus.Pending,
                Description = "Dalam Pengerjaan"
            });

            result.Add(new SPKStatusItem
            {
                Status = (int)DbConstant.SPKPrintStatus.Ready,
                Description = "Selesai"
            });

            result.Add(new SPKStatusItem
            {
                Status = 9,
                Description = "Semua Status"
            });

            return result;
        }

        public List<SPKStatusItem> GetContractWorkStatusDropdownList()
        {
            List<SPKStatusItem> result = new List<SPKStatusItem>();

            result.Add(new SPKStatusItem
            {
                Status = -1,
                Description = "Semua"
            });

            result.Add(new SPKStatusItem
            {
                Status = 1,
                Description = "Borongan"
            });

            result.Add(new SPKStatusItem
            {
                Status = 0,
                Description = "Bukan Borongan"
            });

            return result;
        }
    }
}
