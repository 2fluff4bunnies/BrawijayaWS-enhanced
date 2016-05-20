using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.Runtime;
using BrawijayaWorkshop.View;
using System;
using System.Collections.Generic;

namespace BrawijayaWorkshop.Presenter
{
    public class SPKHistoryListPresenter : BasePresenter<ISPKHistoryListView, SPKHistoryListModel>
    {
        public SPKHistoryListPresenter(ISPKHistoryListView view, SPKHistoryListModel model)
            : base(view, model) { }

        public void InitData()
        {
            View.DateFilterFrom = DateTime.Now;
            View.DateFilterTo = DateTime.Now;
            View.CategoryDropdownList = Model.GetSPKCategoryList();
            View.CustomerDropdownList = Model.GetSPKCustomerList();
            View.ContractWorkStatusDropdownList = GetContractWorkStatusDropdownList();
        }

        public void LoadSPK()
        {
            View.SPKListData = Model.SearchSPK(View.LicenseNumberFilter, View.CodeFilter, View.CategoryFilter, View.DateFilterFrom, View.DateFilterTo, View.ContractWorkStatusFilter, View.CustomerFIlter);
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
