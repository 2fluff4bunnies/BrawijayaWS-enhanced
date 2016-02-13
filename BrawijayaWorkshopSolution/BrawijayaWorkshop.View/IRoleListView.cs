using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System.Collections.Generic;

namespace BrawijayaWorkshop.View
{
    public interface IRoleListView : IView
    {
        string NameFilter { get; set; }

        List<RoleViewModel> RoleListData { get; set; }

        RoleViewModel SelectedRole { get; set; }
    }
}
