﻿using BrawijayaWorkshop.Database.Entities;
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
    public partial class VehicleListControl : BaseAppUserControl, IVehicleListView
    {
        private VehicleListPresenter _presenter;
        private Vehicle _selectedVehicle;

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

            this.Load += VehicleListControl_Load;
        }

        public string ActiveLicenseNumberFilter
        {
            get
            {
                return txtFilter.Text;
            }
            set
            {
                txtFilter.Text = value;
            }
        }

        public List<Vehicle> VehicleListData
        {
            get
            {
                return gcVehicle.DataSource as List<Vehicle>;
            }
            set
            {
                if (InvokeRequired)
                {
                    this.Invoke(new MethodInvoker(delegate { gcVehicle.DataSource = value; gvVehicle.BestFitColumns(); }));
                }
                else
                {
                    gcVehicle.DataSource = value;
                    gvVehicle.BestFitColumns();
                }
            }
        }

        public Vehicle SelectedVehicle
        {
            get
            {
                return _selectedVehicle;
            }
            set
            {
                _selectedVehicle = value;
            }
        }

        private void VehicleListControl_Load(object sender, EventArgs e)
        {
            btnSearch.PerformClick();
        }

        private void gvvehicle_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            this.SelectedVehicle = gvVehicle.GetFocusedRow() as Vehicle;
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            RefreshDataView();
        }

        public override void RefreshDataView()
        {
            if (!bgwMain.IsBusy)
            {
                MethodBase.GetCurrentMethod().Info("Fecthing vehicle data...");
                _selectedVehicle = null;
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

        private void btnNewVehicle_Click(object sender, EventArgs e)
        {
            VehicleEditorForm editor = Bootstrapper.Resolve<VehicleEditorForm>();
            editor.ShowDialog(this);

            btnSearch.PerformClick();
        }

        private void cmsEditData_Click(object sender, EventArgs e)
        {
            if (_selectedVehicle != null)
            {
                VehicleEditorForm editor = Bootstrapper.Resolve<VehicleEditorForm>();
                editor.SelectedVehicle = _selectedVehicle;
                editor.ShowDialog(this);

                btnSearch.PerformClick();
            }
        }

        private void cmsDeleteData_Click(object sender, EventArgs e)
        {
            if (SelectedVehicle == null) return;

            if (this.ShowConfirmation("Apakah anda yakin ingin menghapus kendaraan dengan nomor polisi : '" + SelectedVehicle.ActiveLicenseNumber + "'?") == DialogResult.Yes)
            {
                try
                {
                    MethodBase.GetCurrentMethod().Info("Mengapus kendaraan dengan nomor polisi : " + SelectedVehicle.ActiveLicenseNumber);

                    _presenter.DeleteVehicle();

                    btnSearch.PerformClick(); // refresh data
                }
                catch (Exception ex)
                {
                    MethodBase.GetCurrentMethod().Fatal("An error occured while trying to delete vehicle with license number: '" + SelectedVehicle.ActiveLicenseNumber + "'", ex);
                    this.ShowError("Proses hapus data vehicle dengan nomor polisi : '" + SelectedVehicle.ActiveLicenseNumber + "' gagal!");
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
    }
}
