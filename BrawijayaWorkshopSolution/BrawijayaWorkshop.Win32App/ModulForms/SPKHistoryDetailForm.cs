using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.Presenter;
using BrawijayaWorkshop.Runtime;
using BrawijayaWorkshop.SharedObject.ViewModels;
using BrawijayaWorkshop.Utils;
using BrawijayaWorkshop.View;
using BrawijayaWorkshop.Win32App.PrintItems;
using BrawijayaWorkshop.Win32App.Properties;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Windows.Forms;

namespace BrawijayaWorkshop.Win32App.ModulForms
{
    public partial class SPKHistoryDetailForm :  BaseDefaultForm, ISPKHistoryDetailView
    {
        private SPKHistoryDetailPresenter _presenter;
        private string _prefix = ": ";

        public SPKHistoryDetailForm(SPKHistoryDetailModel model)
        {
            InitializeComponent();
            _presenter = new SPKHistoryDetailPresenter(this, model);

            this.Load += SPKHistoryDetailForm_Load;
           
        }

        void SPKHistoryDetailForm_Load(object sender, EventArgs e)
        {
            _presenter.InitFormData();

            #region Field Setting
            lblCodeValue.Text = _prefix + this.SelectedSPK.Code;
            lblCustomerValue.Text = _prefix + this.SelectedSPK.Vehicle.Customer.CompanyName;
            lblVehicleValue.Text = _prefix + this.SelectedSPK.Vehicle.ActiveLicenseNumber;
            lblCategoryValue.Text = _prefix + this.SelectedSPK.CategoryReference.Name;
            lblCreateDateValue.Text = _prefix + this.SelectedSPK.CreateDate.ToShortDateString();
            lblDueDateValue.Text = _prefix + this.SelectedSPK.DueDate.ToShortDateString();
            lblContractWorkValue.Text = _prefix + (this.SelectedSPK.isContractWork ? "Borongan" : "Bukan Borongan");
            if (this.SelectedSPK.isContractWork)
            {
                lblContractWorkFeeValue.Text = _prefix + this.SelectedSPK.ContractWorkFee.ToString("n0");
            }
            else
            {
                lblContractWorkFee.Visible = false;
                lblContractWorkFeeValue.Visible = false;
            }

            string statusApproval = "";
            switch (this.SelectedSPK.StatusApprovalId)
            {
                case 0: statusApproval = "Menunggu Persetujuan"; break;
                case 1: statusApproval = "Disetujui"; break;
                case 2: statusApproval = "Direvisi"; break;
                case -1: statusApproval = "Ditolak"; break;
            }
            lblStatusApprovalValue.Text = _prefix + statusApproval;

            string statusPrint = "";
            switch (this.SelectedSPK.StatusPrintId)
            {
                case 0: statusPrint = "Menunggu Persetujuan"; break;
                case 1: statusPrint = "Siap Print"; break;
                case 2: statusPrint = "Sudah Diprint"; break;
            }

            lblStatusPrintValue.Text = _prefix + statusPrint;

            string statusCompleted = "";
            switch (this.SelectedSPK.StatusCompletedId)
            {
                case 0: statusCompleted = "Dalam Pengerjaan"; break;
                case 1: statusCompleted = "Selesai"; break;
            }

            lblStatusCompletedValue.Text = _prefix + statusCompleted;

            if (!string.IsNullOrEmpty(this.SelectedSPK.Description))
            {
                string[] descriptArray = this.SelectedSPK.Description.Split(' ');
                string newDescription = "";

                for (int i = 0; i < descriptArray.Length; i++)
                {
                    if ((i + 1) % 4 != 0)
                    {
                        newDescription = newDescription + descriptArray[i] + " ";
                    }
                    else
                    {
                        newDescription = newDescription + descriptArray[i] + "\n ";
                    }
                }

                lblDescriptionValue.Text = _prefix + newDescription;
            }

            lblTotalSparepartValue.Text = _prefix + this.SelectedSPK.TotalSparepartPrice.ToString("n0");
            #endregion
        }

        public SPKViewModel SelectedSPK { get; set; }

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

        public List<SPKDetailSparepartViewModel> SPKSparepartList
        {
            get
            {
                return gcSparepart.DataSource as List<SPKDetailSparepartViewModel>;
            }
            set
            {
                if (InvokeRequired)
                {
                    this.Invoke(new MethodInvoker(delegate { gcSparepart.DataSource = value; gvSparepart.BestFitColumns(); }));
                }
                else
                {
                    gcSparepart.DataSource = value;
                    gvSparepart.BestFitColumns();
                }
            }
        }

        public List<MechanicViewModel> SPKMechanicList
        {
            get
            {
                return gcInvolvedMechanic.DataSource as List<MechanicViewModel>;
            }
            set
            {
                if (InvokeRequired)
                {
                    this.Invoke(new MethodInvoker(delegate { gcInvolvedMechanic.DataSource = value; gvInvolvedMechanic.BestFitColumns(); }));
                }
                else
                {
                    gcInvolvedMechanic.DataSource = value;
                    gvInvolvedMechanic.BestFitColumns();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
