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
    public partial class UserRoleEditorForm : BaseEditorForm, IUserRoleEditorView
    {
        private UserRoleEditorPresenter _presenter;

        public UserRoleEditorForm(UserRoleEditorModel model)
        {
            InitializeComponent();
            _presenter = new UserRoleEditorPresenter(this, model);

            valUser.SetIconAlignment(lookUpUser, ErrorIconAlignment.MiddleRight);
            valRole.SetIconAlignment(lookUpRole, ErrorIconAlignment.MiddleRight);

            this.Load += UserRoleEditorForm_Load;
        }

        private void UserRoleEditorForm_Load(object sender, EventArgs e)
        {
            if (!bgwMain.IsBusy)
            {
                MethodBase.GetCurrentMethod().Info("Fecthing user and role data...");
                FormHelpers.CurrentMainForm.UpdateStatusInformation("Memuat data user dan role...", false);
                bgwMain.RunWorkerAsync();
            }
        }

        public UserRoleViewModel SelectedUserRole { get; set; }

        public List<UserViewModel> UserDropdownListData
        {
            get
            {
                return lookUpUser.Properties.DataSource as List<UserViewModel>;
            }
            set
            {
                if (InvokeRequired)
                {
                    this.Invoke(new MethodInvoker(delegate { lookUpUser.Properties.DataSource = value; }));
                }
                else
                {
                    lookUpUser.Properties.DataSource = value;
                }
            }
        }

        public List<RoleViewModel> RoleDropdownListData
        {
            get
            {
                return lookUpRole.Properties.DataSource as List<RoleViewModel>;
            }
            set
            {
                if (InvokeRequired)
                {
                    this.Invoke(new MethodInvoker(delegate { lookUpRole.Properties.DataSource = value; }));
                }
                else
                {
                    lookUpRole.Properties.DataSource = value;
                }
            }
        }

        public int SelectedUserId
        {
            get
            {
                return lookUpUser.EditValue.AsInteger();
            }
            set
            {
                lookUpUser.EditValue = value;
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

        private void bgwMain_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            try
            {
                _presenter.InitFormData();
            }
            catch (Exception ex)
            {
                MethodBase.GetCurrentMethod().Fatal("An error occured while trying to execute _presenter.InitFormData()", ex);
                e.Result = ex;
            }
        }

        private void bgwMain_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            if (e.Result is Exception)
            {
                this.ShowError("Proses memuat data gagal!");
            }

            FormHelpers.CurrentMainForm.UpdateStatusInformation("Memuat data user dan role selesai", true);
        }

        protected override void ExecuteSave()
        {
            if (valUser.Validate() && valRole.Validate())
            {
                if (_presenter.ValidateInput())
                {
                    try
                    {
                        MethodBase.GetCurrentMethod().Info("Save UserRole's changes");
                        _presenter.SaveChanges();
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MethodBase.GetCurrentMethod().Fatal("An error occured while trying to save UserRole", ex);
                        this.ShowError("Proses simpan data UserRole gagal!");
                    }
                }
                else
                {
                    this.ShowWarning("User Role data sudah terdaftar");
                }
            }
        }
    }
}