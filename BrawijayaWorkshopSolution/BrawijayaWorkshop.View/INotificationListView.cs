using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Infrastructure.MVP;
using System.Collections.Generic;

namespace BrawijayaWorkshop.View
{
    public interface INotificationListView : IView
    {
        List<SPK> SPKListData { get; set; }

        SPK SelectedSPK { get; set; }
    }
}
