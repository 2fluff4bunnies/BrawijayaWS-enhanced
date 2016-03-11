using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.Runtime;
using BrawijayaWorkshop.SharedObject.ViewModels;
using BrawijayaWorkshop.View;
using System.Collections.Generic;

namespace BrawijayaWorkshop.Presenter
{
    public class RoleAccessListPresenter : BasePresenter<IRoleAccessListView, RoleAccessListModel>
    {
        public RoleAccessListPresenter(IRoleAccessListView view, RoleAccessListModel model)
            : base(view, model) { }

        public void LoadRoleAccess()
        {
            //View.RoleAccessListData = Model.RetrieveAllRoleAccess();
            List<RoleAccessViewModel> list = Model.RetrieveAllRoleAccess();
            foreach (var item in list)
            {
                item.Read = LoginInformation.Has(item.AccessCode, Constant.DbConstant.AccessTypeEnum.Read);
                item.Create = LoginInformation.Has(item.AccessCode, Constant.DbConstant.AccessTypeEnum.Create);
                item.Update = LoginInformation.Has(item.AccessCode, Constant.DbConstant.AccessTypeEnum.Update);
                item.Delete = LoginInformation.Has(item.AccessCode, Constant.DbConstant.AccessTypeEnum.Delete);
            }
            View.RoleAccessListData = list;
        }

        public void DeleteRoleAccess()
        {
            Model.DeleteRoleAccess(View.SelectedRoleAccess);
        }
    }
}
