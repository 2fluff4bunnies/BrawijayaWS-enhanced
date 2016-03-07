using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.Presenter;
using BrawijayaWorkshop.SharedObject.ViewModels;
using BrawijayaWorkshop.Utils;
using BrawijayaWorkshop.View;
using BrawijayaWorkshop.Win32App.ModulForms;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Windows.Forms;

namespace BrawijayaWorkshop.Win32App.ModulControls
{
    public partial class ManageUserListControl : BaseAppUserControl, IManageUserListView
    {
        private ManageUserListPresenter _presenter;

        protected override string ModulName
        {
            get
            {
                return DbConstant.MODUL_MANAGE_APP_USER;
            }
        }

        public ManageUserListControl(ManageUserListModel model)
        {
            InitializeComponent();
            _presenter = new ManageUserListPresenter(this, model);

            gvUser.FocusedRowChanged += gvUser_FocusedRowChanged;
            gvUser.PopupMenuShowing += gvUser_PopupMenuShowing;

            // init editor control accessibility
            btnNewUser.Enabled = AllowInsert;
            cmsEditData.Enabled = AllowEdit;
            cmsDeleteData.Enabled = AllowDelete;

            this.Load += ManageUserListControl_Load;
        }

        private void gvUser_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            GridView view = (GridView)sender;
            GridHitInfo hitInfo = view.CalcHitInfo(e.Point);
            if (hitInfo.InRow)
            {
                view.FocusedRowHandle = hitInfo.RowHandle;
                cmsEditor.Show(view.GridControl, e.Point);
            }
        }

        private void gvUser_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            this.SelectedUserRole = gvUser.GetFocusedRow() as UserRoleViewModel;
        }

        private void ManageUserListControl_Load(object sender, EventArgs e)
        {
            _presenter.InitFormData();
            btnSearch.PerformClick();
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

        public string FilterName
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

        public List<UserRoleViewModel> UserRoleListData
        {
            get
            {
                return gridUser.DataSource as List<UserRoleViewModel>;
            }
            set
            {
                if (InvokeRequired)
                {
                    this.Invoke(new MethodInvoker(delegate { gridUser.DataSource = value; gvUser.BestFitColumns(); }));
                }
                else
                {
                    gridUser.DataSource = value;
                    gvUser.BestFitColumns();
                }
            }
        }

        public UserRoleViewModel SelectedUserRole { get; set; }

        public bool IsActive
        {
            get
            {
                return cbxFilterIsActive.EditValue.AsBoolean();
            }
            set
            {
                cbxFilterIsActive.EditValue = true;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            RefreshDataView();
        }

        public override void RefreshDataView()
        {
            if (!bgwMain.IsBusy)
            {
                MethodBase.GetCurrentMethod().Info("Fecthing user role data...");
                SelectedUserRole = null;
                FormHelpers.CurrentMainForm.UpdateStatusInformation("Memuat data user role...", false);
                bgwMain.RunWorkerAsync();
            }
        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            ManageUserEditorForm editor = Bootstrapper.Resolve<ManageUserEditorForm>();
            editor.ShowDialog(this);

            btnSearch.PerformClick();
        }

        private void cmsEditData_Click(object sender, EventArgs e)
        {
            if (SelectedUserRole != null)
            {
                ManageUserEditorForm editor = Bootstrapper.Resolve<ManageUserEditorForm>();
                editor.SelectedUserRole = SelectedUserRole;
                editor.ShowDialog(this);

                btnSearch.PerformClick();
            }
        }

        private void cmsDeleteData_Click(object sender, EventArgs e)
        {
            if (SelectedUserRole != null)
            {
                if (this.ShowConfirmation("Apakah anda yakin ingin menghapus user: '" + SelectedUserRole.User.UserName + "'?") == DialogResult.Yes)
                {
                    try
                    {
                        MethodBase.GetCurrentMethod().Info("Deleting user: " + SelectedUserRole.User.UserName);

                        _presenter.DeleteUser();

                        btnSearch.PerformClick(); // refresh data
                    }
                    catch (Exception ex)
                    {
                        MethodBase.GetCurrentMethod().Fatal("An error occured while trying to delete user: '" + SelectedUserRole.User.UserName + "'", ex);
                        this.ShowError("Proses hapus data user: '" + SelectedUserRole.User.UserName + "' gagal!");
                    }
                }
            }
        }

        private void bgwMain_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                _presenter.LoadData();
            }
            catch (Exception ex)
            {
                MethodBase.GetCurrentMethod().Fatal("An error occured while trying to execute _presenter.LoadData()", ex);
                e.Result = ex;
            }
        }

        private void bgwMain_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Result is Exception)
            {
                this.ShowError("Proses memuat data gagal!");
            }

            if (gvUser.RowCount > 0)
            {
                SelectedUserRole = gvUser.GetRow(0) as UserRoleViewModel;
            }

            FormHelpers.CurrentMainForm.UpdateStatusInformation("Memuat data user selesai", true);
        }
    }
}
