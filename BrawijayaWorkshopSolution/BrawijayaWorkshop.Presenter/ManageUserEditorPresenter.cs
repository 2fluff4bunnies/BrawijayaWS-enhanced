using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.SharedObject.ViewModels;
using BrawijayaWorkshop.Utils;
using BrawijayaWorkshop.View;

namespace BrawijayaWorkshop.Presenter
{
    public class ManageUserEditorPresenter : BasePresenter<IManageUserEditorView, ManageUserEditorModel>
    {
        public ManageUserEditorPresenter(IManageUserEditorView view, ManageUserEditorModel model)
            : base(view, model) { }

        public void InitFormData()
        {
            View.IsActive = true;
            View.RoleDropdownListData = Model.RetrieveRoles();

            if(View.SelectedUserRole != null)
            {
                View.SelectedRoleId = View.SelectedUserRole.RoleId;
                View.UserName = View.SelectedUserRole.User.UserName;
                View.FirstName = View.SelectedUserRole.User.FirstName;
                View.MiddleName = View.SelectedUserRole.User.MiddleName;
                View.LastName = View.SelectedUserRole.User.LastName;
                View.Password = View.SelectedUserRole.User.Password.Decrypt();
                View.ReTypePassword = View.SelectedUserRole.User.Password.Decrypt();
                View.IsActive = View.SelectedUserRole.User.IsActive;
            }
        }

        public void SaveChanges()
        {
            if(View.SelectedUserRole == null)
            {
                View.SelectedUserRole = new UserRoleViewModel();
                View.SelectedUserRole.User = new UserViewModel();
            }

            View.SelectedUserRole.RoleId = View.SelectedRoleId;
            View.SelectedUserRole.User.UserName = View.UserName;
            View.SelectedUserRole.User.FirstName = View.FirstName;
            View.SelectedUserRole.User.MiddleName = View.MiddleName;
            View.SelectedUserRole.User.LastName = View.LastName;
            View.SelectedUserRole.User.Password = View.Password.Encrypt();
            View.SelectedUserRole.User.IsActive = View.IsActive;

            if(View.SelectedUserRole.Id > 0)
            {
                Model.UpdateUserRole(View.SelectedUserRole);
            }
            else
            {
                Model.InsertUserRole(View.SelectedUserRole);
            }
        }
    }
}
