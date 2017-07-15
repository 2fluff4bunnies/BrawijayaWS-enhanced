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
    public partial class RoleListControl : BaseAppUserControl, IRoleListView
    {
        private RoleListPresenter _presenter;
        private RoleViewModel _selectedRole;

        protected override string ModulName
        {
            get
            {
                return DbConstant.MODUL_ACCESSIBILITY;
            }
        }

        public RoleListControl(RoleListModel model)
        {
            InitializeComponent();
            _presenter = new RoleListPresenter(this, model);

            gvRole.PopupMenuShowing += gvRole_PopupMenuShowing;
            gvRole.FocusedRowChanged += gvRole_FocusedRowChanged;

            // init editor control accessibility
            btnNewRole.Enabled = AllowInsert;
            cmsEditData.Enabled = AllowEdit;
            cmsDeleteData.Enabled = AllowDelete;

            this.Load += RoleListControl_Load;
        }

        private void RoleListControl_Load(object sender, EventArgs e)
        {
            btnSearch.PerformClick();
        }

        private void gvRole_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            this.SelectedRole = gvRole.GetFocusedRow() as RoleViewModel;
        }

        private void gvRole_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            GridView view = (GridView)sender;
            GridHitInfo hitInfo = view.CalcHitInfo(e.Point);
            if (hitInfo.InRow)
            {
                view.FocusedRowHandle = hitInfo.RowHandle;
                cmsEditor.Show(view.GridControl, e.Point);
            }
        }

        public string NameFilter
        {
            get
            {
                return txtFilterRole.Text;
            }
            set
            {
                txtFilterRole.Text = value;
            }
        }

        public List<RoleViewModel> RoleListData
        {
            get
            {
                return gridRole.DataSource as List<RoleViewModel>;
            }
            set
            {
                if (InvokeRequired)
                {
                    this.Invoke(new MethodInvoker(delegate { gridRole.DataSource = value; gvRole.BestFitColumns(); }));
                }
                else
                {
                    gridRole.DataSource = value;
                    gvRole.BestFitColumns();
                }
            }
        }

        public RoleViewModel SelectedRole
        {
            get
            {
                return _selectedRole;
            }
            set
            {
                _selectedRole = value;
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
                MethodBase.GetCurrentMethod().Info("Fecthing role data...");
                _selectedRole = null;
                FormHelpers.CurrentMainForm.UpdateStatusInformation("Memuat data role...", false);
                bgwMain.RunWorkerAsync();
            }
        }

        private void btnNewRole_Click(object sender, EventArgs e)
        {
            RoleEditorForm editor = Bootstrapper.Resolve<RoleEditorForm>();
            editor.ShowDialog(this);

            btnSearch.PerformClick();
        }

        private void cmsEditData_Click(object sender, EventArgs e)
        {
            if(_selectedRole != null)
            {
                RoleEditorForm editor = Bootstrapper.Resolve<RoleEditorForm>();
                editor.SelectedRole = _selectedRole;
                editor.ShowDialog(this);

                btnSearch.PerformClick();
            }
        }

        private void cmsDeleteData_Click(object sender, EventArgs e)
        {
            if (SelectedRole == null) return;

            if (this.ShowConfirmation("Apakah anda yakin ingin menghapus role: '" + SelectedRole.Name + "'?") == DialogResult.Yes)
            {
                try
                {
                    MethodBase.GetCurrentMethod().Info("Deleting role: " + SelectedRole.Name);

                    _presenter.DeleteRole();

                    btnSearch.PerformClick(); // refresh data
                }
                catch (Exception ex)
                {
                    MethodBase.GetCurrentMethod().Fatal("An error occured while trying to delete role: '" + SelectedRole.Name + "'", ex);
                    this.ShowError("Proses hapus data role: '" + SelectedRole.Name + "' gagal!");
                }
            }
        }

        private void bgwMain_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                _presenter.LoadRole();
            }
            catch (Exception ex)
            {
                MethodBase.GetCurrentMethod().Fatal("An error occured while trying to execute _presenter.LoadRole()", ex);
                e.Result = ex;
            }
        }

        private void bgwMain_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Result is Exception)
            {
                this.ShowError("Proses memuat data gagal!");
            }

            if (gvRole.RowCount > 0)
            {
                SelectedRole = gvRole.GetRow(0) as RoleViewModel;
            }

            FormHelpers.CurrentMainForm.UpdateStatusInformation("Memuat data role selesai", true);
        }

        private void txtFilterRole_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnSearch.PerformClick();
            }
        }

        private void bgwExport_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                _presenter.ExportToCSV();
            }
            catch (Exception ex)
            {
                MethodBase.GetCurrentMethod().Fatal("An error occured while trying to export Role", ex);
                e.Result = ex;
            }
        }

        private void bgwExport_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Result is Exception)
            {
                this.ShowError("Proses export Role gagal!");
            }

            FormHelpers.CurrentMainForm.UpdateStatusInformation("Export Role selesai", true);
        }

        public string ExportFileName { get; set; }

        private void btnExportToCSV_Click(object sender, EventArgs e)
        {
            if (!bgwExport.IsBusy && !bgwMain.IsBusy)
            {
                ExportFileName = string.Empty;
                btnSearch.PerformClick();
                exportDialog.FileName = "Role_" + DateTime.Now.ToString("yyyyMMdd_HHmmssfff") + ".csv";
                exportDialog.ShowDialog(this);
            }
        }

        private void exportDialog_FileOk(object sender, CancelEventArgs e)
        {
            ExportFileName = exportDialog.FileName;

            MethodBase.GetCurrentMethod().Info("Exporting Role data...");
            FormHelpers.CurrentMainForm.UpdateStatusInformation("Proses export data Role...", false);
            bgwExport.RunWorkerAsync();
        }
    }
}
