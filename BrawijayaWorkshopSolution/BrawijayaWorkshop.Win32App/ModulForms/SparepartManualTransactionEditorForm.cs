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
    public partial class SparepartManualTransactionEditorForm : BaseEditorForm, ISparepartManualTransactionEditorView
    {
        private SparepartManualTransactionEditorPresenter _presenter;

        public SparepartManualTransactionEditorForm(SparepartManualTransactionEditorModel model)
        {
            InitializeComponent();
            _presenter = new SparepartManualTransactionEditorPresenter(this, model);

            // set validation alignment
            valMode.SetIconAlignment(cbMode, System.Windows.Forms.ErrorIconAlignment.MiddleRight);

            this.Load += SparepartsTransactionEditorForm_Load;
        }

        private void SparepartsTransactionEditorForm_Load(object sender, EventArgs e)
        {
            _presenter.InitFormData();

            if (this.IsWheel)
            {
                txtSerialNumber.Enabled = true;
                txtQtyUpdate.Text = "1";
                txtQtyUpdate.Enabled = false;
            }
            else
            {
                txtSerialNumber.Enabled = false;
                txtQtyUpdate.Text = "0";
                txtQtyUpdate.Enabled = true;
            }
        }

        public SparepartManualTransactionViewModel SelectedSparepartManualTransaction { get; set; }

        #region Field Editor
        public bool IsManual { get; set; }

        public List<ReferenceViewModel> ListTransactionTypeReference
        {
            get
            {
                return cbMode.Properties.DataSource as List<ReferenceViewModel>;
            }
            set
            {
                cbMode.Properties.DataSource = value;
            }
        }

        public string SparepartName
        {
            get
            {
                return txtSparepartName.Text;
            }
            set
            {
                txtSparepartName.Text = value;
            }
        }

        public int Stock
        {
            get
            {
                return !string.IsNullOrEmpty(txtStok.Text) ? txtStok.Text.AsInteger() : 0;
            }
            set
            {
                txtStok.Text = value.ToString();
            }
        }

        public int StockUpdate
        {
            get
            {
                return !string.IsNullOrEmpty(txtQtyUpdate.Text) ? txtQtyUpdate.Text.AsInteger() : 0;
            }
            set
            {
                txtQtyUpdate.Text = value.ToString();
            }
        }

        public decimal Price
        {
            get
            {
                return !string.IsNullOrEmpty(txtItemPrice.Text) ? txtItemPrice.Text.AsDecimal() : 0;
            }
            set
            {
                txtItemPrice.Text = value.ToString();
            }
        }

        public decimal TotalPrice
        {
            get
            {
                return !string.IsNullOrEmpty(txtTotalPrice.Text) ? txtTotalPrice.Text.AsDecimal() : 0;
            }
            set
            {
                txtTotalPrice.Text = value.ToString();
            }
        }

        public string Remark
        {
            get
            {
                return txtRemark.Text;
            }
            set
            {
                txtRemark.Text = value;
            }
        }

        public int TransactionTypeId
        {
            get
            {
                ReferenceViewModel selected = cbMode.GetSelectedDataRow() as ReferenceViewModel;
                if (selected == null) return 0;
                return selected.Id;
            }
            set
            {
                cbMode.EditValue = value;
            }
        }
        public int SparepartId { get; set; }

        public string SerialNumber
        {
            get
            {
                return txtSerialNumber.Text;
            }
            set
            {
                txtSerialNumber.Text = value;
            }
        }
        public bool IsWheel { get; set; }

        #endregion
        public SparepartViewModel Sparepart { get; set; }

        protected override void ExecuteSave()
        {
            if (valMode.Validate() && valQty.Validate())
            {
                try
                {
                    MethodBase.GetCurrentMethod().Info("Save Sparepart Transaction's changes");
                    _presenter.SaveChanges();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MethodBase.GetCurrentMethod().Fatal("An error occured while trying to save SparepartManualTransaction: '" + SelectedSparepartManualTransaction.Sparepart.Name + "'", ex);
                    this.ShowError("Proses simpan data transaksi barang bekas: '" + SelectedSparepartManualTransaction.Sparepart.Name + "' gagal!");
                }
            }
        }

        private void txtQtyUpdate_EditValueChanged(object sender, EventArgs e)
        {
            TotalPrice = Price * StockUpdate;
        }

        private void txtItemPrice_EditValueChanged(object sender, EventArgs e)
        {
            TotalPrice = Price * StockUpdate;
        }
    }
}