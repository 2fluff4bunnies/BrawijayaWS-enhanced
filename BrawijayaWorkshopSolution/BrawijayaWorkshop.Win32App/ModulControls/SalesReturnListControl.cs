using BrawijayaWorkshop.Constant;
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
    public partial class SalesReturnListControl : BaseAppUserControl, ISalesReturnListView
    {
        private SalesReturnListPresenter _presenter;
        private SalesReturnViewModel _selectedSalesReturn;

        protected override string ModulName
        {
            get
            {
                return DbConstant.MODUL_SALES_RETURN;
            }
        }

        public SalesReturnListControl(SalesReturnListModel model)
        {
            InitializeComponent();
            _presenter = new SalesReturnListPresenter(this, model);

            gvReturn.PopupMenuShowing += gvReturn_PopupMenuShowing;
            gvReturn.FocusedRowChanged += gvReturn_FocusedRowChanged;

            // init editor control accessibility
            btnNewReturn.Enabled = AllowInsert;
            cmsEditData.Enabled = AllowEdit;

            txtDateFilterFrom.EditValue = txtDateFilterTo.EditValue = DateTime.Today;

            this.Load += SalesReturnListControl_Load;
        }

        private void SalesReturnListControl_Load(object sender, EventArgs e)
        {
            btnSearch.PerformClick();
        }

        private void gvReturn_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            this.SelectedSalesReturn = gvReturn.GetFocusedRow() as SalesReturnViewModel;
        }

        private void gvReturn_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            GridView view = (GridView)sender;
            GridHitInfo hitInfo = view.CalcHitInfo(e.Point);
            if (hitInfo.InRow)
            {
                view.FocusedRowHandle = hitInfo.RowHandle;
                cmsEditor.Show(view.GridControl, e.Point);

                this.SelectedSalesReturn = gvReturn.GetRow(view.FocusedRowHandle) as SalesReturnViewModel;
            }
        }

        public DateTime? DateFilterFrom
        {
            get
            {
                return txtDateFilterFrom.EditValue != null ? Convert.ToDateTime(txtDateFilterFrom.EditValue) : null as DateTime?;
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
                return txtDateFilterTo.EditValue != null ? Convert.ToDateTime(txtDateFilterTo.EditValue) : null as DateTime?;
            }
            set
            {
                txtDateFilterTo.EditValue = value;
            }
        }

        public List<SalesReturnViewModel> SalesReturnListData
        {
            get
            {
                return gridReturn.DataSource as List<SalesReturnViewModel>;
            }
            set
            {
                if (InvokeRequired)
                {
                    this.Invoke(new MethodInvoker(delegate { gridReturn.DataSource = value; gvReturn.BestFitColumns(); }));
                }
                else
                {
                    gridReturn.DataSource = value;
                    gvReturn.BestFitColumns();
                }
            }
        }

        public SalesReturnViewModel SelectedSalesReturn
        {
            get
            {
                return _selectedSalesReturn;
            }
            set
            {
                _selectedSalesReturn = value;
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
                MethodBase.GetCurrentMethod().Info("Fecthing SalesReturn data...");
                _selectedSalesReturn = null;
                FormHelpers.CurrentMainForm.UpdateStatusInformation("Memuat data retur penjualan...", false);
                bgwMain.RunWorkerAsync();
            }
        }

        private void txtDateFilter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch.PerformClick();
            }
        }

        private void btnNewSalesReturn_Click(object sender, EventArgs e)
        {
            //SalesReturnEditorForm editor = Bootstrapper.Resolve<SalesReturnEditorForm>();
            //editor.ShowDialog(this);

            btnSearch.PerformClick();
        }

        private void cmsEditData_Click(object sender, EventArgs e)
        {
            if (_selectedSalesReturn != null)
            {
                //SalesReturnEditorForm editor = Bootstrapper.Resolve<SalesReturnEditorForm>();
                //editor.SelectedSalesReturn = _selectedSalesReturn;
                //editor.ShowDialog(this);

                btnSearch.PerformClick();
            }
        }

        private void bgwMain_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                _presenter.LoadSalesReturn();
            }
            catch (Exception ex)
            {
                MethodBase.GetCurrentMethod().Fatal("An error occured while trying to execute _presenter.LoadSalesReturn()", ex);
                e.Result = ex;
            }
        }

        private void bgwMain_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Result is Exception)
            {
                this.ShowError("Proses memuat data gagal!");
            }

            if (gvReturn.RowCount > 0)
            {
                SelectedSalesReturn = gvReturn.GetRow(0) as SalesReturnViewModel;
            }

            FormHelpers.CurrentMainForm.UpdateStatusInformation("Memuat data retur penjualan selesai", true);
        }

    }
}
