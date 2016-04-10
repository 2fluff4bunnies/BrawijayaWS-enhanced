using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.Presenter;
using BrawijayaWorkshop.SharedObject.ViewModels;
using BrawijayaWorkshop.Utils;
using BrawijayaWorkshop.View;
using BrawijayaWorkshop.Win32App.ModulForms;
using BrawijayaWorkshop.Win32App.PrintItems;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Windows.Forms;

namespace BrawijayaWorkshop.Win32App.ModulControls
{
    public partial class SPKScheduleListControl : BaseAppUserControl, ISPKScheduleListView
    {
        private SPKScheduleListPresenter _presenter;

        protected override string ModulName
        {
            get
            {
                return DbConstant.MODUL_SPK_SCHEDULE;
            }
        }

        public SPKScheduleListControl(SPKScheduleListModel model)
        {
            InitializeComponent();

            _presenter = new SPKScheduleListPresenter(this, model);

            btnNewSPKSchedule.Enabled = AllowInsert;
            cmsEditData.Enabled = AllowEdit;
            cmsDeleteData.Enabled = AllowDelete;

            gvSPKSchedule.FocusedRowChanged += gvSPKSchedule_FocusedRowChanged;
            gvSPKSchedule.PopupMenuShowing += gvSPKSchedule_PopupMenuShowing;
            this.Load += SPKScheduleListControl_Load;
        }

        #region Properties
        public SPKScheduleViewModel SelectedSPKSchedule { get; set; }

        public int SPKId
        {
            get
            {
                return lookUpSPKVehicle.EditValue.AsInteger();
            }
            set
            {
                lookUpSPKVehicle.EditValue = value;
            }
        }

        public List<FilterSPKVechile> SPKVehicleList
        {
            get
            {
                return lookUpSPKVehicle.Properties.DataSource as List<FilterSPKVechile>;
            }
            set
            {
                lookUpSPKVehicle.Properties.DataSource = value;
            }
        }

        public int MechanicId
        {
            get
            {
                return lookUpMechanic.EditValue.AsInteger();
            }
            set
            {
                lookUpMechanic.EditValue = value;
            }
        }

        public List<MechanicViewModel> MechanicList
        {
            get
            {
                return lookUpMechanic.Properties.DataSource as List<MechanicViewModel>;
            }
            set
            {
                lookUpMechanic.Properties.DataSource = value;
            }
        }

        public DateTime CreatedDateFilter
        {
            get
            {
                return dteCreatedDate.Text.AsDateTime();
            }
            set
            {
                dteCreatedDate.Text = value.ToShortDateString();
            }
        }

        public List<SPKScheduleViewModel> SPKScheduleListData
        {
            get
            {
                return gcSPKSchedule.DataSource as List<SPKScheduleViewModel>;
            }
            set
            {
                if (InvokeRequired)
                {
                    this.Invoke(new MethodInvoker(delegate { gcSPKSchedule.DataSource = value; gvSPKSchedule.BestFitColumns(); }));
                }
                else
                {
                    gcSPKSchedule.DataSource = value;
                    gvSPKSchedule.BestFitColumns();
                }
            }
        }
        #endregion

        void gvSPKSchedule_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            GridView view = (GridView)sender;
            GridHitInfo hitInfo = view.CalcHitInfo(e.Point);
            if (hitInfo.InRow)
            {
                view.FocusedRowHandle = hitInfo.RowHandle;
                cmsEditor.Show(view.GridControl, e.Point);
                this.SelectedSPKSchedule = gvSPKSchedule.GetRow(view.FocusedRowHandle) as SPKScheduleViewModel;
            }
        }

        void gvSPKSchedule_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            this.SelectedSPKSchedule = gvSPKSchedule.GetFocusedRow() as SPKScheduleViewModel;
        }

        void SPKScheduleListControl_Load(object sender, EventArgs e)
        {
            _presenter.InitData();
            btnSearch.PerformClick();
        }

        public override void RefreshDataView()
        {
            if (!bgwMain.IsBusy)
            {
                MethodBase.GetCurrentMethod().Info("Fecthing SPKSchedule data...");
                this.SelectedSPKSchedule = null;
                FormHelpers.CurrentMainForm.UpdateStatusInformation("Memuat data jadwal spk...", false);
                bgwMain.RunWorkerAsync();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            RefreshDataView();
        }

        private void btnNewSPK_Click(object sender, EventArgs e)
        {
            SPKScheduleEditorForm editor = Bootstrapper.Resolve<SPKScheduleEditorForm>();
            editor.ShowDialog(this);

            btnSearch.PerformClick();
        }

        private void cmsEditData_Click(object sender, EventArgs e)
        {
            SPKScheduleEditorForm editor = Bootstrapper.Resolve<SPKScheduleEditorForm>();
            editor.SelectedSPKSchedule = this.SelectedSPKSchedule;
            editor.ShowDialog(this);

            btnSearch.PerformClick();
        }

        private void cmsDeleteData_Click(object sender, EventArgs e)
        {
            if (this.SelectedSPKSchedule== null) return;

            if (this.ShowConfirmation("Apakah anda yakin ingin menghapus jadwal spk untuk kendaraan dengan nomor polisi : '" + SelectedSPKSchedule.SPK.Vehicle.ActiveLicenseNumber + "'?") == DialogResult.Yes)
            {
                try
                {
                    MethodBase.GetCurrentMethod().Info("Mengapus jadwal spk untuk kendaraan dengan nomor polisi : " + SelectedSPKSchedule.SPK.Vehicle.ActiveLicenseNumber);

                    _presenter.DeleteSPKSchedule();

                    btnSearch.PerformClick(); // refresh data
                }
                catch (Exception ex)
                {
                    MethodBase.GetCurrentMethod().Fatal("An error occured while trying to delete SPKSchedule with license number: '" + SelectedSPKSchedule.SPK.Vehicle.ActiveLicenseNumber + "'", ex);
                    this.ShowError("Proses hapus data jadwal spk untuk kendaraan dengan nomor polisi : '" + SelectedSPKSchedule.SPK.Vehicle.ActiveLicenseNumber + "' gagal!");
                }
            }
        }

        private void bgwMain_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                _presenter.LoadSPKSchedule();
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

            if (gvSPKSchedule.RowCount > 0)
            {
                this.SelectedSPKSchedule = gvSPKSchedule.GetRow(0) as SPKScheduleViewModel;
            }

            FormHelpers.CurrentMainForm.UpdateStatusInformation("Memuat data jadwal spk untuk kendaraan selesai", true);
        }


    }
}
