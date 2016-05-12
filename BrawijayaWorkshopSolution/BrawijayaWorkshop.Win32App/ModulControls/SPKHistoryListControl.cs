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
    public partial class SPKHistoryListControl : BaseAppUserControl, ISPKHistoryListView
    {
        protected override string ModulName
        {
            get
            {
                return DbConstant.MODUL_SPK;
            }
        }

        private SPKHistoryListPresenter _presenter;

        public SPKHistoryListControl(SPKHistoryListModel model)
        {
            InitializeComponent();

            _presenter = new SPKHistoryListPresenter(this, model);

            this.Load += SPKHistoryListControl_Load;
            gvSPK.FocusedRowChanged += gvSPK_FocusedRowChanged;
            gvSPK.PopupMenuShowing += gvSPK_PopupMenuShowing;

            this.CategoryFilter = 0;
            this.ContractWorkStatusFilter = -1;
        }

        #region Properties

        public SPKViewModel SelectedSPK { get; set; }

        public int CategoryFilter
        {
            get
            {
                return lookUpCategory.EditValue.AsInteger();
            }
            set
            {
                lookUpCategory.EditValue = value;
            }
        }

        public string LicenseNumberFilter
        {
            get
            {
                return txtLicenseNumber.EditValue.ToString();
            }
            set
            {
                txtLicenseNumber.EditValue = value;
            }
        }

        public int ContractWorkStatusFilter
        {
            get
            {
                return lookUpContractWorkStatus.EditValue.AsInteger();
            }
            set
            {
                lookUpContractWorkStatus.EditValue = value;
            }
        }

        public int CustomerFIlter
        {
            get
            {
                return lookUpCustomer.EditValue.AsInteger();
            }
            set
            {
                lookUpCustomer.EditValue = value;
            }
        }

        public DateTime? DateFilterFrom
        {
            get
            {
                return txtDateFilterFrom.EditValue.AsDateTime();
            }
            set
            {
                txtDateFilterFrom.EditValue = value;
            }
        }

        public DateTime? DateFilterTo
        {
            get
            {
                return txtDateFilterTo.EditValue.AsDateTime();
            }
            set
            {
                txtDateFilterTo.EditValue = value;
            }
        }

        public string CodeFilter
        {
            get
            {
                return txtCode.EditValue.ToString();
            }
            set
            {
                txtCode.EditValue = value;
            }
        }

        public List<ReferenceViewModel> CategoryDropdownList
        {
            get
            {
                return lookUpCategory.Properties.DataSource as List<ReferenceViewModel>;
            }
            set
            {
                lookUpCategory.Properties.DataSource = value;
            }
        }

        public List<SPKViewModel> SPKListData
        {
            get
            {
                return gcSPK.DataSource as List<SPKViewModel>;
            }
            set
            {
                if (InvokeRequired)
                {
                    this.Invoke(new MethodInvoker(delegate { gcSPK.DataSource = value; gvSPK.BestFitColumns(); }));
                }
                else
                {
                    gcSPK.DataSource = value;
                    gvSPK.BestFitColumns();
                }
            }
        }

        public List<SPKStatusItem> ContractWorkStatusDropdownList
        {
            get
            {
                return lookUpContractWorkStatus.Properties.DataSource as List<SPKStatusItem>;
            }
            set
            {
                lookUpContractWorkStatus.Properties.DataSource = value;
            }
        }

        public List<CustomerViewModel> CustomerDropdownList
        {
            get
            {
                return lookUpCustomer.Properties.DataSource as List<CustomerViewModel>;
            }
            set
            {
                lookUpCustomer.Properties.DataSource = value;
            }
        }
        #endregion

        #region Event Handlers
        void SPKHistoryListControl_Load(object sender, EventArgs e)
        {
            _presenter.InitData();
            btnSearch.PerformClick();
        }

        void gvSPK_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            GridView view = (GridView)sender;
            GridHitInfo hitInfo = view.CalcHitInfo(e.Point);
            if (hitInfo.InRow)
            {
                view.FocusedRowHandle = hitInfo.RowHandle;
                cmsEditor.Show(view.GridControl, e.Point);
                this.SelectedSPK = gvSPK.GetRow(view.FocusedRowHandle) as SPKViewModel;
            }
        }

        void gvSPK_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            this.SelectedSPK = gvSPK.GetRow(e.FocusedRowHandle) as SPKViewModel;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            RefreshDataView();
        }

        private void bgwMain_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                _presenter.LoadSPK();
            }
            catch (Exception ex)
            {
                MethodBase.GetCurrentMethod().Fatal("An error occured while trying to execute _presenter.LoadSPK()", ex);
                e.Result = ex;
            }
        }

        private void bgwMain_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Result is Exception)
            {
                this.ShowError("Proses memuat data gagal!");
            }

            FormHelpers.CurrentMainForm.UpdateStatusInformation("Memuat data SPK selesai", true);
        }
        #endregion

        #region Methods
        public override void RefreshDataView()
        {
            if (!bgwMain.IsBusy)
            {
                MethodBase.GetCurrentMethod().Info("Fecthing SPK data...");
                SelectedSPK = null;
                FormHelpers.CurrentMainForm.UpdateStatusInformation("Memuat data SPK...", false);
                bgwMain.RunWorkerAsync();
            }
        }
        #endregion
    }
}
