using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.SharedObject.ViewModels;

namespace BrawijayaWorkshop.View
{
    public interface IUserEditorView : IView
    {
        UserViewModel SelectedUser { get; set; }

        string UserName { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string MiddleName { get; set; }

        string Password { get; set; }
        string ReTypePassword { get; set; }

        bool IsActive { get; set; }
    }
}
