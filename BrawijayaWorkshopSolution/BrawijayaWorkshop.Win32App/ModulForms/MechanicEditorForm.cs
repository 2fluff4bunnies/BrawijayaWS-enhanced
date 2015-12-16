using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.Presenter;
using BrawijayaWorkshop.View;
using System;
using System.Collections.Generic;

namespace BrawijayaWorkshop.Win32App.ModulForms
{
    public partial class MechanicEditorForm : BaseEditorForm, IMechanicEditorView
    {
        //public zkemkeeper.CZKEMClass axCZKEM1 = new zkemkeeper.CZKEMClass();

        private MechanicEditorPresenter _presenter;

        public MechanicEditorForm(MechanicEditorModel model)
        {
            InitializeComponent();
            _presenter = new MechanicEditorPresenter(this, model);

            // set validation alignment
            valCode.SetIconAlignment(txtCode, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            valMechanicName.SetIconAlignment(txtMechanicName, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            valAddress.SetIconAlignment(txtAddress, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            valPhone.SetIconAlignment(txtPhoneNumber, System.Windows.Forms.ErrorIconAlignment.MiddleRight);

            this.Load += MechanicEditorForm_Load;
        }

        private void MechanicEditorForm_Load(object sender, EventArgs e)
        {
            _presenter.InitFormData();
        }

        public Mechanic SelectedMechanic { get; set; }

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
        
        public string MechanicName
        {
            get
            {
                return txtMechanicName.Text;
            }
            set
            {
                txtMechanicName.Text = value;
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
            if (valCode.Validate() && valMechanicName.Validate() && valAddress.Validate() && valPhone.Validate())
            {
                _presenter.SaveChanges();
            }
        }
    }
}