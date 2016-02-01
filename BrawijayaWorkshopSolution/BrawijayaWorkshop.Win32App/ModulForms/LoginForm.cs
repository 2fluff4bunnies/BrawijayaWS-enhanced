using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.Presenter;
using BrawijayaWorkshop.SharedObject.ViewModels;
using BrawijayaWorkshop.Utils;
using BrawijayaWorkshop.View;
using System;
using System.Reflection;

namespace BrawijayaWorkshop.Win32App.ModulForms
{
    public partial class LoginForm : BaseDefaultForm, ILoginView
    {
        private LoginPresenter _presenter;

        public LoginForm(LoginModel model)
        {
            InitializeComponent();
            _presenter = new LoginPresenter(this, model);
        }

        public string UserName
        {
            get
            {
                return txtUserName.Text;
            }
            set
            {
                txtUserName.Text = value;
            }
        }

        public string Password
        {
            get
            {
                return txtPassword.Text;
            }
            set
            {
                txtPassword.Text = value;
            }
        }

        public void SetLoginResult(UserViewModel user)
        {
            if (user == null)
            {
                this.ShowWarning("Username atau Password salah!");
                return;
            }

            _presenter.CompileLoginInformation(user);

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.UserName) && string.IsNullOrEmpty(this.Password))
            {
                this.ShowWarning("Username atau Password wajib diisi!");
                return;
            }

            try
            {
                _presenter.ExecuteLogin();
            }
            catch (Exception ex)
            {
                MethodBase.GetCurrentMethod().Fatal("An error occured while trying to login", ex);
                this.ShowError("Proses login gagal!");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.Close();
        }
    }
}