﻿using BrawijayaWorkshop.Constant;
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
    public partial class UserRoleListControl : BaseAppUserControl, IUserRoleListView
    {
        private UserRoleListPresenter _presenter;

        protected override string ModulName
        {
            get
            {
                return DbConstant.MODUL_ACCESSIBILITY;
            }
        }

        public UserRoleListControl(UserRoleListModel model)
        {
            InitializeComponent();
            _presenter = new UserRoleListPresenter(this, model);

            gvUserRole.FocusedRowChanged += gvUserRole_FocusedRowChanged;
            gvUserRole.PopupMenuShowing += gvUserRole_PopupMenuShowing;

            // init editor control accessibility
            btnNewUserRole.Enabled = AllowInsert;
            //cmsEditData.Enabled = AllowEdit;
            cmsDeleteData.Enabled = AllowDelete;

            this.Load += UserRoleListControl_Load;
        }

        private void gvUserRole_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            GridView view = (GridView)sender;
            GridHitInfo hitInfo = view.CalcHitInfo(e.Point);
            if (hitInfo.InRow)
            {
                view.FocusedRowHandle = hitInfo.RowHandle;
                cmsEditor.Show(view.GridControl, e.Point);
            }
        }

        private void gvUserRole_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            SelectedUserRole = gvUserRole.GetFocusedRow() as UserRoleViewModel;
        }

        private void UserRoleListControl_Load(object sender, EventArgs e)
        {
            _presenter.InitData();

            btnSearch.PerformClick();
        }

        public List<UserRoleViewModel> UserRoleListData
        {
            get
            {
                return gridUserRole.DataSource as List<UserRoleViewModel>;
            }
            set
            {
                if (InvokeRequired)
                {
                    this.Invoke(new MethodInvoker(delegate { gridUserRole.DataSource = value; gvUserRole.BestFitColumns(); }));
                }
                else
                {
                    gridUserRole.DataSource = value;
                    gvUserRole.BestFitColumns();
                }
            }
        }

        public UserRoleViewModel SelectedUserRole { get; set; }

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

        private void btnNewUserRole_Click(object sender, EventArgs e)
        {
            UserRoleEditorForm editor = Bootstrapper.Resolve<UserRoleEditorForm>();
            editor.ShowDialog(this);

            btnSearch.PerformClick();
        }

        private void cmsDeleteData_Click(object sender, EventArgs e)
        {
            if (SelectedUserRole == null) return;

            if (this.ShowConfirmation("Apakah anda yakin ingin menghapus user role yang dipilih?") == DialogResult.Yes)
            {
                try
                {
                    MethodBase.GetCurrentMethod().Info("Deleting user role: " + SelectedUserRole.Id);

                    _presenter.DeleteUserRole();

                    btnSearch.PerformClick(); // refresh data
                }
                catch (Exception ex)
                {
                    MethodBase.GetCurrentMethod().Fatal("An error occured while trying to delete user role: '" + SelectedUserRole.Id + "'", ex);
                    this.ShowError("Proses hapus data user role gagal!");
                }
            }
        }

        private void bgwMain_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                _presenter.LoadUserRole();
            }
            catch (Exception ex)
            {
                MethodBase.GetCurrentMethod().Fatal("An error occured while trying to execute _presenter.LoadUserRole()", ex);
                e.Result = ex;
            }
        }

        private void bgwMain_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Result is Exception)
            {
                this.ShowError("Proses memuat data gagal!");
            }

            if (gvUserRole.RowCount > 0)
            {
                SelectedUserRole = gvUserRole.GetRow(0) as UserRoleViewModel;
            }

            FormHelpers.CurrentMainForm.UpdateStatusInformation("Memuat data user role selesai", true);
        }

        private void bgwExport_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                _presenter.ExportToCSV();
            }
            catch (Exception ex)
            {
                MethodBase.GetCurrentMethod().Fatal("An error occured while trying to export UserRole", ex);
                e.Result = ex;
            }
        }

        private void bgwExport_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Result is Exception)
            {
                this.ShowError("Proses export UserRole gagal!");
            }

            FormHelpers.CurrentMainForm.UpdateStatusInformation("Export UserRole selesai", true);
        }

        public string ExportFileName { get; set; }

        private void btnExportToCSV_Click(object sender, EventArgs e)
        {
            if (!bgwExport.IsBusy && !bgwMain.IsBusy)
            {
                ExportFileName = string.Empty;
                btnSearch.PerformClick();
                exportDialog.FileName = "UserRole_" + DateTime.Now.ToString("yyyyMMdd_HHmmssfff") + ".csv";
                exportDialog.ShowDialog(this);
            }
        }

        private void exportDialog_FileOk(object sender, CancelEventArgs e)
        {
            ExportFileName = exportDialog.FileName;

            MethodBase.GetCurrentMethod().Info("Exporting UserRole data...");
            FormHelpers.CurrentMainForm.UpdateStatusInformation("Proses export data UserRole...", false);
            bgwExport.RunWorkerAsync();
        }
    }
}
