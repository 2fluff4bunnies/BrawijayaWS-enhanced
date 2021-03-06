﻿using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.Presenter;
using BrawijayaWorkshop.SharedObject.ViewModels;
using BrawijayaWorkshop.Utils;
using BrawijayaWorkshop.View;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace BrawijayaWorkshop.Win32App.ModulForms
{
    public partial class DebtEditorForm : BaseEditorForm, IDebtEditorView
    {
        private DebtEditorPresenter _presenter;

        public DebtEditorForm(DebtEditorModel model)
        {
            InitializeComponent();
            _presenter = new DebtEditorPresenter(this, model);

            valPaymentMethod.SetIconAlignment(cbPaymentType, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            valTotalPayment.SetIconAlignment(txtTotalPayment, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
        }

        private void DebtEditorForm_Load(object sender, EventArgs e)
        {
            _presenter.InitFormData();
        }

        public TransactionViewModel SelectedDebt { get; set; }

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

        public new string SuppierName
        {
            get
            {
                return txtSupplier.Text;
            }
            set
            {
                txtSupplier.Text = value;
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

        public decimal TotalPaid
        {
            get
            {
                return txtTotalPaid.EditValue.AsDecimal();
            }
            set
            {
                txtTotalPaid.EditValue = value;
            }
        }

        public decimal TotalNotPaid
        {
            get
            {
                return txtTotalNotPaid.EditValue.AsDecimal();
            }
            set
            {
                txtTotalNotPaid.EditValue = value;
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
                        MethodBase.GetCurrentMethod().Info("Save Debt's changes");
                        _presenter.SaveChanges();
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MethodBase.GetCurrentMethod().Fatal("An error occured while trying to save Debt: '" + SelectedDebt.Id + "'", ex);
                        this.ShowError("Proses simpan data Debt: '" + SelectedDebt.Id + "' gagal!");
                    }
                }
            }
            else
            {
                this.ShowError("Jumlah pembayaran melebihi jumlah total utang");
            }
            
        }

        public PurchasingViewModel SelectedPurchasing { get; set; }

        private void bgwSave_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            try
            {
                ExecuteSave();
            }
            catch (Exception ex)
            {
                MethodBase.GetCurrentMethod().Fatal("An error occured while trying to save debt: '" + SelectedDebt.Description + "'" + "at date :'" + SelectedDebt.CreateDate + "'", ex);
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