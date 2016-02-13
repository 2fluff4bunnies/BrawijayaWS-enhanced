using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System.Collections.Generic;

namespace BrawijayaWorkshop.View
{
    public interface IRoleAccessEditorView : IView
    {
        List<RoleViewModel> RoleDropdownList { get; set; }
        List<ApplicationModulViewModel> ApplicationModulDropdownList { get; set; }
        int RoleId { get; set; }
        int ApplicationModulId { get; set; }
        bool AllowRead { get; set; }
        bool AllowCreate { get; set; }
        bool AllowUpdate { get; set; }
        bool AllowDelete { get; set; }
        RoleAccessViewModel SelectedRoleAccess { get; set; }
    }
}
