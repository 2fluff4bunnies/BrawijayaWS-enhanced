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
    public partial class BrandListControl : BaseAppUserControl, IBrandListView
    {
        private BrandListPresenter _presenter;
        private BrandViewModel _selectedBrand;

        protected override string ModulName
        {
            get
            {
                return DbConstant.MODUL_BRAND;
            }
        }

        public BrandListControl(BrandListModel model)
        {
            InitializeComponent();
            _presenter = new BrandListPresenter(this, model);

            gvBrand.PopupMenuShowing += gvBrand_PopupMenuShowing;
            gvBrand.FocusedRowChanged += gvBrand_FocusedRowChanged;

            // init editor control accessibility
            btnNewBrand.Enabled = AllowInsert;
            cmsEditData.Enabled = AllowEdit;
            cmsDeleteData.Enabled = AllowDelete;

            this.Load += BrandListControl_Load;
        }

        private void BrandListControl_Load(object sender, EventArgs e)
        {
            btnSearch.PerformClick();
        }

        private void gvBrand_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            this.SelectedBrand = gvBrand.GetFocusedRow() as BrandViewModel;
        }

        private void gvBrand_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            GridView view = (GridView)sender;
            GridHitInfo hitInfo = view.CalcHitInfo(e.Point);
            if (hitInfo.InRow)
            {
                view.FocusedRowHandle = hitInfo.RowHandle;
                cmsEditor.Show(view.GridControl, e.Point);
            }
        }

        public string NameFilter
        {
            get
            {
                return txtFilterName.Text;
            }
            set
            {
                txtFilterName.Text = value;
            }
        }

        public List<BrandViewModel> BrandListData
        {
            get
            {
                return gridBrand.DataSource as List<BrandViewModel>;
            }
            set
            {
                if (InvokeRequired)
                {
                    this.Invoke(new MethodInvoker(delegate { gridBrand.DataSource = value; gvBrand.BestFitColumns(); }));
                }
                else
                {
                    gridBrand.DataSource = value;
                    gvBrand.BestFitColumns();
                }
            }
        }

        public BrandViewModel SelectedBrand
        {
            get
            {
                return _selectedBrand;
            }
            set
            {
                _selectedBrand = value;
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
                MethodBase.GetCurrentMethod().Info("Fecthing brand data...");
                _selectedBrand = null;
                FormHelpers.CurrentMainForm.UpdateStatusInformation("Memuat data brand...", false);
                bgwMain.RunWorkerAsync();
            }
        }

        private void txtFilter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch.PerformClick();
            }
        }

        private void btnNewBrand_Click(object sender, EventArgs e)
        {
            BrandEditorForm editor = Bootstrapper.Resolve<BrandEditorForm>();
            editor.ShowDialog(this);

            btnSearch.PerformClick();
        }

        private void cmsEditData_Click(object sender, EventArgs e)
        {
            if (_selectedBrand != null)
            {
                BrandEditorForm editor = Bootstrapper.Resolve<BrandEditorForm>();
                editor.SelectedBrand = _selectedBrand;
                editor.ShowDialog(this);

                btnSearch.PerformClick();
            }
        }

        private void cmsDeleteData_Click(object sender, EventArgs e)
        {
            if (SelectedBrand == null) return;

            if (this.ShowConfirmation("Apakah anda yakin ingin menghapus brand: '" + SelectedBrand.Name + "'?") == DialogResult.Yes)
            {
                try
                {
                    MethodBase.GetCurrentMethod().Info("Deleting brand: " + SelectedBrand.Name);

                    _presenter.DeleteBrand();

                    btnSearch.PerformClick(); // refresh data
                }
                catch (Exception ex)
                {
                    MethodBase.GetCurrentMethod().Fatal("An error occured while trying to delete brand: '" + SelectedBrand.Name + "'", ex);
                    this.ShowError("Proses hapus data brand: '" + SelectedBrand.Name + "' gagal!");
                }
            }
        }

        private void bgwMain_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                _presenter.LoadBrand();
            }
            catch (Exception ex)
            {
                MethodBase.GetCurrentMethod().Fatal("An error occured while trying to execute _presenter.LoadBrand()", ex);
                e.Result = ex;
            }
        }

        private void bgwMain_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Result is Exception)
            {
                this.ShowError("Proses memuat data gagal!");
            }

            if (gvBrand.RowCount > 0)
            {
                SelectedBrand = gvBrand.GetRow(0) as BrandViewModel;
            }

            FormHelpers.CurrentMainForm.UpdateStatusInformation("Memuat data brand selesai", true);
        }

        private void bgwExport_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                _presenter.ExportToCSV();
            }
            catch (Exception ex)
            {
                MethodBase.GetCurrentMethod().Fatal("An error occured while trying to export Brand", ex);
                e.Result = ex;
            }
        }

        private void bgwExport_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Result is Exception)
            {
                this.ShowError("Proses export Brand gagal!");
            }

            FormHelpers.CurrentMainForm.UpdateStatusInformation("Export Brand selesai", true);
        }

        public string ExportFileName { get; set; }

        private void btnExportToCSV_Click(object sender, EventArgs e)
        {
            if (!bgwExport.IsBusy && !bgwMain.IsBusy)
            {
                ExportFileName = string.Empty;
                btnSearch.PerformClick();
                exportDialog.FileName = "Brand_" + DateTime.Now.ToString("yyyyMMdd_HHmmssfff") + ".csv";
                exportDialog.ShowDialog(this);
            }
        }

        private void exportDialog_FileOk(object sender, CancelEventArgs e)
        {
            ExportFileName = exportDialog.FileName;

            MethodBase.GetCurrentMethod().Info("Exporting Brand data...");
            FormHelpers.CurrentMainForm.UpdateStatusInformation("Proses export data Brand...", false);
            bgwExport.RunWorkerAsync();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (!gridBrand.IsPrintingAvailable)
            {
                MessageBox.Show("Data Tidak Tersedia", "Warning");
                return;
            }

            // Print.
            gridBrand.Print();
        }
    }
}
