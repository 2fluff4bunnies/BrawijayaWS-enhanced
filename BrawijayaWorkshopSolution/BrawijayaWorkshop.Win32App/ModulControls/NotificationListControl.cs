using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.Presenter;
using BrawijayaWorkshop.Utils;
using BrawijayaWorkshop.View;
using BrawijayaWorkshop.Win32App.ModulForms;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Windows.Forms;

namespace BrawijayaWorkshop.Win32App.ModulControls
{
    public partial class NotificationListControl : BaseAppUserControl, INotificationListView
    {
        private NotificationListPresenter _presenter;

        protected override string ModulName
        {
            get
            {
                return DbConstant.MODUL_SPK;
            }
        }

        public NotificationListControl(NotificationListModel model)
        {
            InitializeComponent();
            _presenter = new NotificationListPresenter(this, model);

            gvPendingSPK.FocusedRowChanged += gvPendingSPK_FocusedRowChanged;
            gvPendingSPK.PopupMenuShowing += gvPendingSPK_PopupMenuShowing;

            // init editor control accessibility
            approveToolStripItem.Enabled = AllowEdit;
            this.Load += NotificationListControl_Load;
        }

        public SPK SelectedSPK { get; set; }

        public List<SPK> SPKListData
        {
            get
            {
                return gridPendingSPK.DataSource as List<SPK>;
            }
            set
            {
                if (InvokeRequired)
                {
                    this.Invoke(new MethodInvoker(delegate { gridPendingSPK.DataSource = value; gvPendingSPK.BestFitColumns(); }));
                }
                else
                {
                    gridPendingSPK.DataSource = value;
                    gvPendingSPK.BestFitColumns();
                }
            }
        }

        void gvPendingSPK_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            GridView view = (GridView)sender;
            GridHitInfo hitInfo = view.CalcHitInfo(e.Point);
            if (hitInfo.InRow)
            {
                view.FocusedRowHandle = hitInfo.RowHandle;
                cmsEditor.Show(view.GridControl, e.Point);
            }
        }

        void gvPendingSPK_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            this.SelectedSPK = gvPendingSPK.GetFocusedRow() as SPK;
        }

        private void approveToolStripItem_Click(object sender, EventArgs e)
        {
            SPKViewDetailForm editor = Bootstrapper.Resolve<SPKViewDetailForm>();
            if(this.SelectedSPK.StatusApprovalId == (int)DbConstant.ApprovalStatus.Approved &&
               this.SelectedSPK.StatusPrintId == 0)
            {
                editor.IsPrintApproval = true;
            }
            if (this.SelectedSPK.StatusApprovalId == (int)DbConstant.ApprovalStatus.Pending)
            {
                editor.IsApproval = true;
            }
            
            editor.SelectedSPK = this.SelectedSPK;
            editor.ShowDialog(this);

            RefreshDataView();
        }
        void NotificationListControl_Load(object sender, EventArgs e)
        {
            RefreshDataView();
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

        private void bgwMain_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                _presenter.LoadSPKPending();
            }
            catch (Exception ex)
            {
                MethodBase.GetCurrentMethod().Fatal("An error occured while trying to execute _presenter.LoadSPKPending()", ex);
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
    }
}
