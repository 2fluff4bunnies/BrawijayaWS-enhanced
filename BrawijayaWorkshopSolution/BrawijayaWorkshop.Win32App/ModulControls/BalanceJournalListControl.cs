using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.Presenter;
using BrawijayaWorkshop.SharedObject.ViewModels;
using BrawijayaWorkshop.Utils;
using BrawijayaWorkshop.View;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Windows.Forms;

namespace BrawijayaWorkshop.Win32App.ModulControls
{
    public partial class BalanceJournalListControl : BaseAppUserControl, IBalanceJournalListView
    {
        private BalanceJournalListPresenter _presenter;

        protected override string ModulName
        {
            get
            {
                return DbConstant.MODUL_ACCOUNTING;
            }
        }

        public int SelectedMonth
        {
            get
            {
                return lookupMonth.EditValue.AsInteger();
            }
            set
            {
                lookupMonth.EditValue = value;
            }
        }

        public int SelectedYear
        {
            get
            {
                return lookupYear.EditValue.AsInteger();
            }
            set
            {
                lookupYear.EditValue = value;
            }
        }

        public Dictionary<int, string> ListMonth
        {
            get
            {
                return lookupMonth.Properties.DataSource as Dictionary<int, string>;
            }
            set
            {
                lookupMonth.Properties.DataSource = value;
            }
        }

        public List<int> ListYear
        {
            get
            {
                return lookupYear.Properties.DataSource as List<int>;
            }
            set
            {
                lookupYear.Properties.DataSource = value;
            }
        }

        public BalanceJournalViewModel AvailableBalanceJournal { get; set; }

        public List<BalanceJournalDetailViewModel> BalanceJournalDetailList
        {
            get
            {
                return gridBalanceJournal.DataSource as List<BalanceJournalDetailViewModel>;
            }
            set
            {
                if (InvokeRequired)
                {
                    this.Invoke(new MethodInvoker(delegate { gridBalanceJournal.DataSource = value; gvBalanceJournal.BestFitColumns(); }));
                }
                else
                {
                    gridBalanceJournal.DataSource = value;
                    gvBalanceJournal.BestFitColumns();
                }
            }
        }

        public BalanceJournalListControl(BalanceJournalListModel model)
        {
            InitializeComponent();
            _presenter = new BalanceJournalListPresenter(this, model);

            this.Load += BalanceJournalListControl_Load;
        }

        private void BalanceJournalListControl_Load(object sender, EventArgs e)
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
                MethodBase.GetCurrentMethod().Info("Fecthing balance journal data...");
                AvailableBalanceJournal = null;
                FormHelpers.CurrentMainForm.UpdateStatusInformation("Memuat data neraca...", false);
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

            FormHelpers.CurrentMainForm.UpdateStatusInformation("Memuat data neraca selesai", true);
        }

        private void btnRecalculateBalanceJournal_Click(object sender, EventArgs e)
        {
            if (!bgwMain.IsBusy && !bgwRecalculate.IsBusy)
            {
                btnRecalculateBalanceJournal.Enabled = false;
                MethodBase.GetCurrentMethod().Info("Recalculate balance journal data...");
                AvailableBalanceJournal = null;
                FormHelpers.CurrentMainForm.UpdateStatusInformation("Menghitung ulang neraca...", false);
                bgwRecalculate.RunWorkerAsync();
            }
        }

        private void bgwRecalculate_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                _presenter.Recalculate();
            }
            catch (Exception ex)
            {
                MethodBase.GetCurrentMethod().Fatal("An error occured while trying to execute _presenter.Recalculate()", ex);
                e.Result = ex;
            }
        }

        private void bgwRecalculate_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Result is Exception)
            {
                this.ShowError("Proses menghitung neraca gagal!");
            }

            btnRecalculateBalanceJournal.Enabled = true;

            btnSearch.PerformClick();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            // Check whether the GridControl can be printed.
            if (!gridBalanceJournal.IsPrintingAvailable)
            {
                MessageBox.Show("Fungsi print tidak tersedia", "Error");
                return;
            }

            // Print.
            gridBalanceJournal.PrintDialog();
        }
    }
}
