using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System.Collections.Generic;

namespace BrawijayaWorkshop.View
{
    public interface IManageUserListView : IView
    {
        List<RoleViewModel> RoleDropdownListData { get; set; }
        int SelectedRoleId { get; set; }
        string FilterName { get; set; }

        List<UserRoleViewModel> UserRoleListData { get; set; }
        UserRoleViewModel SelectedUserRole { get; set; }

        bool IsActive { get; set; }
    }
}
