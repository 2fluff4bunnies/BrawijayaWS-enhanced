using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.Presenter;
using BrawijayaWorkshop.SharedObject.ViewModels;
using BrawijayaWorkshop.Utils;
using BrawijayaWorkshop.View;
using BrawijayaWorkshop.Runtime;
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
    public partial class RoleAccessListControl : BaseAppUserControl, IRoleAccessListView
    {
        private RoleAccessListPresenter _presenter;
        private RoleAccessViewModel _selectedRoleAccess;

        protected override string ModulName
        {
            get
            {
                return DbConstant.MODUL_ACCESSIBILITY;
            }
        }

        public RoleAccessListControl(RoleAccessListModel model)
        {
            InitializeComponent();
            _presenter = new RoleAccessListPresenter(this, model);

            gvRoleAccess.RowLoaded += gvRoleAccess_RowLoaded;

            gvRoleAccess.PopupMenuShowing += gvRoleAccess_PopupMenuShowing;
            gvRoleAccess.FocusedRowChanged += gvRoleAccess_FocusedRowChanged;

            // init editor control accessibility
            btnNewRoleAccess.Enabled = AllowInsert;
            cmsEditData.Enabled = AllowEdit;
            cmsDeleteData.Enabled = AllowDelete;

            this.Load += RoleAccessListControl_Load;
        }

        private void gvRoleAccess_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            _selectedRoleAccess = gvRoleAccess.GetFocusedRow() as RoleAccessViewModel;
        }

        private void gvRoleAccess_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            GridView view = (GridView)sender;
            GridHitInfo hitInfo = view.CalcHitInfo(e.Point);
            if (hitInfo.InRow)
            {
                view.FocusedRowHandle = hitInfo.RowHandle;
                cmsEditor.Show(view.GridControl, e.Point);
            }
        }

        public List<RoleAccessViewModel> RoleAccessListData
        {
            get
            {
                return gridRoleAccess.DataSource as List<RoleAccessViewModel>;
            }
            set
            {
                if (InvokeRequired)
                {
                    this.Invoke(new MethodInvoker(delegate { gridRoleAccess.DataSource = value; gvRoleAccess.BestFitColumns(); }));
                }
                else
                {
                    gridRoleAccess.DataSource = value;
                    gvRoleAccess.BestFitColumns();
                }
            }
        }

        public RoleAccessViewModel SelectedRoleAccess
        {
            get
            {
                return _selectedRoleAccess;
            }
            set
            {
                _selectedRoleAccess = value;
            }
        }

        private void gvRoleAccess_RowLoaded(object sender, DevExpress.XtraGrid.Views.Base.RowEventArgs e)
        {
            if (e.RowHandle > 0)
            {
                RoleAccessViewModel currentRowData = gvRoleAccess.GetRow(e.RowHandle) as RoleAccessViewModel;
                gvRoleAccess.SetRowCellValue(e.RowHandle, colRead, currentRowData.AccessCode.Has(DbConstant.AccessTypeEnum.Read));
                gvRoleAccess.SetRowCellValue(e.RowHandle, colCreate, currentRowData.AccessCode.Has(DbConstant.AccessTypeEnum.Create));
                gvRoleAccess.SetRowCellValue(e.RowHandle, colUpdate, currentRowData.AccessCode.Has(DbConstant.AccessTypeEnum.Update));
                gvRoleAccess.SetRowCellValue(e.RowHandle, colDelete, currentRowData.AccessCode.Has(DbConstant.AccessTypeEnum.Delete));
            }
        }

        private void RoleAccessListControl_Load(object sender, EventArgs e)
        {
            RefreshDataView();
        }

        public override void RefreshDataView()
        {
            if (!bgwMain.IsBusy)
            {
                MethodBase.GetCurrentMethod().Info("Fecthing role access data...");
                _selectedRoleAccess = null;
                FormHelpers.CurrentMainForm.UpdateStatusInformation("Memuat data role access...", false);
                bgwMain.RunWorkerAsync();
            }
        }

        private void btnNewRoleAccess_Click(object sender, EventArgs e)
        {
            RoleAccessEditorForm editor = Bootstrapper.Resolve<RoleAccessEditorForm>();
            editor.ShowDialog(this);

            RefreshDataView();
        }

        private void cmsEditData_Click(object sender, EventArgs e)
        {
            if(_selectedRoleAccess != null)
            {
                RoleAccessEditorForm editor = Bootstrapper.Resolve<RoleAccessEditorForm>();
                editor.SelectedRoleAccess = _selectedRoleAccess;
                editor.ShowDialog(this);

                RefreshDataView();
            }
        }

        private void cmsDeleteData_Click(object sender, EventArgs e)
        {
            if (SelectedRoleAccess == null) return;

            if (this.ShowConfirmation("Apakah anda yakin ingin menghapus role access: Modul-'" + SelectedRoleAccess.ApplicationModul.ModulName + "', Role-'" + SelectedRoleAccess.Role.Name + "'?") == DialogResult.Yes)
            {
                try
                {
                    MethodBase.GetCurrentMethod().Info("Deleting role access: Modul-'" + SelectedRoleAccess.ApplicationModul.ModulName + "', Role-'" + SelectedRoleAccess.Role.Name + "'");

                    _presenter.DeleteRoleAccess();

                    RefreshDataView(); // refresh data
                }
                catch (Exception ex)
                {
                    MethodBase.GetCurrentMethod().Fatal("An error occured while trying to delete role access: Modul-'" + SelectedRoleAccess.ApplicationModul.ModulName + "', Role-'" + SelectedRoleAccess.Role.Name + "'", ex);
                    this.ShowError("Proses hapus data role access: Modul-'" + SelectedRoleAccess.ApplicationModul.ModulName + "', Role-'" + SelectedRoleAccess.Role.Name + "' gagal!");
                }
            }
        }

        private void bgwMain_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                _presenter.LoadRoleAccess();
            }
            catch (Exception ex)
            {
                MethodBase.GetCurrentMethod().Fatal("An error occured while trying to execute _presenter.LoadRoleAccess()", ex);
                e.Result = ex;
            }
        }

        private void bgwMain_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Result is Exception)
            {
                this.ShowError("Proses memuat data gagal!");
            }

            if (gvRoleAccess.RowCount > 0)
            {
                SelectedRoleAccess = gvRoleAccess.GetRow(0) as RoleAccessViewModel;
            }

            FormHelpers.CurrentMainForm.UpdateStatusInformation("Memuat data role access selesai", true);
        }
    }
}
