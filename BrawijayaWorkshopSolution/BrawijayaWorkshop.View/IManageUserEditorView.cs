using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System.Collections.Generic;

namespace BrawijayaWorkshop.View
{
    public interface IManageUserEditorView : IView
    {
        List<RoleViewModel> RoleDropdownListData { get; set; }
        int SelectedRoleId { get; set; }
        UserRoleViewModel SelectedUserRole { get; set; }

        string UserName { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string MiddleName { get; set; }

        string Password { get; set; }
        string ReTypePassword { get; set; }

        bool IsActive { get; set; }
    }
}
