using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System.Collections.Generic;

namespace BrawijayaWorkshop.View
{
    public interface IWheelListView : IView
    {
        string NameFilter { get; set; }

        List<WheelViewModel> WheelListData { get; set; }

        WheelViewModel SelectedWheel { get; set; }

    }
}
