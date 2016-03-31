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
    public partial class BalanceSheetControl : BaseAppUserControl, IBalanceSheetView
    {
        private BalanceSheetPresenter _presenter;

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

        public List<BalanceSheetDetailViewModel> ActivaList
        {
            get
            {
                return gridActiva.DataSource as List<BalanceSheetDetailViewModel>;
            }
            set
            {
                if (InvokeRequired)
                {
                    this.Invoke(new MethodInvoker(delegate { gridActiva.DataSource = value; gvActiva.BestFitColumns(); }));
                }
                else
                {
                    gridActiva.DataSource = value;
                    gvActiva.BestFitColumns();
                }
            }
        }

        public List<BalanceSheetDetailViewModel> PassivaList
        {
            get
            {
                return gridPassiva.DataSource as List<BalanceSheetDetailViewModel>;
            }
            set
            {
                if (InvokeRequired)
                {
                    this.Invoke(new MethodInvoker(delegate { gridPassiva.DataSource = value; gvPassiva.BestFitColumns(); }));
                }
                else
                {
                    gridPassiva.DataSource = value;
                    gvPassiva.BestFitColumns();
                }
            }
        }

        public BalanceSheetControl(BalanceSheetModel model)
        {
            InitializeComponent();
            _presenter = new BalanceSheetPresenter(this, model);

            this.Load += BalanceSheetControl_Load;
        }

        private void BalanceSheetControl_Load(object sender, EventArgs e)
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
