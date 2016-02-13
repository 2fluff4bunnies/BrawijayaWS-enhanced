using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.SharedObject.ViewModels;

namespace BrawijayaWorkshop.View
{
    public interface IRoleEditorView : IView
    {
        RoleViewModel SelectedRole { get; set; }

        string RoleName { get; set; }
    }
}
