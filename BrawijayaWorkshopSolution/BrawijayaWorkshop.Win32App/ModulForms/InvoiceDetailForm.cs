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
            if (isContractWork)
            {
                txtValueAdded.Visible = true;
                lblValueAdded.Visible = true;
            }
            else
            {
                txtValueAdded.Visible = false;
                lblValueAdded.Visible = false;
            }
        }

        public TransactionViewModel SelectedTransaction { get; set; }
        public InvoiceViewModel SelectedInvoice { get; set; }

        #region Field Editor
        public DateTime Date
        {
            get
            {
                return deTransDate.EditValue.AsDateTime();
            }
            set
            {
                deTransDate.EditValue = value;
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
        public decimal TotalTransaction
        {
            get
            {
                return txtTotalTransaction.EditValue.AsDecimal();
            }
            set
            {
                txtTotalTransaction.EditValue = value;
            }
        }

        public decimal TotalPayment
        {
            get
            {
                return txtTotalPayment.EditValue.AsDecimal();
            }
            set
            {
                txtTotalPayment.EditValue = value;
            }
        }

        public decimal TotalSparepart
        {
            get
            {
                return txtTotalSparepart.EditValue.AsDecimal();
            }
            set
            {
                txtTotalSparepart.EditValue = value;
            }
        }

        public decimal TotalSparepartPlusFee
        {
            get
            {
                return txtTotalSparepartPlusFee.EditValue.AsDecimal();
            }
            set
            {
                txtTotalSparepartPlusFee.EditValue = value;
            }
        }

        public decimal TotalFeeSparepart
        {
            get
            {
                return txtFeeSparepart.EditValue.AsDecimal();
            }
            set
            {
                txtFeeSparepart.EditValue = value;
            }
        }

        public decimal TotalService
        {
            get
            {
                return txtTotalService.EditValue.AsDecimal();
            }
            set
            {
                txtTotalService.EditValue = value;
            }
        }
        public decimal TotalServicePlusFee
        {
            get
            {
                return txtTotalServicePlusFee.EditValue.AsDecimal();
            }
            set
            {
                txtTotalServicePlusFee.EditValue = value;
            }
        }

        public decimal TotalFeeService
        {
            get
            {
                return txtFeeService.EditValue.AsDecimal();
            }
            set
            {
                txtFeeService.EditValue = value;
            }
        }

        public decimal TotalValueAdded
        {
            get
            {
                return txtValueAdded.EditValue.AsDecimal();
            }
            set
            {
                txtValueAdded.EditValue = value;
            }
        }
        public decimal TotalSparepartAndService { get; set; }

        public bool isContractWork { get; set; }

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
            this.Close();
        }
    }
}