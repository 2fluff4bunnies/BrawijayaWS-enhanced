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
    public partial class MechanicListControl : BaseAppUserControl, IMechanicListView
    {
        public zkemkeeper.CZKEMClass axCZKEM1 = new zkemkeeper.CZKEMClass();
        private MechanicListPresenter _presenter;
        private MechanicViewModel _selectedMechanic;

        protected override string ModulName
        {
            get
            {
                return DbConstant.MODUL_MECHANIC;
            }
        }

        public string FingerprintIP { get; set; }

        public string FingerpringPort { get; set; }

        public MechanicListControl(MechanicListModel model)
        {
            InitializeComponent();
            _presenter = new MechanicListPresenter(this, model);

            gvMechanic.PopupMenuShowing += gvMechanic_PopupMenuShowing;
            gvMechanic.FocusedRowChanged += gvMechanic_FocusedRowChanged;

            // init editor control accessibility
            btnNewMechanic.Enabled = AllowInsert;
            cmsEditData.Enabled = AllowEdit;
            cmsDeleteData.Enabled = AllowDelete;

            this.Load += MechanicListControl_Load;
        }

        private void MechanicListControl_Load(object sender, EventArgs e)
        {
            if (!bgwFingerprint.IsBusy)
            {
                Cursor = Cursors.WaitCursor;
                FormHelpers.CurrentMainForm.UpdateStatusInformation("Cek koneksi ke fingerprint", false);
                bgwFingerprint.RunWorkerAsync();
            }
        }

        private void gvMechanic_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            this.SelectedMechanic = gvMechanic.GetFocusedRow() as MechanicViewModel;
        }

        private void gvMechanic_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            GridView view = (GridView)sender;
            GridHitInfo hitInfo = view.CalcHitInfo(e.Point);
            if (hitInfo.InRow)
            {
                view.FocusedRowHandle = hitInfo.RowHandle;
                cmsEditor.Show(view.GridControl, e.Point);
            }
        }

        public string MechanicNameFilter
        {
            get
            {
                return txtFilterMechanicName.Text;
            }
            set
            {
                txtFilterMechanicName.Text = value;
            }
        }

        public List<MechanicViewModel> MechanicListData
        {
            get
            {
                return gridMechanic.DataSource as List<MechanicViewModel>;
            }
            set
            {
                if (InvokeRequired)
                {
                    this.Invoke(new MethodInvoker(delegate { gridMechanic.DataSource = value; }));
                }
                else
                {
                    gridMechanic.DataSource = value;
                }
            }
        }

        public MechanicViewModel SelectedMechanic
        {
            get
            {
                return _selectedMechanic;
            }
            set
            {
                _selectedMechanic = value;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!bgwMain.IsBusy)
            {
                MethodBase.GetCurrentMethod().Info("Fecthing Mechanic data...");
                _selectedMechanic = null;
                FormHelpers.CurrentMainForm.UpdateStatusInformation("Memuat data Mechanic...", false);
                bgwMain.RunWorkerAsync();
            }
        }

        private void txtFilterMechanicName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch.PerformClick();
            }
        }

        private void btnNewMechanic_Click(object sender, EventArgs e)
        {
            MechanicEditorForm editor = Bootstrapper.Resolve<MechanicEditorForm>();
            editor.ShowDialog(this);

            btnSearch.PerformClick();
        }

        private void cmsEditData_Click(object sender, EventArgs e)
        {
            if (_selectedMechanic != null)
            {
                MechanicEditorForm editor = Bootstrapper.Resolve<MechanicEditorForm>();
                editor.SelectedMechanic = _selectedMechanic;
                editor.ShowDialog(this);

                btnSearch.PerformClick();
            }
        }

        private void cmsDeleteData_Click(object sender, EventArgs e)
        {
            if (SelectedMechanic == null) return;

            if (this.ShowConfirmation("Apakah anda yakin ingin Mechanic: '" + SelectedMechanic.Name + "'?") == DialogResult.Yes)
            {
                try
                {
                    MethodBase.GetCurrentMethod().Info("Deleting Mechanic: " + SelectedMechanic.Name);

                    _presenter.DeleteMechanic();
                    if(axCZKEM1.SSR_DeleteEnrollData(1, SelectedMechanic.Code, 0))
                    {
                        axCZKEM1.RefreshData(1);
                        if(axCZKEM1.SSR_DelUserTmpExt(1, SelectedMechanic.Code, 1))
                        {
                            axCZKEM1.RefreshData(1);
                        }
                    }

                    btnSearch.PerformClick(); // refresh data
                }
                catch (Exception ex)
                {
                    MethodBase.GetCurrentMethod().Fatal("An error occured while trying to delete Mechanic: '" + SelectedMechanic.Name + "'", ex);
                    this.ShowError("Proses hapus data Mechanic: '" + SelectedMechanic.Name + "' gagal!");
                }
            }
        }

        private void bgwMain_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                _presenter.LoadMechanic();
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
            if (MechanicListData.Count > 0)
            {
                gvMechanic.FocusedRowHandle = 0;
                _selectedMechanic = gvMechanic.GetRow(0) as MechanicViewModel;
            }
            FormHelpers.CurrentMainForm.UpdateStatusInformation("Memuat data Mechanic selesai", true);
        }

        private void bgwFingerprint_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                _presenter.LoadMechanic();
                bool isConnected = axCZKEM1.Connect_Net(FingerprintIP, Convert.ToInt32(FingerpringPort));
                e.Result = isConnected;
            }
            catch (Exception ex)
            {
                MethodBase.GetCurrentMethod().Fatal("An error occured while trying to connect to fingerprint device", ex);
                e.Result = ex;
            }
        }

        private void bgwFingerprint_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Cursor = Cursors.Default;
            if (e.Result is Exception)
            {
                this.ShowError("Koneksi ke fingerprint gagal!");
            }
            else
            {
                if (e.Result.AsBoolean())
                {
                    axCZKEM1.RegEvent(1, 65535);
                    FormHelpers.CurrentMainForm.UpdateStatusInformation("Koneksi ke fingerprint berhasil", true);
                }
                else
                {
                    int errorCode = 0;
                    axCZKEM1.GetLastError(ref errorCode);
                    this.ShowError("Koneksi ke fingerprint gagal! Kode Error=" + errorCode);
                    FormHelpers.CurrentMainForm.UpdateStatusInformation("Tidak ada koneksi ke fingerprint", true);
                }
            }
        }
    }
}
