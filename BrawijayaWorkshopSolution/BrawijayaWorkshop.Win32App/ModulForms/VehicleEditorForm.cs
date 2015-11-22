using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.Presenter;
using BrawijayaWorkshop.View;
using System;
using System.Collections.Generic;

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
            valCustomer.SetIconAlignment(cbCustomer, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            valBrand.SetIconAlignment(txtBrand, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            valType.SetIconAlignment(txtType, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            valYearOfBuy.SetIconAlignment(dtpYearOfBuy, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
        

            this.Load += VehicleEditorForm_Load;
        }

        private void VehicleEditorForm_Load(object sender, EventArgs e)
        {
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

        public new string Brand
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

        public string YearOfBuy
        {
            get
            {
                return dtpYearOfBuy.Text;
            }
            set
            {
                dtpYearOfBuy.Text = value;
            }
        }

       
        public int CustomerId
        {
            get
            {
                Customer selected = cbCustomer.GetSelectedDataRow() as Customer;
                if (selected == null) return 0;
                return selected.Id;
            }
            set
            {
                cbCustomer.EditValue = value;
            }
        }
        #endregion

        public List<Customer> CustomerList { get; set; }

        protected override void ExecuteSave()
        {
            if(valCustomer.Validate() && valBrand.Validate() && valType.Validate() &&
                valYearOfBuy.Validate())
            {
                _presenter.SaveChanges();
            }
        }
    }
}