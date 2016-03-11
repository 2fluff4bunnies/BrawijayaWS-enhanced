using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.Presenter;
using BrawijayaWorkshop.SharedObject.ViewModels;
using BrawijayaWorkshop.Utils;
using BrawijayaWorkshop.View;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;

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
            cbWheelDetailGv.EditValueChanged += cbWheelDetailGv_EditValueChanged;
            gvVehicleWheel.PopupMenuShowing += gvVehicleWheel_PopupMenuShowing;
            gvVehicleWheel.FocusedRowChanged += gvVehicleWheel_FocusedRowChanged;
        }

        #region Field Editor
        public VehicleViewModel SelectedVehicle { get; set; }
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
                CustomerViewModel selected = lookUpCustomer.GetSelectedDataRow() as CustomerViewModel;
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

        public List<CustomerViewModel> CustomerList
        {
            get
            {
                return lookUpCustomer.Properties.DataSource as List<CustomerViewModel>;
            }
            set
            {
                lookUpCustomer.Properties.DataSource = value;
            }
        }

        public List<VehicleWheelViewModel> VehicleWheelList
        {
            get
            {
                return bsVehicleWheel.DataSource as List<VehicleWheelViewModel>;
            }
            set
            {
                if (InvokeRequired)
                {
                    this.Invoke(new MethodInvoker(delegate
                    {
                        bsVehicleWheel.DataSource = value;
                        gridVehicleWheel.DataSource = bsVehicleWheel;
                        gvVehicleWheel.BestFitColumns();
                    }));
                }
                else
                {
                    bsVehicleWheel.DataSource = value;
                    gridVehicleWheel.DataSource = bsVehicleWheel;
                    gvVehicleWheel.BestFitColumns();
                }
            }
        }

        public List<WheelDetailViewModel> WheelDetailList
        {
            get
            {
                return cbWheelDetailGv.DataSource as List<WheelDetailViewModel>;
            }
            set
            {
                cbWheelDetailGv.DataSource = value;
            }
        }

        public List<VehicleWheelViewModel> VehicleWheelExchangedList { get; set; }

        public VehicleWheelViewModel SelectedVehicleWheel { get; set; }
        #endregion

        void gvVehicleWheel_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            this.SelectedVehicleWheel = gvVehicleWheel.GetFocusedRow() as VehicleWheelViewModel;
        }

        void gvVehicleWheel_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            GridView view = (GridView)sender;
            GridHitInfo hitInfo = view.CalcHitInfo(e.Point);
            if (hitInfo.InRow)
            {
                view.FocusedRowHandle = hitInfo.RowHandle;
                cmsEditor.Show(view.GridControl, e.Point);
            }
        }

        void cbWheelDetailGv_EditValueChanged(object sender, EventArgs e)
        {
            WheelDetailViewModel selectedWheelDetail = sender as WheelDetailViewModel;
            VehicleWheelViewModel foundConflict = _presenter.IsWheelUsedByOtherVehicle(selectedWheelDetail.Id);

            if (foundConflict != null)
            {
                if (this.ShowConfirmation("Ban dengan nomor seri " + selectedWheelDetail.SerialNumber +
                   " sudah digunakan pada kendaraan dengan nopol " + foundConflict.Vehicle.ActiveLicenseNumber + "!" +
                   "\n\n Apakah anda yakin ingin menukar?") == System.Windows.Forms.DialogResult.Yes)
                {
                    foundConflict.WheelDetailId = _presenter.GetCurrentInstalledWheel(selectedWheelDetail.Id);
                    this.VehicleWheelExchangedList.Add(foundConflict);
                }
                else
                {
                    sender = null;
                }
            }
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

        protected override void ExecuteSave()
        {
            if (FieldsValidator.Validate() && VehicleWheelList.Count > 4)
            {
                try
                {
                    MethodBase.GetCurrentMethod().Info("Save Vehicle's changes");
                    _presenter.SaveChanges();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MethodBase.GetCurrentMethod().Fatal("An error occured while trying to save Vehicle", ex);
                    this.ShowError("Proses simpan data Kendaraan gagal!");
                }
            }
            else
            {
                if (VehicleWheelList.Count < 4)
                {
                    this.ShowWarning("Ban yang terpasang pada kendaraan minimal 4!");
                }
            }
        }

        private void btnNewVehicleWheel_Click(object sender, EventArgs e)
        {
            gvVehicleWheel.AddNewRow();
        }

        private void deleteWheelDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gvVehicleWheel.DeleteSelectedRows();
        }
    }
}