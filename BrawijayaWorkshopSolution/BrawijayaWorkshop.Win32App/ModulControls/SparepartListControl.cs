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
    public partial class SparepartListControl : BaseAppUserControl, ISparepartListView
    {
        private SparepartListPresenter _presenter;
        private SparepartViewModel _selectedSparepart;

        protected override string ModulName
        {
            get
            {
                return DbConstant.MODUL_SPAREPART;
            }
        }

        public SparepartListControl(SparepartListModel model)
        {
            InitializeComponent();

            _presenter = new SparepartListPresenter(this, model);

            gvSparepart.FocusedRowChanged += gvSparepart_FocusedRowChanged;
            gvSparepart.PopupMenuShowing += gvSparepart_PopupMenuShowing;

            // init editor control accessibility
            btnNewSparepart.Enabled = AllowInsert;
            cmsEditData.Enabled = AllowEdit;
            cmsDeleteData.Enabled = AllowDelete;

            this.Load += SparepartListControl_Load;
        }

        private void SparepartListControl_Load(object sender, EventArgs e)
        {
            _presenter.InitData();
            btnSearch.PerformClick();
        }

        private void gvSparepart_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            GridView view = (GridView)sender;
            GridHitInfo hitInfo = view.CalcHitInfo(e.Point);
            if (hitInfo.InRow)
            {
                view.FocusedRowHandle = hitInfo.RowHandle;
                cmsEditor.Show(view.GridControl, e.Point);
            }
        }

        private void gvSparepart_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            this.SelectedSparepart = gvSparepart.GetFocusedRow() as SparepartViewModel;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            RefreshDataView();
        }

        public override void RefreshDataView()
        {
            if (!bgwMain.IsBusy)
            {
                MethodBase.GetCurrentMethod().Info("Fecthing sparepart data...");
                _selectedSparepart = null;
                FormHelpers.CurrentMainForm.UpdateStatusInformation("Memuat data sparepart...", false);
                bgwMain.RunWorkerAsync();
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

        public string NameFilter
        {
            get
            {
                return txtSparepartName.Text;
            }
            set
            {
                txtSparepartName.Text = value;
            }
        }

        public List<ReferenceViewModel> CategoryDropdownList
        {
            get
            {
                return lookUpCategory.Properties.DataSource as List<ReferenceViewModel>;
            }
            set
            {
                lookUpCategory.Properties.DataSource = value;
            }
        }

        public List<SparepartViewModel> SparepartListData
        {
            get
            {
                return gridSparepart.DataSource as List<SparepartViewModel>;
            }
            set
            {
                if (InvokeRequired)
                {
                    this.Invoke(new MethodInvoker(delegate { gridSparepart.DataSource = value; gvSparepart.BestFitColumns(); }));
                }
                else
                {
                    gridSparepart.DataSource = value;
                    gvSparepart.BestFitColumns();
                }
            }
        }

        public SparepartViewModel SelectedSparepart
        {
            get
            {
                return _selectedSparepart;
            }
            set
            {
                _selectedSparepart = value;
            }
        }

        private void bgwMain_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                _presenter.LoadSparepart();
            }
            catch (Exception ex)
            {
                MethodBase.GetCurrentMethod().Fatal("An error occured while trying to execute _presenter.LoadSparepart()", ex);
                e.Result = ex;
            }
        }

        private void bgwMain_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Result is Exception)
            {
                this.ShowError("Proses memuat data gagal!");
            }

            if(gvSparepart.RowCount > 0)
            {
                SelectedSparepart = gvSparepart.GetRow(0) as SparepartViewModel;
            }

            FormHelpers.CurrentMainForm.UpdateStatusInformation("Memuat data sparepart selesai", true);
        }

        private void txtSparepartName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch.PerformClick();
            }
        }

        private void btnNewSparepart_Click(object sender, EventArgs e)
        {
            SparepartEditorForm editor = Bootstrapper.Resolve<SparepartEditorForm>();
            editor.ShowDialog(this);

            btnSearch.PerformClick();
        }

        private void cmsEditData_Click(object sender, EventArgs e)
        {
            if (_selectedSparepart != null)
            {
                SparepartEditorForm editor = Bootstrapper.Resolve<SparepartEditorForm>();
                editor.SelectedSparepart = _selectedSparepart;
                editor.ShowDialog(this);

                btnSearch.PerformClick();
            }
        }

        private void cmsDeleteData_Click(object sender, EventArgs e)
        {
            if (SelectedSparepart == null) return;

            if (this.ShowConfirmation("Apakah anda yakin ingin sparepart: '" + SelectedSparepart.Name + "'?") == DialogResult.Yes)
            {
                try
                {
                    MethodBase.GetCurrentMethod().Info("Deleting sparepart: " + SelectedSparepart.Name);

                    _presenter.DeleteSparepart();

                    btnSearch.PerformClick(); // refresh data
                }
                catch (Exception ex)
                {
                    MethodBase.GetCurrentMethod().Fatal("An error occured while trying to delete sparepart: '" + SelectedSparepart.Name + "'", ex);
                    this.ShowError("Proses hapus data sparepart: '" + SelectedSparepart.Name + "' gagal!");
                }
            }
        }

        private void viewDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_selectedSparepart != null && _selectedSparepart.IsSpecialSparepart)
            {
                SparepartDetailListForm detail = Bootstrapper.Resolve<SparepartDetailListForm>();
                detail.SelectedSparepart = _selectedSparepart;
                detail.ShowDialog(this);
            }
        }

        private void cmsManageStock_Click(object sender, EventArgs e)
        {
            if (_selectedSparepart != null)
            {
                SparepartManualTransactionEditorForm detail = Bootstrapper.Resolve<SparepartManualTransactionEditorForm>();
                detail.Sparepart = _selectedSparepart;
                detail.ShowDialog(this);
                btnSearch.PerformClick();
            }
        }

        private void bgwExport_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                _presenter.ExportToCSV();
            }
            catch (Exception ex)
            {
                MethodBase.GetCurrentMethod().Fatal("An error occured while trying to export Sparepart", ex);
                e.Result = ex;
            }
        }

        private void bgwExport_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Result is Exception)
            {
                this.ShowError("Proses export Sparepart gagal!");
            }

            FormHelpers.CurrentMainForm.UpdateStatusInformation("Export Sparepart selesai", true);
        }

        public string ExportFileName { get; set; }

        private void btnExportToCSV_Click(object sender, EventArgs e)
        {
            if (!bgwExport.IsBusy && !bgwMain.IsBusy)
            {
                ExportFileName = string.Empty;
                btnSearch.PerformClick();
                exportDialog.FileName = "Sparepart_" + DateTime.Now.ToString("yyyyMMdd_HHmmssfff") + ".csv";
                exportDialog.ShowDialog(this);
            }
        }

        private void exportDialog_FileOk(object sender, CancelEventArgs e)
        {
            ExportFileName = exportDialog.FileName;

            MethodBase.GetCurrentMethod().Info("Exporting Sparepart data...");
            FormHelpers.CurrentMainForm.UpdateStatusInformation("Proses export data Sparepart...", false);
            bgwExport.RunWorkerAsync();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (!gridSparepart.IsPrintingAvailable)
            {
                MessageBox.Show("Data Tidak Tersedia", "Warning");
                return;
            }

            // Print.
            gridSparepart.Print();
        }
    }
}
