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

namespace BrawijayaWorkshop.Win32App.ModulForms
{
    public partial class VehicleDetailListForm : BaseDefaultForm, IVehicleDetailListView
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

        #region Properties
        public List<VehicleDetail> VehicleDetailListData
        {
            get
            {
                return gcVehicleDetail.DataSource as List<VehicleDetail>;
            }
            set
            {
                if (InvokeRequired)
                {
                    this.Invoke(new MethodInvoker(delegate { gcVehicleDetail.DataSource = value; gvVehicleDetail.BestFitColumns(); }));
                }
                else
                {
                    gcVehicleDetail.DataSource = value;
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

        public Vehicle SelectedVehicle { get; set; }
        #endregion

        public VehicleDetailListForm(VehicleDetailListModel model)
        {
            InitializeComponent();

            _presenter = new VehicleDetailListPresenter(this, model);

            btnUpdateVehicleDetail.Enabled = AllowInsert;

            this.Load += VehicleDetailListForm_Load;
        }

        public override void RefreshDataView()
        {
            if (!bgwMain.IsBusy)
            {
                MethodBase.GetCurrentMethod().Info("Fecthing vehicle detail data...");
                _selectedVehicleDetail = null;
                FormHelpers.CurrentMainForm.UpdateStatusInformation("Memuat data detail kendaraan...", false);
                bgwMain.RunWorkerAsync();
            }
        }

        void VehicleDetailListForm_Load(object sender, EventArgs e)
        {
            RefreshDataView();
        }

        private void btnUpdateVehicleDetail_Click(object sender, EventArgs e)
        {
            VehicleDetailEditorForm editor = Bootstrapper.Resolve<VehicleDetailEditorForm>();
            editor.ShowDialog(this);
        }

        private void bgwMain_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                _presenter.LoadVehicleDetail();
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

            FormHelpers.CurrentMainForm.UpdateStatusInformation("Memuat data kendaraan detail selesai", true);
        }

    }
}