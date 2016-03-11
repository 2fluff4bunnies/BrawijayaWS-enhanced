using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.Presenter;
using BrawijayaWorkshop.SharedObject.ViewModels;
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
    public partial class UsedGoodsTransactionListControl : BaseAppUserControl, IUsedGoodTransactionListView
    {
        private UsedGoodTransactionListPresenter _presenter;
        private UsedGoodTransactionViewModel _selectedUsedGoodTransaction;
        protected override string ModulName
        {
            get
            {
                return DbConstant.MODUL_USEDGOOD_TRANSACTION;
            }
        }
        public UsedGoodsTransactionListControl(UsedGoodTransactionListModel model)
        {
            InitializeComponent();
            _presenter = new UsedGoodTransactionListPresenter(this, model);

            gvUsedGoodTrans.PopupMenuShowing += gvUsedGoodTrans_PopupMenuShowing;
            gvUsedGoodTrans.FocusedRowChanged += gvUsedGoodTrans_FocusedRowChanged;

            // init editor control accessibility
            btnNewUsedGoodTrans.Enabled = AllowInsert;
            cmsEditData.Enabled = AllowEdit;
            this.Load += UsedGoodsListTransactionControl_Load;
        }

        private void UsedGoodsListTransactionControl_Load(object sender, EventArgs e)
        {
            btnSearch.PerformClick();
        }

        private void gvUsedGoodTrans_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            this.SelectedUsedGoodTransaction = gvUsedGoodTrans.GetFocusedRow() as UsedGoodTransactionViewModel;
        }

        private void gvUsedGoodTrans_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            GridView view = (GridView)sender;
            GridHitInfo hitInfo = view.CalcHitInfo(e.Point);
            if (hitInfo.InRow)
            {
                view.FocusedRowHandle = hitInfo.RowHandle;
                cmsEditor.Show(view.GridControl, e.Point);
            }
        }

        public string SparepartNameFilter
        {
            get
            {
                return txtFilterSparepartName.Text;
            }
            set
            {
                txtFilterSparepartName.Text = value;
            }
        }

        public List<UsedGoodTransactionViewModel> UsedGoodTransactionListData
        {
            get
            {
                return gridUsedGoodTrans.DataSource as List<UsedGoodTransactionViewModel>;
            }
            set
            {
                if (InvokeRequired)
                {
                    this.Invoke(new MethodInvoker(delegate { gridUsedGoodTrans.DataSource = value; gvUsedGoodTrans.BestFitColumns(); }));
                }
                else
                {
                    gridUsedGoodTrans.DataSource = value;
                    gvUsedGoodTrans.BestFitColumns();
                }
            }
        }

        public UsedGoodTransactionViewModel SelectedUsedGoodTransaction
        {
            get
            {
                return _selectedUsedGoodTransaction;
            }
            set
            {
                _selectedUsedGoodTransaction = value;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            RefreshDataView();
        }

        public override void RefreshDataView()
        {
            if (!bgwMain.IsBusy)
            {
                MethodBase.GetCurrentMethod().Info("Fecthing UsedGoodTransaction data...");
                _selectedUsedGoodTransaction = null;
                FormHelpers.CurrentMainForm.UpdateStatusInformation("Memuat data transaksi barang bekas...", false);
                bgwMain.RunWorkerAsync();
            }
        }

        private void txtFilterSparepartName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch.PerformClick();
            }
        }

        private void btnNewTransaction_Click(object sender, EventArgs e)
        {
            UsedGoodTransactionEditorForm editor = Bootstrapper.Resolve<UsedGoodTransactionEditorForm>();
            editor.IsManual = false;
            editor.ShowDialog(this);

            btnSearch.PerformClick();
        }

        private void cmsEditData_Click(object sender, EventArgs e)
        {
            if (_selectedUsedGoodTransaction != null)
            {
                UsedGoodTransactionEditorForm editor = Bootstrapper.Resolve<UsedGoodTransactionEditorForm>();
                editor.SelectedUsedGoodTransaction = _selectedUsedGoodTransaction;
                editor.UsedGood = _selectedUsedGoodTransaction.UsedGood;
                editor.IsManual = false;
                editor.ShowDialog(this);

                btnSearch.PerformClick();
            }
        }

        private void bgwMain_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                _presenter.LoadUsedGoodTransaction();
            }
            catch (Exception ex)
            {
                MethodBase.GetCurrentMethod().Fatal("An error occured while trying to execute _presenter.LoadUsedGood()", ex);
                e.Result = ex;
            }
        }

        private void bgwMain_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Result is Exception)
            {
                this.ShowError("Proses memuat data gagal!");
            }

            if (gvUsedGoodTrans.RowCount > 0)
            {
                SelectedUsedGoodTransaction = gvUsedGoodTrans.GetRow(0) as UsedGoodTransactionViewModel;
            }

            FormHelpers.CurrentMainForm.UpdateStatusInformation("Memuat data barang bekas selesai", true);
        }
    }
}
