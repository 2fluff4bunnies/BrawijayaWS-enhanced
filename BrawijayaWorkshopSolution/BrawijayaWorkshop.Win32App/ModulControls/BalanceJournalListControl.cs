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

        public decimal? ProfitLossDebitTemp { get; set; }

        public decimal? ProfitLossCreditTemp { get; set; }

        public decimal? ProfitLossDebitResult { get; set; }

        public decimal? ProfitLossCreditResult { get; set; }

        public decimal? LastDebitTemp { get; set; }

        public decimal? LastCreditTemp { get; set; }

        public decimal? LastDebitResult { get; set; }

        public decimal? LastCreditResult { get; set; }

        public BalanceJournalListControl(BalanceJournalListModel model)
        {
            InitializeComponent();
            _presenter = new BalanceJournalListPresenter(this, model);

            gvBalanceJournal.CustomSummaryCalculate += gvBalanceJournal_CustomSummaryCalculate;

            this.Load += BalanceJournalListControl_Load;
        }

        private void gvBalanceJournal_CustomSummaryCalculate(object sender, DevExpress.Data.CustomSummaryEventArgs e)
        {
            GridColumnSummaryItem item = e.Item as GridColumnSummaryItem;
            GridView view = sender as GridView;

            if (e.SummaryProcess == DevExpress.Data.CustomSummaryProcess.Finalize)
            {
                if (Equals("ProfitLossDebit", item.Tag))
                {
                    e.TotalValue = this.ProfitLossDebitTemp;
                }
                if (Equals("ProfitLossCredit", item.Tag))
                {
                    e.TotalValue = this.ProfitLossCreditTemp;
                }
                if (Equals("ProfitLossDebitResult", item.Tag))
                {
                    e.TotalValue = this.ProfitLossDebitResult;
                }
                if (Equals("ProfitLossCreditResult", item.Tag))
                {
                    e.TotalValue = this.ProfitLossCreditResult;
                }
                if (Equals("LastDebit", item.Tag))
                {
                    e.TotalValue = this.LastDebitTemp;
                }
                if (Equals("LastCredit", item.Tag))
                {
                    e.TotalValue = this.LastCreditTemp;
                }
                if (Equals("LastDebitResult", item.Tag))
                {
                    e.TotalValue = this.LastDebitResult;
                }
                if (Equals("LastCreditResult", item.Tag))
                {
                    e.TotalValue = this.LastCreditResult;
                }
            }
            //if (Equals("Count", item.Tag))
            //{
            //    if (e.SummaryProcess == DevExpress.Data.CustomSummaryProcess.Start)
            //        validRowCount = 0;
            //    if (e.SummaryProcess == DevExpress.Data.CustomSummaryProcess.Calculate)
            //    {
            //        if (!Convert.ToBoolean(view.GetRowCellValue(e.RowHandle, "Discontinued"))) validRowCount++;
            //    }
            //    if (e.SummaryProcess == DevExpress.Data.CustomSummaryProcess.Finalize)
            //        e.TotalValue = validRowCount;
            //}
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
    }
}
