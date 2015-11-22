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
    public partial class SupplierListControl : BaseAppUserControl, ISupplierListView
    {
        private SupplierListPresenter _presenter;
        private Supplier _selectedSupplier;

        public SupplierListControl(SupplierListModel model)
        {
            InitializeComponent();
            _presenter = new SupplierListPresenter(this, model);

            gvSupplier.PopupMenuShowing += gvSupplier_PopupMenuShowing;
            gvSupplier.FocusedRowChanged += gvSupplier_FocusedRowChanged;

            // init editor control accessibility
            btnNewSupplier.Enabled = AllowInsert;
            cmsEditData.Enabled = AllowEdit;
            cmsDeleteData.Enabled = AllowDelete;
        }

        private void gvSupplier_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            this.SelectedSupplier = gvSupplier.GetFocusedRow() as Supplier;
        }

        private void gvSupplier_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            GridView view = (GridView)sender;
            GridHitInfo hitInfo = view.CalcHitInfo(e.Point);
            if (hitInfo.InRow)
            {
                view.FocusedRowHandle = hitInfo.RowHandle;
                cmsEditor.Show(view.GridControl, e.Point);
            }
        }

        public string SupplierNameFilter
        {
            get
            {
                return txtFilterSupplierName.Text;
            }
            set
            {
                txtFilterSupplierName.Text = value;
            }
        }

        public List<Supplier> SupplierListData
        {
            get
            {
                return gridSupplier.DataSource as List<Supplier>;
            }
            set
            {
                if (InvokeRequired)
                {
                    this.Invoke(new MethodInvoker(delegate { gridSupplier.DataSource = value; }));
                }
                else
                {
                    gridSupplier.DataSource = value;
                }
            }
        }

        public Supplier SelectedSupplier
        {
            get
            {
                return _selectedSupplier;
            }
            set
            {
                _selectedSupplier = value;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!bgwMain.IsBusy)
            {
                MethodBase.GetCurrentMethod().Info("Fecthing Supplier data...");
                _selectedSupplier = null;
                FormHelpers.CurrentMainForm.UpdateStatusInformation("Memuat data Supplier...", false);
                bgwMain.RunWorkerAsync();
            }
        }

        private void txtFilterSupplierName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch.PerformClick();
            }
        }

        private void btnNewSupplier_Click(object sender, EventArgs e)
        {
            SupplierEditorForm editor = Boostrapper.Resolve<SupplierEditorForm>();
            editor.ShowDialog(this);

            btnSearch.PerformClick();
        }

        private void cmsEditData_Click(object sender, EventArgs e)
        {
            if (_selectedSupplier != null)
            {
                SupplierEditorForm editor = Boostrapper.Resolve<SupplierEditorForm>();
                editor.SelectedSupplier = _selectedSupplier;
                editor.ShowDialog(this);

                btnSearch.PerformClick();
            }
        }

        private void cmsDeleteData_Click(object sender, EventArgs e)
        {
            if (SelectedSupplier == null) return;

            if (this.ShowConfirmation("Apakah anda yakin ingin Supplier: '" + SelectedSupplier.Name + "'?") == DialogResult.Yes)
            {
                try
                {
                    MethodBase.GetCurrentMethod().Info("Deleting Supplier: " + SelectedSupplier.Name);

                    _presenter.DeleteSupplier();

                    btnSearch.PerformClick(); // refresh data
                }
                catch (Exception ex)
                {
                    MethodBase.GetCurrentMethod().Fatal("An error occured while trying to delete Supplier: '" + SelectedSupplier.Name + "'", ex);
                    this.ShowError("Proses hapus data Supplier: '" + SelectedSupplier.Name + "' gagal!");
                }
            }
        }

        private void bgwMain_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                _presenter.LoadSupplier();
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

            FormHelpers.CurrentMainForm.UpdateStatusInformation("Memuat data Supplier selesai", true);
        }
    }
}
