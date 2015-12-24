using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.Presenter;
using BrawijayaWorkshop.Utils;
using BrawijayaWorkshop.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Windows.Forms;

namespace BrawijayaWorkshop.Win32App.ModulForms
{
    public partial class SparepartDetailListForm : BaseDefaultForm, ISparepartDetailListView
    {
        private SparepartDetailListPresenter _presenter;

        public SparepartDetailListForm(SparepartDetailListModel model)
        {
            InitializeComponent();
            _presenter = new SparepartDetailListPresenter(this, model);

            this.Load += SparepartDetailListForm_Load;
        }

        private void SparepartDetailListForm_Load(object sender, EventArgs e)
        {
            this.Text = string.Format(this.Text, SelectedSparepart.Code + " - " + SelectedSparepart.Name);
            _presenter.InitFormData();
            lookupStatus.EditValue = (int)DbConstant.SparepartDetailDataStatus.Active;
            RefreshDataView();
        }

        public Sparepart SelectedSparepart { get; set; }

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

        public List<SparepartDetailStatusItem> ListStatus
        {
            get
            {
                return lookupStatus.Properties.DataSource as List<SparepartDetailStatusItem>;
            }
            set
            {
                lookupStatus.Properties.DataSource = value;
            }
        }

        public List<SparepartDetail> SparepartDetailListData
        {
            get
            {
                return gridSparepartDetail.DataSource as List<SparepartDetail>;
            }
            set
            {
                if (InvokeRequired)
                {
                    this.Invoke(new MethodInvoker(delegate { gridSparepartDetail.DataSource = value; gvSparepartDetail.BestFitColumns(); }));
                }
                else
                {
                    gridSparepartDetail.DataSource = value;
                    gvSparepartDetail.BestFitColumns();
                }
            }
        }

        private void lookupStatus_EditValueChanged(object sender, EventArgs e)
        {
            SelectedStatus = lookupStatus.EditValue.AsInteger();
            RefreshDataView();
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

            FormHelpers.CurrentMainForm.UpdateStatusInformation("Memuat data sparepart detail selesai", true);
        }

        public override void RefreshDataView()
        {
            if (!bgwMain.IsBusy)
            {
                MethodBase.GetCurrentMethod().Info("Fecthing sparepart detail data...");
                FormHelpers.CurrentMainForm.UpdateStatusInformation("Memuat data sparepart detail...", false);
                bgwMain.RunWorkerAsync();
            }
        }
    }
}