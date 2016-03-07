using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.Presenter;
using BrawijayaWorkshop.SharedObject.ViewModels;
using BrawijayaWorkshop.Utils;
using BrawijayaWorkshop.View;
using BrawijayaWorkshop.Win32App.ModulForms;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Windows.Forms;

namespace BrawijayaWorkshop.Win32App.ModulControls
{
    public partial class ManualTransactionListControl : BaseAppUserControl, IManualTransactionListView
    {
        private ManualTransactionListPresenter _presenter;

        protected override string ModulName
        {
            get
            {
                return DbConstant.MODUL_MANUAL_TRANSACTION;
            }
        }

        public ManualTransactionListControl(ManualTransactionListModel model)
        {
            InitializeComponent();
            _presenter = new ManualTransactionListPresenter(this, model);

            gvManualTransaction.FocusedRowChanged += gvManualTransaction_FocusedRowChanged;
            gvManualTransaction.PopupMenuShowing += gvManualTransaction_PopupMenuShowing;

            // init editor control accessibility
            btnNewTransaction.Enabled = AllowInsert;
            cmsEditData.Enabled = AllowEdit;
            cmsDeleteData.Enabled = AllowDelete;

            this.Load += ManualTransactionListControl_Load;
        }

       #region View's Member
        public DateTime From
        {
            get
            {
                return deFrom.DateTime;
            }
            set
            {
                deFrom.DateTime = value;
            }
        }

        public DateTime To
        {
            get
            {
                return deTo.DateTime;
            }
            set
            {
                deTo.DateTime = value;
            }
        }

        public List<TransactionViewModel> TransactionListData
        {
            get
            {
                return gridManualTransaction.DataSource as List<TransactionViewModel>;
            }
            set
            {
                if (InvokeRequired)
                {
                    this.Invoke(new MethodInvoker(delegate { gridManualTransaction.DataSource = value; gvManualTransaction.BestFitColumns(); }));
                }
                else
                {
                    gridManualTransaction.DataSource = value;
                    gvManualTransaction.BestFitColumns();
                }
            }
        }

        public TransactionViewModel SelectedTransaction { get; set; } 
        #endregion 

        private void gvManualTransaction_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            GridView view = (GridView)sender;
            GridHitInfo hitInfo = view.CalcHitInfo(e.Point);
            if (hitInfo.InRow)
            {
                view.FocusedRowHandle = hitInfo.RowHandle;
                cmsEditor.Show(view.GridControl, e.Point);
            }
        }

        private void gvManualTransaction_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            this.SelectedTransaction = gvManualTransaction.GetFocusedRow() as TransactionViewModel;
        }

        private void ManualTransactionListControl_Load(object sender, EventArgs e)
        {
            _presenter.InitFormData();
            btnSearch.PerformClick();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            RefreshDataView();
        }

        public override void RefreshDataView()
        {
            if (!bgwMain.IsBusy)
            {
                MethodBase.GetCurrentMethod().Info("Fecthing transactino data...");
                this.SelectedTransaction = null;
                FormHelpers.CurrentMainForm.UpdateStatusInformation("Memuat data manual transaksi...", false);
                bgwMain.RunWorkerAsync();
            }
        }

        private void bgwMain_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                _presenter.LoadData();
            }
            catch (Exception ex)
            {
                MethodBase.GetCurrentMethod().Fatal("An error occured while trying to execute _presenter.LoadData()", ex);
                e.Result = ex;
            }
        }

        private void bgwMain_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Result is Exception)
            {
                this.ShowError("Proses memuat data gagal!");
            }

            if (gvManualTransaction.RowCount > 0)
            {
                this.SelectedTransaction = gvManualTransaction.GetRow(0) as TransactionViewModel;
            }

            FormHelpers.CurrentMainForm.UpdateStatusInformation("Memuat data manual transaksi selesai", true);
        }

        private void btnNewTransaction_Click(object sender, EventArgs e)
        {
            ManualTransactionEditorForm editor = Bootstrapper.Resolve<ManualTransactionEditorForm>();
            editor.ShowDialog(this);

            btnSearch.PerformClick();
        }

        private void cmsEditData_Click(object sender, EventArgs e)
        {
            if (this.SelectedTransaction != null)
            {
                ManualTransactionEditorForm editor = Bootstrapper.Resolve<ManualTransactionEditorForm>();
                editor.SelectedTransaction = this.SelectedTransaction;
                editor.ShowDialog(this);

                btnSearch.PerformClick();
            }
        }

        private void cmsDeleteData_Click(object sender, EventArgs e)
        {
            if (SelectedTransaction == null) return;

            if (this.ShowConfirmation("Apakah anda yakin ingin menghapus transaksi: '" + SelectedTransaction.Description + "'?") == DialogResult.Yes)
            {
                try
                {
                    MethodBase.GetCurrentMethod().Info("Deleting customer: " + SelectedTransaction.Description);

                    _presenter.DeleteManualTransaction();

                    btnSearch.PerformClick(); // refresh data
                }
                catch (Exception ex)
                {
                    MethodBase.GetCurrentMethod().Fatal("An error occured while trying to delete customer: '" + SelectedTransaction.Description + "'", ex);
                    this.ShowError("Proses hapus data customer: '" + SelectedTransaction.Description + "' gagal!");
                }
            }
        }
    }
}
