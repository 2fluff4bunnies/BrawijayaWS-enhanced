using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.View;

namespace BrawijayaWorkshop.Presenter
{
    public class RoleListPresenter : BasePresenter<IRoleListView, RoleListModel>
    {
        public RoleListPresenter(IRoleListView view, RoleListModel model)
            : base(view, model) { }

        public void LoadRole()
        {
            View.RoleListData = Model.SearchRole(View.NameFilter);
        }

        public void DeleteRole()
        {
            Model.DeleteRole(View.SelectedRole);
        }
    }
}
