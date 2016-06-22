using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.Presenter;
using BrawijayaWorkshop.SharedObject.ViewModels;
using BrawijayaWorkshop.Utils;
using BrawijayaWorkshop.View;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;

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
            valQty.SetIconAlignment(txtQtyUpdate, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            valItemPrice.SetIconAlignment(txtItemPrice, System.Windows.Forms.ErrorIconAlignment.MiddleRight);

            this.Load += SparepartsTransactionEditorForm_Load;
        }

        private void SparepartsTransactionEditorForm_Load(object sender, EventArgs e)
        {
            _presenter.InitFormData();

            if (this.IsSpecialSparepart)
            {
                txtSerialNumber.Enabled = true;
                txtQtyUpdate.Text = "1";
                txtQtyUpdate.Enabled = false;
                cbMode.Enabled = false;
                cbMode.EditValue = ListTransactionTypeReference.Where(rf => rf.Code == DbConstant.REF_SPAREPART_TRANSACTION_MANUAL_TYPE_PLUS).FirstOrDefault().Id;
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
                return txtQtyUpdate.EditValue.AsInteger();
            }
            set
            {
                txtQtyUpdate.EditValue = value;
            }
        }

        public decimal Price
        {
            get
            {
                return txtItemPrice.EditValue.AsDecimal();
            }
            set
            {
                txtItemPrice.EditValue = value;
            }
        }

        public decimal TotalPrice
        {
            get
            {
                return txtTotalPrice.EditValue.AsDecimal();
            }
            set
            {
                txtTotalPrice.EditValue = value;
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
        public bool IsSpecialSparepart { get; set; }

        #endregion
        public SparepartViewModel Sparepart { get; set; }

        protected override void ExecuteSave()
        {
            ReferenceViewModel selectedTransactionType = ListTransactionTypeReference.Where(x=>x.Id == this.TransactionTypeId).FirstOrDefault();
            if (valMode.Validate() && valQty.Validate() && valItemPrice.Validate() 
                && this.StockUpdate > 0 && selectedTransactionType != null
                && (selectedTransactionType.Value == DbConstant.REF_SPAREPART_TRANSACTION_MANUAL_TYPE_PLUS 
                    || (selectedTransactionType.Value == DbConstant.REF_SPAREPART_TRANSACTION_MANUAL_TYPE_MINUS && this.Stock >= this.StockUpdate)
                    )
                )
            {
                bool ok = true;
                if (this.IsSpecialSparepart)
                {
                    if (string.IsNullOrEmpty(this.SerialNumber))
                    {
                        ok = false;
                        this.ShowWarning("Nomor seri harus diisi.");
                    } 
                    else if (_presenter.IsSerialNumberExist())
                    {
                        ok = false;
                        this.ShowWarning("Nomor seri "+this.SerialNumber+" sudah digunakan.");
                    }
                }

                if (ok)
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
        }

        private void txtQtyUpdate_EditValueChanged(object sender, EventArgs e)
        {
            TotalPrice = Price * StockUpdate;
        }

        private void txtItemPrice_EditValueChanged(object sender, EventArgs e)
        {
            TotalPrice = Price * StockUpdate;
        }

        private void bgwSave_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            try
            {
                ExecuteSave();
            }
            catch (Exception ex)
            {
                MethodBase.GetCurrentMethod().Fatal("An error occured while trying to save manual sparepart: '" + SelectedSparepartManualTransaction.Id + "'" + "at date :'" + SelectedSparepartManualTransaction.CreateDate + "'", ex);
                e.Result = ex;
            }
        }

        private void bgwSave_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            if (e.Result is Exception)
            {
                this.ShowError("Proses penyimpanan data ubah stok sparepart gagal!");
            }
            else
            {
                FormHelpers.CurrentMainForm.UpdateStatusInformation("proses penyimpanan data ubah stok selesai", true);
                this.Close();
            }
        }
    }
}