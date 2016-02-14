using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.Presenter;
using BrawijayaWorkshop.SharedObject.ViewModels;
using BrawijayaWorkshop.Utils;
using BrawijayaWorkshop.View;
using System;
using System.Reflection;
using System.Windows.Forms;

namespace BrawijayaWorkshop.Win32App.ModulForms
{
    public partial class UserEditorForm : BaseEditorForm, IUserEditorView
    {
        private UserEditorPresenter _presenter;

        public UserEditorForm(UserEditorModel model)
        {
            InitializeComponent();

            _presenter = new UserEditorPresenter(this, model);

            valUserName.SetIconAlignment(txtUserName, ErrorIconAlignment.MiddleRight);
            valFirstName.SetIconAlignment(txtFirstName, ErrorIconAlignment.MiddleRight);
            valLastName.SetIconAlignment(txtLastName, ErrorIconAlignment.MiddleRight);
            valPassword.SetIconAlignment(txtPassword, ErrorIconAlignment.MiddleRight);
            valReTypePassword.SetIconAlignment(txtReTypePassword, ErrorIconAlignment.MiddleRight);

            this.Load += UserEditorForm_Load;
        }

        private void UserEditorForm_Load(object sender, EventArgs e)
        {
            _presenter.InitFormData();
        }

        public UserViewModel SelectedUser { get; set; }

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

        public string FirstName
        {
            get
            {
                return txtFirstName.Text;
            }
            set
            {
                txtFirstName.Text = value;
            }
        }

        public string LastName
        {
            get
            {
                return txtLastName.Text;
            }
            set
            {
                txtLastName.Text = value;
            }
        }

        public string MiddleName
        {
            get
            {
                return txtMiddleName.Text;
            }
            set
            {
                txtMiddleName.Text = value;
            }
        }

        public string Password
        {
            get
            {
                return txtPassword.EditValue.ToString();
            }
            set
            {
                txtPassword.EditValue = value;
            }
        }

        public string ReTypePassword
        {
            get
            {
                return txtReTypePassword.EditValue.ToString();
            }
            set
            {
                txtReTypePassword.EditValue = value;
            }
        }

        public bool IsActive
        {
            get
            {
                return cbxIsActive.EditValue.AsBoolean();
            }
            set
            {
                cbxIsActive.EditValue = value;
            }
        }

        protected override void ExecuteSave()
        {
            if (valUserName.Validate() && valFirstName.Validate() && valLastName.Validate() &&
                valPassword.Validate() && valReTypePassword.Validate())
            {
                if (_presenter.ValidateUser())
                {
                    try
                    {
                        MethodBase.GetCurrentMethod().Info("Save User's changes");
                        _presenter.SaveChanges();
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MethodBase.GetCurrentMethod().Fatal("An error occured while trying to save user: '" + SelectedUser.UserName + "'", ex);
                        this.ShowError("Proses simpan data user: '" + SelectedUser.UserName + "' gagal!");
                    }
                }
                else
                {
                    this.ShowWarning("Username '" + this.UserName + "' sudah terpakai");
                }
            }
        }
    }
}