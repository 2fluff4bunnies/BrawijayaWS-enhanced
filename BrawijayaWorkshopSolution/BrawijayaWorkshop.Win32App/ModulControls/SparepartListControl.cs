using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BrawijayaWorkshop.View;
using BrawijayaWorkshop.Presenter;
using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Model;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using BrawijayaWorkshop.Utils;
using System.Reflection;
using BrawijayaWorkshop.Win32App.ModulForms;

namespace BrawijayaWorkshop.Win32App.ModulControls
{
    public partial class SparepartListControl : BaseAppUserControl, ISparepartListView
    {
        private SparepartListPresenter _presenter;
        private Sparepart _selectedSparepart;

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
            this.SelectedSparepart = gvSparepart.GetFocusedRow() as Sparepart;
        }

        private void btnSearch_Click(object sender, EventArgs e)
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

        public List<Reference> CategoryDropdownList
        {
            get
            {
                return lookUpCategory.Properties.DataSource as List<Reference>;
            }
            set
            {
                lookUpCategory.Properties.DataSource = value;
            }
        }

        public List<Sparepart> SparepartListData
        {
            get
            {
                return gridSparepart.DataSource as List<Sparepart>;
            }
            set
            {
                if (InvokeRequired)
                {
                    this.Invoke(new MethodInvoker(delegate { gridSparepart.DataSource = value; }));
                }
                else
                {
                    gridSparepart.DataSource = value;
                }
            }
        }

        public Sparepart SelectedSparepart
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
            SparepartEditorForm editor = Boostrapper.Resolve<SparepartEditorForm>();
            editor.ShowDialog(this);

            btnSearch.PerformClick();
        }

        private void cmsEditData_Click(object sender, EventArgs e)
        {
            if (_selectedSparepart != null)
            {
                SparepartEditorForm editor = Boostrapper.Resolve<SparepartEditorForm>();
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
    }
}
