using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.Presenter;
using BrawijayaWorkshop.Utils;
using BrawijayaWorkshop.View;
using System;
using System.Collections.Generic;

namespace BrawijayaWorkshop.Win32App.ModulForms
{
    public partial class VehicleDetailEditorForm : BaseEditorForm, IVehicleDetailEditorView
    {
        private VehicleDetailEditorPresenter _presenter;


        public VehicleDetailEditorForm(VehicleDetailEditorModel model)
        {
            InitializeComponent();
            _presenter = new VehicleDetailEditorPresenter(this, model);
        }

        public VehicleDetail SelectedVehicleDetail { get; set; }

        public string LicenseNumber
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
                throw new NotImplementedException();
            }
        }

        public int SelectedStatus
        {
            get
            {
                return 1;
            }
        }

        protected override void ExecuteSave()
        {
            if (valLicenseNumber.Validate() && valExpirationDate.Validate())
            {
                _presenter.SaveChanges();
                this.Close();
            }
        }


    }
}