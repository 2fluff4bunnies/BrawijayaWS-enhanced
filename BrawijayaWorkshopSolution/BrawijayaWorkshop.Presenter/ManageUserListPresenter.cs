using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.View;

namespace BrawijayaWorkshop.Presenter
{
    public class ManageUserListPresenter : BasePresenter<IManageUserListView, ManageUserListModel>
    {
        public ManageUserListPresenter(IManageUserListView view, ManageUserListModel model)
            : base(view, model) { }

        public void InitFormData()
        {
            View.IsActive = true;
            View.RoleDropdownListData = Model.RetrieveRoles();
        }

        public void LoadData()
        {
            View.UserRoleListData = Model.RetrieveUsers(View.SelectedRoleId, View.FilterName);
        }

        public void DeleteUser()
        {
            if (View.SelectedUserRole != null)
            {
                Model.DeleteUser(View.SelectedUserRole.UserId);
            }
        }
    }
}
