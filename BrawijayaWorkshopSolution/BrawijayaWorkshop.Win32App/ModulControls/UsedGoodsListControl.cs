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
    public partial class UsedGoodsListControl : BaseAppUserControl, IUsedGoodListView
    {
        private UsedGoodListPresenter _presenter;
        private UsedGoodViewModel _selectedUsedGood;
        protected override string ModulName
        {
            get
            {
                return DbConstant.MODUL_USEDGOOD;
            }
        }
        public UsedGoodsListControl(UsedGoodListModel model)
        {
            InitializeComponent();
            _presenter = new UsedGoodListPresenter(this, model);

            gvUsedGood.PopupMenuShowing += gvUsedGood_PopupMenuShowing;
            gvUsedGood.FocusedRowChanged += gvUsedGood_FocusedRowChanged;

            // init editor control accessibility
            btnNewUsedGood.Enabled = AllowInsert;
            cmsEditData.Enabled = AllowEdit;
            cmsManageStok.Enabled = AllowEdit;
            cmsDeleteData.Enabled = AllowDelete;
            this.Load += UsedGoodsListControl_Load;
        }

        private void UsedGoodsListControl_Load(object sender, EventArgs e)
        {
            btnSearch.PerformClick();
        }

        private void gvUsedGood_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            this.SelectedUsedGood = gvUsedGood.GetFocusedRow() as UsedGoodViewModel;
        }

        private void gvUsedGood_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
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

        public List<UsedGoodViewModel> UsedGoodListData
        {
            get
            {
                return gridUsedGood.DataSource as List<UsedGoodViewModel>;
            }
            set
            {
                if (InvokeRequired)
                {
                    this.Invoke(new MethodInvoker(delegate { gridUsedGood.DataSource = value; gvUsedGood.BestFitColumns(); }));
                }
                else
                {
                    gridUsedGood.DataSource = value;
                    gvUsedGood.BestFitColumns();
                }
            }
        }

        public UsedGoodViewModel SelectedUsedGood
        {
            get
            {
                return _selectedUsedGood;
            }
            set
            {
                _selectedUsedGood = value;
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
                MethodBase.GetCurrentMethod().Info("Fecthing UsedGood data...");
                _selectedUsedGood = null;
                FormHelpers.CurrentMainForm.UpdateStatusInformation("Memuat data barang bekas...", false);
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

        private void btnNewUsedGood_Click(object sender, EventArgs e)
        {
            UsedGoodsEditorForm editor = Bootstrapper.Resolve<UsedGoodsEditorForm>();
            editor.ShowDialog(this);

            btnSearch.PerformClick();
        }

        private void cmsEditData_Click(object sender, EventArgs e)
        {
            if (_selectedUsedGood != null)
            {
                UsedGoodsEditorForm editor = Bootstrapper.Resolve<UsedGoodsEditorForm>();
                editor.SelectedUsedGood = _selectedUsedGood;
                editor.ShowDialog(this);

                btnSearch.PerformClick();
            }
        }

        private void cmsManageStock_Click(object sender, EventArgs e)
        {
            if (_selectedUsedGood != null)
            {
                UsedGoodTransactionEditorForm editor = Bootstrapper.Resolve<UsedGoodTransactionEditorForm>();
                editor.UsedGood = _selectedUsedGood;
                editor.IsManual = true;
                editor.ShowDialog(this);

                btnSearch.PerformClick();
            }
        }

        private void cmsDeleteData_Click(object sender, EventArgs e)
        {
            if (SelectedUsedGood == null) return;

            if (this.ShowConfirmation("Apakah anda yakin ingin menghapus barang bekas: '" + SelectedUsedGood.Sparepart.Name + "'?") == DialogResult.Yes)
            {
                try
                {
                    MethodBase.GetCurrentMethod().Info("Deleting barang bekas: " + SelectedUsedGood.Sparepart.Name);

                    _presenter.DeleteUsedGood();

                    btnSearch.PerformClick(); // refresh data
                }
                catch (Exception ex)
                {
                    MethodBase.GetCurrentMethod().Fatal("An error occured while trying to delete UsedGood: '" + SelectedUsedGood.Sparepart.Name + "'", ex);
                    this.ShowError("Proses hapus data barang bekas: '" + SelectedUsedGood.Sparepart.Name + "' gagal!");
                }
            }
        }

        private void bgwMain_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                _presenter.LoadUsedGood();
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

            if (gvUsedGood.RowCount > 0)
            {
                SelectedUsedGood = gvUsedGood.GetRow(0) as UsedGoodViewModel;
            }

            FormHelpers.CurrentMainForm.UpdateStatusInformation("Memuat data barang bekas selesai", true);
        }
    }
}
