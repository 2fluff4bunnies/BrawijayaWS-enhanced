using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.View;
using System.Collections.Generic;

namespace BrawijayaWorkshop.Presenter
{
    public class SparepartDetailListPresenter : BasePresenter<ISparepartDetailListView, SparepartDetailListModel>
    {
        public SparepartDetailListPresenter(ISparepartDetailListView view, SparepartDetailListModel model)
            : base(view, model) { }

        public void InitFormData()
        {
            List<SparepartDetailStatusItem> listStatus = new List<SparepartDetailStatusItem>();
            listStatus.Add(new SparepartDetailStatusItem
            {
                Status = (int)DbConstant.SparepartDetailDataStatus.Active,
                Description = "Aktif"
            });
            listStatus.Add(new SparepartDetailStatusItem
            {
                Status = (int)DbConstant.SparepartDetailDataStatus.NotVerified,
                Description = "Pending"
            });
            View.ListStatus = listStatus;
        }

        public void LoadDetailList()
        {
            View.SparepartDetailListData = Model.SearchSparepart(View.SelectedSparepart.Id,
                (DbConstant.SparepartDetailDataStatus)View.SelectedStatus, View.PurchasingDetailID);
        }
    }
}
