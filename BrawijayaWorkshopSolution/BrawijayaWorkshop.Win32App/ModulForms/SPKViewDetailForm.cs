using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.Presenter;
using BrawijayaWorkshop.Runtime;
using BrawijayaWorkshop.Utils;
using BrawijayaWorkshop.View;
using BrawijayaWorkshop.Win32App.PrintItems;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.Reflection;
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

        public bool IsAbort { get; set; }
        public bool IsSetAsComplete { get; set; }


        void SPKViewDetailForm_Load(object sender, EventArgs e)
        {
            _presenter.InitFormData();
            ApplyButtonSetting();

            #region Field Setting
            lblCodeValue.Text = _prefix + this.SelectedSPK.Code;
            lblCustomerValue.Text = _prefix + this.SelectedSPK.Vehicle.Customer.CompanyName;
            lblVehicleValue.Text = _prefix + this.SelectedSPK.Vehicle.ActiveLicenseNumber;
            lblCategoryValue.Text = _prefix + this.SelectedSPK.CategoryReference.Name;

            lblCreateDateValue.Text = _prefix + this.SelectedSPK.CreateDate.ToShortDateString();
            lblDueDateValue.Text = _prefix + this.SelectedSPK.DueDate.ToShortDateString();

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

            if(!string.IsNullOrEmpty(this.SelectedSPK.Description))
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

        void ApplyButtonSetting()
        {
            btnSetAsComplete.Visible = btnAbort.Visible = btnApprove.Visible = btnReject.Visible = false;
            btnPrint.Visible = SelectedSPK.StatusPrintId == (int)DbConstant.SPKPrintStatus.Ready;
            btnRequestPrint.Visible = SelectedSPK.StatusPrintId == (int)DbConstant.SPKPrintStatus.Printed;

            if (this.IsApproval)
            {
                if (LoginInformation.RoleName == DbConstant.ROLE_MANAGER || LoginInformation.RoleName == DbConstant.ROLE_SUPERADMIN)
                {
                    btnApprove.Visible = SelectedSPK.StatusApprovalId == (int)DbConstant.ApprovalStatus.Pending;
                    btnReject.Visible = SelectedSPK.StatusApprovalId == (int)DbConstant.ApprovalStatus.Pending;
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

        public SPK SelectedSPK { get; set; }

        public SPK ParentSPK { get; set; }

        public List<SPKDetailMechanic> SPKMechanicList
        {
            get
            {
                return gcMechanic.DataSource as List<SPKDetailMechanic>;
            }
            set
            {
                if (InvokeRequired)
                {
                    this.Invoke(new MethodInvoker(delegate { gcMechanic.DataSource = value; gvMechanic.BestFitColumns(); }));
                }
                else
                {
                    gcMechanic.DataSource = value;
                    gvMechanic.BestFitColumns();
                }
            }
        }

        public List<SPKDetailSparepart> SPKSparepartList
        {
            get
            {
                return gcSparepart.DataSource as List<SPKDetailSparepart>;
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

        public List<SPKDetailSparepartDetail> SPKSparepartDetailList { get; set; }


        #endregion

        private void btnApprove_Click(object sender, EventArgs e)
        {
            _presenter.Approve();
            this.Close();
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            _presenter.Reject();
            this.Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            SPKPrintItem report = new SPKPrintItem();
            List<SPK> _dataSource = new List<SPK>();
            _dataSource.Add(SelectedSPK);
            report.DataSource = _dataSource;
            report.FillDataSource();
            _presenter.print();

            using (ReportPrintTool printTool = new ReportPrintTool(report))
            {
                // Invoke the Print dialog.
                printTool.PrintDialog();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRequestPrint_Click(object sender, EventArgs e)
        {

        }
        private void btnAbort_Click(object sender, EventArgs e)
        {

        }

        private void btnEndorse_Click(object sender, EventArgs e)
        {
            this.Close();

            SPKEditorForm editor = Bootstrapper.Resolve<SPKEditorForm>();
            editor.ParentSPK = this.SelectedSPK;
            editor.ShowDialog(this);
        }

        private void btnSetAsComplete_Click(object sender, EventArgs e)
        {

        }
    }
}