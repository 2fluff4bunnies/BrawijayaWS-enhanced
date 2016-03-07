using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.Presenter;
using BrawijayaWorkshop.SharedObject.ViewModels;
using BrawijayaWorkshop.Utils;
using BrawijayaWorkshop.View;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace BrawijayaWorkshop.Win32App.ModulForms
{
    public partial class InvoiceEditorForm : BaseEditorForm, IInvoiceEditorView
    {
        private InvoiceEditorPresenter _presenter;

        public InvoiceEditorForm(InvoiceEditorModel model)
        {
            InitializeComponent();
            _presenter = new InvoiceEditorPresenter(this, model);

            // set validation alignment
            //valCode.SetIconAlignment(txtCode, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            //valCompanyName.SetIconAlignment(txtCompanyName, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            //valAddress.SetIconAlignment(txtAddress, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            //valCity.SetIconAlignment(cbCity, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            //valContact.SetIconAlignment(txtContactName, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            //valPhone.SetIconAlignment(txtPhoneNumber, System.Windows.Forms.ErrorIconAlignment.MiddleRight);

            this.Load += InvoiceEditorForm_Load;
        }

        private void InvoiceEditorForm_Load(object sender, EventArgs e)
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
                txtTotalTransaction.Text = value.ToString();
            }
        }

        public decimal TotalPayment
        {
            get
            {
                return txtTotalPayment.Text.AsDecimal();
            }
            set
            {
                txtTotalPayment.Text = value.ToString();
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
                return gridSparepart.DataSource as List<InvoiceDetailViewModel>;
            }
            set
            {
                gridSparepart.DataSource = value;
            }
        }

        protected override void ExecuteSave()
        {
            //if (valCode.Validate() && valCompanyName.Validate() && valAddress.Validate() &&
            //    valCity.Validate() && valPhone.Validate() && valContact.Validate())
            if (true)
            {
                try
                {
                    MethodBase.GetCurrentMethod().Info("Save Invoice's changes");
                    _presenter.SaveChanges();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MethodBase.GetCurrentMethod().Fatal("An error occured while trying to save Invoice: '" + SelectedInvoice.Id + "'", ex);
                    this.ShowError("Proses simpan data Invoice: '" + SelectedInvoice.Id + "' gagal!");
                }
            }
        }
    }
}