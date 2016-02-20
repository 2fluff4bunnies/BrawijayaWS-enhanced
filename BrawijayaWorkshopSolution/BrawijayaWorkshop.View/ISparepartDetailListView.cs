using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System.Collections.Generic;

namespace BrawijayaWorkshop.View
{
    public interface ISparepartDetailListView : IView
    {
        SparepartViewModel SelectedSparepart { get; set; }

        int SelectedStatus { get; set; }

        List<SparepartDetailStatusItem> ListStatus { get; set; }

        List<SparepartDetailViewModel> SparepartDetailListData { get; set; }

        int PurchasingDetailID { get; set; }
    }

    public class SparepartDetailStatusItem
    {
        public int Status { get; set; }
        public string Description { get; set; }
    }
}
