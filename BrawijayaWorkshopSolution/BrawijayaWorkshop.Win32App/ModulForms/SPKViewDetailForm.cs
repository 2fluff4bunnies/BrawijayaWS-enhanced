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
    public partial class SPKViewDetailForm : BaseDefaultForm, ISPKViewDetailView
    {
        private SPKViewDetailPresenter _presenter;
        private bool _isApproval = false;

        private string _prefix = ": ";

        public SPKViewDetailForm(SPKViewDetailModel model)
        {
            InitializeComponent();
            _presenter = new SPKViewDetailPresenter(this, model);

            this.IsAbort = false;
            this.IsSetAsComplete = false;

            this.Load += SPKViewDetailForm_Load;
        }

        private void SPKViewDetailForm_Load(object sender, EventArgs e)
        {
            _presenter.InitFormData();

            this.ApprovalEmailBody = Resources.SPKApprovalEmailTemplate;
            this.ApprovalEmailFrom = ConfigurationManager.AppSettings[ConfigurationConstant.APP_SETTING_MAIL_FROM].Decrypt();
            this.ApprovalEmailTo = ConfigurationManager.AppSettings[ConfigurationConstant.APP_SETTING_MANAGER_MAIL].Decrypt();
            ApplyButtonSetting();

            #region Field Setting
            lblCodeValue.Text = _prefix + this.SelectedSPK.Code;
            lblCustomerValue.Text = _prefix + this.SelectedSPK.Vehicle.Customer.CompanyName;
            lblVehicleValue.Text = _prefix + this.SelectedSPK.Vehicle.ActiveLicenseNumber;
            lblCategoryValue.Text = _prefix + this.SelectedSPK.CategoryReference.Name;
            lblCreateDateValue.Text = _prefix + this.SelectedSPK.CreateDate.ToShortDateString();
            lblDueDateValue.Text = _prefix + this.SelectedSPK.DueDate.ToShortDateString();
            lblContractWorkValue.Text = _prefix + (this.SelectedSPK.isContractWork ? "Borongan" : "Bukan Borongan");
            lblCostEstimationValue.Text = _prefix + this.SelectedSPK.CostEstimation;
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

        private void ApplyButtonSetting()
        {
            btnSetAsComplete.Visible = btnAbort.Visible = btnApprove.Visible = btnReject.Visible = false;
            btnPrint.Visible = SelectedSPK.StatusPrintId == (int)DbConstant.SPKPrintStatus.Ready;
            btnRequestPrint.Visible = SelectedSPK.StatusPrintId == (int)DbConstant.SPKPrintStatus.Printed  && SelectedSPK.StatusCompletedId == (int)DbConstant.SPKCompletionStatus.InProgress ;
            btnEndorse.Visible = (SelectedSPK.StatusApprovalId == (int)DbConstant.ApprovalStatus.Approved || SelectedSPK.StatusApprovalId == (int)DbConstant.ApprovalStatus.Rejected) && SelectedSPK.StatusCompletedId == (int)DbConstant.SPKCompletionStatus.InProgress;

            if (LoginInformation.RoleName == DbConstant.ROLE_MANAGER || LoginInformation.RoleName == DbConstant.ROLE_SUPERADMIN)
            {
                if (this.IsPrintApproval)
                {
                    btnApprove.Visible = SelectedSPK.StatusPrintId == (int)DbConstant.SPKPrintStatus.Pending;
                    btnReject.Visible = SelectedSPK.StatusPrintId == (int)DbConstant.SPKPrintStatus.Pending;
                }
                else if (this.IsApproval)
                {
                    btnApprove.Visible = SelectedSPK.StatusApprovalId == (int)DbConstant.ApprovalStatus.Pending;
                    btnReject.Visible = SelectedSPK.StatusApprovalId == (int)DbConstant.ApprovalStatus.Pending;
                }
                else if (this.IsRollBack)
                {
                    btnRollback.Visible = false;
                    //btnRollback.Visible = SelectedSPK.StatusApprovalId == (int)DbConstant.SPKCompletionStatus.Completed;
                }
            }


            if (this.IsAbort)
            {
                btnSetAsComplete.Visible = btnRequestPrint.Visible = btnPrint.Visible = btnEndorse.Visible = btnApprove.Visible = btnReject.Visible = false;
                btnAbort.Visible = true;
            }

            if (this.IsSetAsComplete)
            {
                btnAbort.Visible = btnRequestPrint.Visible = btnPrint.Visible = btnEndorse.Visible = btnApprove.Visible = btnReject.Visible = false;
                btnSetAsComplete.Visible = true;
            }
        }

        #region Field Editor
        public bool IsApproval
        {
            get
            {
                return _isApproval;
            }
            set
            {
                _isApproval = value;
            }
        }

        public bool IsRequestPrintApproval { get; set; }

        public bool IsPrintApproval { get; set; }

        public bool IsRollBack { get; set; }

        public bool IsAbort { get; set; }

        public bool IsSetAsComplete { get; set; }

        public SPKViewModel SelectedSPK { get; set; }

        public SPKViewModel ParentSPK { get; set; }

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

        public List<SPKDetailSparepartDetailViewModel> SPKSparepartDetailList { get; set; }

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
        #endregion

        #region EmailProperties
        public string ApprovalEmailBody { get; set; }

        public string ApprovalEmailFrom { get; set; }

        public string ApprovalEmailTo { get; set; }
        #endregion

        private void btnApprove_Click(object sender, EventArgs e)
        {
            if (this.IsPrintApproval)
            {
                _presenter.PrintApproval(true);
            }
            if(this.IsApproval)
            {
                 _presenter.Approve();
            }

            this.Close();
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            if (this.IsRequestPrintApproval)
            {
                _presenter.PrintApproval(false);
            }
            else
            {
                _presenter.Reject();
            }

            this.Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            SPKPrintItem report = new SPKPrintItem();
            List<SPKViewModel> _dataSource = new List<SPKViewModel>();
            _dataSource.Add(SelectedSPK);
            report.DataSource = _dataSource;
            report.FillDataSource();

            using (ReportPrintTool printTool = new ReportPrintTool(report))
            {
                // Invoke the Print dialog.
                printTool.PrintDialog();
            }

            _presenter.Print();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRequestPrint_Click(object sender, EventArgs e)
        {
            _presenter.RequestPrint();
            this.Close();
        }

        private void btnAbort_Click(object sender, EventArgs e)
        {
            if (this.ShowConfirmation("SPK yang dibatalkan tidak dapat digunakan kembali, anda yakin ingin melanjutkan ?") == DialogResult.Yes)
            {
                _presenter.Abort();
                this.Close();
            }
        }

        private void btnEndorse_Click(object sender, EventArgs e)
        {
            SPKEditorForm editor = Bootstrapper.Resolve<SPKEditorForm>();
            editor.ParentSPK = this.SelectedSPK;
            editor.ShowDialog(this);

            this.Close();
        }

        private void btnSetAsComplete_Click(object sender, EventArgs e)
        {
            if (this.ShowConfirmation("SPK yang sudah dianggap selesai tidak bisa direvisi kembali \nkarena akan digunakan untuk pembuatan invoice/tagihan, anda yakin ingin melanjutkan ?") == DialogResult.Yes)
            {
                _presenter.SetAsCompleted();
                this.Close();
            }
        }

        private void btnRollback_Click(object sender, EventArgs e)
        {
            if (this.ShowConfirmation("Ulangi semua proses penyelesaian SPK?") == DialogResult.Yes)
            {
                _presenter.RollBack();
                this.Close();
            }
        }
    }
}