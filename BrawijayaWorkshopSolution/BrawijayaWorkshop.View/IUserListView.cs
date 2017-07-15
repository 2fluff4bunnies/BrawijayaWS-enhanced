using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System.Collections.Generic;

namespace BrawijayaWorkshop.View
{
    public interface IUserListView : IView
    {
        List<UserViewModel> UserListData { get; set; }
        UserViewModel SelectedUser { get; set; }

        string FilterName { get; set; }
        bool FilterIsActive { get; set; }

        string ExportFileName { get; }
    }
}
