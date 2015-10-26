using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.Presenter;
using BrawijayaWorkshop.View;
using System;

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

        public void SetLoginResult(User user)
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

            _presenter.ExecuteLogin();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.Close();
        }
    }
}