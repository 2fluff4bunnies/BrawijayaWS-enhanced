using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.Presenter;
using BrawijayaWorkshop.Runtime;
using BrawijayaWorkshop.SharedObject.ViewModels;
using BrawijayaWorkshop.Utils;
using BrawijayaWorkshop.View;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Windows.Forms;

namespace BrawijayaWorkshop.Win32App.ModulForms
{
    public partial class SpecialSparepartDetailListForm : BaseDefaultForm, ISpecialSparepartDetailListView
    {
        private SpecialSparepartDetailListPresenter _presenter;
        private SpecialSparepartDetailViewModel _selectedSSpd;

        public SpecialSparepartDetailListForm(SpecialSparepartDetailListModel model)
        {
            InitializeComponent();

            _presenter = new SpecialSparepartDetailListPresenter(this, model);
            gvSpecialSparepartDetail.PopupMenuShowing += gvSpecialSparepartDetail_PopupMenuShowing;
            gvSpecialSparepartDetail.FocusedRowChanged += gvSpecialSparepartDetail_FocusedRowChanged;

            this.Load += WheelDetailEditorForm_Load;
        }

        void gvSpecialSparepartDetail_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            _selectedSSpd = gvSpecialSparepartDetail.GetFocusedRow() as SpecialSparepartDetailViewModel;
        }

        void gvSpecialSparepartDetail_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            GridView view = (GridView)sender;
            GridHitInfo hitInfo = view.CalcHitInfo(e.Point);
            if (hitInfo.InRow)
            {
                view.FocusedRowHandle = hitInfo.RowHandle;
                cmsEditor.Show(view.GridControl, e.Point);
            }

            if (_selectedSSpd != null)
            {
                this.cmsDeleteData.Enabled = !_presenter.IsSpecialSparepartDetailInstalled(_selectedSSpd.Id);
            }
        }

        void WheelDetailEditorForm_Load(object sender, EventArgs e)
        {
            _presenter.InitFormData();
            lookupStatus.EditValue = (int)DbConstant.WheelDetailStatus.Ready;
        }

        private void lookupStatus_EditValueChanged(object sender, EventArgs e)
        {
            SelectedStatus = lookupStatus.EditValue.AsInteger();
            cmsEditor.Close();
            RefreshDataView();
        }

        #region Properties
        public SpecialSparepartViewModel SelectedSpecialSparepart { get; set; }
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

        public List<SpecialSparepartDetailViewModel> WheelDetailListData
        {
            get
            {
                return gridSpecialSparepartDetail.DataSource as List<SpecialSparepartDetailViewModel>;
            }
            set
            {
                if (InvokeRequired)
                {
                    this.Invoke(new MethodInvoker(delegate { gridSpecialSparepartDetail.DataSource = value; gvSpecialSparepartDetail.BestFitColumns(); }));
                }
                else
                {
                    gridSpecialSparepartDetail.DataSource = value;
                    gvSpecialSparepartDetail.BestFitColumns();
                }
            }
        } 
        #endregion

        public override void RefreshDataView()
        {
            if (!bgwMain.IsBusy)
            {
                this._selectedSSpd = null;
                MethodBase.GetCurrentMethod().Info("Fecthing specialSparepart detail data...");
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

            if (gvSpecialSparepartDetail.RowCount > 0)
            {
                this._selectedSSpd = gvSpecialSparepartDetail.GetRow(0) as SpecialSparepartDetailViewModel;
            }

            FormHelpers.CurrentMainForm.UpdateStatusInformation("Memuat data ban detail selesai", true);
        }

        private void cmsDeleteData_Click(object sender, EventArgs e)
        {
            if (!bgwDelete.IsBusy)
            {
                if (this.ShowConfirmation("Yakin akan menghapus data?") == System.Windows.Forms.DialogResult.Yes)
                {

                    try
                    {
                        MethodBase.GetCurrentMethod().Info("Deleting special sparepat detail");
                        this.Enabled = false;
                        bgwDelete.RunWorkerAsync();
                    }
                    catch (Exception ex)
                    {
                        MethodBase.GetCurrentMethod().Fatal("An error occured while trying to delete special sparepart detail", ex);
                        this.ShowError("Proses hapus data special sparepart detail gagal!");
                    }

                    //if ()
                    //{
                    //    this.ShowWarning("Sparepart ini telah digunakan, untuk menjaga validitas data proses penghapusan dibatalkan");
                    //}
                    //else
                    //{
                    //    this.Enabled = false;
                    //    bgwDelete.RunWorkerAsync();
                    //}
                }
            }
        }

        private void bgwDelete_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                _presenter.RemoveSpecialSparepartDetail(_selectedSSpd.Id);
            }
            catch (Exception ex)
            {
                MethodBase.GetCurrentMethod().Fatal("An error occured while trying to execute _presenter.RemoveSpecialSparepartDetail()", ex);
                e.Result = ex;
            }
        }

        private void bgwDelete_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Result is Exception)
            {
                this.ShowError("Proses hapus gagal!");
            }

            this.Enabled = true;
            this.RefreshDataView();
        }
    }
}