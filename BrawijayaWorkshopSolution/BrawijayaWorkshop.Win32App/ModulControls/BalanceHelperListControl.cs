using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.Presenter;
using BrawijayaWorkshop.SharedObject.ViewModels;
using BrawijayaWorkshop.Utils;
using BrawijayaWorkshop.View;
using BrawijayaWorkshop.Win32App.PrintItems;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Windows.Forms;

namespace BrawijayaWorkshop.Win32App.ModulControls
{
    public partial class BalanceHelperListControl : BaseAppUserControl, IBalanceHelperListView
    {
        private const string ViewCaptionFormat = "Buku Pembantu - {0}";
        private BalanceHelperListPresenter _presenter;

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

        public int SelectedJournal
        {
            get
            {
                return lookUpFilterJournal.EditValue.AsInteger();
            }
            set
            {
                lookUpFilterJournal.EditValue = value;
            }
        }

        public List<JournalMasterViewModel> ListJournal
        {
            get
            {
                return lookUpFilterJournal.Properties.DataSource as List<JournalMasterViewModel>;
            }
            set
            {
                lookUpFilterJournal.Properties.DataSource = value;
            }
        }

        public List<BalanceHelperItemViewModel> ListHelper
        {
            get
            {
                return gridBalanceHelper.DataSource as List<BalanceHelperItemViewModel>;
            }
            set
            {
                if (InvokeRequired)
                {
                    this.Invoke(new MethodInvoker(delegate { gridBalanceHelper.DataSource = value; gvBalanceHelper.BestFitColumns(); }));
                }
                else
                {
                    gridBalanceHelper.DataSource = value;
                    gvBalanceHelper.BestFitColumns();
                }
            }
        }

        public BalanceHelperListControl(BalanceHelperListModel model)
        {
            InitializeComponent();
            _presenter = new BalanceHelperListPresenter(this, model);

            lookUpFilterJournal.EditValueChanged += lookUpFilterJournal_EditValueChanged;

            this.Load += BalanceHelperListControl_Load;
        }

        private void lookUpFilterJournal_EditValueChanged(object sender, EventArgs e)
        {
            gvBalanceHelper.ViewCaption = "-";
            JournalMasterViewModel selectedJournal = lookUpFilterJournal.GetSelectedDataRow() as JournalMasterViewModel;
            if(selectedJournal != null)
            {
                gvBalanceHelper.ViewCaption = string.Format(ViewCaptionFormat, selectedJournal.Name);
            }
        }

        private void BalanceHelperListControl_Load(object sender, EventArgs e)
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
            if(!bgwMain.IsBusy)
            {
                MethodBase.GetCurrentMethod().Info("Fecthing balance helper data...");
                FormHelpers.CurrentMainForm.UpdateStatusInformation("Memuat data buku pembantu...", false);
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

            FormHelpers.CurrentMainForm.UpdateStatusInformation("Memuat data buku pembantu selesai", true);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            BalanceHelperPrintItem report = new BalanceHelperPrintItem(SelectedYear, SelectedMonth, (lookUpFilterJournal.GetSelectedDataRow() as JournalMasterViewModel).Name);
            report.DataSource = ListHelper;
            report.FillDataSource();

            using (ReportPrintTool printTool = new ReportPrintTool(report))
            {
                // Invoke the Print dialog.
                printTool.PrintDialog();
            }
        }
    }
}
