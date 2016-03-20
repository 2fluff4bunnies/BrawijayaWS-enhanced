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
    public partial class HPPListControl : BaseAppUserControl, IHPPListView
    {
        private HPPListPresenter _presenter;

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

        public HPPHeaderViewModel AvailableHeader { get; set; }

        public List<HPPDetailViewModel> HPPDetailList
        {
            get
            {
                return gridHPP.DataSource as List<HPPDetailViewModel>;
            }
            set
            {
                if (InvokeRequired)
                {
                    this.Invoke(new MethodInvoker(delegate { gridHPP.DataSource = value; gvHPP.BestFitColumns(); }));
                }
                else
                {
                    gridHPP.DataSource = value;
                    gvHPP.BestFitColumns();
                }
            }
        }

        public HPPListControl(HPPListModel model)
        {
            InitializeComponent();
            _presenter = new HPPListPresenter(this, model);

            this.Load += HPPListControl_Load;
        }

        private void HPPListControl_Load(object sender, EventArgs e)
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
                MethodBase.GetCurrentMethod().Info("Fecthing HPP data...");
                AvailableHeader = null;
                FormHelpers.CurrentMainForm.UpdateStatusInformation("Memuat data HPP...", false);
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

            FormHelpers.CurrentMainForm.UpdateStatusInformation("Memuat data HPP selesai", true);
        }

        private void btnRecalculateHPP_Click(object sender, EventArgs e)
        {
            if(!bgwMain.IsBusy && !bgwRecalculate.IsBusy)
            {
                MethodBase.GetCurrentMethod().Info("Recalculate HPP data...");
                AvailableHeader = null;
                FormHelpers.CurrentMainForm.UpdateStatusInformation("Menghitung ulang HPP...", false);
                bgwMain.RunWorkerAsync();
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
                this.ShowError("Proses menghitung HPP gagal!");
            }

            btnSearch.PerformClick();
        }
    }
}
