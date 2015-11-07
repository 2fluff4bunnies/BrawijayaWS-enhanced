using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.Presenter;
using BrawijayaWorkshop.View;
using System;
using System.Collections.Generic;

namespace BrawijayaWorkshop.Win32App.ModulForms
{
    public partial class CustomerEditorForm : BaseEditorForm, ICustomerEditorView
    {
        private CustomerEditorPresenter _presenter;

        public CustomerEditorForm(CustomerEditorModel model)
        {
            InitializeComponent();
            _presenter = new CustomerEditorPresenter(this, model);

            // set validation alignment
            valCode.SetIconAlignment(txtCode, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            valCompanyName.SetIconAlignment(txtCompanyName, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            valAddress.SetIconAlignment(txtAddress, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            valCity.SetIconAlignment(cbCity, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            valContact.SetIconAlignment(txtContactName, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            valPhone.SetIconAlignment(txtPhoneNumber, System.Windows.Forms.ErrorIconAlignment.MiddleRight);

            this.Load += CustomerEditorForm_Load;
        }

        private void CustomerEditorForm_Load(object sender, EventArgs e)
        {
            _presenter.InitFormData();
        }

        public Customer SelectedCustomer { get; set; }

        #region Field Editor
        public string Code
        {
            get
            {
                return txtCode.Text;
            }
            set
            {
                txtCode.Text = value;
            }
        }

        public new string CompanyName
        {
            get
            {
                return txtCompanyName.Text;
            }
            set
            {
                txtCompanyName.Text = value;
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

        public string ContactPerson
        {
            get
            {
                return txtContactName.Text;
            }
            set
            {
                txtContactName.Text = value;
            }
        }

        public int CityId
        {
            get
            {
                City selected = cbCity.GetSelectedDataRow() as City;
                if (selected == null) return 0;
                return selected.Id;
            }
            set
            {
                cbCity.EditValue = value;
            }
        }
        #endregion

        public List<City> ListCity { get; set; }

        protected override void ExecuteSave()
        {
            if(valCode.Validate() && valCompanyName.Validate() && valAddress.Validate() &&
                valCity.Validate() && valPhone.Validate() && valContact.Validate())
            {
                _presenter.SaveChanges();
            }
        }
    }
}