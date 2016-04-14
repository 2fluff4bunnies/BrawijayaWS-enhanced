using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.Presenter;
using BrawijayaWorkshop.SharedObject.ViewModels;
using BrawijayaWorkshop.Utils;
using BrawijayaWorkshop.View;
using System;
using System.Reflection;

namespace BrawijayaWorkshop.Win32App.ModulForms
{
    public partial class VehicleDetailEditorForm : BaseEditorForm, IVehicleDetailEditorView
    {
        private VehicleDetailEditorPresenter _presenter;

        public VehicleDetailEditorForm(VehicleDetailEditorModel model)
        {
            InitializeComponent();
            _presenter = new VehicleDetailEditorPresenter(this, model);

            FieldsValidator.SetIconAlignment(txtLicenseNumber, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            FieldsValidator.SetIconAlignment(dtpExpirationDate, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
        }

        public VehicleDetailViewModel SelectedVehicleDetail { get; set; }

        public VehicleViewModel SelectedVehicle { get; set; }

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
                dtpExpirationDate.Text = value.ToString();
            }
        }

        protected override void ExecuteSave()
        {
            if (FieldsValidator.Validate())
            {
                try
                {
                    MethodBase.GetCurrentMethod().Info("Save Vehicle Detail's changes");
                    _presenter.SaveChanges();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MethodBase.GetCurrentMethod().Fatal("An error occured while trying to save Vehicle Detail", ex);
                    this.ShowError("Proses simpan data Detail Kendaraan gagal!");
                }
            }
        }
    }
}