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

namespace BrawijayaWorkshop.Win32App.ModulForms
{
    public partial class WheelDetailListForm : BaseDefaultForm, IWheelDetailListView
    {
        private WheelDetailListPresenter _presenter;

        public WheelDetailListForm()
        {
            InitializeComponent();

            this.Load += WheelDetailEditorForm_Load;
        }

        void WheelDetailEditorForm_Load(object sender, EventArgs e)
        {
            _presenter.InitFormData();
        }

        private void lookupStatus_EditValueChanged(object sender, EventArgs e)
        {
            SelectedStatus = lookupStatus.EditValue.AsInteger();
            RefreshDataView();
        }

        #region Properties
        public WheelViewModel SelectedWheel { get; set; }
        public int PurchasingDetailID { get; set; }

        public int SelectedStatus
        {
            get
            {
                return lookupStatus.EditValue.AsInteger();
            }
            set
            {
                lookupStatus.EditValue = value;
            }
        }

        public List<WheelDetailStatusItem> ListStatus
        {
            get
            {
                return lookupStatus.Properties.DataSource as List<WheelDetailStatusItem>;
            }
            set
            {
                lookupStatus.Properties.DataSource = value;
            }
        }

        public List<WheelDetailViewModel> WheelDetailListData
        {
            get
            {
                return gridWheelDetail.DataSource as List<WheelDetailViewModel>;
            }
            set
            {
                if (InvokeRequired)
                {
                    this.Invoke(new MethodInvoker(delegate { gridWheelDetail.DataSource = value; gvWheelDetail.BestFitColumns(); }));
                }
                else
                {
                    gridWheelDetail.DataSource = value;
                    gvWheelDetail.BestFitColumns();
                }
            }
        } 
        #endregion

        public override void RefreshDataView()
        {
            if (!bgwMain.IsBusy)
            {
                MethodBase.GetCurrentMethod().Info("Fecthing wheel detail data...");
                FormHelpers.CurrentMainForm.UpdateStatusInformation("Memuat data ban detail...", false);
                bgwMain.RunWorkerAsync();
            }
        }

        private void bgwMain_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                _presenter.LoadDetailList();
            }
            catch (Exception ex)
            {
                MethodBase.GetCurrentMethod().Fatal("An error occured while trying to execute _presenter.LoadDetailList()", ex);
                e.Result = ex;
            }
        }

        private void bgwMain_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Result is Exception)
            {
                this.ShowError("Proses memuat data gagal!");
            }

            FormHelpers.CurrentMainForm.UpdateStatusInformation("Memuat data ban detail selesai", true);
        }
    }
}