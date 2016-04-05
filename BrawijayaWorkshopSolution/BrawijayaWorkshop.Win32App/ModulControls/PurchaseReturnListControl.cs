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
    public partial class PurchaseReturnListControl : BaseAppUserControl, IPurchaseReturnListView
    {
        private PurchaseReturnListPresenter _presenter;
        private PurchasingViewModel _selectedPurchasing;

        protected override string ModulName
        {
            get
            {
                return DbConstant.MODUL_PURCHASE_RETURN;
            }
        }

        public PurchaseReturnListControl(PurchaseReturnListModel model)
        {
            InitializeComponent();
            _presenter = new PurchaseReturnListPresenter(this, model);

            gvPurchasing.PopupMenuShowing += gvPurchasing_PopupMenuShowing;
            gvPurchasing.FocusedRowChanged += gvPurchasing_FocusedRowChanged;

            // init editor control accessibility
            btnListReturn.Enabled = AllowInsert;
            cmsListReturn.Enabled = AllowEdit;

            txtDateFilterFrom.EditValue = txtDateFilterTo.EditValue = DateTime.Today;

            this.Load += PurchaseReturnListControl_Load;
        }

        private void PurchaseReturnListControl_Load(object sender, EventArgs e)
        {
            btnSearch.PerformClick();
        }

        private void gvPurchasing_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            this.SelectedPurchasing = gvPurchasing.GetFocusedRow() as PurchasingViewModel;
        }

        private void gvPurchasing_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            GridView view = (GridView)sender;
            GridHitInfo hitInfo = view.CalcHitInfo(e.Point);
            if (hitInfo.InRow)
            {
                view.FocusedRowHandle = hitInfo.RowHandle;
                cmsEditor.Show(view.GridControl, e.Point);

                this.SelectedPurchasing = gvPurchasing.GetRow(view.FocusedRowHandle) as PurchasingViewModel;
            }
        }

        public DateTime? DateFilterFrom
        {
            get
            {
                return txtDateFilterFrom.EditValue != null ? Convert.ToDateTime(txtDateFilterFrom.EditValue) : null as DateTime?;
            }
            set
            {
                txtDateFilterFrom.EditValue = value;
            }
        }

        public DateTime? DateFilterTo
        {
            get
            {
                return txtDateFilterTo.EditValue != null ? Convert.ToDateTime(txtDateFilterTo.EditValue) : null as DateTime?;
            }
            set
            {
                txtDateFilterTo.EditValue = value;
            }
        }

        public List<PurchasingViewModel> PurchasingListData
        {
            get
            {
                return gridPurchasing.DataSource as List<PurchasingViewModel>;
            }
            set
            {
                if (InvokeRequired)
                {
                    this.Invoke(new MethodInvoker(delegate { gridPurchasing.DataSource = value; gvPurchasing.BestFitColumns(); }));
                }
                else
                {
                    gridPurchasing.DataSource = value;
                    gvPurchasing.BestFitColumns();
                }
            }
        }

        public PurchasingViewModel SelectedPurchasing
        {
            get
            {
                return _selectedPurchasing;
            }
            set
            {
                _selectedPurchasing = value;
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
                MethodBase.GetCurrentMethod().Info("Fecthing PurchaseReturn data...");
                _selectedPurchasing = null;
                FormHelpers.CurrentMainForm.UpdateStatusInformation("Memuat data pembelian...", false);
                bgwMain.RunWorkerAsync();
            }
        }

        private void txtDateFilter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch.PerformClick();
            }
        }

        private void bgwMain_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                _presenter.LoadPurchaseReturn();
            }
            catch (Exception ex)
            {
                MethodBase.GetCurrentMethod().Fatal("An error occured while trying to execute _presenter.LoadPurchaseReturn()", ex);
                e.Result = ex;
            }
        }

        private void bgwMain_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Result is Exception)
            {
                this.ShowError("Proses memuat data gagal!");
            }

            if (gvPurchasing.RowCount > 0)
            {
                SelectedPurchasing = gvPurchasing.GetRow(0) as PurchasingViewModel;
            }

            FormHelpers.CurrentMainForm.UpdateStatusInformation("Memuat data pembelian selesai", true);
        }

        private void btnListReturn_Click(object sender, EventArgs e)
        {
            PurchaseReturnTransactionListForm editor = Bootstrapper.Resolve<PurchaseReturnTransactionListForm>();
            editor.ShowDialog(this);

            btnSearch.PerformClick();
        }

        private void cmsAddReturn_Click(object sender, EventArgs e)
        {
            if (_selectedPurchasing != null)
            {
                //PurchaseReturnEditorForm editor = Bootstrapper.Resolve<PurchaseReturnEditorForm>();
                //editor.SelectedPurchaseReturn = _selectedPurchaseReturn;
                //editor.ShowDialog(this);

                btnSearch.PerformClick();
            }
        }

        private void cmsListReturn_Click(object sender, EventArgs e)
        {
            if (_selectedPurchasing != null)
            {
                //PurchaseReturnEditorForm editor = Bootstrapper.Resolve<PurchaseReturnEditorForm>();
                //editor.SelectedPurchaseReturn = _selectedPurchaseReturn;
                //editor.ShowDialog(this);

                btnSearch.PerformClick();
            }
        }

    }
}
