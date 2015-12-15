using BrawijayaWorkshop.Constant;
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
    public partial class VehicleDetailListControl : BaseAppUserControl, IVehicleDetailListView
    {
        private VehicleDetailListPresenter _presenter;
        private VehicleDetail _selectedVehicleDetail;

        protected override string ModulName
        {
            get
            {
                return DbConstant.MODUL_VEHICLE_DETAIL;
            }
        }

        public VehicleDetailListControl(VehicleDetailListModel model)
        {
            InitializeComponent();
            _presenter = new VehicleDetailListPresenter(this, model);



            btnUpdateDetail.Enabled = AllowInsert;

            this.Load += VehicleDetailListControl_Load;

        }

        void VehicleDetailListControl_Load(object sender, EventArgs e)
        {
            btnSearch.PerformClick();
        }

        public string LicenseNumberFilter
        {
            get
            {
                return txtFilterLicenseNumber.Text;
            }
            set
            {
                txtFilterLicenseNumber.Text = value;
            }
        }

        public List<VehicleDetail> VehicleDetailListData
        {
            get
            {
                return gridVehicleDetail.DataSource as List<VehicleDetail>;
            }
            set
            {
                if (InvokeRequired)
                {
                    this.Invoke(new MethodInvoker(delegate { gridVehicleDetail.DataSource = value; gvVehicleDetail.BestFitColumns(); }));
                }
                else
                {
                    gridVehicleDetail.DataSource = value;
                    gvVehicleDetail.BestFitColumns();
                }
            }
        }

        public VehicleDetail SelectedVehicleDetail
        {
            get
            {
                return _selectedVehicleDetail;
            }
            set
            {
                _selectedVehicleDetail = value;
            }
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            RefreshDataView();
        }

        public override void RefreshDataView()
        {
            if (!bgwMain.IsBusy)
            {
                MethodBase.GetCurrentMethod().Info("Fecthing Vehicle Detail data...");
                _selectedVehicleDetail = null;
                FormHelpers.CurrentMainForm.UpdateStatusInformation("Memuat data detail kendaraan...", false);
                bgwMain.RunWorkerAsync();
            }
        }

        private void btnUpdateDetail_Click(object sender, EventArgs e)
        {

        }

        private void bgwMain_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                _presenter.LoadDetailList();
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
                this.ShowError("Proses memuat data gagal!"); SupplierEditorForm editor = Bootstrapper.Resolve<SupplierEditorForm>();
            editor.ShowDialog(this);

            btnSearch.PerformClick();
            }
            if (VehicleDetailListData.Count > 0)
            {
                gvVehicleDetail.FocusedRowHandle = 0;
                _selectedVehicleDetail = gvVehicleDetail.GetRow(0) as VehicleDetail;
            }
            FormHelpers.CurrentMainForm.UpdateStatusInformation("Memuat data detail kendaraan selesai", true);
        }
    }
}
