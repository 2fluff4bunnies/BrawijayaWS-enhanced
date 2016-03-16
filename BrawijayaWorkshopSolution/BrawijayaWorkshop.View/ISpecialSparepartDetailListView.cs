using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System.Collections.Generic;

namespace BrawijayaWorkshop.View
{
    public interface ISpecialSparepartDetailListView : IView
    {
        SpecialSparepartViewModel SelectedSpecialSparepart { get; set; }

        int SelectedStatus { get; set; }

        List<WheelDetailStatusItem> ListStatus { get; set; }

        List<SpecialSparepartDetailViewModel> WheelDetailListData { get; set; }

        int PurchasingDetailID { get; set; }
    }

    public class WheelDetailStatusItem
    {
        public int Status { get; set; }
        public string Description { get; set; }
    }
}
