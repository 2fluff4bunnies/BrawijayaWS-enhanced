using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.Presenter;
using BrawijayaWorkshop.SharedObject.ViewModels;
using BrawijayaWorkshop.Utils;
using BrawijayaWorkshop.View;
using BrawijayaWorkshop.Win32App.ModulForms;
using BrawijayaWorkshop.Win32App.PrintItems;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Windows.Forms;

namespace BrawijayaWorkshop.Win32App.ModulControls
{
    public partial class SPKHistoryListControl : BaseAppUserControl, ISPKHistoryListView
    {
        protected override string ModulName
        {
            get
            {
                return DbConstant.MODUL_SPK;
            }
        }

        private SPKHistoryListPresenter _presenter;

        public SPKHistoryListControl(SPKHistoryListModel model)
        {
            InitializeComponent();

            _presenter = new SPKHistoryListPresenter(this, model);

            this.Load += SPKHistoryListControl_Load;
            gvSPK.FocusedRowChanged += gvSPK_FocusedRowChanged;
            gvSPK.PopupMenuShowing += gvSPK_PopupMenuShowing;

            this.CategoryFilter = 0;
            this.ContractWorkStatusFilter = -1;
        }

        #region Properties

        public SPKViewModel SelectedSPK { get; set; }

        public int CategoryFilter
        {
            get
            {
                if (lookUpCategory.EditValue != null)
                {
                    return lookUpCategory.EditValue.AsInteger();
                }
                else
                {
                    return -1;
                }
            }
            set
            {
                lookUpCategory.EditValue = value;
            }
        }

        public string LicenseNumberFilter
        {
            get
            {
                if (txtLicenseNumber.EditValue != null)
                {
                    return txtLicenseNumber.EditValue.ToString();
                }
                else
                {
                    return string.Empty;
                }
            }
            set
            {
                txtLicenseNumber.EditValue = value;
            }
        }

        public int ContractWorkStatusFilter
        {
            get
            {
                if (lookUpContractWorkStatus.EditValue != null)
                {
                    return lookUpContractWorkStatus.EditValue.AsInteger();
                }
                else
                {
                    return -1;
                }
            }
            set
            {
                lookUpContractWorkStatus.EditValue = value;
            }
        }

        public int CustomerFIlter
        {
            get
            {
                if (lookUpCustomer.EditValue != null)
                {
                    return lookUpCustomer.EditValue.AsInteger();
                }
                else
                {
                    return -1;
                }
            }
            set
            {
                lookUpCustomer.EditValue = value;
            }
        }

        public DateTime? DateFilterFrom
        {
            get
            {
                return txtDateFilterFrom.EditValue.AsDateTime();
            }
            set
            {
                txtDateFilterFrom.EditValue = value;
            }
        }

        public DateTime? DateFilterTo
        {
            get
            {
                return txtDateFilterTo.EditValue.AsDateTime();
            }
            set
            {
                txtDateFilterTo.EditValue = value;
            }
        }

        public string CodeFilter
        {
            get
            {
                if (txtCode.EditValue != null)
                {
                    return txtCode.EditValue.ToString();
                }
                else
                {
                    return string.Empty;
                }
            }
            set
            {
                txtCode.EditValue = value;
            }
        }

        public List<ReferenceViewModel> CategoryDropdownList
        {
            get
            {
                return lookUpCategory.Properties.DataSource as List<ReferenceViewModel>;
            }
            set
            {
                lookUpCategory.Properties.DataSource = value;
            }
        }

        public List<SPKViewModel> SPKListData
        {
            get
            {
                return gcSPK.DataSource as List<SPKViewModel>;
            }
            set
            {
                if (InvokeRequired)
                {
                    this.Invoke(new MethodInvoker(delegate { gcSPK.DataSource = value; gvSPK.BestFitColumns(); }));
                }
                else
                {
                    gcSPK.DataSource = value;
                    gvSPK.BestFitColumns();
                }
            }
        }

        public List<SPKStatusItem> ContractWorkStatusDropdownList
        {
            get
            {
                return lookUpContractWorkStatus.Properties.DataSource as List<SPKStatusItem>;
            }
            set
            {
                lookUpContractWorkStatus.Properties.DataSource = value;
            }
        }

        public List<CustomerViewModel> CustomerDropdownList
        {
            get
            {
                return lookUpCustomer.Properties.DataSource as List<CustomerViewModel>;
            }
            set
            {
                lookUpCustomer.Properties.DataSource = value;
            }
        }
        #endregion

        #region Event Handlers
        void SPKHistoryListControl_Load(object sender, EventArgs e)
        {
            _presenter.InitData();
            btnSearch.PerformClick();
        }

        void gvSPK_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            GridView view = (GridView)sender;
            GridHitInfo hitInfo = view.CalcHitInfo(e.Point);
            if (hitInfo.InRow)
            {
                view.FocusedRowHandle = hitInfo.RowHandle;
                cmsEditor.Show(view.GridControl, e.Point);
                this.SelectedSPK = gvSPK.GetRow(view.FocusedRowHandle) as SPKViewModel;
            }
        }

        void gvSPK_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            this.SelectedSPK = gvSPK.GetRow(e.FocusedRowHandle) as SPKViewModel;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            RefreshDataView();
        }

        private void bgwMain_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                _presenter.LoadSPK();
            }
            catch (Exception ex)
            {
                MethodBase.GetCurrentMethod().Fatal("An error occured while trying to execute _presenter.LoadSPK()", ex);
                e.Result = ex;
            }
        }

        private void bgwMain_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Result is Exception)
            {
                this.ShowError("Proses memuat data gagal!");
            }

            FormHelpers.CurrentMainForm.UpdateStatusInformation("Memuat data SPK selesai", true);
        }
        #endregion

        #region Methods
        public override void RefreshDataView()
        {
            if (!bgwMain.IsBusy)
            {
                MethodBase.GetCurrentMethod().Info("Fecthing SPK data...");
                SelectedSPK = null;
                FormHelpers.CurrentMainForm.UpdateStatusInformation("Memuat data SPK...", false);
                bgwMain.RunWorkerAsync();
            }
        }
        #endregion

        private void viewDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SPKHistoryDetailForm editor = Bootstrapper.Resolve<SPKHistoryDetailForm>();
            editor.SelectedSPK = this.SelectedSPK;
            editor.ShowDialog(this);

            btnSearch.PerformClick();
        }

        private void gvSPK_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {
            ColumnView view = sender as ColumnView;
            if (e.Column.FieldName == "StatusApprovalId" && e.ListSourceRowIndex != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
            {
                int status = (int)view.GetListSourceRowCellValue(e.ListSourceRowIndex, "StatusApprovalId");
                switch (status)
                {
                    case 0: e.DisplayText = "Menunggu Persetujuan"; break;
                    case 1: e.DisplayText = "Disetujui"; break;
                    case 2: e.DisplayText = "Direvisi"; break;
                    case -1: e.DisplayText = "Ditolak"; break;
                }
            }

            if (e.Column.FieldName == "StatusPrintId" && e.ListSourceRowIndex != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
            {
                int status = (int)view.GetListSourceRowCellValue(e.ListSourceRowIndex, "StatusPrintId");
                switch (status)
                {
                    case 0: e.DisplayText = "Menunggu Persetujuan"; break;
                    case 1: e.DisplayText = "Siap Print"; break;
                    case 2: e.DisplayText = "Sudah Diprint"; break;
                }
            }

            if (e.Column.FieldName == "StatusCompletedId" && e.ListSourceRowIndex != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
            {
                int status = (int)view.GetListSourceRowCellValue(e.ListSourceRowIndex, "StatusCompletedId");
                switch (status)
                {
                    case 0: e.DisplayText = "Dalam Pengerjaan"; break;
                    case 1: e.DisplayText = "Selesai"; break;
                }
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
                MethodBase.GetCurrentMethod().Fatal("An error occured while trying to export SPKHistory", ex);
                e.Result = ex;
            }
        }

        private void bgwExport_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Result is Exception)
            {
                this.ShowError("Proses export SPKHistory gagal!");
            }

            FormHelpers.CurrentMainForm.UpdateStatusInformation("Export SPKHistory selesai", true);
        }

        public string ExportFileName { get; set; }

        private void btnExportToCSV_Click(object sender, EventArgs e)
        {
            if (!bgwExport.IsBusy && !bgwMain.IsBusy)
            {
                ExportFileName = string.Empty;
                btnSearch.PerformClick();
                exportDialog.FileName = "SPKHistory_" + DateTime.Now.ToString("yyyyMMdd_HHmmssfff") + ".csv";
                exportDialog.ShowDialog(this);
            }
        }

        private void exportDialog_FileOk(object sender, CancelEventArgs e)
        {
            ExportFileName = exportDialog.FileName;

            MethodBase.GetCurrentMethod().Info("Exporting SPKHistory data...");
            FormHelpers.CurrentMainForm.UpdateStatusInformation("Proses export data SPKHistory...", false);
            bgwExport.RunWorkerAsync();
        }
    }
}
