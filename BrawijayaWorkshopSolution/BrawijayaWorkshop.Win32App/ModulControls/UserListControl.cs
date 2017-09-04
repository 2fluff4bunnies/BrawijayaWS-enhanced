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
    public partial class UserListControl : BaseAppUserControl, IUserListView
    {
        private UserListPresenter _presenter;

        protected override string ModulName
        {
            get
            {
                return DbConstant.MODUL_USERCONTROL;
            }
        }

        public UserListControl(UserListModel model)
        {
            InitializeComponent();

            _presenter = new UserListPresenter(this, model);

            FilterIsActive = true;

            gvUser.FocusedRowChanged += gvUser_FocusedRowChanged;
            gvUser.PopupMenuShowing += gvUser_PopupMenuShowing;

            // init editor control accessibility
            btnNewUser.Enabled = AllowInsert;
            cmsEditData.Enabled = AllowEdit;
            cmsDeleteData.Enabled = AllowDelete;

            this.Load += UserListControl_Load;
        }

        private void gvUser_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
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
            this.SelectedUser = gvUser.GetFocusedRow() as UserViewModel;
        }

        private void UserListControl_Load(object sender, EventArgs e)
        {
            btnSearch.PerformClick();
        }

        public List<UserViewModel> UserListData
        {
            get
            {
                return gridUser.DataSource as List<UserViewModel>;
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

        public UserViewModel SelectedUser { get; set; }

        public string FilterName
        {
            get
            {
                return txtFilterName.Text;
            }
            set
            {
                txtFilterName.Text = value;
            }
        }

        public bool FilterIsActive
        {
            get
            {
                return cbxFilterIsActive.EditValue.AsBoolean();
            }
            set
            {
                cbxFilterIsActive.EditValue = value;
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
                MethodBase.GetCurrentMethod().Info("Fecthing user data...");
                SelectedUser = null;
                FormHelpers.CurrentMainForm.UpdateStatusInformation("Memuat data user...", false);
                bgwMain.RunWorkerAsync();
            }
        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            UserEditorForm editor = Bootstrapper.Resolve<UserEditorForm>();
            editor.ShowDialog(this);

            btnSearch.PerformClick();
        }

        private void cmsEditData_Click(object sender, EventArgs e)
        {
            if(SelectedUser != null)
            {
                UserEditorForm editor = Bootstrapper.Resolve<UserEditorForm>();
                editor.SelectedUser = SelectedUser;
                editor.ShowDialog(this);

                btnSearch.PerformClick();
            }
        }

        private void cmsDeleteData_Click(object sender, EventArgs e)
        {
            if (SelectedUser == null) return;

            if (this.ShowConfirmation("Apakah anda yakin ingin menghapus user: '" + SelectedUser.UserName + "'?") == DialogResult.Yes)
            {
                try
                {
                    MethodBase.GetCurrentMethod().Info("Deleting user: " + SelectedUser.UserName);

                    _presenter.DeleteUser();

                    btnSearch.PerformClick(); // refresh data
                }
                catch (Exception ex)
                {
                    MethodBase.GetCurrentMethod().Fatal("An error occured while trying to delete user: '" + SelectedUser.UserName + "'", ex);
                    this.ShowError("Proses hapus data user: '" + SelectedUser.UserName + "' gagal!");
                }
            }
        }

        private void bgwMain_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                _presenter.LoadUser();
            }
            catch (Exception ex)
            {
                MethodBase.GetCurrentMethod().Fatal("An error occured while trying to execute _presenter.LoadUser()", ex);
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
                SelectedUser = gvUser.GetRow(0) as UserViewModel;
            }

            FormHelpers.CurrentMainForm.UpdateStatusInformation("Memuat data user selesai", true);
        }

        private void bgwExport_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                _presenter.ExportToCSV();
            }
            catch (Exception ex)
            {
                MethodBase.GetCurrentMethod().Fatal("An error occured while trying to export User", ex);
                e.Result = ex;
            }
        }

        private void bgwExport_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Result is Exception)
            {
                this.ShowError("Proses export User gagal!");
            }

            FormHelpers.CurrentMainForm.UpdateStatusInformation("Export User selesai", true);
        }

        public string ExportFileName { get; set; }

        private void btnExportToCSV_Click(object sender, EventArgs e)
        {
            if (!bgwExport.IsBusy && !bgwMain.IsBusy)
            {
                ExportFileName = string.Empty;
                btnSearch.PerformClick();
                exportDialog.FileName = "User_" + DateTime.Now.ToString("yyyyMMdd_HHmmssfff") + ".csv";
                exportDialog.ShowDialog(this);
            }
        }

        private void exportDialog_FileOk(object sender, CancelEventArgs e)
        {
            ExportFileName = exportDialog.FileName;

            MethodBase.GetCurrentMethod().Info("Exporting User data...");
            FormHelpers.CurrentMainForm.UpdateStatusInformation("Proses export data User...", false);
            bgwExport.RunWorkerAsync();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (!gridUser.IsPrintingAvailable)
            {
                MessageBox.Show("Data Tidak Tersedia", "Warning");
                return;
            }

            // Print.
            gridUser.Print();
        }
    }
}
