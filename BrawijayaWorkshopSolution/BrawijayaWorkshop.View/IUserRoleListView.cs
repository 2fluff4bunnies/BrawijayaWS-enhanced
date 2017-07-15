using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System.Collections.Generic;

namespace BrawijayaWorkshop.View
{
    public interface IUserRoleListView : IView
    {
        List<UserRoleViewModel> UserRoleListData { get; set; }
        UserRoleViewModel SelectedUserRole { get; set; }

        List<RoleViewModel> RoleDropdownListData { get; set; }
        int SelectedRoleId { get; set; }

        string ExportFileName { get; }
    }
}
