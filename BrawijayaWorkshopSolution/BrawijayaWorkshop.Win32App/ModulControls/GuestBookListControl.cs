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
    public partial class GuestBookListControl : BaseAppUserControl, IGuestBookListView
    {
        private GuestBookListPresenter _presenter;

        protected override string ModulName
        {
            get
            {
                return DbConstant.MODUL_GUESTBOOK;
            }
        }

        public GuestBookListControl(GuestBookListModel model)
        {
            InitializeComponent();
            _presenter = new GuestBookListPresenter(this, model);

            gvGuestBook.PopupMenuShowing += gvGuestBook_PopupMenuShowing;
            gvGuestBook.FocusedRowChanged += gvGuestBook_FocusedRowChanged;

            // init editor control accessibility
            btnNewGuestBook.Enabled = AllowInsert;
            cmsEditData.Enabled = AllowEdit;
            cmsDeleteData.Enabled = AllowDelete;

            this.CreatedDateFilter = System.DateTime.Now;

            this.Load +=GuestBookListControl_Load;
        }

        void GuestBookListControl_Load(object sender, EventArgs e)
        {
            btnSearch.PerformClick();
        }

        #region Properties

        public GuestBookViewModel SelectedGuestBook { get; set; }

        public string ActiveLicenseNumberFilter
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

        public List<GuestBookViewModel> GuestBookListData
        {
            get
            {
                return gcGuestBook.DataSource as List<GuestBookViewModel>;
            }
            set
            {
                if (InvokeRequired)
                {
                    this.Invoke(new MethodInvoker(delegate { gcGuestBook.DataSource = value; gvGuestBook.BestFitColumns(); }));
                }
                else
                {
                    gcGuestBook.DataSource = value;
                    gvGuestBook.BestFitColumns();
                }
            }
        }

        public DateTime CreatedDateFilter
        {
            get
            {
                return dtpCreatedDate.Text.AsDateTime();
            }
            set
            {
                dtpCreatedDate.Text = value.ToShortDateString();
            }
        }
        #endregion

        void gvGuestBook_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            this.SelectedGuestBook = gvGuestBook.GetFocusedRow() as GuestBookViewModel;
        }

        void gvGuestBook_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            GridView view = (GridView)sender;
            GridHitInfo hitInfo = view.CalcHitInfo(e.Point);
            if (hitInfo.InRow)
            {
                view.FocusedRowHandle = hitInfo.RowHandle;
                cmsEditor.Show(view.GridControl, e.Point);
            }
        }

        public override void RefreshDataView()
        {
            if (!bgwMain.IsBusy)
            {
                MethodBase.GetCurrentMethod().Info("Fecthing daftar hadir kendaraan data...");
                this.SelectedGuestBook = null;
                FormHelpers.CurrentMainForm.UpdateStatusInformation("Memuat daftar hadir...", false);
                bgwMain.RunWorkerAsync();
            }
        }

        private void bgwMain_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                _presenter.LoadGuestBook();
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

            if (gvGuestBook.RowCount > 0)
            {
                this.SelectedGuestBook = gvGuestBook.GetRow(0) as GuestBookViewModel;
            }

            FormHelpers.CurrentMainForm.UpdateStatusInformation("Memuat data kendaraan selesai", true);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            RefreshDataView();
        }

        private void btnNewGuestBook_Click(object sender, EventArgs e)
        {
            GuestBookEditorForm editor = Bootstrapper.Resolve<GuestBookEditorForm>();
            editor.ShowDialog(this);

            btnSearch.PerformClick();
        }

        private void cmsEditData_Click(object sender, EventArgs e)
        {
            GuestBookEditorForm editor = Bootstrapper.Resolve<GuestBookEditorForm>();
            editor.SelectedGuestBook = this.SelectedGuestBook;
            editor.ShowDialog(this);

            btnSearch.PerformClick();
        }

        private void cmsDeleteData_Click(object sender, EventArgs e)
        {
            if (this.SelectedGuestBook == null) return;

            if (this.ShowConfirmation("Apakah anda yakin ingin menghapus daftar hadir kendaraan dengan nomor polisi : '" + SelectedGuestBook.Vehicle.ActiveLicenseNumber + "'?") == DialogResult.Yes)
            {
                try
                {
                    MethodBase.GetCurrentMethod().Info("Mengapus daftar hadir kendaraan dengan nomor polisi : " + SelectedGuestBook.Vehicle.ActiveLicenseNumber);

                    _presenter.DeleteGuestBook();

                    btnSearch.PerformClick(); // refresh data
                }
                catch (Exception ex)
                {
                    MethodBase.GetCurrentMethod().Fatal("An error occured while trying to delete vehicle with license number: '" + SelectedGuestBook.Vehicle.ActiveLicenseNumber + "'", ex);
                    this.ShowError("Proses hapus daftar hadir kendaraan dengan nomor polisi : '" + SelectedGuestBook.Vehicle.ActiveLicenseNumber + "' gagal!");
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
                MethodBase.GetCurrentMethod().Fatal("An error occured while trying to export GuestBook", ex);
                e.Result = ex;
            }
        }

        private void bgwExport_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Result is Exception)
            {
                this.ShowError("Proses export GuestBook gagal!");
            }

            FormHelpers.CurrentMainForm.UpdateStatusInformation("Export GuestBook selesai", true);
        }

        public string ExportFileName { get; set; }

        private void btnExportToCSV_Click(object sender, EventArgs e)
        {
            if (!bgwExport.IsBusy && !bgwMain.IsBusy)
            {
                ExportFileName = string.Empty;
                btnSearch.PerformClick();
                exportDialog.FileName = "GuestBook_" + DateTime.Now.ToString("yyyyMMdd_HHmmssfff") + ".csv";
                exportDialog.ShowDialog(this);
            }
        }

        private void exportDialog_FileOk(object sender, CancelEventArgs e)
        {
            ExportFileName = exportDialog.FileName;

            MethodBase.GetCurrentMethod().Info("Exporting GuestBook data...");
            FormHelpers.CurrentMainForm.UpdateStatusInformation("Proses export data GuestBook...", false);
            bgwExport.RunWorkerAsync();
        }

    }
}
