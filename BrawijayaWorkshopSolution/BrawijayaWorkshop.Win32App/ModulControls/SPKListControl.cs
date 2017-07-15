using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.Presenter;
using BrawijayaWorkshop.Runtime;
using BrawijayaWorkshop.SharedObject.ViewModels;
using BrawijayaWorkshop.Utils;
using BrawijayaWorkshop.View;
using BrawijayaWorkshop.Win32App.ModulForms;
using BrawijayaWorkshop.Win32App.PrintItems;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Windows.Forms;

namespace BrawijayaWorkshop.Win32App.ModulControls
{
    public partial class SPKListControl : BaseAppUserControl, ISPKListView
    {
        private SPKListPresenter _presenter;

        public SPKListControl(SPKListModel model)
        {
            InitializeComponent();

            _presenter = new SPKListPresenter(this, model);

            gvSPK.FocusedRowChanged += gvSPK_FocusedRowChanged;
            gvSPK.PopupMenuShowing += gvSPK_PopupMenuShowing;

            // init editor control accessibility
            btnNewSPK.Enabled = AllowInsert;
            cmsEndorseData.Enabled = AllowEdit;

            this.Load += SPKListControl_Load;

            //by default pending & all category spk will displayed
            this.ApprovalStatusFilter = 9;
            this.CategoryFilter = 0;
            this.PrintStatusFilter = 9;
            this.CompletedStatusFilter = 9;
            this.ContractWorkStatusFilter = -1;
        }

        protected override string ModulName
        {
            get
            {
                return DbConstant.MODUL_SPK;
            }
        }

        #region Filter Fields

        public SPKViewModel SelectedSPK { get; set; }

        public DateTime DateFrom
        {
            get
            {
                return txtDateFilterFrom.EditValue.AsDateTime();
            }
            set
            {
                txtDateFilterFrom.EditValue = value;
            }
        }

        public DateTime DateTo
        {
            get
            {
                return txtDateFilterTo.EditValue.AsDateTime();
            }
            set
            {
                txtDateFilterTo.EditValue = value;
            }
        }

        public int ApprovalStatusFilter
        {
            get
            {
                return lookUpApprovalStatus.EditValue.AsInteger();
            }
            set
            {
                lookUpApprovalStatus.EditValue = value;
            }
        }

        public int PrintStatusFilter
        {
            get
            {
                return lookUpPrintStatus.EditValue.AsInteger();
            }
            set
            {
                lookUpPrintStatus.EditValue = value;
            }
        }

        public int CompletedStatusFilter
        {
            get
            {
                return lookUpCompletedStatus.EditValue.AsInteger();
            }
            set
            {
                lookUpCompletedStatus.EditValue = value;
            }
        }

        public string CodeFilter
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

        public int CategoryFilter
        {
            get
            {
                return lookUpCategory.EditValue.AsInteger();
            }
            set
            {
                lookUpCategory.EditValue = value;
            }
        }

        public int ContractWorkStatusFilter
        {
            get
            {
                return lookUpContractWorkStatus.EditValue.AsInteger();
            }
            set
            {
                lookUpContractWorkStatus.EditValue = value;
            }
        }

        public string LicenseNumberFilter
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

        public List<ReferenceViewModel> CategoryDropdownList
        {
            get
            {
                return lookUpCategory.Properties.DataSource as List<ReferenceViewModel>;
            }
            set
            {
                lookUpCategory.Properties.DataSource = value;
            }
        }

        public List<SPKViewModel> SPKListData
        {
            get
            {
                return gcSPK.DataSource as List<SPKViewModel>;
            }
            set
            {
                if (InvokeRequired)
                {
                    this.Invoke(new MethodInvoker(delegate { gcSPK.DataSource = value; gvSPK.BestFitColumns(); }));
                }
                else
                {
                    gcSPK.DataSource = value;
                    gvSPK.BestFitColumns();
                }
            }
        }

        public List<SPKStatusItem> ApprovalStatusDropdownList
        {
            get
            {
                return lookUpApprovalStatus.Properties.DataSource as List<SPKStatusItem>;
            }
            set
            {
                lookUpApprovalStatus.Properties.DataSource = value;
            }
        }

        public List<SPKStatusItem> PrintStatusDropdownList
        {
            get
            {
                return lookUpPrintStatus.Properties.DataSource as List<SPKStatusItem>;
            }
            set
            {
                lookUpPrintStatus.Properties.DataSource = value;
            }
        }

        public List<SPKStatusItem> CompletedStatusDropdownList
        {
            get
            {
                return lookUpCompletedStatus.Properties.DataSource as List<SPKStatusItem>;
            }
            set
            {
                lookUpCompletedStatus.Properties.DataSource = value;
            }
        }

        public List<SPKStatusItem> ContractWorkStatusDropdownList
        {
            get
            {
                return lookUpContractWorkStatus.Properties.DataSource as List<SPKStatusItem>;
            }
            set
            {
                lookUpContractWorkStatus.Properties.DataSource = value;
            }
        }

        #endregion

        void gvSPK_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            GridView view = (GridView)sender;
            GridHitInfo hitInfo = view.CalcHitInfo(e.Point);
            if (hitInfo.InRow)
            {
                view.FocusedRowHandle = hitInfo.RowHandle;
                cmsEditor.Show(view.GridControl, e.Point);
                this.SelectedSPK = gvSPK.GetRow(view.FocusedRowHandle) as SPKViewModel;
                ApplyCMSSetting();
            }
        }

        void gvSPK_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            this.SelectedSPK = gvSPK.GetRow(e.FocusedRowHandle) as SPKViewModel;
        }

        void ApplyCMSSetting()
        {
            if (this.SelectedSPK.StatusCompletedId == (int)DbConstant.SPKCompletionStatus.Completed)
            {
                cmsEndorseData.Visible = false;
                cmsPrintData.Visible = false;
                cmsRequestPrint.Visible = false;
                cmsSetAsCompleted.Visible = false;
                cmsSPKApproval.Visible = false;
                cmsPrintApproval.Visible = false;
                cmsAbort.Visible = false;
                cmsEndorseData.Visible = false;
                cmsRollback.Visible = false;
                //cmsRollback.Visible = LoginInformation.RoleName == DbConstant.ROLE_MANAGER || LoginInformation.RoleName == DbConstant.ROLE_SUPERADMIN;
            }
            else
            {
                cmsSPKApproval.Visible = this.SelectedSPK.StatusApprovalId == (int)DbConstant.ApprovalStatus.Pending;

                cmsPrintApproval.Visible = (this.SelectedSPK.StatusPrintId == (int)DbConstant.SPKPrintStatus.Pending &&
                    this.SelectedSPK.StatusApprovalId == (int)DbConstant.ApprovalStatus.Approved);

                cmsEndorseData.Visible = (this.SelectedSPK.StatusApprovalId == (int)DbConstant.ApprovalStatus.Approved ||
                    this.SelectedSPK.StatusApprovalId == (int)DbConstant.ApprovalStatus.Rejected) &&
                    this.SelectedSPK.StatusCompletedId == (int)DbConstant.SPKCompletionStatus.InProgress;
                cmsPrintData.Visible = this.SelectedSPK.StatusPrintId == (int)DbConstant.SPKPrintStatus.Ready;

                cmsRequestPrint.Visible = this.SelectedSPK.StatusPrintId == (int)DbConstant.SPKPrintStatus.Printed;
                cmsSetAsCompleted.Visible = this.SelectedSPK.StatusApprovalId == (int)DbConstant.ApprovalStatus.Approved &&
                    this.SelectedSPK.StatusPrintId == (int)DbConstant.SPKPrintStatus.Printed &&
                    this.SelectedSPK.StatusCompletedId == (int)DbConstant.SPKCompletionStatus.InProgress;

                toolStripSeparator1.Visible = cmsEndorseData.Visible && cmsPrintData.Visible && cmsRequestPrint.Visible &&
                    cmsSetAsCompleted.Visible;

                cmsRollback.Visible = false;
            }
        }

        void SPKListControl_Load(object sender, EventArgs e)
        {
            _presenter.InitData();
            btnSearch.PerformClick();
        }

        public override void RefreshDataView()
        {
            if (!bgwMain.IsBusy)
            {
                MethodBase.GetCurrentMethod().Info("Fecthing SPK data...");
                SelectedSPK = null;
                FormHelpers.CurrentMainForm.UpdateStatusInformation("Memuat data SPK...", false);
                bgwMain.RunWorkerAsync();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            RefreshDataView();
        }

        private void bgwMain_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                _presenter.LoadSPK();
            }
            catch (Exception ex)
            {
                MethodBase.GetCurrentMethod().Fatal("An error occured while trying to execute _presenter.LoadSPK()", ex);
                e.Result = ex;
            }
        }

        private void bgwMain_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Result is Exception)
            {
                this.ShowError("Proses memuat data gagal!");
            }

            FormHelpers.CurrentMainForm.UpdateStatusInformation("Memuat data SPK selesai", true);
        }

        private void btnNewSPK_Click(object sender, EventArgs e)
        {
            SPKEditorForm editor = Bootstrapper.Resolve<SPKEditorForm>();
            editor.ShowDialog(this);

            btnSearch.PerformClick();
        }

        private void viewDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SPKViewDetailForm editor = Bootstrapper.Resolve<SPKViewDetailForm>();
            editor.SelectedSPK = this.SelectedSPK;
            editor.IsApproval = false;
            editor.ShowDialog(this);

            btnSearch.PerformClick();
        }

        private void cmsEndorseData_Click(object sender, EventArgs e)
        {
            SPKEditorForm editor = Bootstrapper.Resolve<SPKEditorForm>();
            editor.ParentSPK = this.SelectedSPK;
            editor.ShowDialog(this);

            btnSearch.PerformClick();
        }

        private void cmsPrintData_Click(object sender, EventArgs e)
        {
            SPKPrintItem report = new SPKPrintItem();
            List<SPKViewModel> _dataSource = new List<SPKViewModel>();
            _dataSource.Add(SelectedSPK);
            report.DataSource = _dataSource;
            report.FillDataSource();

            using (ReportPrintTool printTool = new ReportPrintTool(report))
            {
                // Invoke the Print dialog.
                bool? result = printTool.PrintDialog();
                if (result.HasValue && result.Value)
                {
                    _presenter.PrintSPK();
                }
            }

            btnSearch.PerformClick();
        }

        private void gvSPK_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            ColumnView view = sender as ColumnView;
            if (e.Column.FieldName == "StatusApprovalId" && e.ListSourceRowIndex != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
            {
                int status = (int)view.GetListSourceRowCellValue(e.ListSourceRowIndex, "StatusApprovalId");
                switch (status)
                {
                    case 0: e.DisplayText = "Menunggu Persetujuan"; break;
                    case 1: e.DisplayText = "Disetujui"; break;
                    case 2: e.DisplayText = "Direvisi"; break;
                    case -1: e.DisplayText = "Ditolak"; break;
                }
            }

            if (e.Column.FieldName == "StatusPrintId" && e.ListSourceRowIndex != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
            {
                int status = (int)view.GetListSourceRowCellValue(e.ListSourceRowIndex, "StatusPrintId");
                switch (status)
                {
                    case 0: e.DisplayText = "Menunggu Persetujuan"; break;
                    case 1: e.DisplayText = "Siap Print"; break;
                    case 2: e.DisplayText = "Sudah Diprint"; break;
                }
            }

            if (e.Column.FieldName == "StatusCompletedId" && e.ListSourceRowIndex != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
            {
                int status = (int)view.GetListSourceRowCellValue(e.ListSourceRowIndex, "StatusCompletedId");
                switch (status)
                {
                    case 0: e.DisplayText = "Dalam Pengerjaan"; break;
                    case 1: e.DisplayText = "Selesai"; break;
                }
            }
        }

        private void cmsAbort_Click(object sender, EventArgs e)
        {
            SPKViewDetailForm editor = Bootstrapper.Resolve<SPKViewDetailForm>();
            editor.SelectedSPK = this.SelectedSPK;
            editor.IsAbort = true;
            editor.ShowDialog(this);

            btnSearch.PerformClick();
        }

        private void cmsSetAsCompleted_Click(object sender, EventArgs e)
        {
            SPKViewDetailForm editor = Bootstrapper.Resolve<SPKViewDetailForm>();
            editor.SelectedSPK = this.SelectedSPK;
            editor.IsSetAsComplete = true;
            editor.ShowDialog(this);

            btnSearch.PerformClick();
        }

        private void cmsRequestPrint_Click(object sender, EventArgs e)
        {
            SPKViewDetailForm editor = Bootstrapper.Resolve<SPKViewDetailForm>();
            editor.SelectedSPK = this.SelectedSPK;
            editor.IsRequestPrintApproval = true;
            editor.ShowDialog(this);

            btnSearch.PerformClick();
        }

        private void cmsSPKApproval_Click(object sender, EventArgs e)
        {
            SPKViewDetailForm editor = Bootstrapper.Resolve<SPKViewDetailForm>();
            editor.SelectedSPK = this.SelectedSPK;
            editor.IsApproval = true;
            editor.ShowDialog(this);

            btnSearch.PerformClick();
        }

        private void cmsPrintApproval_Click(object sender, EventArgs e)
        {
            SPKViewDetailForm editor = Bootstrapper.Resolve<SPKViewDetailForm>();
            editor.SelectedSPK = this.SelectedSPK;
            editor.IsPrintApproval = true;
            editor.ShowDialog(this);

            btnSearch.PerformClick();
        }

        private void cmsRollback_Click(object sender, EventArgs e)
        {
            SPKViewDetailForm editor = Bootstrapper.Resolve<SPKViewDetailForm>();
            editor.SelectedSPK = this.SelectedSPK;
            editor.IsRollBack = true;
            editor.ShowDialog(this);

            btnSearch.PerformClick();
        }

        private void bgwExport_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                _presenter.ExportToCSV();
            }
            catch (Exception ex)
            {
                MethodBase.GetCurrentMethod().Fatal("An error occured while trying to export SPK", ex);
                e.Result = ex;
            }
        }

        private void bgwExport_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Result is Exception)
            {
                this.ShowError("Proses export SPK gagal!");
            }

            FormHelpers.CurrentMainForm.UpdateStatusInformation("Export SPK selesai", true);
        }

        public string ExportFileName { get; set; }

        private void btnExportToCSV_Click(object sender, EventArgs e)
        {
            if (!bgwExport.IsBusy && !bgwMain.IsBusy)
            {
                ExportFileName = string.Empty;
                btnSearch.PerformClick();
                exportDialog.FileName = "SPK_" + DateTime.Now.ToString("yyyyMMdd_HHmmssfff") + ".csv";
                exportDialog.ShowDialog(this);
            }
        }

        private void exportDialog_FileOk(object sender, CancelEventArgs e)
        {
            ExportFileName = exportDialog.FileName;

            MethodBase.GetCurrentMethod().Info("Exporting SPK data...");
            FormHelpers.CurrentMainForm.UpdateStatusInformation("Proses export data SPK...", false);
            bgwExport.RunWorkerAsync();
        }

    }
}
