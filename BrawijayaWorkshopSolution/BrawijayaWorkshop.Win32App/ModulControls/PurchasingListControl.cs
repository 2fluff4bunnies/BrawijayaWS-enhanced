using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.Presenter;
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
    public partial class PurchasingListControl : BaseAppUserControl, IPurchasingListView
    {
        private PurchasingListPresenter _presenter;
        private Purchasing _selectedPurchasing;

        protected override string ModulName
        {
            get
            {
                return DbConstant.MODUL_PURCHASING;
            }
        }

        public PurchasingListControl(PurchasingListModel model)
        {
            InitializeComponent();
            _presenter = new PurchasingListPresenter(this, model);

            gvPurchasing.PopupMenuShowing += gvPurchasing_PopupMenuShowing;
            gvPurchasing.FocusedRowChanged += gvPurchasing_FocusedRowChanged;

            // init editor control accessibility
            btnNewPurchasing.Enabled = AllowInsert;
            cmsEditData.Enabled = AllowEdit;

            this.Load += PurchasingListControl_Load;
        }

        private void PurchasingListControl_Load(object sender, EventArgs e)
        {
            btnSearch.PerformClick();
        }

        private void gvPurchasing_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            this.SelectedPurchasing = gvPurchasing.GetFocusedRow() as Purchasing;
        }

        private void gvPurchasing_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            GridView view = (GridView)sender;
            GridHitInfo hitInfo = view.CalcHitInfo(e.Point);
            if (hitInfo.InRow)
            {
                view.FocusedRowHandle = hitInfo.RowHandle;
                cmsEditor.Show(view.GridControl, e.Point);
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

        public List<Purchasing> PurchasingListData
        {
            get
            {
                return gridPurchasing.DataSource as List<Purchasing>;
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

        public Purchasing SelectedPurchasing
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
                MethodBase.GetCurrentMethod().Info("Fecthing Purchasing data...");
                _selectedPurchasing = null;
                FormHelpers.CurrentMainForm.UpdateStatusInformation("Memuat data Purchasing...", false);
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

        private void btnNewPurchasing_Click(object sender, EventArgs e)
        {
            PurchasingEditorForm editor = Bootstrapper.Resolve<PurchasingEditorForm>();
            editor.ShowDialog(this);

            btnSearch.PerformClick();
        }

        private void cmsEditData_Click(object sender, EventArgs e)
        {
            if (_selectedPurchasing != null)
            {
                PurchasingEditorForm editor = Bootstrapper.Resolve<PurchasingEditorForm>();
                editor.SelectedPurchasing = _selectedPurchasing;
                editor.ShowDialog(this);

                btnSearch.PerformClick();
            }
        }

        //private void cmsDeleteData_Click(object sender, EventArgs e)
        //{
        //    if (SelectedPurchasing == null) return;

        //    if (this.ShowConfirmation("Apakah anda yakin ingin menghapus Purchasing: '" + SelectedPurchasing.CompanyName + "'?") == DialogResult.Yes)
        //    {
        //        try
        //        {
        //            MethodBase.GetCurrentMethod().Info("Deleting Purchasing: " + SelectedPurchasing.CompanyName);

        //            _presenter.DeletePurchasing();

        //            btnSearch.PerformClick(); // refresh data
        //        }
        //        catch (Exception ex)
        //        {
        //            MethodBase.GetCurrentMethod().Fatal("An error occured while trying to delete Purchasing: '" + SelectedPurchasing.CompanyName + "'", ex);
        //            this.ShowError("Proses hapus data Purchasing: '" + SelectedPurchasing.CompanyName + "' gagal!");
        //        }
        //    }
        //}

        private void bgwMain_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                _presenter.LoadPurchasing();
            }
            catch (Exception ex)
            {
                MethodBase.GetCurrentMethod().Fatal("An error occured while trying to execute _presenter.LoadPurchasing()", ex);
                e.Result = ex;
            }
        }

        private void bgwMain_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Result is Exception)
            {
                this.ShowError("Proses memuat data gagal!");
            }

            FormHelpers.CurrentMainForm.UpdateStatusInformation("Memuat data Purchasing selesai", true);
        }

        private void gvPurchasing_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            ColumnView view = sender as ColumnView;
            if (e.Column.FieldName == "Status" && e.ListSourceRowIndex != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
            {
                int status = (int)view.GetListSourceRowCellValue(e.ListSourceRowIndex, "Status");
                switch (status)
                {
                    case 0: e.DisplayText = "Belum Disetujui"; break;
                    case 1: e.DisplayText = "Telah Disetujui"; break;
                }
            }
        }

    }
}
