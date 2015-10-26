using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.Runtime;
using BrawijayaWorkshop.Utils;
using BrawijayaWorkshop.View;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace BrawijayaWorkshop.Presenter
{
    public class LoginPresenter : BasePresenter<ILoginView, LoginModel>
    {
        public LoginPresenter(ILoginView view, LoginModel model)
            : base(view, model) { }

        public void ExecuteLogin()
        {
            try
            {
                User loginResult = Model.ValidateLogin(View.UserName, View.Password.Encrypt());
                View.SetLoginResult(loginResult);
            }
            catch (Exception ex)
            {
                string errorMessage = "An error occured while trying to validate login";
                MethodBase.GetCurrentMethod().Error(errorMessage, ex);
                View.ShowMessage(EnumViewMessage.Error, errorMessage);
            }
        }

        public void CompileLoginInformation(User user)
        {
            if (user == null)
            {
                string errorMessage = "Invalid login";
                MethodBase.GetCurrentMethod().Fatal(errorMessage);
                View.ShowMessage(EnumViewMessage.Error, errorMessage);
                return;
            }

            try
            {
                // get role for user
                UserRole userRole = Model.GetUserRolesByUserId(user.Id);

                // get allowed modules for current user's role
                List<RoleAccess> listAllowedModules = Model.GetRoleAccessByRoleId(userRole.RoleId);

                LoginInformation.SetLoggedInInformation(user.Id, user.UserName, userRole.RoleId, userRole.Role.Name);
                listAllowedModules.ForEach(item =>
                {
                    LoginInformation.AddModulInfo(new ModulInfo
                    {
                        ModulId = item.ApplicationModulId,
                        ModulName = item.ApplicationModul.ModulName,
                        AccessCode = item.AccessCode
                    });
                });
            }
            catch (Exception ex)
            {
                string errorMessage = "An error occured while trying to compile login information";
                MethodBase.GetCurrentMethod().Error(errorMessage, ex);
                View.ShowMessage(EnumViewMessage.Error, errorMessage);
            }
        }
    }
}
