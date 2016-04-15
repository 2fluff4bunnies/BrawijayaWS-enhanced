using BrawijayaWorkshop.Constant;
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
    public partial class UsedGoodTransactionEditorForm : BaseEditorForm, IUsedGoodTransactionEditorView
    {
        private UsedGoodTransactionEditorPresenter _presenter;

        public UsedGoodTransactionEditorForm(UsedGoodTransactionEditorModel model)
        {
            InitializeComponent();
            _presenter = new UsedGoodTransactionEditorPresenter(this, model);

            // set validation alignment
            valMode.SetIconAlignment(cbMode, System.Windows.Forms.ErrorIconAlignment.MiddleRight);

            this.Load += UsedGoodTransactionEditorForm_Load;
        }

        private void UsedGoodTransactionEditorForm_Load(object sender, EventArgs e)
        {
            _presenter.InitFormData();
            txtItemPrice.Visible = false;
            lblItemPrice.Visible = false;
                
            if (IsManual)
            {
                cbUsedGood.ReadOnly = true;
            }
            else
            {
                cbUsedGood.ReadOnly = false;
            }
        }

        public UsedGoodTransactionViewModel SelectedUsedGoodTransaction { get; set; }

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
        public List<UsedGoodViewModel> UsedGoodListCombo
        {
            get
            {
                return cbUsedGood.Properties.DataSource as List<UsedGoodViewModel>;
            }
            set
            {
                cbUsedGood.Properties.DataSource = value;
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

        public double ItemPrice
        {
            get
            {
                return !string.IsNullOrEmpty(txtItemPrice.Text) ? txtItemPrice.Text.AsDouble() : 0;
            }
            set
            {
                txtItemPrice.Text = value.ToString();
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
        public int UsedGoodId
        {
            get
            {
                UsedGoodViewModel selected = cbUsedGood.GetSelectedDataRow() as UsedGoodViewModel;
                if (selected == null)
                {
                    return 0;
                }
                else
                {
                    return selected.Id;
                }
                
            }
            set
            {
                cbUsedGood.EditValue = value;
            }
        }
        #endregion
        public UsedGoodViewModel UsedGood { get; set; }

        protected override void ExecuteSave()
        {
            if (valMode.Validate() && valQty.Validate())
            {
                try
                {
                    MethodBase.GetCurrentMethod().Info("Save Used Good Transaction's changes");
                    _presenter.SaveChanges();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MethodBase.GetCurrentMethod().Fatal("An error occured while trying to save UsedGoodTransaction: '" + SelectedUsedGoodTransaction.UsedGood.Sparepart.Name + "'", ex);
                    this.ShowError("Proses simpan data transaksi barang bekas: '" + SelectedUsedGoodTransaction.UsedGood.Sparepart.Name + "' gagal!");
                }
            }
        }

        private void cbUsedGood_EditValueChanged(object sender, EventArgs e)
        {
            UsedGoodViewModel model = cbUsedGood.GetSelectedDataRow() as UsedGoodViewModel; ;
            this.Stock = model.Stock;
        }

        private void cbMode_EditValueChanged(object sender, EventArgs e)
        {
            ReferenceViewModel model = cbMode.GetSelectedDataRow() as ReferenceViewModel; ;
            if(model.Code == DbConstant.REF_USEDGOOD_TRANSACTION_TYPE_SOLD)
            {
                txtItemPrice.Visible = true;
                lblItemPrice.Visible = true;
            }
            else
            {
                txtItemPrice.Visible = false;
                lblItemPrice.Visible = false;
                this.ItemPrice = 0;
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
                MethodBase.GetCurrentMethod().Fatal("An error occured while trying to save used good transaction: '" + SelectedUsedGoodTransaction.Id + "'" + "at date :'" + SelectedUsedGoodTransaction.CreateDate + "'", ex);
                e.Result = ex;
            }
        }

        private void bgwSave_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            if (e.Result is Exception)
            {
                this.ShowError("Proses penyimpanan data transaksi barang bekas gagal!");
            }
            else
            {
                FormHelpers.CurrentMainForm.UpdateStatusInformation("proses penyimpanan data transaksi barang bekas selesai", true);
                this.Close();
            }
        }
    }
}