using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Infrastructure.MVP;
using System.Collections.Generic;

namespace BrawijayaWorkshop.View
{
    public interface ISparepartDetailListView : IView
    {
        Sparepart SelectedSparepart { get; set; }

        int SelectedStatus { get; set; }

        List<SparepartDetail> SparepartDetailListData { get; set; }
    }
}
