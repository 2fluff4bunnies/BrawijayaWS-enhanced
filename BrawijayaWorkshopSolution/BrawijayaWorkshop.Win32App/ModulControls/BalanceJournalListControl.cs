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
                MethodBase.GetCurrentMethod().Info("Fecthing BalanceJournal data...");
                AvailableBalanceJournal = null;
                FormHelpers.CurrentMainForm.UpdateStatusInformation("Memuat data BalanceJournal...", false);
                bgwMain.RunWorkerAsync();
            }
        }

        private void bgwMain_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void bgwMain_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }

        private void btnRecalculateBalanceJournal_Click(object sender, EventArgs e)
        {
            if (!bgwMain.IsBusy && !bgwRecalculate.IsBusy)
            {
                MethodBase.GetCurrentMethod().Info("Recalculate BalanceJournal data...");
                AvailableBalanceJournal = null;
                FormHelpers.CurrentMainForm.UpdateStatusInformation("Menghitung ulang BalanceJournal...", false);
                bgwMain.RunWorkerAsync();
            }
        }

        private void bgwRecalculate_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void bgwRecalculate_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }
    }
}
