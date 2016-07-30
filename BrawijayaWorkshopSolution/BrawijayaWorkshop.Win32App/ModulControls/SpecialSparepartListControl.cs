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
    public partial class SpecialSparepartListControl : BaseAppUserControl, ISpecialSparepartListView
    {
        private SpecialSparepartListPresenter _presenter;
        private SpecialSparepartViewModel _selectedSpecialSparepart;
       
        protected override string ModulName
        {
            get
            {
                return DbConstant.MODUL_SPAREPART;
            }
        }

        public SpecialSparepartListControl(SpecialSparepartListModel model)
        {
            InitializeComponent();

            // init editor control accessibility
            btnNewSpecialSparepart.Enabled = AllowInsert;
            cmsEditData.Enabled = AllowEdit;
            cmsDeleteData.Enabled = AllowDelete;

            _presenter = new SpecialSparepartListPresenter(this, model);

            gvSpecialSparepart.FocusedRowChanged += gvSpecialSparepart_FocusedRowChanged;
            gvSpecialSparepart.PopupMenuShowing += gvSpecialSparepart_PopupMenuShowing;

            this.Load += SpecialSparepartListControl_Load;
        }

        #region Properties

        public string NameFilter
        {
            get
            {
                return txtFilter.Text;
            }
            set
            {
                txtFilter.Text = value;
            }
        }

        public List<SpecialSparepartViewModel> SpecialSparepartListData
        {
            get
            {
                return gcSpecialSparepart.DataSource as List<SpecialSparepartViewModel>;
            }
            set
            {
                if (InvokeRequired)
                {
                    this.Invoke(new MethodInvoker(delegate { gcSpecialSparepart.DataSource = value; gvSpecialSparepart.BestFitColumns(); }));
                }
                else
                {
                    gcSpecialSparepart.DataSource = value;
                    gvSpecialSparepart.BestFitColumns();
                }
            }
        }

        public SpecialSparepartViewModel SelectedSpecialSparepart
        {
            get
            {
                return _selectedSpecialSparepart;
            }
            set
            {
                _selectedSpecialSparepart = value;
            }
        }

        private void bgwMain_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                _presenter.LoadSpecialSparepart();
            }
            catch (Exception ex)
            {
                MethodBase.GetCurrentMethod().Fatal("An error occured while trying to execute _presenter.LoadSpecialSparepart()", ex);
                e.Result = ex;
            }
        }
        #endregion

        void SpecialSparepartListControl_Load(object sender, EventArgs e)
        {
            btnSearch.PerformClick();
        }

        void gvSpecialSparepart_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            GridView view = (GridView)sender;
            GridHitInfo hitInfo = view.CalcHitInfo(e.Point);
            if (hitInfo.InRow)
            {
                view.FocusedRowHandle = hitInfo.RowHandle;
                cmsEditor.Show(view.GridControl, e.Point);
            }
            if (this.SelectedSpecialSparepart.Sparepart.StockQty > 0)
                this.cmsDeleteData.Enabled = false;
            else
                this.cmsDeleteData.Enabled = true;
           
        }

        void gvSpecialSparepart_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            this.SelectedSpecialSparepart = gvSpecialSparepart.GetFocusedRow() as SpecialSparepartViewModel;
        }

        private void viewDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_selectedSpecialSparepart != null)
            {
                SpecialSparepartDetailListForm listForm = Bootstrapper.Resolve<SpecialSparepartDetailListForm>();
                listForm.SelectedSpecialSparepart = _selectedSpecialSparepart;
                listForm.ShowDialog(this);

                btnSearch.PerformClick();
            }
        }

        private void cmsEditData_Click(object sender, EventArgs e)
        {
            if (_selectedSpecialSparepart != null)
            {
                SpecialSparepartEditorForm editor = Bootstrapper.Resolve<SpecialSparepartEditorForm>();
                editor.SelectedSpecialSparepart = _selectedSpecialSparepart;
                editor.ShowDialog(this);

                btnSearch.PerformClick();
            }
        }

        private void cmsDeleteData_Click(object sender, EventArgs e)
        {
            if (SelectedSpecialSparepart == null) return;

            if (this.ShowConfirmation("Apakah anda yakin ingin ban: '" + SelectedSpecialSparepart.Sparepart.Name + "'?") == DialogResult.Yes)
            {
                try
                {
                    MethodBase.GetCurrentMethod().Info("Deleting specialSparepart: " + SelectedSpecialSparepart.Sparepart.Name);

                    _presenter.DeleteWheel();

                    btnSearch.PerformClick(); // refresh data
                }
                catch (Exception ex)
                {
                    MethodBase.GetCurrentMethod().Fatal("An error occured while trying to delete special sparepart: '" + SelectedSpecialSparepart.Sparepart.Name + "'", ex);
                    this.ShowError("Proses hapus data ban: '" + SelectedSpecialSparepart.Sparepart.Name + "' gagal!");
                }
            }
        }

        private void btnNewSpecialSparepart_Click(object sender, EventArgs e)
        {
            SpecialSparepartEditorForm editor = Bootstrapper.Resolve<SpecialSparepartEditorForm>();
            editor.ShowDialog(this);

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
                MethodBase.GetCurrentMethod().Info("Fecthing specialSparepart data...");
                _selectedSpecialSparepart = null;
                FormHelpers.CurrentMainForm.UpdateStatusInformation("Memuat data ban...", false);
                bgwMain.RunWorkerAsync();
            }
        }

      

        private void bgwMain_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Result is Exception)
            {
                this.ShowError("Proses memuat data gagal!");
            }

            if (gvSpecialSparepart.RowCount > 0)
            {
                SelectedSpecialSparepart = gvSpecialSparepart.GetRow(0) as SpecialSparepartViewModel;
            }

            FormHelpers.CurrentMainForm.UpdateStatusInformation("Memuat data ban selesai", true);
        }

        private void txtSpecialSparepartName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch.PerformClick();
            }
        }

    }
}
