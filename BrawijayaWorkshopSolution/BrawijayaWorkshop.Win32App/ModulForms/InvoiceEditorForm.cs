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
            valPaymentMethod.SetIconAlignment(cbPaymentType, System.Windows.Forms.ErrorIconAlignment.MiddleRight); ;

            this.Load += InvoiceEditorForm_Load;
        }

        private void InvoiceEditorForm_Load(object sender, EventArgs e)
        {
            _presenter.InitFormData();
            if(isContractWork)
            {
                txtFeeService20.Visible = true;
                lblFeeService20.Visible = true;
            }
            else
            {
                txtFeeService20.Visible = false;
                lblFeeService20.Visible = false;
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

        protected override void ExecuteSave()
        {
            if (this.TotalPayment <= this.TotalTransaction)
            {
                if (valPaymentMethod.Validate())
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
            else
            {
                this.ShowError("Jumlah pembayaran melebihi jumlah total harga");
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

        public decimal TotalFeeSparepart
        {
            get
            {
                return txtFeeSparepart.Text.AsDecimal();
            }
            set
            {
                txtFeeSparepart.Text = value.ToString("#,##");
            }
        }

        public decimal TotalService
        {
            get
            {
                if (!string.IsNullOrEmpty(txtTotalService.Text))
                {
                    return txtTotalService.Text.AsDecimal();
                }
                else
                {
                    return 0;
                }
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
                if (!string.IsNullOrEmpty(txtTotalServicePlusFee.Text))
                {
                    return txtTotalServicePlusFee.Text.AsDecimal();
                }
                else
                {
                    return 0;
                }
            }
            set
            {
                txtTotalServicePlusFee.Text = value.ToString("#,##");
            }
        }

        public decimal TotalFeeService10
        {
            get
            {
                return txtFeeService10.Text.AsDecimal();
            }
            set
            {
                txtFeeService10.Text = value.ToString("#,##");
            }
        }

        public decimal TotalFeeService20
        {
            get
            {
                return txtFeeService20.Text.AsDecimal();
            }
            set
            {
                txtFeeService20.Text = value.ToString("#,##");
            }
        }

        public bool IsApplyToAll
        {
            get
            {
                return chkApplyToAll.Checked;
            }
            set
            {
                chkApplyToAll.Checked = value;
            }
        }

        public bool isContractWork { get; set; }

        public double MasterFee
        {
            get
            {
                return !string.IsNullOrEmpty(txtMasterFee.Text) ? txtMasterFee.Text.AsDouble() : 0;
            }
            set
            {
                txtMasterFee.Text = value.ToString();
            }
        }

        private void txtMasterFee_EditValueChanged(object sender, EventArgs e)
        {
            if (chkApplyToAll.Checked)
            {
                foreach (var itemInvoice in ListInvoiceDetail)
                {
                    itemInvoice.FeePctg = MasterFee.AsDouble();
                    itemInvoice.SubTotalPrice = itemInvoice.ItemPrice.AsDouble() + (itemInvoice.ItemPrice.AsDouble() * itemInvoice.FeePctg / 100);
                }
                TotalSparepart = ListInvoiceDetail.Sum(x => x.ItemPrice);
                TotalSparepartPlusFee = ListInvoiceDetail.Sum(x => x.SubTotalPrice).AsDecimal();
                TotalFeeSparepart = TotalSparepartPlusFee - TotalSparepart;
                TotalTransaction = TotalSparepartPlusFee + TotalServicePlusFee;
            }
        }

        private void chkApplyToAll_EditValueChanged(object sender, EventArgs e)
        {
            if (chkApplyToAll.Checked)
            {
                List<InvoiceDetailViewModel> list = ListInvoiceDetail;
                foreach (var itemInvoice in list)
                {
                    itemInvoice.FeePctg = MasterFee.AsDouble();
                    itemInvoice.SubTotalPrice = itemInvoice.ItemPrice.AsDouble() + (itemInvoice.ItemPrice.AsDouble() * itemInvoice.FeePctg / 100);
                }
                ListInvoiceDetail = list;
                TotalSparepart = ListInvoiceDetail.Sum(x => x.ItemPrice);
                TotalSparepartPlusFee = ListInvoiceDetail.Sum(x => x.SubTotalPrice).AsDecimal();
                TotalFeeSparepart = TotalSparepartPlusFee - TotalSparepart;
                TotalTransaction = TotalSparepartPlusFee + TotalServicePlusFee;
            }
        }

        private void gvSparepart_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName != "FeePctg") return;
            double cellValue = e.Value.AsDouble();
            if (MasterFee != cellValue)
            {
                chkApplyToAll.Checked = false;
            }
            List<InvoiceDetailViewModel> list = ListInvoiceDetail;
            foreach (var itemInvoice in list)
            {
                itemInvoice.SubTotalPrice = itemInvoice.ItemPrice.AsDouble() + (itemInvoice.ItemPrice.AsDouble() * itemInvoice.FeePctg / 100);
            }
            ListInvoiceDetail = list;
            TotalSparepart = ListInvoiceDetail.Sum(x => x.ItemPrice);
            TotalSparepartPlusFee = ListInvoiceDetail.Sum(x => x.SubTotalPrice).AsDecimal();
            TotalFeeSparepart = TotalSparepartPlusFee - TotalSparepart;
            TotalTransaction = TotalSparepartPlusFee + TotalServicePlusFee;
        }

        private void cbPaymentType_EditValueChanged(object sender, EventArgs e)
        {
            ReferenceViewModel refSelected = (sender as DevExpress.XtraEditors.LookUpEdit).GetSelectedDataRow() as ReferenceViewModel;
            if (refSelected != null)
            {
                if (refSelected.Code == DbConstant.REF_INVOICE_PAYMENTMETHOD_UANGMUKA_KAS ||
                    refSelected.Code == DbConstant.REF_INVOICE_PAYMENTMETHOD_UANGMUKA_BANK_EKONOMI ||
                    refSelected.Code == DbConstant.REF_INVOICE_PAYMENTMETHOD_UANGMUKA_BANK_BCA1 ||
                    refSelected.Code == DbConstant.REF_INVOICE_PAYMENTMETHOD_UANGMUKA_BANK_BCA2 ||
                    refSelected.Code == DbConstant.REF_INVOICE_PAYMENTMETHOD_PIUTANG)
                {
                    TotalPayment = 0;
                }
                else
                {
                    TotalPayment = TotalTransaction;
                }

                if (refSelected.Code == DbConstant.REF_INVOICE_PAYMENTMETHOD_UANGMUKA_KAS ||
                    refSelected.Code == DbConstant.REF_INVOICE_PAYMENTMETHOD_UANGMUKA_BANK_EKONOMI ||
                    refSelected.Code == DbConstant.REF_INVOICE_PAYMENTMETHOD_UANGMUKA_BANK_BCA1 ||
                    refSelected.Code == DbConstant.REF_INVOICE_PAYMENTMETHOD_UANGMUKA_BANK_BCA2)
                {
                    txtTotalPayment.ReadOnly = false;
                }
                else
                {
                    txtTotalPayment.ReadOnly = true;
                }

            }
        }

        private void bgwSave_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            try
            {
                ExecuteSave();
            }
            catch (Exception ex)
            {
                MethodBase.GetCurrentMethod().Fatal("An error occured while trying to save invoice: '" + SelectedInvoice.Code + "'" + "at date :'" + SelectedInvoice.CreateDate + "'", ex);
                e.Result = ex;
            }
        }

        private void bgwSave_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            if (e.Result is Exception)
            {
                this.ShowError("Proses penyimpanan data invoice gagal!");
            }
            else
            {
                FormHelpers.CurrentMainForm.UpdateStatusInformation("proses penyimpanan data invoice selesai", true);
                this.Close();
            }
        }
    }
}