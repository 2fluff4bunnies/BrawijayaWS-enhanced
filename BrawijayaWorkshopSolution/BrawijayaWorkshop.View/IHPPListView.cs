using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System;
using System.Collections.Generic;

namespace BrawijayaWorkshop.View
{
    public interface IHPPListView : IView
    {
        int SelectedMonth { get; set; }
        int SelectedYear { get; set; }

        Dictionary<int, string> ListMonth { get; set; }
        List<int> ListYear { get; set; }

        HPPHeaderViewModel AvailableHeader { get; set; }
        List<HPPDetailViewModel> HPPDetailList { get; set; }
    }
}
