using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System.Collections.Generic;

namespace BrawijayaWorkshop.View
{
    public interface IWheelDetailListView : IView
    {
        WheelViewModel SelectedWheel { get; set; }

        int SelectedStatus { get; set; }

        List<WheelDetailStatusItem> ListStatus { get; set; }

        List<WheelDetailViewModel> WheelDetailListData { get; set; }

        int PurchasingDetailID { get; set; }
    }

    public class WheelDetailStatusItem
    {
        public int Status { get; set; }
        public string Description { get; set; }
    }
}
