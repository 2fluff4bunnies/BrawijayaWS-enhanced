using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.Runtime;
using BrawijayaWorkshop.View;

namespace BrawijayaWorkshop.Presenter
{
    public class UserRoleListPresenter : BasePresenter<IUserRoleListView, UserRoleListModel>
    {
        public UserRoleListPresenter(IUserRoleListView view, UserRoleListModel model)
            : base(view, model) { }

        public void InitData()
        {
            View.RoleDropdownListData = Model.RetrieveAllRole();
        }

        public void LoadUserRole()
        {
            View.UserRoleListData = Model.RetrieveUserRoleByRoleId(LoginInformation.UserId, View.SelectedRoleId);
        }

        public void DeleteUserRole()
        {
            Model.DeleteUserRole(View.SelectedUserRole);
        }
    }
}
