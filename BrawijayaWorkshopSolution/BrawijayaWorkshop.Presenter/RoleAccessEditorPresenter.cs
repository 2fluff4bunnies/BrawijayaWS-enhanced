using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.SharedObject.ViewModels;
using BrawijayaWorkshop.View;

namespace BrawijayaWorkshop.Presenter
{
    public class RoleAccessEditorPresenter : BasePresenter<IRoleAccessEditorView, RoleAccessEditorModel>
    {
        public RoleAccessEditorPresenter(IRoleAccessEditorView view, RoleAccessEditorModel model)
            : base(view, model) { }

        public void InitFormData()
        {
            View.RoleDropdownList = Model.RetrieveAllRoles();
            View.ApplicationModulDropdownList = Model.RetrieveAllApplicationModul();

            if(View.SelectedRoleAccess != null)
            {
                View.RoleId = View.SelectedRoleAccess.RoleId;
                View.ApplicationModulId = View.SelectedRoleAccess.ApplicationModulId;
                View.AllowRead = Has(View.SelectedRoleAccess.AccessCode, DbConstant.AccessTypeEnum.Read);
                View.AllowCreate = Has(View.SelectedRoleAccess.AccessCode, DbConstant.AccessTypeEnum.Create);
                View.AllowUpdate = Has(View.SelectedRoleAccess.AccessCode, DbConstant.AccessTypeEnum.Update);
                View.AllowDelete = Has(View.SelectedRoleAccess.AccessCode, DbConstant.AccessTypeEnum.Delete);
            }
        }

        public void SaveChanges()
        {
            if(View.SelectedRoleAccess == null)
            {
                View.SelectedRoleAccess = new RoleAccessViewModel();
            }

            View.SelectedRoleAccess.RoleId = View.RoleId;
            View.SelectedRoleAccess.ApplicationModulId = View.ApplicationModulId;
            DbConstant.AccessTypeEnum accessType = DbConstant.AccessTypeEnum.Read;
            if(View.AllowCreate)
            {
                accessType = accessType | DbConstant.AccessTypeEnum.Create;
            }
            if(View.AllowUpdate)
            {
                accessType = accessType | DbConstant.AccessTypeEnum.Update;
            }
            if(View.AllowDelete)
            {
                accessType = accessType | DbConstant.AccessTypeEnum.Delete;
            }
            View.SelectedRoleAccess.AccessCode = (int)accessType;

            if(View.SelectedRoleAccess.Id > 0)
            {
                Model.UpdateRoleAccess(View.SelectedRoleAccess);
            }
            else
            {
                Model.InsertRoleAccess(View.SelectedRoleAccess);
            }
        }

        private bool Has(int accessCode, DbConstant.AccessTypeEnum flags)
        {
            return ((int)accessCode == ((int)flags | (int)accessCode));
        }
    }
}
