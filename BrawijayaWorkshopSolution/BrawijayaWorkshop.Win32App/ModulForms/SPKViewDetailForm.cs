using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.Presenter;
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
    public partial class SPKViewDetailForm : BaseDefaultForm, ISPKViewDetailView
    {
        private SPKViewDetailPresenter _presenter;
        private bool _isApproval = false;
        public SPKViewDetailForm(SPKViewDetailModel model)
        {
            InitializeComponent();
            _presenter = new SPKViewDetailPresenter(this, model);

            if (this.IsApproval)
            {
                btnPrint.Visible = false;
            }
            else
            {
                btnApprove.Visible = false;
                btnReject.Visible = false;
            }

            txtCode.ReadOnly = true;
            txtVehicle.ReadOnly = true;
            txtSPKCategory.ReadOnly = true;
            txtDueDate.ReadOnly = true;
            txtCreateDate.ReadOnly = true;
            txtCustomer.ReadOnly = true;

            this.Load += SPKViewDetailForm_Load;
        }

        void SPKViewDetailForm_Load(object sender, EventArgs e)
        {
            _presenter.InitFormData();
            ApplyButtonSetting();
        }

        void ApplyButtonSetting()
        {
            btnApprove.Visible = SelectedSPK.StatusApprovalId == (int)DbConstant.ApprovalStatus.Pending;
            btnReject.Visible = SelectedSPK.StatusApprovalId == (int)DbConstant.ApprovalStatus.Pending;
            btnPrint.Visible = SelectedSPK.StatusPrintId == (int)DbConstant.SPKPrintStatus.Ready;
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

        public string DueDate
        {
            get
            {
                return txtDueDate.Text;
            }
            set
            {
                txtDueDate.Text = value;
            }
        }

        public string CreateDate
        {
            get
            {
                return txtCreateDate.Text;
            }
            set
            {
                txtCreateDate.Text = value;
            }
        }

        public string Vehicle
        {
            get
            {
                return txtVehicle.Text;
            }
            set
            {
                txtVehicle.Text = value;
            }
        }

        public string Customer
        {
            get
            {
                return txtCustomer.Text;
            }
            set
            {
                txtCustomer.Text = value;
            }
        }

        public string Category
        {
            get
            {
                return txtSPKCategory.Text;
            }
            set
            {
                txtSPKCategory.Text = value;
            }
        }
        #endregion

        private void btnApprove_Click(object sender, EventArgs e)
        {
            _presenter.Approve();
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            _presenter.Reject();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            _presenter.print();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}