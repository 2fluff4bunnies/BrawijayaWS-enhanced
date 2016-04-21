using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.View;
using System;
using System.Collections.Generic;

namespace BrawijayaWorkshop.Presenter
{
    public class PurchasingListPresenter : BasePresenter<IPurchasingListView, PurchasingListModel>
    {
        public PurchasingListPresenter(IPurchasingListView view, PurchasingListModel model)
            : base(view, model) { }

        public void InitData()
        {
            View.PurchasingStatusList = GetPurchasingStatusDropdownList();
            View.DateFilterFrom = DateTime.Now;
            View.DateFilterTo = DateTime.Now;
            View.PurchasingStatusFilter = 9;
        }

        public void LoadPurchasing()
        {
            View.PurchasingListData = Model.SearchPurchasing(View.DateFilterFrom, View.DateFilterTo, (DbConstant.PurchasingStatus)View.PurchasingStatusFilter);
        }

        public List<PurchasingStatusItem> GetPurchasingStatusDropdownList()
        {
            List<PurchasingStatusItem> result = new List<PurchasingStatusItem>();
            result.Add(new PurchasingStatusItem
            {
                Status = 9,
                Description = "Semua"
            });

            result.Add(new PurchasingStatusItem
            {
                Status = (int)DbConstant.PurchasingStatus.Active,
                Description = "Disteujui"
            });

            result.Add(new PurchasingStatusItem
            {
                Status = (int)DbConstant.PurchasingStatus.NotVerified,
                Description = "Belum Disetujui"
            });

            return result;
        }
    }
}
