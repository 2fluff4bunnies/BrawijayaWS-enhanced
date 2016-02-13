using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.SharedObject.ViewModels;
using BrawijayaWorkshop.View;

namespace BrawijayaWorkshop.Presenter
{
    public class RoleEditorPresenter : BasePresenter<IRoleEditorView, RoleEditorModel>
    {
        public RoleEditorPresenter(IRoleEditorView view, RoleEditorModel model)
            : base(view, model) { }

        public void InitFormData()
        {
            if(View.SelectedRole != null)
            {
                View.RoleName = View.SelectedRole.Name;
            }
        }

        public void SaveChanges()
        {
            if(View.SelectedRole == null)
            {
                View.SelectedRole = new RoleViewModel();
            }

            View.SelectedRole.Name = View.RoleName;

            if(View.SelectedRole.Id > 0)
            {
                Model.UpdateRole(View.SelectedRole);
            }
            else
            {
                Model.InsertRole(View.SelectedRole);
            }
        }
    }
}
