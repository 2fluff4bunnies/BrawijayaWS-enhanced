using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.Presenter;
using BrawijayaWorkshop.SharedObject.ViewModels;
using BrawijayaWorkshop.Utils;
using BrawijayaWorkshop.View;
using BrawijayaWorkshop.Win32App.ModulForms;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Windows.Forms;

namespace BrawijayaWorkshop.Win32App.ModulControls
{
    public partial class HistorySparepartListControl : BaseAppUserControl, IHistorySparepartListView
    {
        private HistorySparepartListPresenter _presenter;

        protected override string ModulName
        {
            get
            {
                return DbConstant.MODUL_HISTORY_SPAREPART;
            }
        }

        public HistorySparepartListControl(HistorySparepartListModel model)
        {
            InitializeComponent();
            _presenter = new HistorySparepartListPresenter(this, model);

            this.Load += HistorySparepartListControl_Load;
        }

        private void HistorySparepartListControl_Load(object sender, EventArgs e)
        {
            _presenter.InitData();
            btnSearch.PerformClick();
        }

        public DateTime? DateFromFilter
        {
            get
            {
                return txtDateFilterFrom.EditValue as DateTime?;
            }
            set
            {
                txtDateFilterFrom.EditValue = value;
            }
        }

        public DateTime? DateToFilter
        {
            get
            {
                return txtDateFilterTo.EditValue as DateTime?;
            }
            set
            {
                txtDateFilterTo.EditValue = value;
            }
        }

        public List<SparepartViewModel> SparepartFilterList
        {
            get
            {
                return lookupSparepart.Properties.DataSource as List<SparepartViewModel>;
            }
            set
            {
                lookupSparepart.Properties.DataSource = value;
            }
        }

        public int SparepartFilter
        {
            get
            {
                return lookupSparepart.EditValue.AsInteger();
            }
            set
            {
                lookupSparepart.EditValue = value;
            }
        }

        public List<VehicleViewModel> VehicleFilterList
        {
            get
            {
                return lookupVehicleNo.Properties.DataSource as List<VehicleViewModel>;
            }
            set
            {
                lookupVehicleNo.Properties.DataSource = value;
            }
        }

        public int VehicleFilter
        {
            get
            {
                return lookupVehicleNo.EditValue.AsInteger();
            }
            set
            {
                lookupVehicleNo.EditValue = value;
            }
        }

        public List<SPKDetailSparepartViewModel> SparepartListData
        {
            get
            {
                return gridHistorySparepart.DataSource as List<SPKDetailSparepartViewModel>;
            }
            set
            {
                if (InvokeRequired)
                {
                    this.Invoke(new MethodInvoker(delegate { gridHistorySparepart.DataSource = value; gvHistorySparepart.BestFitColumns(); }));
                }
                else
                {
                    gridHistorySparepart.DataSource = value;
                    gvHistorySparepart.BestFitColumns();
                }
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
                MethodBase.GetCurrentMethod().Info("Fecthing HistorySparepart data...");
                FormHelpers.CurrentMainForm.UpdateStatusInformation("Memuat data HistorySparepart...", false);
                bgwMain.RunWorkerAsync();
            }
        }

        private void bgwMain_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                _presenter.LoadHistorySparepartList();
            }
            catch (Exception ex)
            {
                MethodBase.GetCurrentMethod().Fatal("An error occured while trying to execute _presenter.LoadHistorySparepart()", ex);
                e.Result = ex;
            }
        }

        private void bgwMain_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Result is Exception)
            {
                this.ShowError("Proses memuat data gagal!");
            }

            FormHelpers.CurrentMainForm.UpdateStatusInformation("Memuat data History Sparepart selesai", true);
        }

        private void bgwExport_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                _presenter.ExportToCSV();
            }
            catch (Exception ex)
            {
                MethodBase.GetCurrentMethod().Fatal("An error occured while trying to export HistorySparepart", ex);
                e.Result = ex;
            }
        }

        private void bgwExport_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Result is Exception)
            {
                this.ShowError("Proses export HistorySparepart gagal!");
            }

            FormHelpers.CurrentMainForm.UpdateStatusInformation("Export HistorySparepart selesai", true);
        }

        public string ExportFileName { get; set; }

        private void btnExportToCSV_Click(object sender, EventArgs e)
        {
            if (!bgwExport.IsBusy && !bgwMain.IsBusy)
            {
                ExportFileName = string.Empty;
                btnSearch.PerformClick();
                exportDialog.FileName = "HistorySparepart_" + DateTime.Now.ToString("yyyyMMdd_HHmmssfff") + ".csv";
                exportDialog.ShowDialog(this);
            }
        }

        private void exportDialog_FileOk(object sender, CancelEventArgs e)
        {
            ExportFileName = exportDialog.FileName;

            MethodBase.GetCurrentMethod().Info("Exporting HistorySparepart data...");
            FormHelpers.CurrentMainForm.UpdateStatusInformation("Proses export data HistorySparepart...", false);
            bgwExport.RunWorkerAsync();
        }
    }
}
