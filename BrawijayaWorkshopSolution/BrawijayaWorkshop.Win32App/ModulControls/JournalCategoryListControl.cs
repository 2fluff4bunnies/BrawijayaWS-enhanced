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
    public partial class JournalCategoryListControl : BaseAppUserControl, IJournalCategoryListView
    {
        private JournalCategoryListPresenter _presenter;

        protected override string ModulName
        {
            get
            {
                return DbConstant.MODUL_ACCOUNTING;
            }
        }

        public int ParentId
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

        public List<ReferenceViewModel> ParentDropdownList
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

        public List<ReferenceViewModel> ChildrenListData
        {
            get
            {
                return gridCatJournal.DataSource as List<ReferenceViewModel>;
            }
            set
            {
                if (InvokeRequired)
                {
                    this.Invoke(new MethodInvoker(delegate { gridCatJournal.DataSource = value; gvCatJournal.BestFitColumns(); }));
                }
                else
                {
                    gridCatJournal.DataSource = value;
                    gvCatJournal.BestFitColumns();
                }
            }
        }

        public ReferenceViewModel SelectedChildren { get; set; }

        public JournalCategoryListControl(JournalCategoryListModel model)
        {
            InitializeComponent();

            _presenter = new JournalCategoryListPresenter(this, model);

            gvCatJournal.FocusedRowChanged += gvCatJournal_FocusedRowChanged;
            gvCatJournal.PopupMenuShowing += gvCatJournal_PopupMenuShowing;

            // init editor control accessibility
            btnNewChildren.Enabled = AllowInsert;
            cmsEditData.Enabled = AllowEdit;
            cmsDeleteData.Enabled = AllowDelete;

            this.Load += JournalCategoryListControl_Load;
        }

        private void gvCatJournal_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            GridView view = (GridView)sender;
            GridHitInfo hitInfo = view.CalcHitInfo(e.Point);
            if (hitInfo.InRow)
            {
                view.FocusedRowHandle = hitInfo.RowHandle;
                cmsEditor.Show(view.GridControl, e.Point);
            }
        }

        private void gvCatJournal_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            SelectedChildren = gvCatJournal.GetFocusedRow() as ReferenceViewModel;
        }

        private void JournalCategoryListControl_Load(object sender, EventArgs e)
        {
            _presenter.InitFormData();

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
                MethodBase.GetCurrentMethod().Info("Fecthing category journal account data...");
                SelectedChildren = null;
                FormHelpers.CurrentMainForm.UpdateStatusInformation("Memuat data kategori akun jurnal...", false);
                bgwMain.RunWorkerAsync();
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

            if (gvCatJournal.RowCount > 0)
            {
                SelectedChildren = gvCatJournal.GetRow(0) as ReferenceViewModel;
            }

            FormHelpers.CurrentMainForm.UpdateStatusInformation("Memuat data kategori akun selesai", true);
        }

        private void btnNewChildren_Click(object sender, EventArgs e)
        {
            JournalCategoryEditorForm editor = Bootstrapper.Resolve<JournalCategoryEditorForm>();
            editor.ShowDialog(this);

            btnSearch.PerformClick();
        }

        private void cmsEditData_Click(object sender, EventArgs e)
        {
            if (SelectedChildren == null) return;

            JournalCategoryEditorForm editor = Bootstrapper.Resolve<JournalCategoryEditorForm>();
            editor.SelectedChildren = SelectedChildren;
            editor.ShowDialog(this);

            btnSearch.PerformClick(); // refresh data
        }

        private void cmsDeleteData_Click(object sender, EventArgs e)
        {
            if (SelectedChildren == null) return;

            if (this.ShowConfirmation("Apakah anda yakin ingin menghapus: '" + SelectedChildren.Description + "'?") == DialogResult.Yes)
            {
                try
                {
                    MethodBase.GetCurrentMethod().Info("Deleting jurnal from category: " + SelectedChildren.Description);

                    _presenter.DeleteData();

                    btnSearch.PerformClick(); // refresh data
                }
                catch (Exception ex)
                {
                    MethodBase.GetCurrentMethod().Fatal("An error occured while trying to delete jurnal: '" + SelectedChildren.Description + "' from category", ex);
                    this.ShowError("Proses hapus data jurnal: '" + SelectedChildren.Description + "' dari kategory gagal!");
                }
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
                MethodBase.GetCurrentMethod().Fatal("An error occured while trying to export JournalCategory", ex);
                e.Result = ex;
            }
        }

        private void bgwExport_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Result is Exception)
            {
                this.ShowError("Proses export JournalCategory gagal!");
            }

            FormHelpers.CurrentMainForm.UpdateStatusInformation("Export JournalCategory selesai", true);
        }

        public string ExportFileName { get; set; }

        private void btnExportToCSV_Click(object sender, EventArgs e)
        {
            if (!bgwExport.IsBusy && !bgwMain.IsBusy)
            {
                ExportFileName = string.Empty;
                btnSearch.PerformClick();
                exportDialog.FileName = "JournalCategory_" + DateTime.Now.ToString("yyyyMMdd_HHmmssfff") + ".csv";
                exportDialog.ShowDialog(this);
            }
        }

        private void exportDialog_FileOk(object sender, CancelEventArgs e)
        {
            ExportFileName = exportDialog.FileName;

            MethodBase.GetCurrentMethod().Info("Exporting JournalCategory data...");
            FormHelpers.CurrentMainForm.UpdateStatusInformation("Proses export data JournalCategory...", false);
            bgwExport.RunWorkerAsync();
        }
    }
}
