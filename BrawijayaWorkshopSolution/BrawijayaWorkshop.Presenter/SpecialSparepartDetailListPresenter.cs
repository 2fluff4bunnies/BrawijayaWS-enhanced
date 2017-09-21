using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.Runtime;
using BrawijayaWorkshop.View;
using System.Collections.Generic;

namespace BrawijayaWorkshop.Presenter
{
    public class SpecialSparepartDetailListPresenter : BasePresenter<ISpecialSparepartDetailListView, SpecialSparepartDetailListModel>
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
            View.SerialNumber = "";
            View.SerialNumberUpdate = "";
        }

        public void LoadDetailList()
        {
            View.SpecialSparepartData = Model.SearchDetail(View.SelectedSpecialSparepart.Id, View.SerialNumber,
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

        public void UpdateSerialNUmber(int specialSparepartDetailId)
        {
            Model.UpdateSerialNumber(specialSparepartDetailId, View.SerialNumberUpdate);
        }

        public bool IsSerialNumberExist(string sn)
        {
            return Model.IsSerialNumberExist(sn);
        }
    }
}
