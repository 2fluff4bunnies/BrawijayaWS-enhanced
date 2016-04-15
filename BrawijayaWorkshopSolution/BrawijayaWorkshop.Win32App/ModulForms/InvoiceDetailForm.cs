using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.Presenter;
using BrawijayaWorkshop.SharedObject.ViewModels;
using BrawijayaWorkshop.Utils;
using BrawijayaWorkshop.View;
using DevExpress.XtraGrid.Views.Base;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using System.Windows.Forms;
using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Win32App.PrintItems;
using DevExpress.XtraReports.UI;

namespace BrawijayaWorkshop.Win32App.ModulForms
{
    public partial class InvoiceDetailForm : BaseDefaultForm, IInvoiceDetailView
    {
        private InvoiceDetailPresenter _presenter;

        public InvoiceDetailForm(InvoiceDetailModel model)
        {
            InitializeComponent();
            _presenter = new InvoiceDetailPresenter(this, model);

            this.Load += InvoiceDetailForm_Load;
        }

        private void InvoiceDetailForm_Load(object sender, EventArgs e)
        {
            _presenter.InitFormData();
        }

        public TransactionViewModel SelectedTransaction { get; set; }
        public InvoiceViewModel SelectedInvoice { get; set; }

        #region Field Editor
        public DateTime Date
        {
            get
            {
                return Convert.ToDateTime(txtTransactionDate.Text);
            }
            set
            {
                txtTransactionDate.Text = value.ToString("dd-MM-yyyy");
            }
        }

        public new string CustomerName
        {
            get
            {
                return txtCustomer.Text;
            }
            set
            {
                txtCustomer.Text = value;
            }
        }

        public decimal TotalTransaction
        {
            get
            {
                return txtTotalTransaction.Text.AsDecimal();
            }
            set
            {
                txtTotalTransaction.Text = value.ToString("#,##");
            }
        }

        public decimal TotalPayment
        {
            get
            {
                return string.IsNullOrEmpty(txtTotalPayment.Text) ? 0 : txtTotalPayment.Text.AsDecimal();
            }
            set
            {
                txtTotalPayment.Text = value.ToString("#,##");
            }
        }

        public int PaymentMethodId
        {
            get
            {
                ReferenceViewModel selected = cbPaymentType.GetSelectedDataRow() as ReferenceViewModel;
                if (selected == null) return 0;
                return selected.Id;
            }
            set
            {
                cbPaymentType.EditValue = value;
            }
        }
        #endregion

        public List<ReferenceViewModel> ListPaymentMethod
        {
            get
            {
                return cbPaymentType.Properties.DataSource as List<ReferenceViewModel>;
            }
            set
            {
                cbPaymentType.Properties.DataSource = value;
            }
        }

        public List<InvoiceDetailViewModel> ListInvoiceDetail
        {
            get
            {
                return bsSparepart.DataSource as List<InvoiceDetailViewModel>;
            }
            set
            {
                if (InvokeRequired)
                {
                    this.Invoke(new MethodInvoker(delegate
                    {
                        bsSparepart.DataSource = value;
                        gridSparepart.DataSource = bsSparepart;
                        gvSparepart.BestFitColumns();
                    }));
                }
                else
                {
                    bsSparepart.DataSource = value;
                    gridSparepart.DataSource = bsSparepart;
                    gvSparepart.BestFitColumns();
                }
            }
        }

        public decimal TotalSparepart
        {
            get
            {
                return txtTotalSparepart.Text.AsDecimal();
            }
            set
            {
                txtTotalSparepart.Text = value.ToString("#,##");
            }
        }

        public decimal TotalSparepartPlusFee
        {
            get
            {
                return txtTotalSparepartPlusFee.Text.AsDecimal();
            }
            set
            {
                txtTotalSparepartPlusFee.Text = value.ToString("#,##");
            }
        }

        public decimal TotalService
        {
            get
            {
                return txtTotalService.Text.AsDecimal();
            }
            set
            {
                txtTotalService.Text = value.ToString("#,##");
            }
        }
        public decimal TotalServicePlusFee
        {
            get
            {
                return txtTotalServicePlusFee.Text.AsDecimal();
            }
            set
            {
                txtTotalServicePlusFee.Text = value.ToString("#,##");
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            InvoicePrintItem report = new InvoicePrintItem();
            List<InvoiceViewModel> _dataSource = new List<InvoiceViewModel>();
            _dataSource.Add(SelectedInvoice);
            report.DataSource = _dataSource;
            report.FillDataSource();

            using (ReportPrintTool printTool = new ReportPrintTool(report))
            {
                // Invoke the Print dialog.
                printTool.PrintDialog();
            }
            _presenter.Print();
        }
    }
}