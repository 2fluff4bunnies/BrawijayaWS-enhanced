using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.Utils;
using BrawijayaWorkshop.View;
using System;
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
    }
}
