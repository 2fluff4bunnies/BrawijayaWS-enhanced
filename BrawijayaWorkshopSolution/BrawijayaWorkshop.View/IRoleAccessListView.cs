using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System.Collections.Generic;

namespace BrawijayaWorkshop.View
{
    public interface IRoleAccessListView : IView
    {
        List<RoleAccessViewModel> RoleAccessListData { get; set; }

        RoleAccessViewModel SelectedRoleAccess { get; set; }
    }
}
