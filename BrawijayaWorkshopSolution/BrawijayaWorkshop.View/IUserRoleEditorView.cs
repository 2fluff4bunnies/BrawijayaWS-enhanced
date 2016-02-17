using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System.Collections.Generic;

namespace BrawijayaWorkshop.View
{
    public interface IUserRoleEditorView : IView
    {
        UserRoleViewModel SelectedUserRole { get; set; }

        List<UserViewModel> UserDropdownListData { get; set; }
        List<RoleViewModel> RoleDropdownListData { get; set; }

        int SelectedUserId { get; set; }
        int SelectedRoleId { get; set; }
    }
}
