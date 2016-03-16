using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.Presenter;
using BrawijayaWorkshop.SharedObject.ViewModels;
using BrawijayaWorkshop.Utils;
using BrawijayaWorkshop.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Windows.Forms;

namespace BrawijayaWorkshop.Win32App.ModulControls
{
    public partial class FirstBalanceListControl : BaseAppUserControl, IFirstBalanceListView
    {
        private FirstBalanceListPresenter _presenter;

        protected override string ModulName
        {
            get
            {
                return DbConstant.MODUL_ACCOUNTING;
            }
        }

        public FirstBalanceListControl(FirstBalanceListModel model)
        {
            InitializeComponent();

            _presenter = new FirstBalanceListPresenter(this, model);
            txtMonthYear.Text = "- / -";

            btnNewData.Enabled = AllowInsert;
            btnEditData.Enabled = AllowEdit;
            btnDeleteData.Enabled = AllowDelete;

            this.Load += FirstBalanceListControl_Load;
        }

        private void FirstBalanceListControl_Load(object sender, EventArgs e)
        {
            RefreshDataView();
        }

        public BalanceJournalViewModel SelectedFirstBalanceJournal { get; set; }

        public List<BalanceJournalDetailViewModel> FirstBalanceJournalDetailList
        {
            get
            {
                return gridFirstBalance.DataSource as List<BalanceJournalDetailViewModel>;
            }
            set
            {
                if (InvokeRequired)
                {
                    this.Invoke(new MethodInvoker(delegate { gridFirstBalance.DataSource = value; gvFirstBalance.BestFitColumns(); }));
                }
                else
                {
                    gridFirstBalance.DataSource = value;
                    gvFirstBalance.BestFitColumns();
                }
            }
        }

        public override void RefreshDataView()
        {
            if (!bgwMain.IsBusy)
            {
                MethodBase.GetCurrentMethod().Info("Fecthing first balance data...");
                SelectedFirstBalanceJournal = null;
                FormHelpers.CurrentMainForm.UpdateStatusInformation("Memuat data saldo awal...", false);
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

            if(SelectedFirstBalanceJournal != null)
            {
                txtMonthYear.Text = string.Format("{0} / {1}", SelectedFirstBalanceJournal.Month, SelectedFirstBalanceJournal.Year);
                btnNewData.Enabled = false;
                btnEditData.Enabled = AllowEdit && true;
                btnDeleteData.Enabled = AllowDelete && true;
            }
            else
            {
                btnNewData.Enabled = AllowInsert && true;
                btnEditData.Enabled = false;
                btnDeleteData.Enabled = false;
            }

            FormHelpers.CurrentMainForm.UpdateStatusInformation("Memuat data saldo awal selesai", true);
        }

        private void btnNewData_Click(object sender, EventArgs e)
        {
            if (bgwMain.IsBusy) return;
        }

        private void btnEditData_Click(object sender, EventArgs e)
        {
            if (bgwMain.IsBusy) return;
        }

        private void btnDeleteData_Click(object sender, EventArgs e)
        {
            if (SelectedFirstBalanceJournal == null) return;

            DateTime balanceDate = new DateTime(SelectedFirstBalanceJournal.Year, SelectedFirstBalanceJournal.Month, 1);
            if (this.ShowConfirmation("Apakah anda yakin ingin menghapus saldo awal bulan / tahun: " + balanceDate.ToString("MMMM / yyyy") + "?") == DialogResult.Yes)
            {
                try
                {
                    MethodBase.GetCurrentMethod().Info("Deleting first balance: " + balanceDate.ToString("MMMM / yyyy"));

                    _presenter.DeleteSelectedBalance();

                    RefreshDataView();
                }
                catch (Exception ex)
                {
                    MethodBase.GetCurrentMethod().Fatal("An error occured while trying to delete first balance: '" + balanceDate.ToString("MMMM / yyyy") + "'", ex);
                    this.ShowError("Proses hapus data saldo awal bulan / tahun: '" + balanceDate.ToString("MMMM / yyyy") + "' gagal!");
                }
            }
        }
    }
}
