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
    public partial class VehicleGroupEditorForm : BaseEditorForm, IVehicleGroupEditorView
    {
        private VehicleGroupEditorPresenter _presenter;
        public VehicleGroupEditorForm(VehicleGroupEditorModel model)
        {
            InitializeComponent();
            _presenter = new VehicleGroupEditorPresenter(this, model);

            valCustomer.SetIconAlignment(lookupCustomer, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            valName.SetIconAlignment(txtGroupName, System.Windows.Forms.ErrorIconAlignment.MiddleRight);

            this.Load += VehicleGroupEditorForm_Load;
        }

        private void VehicleGroupEditorForm_Load(object sender, EventArgs e)
        {
            _presenter.InitFormData();
        }

        public VehicleGroupViewModel SelectedGroup { get; set; }

        public List<CustomerViewModel> ListCustomer
        {
            get
            {
                return lookupCustomer.Properties.DataSource as List<CustomerViewModel>;
            }
            set
            {
                lookupCustomer.Properties.DataSource = value;
            }
        }

        public int CustomerId
        {
            get
            {
                return lookupCustomer.EditValue.AsInteger();
            }
            set
            {
                lookupCustomer.EditValue = value;
            }
        }

        public string GroupName
        {
            get
            {
                return txtGroupName.Text;
            }
            set
            {
                txtGroupName.Text = value;
            }
        }

        protected override void ExecuteSave()
        {
            if (valCustomer.Validate() && valName.Validate())
            {
                try
                {
                    MethodBase.GetCurrentMethod().Info("Save Vehicle Group's changes");
                    _presenter.SaveChanges();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MethodBase.GetCurrentMethod().Fatal("An error occured while trying to save Vehicle Gruop: '" + SelectedGroup.Name + "'", ex);
                    this.ShowError("Proses simpan data customer: '" + SelectedGroup.Name + "' gagal!");
                }
            }
        }
    }
}