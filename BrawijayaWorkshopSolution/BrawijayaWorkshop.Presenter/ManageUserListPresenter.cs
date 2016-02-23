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
            View.RoleDropdownListData = Model.RetrieveRoles();
        }

        public void SearchData()
        {
            View.UserRoleListData = Model.RetrieveUsers(View.SelectedRoleId, View.FilterName);
        }

        public void DisableUser()
        {
            if (View.SelectedUserRole != null)
            {
                Model.DisableUser(View.SelectedUserRole.UserId);
            }
        }
    }
}
