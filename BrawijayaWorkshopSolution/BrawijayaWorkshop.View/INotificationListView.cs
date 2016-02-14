using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System.Collections.Generic;

namespace BrawijayaWorkshop.View
{
    public interface INotificationListView : IView
    {
        List<SPKViewModel> SPKListData { get; set; }

        SPKViewModel SelectedSPK { get; set; }
    }
}
