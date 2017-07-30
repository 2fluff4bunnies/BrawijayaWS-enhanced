using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.Presenter;
using BrawijayaWorkshop.SharedObject.ViewModels;
using BrawijayaWorkshop.Utils;
using BrawijayaWorkshop.View;
using BrawijayaWorkshop.Win32App.PrintItems;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace BrawijayaWorkshop.Win32App.ModulControls
{
    public partial class RecapPurchasingBySupplierListControl : BaseAppUserControl, IRecapPurchasingBySupplierView
    {
        private RecapPurchasingBySupplierPresenter _presenter;

        public RecapPurchasingBySupplierListControl(RecapPurchasingModel model)
        {
            InitializeComponent();
            _presenter = new RecapPurchasingBySupplierPresenter(this, model);

            this.Load += RecapInvoiceByCustomerListControl_Load;
        }

        private void RecapInvoiceByCustomerListControl_Load(object sender, EventArgs e)
        {
            _presenter.InitFormData();
        }

        public DateTime DateFrom
        {
            get
            {
                return dePeriodFrom.EditValue.AsDateTime();
            }
            set
            {
                dePeriodFrom.EditValue = value;
            }
        }

        public DateTime DateTo
        {
            get
            {
                return dePeriodeTo.EditValue.AsDateTime();
            }
            set
            {
                dePeriodeTo.EditValue = value;
            }
        }

        public int SelectedSupplier
        {
            get
            {
                return lookupSupplier.EditValue.AsInteger();
            }
            set
            {
                lookupSupplier.EditValue = value;
            }
        }

        public List<SupplierViewModel> ListSupplier
        {
            get
            {
                return lookupSupplier.Properties.DataSource as List<SupplierViewModel>;
            }
            set
            {
                lookupSupplier.Properties.DataSource = value;
            }
        }

        public List<RecapPurchasingItemViewModel> ListPurchasing
        {
            get
            {
                return gridRecapPurchasing.DataSource as List<RecapPurchasingItemViewModel>;
            }
            set
            {
                if (InvokeRequired)
                {
                    this.Invoke(new MethodInvoker(delegate { gridRecapPurchasing.DataSource = value; gvRecapPurchasing.BestFitColumns(); }));
                }
                else
                {
                    gridRecapPurchasing.DataSource = value;
                    gvRecapPurchasing.BestFitColumns();
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (SelectedSupplier > 0)
            {
                RefreshDataView();
            }
            else
            {
                this.ShowWarning("Pilih salah satu Supplier");
            }
        }

        public override void RefreshDataView()
        {
            if (!bgwMain.IsBusy)
            {
                MethodBase.GetCurrentMethod().Info("Fecthing purchasing data...");
                FormHelpers.CurrentMainForm.UpdateStatusInformation("Memuat data purchasing...", false);
                bgwMain.RunWorkerAsync();
            }
        }

        private void bgwMain_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                _presenter.LoadData();
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

            FormHelpers.CurrentMainForm.UpdateStatusInformation("Memuat data purchasing selesai", true);
        }

        private void btnPrintAll_Click(object sender, EventArgs e)
        {
            if (ListPurchasing == null || ListPurchasing.Count == 0)
            {
                this.ShowInformation("Data Purchasing tidak ada");
                return;
            }

            try
            {
                List<RecapPurchasingItemViewModel> reportDataSource = ListPurchasing;

                string supplier = (lookupSupplier.GetSelectedDataRow() as SupplierViewModel).Name;
                RecapPurchasingBySupplierPrintItem report = new RecapPurchasingBySupplierPrintItem(supplier, DateFrom, DateTo);
                report.DataSource = reportDataSource;
                report.FillDataSource();

                using (ReportPrintTool printTool = new ReportPrintTool(report))
                {
                    printTool.PrintDialog();
                }
            }
            catch (Exception ex)
            {
                MethodBase.GetCurrentMethod().Fatal("An error occured while trying to print recap purchasing", ex);
                this.ShowError("Print recap purchasing Gagal! Hubungi Developer.");
            }
        }
    }
}
