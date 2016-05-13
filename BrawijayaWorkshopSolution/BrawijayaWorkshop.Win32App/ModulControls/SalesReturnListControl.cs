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
    public partial class SalesReturnListControl : BaseAppUserControl, ISalesReturnListView
    {
        private SalesReturnListPresenter _presenter;
        private InvoiceViewModel _selectedInvoice;

        protected override string ModulName
        {
            get
            {
                return DbConstant.MODUL_SALES_RETURN;
            }
        }

        public SalesReturnListControl(SalesReturnListModel model)
        {
            InitializeComponent();
            _presenter = new SalesReturnListPresenter(this, model);

            gvInvoice.PopupMenuShowing += gvInvoice_PopupMenuShowing;
            gvInvoice.FocusedRowChanged += gvInvoice_FocusedRowChanged;

            // init editor control accessibility
            btnListReturn.Enabled = AllowEdit;
            cmsAddReturn.Enabled = AllowInsert;
            cmsEditReturn.Enabled = AllowEdit;
            cmsDeleteReturn.Enabled = AllowEdit;
            cmsPrintReturn.Enabled = AllowEdit;

            txtDateFilterFrom.EditValue = txtDateFilterTo.EditValue = DateTime.Today;

            this.Load += SalesReturnListControl_Load;
        }

        private void SalesReturnListControl_Load(object sender, EventArgs e)
        {
            _presenter.InitData();
            btnSearch.PerformClick();
        }

        private void gvInvoice_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            this.SelectedInvoice = gvInvoice.GetFocusedRow() as InvoiceViewModel;
            if (this.SelectedInvoice != null)
            {
                bool isHasReturnActive = false;
                isHasReturnActive = SelectedInvoice.IsHasReturn;
                if (!isHasReturnActive)
                {
                    cmsAddReturn.Visible = true;
                    cmsEditReturn.Visible = false;
                    cmsDeleteReturn.Visible = false;
                    cmsPrintReturn.Visible = false;
                }
                else
                {
                    cmsAddReturn.Visible = false;
                    cmsEditReturn.Visible = true;
                    cmsDeleteReturn.Visible = true;
                    cmsPrintReturn.Visible = true;
                    _presenter.GetSalesReturn();
                    _presenter.GetReturnList();
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

                this.SelectedInvoice = gvInvoice.GetRow(view.FocusedRowHandle) as InvoiceViewModel;
                if (this.SelectedInvoice != null)
                {
                    bool isHasReturnActive = false;
                    isHasReturnActive = SelectedInvoice.IsHasReturn;
                    if (!isHasReturnActive)
                    {
                        cmsAddReturn.Visible = true;
                        cmsEditReturn.Visible = false;
                        cmsDeleteReturn.Visible = false;
                        cmsPrintReturn.Visible = false;
                    }
                    else
                    {
                        cmsAddReturn.Visible = false;
                        cmsEditReturn.Visible = true;
                        cmsDeleteReturn.Visible = true;
                        cmsPrintReturn.Visible = true;
                        _presenter.GetSalesReturn();
                        _presenter.GetReturnList();
                    }
                }
            }
        }

        public int CustomerFilter
        {
            get
            {
                return cbCustomerFilter.EditValue.AsInteger();
            }
            set
            {
                cbCustomerFilter.EditValue = value;
            }
        }

        public List<CustomerViewModel> CustomerFilterList
        {
            get
            {
                return cbCustomerFilter.Properties.DataSource as List<CustomerViewModel>;
            }
            set
            {
                cbCustomerFilter.Properties.DataSource = value;
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

        public SalesReturnViewModel SelectedSalesReturn { get; set; }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            RefreshDataView();
        }

        public override void RefreshDataView()
        {
            if (!bgwMain.IsBusy)
            {
                MethodBase.GetCurrentMethod().Info("Fecthing SalesReturn data...");
                _selectedInvoice = null;
                FormHelpers.CurrentMainForm.UpdateStatusInformation("Memuat data penjualan...", false);
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

        private void bgwMain_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                _presenter.LoadSalesReturn();
            }
            catch (Exception ex)
            {
                MethodBase.GetCurrentMethod().Fatal("An error occured while trying to execute _presenter.LoadSalesReturn()", ex);
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
            }

            FormHelpers.CurrentMainForm.UpdateStatusInformation("Memuat data pembelian selesai", true);
        }

        private void btnListReturn_Click(object sender, EventArgs e)
        {
            SalesReturnTransactionListForm editor = Bootstrapper.Resolve<SalesReturnTransactionListForm>();
            editor.ShowDialog(this);

            btnSearch.PerformClick();
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

        private void cmsListReturn_Click(object sender, EventArgs e)
        {
            if (_selectedInvoice != null)
            {
                SalesReturnTransactionListForm editor = Bootstrapper.Resolve<SalesReturnTransactionListForm>();
                editor.SelectedInvoice = _selectedInvoice;
                editor.ShowDialog(this);

                btnSearch.PerformClick();
            }
        }

        private void cmsEditReturn_Click(object sender, EventArgs e)
        {
            if (SelectedSalesReturn != null)
            {
                SalesReturnEditorForm editor = Bootstrapper.Resolve<SalesReturnEditorForm>();
                editor.SelectedInvoice = SelectedInvoice;
                editor.SelectedSalesReturn = SelectedSalesReturn;
                editor.ShowDialog(this);

                btnSearch.PerformClick();

            }
        }

        private void cmsDeleteReturn_Click(object sender, EventArgs e)
        {
            if (SelectedSalesReturn == null) return;

            if (this.ShowConfirmation("Apakah anda yakin ingin menghapus retur penjualan: '" + SelectedSalesReturn.InvoiceId + "'?") == DialogResult.Yes)
            {
                try
                {
                    MethodBase.GetCurrentMethod().Info("Deleting sales return: " + SelectedSalesReturn.InvoiceId);
                    _presenter.DeleteData();
                    RefreshDataView();

                }
                catch (Exception ex)
                {
                    MethodBase.GetCurrentMethod().Fatal("An error occured while trying to delete sales return: '" + SelectedSalesReturn.InvoiceId + "'", ex);
                    this.ShowError("Proses hapus data retur penjualan: '" + SelectedSalesReturn.InvoiceId + "' gagal!");
                }
            }
        }

        private void cmsPrintReturn_Click(object sender, EventArgs e)
        {
            SalesReturnPrintItem2 report = new SalesReturnPrintItem2();
            List<SalesReturnViewModel> _dataSource = new List<SalesReturnViewModel>();
            _dataSource.Add(SelectedSalesReturn);
            report.DataSource = _dataSource;
            report.FillDataSource();

            using (ReportPrintTool printTool = new ReportPrintTool(report))
            {
                // Invoke the Print dialog.
                printTool.PrintDialog();
            }
        }

    }
}
