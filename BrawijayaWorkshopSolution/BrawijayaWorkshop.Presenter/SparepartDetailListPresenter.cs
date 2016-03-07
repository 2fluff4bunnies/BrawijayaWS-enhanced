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
            listStatus.Add(new SparepartDetailStatusItem
            {
                Status = (int)DbConstant.SparepartDetailDataStatus.Broken,
                Description = "Rusak"
            });
            listStatus.Add(new SparepartDetailStatusItem
            {
                Status = (int)DbConstant.SparepartDetailDataStatus.OutInstalled,
                Description = "Terpasang di Kendaraan"
            });
            listStatus.Add(new SparepartDetailStatusItem
            {
                Status = (int)DbConstant.SparepartDetailDataStatus.OutPurchase,
                Description = "Keluar Melalui Pembelian"
            });
            listStatus.Add(new SparepartDetailStatusItem
            {
                Status = (int)DbConstant.SparepartDetailDataStatus.OutService,
                Description = "Keluar Melalui Service"
            });
            listStatus.Add(new SparepartDetailStatusItem
            {
                Status = (int)DbConstant.SparepartDetailDataStatus.Deleted,
                Description = "Dihapus"
            });
            View.ListStatus = listStatus;
            View.SelectedStatus = (int)DbConstant.SparepartDetailDataStatus.Active;
        }

        public void LoadDetailList()
        {
            View.SparepartDetailListData = Model.SearchSparepart(View.SelectedSparepart.Id,
                (DbConstant.SparepartDetailDataStatus)View.SelectedStatus, View.PurchasingDetailID);
        }
    }
}
