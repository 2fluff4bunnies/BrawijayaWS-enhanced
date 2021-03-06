﻿using BrawijayaWorkshop.Constant;
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
    public partial class SupplierListControl : BaseAppUserControl, ISupplierListView
    {
        private SupplierListPresenter _presenter;
        private SupplierViewModel _selectedSupplier;

        protected override string ModulName
        {
            get
            {
                return DbConstant.MODUL_SUPPLIER;
            }
        }

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

            this.Load += SupplierListControl_Load;
        }

        private void SupplierListControl_Load(object sender, EventArgs e)
        {
            btnSearch.PerformClick();
        }

        private void gvSupplier_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            this.SelectedSupplier = gvSupplier.GetFocusedRow() as SupplierViewModel;
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

        public List<SupplierViewModel> SupplierListData
        {
            get
            {
                return gridSupplier.DataSource as List<SupplierViewModel>;
            }
            set
            {
                if (InvokeRequired)
                {
                    this.Invoke(new MethodInvoker(delegate { gridSupplier.DataSource = value; gvSupplier.BestFitColumns(); }));
                }
                else
                {
                    gridSupplier.DataSource = value;
                    gvSupplier.BestFitColumns();
                }
            }
        }

        public SupplierViewModel SelectedSupplier
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
            RefreshDataView();
        }

        public override void RefreshDataView()
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
            SupplierEditorForm editor = Bootstrapper.Resolve<SupplierEditorForm>();
            editor.ShowDialog(this);

            btnSearch.PerformClick();
        }

        private void cmsEditData_Click(object sender, EventArgs e)
        {
            if (_selectedSupplier != null)
            {
                SupplierEditorForm editor = Bootstrapper.Resolve<SupplierEditorForm>();
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
            if (SupplierListData != null && SupplierListData.Count > 0)
            {
                gvSupplier.FocusedRowHandle = 0;
                _selectedSupplier = gvSupplier.GetRow(0) as SupplierViewModel;
            }
            FormHelpers.CurrentMainForm.UpdateStatusInformation("Memuat data Supplier selesai", true);
        }

        private void bgwExport_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                _presenter.ExportToCSV();
            }
            catch (Exception ex)
            {
                MethodBase.GetCurrentMethod().Fatal("An error occured while trying to export Supplier", ex);
                e.Result = ex;
            }
        }

        private void bgwExport_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Result is Exception)
            {
                this.ShowError("Proses export Supplier gagal!");
            }

            FormHelpers.CurrentMainForm.UpdateStatusInformation("Export Supplier selesai", true);
        }

        public string ExportFileName { get; set; }

        private void btnExportToCSV_Click(object sender, EventArgs e)
        {
            if (!bgwExport.IsBusy && !bgwMain.IsBusy)
            {
                ExportFileName = string.Empty;
                btnSearch.PerformClick();
                exportDialog.FileName = "Supplier_" + DateTime.Now.ToString("yyyyMMdd_HHmmssfff") + ".csv";
                exportDialog.ShowDialog(this);
            }
        }

        private void exportDialog_FileOk(object sender, CancelEventArgs e)
        {
            ExportFileName = exportDialog.FileName;

            MethodBase.GetCurrentMethod().Info("Exporting Supplier data...");
            FormHelpers.CurrentMainForm.UpdateStatusInformation("Proses export data Supplier...", false);
            bgwExport.RunWorkerAsync();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (!gridSupplier.IsPrintingAvailable)
            {
                MessageBox.Show("Data Tidak Tersedia", "Warning");
                return;
            }

            // Print.
            gridSupplier.Print();
        }
    }
}
