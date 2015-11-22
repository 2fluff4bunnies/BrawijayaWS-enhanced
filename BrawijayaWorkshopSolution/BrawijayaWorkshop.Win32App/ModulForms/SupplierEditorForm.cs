using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.Presenter;
using BrawijayaWorkshop.View;
using System;
using System.Collections.Generic;

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

        public Supplier SelectedSupplier { get; set; }

        #region Field Editor

        public new string SupplierName
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
                _presenter.SaveChanges();
            }
        }
    }
}