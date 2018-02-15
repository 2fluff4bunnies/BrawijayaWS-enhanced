using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System.Collections.Generic;

namespace BrawijayaWorkshop.View
{
    public interface ISpecialSparepartDetailListView : IView
    {
        SparepartViewModel SelectedSparepart { get; set; }

        int SelectedStatus { get; set; }

        List<WheelDetailStatusItem> ListStatus { get; set; }

        List<SpecialSparepartDetailViewModel> SpecialSparepartData { get; set; }

        int PurchasingDetailID { get; set; }

        string SerialNumber { get; set; }

        string SerialNumberUpdate { get; set; }
    }

    public class WheelDetailStatusItem
    {
        public int Status { get; set; }
        public string Description { get; set; }
    }
}
