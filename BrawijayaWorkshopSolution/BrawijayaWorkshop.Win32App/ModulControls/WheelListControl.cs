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
    public partial class WheelListControl : BaseAppUserControl, IWheelListView
    {
        private WheelListPresenter _presenter;
        private WheelViewModel _selectedWheel;
       
        protected override string ModulName
        {
            get
            {
                return DbConstant.MODUL_SPAREPART;
            }
        }

        public WheelListControl(WheelListModel model)
        {
            InitializeComponent();

            // init editor control accessibility
            btnNewWheel.Enabled = AllowInsert;
            cmsEditData.Enabled = AllowEdit;
            cmsDeleteData.Enabled = AllowDelete;

            _presenter = new WheelListPresenter(this, model);

            gvWheel.FocusedRowChanged += gvWheel_FocusedRowChanged;
            gvWheel.PopupMenuShowing += gvWheel_PopupMenuShowing;

            this.Load += WheelListControl_Load;
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

        public List<WheelViewModel> WheelListData
        {
            get
            {
                return gcWheel.DataSource as List<WheelViewModel>;
            }
            set
            {
                if (InvokeRequired)
                {
                    this.Invoke(new MethodInvoker(delegate { gcWheel.DataSource = value; gvWheel.BestFitColumns(); }));
                }
                else
                {
                    gcWheel.DataSource = value;
                    gvWheel.BestFitColumns();
                }
            }
        }

        public WheelViewModel SelectedWheel
        {
            get
            {
                return _selectedWheel;
            }
            set
            {
                _selectedWheel = value;
            }
        }

        private void bgwMain_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                _presenter.LoadWheel();
            }
            catch (Exception ex)
            {
                MethodBase.GetCurrentMethod().Fatal("An error occured while trying to execute _presenter.LoadWheel()", ex);
                e.Result = ex;
            }
        }
        #endregion

        void WheelListControl_Load(object sender, EventArgs e)
        {
            btnSearch.PerformClick();
        }

        void gvWheel_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            GridView view = (GridView)sender;
            GridHitInfo hitInfo = view.CalcHitInfo(e.Point);
            if (hitInfo.InRow)
            {
                view.FocusedRowHandle = hitInfo.RowHandle;
                cmsEditor.Show(view.GridControl, e.Point);
            }
        }

        void gvWheel_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            this.SelectedWheel = gvWheel.GetFocusedRow() as WheelViewModel;
        }

        private void viewDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_selectedWheel != null)
            {
                WheelDetailListForm listForm = Bootstrapper.Resolve<WheelDetailListForm>();
                listForm.SelectedWheel = _selectedWheel;
                listForm.ShowDialog(this);

                btnSearch.PerformClick();
            }
        }

        private void cmsEditData_Click(object sender, EventArgs e)
        {
            if (_selectedWheel != null)
            {
                WheelEditorForm editor = Bootstrapper.Resolve<WheelEditorForm>();
                editor.SelectedWheel = _selectedWheel;
                editor.ShowDialog(this);

                btnSearch.PerformClick();
            }
        }

        private void cmsDeleteData_Click(object sender, EventArgs e)
        {
            if (SelectedWheel == null) return;

            if (this.ShowConfirmation("Apakah anda yakin ingin ban: '" + SelectedWheel.Sparepart.Name + "'?") == DialogResult.Yes)
            {
                try
                {
                    MethodBase.GetCurrentMethod().Info("Deleting wheel: " + SelectedWheel.Sparepart.Name);

                    _presenter.DeleteWheel();

                    btnSearch.PerformClick(); // refresh data
                }
                catch (Exception ex)
                {
                    MethodBase.GetCurrentMethod().Fatal("An error occured while trying to delete wheel: '" + SelectedWheel.Sparepart.Name + "'", ex);
                    this.ShowError("Proses hapus data ban: '" + SelectedWheel.Sparepart.Name + "' gagal!");
                }
            }
        }

        private void btnNewWheel_Click(object sender, EventArgs e)
        {
            WheelEditorForm editor = Bootstrapper.Resolve<WheelEditorForm>();
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
                MethodBase.GetCurrentMethod().Info("Fecthing wheel data...");
                _selectedWheel = null;
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

            if (gvWheel.RowCount > 0)
            {
                SelectedWheel = gvWheel.GetRow(0) as WheelViewModel;
            }

            FormHelpers.CurrentMainForm.UpdateStatusInformation("Memuat data ban selesai", true);
        }

        private void txtWheelName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch.PerformClick();
            }
        }

    }
}
