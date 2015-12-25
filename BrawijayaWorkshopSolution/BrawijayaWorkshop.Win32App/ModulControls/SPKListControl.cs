using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.Presenter;
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
        }

        protected override string ModulName
        {
            get
            {
                return DbConstant.MODUL_SPK;
            }
        }

        #region Filter Fields

        public SPK SelectedSPK { get; set; }

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

        public List<Reference> CategoryDropdownList
        {
            get
            {
                return lookUpCategory.Properties.DataSource as List<Reference>;
            }
            set
            {
                lookUpCategory.Properties.DataSource = value;
            }
        }

        public List<SPK> SPKListData
        {
            get
            {
                return gcSPK.DataSource as List<SPK>;
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

        
        #endregion

        void gvSPK_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            GridView view = (GridView)sender;
            GridHitInfo hitInfo = view.CalcHitInfo(e.Point);
            if (hitInfo.InRow)
            {
                view.FocusedRowHandle = hitInfo.RowHandle;
                cmsEditor.Show(view.GridControl, e.Point);
            }
        }

        void gvSPK_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            this.SelectedSPK = gvSPK.GetFocusedRow() as SPK;
            if (this.SelectedSPK != null)
            {
                ApplyCMSSetting();
            }
        }

        void ApplyCMSSetting()
        {
            cmsEndorseData.Visible =( this.SelectedSPK.StatusApprovalId == (int)DbConstant.ApprovalStatus.Approved || this.SelectedSPK.StatusApprovalId == (int)DbConstant.ApprovalStatus.Rejected) && this.SelectedSPK.StatusCompletedId == (int)DbConstant.SPKCompletionStatus.InProgress;
            cmsPrintData.Visible = this.SelectedSPK.StatusPrintId == (int)DbConstant.SPKPrintStatus.Ready;
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
            List<SPK> _dataSource = new List<SPK>();
            _dataSource.Add(SelectedSPK);
            report.DataSource = _dataSource;
            report.FillDataSource();
            _presenter.PrintSPK();

            using (ReportPrintTool printTool = new ReportPrintTool(report))
            {
                // Invoke the Print dialog.
                printTool.PrintDialog();
            }
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
            editor.IsAbort = false;
            editor.ShowDialog(this);

            btnSearch.PerformClick();
        }

        private void cmsSetAsCompleted_Click(object sender, EventArgs e)
        {
            SPKViewDetailForm editor = Bootstrapper.Resolve<SPKViewDetailForm>();
            editor.SelectedSPK = this.SelectedSPK;
            editor.IsSetAsComplete = false;
            editor.ShowDialog(this);

            btnSearch.PerformClick();
        }

        private void cmsRequestPrint_Click(object sender, EventArgs e)
        {

        }
    }
}
