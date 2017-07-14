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
    public partial class CreditListControl : BaseAppUserControl, ICreditListView
    {
        private CreditListPresenter _presenter;
        private InvoiceViewModel _selectedInvoice;

        protected override string ModulName
        {
            get
            {
                return DbConstant.MODUL_CREDIT;
            }
        }

        public CreditListControl(CreditListModel model)
        {
            InitializeComponent();
            _presenter = new CreditListPresenter(this, model);

            gvCredit.PopupMenuShowing += gvCredit_PopupMenuShowing;
            gvCredit.FocusedRowChanged += gvCredit_FocusedRowChanged;

            // init editor control accessibility
            cmsNewPayment.Enabled = AllowInsert;
            cmsListPayment.Enabled = AllowEdit;

            this.Load += CreditListControl_Load;
        }

        private void CreditListControl_Load(object sender, EventArgs e)
        {
            _presenter.InitData();
            btnSearch.PerformClick();
        }

        private void gvCredit_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            this.SelectedInvoice = gvCredit.GetFocusedRow() as InvoiceViewModel;
            if (this.SelectedInvoice != null)
            {
                if (this.SelectedInvoice.PaymentStatus == (int)DbConstant.PaymentStatus.NotSettled)
                {
                    cmsNewPayment.Visible = true;
                    cmsListPayment.Visible = true;
                }
                else if (this.SelectedInvoice.PaymentStatus == (int)DbConstant.PaymentStatus.Settled)
                {
                    cmsNewPayment.Visible = false;
                    cmsListPayment.Visible = true;
                }
            }
        }

        private void gvCredit_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
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

        public List<InvoiceViewModel> InvoiceListData
        {
            get
            {
                return gridCredit.DataSource as List<InvoiceViewModel>;
            }
            set
            {
                if (InvokeRequired)
                {
                    this.Invoke(new MethodInvoker(delegate { gridCredit.DataSource = value; gvCredit.BestFitColumns(); }));
                }
                else
                {
                    gridCredit.DataSource = value;
                    gvCredit.BestFitColumns();
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

        public string CreditStatusPayment
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

        public List<VehicleGroupViewModel> VehicleGroupListOption
        {
            get
            {
                return lookUpVehicleGroup.Properties.DataSource as List<VehicleGroupViewModel>;
            }
            set
            {
                lookUpVehicleGroup.Properties.DataSource = value;
            }
        }

        public int SelectedVehicleGroupId
        {
            get
            {
                return lookUpVehicleGroup.EditValue.AsInteger();
            }
        }

        public int SelectedCustomerId
        {
            get
            {
                return lookUpCustomer.EditValue.AsInteger();
            }
        }

        public string LicenseNumberFilter
        {
            get
            {
                if (txtLicenseNumberFilter.EditValue != null)
                {
                    return txtLicenseNumberFilter.EditValue.ToString();
                }
                else
                {
                    return null;
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
                MethodBase.GetCurrentMethod().Info("Fecthing Credit data...");
                _selectedInvoice = null;
                FormHelpers.CurrentMainForm.UpdateStatusInformation("Memuat data Credit...", false);
                bgwMain.RunWorkerAsync();
            }
        }

        private void cmsNewPayment_Click(object sender, EventArgs e)
        {
            if (_selectedInvoice != null)
            {
                CreditEditorForm editor = Bootstrapper.Resolve<CreditEditorForm>();
                editor.SelectedInvoice = SelectedInvoice;
                editor.ShowDialog(this);

                btnSearch.PerformClick();
            }
        }

        private void cmsListPayment_Click(object sender, EventArgs e)
        {
            if (_selectedInvoice != null)
            {
                CreditPaymentListForm list = Bootstrapper.Resolve<CreditPaymentListForm>();
                list.SelectedInvoice = SelectedInvoice;
                list.ShowDialog(this);

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
                MethodBase.GetCurrentMethod().Fatal("An error occured while trying to execute _presenter.LoadCredit()", ex);
                e.Result = ex;
            }
        }

        private void bgwMain_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Result is Exception)
            {
                this.ShowError("Proses memuat data gagal!");
            }

            if (gvCredit.RowCount > 0)
            {
                SelectedInvoice = gvCredit.GetRow(0) as InvoiceViewModel;

                if (this.SelectedInvoice != null)
                {
                    if (this.SelectedInvoice.PaymentStatus == (int)DbConstant.PaymentStatus.NotSettled)
                    {
                        cmsNewPayment.Visible = true;
                        cmsListPayment.Visible = true;
                    }
                    else if (this.SelectedInvoice.PaymentStatus == (int)DbConstant.PaymentStatus.Settled)
                    {
                        cmsNewPayment.Visible = false;
                        cmsListPayment.Visible = true;
                    }
                }
            }

            FormHelpers.CurrentMainForm.UpdateStatusInformation("Memuat data Credit selesai", true);
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

        public string ExportFileName { get; set; }

        private void btnExportToCSV_Click(object sender, EventArgs e)
        {
            if (!bgwExport.IsBusy && !bgwMain.IsBusy)
            {
                ExportFileName = string.Empty;
                btnSearch.PerformClick();
                exportDialog.FileName = "Credit_" + SelectedCustomerId + "_" + DateTime.Now.ToString("yyyyMMdd_HHmmssfff") + ".csv";
                exportDialog.ShowDialog(this);
            }
        }

        private void exportDialog_FileOk(object sender, CancelEventArgs e)
        {
            ExportFileName = exportDialog.FileName;

            MethodBase.GetCurrentMethod().Info("Exporting Credit data...");
            FormHelpers.CurrentMainForm.UpdateStatusInformation("Proses export data Credit...", false);
            bgwExport.RunWorkerAsync();
        }

        private void gvCredit_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            ColumnView view = sender as ColumnView;
            if (e.Column.FieldName == "PaymentStatus" && e.ListSourceRowIndex != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
            {
                int status = (int)view.GetListSourceRowCellValue(e.ListSourceRowIndex, "PaymentStatus");
                switch (status)
                {
                    case 0: e.DisplayText = "Belum Lunas"; break;
                    case 1: e.DisplayText = "Lunas"; break;
                }
            }
        }

        private void lookUpCustomer_EditValueChanged(object sender, EventArgs e)
        {
            _presenter.LoadVehicleGroups();
        }
    }
}
