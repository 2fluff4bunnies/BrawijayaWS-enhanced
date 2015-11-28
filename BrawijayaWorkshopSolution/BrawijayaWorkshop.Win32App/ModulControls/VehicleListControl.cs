using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.Presenter;
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
    public partial class VehicleListControl : BaseAppUserControl , IVehicleListView
    {
        private VehicleListPresenter _presenter;
        private Vehicle _selectedvehicle;

        public VehicleListControl(VehicleListModel model)
        {
            InitializeComponent();
            _presenter = new VehicleListPresenter(this, model);

            gvVehicle.PopupMenuShowing += gvvehicle_PopupMenuShowing;
            gvVehicle.FocusedRowChanged += gvvehicle_FocusedRowChanged;

            // init editor control accessibility
            btnNewVehicle.Enabled = AllowInsert;
            cmsEditData.Enabled = AllowEdit;
            cmsDeleteData.Enabled = AllowDelete;
        }

        private void gvvehicle_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            this.Selectedvehicle = gvVehicle.GetFocusedRow() as Vehicle;
        }

        private void gvvehicle_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            GridView view = (GridView)sender;
            GridHitInfo hitInfo = view.CalcHitInfo(e.Point);
            if (hitInfo.InRow)
            {
                view.FocusedRowHandle = hitInfo.RowHandle;
                cmsEditor.Show(view.GridControl, e.Point);
            }
        }

        public string CompanyNameFilter
        {
            get
            {
                return txtFilterLicenseId.Text;
            }
            set
            {
                txtFilterLicenseId.Text = value;
            }
        }

        public List<Vehicle> vehicleListData
        {
            get
            {
                return gridVehicle.DataSource as List<Vehicle>;
            }
            set
            {
                if(InvokeRequired)
                {
                    this.Invoke(new MethodInvoker(delegate { gridVehicle.DataSource = value; }));
                }
                else
                {
                    gridVehicle.DataSource = value;
                }
            }
        }

        public Vehicle Selectedvehicle
        {
            get
            {
                return _selectedvehicle;
            }
            set
            {
                _selectedvehicle = value;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!bgwMain.IsBusy)
            {
                MethodBase.GetCurrentMethod().Info("Fecthing vehicle data...");
                _selectedvehicle = null;
                FormHelpers.CurrentMainForm.UpdateStatusInformation("Memuat data vehicle...", false);
                bgwMain.RunWorkerAsync();
            }
        }

        private void txtFilterCompanyName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch.PerformClick();
            }
        }

        private void btnNewvehicle_Click(object sender, EventArgs e)
        {
            VehicleEditorForm editor = Bootstrapper.Resolve<VehicleEditorForm>();
            editor.ShowDialog(this);

            btnSearch.PerformClick();
        }

        private void cmsEditData_Click(object sender, EventArgs e)
        {
            if (_selectedvehicle != null)
            {
                VehicleEditorForm editor = Bootstrapper.Resolve<VehicleEditorForm>();
                editor.SelectedVehicle = _selectedvehicle;
                editor.ShowDialog(this);

                btnSearch.PerformClick();
            }
        }

        private void cmsDeleteData_Click(object sender, EventArgs e)
        {
            if (Selectedvehicle == null) return;

            if (this.ShowConfirmation("Apakah anda yakin ingin menghapus vehicle: '" + Selectedvehicle.Brand + "'?") == DialogResult.Yes)
            {
                try
                {
                    MethodBase.GetCurrentMethod().Info("Mengapus vehicle: " + Selectedvehicle.Brand);

                    _presenter.DeleteVehicle();

                    btnSearch.PerformClick(); // refresh data
                }
                catch (Exception ex)
                {
                    MethodBase.GetCurrentMethod().Fatal("An error occured while trying to delete vehicle: '" + Selectedvehicle.Brand + "'", ex);
                    this.ShowError("Proses hapus data vehicle: '" + Selectedvehicle.Brand + "' gagal!");
                }
            }
        }

        private void bgwMain_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                _presenter.LoadVehicle();
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

            FormHelpers.CurrentMainForm.UpdateStatusInformation("Memuat data vehicle selesai", true);
        }



        public Vehicle SelectedVehicle
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public string LicenseIdFilter
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public List<Vehicle> VehicleListData
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }
}
