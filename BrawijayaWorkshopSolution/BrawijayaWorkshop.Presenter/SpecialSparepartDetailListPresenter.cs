using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.Runtime;
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
                Status = (int)DbConstant.WheelDetailStatus.Ready,
                Description = "Tersedia"
            });
            listStatus.Add(new WheelDetailStatusItem
            {
                Status = (int)DbConstant.WheelDetailStatus.Installed,
                Description = "Terpasang"
            });
            View.ListStatus = listStatus;
        }

        public void LoadDetailList()
        {
            View.WheelDetailListData = Model.SearchDetail(View.SelectedSpecialSparepart.Id,
                (DbConstant.WheelDetailStatus)View.SelectedStatus);
        }

        public bool IsSpecialSparepartDetailInstalled(int specialSparepartDetailId)
        {
            return Model.IsSpecialSparepartDetailInstalled(specialSparepartDetailId);
        }

        public void RemoveSpecialSparepartDetail(int specialSparepartDetailId)
        {
            Model.RemoveSpecialSparepart(specialSparepartDetailId, LoginInformation.UserId);
        }
    }
}
