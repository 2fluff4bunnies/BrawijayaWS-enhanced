using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.SharedObject.ViewModels;
using BrawijayaWorkshop.View;

namespace BrawijayaWorkshop.Presenter
{
    public class UserRoleEditorPresenter : BasePresenter<IUserRoleEditorView, UserRoleEditorModel>
    {
        public UserRoleEditorPresenter(IUserRoleEditorView view, UserRoleEditorModel model)
            : base(view, model) { }

        public void InitFormData()
        {
            View.UserDropdownListData = Model.RetrieveAllUser();
            View.RoleDropdownListData = Model.RetrieveAllRole();
        }

        public bool ValidateInput()
        {
            return Model.Validate(View.SelectedUserId, View.SelectedRoleId);
        }

        public void SaveChanges()
        {
            if(View.SelectedUserRole == null)
            {
                View.SelectedUserRole = new UserRoleViewModel();
            }

            View.SelectedUserRole.UserId = View.SelectedUserId;
            View.SelectedUserRole.RoleId = View.SelectedRoleId;

            Model.InsertUserRole(View.SelectedUserRole);
        }
    }
}
