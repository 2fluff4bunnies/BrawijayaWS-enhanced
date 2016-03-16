using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.View;
using System.Collections.Generic;

namespace BrawijayaWorkshop.Presenter
{
    public class SpecialSparepartDetailListPresenter: BasePresenter<ISpecialSparepartDetailListView, SpecialSparepartDetailListModel>
    {
        public SpecialSparepartDetailListPresenter(ISpecialSparepartDetailListView view, SpecialSparepartDetailListModel model)
            : base(view, model) { }

        public void InitFormData()
        {
            List<WheelDetailStatusItem> listStatus = new List<WheelDetailStatusItem>();
            listStatus.Add(new WheelDetailStatusItem
            {
                Status = (int)DbConstant.SparepartDetailDataStatus.Active,
                Description = "Aktif"
            });
            listStatus.Add(new WheelDetailStatusItem
            {
                Status = (int)DbConstant.SparepartDetailDataStatus.NotVerified,
                Description = "Pending"
            });
            View.ListStatus = listStatus;
        }

        public void LoadDetailList()
        {
            View.WheelDetailListData = Model.SearchWheel(View.SelectedSpecialSparepart.Id,
                (DbConstant.SparepartDetailDataStatus)View.SelectedStatus, View.PurchasingDetailID);
        }
    }
}
