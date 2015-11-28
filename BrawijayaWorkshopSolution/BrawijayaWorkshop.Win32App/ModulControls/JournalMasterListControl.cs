using BrawijayaWorkshop.Constant;
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
    public partial class JournalMasterListControl : BaseAppUserControl, IJournalMasterListView
    {
        private JournalMasterListPresenter _presenter;
        private JournalMaster _selectedJournalMaster;

        protected override string ModulName
        {
            get
            {
                return DbConstant.MODUL_JOURNAL;
            }
        }

        public JournalMasterListControl(JournalMasterListModel model)
        {
            InitializeComponent();
            _presenter = new JournalMasterListPresenter(this, model);

            gvJournalMaster.FocusedRowChanged += gvJournalMaster_FocusedRowChanged;
            gvJournalMaster.PopupMenuShowing += gvJournalMaster_PopupMenuShowing;

            // init editor control accessibility
            btnNewJournal.Enabled = AllowInsert;
            cmsEditData.Enabled = AllowEdit;
            cmsDeleteData.Enabled = AllowDelete;

            this.Load += JournalMasterListControl_Load;
        }

        private void JournalMasterListControl_Load(object sender, EventArgs e)
        {
            btnSearch.PerformClick();
        }

        private void gvJournalMaster_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            GridView view = (GridView)sender;
            GridHitInfo hitInfo = view.CalcHitInfo(e.Point);
            if (hitInfo.InRow)
            {
                view.FocusedRowHandle = hitInfo.RowHandle;
                cmsEditor.Show(view.GridControl, e.Point);
            }
        }

        private void gvJournalMaster_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            _selectedJournalMaster = gvJournalMaster.GetFocusedRow() as JournalMaster;
        }

        public string NameFilter
        {
            get
            {
                return txtJournalName.Text;
            }
            set
            {
                txtJournalName.Text = value;
            }
        }

        public int ParentId
        {
            get
            {
                return lookupJournalParent.EditValue.AsInteger();
            }
            set
            {
                lookupJournalParent.EditValue = value;
            }
        }

        public List<JournalMaster> ParentDropdownList
        {
            get
            {
                return lookupJournalParent.Properties.DataSource as List<JournalMaster>;
            }
            set
            {
                lookupJournalParent.Properties.DataSource = value;
            }
        }

        public List<JournalMaster> JournalMasterListData
        {
            get
            {
                return gridJournalMaster.DataSource as List<JournalMaster>;
            }
            set
            {
                if (InvokeRequired)
                {
                    this.Invoke(new MethodInvoker(delegate { gridJournalMaster.DataSource = value; gvJournalMaster.BestFitColumns(); }));
                }
                else
                {
                    gridJournalMaster.DataSource = value;
                    gvJournalMaster.BestFitColumns();
                }
            }
        }

        public JournalMaster SelectedJournalMaster
        {
            get
            {
                return _selectedJournalMaster;
            }
            set
            {
                _selectedJournalMaster = value;
            }
        }

        private void bgwMain_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                _presenter.LoadData();
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

            FormHelpers.CurrentMainForm.UpdateStatusInformation("Memuat data jurnal selesai", true);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            RefreshDataView();
        }

        public override void RefreshDataView()
        {
            if (!bgwMain.IsBusy)
            {
                MethodBase.GetCurrentMethod().Info("Fecthing journal data...");
                _selectedJournalMaster = null;
                FormHelpers.CurrentMainForm.UpdateStatusInformation("Memuat data jurnal...", false);
                bgwMain.RunWorkerAsync();
            }
        }

        private void btnNewJournal_Click(object sender, EventArgs e)
        {
            JournalMasterEditorForm editor = Bootstrapper.Resolve<JournalMasterEditorForm>();
            editor.ShowDialog(this);

            btnSearch.PerformClick();
        }

        private void cmsEditData_Click(object sender, EventArgs e)
        {
            if(_selectedJournalMaster != null)
            {
                JournalMasterEditorForm editor = Bootstrapper.Resolve<JournalMasterEditorForm>();
                editor.SelectedJournalMaster = _selectedJournalMaster;
                editor.ShowDialog(this);

                btnSearch.PerformClick();
            }
        }

        private void cmsDeleteData_Click(object sender, EventArgs e)
        {
            if (SelectedJournalMaster == null) return;

            if (this.ShowConfirmation("Apakah anda yakin ingin jurnal: '" + SelectedJournalMaster.Name + "'?") == DialogResult.Yes)
            {
                try
                {
                    MethodBase.GetCurrentMethod().Info("Deleting jurnal: " + SelectedJournalMaster.Name);

                    _presenter.DeleteData();

                    btnSearch.PerformClick(); // refresh data
                }
                catch (Exception ex)
                {
                    MethodBase.GetCurrentMethod().Fatal("An error occured while trying to delete jurnal: '" + SelectedJournalMaster.Name + "'", ex);
                    this.ShowError("Proses hapus data jurnal: '" + SelectedJournalMaster.Name + "' gagal!");
                }
            }
        }

        private void txtJournalName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch.PerformClick();
            }
        }
    }
}
