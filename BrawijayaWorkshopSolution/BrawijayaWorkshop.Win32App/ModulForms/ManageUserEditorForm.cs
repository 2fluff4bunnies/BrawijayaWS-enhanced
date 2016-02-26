using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.Presenter;
using BrawijayaWorkshop.SharedObject.ViewModels;
using BrawijayaWorkshop.Utils;
using BrawijayaWorkshop.View;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;

namespace BrawijayaWorkshop.Win32App.ModulForms
{
    public partial class ManageUserEditorForm : BaseEditorForm, IManageUserEditorView
    {
        private ManageUserEditorPresenter _presenter;
        public ManageUserEditorForm(ManageUserEditorModel model)
        {
            InitializeComponent();
            _presenter = new ManageUserEditorPresenter(this, model);

            valUserName.SetIconAlignment(txtUserName, ErrorIconAlignment.MiddleRight);
            valFirstName.SetIconAlignment(txtFirstName, ErrorIconAlignment.MiddleRight);
            valLastName.SetIconAlignment(txtLastName, ErrorIconAlignment.MiddleRight);
            valPassword.SetIconAlignment(txtPassword, ErrorIconAlignment.MiddleRight);
            valReTypePassword.SetIconAlignment(txtReTypePassword, ErrorIconAlignment.MiddleRight);

            this.Load += ManageUserEditorForm_Load;
        }

        private void ManageUserEditorForm_Load(object sender, EventArgs e)
        {
            _presenter.InitFormData();
        }

        public List<RoleViewModel> RoleDropdownListData
        {
            get
            {
                return lookUpRole.Properties.DataSource as List<RoleViewModel>;
            }
            set
            {
                lookUpRole.Properties.DataSource = value;
            }
        }

        public int SelectedRoleId
        {
            get
            {
                return lookUpRole.EditValue.AsInteger();
            }
            set
            {
                lookUpRole.EditValue = value;
            }
        }

        public UserRoleViewModel SelectedUserRole { get; set; }

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
                return txtPassword.Text;
            }
            set
            {
                txtPassword.Text = value;
            }
        }

        public string ReTypePassword
        {
            get
            {
                return txtReTypePassword.Text;
            }
            set
            {
                txtReTypePassword.Text = value;
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
                        MethodBase.GetCurrentMethod().Fatal("An error occured while trying to save user: '" + this.FirstName + "'", ex);
                        this.ShowError("Proses simpan data user: '" + this.FirstName + "' gagal!");
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