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
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace BrawijayaWorkshop.Win32App.ModulControls
{
    public partial class InvoiceListControl : BaseAppUserControl, IInvoiceListView
    {
        private InvoiceListPresenter _presenter;
        private InvoiceViewModel _selectedInvoice;

        protected override string ModulName
        {
            get
            {
                return DbConstant.MODUL_INVOICE;
            }
        }

        public InvoiceListControl(InvoiceListModel model)
        {
            InitializeComponent();
            _presenter = new InvoiceListPresenter(this, model);

            gvInvoice.PopupMenuShowing += gvInvoice_PopupMenuShowing;
            gvInvoice.FocusedRowChanged += gvInvoice_FocusedRowChanged;

            // init editor control accessibility
            cmsAddData.Enabled = AllowInsert;
            cmsEditData.Enabled = AllowEdit;
            cmsPrint.Enabled = AllowEdit;
            cmsAddReturn.Enabled = AllowEdit;

            this.Load += InvoiceListControl_Load;
        }

        private void InvoiceListControl_Load(object sender, EventArgs e)
        {
            _presenter.InitData();
            btnSearch.PerformClick();
            EnableExport();
        }

        private void gvInvoice_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            this.SelectedInvoice = gvInvoice.GetFocusedRow() as InvoiceViewModel;
            if (this.SelectedInvoice != null)
            {
                if (this.SelectedInvoice.Status == (int)DbConstant.InvoiceStatus.FeeNotFixed)
                {
                    cmsAddData.Visible = true;
                    cmsEditData.Visible = false;
                    cmsPrint.Visible = false;
                    cmsAddReturn.Visible = false;
                }
                else if (this.SelectedInvoice.Status == (int)DbConstant.InvoiceStatus.NotPrinted)
                {
                    cmsAddData.Visible = false;
                    cmsEditData.Visible = true;
                    cmsPrint.Visible = true;
                    cmsAddReturn.Visible = false;
                }
                else if (this.SelectedInvoice.Status == (int)DbConstant.InvoiceStatus.HasReturn)
                {
                    cmsAddData.Visible = false;
                    cmsEditData.Visible = false;
                    cmsPrint.Visible = false;
                    cmsAddReturn.Visible = false;
                }
                else
                {
                    cmsAddData.Visible = false;
                    cmsEditData.Visible = false;
                    cmsPrint.Visible = true;
                    cmsAddReturn.Visible = true;
                }
            }
        }

        private void gvInvoice_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            GridView view = (GridView)sender;
            GridHitInfo hitInfo = view.CalcHitInfo(e.Point);
            if (hitInfo.InRow)
            {
                view.FocusedRowHandle = hitInfo.RowHandle;
                cmsEditor.Show(view.GridControl, e.Point);
            }
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

        public int InvoiceStatusFilter
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

        public List<InvoiceViewModel> InvoiceListData
        {
            get
            {
                return gridInvoice.DataSource as List<InvoiceViewModel>;
            }
            set
            {
                if (InvokeRequired)
                {
                    this.Invoke(new MethodInvoker(delegate { gridInvoice.DataSource = value; gvInvoice.BestFitColumns(); }));
                }
                else
                {
                    gridInvoice.DataSource = value;
                    gvInvoice.BestFitColumns();
                }
            }
        }
        public List<InvoiceStatusItem> InvoiceStatusList
        {
            get
            {
                return cbStatus.Properties.DataSource as List<InvoiceStatusItem>;
            }
            set
            {
                cbStatus.Properties.DataSource = value;
            }
        }

        public InvoiceViewModel SelectedInvoice
        {
            get
            {
                return _selectedInvoice;
            }
            set
            {
                _selectedInvoice = value;
            }
        }

        public int SelectedCustomerId
        {
            get
            {
                return lookUpCustomer.EditValue.AsInteger();
            }
        }

        public string InvoiceStatusPayment
        {
            get
            {
                string result = "Semua";
                if (cbPaymentStatus.EditValue != null)
                {
                    result = cbPaymentStatus.EditValue.ToString();
                }
                return result;
            }
        }

        public List<CustomerViewModel> CustomerListOption
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

        public string ExportFileName { get; set; }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            RefreshDataView();
        }

        public override void RefreshDataView()
        {
            if (!bgwMain.IsBusy && !bgwExport.IsBusy)
            {
                MethodBase.GetCurrentMethod().Info("Fecthing Invoice data...");
                _selectedInvoice = null;
                FormHelpers.CurrentMainForm.UpdateStatusInformation("Memuat data Invoice...", false);
                bgwMain.RunWorkerAsync();
            }
        }

        private void cmsNewData_Click(object sender, EventArgs e)
        {
            if (_selectedInvoice != null)
            {
                InvoiceEditorForm editor = Bootstrapper.Resolve<InvoiceEditorForm>();
                editor.SelectedInvoice = _selectedInvoice;
                editor.ShowDialog(this);

                btnSearch.PerformClick();
            }
        }

        private void cmEditData_Click(object sender, EventArgs e)
        {
            if (bgwMain.IsBusy || bgwExport.IsBusy) return;

            if (_selectedInvoice != null)
            {
                InvoiceEditorForm editor = Bootstrapper.Resolve<InvoiceEditorForm>();
                editor.SelectedInvoice = _selectedInvoice;
                editor.ShowDialog(this);

                btnSearch.PerformClick();
            }
        }

        private void cmsPrint_Click(object sender, EventArgs e)
        {
            if (bgwMain.IsBusy || bgwExport.IsBusy) return;

            if (_selectedInvoice != null)
            {
                InvoiceDetailForm detail = Bootstrapper.Resolve<InvoiceDetailForm>();
                detail.SelectedInvoice = _selectedInvoice;
                detail.ShowDialog(this);

                btnSearch.PerformClick();
            }
        }

        private void bgwMain_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                _presenter.LoadInvoiceList();
            }
            catch (Exception ex)
            {
                MethodBase.GetCurrentMethod().Fatal("An error occured while trying to execute _presenter.LoadInvoice()", ex);
                e.Result = ex;
            }
        }

        private void bgwMain_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Result is Exception)
            {
                this.ShowError("Proses memuat data gagal!");
            }

            if (gvInvoice.RowCount > 0)
            {
                SelectedInvoice = gvInvoice.GetRow(0) as InvoiceViewModel;

                if (this.SelectedInvoice != null)
                {
                    if (this.SelectedInvoice.Status == (int)DbConstant.InvoiceStatus.FeeNotFixed)
                    {
                        cmsAddData.Visible = true;
                        cmsEditData.Visible = false;
                        cmsPrint.Visible = false;
                        cmsAddReturn.Visible = false;
                    }
                    else if (this.SelectedInvoice.Status == (int)DbConstant.InvoiceStatus.NotPrinted)
                    {
                        cmsAddData.Visible = false;
                        cmsEditData.Visible = true;
                        cmsPrint.Visible = true;
                        cmsAddReturn.Visible = false;
                    }
                    else if (this.SelectedInvoice.Status == (int)DbConstant.InvoiceStatus.HasReturn)
                    {
                        cmsAddData.Visible = false;
                        cmsEditData.Visible = false;
                        cmsPrint.Visible = false;
                        cmsAddReturn.Visible = false;
                    }
                    else
                    {
                        cmsAddData.Visible = false;
                        cmsEditData.Visible = false;
                        cmsPrint.Visible = true;
                        cmsAddReturn.Visible = true;
                    }
                }
            }

            FormHelpers.CurrentMainForm.UpdateStatusInformation("Memuat data Invoice selesai", true);
        }

        private void gvInvoice_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            ColumnView view = sender as ColumnView;
            if (e.Column.FieldName == "Status" && e.ListSourceRowIndex != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
            {
                int status = (int)view.GetListSourceRowCellValue(e.ListSourceRowIndex, "Status");
                switch (status)
                {
                    case 0: e.DisplayText = "Belum Dibuat"; break;
                    case 1: e.DisplayText = "Belum Dicetak"; break;
                    case 2: e.DisplayText = "Telah Dicetak"; break;
                    case 3: e.DisplayText = "Ada Retur"; break;
                }
            }
        }

        private void btnPrintAll_Click(object sender, EventArgs e)
        {
            if (bgwMain.IsBusy || bgwExport.IsBusy) return;

            if (InvoiceListData == null || InvoiceListData.Count == 0) return;

            if (InvoiceListData.Where(x => x.Status == (int)DbConstant.InvoiceStatus.FeeNotFixed).Count() > 0)
            {
                this.ShowWarning("terdapat data yang belum dilengkapi dengan fee dalam grid, tidak bisa cetak semua");
            }
            else
            {
                if (this.ShowConfirmation("Apakah anda yakin ingin mencetak semua data yang tampil pada daftar?") == DialogResult.Yes)
                {
                    List<InvoiceViewModel> dsReport = InvoiceListData;
                    if (dsReport != null && dsReport.Count > 0)
                    {
                        foreach (var itemReport in dsReport)
                        {
                            itemReport.ListInvoiceSparepart = _presenter.GetSparepartInvoice(itemReport.Id);
                        }
                        InvoicePrintItem report = new InvoicePrintItem();
                        report.DataSource = dsReport;
                        report.FillDataSource();

                        using (ReportPrintTool printTool = new ReportPrintTool(report))
                        {
                            // Invoke the Print dialog.
                            printTool.PrintDialog();
                        }
                        _presenter.PrintAll();

                        btnSearch.PerformClick();
                    }
                }
            }
        }

        private void btnExportToCSV_Click(object sender, EventArgs e)
        {
            if (!bgwExport.IsBusy && !bgwMain.IsBusy)
            {
                ExportFileName = string.Empty;
                btnSearch.PerformClick();
                exportDialog.FileName = "Invoice_" + SelectedCustomerId + "_" + DateTime.Now.ToString("yyyyMMdd_HHmmssfff") + ".csv";
                exportDialog.ShowDialog(this);
            }
        }

        private void exportDialog_FileOk(object sender, CancelEventArgs e)
        {
            ExportFileName = exportDialog.FileName;

            MethodBase.GetCurrentMethod().Info("Exporting Invoice data...");
            FormHelpers.CurrentMainForm.UpdateStatusInformation("Proses export data Invoice...", false);
            bgwExport.RunWorkerAsync();
        }

        private void lookUpCustomer_EditValueChanged(object sender, EventArgs e)
        {
            EnableExport();
        }

        private void cbPaymentStatus_EditValueChanged(object sender, EventArgs e)
        {
            EnableExport();
        }

        private void EnableExport()
        {
            btnExportToCSV.Enabled = SelectedCustomerId > 0 && InvoiceStatusPayment == "Belum Lunas";
        }

        private void bgwExport_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                _presenter.ExportToCSV();
            }
            catch (Exception ex)
            {
                MethodBase.GetCurrentMethod().Fatal("An error occured while trying to export Invoice", ex);
                e.Result = ex;
            }
        }

        private void bgwExport_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Result is Exception)
            {
                this.ShowError("Proses export invoice gagal!");
            }

            FormHelpers.CurrentMainForm.UpdateStatusInformation("Export invoice selesai", true);
        }

        private void cmsAddReturn_Click(object sender, EventArgs e)
        {
            if (_selectedInvoice != null)
            {
                SalesReturnEditorForm editor = Bootstrapper.Resolve<SalesReturnEditorForm>();
                editor.SelectedInvoice = _selectedInvoice;
                editor.ShowDialog(this);

                btnSearch.PerformClick();
            }
        }
    }
}
