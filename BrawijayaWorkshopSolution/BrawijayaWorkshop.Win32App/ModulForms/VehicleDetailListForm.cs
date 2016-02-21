using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.Presenter;
using BrawijayaWorkshop.SharedObject.ViewModels;
using BrawijayaWorkshop.Utils;
using BrawijayaWorkshop.View;
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
        private VehicleDetailViewModel _selectedVehicleDetail;

        protected override string ModulName
        {
            get
            {
                return DbConstant.MODUL_VEHICLE_DETAIL;
            }
        }

        #region Properties
        public List<VehicleDetailViewModel> VehicleDetailListData
        {
            get
            {
                return gcVehicleDetail.DataSource as List<VehicleDetailViewModel>;
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

        public VehicleDetailViewModel SelectedVehicleDetail
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

        public VehicleViewModel SelectedVehicle { get; set; }
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

            if(gvVehicleDetail.RowCount > 0)
            {
                SelectedVehicleDetail = gvVehicleDetail.GetRow(0) as VehicleDetailViewModel;
            }

            FormHelpers.CurrentMainForm.UpdateStatusInformation("Memuat data kendaraan detail selesai", true);
        }

    }
}