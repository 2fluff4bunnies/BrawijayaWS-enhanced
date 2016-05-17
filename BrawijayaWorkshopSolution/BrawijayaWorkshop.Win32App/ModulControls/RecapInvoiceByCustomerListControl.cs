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

namespace BrawijayaWorkshop.Win32App.ModulControls
{
    public partial class RecapInvoiceByCustomerListControl : BaseAppUserControl, IRecapInvoiceByCustomerView
    {
        private RecapInvoiceByCustomerPresenter _presenter;

        public RecapInvoiceByCustomerListControl(RecapInvoiceByCustomerModel model)
        {
            InitializeComponent();
            _presenter = new RecapInvoiceByCustomerPresenter(this, model);

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

        public int SelectedCustomer
        {
            get
            {
                return lookupCustomer.EditValue.AsInteger();
            }
            set
            {
                lookupCustomer.EditValue = value;
            }
        }

        public List<CustomerViewModel> ListCustomer
        {
            get
            {
                return lookupCustomer.Properties.DataSource as List<CustomerViewModel>;
            }
            set
            {
                lookupCustomer.Properties.DataSource = value;
            }
        }

        public int SelectedCategory
        {
            get
            {
                return lookupCategory.EditValue.AsInteger();
            }
            set
            {
                lookupCategory.EditValue = value;
            }
        }

        public List<ReferenceViewModel> ListCategory
        {
            get
            {
                return lookupCategory.Properties.DataSource as List<ReferenceViewModel>;
            }
            set
            {
                lookupCategory.Properties.DataSource = value;
            }
        }

        public List<RecapInvoiceItemViewModel> ListInvoices
        {
            get
            {
                return gridRecapInvoice.DataSource as List<RecapInvoiceItemViewModel>;
            }
            set
            {
                if (InvokeRequired)
                {
                    this.Invoke(new MethodInvoker(delegate { gridRecapInvoice.DataSource = value; gvRecapInvoice.BestFitColumns(); }));
                }
                else
                {
                    gridRecapInvoice.DataSource = value;
                    gvRecapInvoice.BestFitColumns();
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (SelectedCategory > 0 && SelectedCustomer > 0)
            {
                RefreshDataView();
            }
            else
            {
                this.ShowWarning("Pilih salah satu Kategori dan Customer");
            }
        }

        public override void RefreshDataView()
        {
            if (!bgwMain.IsBusy)
            {
                MethodBase.GetCurrentMethod().Info("Fecthing invoice data...");
                FormHelpers.CurrentMainForm.UpdateStatusInformation("Memuat data invoice...", false);
                bgwMain.RunWorkerAsync();
            }
        }

        private void btnPrintAll_Click(object sender, EventArgs e)
        {

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

            FormHelpers.CurrentMainForm.UpdateStatusInformation("Memuat data invoice selesai", true);
        }
    }
}
