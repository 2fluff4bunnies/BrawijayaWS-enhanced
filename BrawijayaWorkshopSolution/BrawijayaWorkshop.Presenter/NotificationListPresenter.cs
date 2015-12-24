using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.View;
using System.Collections.Generic;

namespace BrawijayaWorkshop.Presenter
{
    public class NotificationListPresenter : BasePresenter<INotificationListView, NotificationListModel>
    {
        public NotificationListPresenter(INotificationListView view, NotificationListModel model)
            : base(view, model) { }

        public void LoadSPKPending()
        {
            View.SPKListData = Model.SearchSPKPending();
        }
    }
}
