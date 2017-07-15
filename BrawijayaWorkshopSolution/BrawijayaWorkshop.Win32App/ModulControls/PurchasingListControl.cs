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
    public partial class PurchasingListControl : BaseAppUserControl, IPurchasingListView
    {
        private PurchasingListPresenter _presenter;
        private PurchasingViewModel _selectedPurchasing;

        protected override string ModulName
        {
            get
            {
                return DbConstant.MODUL_PURCHASING;
            }
        }

        public PurchasingListControl(PurchasingListModel model)
        {
            InitializeComponent();
            _presenter = new PurchasingListPresenter(this, model);

            gvPurchasing.PopupMenuShowing += gvPurchasing_PopupMenuShowing;
            gvPurchasing.FocusedRowChanged += gvPurchasing_FocusedRowChanged;

            // init editor control accessibility
            btnNewPurchasing.Enabled = AllowInsert;
            cmsEditData.Enabled = AllowEdit;
            persetujuanPembelianToolStripMenuItem.Enabled = AllowEdit;
            cmsPrint.Enabled = AllowEdit;
            cmsAddReturn.Enabled = AllowEdit;
            txtDateFilterFrom.EditValue = txtDateFilterTo.EditValue = DateTime.Today;

            this.Load += PurchasingListControl_Load;
        }

        private void PurchasingListControl_Load(object sender, EventArgs e)
        {
            _presenter.InitData();
            btnSearch.PerformClick();
        }

        private void gvPurchasing_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            this.SelectedPurchasing = gvPurchasing.GetFocusedRow() as PurchasingViewModel;
            if (this.SelectedPurchasing != null)
            {
                if (this.SelectedPurchasing.Status == (int)DbConstant.PurchasingStatus.NotVerified)
                {
                    cmsEditData.Visible = true;
                    persetujuanPembelianToolStripMenuItem.Visible = true;
                    lihatSelengkapnyaToolStripMenuItem.Visible = false;
                    cmsPrint.Visible = false;
                    cmsAddReturn.Visible = false;
                }
                else if (this.SelectedPurchasing.Status == (int)DbConstant.PurchasingStatus.HasReturn)
                {
                    cmsEditData.Visible = false;
                    persetujuanPembelianToolStripMenuItem.Visible = false;
                    lihatSelengkapnyaToolStripMenuItem.Visible = true;
                    cmsPrint.Visible = true;
                    cmsAddReturn.Visible = false;
                }
                else
                {
                    cmsEditData.Visible = false;
                    persetujuanPembelianToolStripMenuItem.Visible = false;
                    lihatSelengkapnyaToolStripMenuItem.Visible = true;
                    cmsPrint.Visible = true;
                    cmsAddReturn.Visible = true;
                }
            }
        }

        private void gvPurchasing_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            GridView view = (GridView)sender;
            GridHitInfo hitInfo = view.CalcHitInfo(e.Point);
            if (hitInfo.InRow)
            {
                view.FocusedRowHandle = hitInfo.RowHandle;
                cmsEditor.Show(view.GridControl, e.Point);
            }
        }

        public int PurchasingStatusFilter
        {
            get
            {
                return cbStatus.EditValue.AsInteger();
            }
            set
            {
                cbStatus.EditValue = value;
            }
        }

        public List<PurchasingStatusItem> PurchasingStatusList
        {
            get
            {
                return cbStatus.Properties.DataSource as List<PurchasingStatusItem>;
            }
            set
            {
                cbStatus.Properties.DataSource = value;
            }
        }

        public DateTime? DateFilterFrom
        {
            get
            {
                return txtDateFilterFrom.EditValue != null ? Convert.ToDateTime(txtDateFilterFrom.EditValue) : null as DateTime?;
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
                return txtDateFilterTo.EditValue != null ? Convert.ToDateTime(txtDateFilterTo.EditValue) : null as DateTime?;
            }
            set
            {
                txtDateFilterTo.EditValue = value;
            }
        }

        public List<PurchasingViewModel> PurchasingListData
        {
            get
            {
                return gridPurchasing.DataSource as List<PurchasingViewModel>;
            }
            set
            {
                if (InvokeRequired)
                {
                    this.Invoke(new MethodInvoker(delegate { gridPurchasing.DataSource = value; gvPurchasing.BestFitColumns(); }));
                }
                else
                {
                    gridPurchasing.DataSource = value;
                    gvPurchasing.BestFitColumns();
                }
            }
        }

        public PurchasingViewModel SelectedPurchasing
        {
            get
            {
                return _selectedPurchasing;
            }
            set
            {
                _selectedPurchasing = value;
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
                MethodBase.GetCurrentMethod().Info("Fecthing Purchasing data...");
                _selectedPurchasing = null;
                FormHelpers.CurrentMainForm.UpdateStatusInformation("Memuat data pembelian...", false);
                bgwMain.RunWorkerAsync();
            }
        }

        private void txtDateFilter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch.PerformClick();
            }
        }

        private void btnNewPurchasing_Click(object sender, EventArgs e)
        {
            PurchasingEditorForm editor = Bootstrapper.Resolve<PurchasingEditorForm>();
            editor.ShowDialog(this);

            btnSearch.PerformClick();
        }

        private void cmsEditData_Click(object sender, EventArgs e)
        {
            if (_selectedPurchasing != null)
            {
                PurchasingEditorForm editor = Bootstrapper.Resolve<PurchasingEditorForm>();
                editor.SelectedPurchasing = _selectedPurchasing;
                editor.ShowDialog(this);

                btnSearch.PerformClick();
            }
        }

        private void bgwMain_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                _presenter.LoadPurchasing();
            }
            catch (Exception ex)
            {
                MethodBase.GetCurrentMethod().Fatal("An error occured while trying to execute _presenter.LoadPurchasing()", ex);
                e.Result = ex;
            }
        }

        private void bgwMain_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Result is Exception)
            {
                this.ShowError("Proses memuat data gagal!");
            }

            if (gvPurchasing.RowCount > 0)
            {
                SelectedPurchasing = gvPurchasing.GetRow(0) as PurchasingViewModel;
                if (this.SelectedPurchasing != null)
                {
                    if (this.SelectedPurchasing.Status == (int)DbConstant.PurchasingStatus.NotVerified)
                    {
                        cmsEditData.Visible = true;
                        persetujuanPembelianToolStripMenuItem.Visible = true;
                        lihatSelengkapnyaToolStripMenuItem.Visible = false;
                        cmsPrint.Visible = false;
                        cmsAddReturn.Visible = false;
                    }
                    else if (this.SelectedPurchasing.Status == (int)DbConstant.PurchasingStatus.HasReturn)
                    {
                        cmsEditData.Visible = false;
                        persetujuanPembelianToolStripMenuItem.Visible = false;
                        lihatSelengkapnyaToolStripMenuItem.Visible = true;
                        cmsPrint.Visible = true;
                        cmsAddReturn.Visible = false;
                    }
                    else
                    {
                        cmsEditData.Visible = false;
                        persetujuanPembelianToolStripMenuItem.Visible = false;
                        lihatSelengkapnyaToolStripMenuItem.Visible = true;
                        cmsPrint.Visible = true;
                        cmsAddReturn.Visible = true;
                    }
                }
            }

            FormHelpers.CurrentMainForm.UpdateStatusInformation("Memuat data pembelian selesai", true);
        }

        private void gvPurchasing_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            ColumnView view = sender as ColumnView;
            if (e.Column.FieldName == "Status" && e.ListSourceRowIndex != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
            {
                int status = (int)view.GetListSourceRowCellValue(e.ListSourceRowIndex, "Status");
                switch (status)
                {
                    case 0: e.DisplayText = "Menunggu Persetujuan"; break;
                    case 1: e.DisplayText = "Disetujui"; break;
                    case 2: e.DisplayText = "Ada Retur"; break;
                }
            }
        }

        private void persetujuanPembelianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_selectedPurchasing != null)
            {
                PurchasingApprovalForm editor = Bootstrapper.Resolve<PurchasingApprovalForm>();
                editor.SelectedPurchasing = _selectedPurchasing;
                editor.ShowDialog(this);

                btnSearch.PerformClick();
            }
        }

        private void lihatSelengkapnyaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_selectedPurchasing != null)
            {
                PurchasingApprovalForm editor = Bootstrapper.Resolve<PurchasingApprovalForm>();
                editor.SelectedPurchasing = _selectedPurchasing;
                editor.ShowDialog(this);

                btnSearch.PerformClick();
            }
        }

        private void cmsPrint_Click(object sender, EventArgs e)
        {
            PurchasingPrintItem report = new PurchasingPrintItem();
            List<PurchasingViewModel> _dataSource = new List<PurchasingViewModel>();
            _dataSource.Add(SelectedPurchasing);
            report.DataSource = _dataSource;
            report.FillDataSource();

            using (ReportPrintTool printTool = new ReportPrintTool(report))
            {
                // Invoke the Print dialog.
                printTool.PrintDialog();
            }
        }

        private void cmsAddReturn_Click(object sender, EventArgs e)
        {
            if (_selectedPurchasing != null)
            {
                PurchaseReturnEditorForm editor = Bootstrapper.Resolve<PurchaseReturnEditorForm>();
                editor.SelectedPurchasing = _selectedPurchasing;
                editor.ShowDialog(this);

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
                MethodBase.GetCurrentMethod().Fatal("An error occured while trying to export Purchasing", ex);
                e.Result = ex;
            }
        }

        private void bgwExport_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Result is Exception)
            {
                this.ShowError("Proses export Purchasing gagal!");
            }

            FormHelpers.CurrentMainForm.UpdateStatusInformation("Export Purchasing selesai", true);
        }

        public string ExportFileName { get; set; }

        private void btnExportToCSV_Click(object sender, EventArgs e)
        {
            if (!bgwExport.IsBusy && !bgwMain.IsBusy)
            {
                ExportFileName = string.Empty;
                btnSearch.PerformClick();
                exportDialog.FileName = "Purchasing_" + DateTime.Now.ToString("yyyyMMdd_HHmmssfff") + ".csv";
                exportDialog.ShowDialog(this);
            }
        }

        private void exportDialog_FileOk(object sender, CancelEventArgs e)
        {
            ExportFileName = exportDialog.FileName;

            MethodBase.GetCurrentMethod().Info("Exporting Purchasing data...");
            FormHelpers.CurrentMainForm.UpdateStatusInformation("Proses export data Purchasing...", false);
            bgwExport.RunWorkerAsync();
        }

    }
}
