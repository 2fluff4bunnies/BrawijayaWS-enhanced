﻿using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.Presenter;
using BrawijayaWorkshop.SharedObject.ViewModels;
using BrawijayaWorkshop.Utils;
using BrawijayaWorkshop.View;
using BrawijayaWorkshop.Win32App.ModulForms;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Windows.Forms;

namespace BrawijayaWorkshop.Win32App.ModulControls
{
    public partial class DebtListControl : BaseAppUserControl, IDebtListView
    {
        private DebtListPresenter _presenter;
        private PurchasingViewModel _selectedPurchasing;

        protected override string ModulName
        {
            get
            {
                return DbConstant.MODUL_DEBT;
            }
        }

        public DebtListControl(DebtListModel model)
        {
            InitializeComponent();
            _presenter = new DebtListPresenter(this, model);

            gvDebt.PopupMenuShowing += gvDebt_PopupMenuShowing;
            gvDebt.FocusedRowChanged += gvDebt_FocusedRowChanged;

            // init editor control accessibility
            cmsNewPayment.Enabled = AllowInsert;
            cmsListPayment.Enabled = AllowEdit;

            this.Load += DebtListControl_Load;
        }

        private void DebtListControl_Load(object sender, EventArgs e)
        {
            DateFromFilter = DateTime.Now;
            DateToFilter = DateTime.Now;
            btnSearch.PerformClick();
        }

        private void gvDebt_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            this.SelectedPurchasing = gvDebt.GetFocusedRow() as PurchasingViewModel;
            if (this.SelectedPurchasing != null)
            {
                if (this.SelectedPurchasing.PaymentStatus == (int)DbConstant.PaymentStatus.NotSettled)
                {
                    cmsNewPayment.Visible = true;
                    cmsListPayment.Visible = true;
                }
                else if (this.SelectedPurchasing.PaymentStatus == (int)DbConstant.PaymentStatus.Settled)
                {
                    cmsNewPayment.Visible = false;
                    cmsListPayment.Visible = true;
                }
            }
        }

        private void gvDebt_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            GridView view = (GridView)sender;
            GridHitInfo hitInfo = view.CalcHitInfo(e.Point);
            if (hitInfo.InRow)
            {
                view.FocusedRowHandle = hitInfo.RowHandle;
                cmsEditor.Show(view.GridControl, e.Point);
            }
        }

        public DateTime? DateFromFilter
        {
            get
            {
                return txtDateFilterFrom.EditValue as DateTime?;
            }
            set
            {
                txtDateFilterFrom.EditValue = value;
            }
        }

        public DateTime? DateToFilter
        {
            get
            {
                return txtDateFilterTo.EditValue as DateTime?;
            }
            set
            {
                txtDateFilterTo.EditValue = value;
            }
        }

        public List<PurchasingViewModel> PurchasingListData
        {
            get
            {
                return gridDebt.DataSource as List<PurchasingViewModel>;
            }
            set
            {
                if (InvokeRequired)
                {
                    this.Invoke(new MethodInvoker(delegate { gridDebt.DataSource = value; gvDebt.BestFitColumns(); }));
                }
                else
                {
                    gridDebt.DataSource = value;
                    gvDebt.BestFitColumns();
                }
            }
        }

        public PurchasingViewModel SelectedPurchasing
        {
            get
            {
                return _selectedPurchasing;
            }
            set
            {
                _selectedPurchasing = value;
            }
        }

        public string DebtStatusPayment
        {
            get
            {
                string result = "Semua";
                if (cbPaymentStatus.EditValue != null)
                {
                    result = cbPaymentStatus.EditValue.ToString();
                }
                return result;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            RefreshDataView();
        }

        public override void RefreshDataView()
        {
            if (!bgwMain.IsBusy)
            {
                MethodBase.GetCurrentMethod().Info("Fecthing Debt data...");
                _selectedPurchasing = null;
                FormHelpers.CurrentMainForm.UpdateStatusInformation("Memuat data Debt...", false);
                bgwMain.RunWorkerAsync();
            }
        }

        private void txtFilterCompanyName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch.PerformClick();
            }
        }


        private void cmsNewPayment_Click(object sender, EventArgs e)
        {
            if (_selectedPurchasing != null)
            {
                DebtEditorForm editor = Bootstrapper.Resolve<DebtEditorForm>();
                editor.SelectedPurchasing = SelectedPurchasing;
                editor.ShowDialog(this);

                btnSearch.PerformClick();
            }
        }

        private void cmsListPayment_Click(object sender, EventArgs e)
        {
            if (_selectedPurchasing != null)
            {
                DebtPaymentListForm list = Bootstrapper.Resolve<DebtPaymentListForm>();
                list.SelectedPurchasing = SelectedPurchasing;
                list.ShowDialog(this);

                btnSearch.PerformClick();
            }
        }

        private void bgwMain_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                _presenter.LoadPurchasingList();
            }
            catch (Exception ex)
            {
                MethodBase.GetCurrentMethod().Fatal("An error occured while trying to execute _presenter.LoadDebt()", ex);
                e.Result = ex;
            }
        }

        private void bgwMain_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Result is Exception)
            {
                this.ShowError("Proses memuat data gagal!");
            }

            if (gvDebt.RowCount > 0)
            {
                SelectedPurchasing = gvDebt.GetRow(0) as PurchasingViewModel;
                if (this.SelectedPurchasing != null)
                {
                    if (this.SelectedPurchasing.PaymentStatus == (int)DbConstant.PaymentStatus.NotSettled)
                    {
                        cmsNewPayment.Visible = true;
                        cmsListPayment.Visible = true;
                    }
                    else if (this.SelectedPurchasing.PaymentStatus == (int)DbConstant.PaymentStatus.Settled)
                    {
                        cmsNewPayment.Visible = false;
                        cmsListPayment.Visible = true;
                    }
                }
            }

            FormHelpers.CurrentMainForm.UpdateStatusInformation("Memuat data Debt selesai", true);
        }

        private void bgwExport_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                _presenter.ExportToCSV();
            }
            catch (Exception ex)
            {
                MethodBase.GetCurrentMethod().Fatal("An error occured while trying to export Debt", ex);
                e.Result = ex;
            }
        }

        private void bgwExport_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Result is Exception)
            {
                this.ShowError("Proses export Debt gagal!");
            }

            FormHelpers.CurrentMainForm.UpdateStatusInformation("Export Debt selesai", true);
        }

        public string ExportFileName { get; set; }

        private void btnExportToCSV_Click(object sender, EventArgs e)
        {
            if (!bgwExport.IsBusy && !bgwMain.IsBusy)
            {
                ExportFileName = string.Empty;
                btnSearch.PerformClick();
                exportDialog.FileName = "Debt_" + DateTime.Now.ToString("yyyyMMdd_HHmmssfff") + ".csv";
                exportDialog.ShowDialog(this);
            }
        }

        private void exportDialog_FileOk(object sender, CancelEventArgs e)
        {
            ExportFileName = exportDialog.FileName;

            MethodBase.GetCurrentMethod().Info("Exporting Debt data...");
            FormHelpers.CurrentMainForm.UpdateStatusInformation("Proses export data Debt...", false);
            bgwExport.RunWorkerAsync();
        }

        private void gvDebt_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            ColumnView view = sender as ColumnView;
            if (e.Column.FieldName == "PaymentStatus" && e.ListSourceRowIndex != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
            {
                int status = (int)view.GetListSourceRowCellValue(e.ListSourceRowIndex, "PaymentStatus");
                switch (status)
                {
                    case 0: e.DisplayText = "Belum Lunas"; break;
                    case 1: e.DisplayText = "Lunas"; break;
                }
            }
        }
    }
}
