using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.Presenter;
using BrawijayaWorkshop.SharedObject.ViewModels;
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
    public partial class SPKSaleListControl : BaseAppUserControl, ISPKSaleListView
    {
        private SPKSaleListPresenter _presenter;

        protected override string ModulName
        {
            get
            {
                return DbConstant.MODUL_SPK_SALES;
            }
        }

        public SPKSaleListControl(SPKSaleListModel model)
        {
            InitializeComponent();
            _presenter = new SPKSaleListPresenter(this, model);

            gvSPKSales.PopupMenuShowing += gvSPKSales_PopupMenuShowing;
            gvSPKSales.FocusedRowChanged += gvSPKSales_FocusedRowChanged;

            // init editor control accessibility

            cmsEditData.Visible = false;

            txtDateFilterFrom.EditValue = txtDateFilterTo.EditValue = DateTime.Today;

            this.Load += SPKSaleListControl_Load;
        }

        #region Properties
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

        public List<SPKViewModel> SPKListData
        {
            get
            {
                return gcSPKSales.DataSource as List<SPKViewModel>;
            }
            set
            {
                if (InvokeRequired)
                {
                    this.Invoke(new MethodInvoker(delegate { gcSPKSales.DataSource = value; gvSPKSales.BestFitColumns(); }));
                }
                else
                {
                    gcSPKSales.DataSource = value;
                    gvSPKSales.BestFitColumns();
                }
            }
        }

        public SPKViewModel SelectedSPK { get; set; }
        public InvoiceViewModel SelectedInvoice { get; set; }
        #endregion

        private void bgwMain_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                _presenter.LoadSPK();
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

            if (gvSPKSales.RowCount > 0)
            {
                this.SelectedSPK = gvSPKSales.GetRow(0) as SPKViewModel;
            }

            FormHelpers.CurrentMainForm.UpdateStatusInformation("Memuat data penjualan langsung selesai", true);
        }

        private void btnNewSale_Click(object sender, EventArgs e)
        {
            SPKEditorForm editor = Bootstrapper.Resolve<SPKEditorForm>();
            editor.IsSPKSales = true;
            editor.ShowDialog(this);

            if (editor.IsSaveComplete)
            {
                this.SelectedSPK = editor.SelectedSPK;
                _presenter.loadSelectedInvoice();
                InvoiceEditorForm editorInvoice = Bootstrapper.Resolve<InvoiceEditorForm>();
                editorInvoice.SelectedInvoice = this.SelectedInvoice;
                editorInvoice.ShowDialog(this);
            }
            btnSearch.PerformClick();
        }

        private void cmsEditData_Click(object sender, EventArgs e)
        {
            if (this.SelectedSPK != null)
            {
                SPKEditorForm editor = Bootstrapper.Resolve<SPKEditorForm>();
                editor.IsSPKSales = true;
                editor.SelectedSPK = this.SelectedSPK;
                editor.ShowDialog(this);

                btnSearch.PerformClick();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            RefreshDataView();
        }

        void SPKSaleListControl_Load(object sender, EventArgs e)
        {
            btnSearch.PerformClick();
        }

        void gvSPKSales_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            this.SelectedSPK = gvSPKSales.GetFocusedRow() as SPKViewModel;
        }

        void gvSPKSales_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            GridView view = (GridView)sender;
            GridHitInfo hitInfo = view.CalcHitInfo(e.Point);
            if (hitInfo.InRow)
            {
                view.FocusedRowHandle = hitInfo.RowHandle;
                cmsEditor.Show(view.GridControl, e.Point);
            }
        }

        public override void RefreshDataView()
        {
            if (!bgwMain.IsBusy)
            {
                MethodBase.GetCurrentMethod().Info("Fecthing SPK Sales data...");
                this.SelectedSPK = null;
                FormHelpers.CurrentMainForm.UpdateStatusInformation("Memuat data penjualan langsung...", false);
                bgwMain.RunWorkerAsync();
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
                MethodBase.GetCurrentMethod().Fatal("An error occured while trying to export SPKSale", ex);
                e.Result = ex;
            }
        }

        private void bgwExport_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Result is Exception)
            {
                this.ShowError("Proses export SPKSale gagal!");
            }

            FormHelpers.CurrentMainForm.UpdateStatusInformation("Export SPKSale selesai", true);
        }

        public string ExportFileName { get; set; }

        private void btnExportToCSV_Click(object sender, EventArgs e)
        {
            if (!bgwExport.IsBusy && !bgwMain.IsBusy)
            {
                ExportFileName = string.Empty;
                btnSearch.PerformClick();
                exportDialog.FileName = "SPKSale_" + DateTime.Now.ToString("yyyyMMdd_HHmmssfff") + ".csv";
                exportDialog.ShowDialog(this);
            }
        }

        private void exportDialog_FileOk(object sender, CancelEventArgs e)
        {
            ExportFileName = exportDialog.FileName;

            MethodBase.GetCurrentMethod().Info("Exporting SPKSale data...");
            FormHelpers.CurrentMainForm.UpdateStatusInformation("Proses export data SPKSale...", false);
            bgwExport.RunWorkerAsync();
        }
    }
}
