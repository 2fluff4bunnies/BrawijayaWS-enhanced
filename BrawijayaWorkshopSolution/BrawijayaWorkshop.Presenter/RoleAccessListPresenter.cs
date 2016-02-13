using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.View;

namespace BrawijayaWorkshop.Presenter
{
    public class RoleAccessListPresenter : BasePresenter<IRoleAccessListView, RoleAccessListModel>
    {
        public RoleAccessListPresenter(IRoleAccessListView view, RoleAccessListModel model)
            : base(view, model) { }

        public void LoadRoleAccess()
        {
            View.RoleAccessListData = Model.RetrieveAllRoleAccess();
        }

        public void DeleteRoleAccess()
        {
            Model.DeleteRoleAccess(View.SelectedRoleAccess);
        }
    }
}
