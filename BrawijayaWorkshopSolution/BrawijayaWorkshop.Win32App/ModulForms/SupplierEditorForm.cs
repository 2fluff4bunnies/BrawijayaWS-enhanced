﻿using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.Presenter;
using BrawijayaWorkshop.SharedObject.ViewModels;
using BrawijayaWorkshop.Utils;
using BrawijayaWorkshop.View;
using System;
using System.Reflection;

namespace BrawijayaWorkshop.Win32App.ModulForms
{
    public partial class SupplierEditorForm : BaseEditorForm, ISupplierEditorView
    {
        private SupplierEditorPresenter _presenter;

        public SupplierEditorForm(SupplierEditorModel model)
        {
            InitializeComponent();
            _presenter = new SupplierEditorPresenter(this, model);

            // set validation alignment
            valSupplierName.SetIconAlignment(txtSupplierName, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            valAddress.SetIconAlignment(txtAddress, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            valPhone.SetIconAlignment(txtPhoneNumber, System.Windows.Forms.ErrorIconAlignment.MiddleRight);

            this.Load += SupplierEditorForm_Load;
        }

        private void SupplierEditorForm_Load(object sender, EventArgs e)
        {
            _presenter.InitFormData();
        }

        public SupplierViewModel SelectedSupplier { get; set; }

        #region Field Editor

        public string SupplierName
        {
            get
            {
                return txtSupplierName.Text;
            }
            set
            {
                txtSupplierName.Text = value;
            }
        }

        public string Address
        {
            get
            {
                return txtAddress.Text;
            }
            set
            {
                txtAddress.Text = value;
            }
        }

        public string PhoneNumber
        {
            get
            {
                return txtPhoneNumber.Text;
            }
            set
            {
                txtPhoneNumber.Text = value;
            }
        }

        #endregion

        protected override void ExecuteSave()
        {
            if (valSupplierName.Validate() && valAddress.Validate() && valPhone.Validate())
            {
                try
                {
                    MethodBase.GetCurrentMethod().Info("Save supplier's changes");
                    _presenter.SaveChanges();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MethodBase.GetCurrentMethod().Fatal("An error occured while trying to save supplier: '" + SelectedSupplier.Name + "'", ex);
                    this.ShowError("Proses simpan data supplier: '" + SelectedSupplier.Name + "' gagal!");
                }
            }
        }
    }
}