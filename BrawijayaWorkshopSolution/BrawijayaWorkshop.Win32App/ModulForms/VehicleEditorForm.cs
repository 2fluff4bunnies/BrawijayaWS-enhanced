﻿using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.Presenter;
using BrawijayaWorkshop.View;
using System;
using System.Collections.Generic;
using BrawijayaWorkshop.Utils;

namespace BrawijayaWorkshop.Win32App.ModulForms
{
    public partial class VehicleEditorForm : BaseEditorForm, IVehicleEditorView
    {
        private VehicleEditorPresenter _presenter;

        public VehicleEditorForm(VehicleEditorModel model)
        {
            InitializeComponent();
            _presenter = new VehicleEditorPresenter(this, model);

            // set validation alignment
            FieldsValidator.SetIconAlignment(lookUpCustomer, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            FieldsValidator.SetIconAlignment(txtBrand, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            FieldsValidator.SetIconAlignment(txtType, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            FieldsValidator.SetIconAlignment(txtYearOfPurchase, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            FieldsValidator.SetIconAlignment(txtLicenseNumber, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            FieldsValidator.SetIconAlignment(dtpExpirationDate, System.Windows.Forms.ErrorIconAlignment.MiddleRight);

            this.Load += VehicleEditorForm_Load;
        }

        private void VehicleEditorForm_Load(object sender, EventArgs e)
        {
            if (SelectedVehicle != null)
            {
                lblExpirationDate.Visible = false;
                dtpExpirationDate.Visible = false;
                txtLicenseNumber.Enabled = false;
            }
            _presenter.InitFormData();
        }

        public Vehicle SelectedVehicle { get; set; }

        #region Field Editor
        public string Type
        {
            get
            {
                return txtType.Text;
            }
            set
            {
                txtType.Text = value;
            }
        }

        public string Brand
        {
            get
            {
                return txtBrand.Text;
            }
            set
            {
                txtBrand.Text = value;
            }
        }

        public int CustomerId
        {
            get
            {
                Customer selected = lookUpCustomer.GetSelectedDataRow() as Customer;
                if (selected == null) return 0;
                return selected.Id;
            }
            set
            {
                lookUpCustomer.EditValue = value;
            }
        }

        public int YearOfPurchase
        {
            get
            {
                return txtYearOfPurchase.Text.AsInteger();
            }
            set
            {
                txtYearOfPurchase.Text = value.ToString();
            }
        }

        public string ActiveLicenseNumber
        {
            get
            {
                return txtLicenseNumber.Text;
            }
            set
            {
                txtLicenseNumber.Text = value;
            }
        }

        public DateTime ExpirationDate
        {
            get
            {
               return dtpExpirationDate.Text.AsDateTime();
            }
            set
            {
                dtpExpirationDate.Text = value.ToString();
            }
        }

        public List<Customer> CustomerList
        {
            get
            {
                return lookUpCustomer.Properties.DataSource as List<Customer>;
            }
            set
            {
                lookUpCustomer.Properties.DataSource = value;
            }
        }
        #endregion

        protected override void ExecuteSave()
        {
            if (FieldsValidator.Validate())
            {
                _presenter.SaveChanges();
                this.Close();
            }
        }



    }
}