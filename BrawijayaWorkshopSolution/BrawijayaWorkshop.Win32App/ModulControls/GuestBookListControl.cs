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
        private GuestBookViewModel _selectedGuestBook;

        protected override string ModulName
        {
            get
            {
                return DbConstant.MODUL_VEHICLE;
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
            cmsViewVehicle.Enabled = AllowEdit;
            cmsDeleteData.Enabled = AllowDelete;

            this.Load += GuestBookListControl_Load;

            InitializeComponent();
        }

        void GuestBookListControl_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.dtpCreatedDate.Text))
            {
                this.dtpCreatedDate.Text = DateTime.Now.ToShortDateString();
            }
            btnSearch.PerformClick();
        }

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

        #region Properties
        public GuestBookViewModel SelectedGuestBook
        {
            get
            {
                return _selectedGuestBook;
            }
            set
            {
                _selectedGuestBook = value;
            }
        }

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

        public DateTime CreatedDate
        {
            get
            {
                return dtpCreatedDate.Text.AsDateTime();
            }
            set
            {
                dtpCreatedDate.Text = value.ToString();
            }
        }
        #endregion

        private void btnSearch_Click(object sender, EventArgs e)
        {
            RefreshDataView();
        }

        private void cmsViewVehicle_Click(object sender, EventArgs e)
        {
            if (_selectedGuestBook != null)
            {
                VehicleEditorForm editor = Bootstrapper.Resolve<VehicleEditorForm>();
                editor.SelectedVehicle = SelectedGuestBook.Vehicle;
                editor.ShowDialog(this);

                btnSearch.PerformClick();
            }
        }

        private void cmsDeleteData_Click(object sender, EventArgs e)
        {
            if (SelectedGuestBook == null) return;

            if (this.ShowConfirmation("Apakah anda yakin ingin menghapus dafar hadir kendaraan dengan nomor polisi : '" + SelectedGuestBook.Vehicle.ActiveLicenseNumber + "'?") == DialogResult.Yes)
            {
                try
                {
                    MethodBase.GetCurrentMethod().Info("Mengapus daftar hadir dengan nomor polisi : " + SelectedGuestBook.Vehicle.ActiveLicenseNumber);

                    _presenter.DeleteGuestBook();

                    btnSearch.PerformClick(); // refresh data
                }
                catch (Exception ex)
                {
                    MethodBase.GetCurrentMethod().Fatal("An error occured while trying to delete guestbook with license number: '" + SelectedGuestBook.Vehicle.ActiveLicenseNumber + "'", ex);
                    this.ShowError("Proses hapus daftar dengan nomor polisi : '" + SelectedGuestBook.Vehicle.ActiveLicenseNumber + "' gagal!");
                }
            }
        }

        private void cmsEditData_Click(object sender, EventArgs e)
        {
            if (_selectedGuestBook != null)
            {
                GuestBookEditorForm editor = Bootstrapper.Resolve<GuestBookEditorForm>();
                editor.SelectedGuestBook = this.SelectedGuestBook;
                editor.ShowDialog(this);

                btnSearch.PerformClick();
            }
        }

        public override void RefreshDataView()
        {
            if (!bgwMain.IsBusy)
            {
                MethodBase.GetCurrentMethod().Info("Fecthing guest book data...");
                _selectedGuestBook = null;
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
                SelectedGuestBook = gvGuestBook.GetRow(0) as GuestBookViewModel;
            }

            FormHelpers.CurrentMainForm.UpdateStatusInformation("Memuat daftar hadir selesai", true);
        }

        private void btnNewGuestBook_Click(object sender, EventArgs e)
        {
            GuestBookEditorForm editor = Bootstrapper.Resolve<GuestBookEditorForm>();
            editor.ShowDialog(this);

            btnSearch.PerformClick();
        }


    }
}
