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
    public partial class PurchaseReturnTransactionListForm : BaseDefaultForm, IPurchaseReturnTransactionListView
    {
        private PurchaseReturnTransactionListPresenter _presenter;
        private PurchaseReturnViewModel _selectedPurchaseReturn;

        protected override string ModulName
        {
            get
            {
                return DbConstant.MODUL_PURCHASE_RETURN;
            }
        }

        public PurchaseReturnTransactionListForm(PurchaseReturnTransactionListModel model)
        {
            InitializeComponent();
            _presenter = new PurchaseReturnTransactionListPresenter(this, model);

            gvReturn.PopupMenuShowing += gvReturn_PopupMenuShowing;
            gvReturn.FocusedRowChanged += gvReturn_FocusedRowChanged;

            // init editor control accessibility
            cmsEditData.Enabled = AllowEdit;
            cmsDeleteData.Enabled = AllowDelete;

            this.Load += PurchaseReturnTransactionListForm_Load;
        }

        private void PurchaseReturnTransactionListForm_Load(object sender, EventArgs e)
        {
            btnSearch.PerformClick();
        }

        private void gvReturn_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            this.SelectedPurchaseReturn = gvReturn.GetFocusedRow() as PurchaseReturnViewModel;
            if (this.SelectedPurchasing == null)
            {
                this.SelectedPurchasing = this.SelectedPurchaseReturn.Purchasing;
            }
        }

        private void gvReturn_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            GridView view = (GridView)sender;
            GridHitInfo hitInfo = view.CalcHitInfo(e.Point);
            if (hitInfo.InRow)
            {
                view.FocusedRowHandle = hitInfo.RowHandle;
                cmsEditor.Show(view.GridControl, e.Point);

                this.SelectedPurchaseReturn = gvReturn.GetRow(view.FocusedRowHandle) as PurchaseReturnViewModel;
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

        public List<PurchaseReturnViewModel> PurchaseReturnListData
        {
            get
            {
                return gridReturn.DataSource as List<PurchaseReturnViewModel>;
            }
            set
            {
                if (InvokeRequired)
                {
                    this.Invoke(new MethodInvoker(delegate { gridReturn.DataSource = value; gvReturn.BestFitColumns(); }));
                }
                else
                {
                    gridReturn.DataSource = value;
                    gvReturn.BestFitColumns();
                }
            }
        }

        public PurchasingViewModel SelectedPurchasing { get; set; }

        public PurchaseReturnViewModel SelectedPurchaseReturn
        {
            get
            {
                return _selectedPurchaseReturn;
            }
            set
            {
                _selectedPurchaseReturn = value;
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
                _selectedPurchaseReturn = null;
                FormHelpers.CurrentMainForm.UpdateStatusInformation("Memuat data retur pembelian...", false);
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_selectedPurchaseReturn == null) return;

            if (this.ShowConfirmation("Apakah anda yakin ingin menghapus retur pembelian: '" + SelectedPurchaseReturn.PurchasingId + "'?") == DialogResult.Yes)
            {
                try
                {
                    MethodBase.GetCurrentMethod().Info("Deleting purchase return: " + SelectedPurchaseReturn.PurchasingId);
                    _presenter.DeleteData();
                    RefreshDataView();

                }
                catch (Exception ex)
                {
                    MethodBase.GetCurrentMethod().Fatal("An error occured while trying to delete purchase return: '" + SelectedPurchaseReturn.PurchasingId + "'", ex);
                    this.ShowError("Proses hapus data retur pembelian: '" + SelectedPurchaseReturn.PurchasingId + "' gagal!");
                }
            }
        }

        private void cmsEditData_Click(object sender, EventArgs e)
        {
            if (_selectedPurchaseReturn != null)
            {
                PurchaseReturnEditorForm editor = Bootstrapper.Resolve<PurchaseReturnEditorForm>();
                editor.SelectedPurchasing = SelectedPurchasing;
                editor.SelectedPurchaseReturn = SelectedPurchaseReturn;
                editor.ShowDialog(this);
                RefreshDataView();

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

            if (gvReturn.RowCount > 0)
            {
                SelectedPurchaseReturn = gvReturn.GetRow(0) as PurchaseReturnViewModel;
            }

            FormHelpers.CurrentMainForm.UpdateStatusInformation("Memuat data retur pembelian selesai", true);
        }

    }
}
