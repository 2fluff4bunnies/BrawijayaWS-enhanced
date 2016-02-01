using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.Runtime;
using BrawijayaWorkshop.SharedObject.ViewModels;
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
                UserViewModel loginResult = Model.ValidateLogin(View.UserName, View.Password.Encrypt());
                View.SetLoginResult(loginResult);
            }
            catch (Exception ex)
            {
                string errorMessage = "An error occured while trying to validate login";
                MethodBase.GetCurrentMethod().Error(errorMessage, ex);
                View.ShowMessage(EnumViewMessage.Error, errorMessage);
            }
        }

        public void CompileLoginInformation(UserViewModel user)
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
                UserRoleViewModel userRole = Model.GetUserRolesByUserId(user.Id);

                // get allowed modules for current user's role
                List<RoleAccessViewModel> listAllowedModules = Model.GetRoleAccessByRoleId(userRole.RoleId);

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
