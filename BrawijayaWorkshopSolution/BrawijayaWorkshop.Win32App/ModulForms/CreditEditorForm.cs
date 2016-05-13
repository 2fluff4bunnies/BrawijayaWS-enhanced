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
    public partial class CreditEditorForm : BaseEditorForm, ICreditEditorView
    {
        private CreditEditorPresenter _presenter;

        public CreditEditorForm(CreditEditorModel model)
        {
            InitializeComponent();
            _presenter = new CreditEditorPresenter(this, model);

            valPaymentMethod.SetIconAlignment(cbPaymentType, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            valTotalPayment.SetIconAlignment(txtTotalPayment, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
        }

        private void CreditEditorForm_Load(object sender, EventArgs e)
        {
            _presenter.InitFormData();
        }

        public TransactionViewModel SelectedCredit { get; set; }

        #region Field Editor
        public DateTime Date
        {
            get
            {
                return Convert.ToDateTime(txtDate.Text);
            }
            set
            {
                txtDate.Text = value.ToString("dd-MM-yyyy");
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
                return string.IsNullOrEmpty(txtTotalTransaction.Text) ? 0 : txtTotalTransaction.Text.AsDecimal();
            }
            set
            {
                txtTotalTransaction.Text = value.ToString("#,#");
            }
        }

        public decimal TotalPaid
        {
            get
            {
                return string.IsNullOrEmpty(txtTotalPaid.Text) ? 0 : txtTotalPaid.Text.AsDecimal();
            }
            set
            {
                txtTotalPaid.Text = value.ToString("#,#");
            }
        }

        public decimal TotalNotPaid
        {
            get
            {
                return string.IsNullOrEmpty(txtTotalNotPaid.Text) ? 0 : txtTotalNotPaid.Text.AsDecimal();
            }
            set
            {
                txtTotalNotPaid.Text = value.ToString("#,#");
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
                txtTotalPayment.Text = value.ToString("#,#");
            }
        }

        public decimal OldTotalPayment { get; set; }
        public decimal OldTotalPaid { get; set; }
        public decimal OldTotalNotPaid { get; set; }

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

        protected override void ExecuteSave()
        {
            if (this.TotalNotPaid >= 0)
            {
                if (valPaymentMethod.Validate() && valTotalPayment.Validate())
                {
                    try
                    {
                        MethodBase.GetCurrentMethod().Info("Save Credit's changes");
                        _presenter.SaveChanges();
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MethodBase.GetCurrentMethod().Fatal("An error occured while trying to save Credit: '" + SelectedCredit.Id + "'", ex);
                        this.ShowError("Proses simpan data Credit: '" + SelectedCredit.Id + "' gagal!");
                    }
                }
            }
            else
            {
                this.ShowError("Jumlah pembayaran melebihi jumlah total piutang");
            }
            
        }

        public InvoiceViewModel SelectedInvoice { get; set; }

        private void bgwSave_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            try
            {
                ExecuteSave();
            }
            catch (Exception ex)
            {
                MethodBase.GetCurrentMethod().Fatal("An error occured while trying to save credit: '" + SelectedCredit.Description + "'" + "at date :'" + SelectedCredit.CreateDate + "'", ex);
                e.Result = ex;
            }
        }

        private void bgwSave_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            if (e.Result is Exception)
            {
                this.ShowError("Proses penyimpanan data pembayaran gagal!");
            }
            else
            {
                FormHelpers.CurrentMainForm.UpdateStatusInformation("proses penyimpanan data pembayaran selesai", true);
                this.Close();
            }
        }

        private void txtTotalPayment_EditValueChanged(object sender, EventArgs e)
        {
            TotalPaid = OldTotalPaid - OldTotalPayment + TotalPayment;
            TotalNotPaid = OldTotalNotPaid + OldTotalPayment - TotalPayment;
        }

    }
}