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
    public partial class VehicleGroupListControl : BaseAppUserControl, IVehicleGroupListView
    {
        private VehicleGroupListPresenter _presenter;

        protected override string ModulName
        {
            get
            {
                return DbConstant.MODUL_VEHICLEGROUP;
            }
        }

        public VehicleGroupListControl(VehicleGroupListModel model)
        {
            InitializeComponent();
            _presenter = new VehicleGroupListPresenter(this, model);

            gvVehicleGroup.PopupMenuShowing += gvVehicleGroup_PopupMenuShowing;
            gvVehicleGroup.FocusedRowChanged += gvVehicleGroup_FocusedRowChanged;

            // init editor control accessibility
            btnNewVehicleGroup.Enabled = AllowInsert;
            cmsEditData.Enabled = AllowEdit;
            cmsDeleteData.Enabled = AllowDelete;

            this.Load += VehicleGroupListControl_Load;
        }

        private void VehicleGroupListControl_Load(object sender, EventArgs e)
        {
            _presenter.InitFormData();
            btnSearch.PerformClick();
        }

        private void gvVehicleGroup_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            this.SelectedGroup = gvVehicleGroup.GetFocusedRow() as VehicleGroupViewModel;
        }

        private void gvVehicleGroup_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            GridView view = (GridView)sender;
            GridHitInfo hitInfo = view.CalcHitInfo(e.Point);
            if (hitInfo.InRow)
            {
                view.FocusedRowHandle = hitInfo.RowHandle;
                cmsEditor.Show(view.GridControl, e.Point);
            }
        }

        public List<CustomerViewModel> ListCustomer
        {
            get
            {
                return lookupCustomer.Properties.DataSource as List<CustomerViewModel>;
            }
            set
            {
                lookupCustomer.Properties.DataSource = value;
            }
        }

        public int SelectedCustomerId
        {
            get
            {
                return lookupCustomer.EditValue.AsInteger();
            }
            set
            {
                lookupCustomer.EditValue = value;
            }
        }

        public string GroupNameFilter
        {
            get
            {
                return txtFilterGroupName.Text;
            }
            set
            {
                txtFilterGroupName.Text = value;
            }
        }

        public List<VehicleGroupViewModel> ListVehicleGroupData
        {
            get
            {
                return gridVehicleGroup.DataSource as List<VehicleGroupViewModel>;
            }
            set
            {
                if (InvokeRequired)
                {
                    this.Invoke(new MethodInvoker(delegate { gridVehicleGroup.DataSource = value; gvVehicleGroup.BestFitColumns(); }));
                }
                else
                {
                    gridVehicleGroup.DataSource = value;
                    gvVehicleGroup.BestFitColumns();
                }
            }
        }

        public VehicleGroupViewModel SelectedGroup { get; set; }

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

            if (gvVehicleGroup.RowCount > 0)
            {
                SelectedGroup = gvVehicleGroup.GetRow(0) as VehicleGroupViewModel;
            }

            FormHelpers.CurrentMainForm.UpdateStatusInformation("Memuat data customer selesai", true);
        }

        private void btnNewVehicleGroup_Click(object sender, EventArgs e)
        {
            VehicleGroupEditorForm editor = Bootstrapper.Resolve<VehicleGroupEditorForm>();
            editor.ShowDialog(this);

            btnSearch.PerformClick();
        }

        private void cmsEditData_Click(object sender, EventArgs e)
        {
            if (this.SelectedGroup != null)
            {
                VehicleGroupEditorForm editor = Bootstrapper.Resolve<VehicleGroupEditorForm>();
                editor.SelectedGroup = this.SelectedGroup;
                editor.ShowDialog(this);

                btnSearch.PerformClick();
            }
        }

        private void cmsDeleteData_Click(object sender, EventArgs e)
        {
            if (SelectedGroup == null) return;

            if (this.ShowConfirmation("Apakah anda yakin ingin menghapus kelompok: '" + SelectedGroup.Name + "'?") == DialogResult.Yes)
            {
                try
                {
                    MethodBase.GetCurrentMethod().Info("Deleting vehicle group: " + SelectedGroup.Name);

                    _presenter.DeleteSelectedGroup();

                    btnSearch.PerformClick(); // refresh data
                }
                catch (Exception ex)
                {
                    MethodBase.GetCurrentMethod().Fatal("An error occured while trying to delete vehicle group: '" + SelectedGroup.Name + "'", ex);
                    this.ShowError("Proses hapus data kelompok: '" + SelectedGroup.Name + "' gagal!");
                }
            }
        }

        private void txtFilterGroupName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch.PerformClick();
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
                MethodBase.GetCurrentMethod().Info("Fecthing vehicle group data...");
                this.SelectedGroup = null;
                FormHelpers.CurrentMainForm.UpdateStatusInformation("Memuat data kelompok...", false);
                bgwMain.RunWorkerAsync();
            }
        }
    }
}
