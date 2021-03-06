﻿using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.Presenter;
using BrawijayaWorkshop.SharedObject.ViewModels;
using BrawijayaWorkshop.Utils;
using BrawijayaWorkshop.View;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;

namespace BrawijayaWorkshop.Win32App.ModulForms
{
    public partial class GuestBookEditorForm : BaseEditorForm, IGuestBookEditorView
    {
        private GuestBookEditorPresenter _presenter;

        public GuestBookEditorForm(GuestBookEditorModel model)
        {
            InitializeComponent();
            _presenter = new GuestBookEditorPresenter(this, model);

            VehicleValidator.SetIconAlignment(lookUpVehicle, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.MaximizeBox = false;
            this.Load += GuestBookEditorForm_Load;
        }

        #region Properties
        public int VehicleId
        {
            get
            {
                VehicleViewModel selected = lookUpVehicle.GetSelectedDataRow() as VehicleViewModel;
                if (selected == null) return 0;
                return selected.Id;
            }
            set
            {
                lookUpVehicle.EditValue = value;
            }
        }

        public List<VehicleViewModel> VehicleList
        {
            get
            {
                return lookUpVehicle.Properties.DataSource as List<VehicleViewModel>;
            }
            set
            {
                lookUpVehicle.Properties.DataSource = value;
            }
        }

        public GuestBookViewModel SelectedGuestBook { get; set; }

        public string Description
        {
            get
            {
                return rtbDescription.Text;
            }
            set
            {
                rtbDescription.Text = value;
            }
        }

        public List<VehicleWheelViewModel> VehicleWheelList
        {
            get
            {
                return gridVehicleWheel.DataSource as List<VehicleWheelViewModel>;
            }
            set
            {
                if (InvokeRequired)
                {
                    this.Invoke(new MethodInvoker(delegate { gridVehicleWheel.DataSource = value; gvVehicleWheel.BestFitColumns(); }));
                }
                else
                {
                    gridVehicleWheel.DataSource = value;
                    gvVehicleWheel.BestFitColumns();
                }
            }
        }
        public string Type
        {
            get
            {
                return lblTypeValue.Text;
            }
            set
            {
                lblTypeValue.Text = value;
            }
        }

        public string Brand
        {
            get
            {
                return lblBrandValue.Text;
            }
            set
            {
                lblBrandValue.Text = value;
            }
        }

        public string Customer
        {
            get
            {
                return lblCustomerValue.Text;
            }
            set
            {
                lblCustomerValue.Text = value;
            }
        }

        public string YearOfPurchase
        {
            get
            {
                return lblYearOfpurchaseValue.Text;
            }
            set
            {
                lblYearOfpurchaseValue.Text = value.ToString();
            }
        }

        public string ExpirationDate
        {
            get
            {
                return lblExpirationDateValue.Text;
            }
            set
            {
                lblExpirationDateValue.Text = value;
            }
        }

        public VehicleViewModel SelectedVehicle { get; set; }
        #endregion

        void GuestBookEditorForm_Load(object sender, EventArgs e)
        {
            _presenter.InitFormData();
        }

        protected override void ExecuteSave()
        {
            if (VehicleValidator.Validate())
            {
                try
                {
                    MethodBase.GetCurrentMethod().Info("Save GuestBook's changes");
                    _presenter.SaveChanges();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MethodBase.GetCurrentMethod().Fatal("An error occured while trying to save guestbook", ex);
                    this.ShowError("Proses simpan daftar hadir kendaraan gagal!");
                }
            }
        }

        private void lookUpVehicle_EditValueChanged(object sender, EventArgs e)
        {
            this.SelectedVehicle = lookUpVehicle.GetSelectedDataRow() as VehicleViewModel;
            _presenter.LoadDataVehicle();
        }
    }
}