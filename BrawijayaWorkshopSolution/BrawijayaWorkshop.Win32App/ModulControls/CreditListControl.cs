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
    public partial class CreditListControl : BaseAppUserControl, ICreditListView
    {
        private CreditListPresenter _presenter;
        private InvoiceViewModel _selectedInvoice;

        protected override string ModulName
        {
            get
            {
                return DbConstant.MODUL_CREDIT;
            }
        }

        public CreditListControl(CreditListModel model)
        {
            InitializeComponent();
            _presenter = new CreditListPresenter(this, model);

            gvCredit.PopupMenuShowing += gvCredit_PopupMenuShowing;
            gvCredit.FocusedRowChanged += gvCredit_FocusedRowChanged;

            // init editor control accessibility
            cmsNewPayment.Enabled = AllowInsert;
            cmsListPayment.Enabled = AllowEdit;

            this.Load += CreditListControl_Load;
        }

        private void CreditListControl_Load(object sender, EventArgs e)
        {
            DateFromFilter = DateTime.Now;
            DateToFilter = DateTime.Now;
            btnSearch.PerformClick();
        }

        private void gvCredit_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            this.SelectedInvoice = gvCredit.GetFocusedRow() as InvoiceViewModel;
            if (this.SelectedInvoice != null)
            {
                if (this.SelectedInvoice.PaymentStatus == (int)DbConstant.PaymentStatus.NotSettled)
                {
                    cmsNewPayment.Visible = true;
                    cmsListPayment.Visible = true;
                }
                else if (this.SelectedInvoice.Status == (int)DbConstant.PaymentStatus.Settled)
                {
                    cmsNewPayment.Visible = false;
                    cmsListPayment.Visible = true;
                }
            }
        }

        private void gvCredit_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
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

        public List<InvoiceViewModel> InvoiceListData
        {
            get
            {
                return gridCredit.DataSource as List<InvoiceViewModel>;
            }
            set
            {
                if (InvokeRequired)
                {
                    this.Invoke(new MethodInvoker(delegate { gridCredit.DataSource = value; gvCredit.BestFitColumns(); }));
                }
                else
                {
                    gridCredit.DataSource = value;
                    gvCredit.BestFitColumns();
                }
            }
        }

        public InvoiceViewModel SelectedInvoice
        {
            get
            {
                return _selectedInvoice;
            }
            set
            {
                _selectedInvoice = value;
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
                MethodBase.GetCurrentMethod().Info("Fecthing Credit data...");
                _selectedInvoice = null;
                FormHelpers.CurrentMainForm.UpdateStatusInformation("Memuat data Credit...", false);
                bgwMain.RunWorkerAsync();
            }
        }

        private void cmsNewPayment_Click(object sender, EventArgs e)
        {
            if (_selectedInvoice != null)
            {
                CreditEditorForm editor = Bootstrapper.Resolve<CreditEditorForm>();
                editor.SelectedInvoice = SelectedInvoice;
                editor.ShowDialog(this);

                btnSearch.PerformClick();
            }
        }

        private void cmsListPayment_Click(object sender, EventArgs e)
        {
            if (_selectedInvoice != null)
            {
                CreditPaymentListForm list = Bootstrapper.Resolve<CreditPaymentListForm>();
                list.SelectedInvoice = SelectedInvoice;
                list.ShowDialog(this);

                btnSearch.PerformClick();
            }
        }

        private void bgwMain_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                _presenter.LoadInvoiceList();
            }
            catch (Exception ex)
            {
                MethodBase.GetCurrentMethod().Fatal("An error occured while trying to execute _presenter.LoadCredit()", ex);
                e.Result = ex;
            }
        }

        private void bgwMain_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Result is Exception)
            {
                this.ShowError("Proses memuat data gagal!");
            }

            if (gvCredit.RowCount > 0)
            {
                SelectedInvoice = gvCredit.GetRow(0) as InvoiceViewModel;
            }

            FormHelpers.CurrentMainForm.UpdateStatusInformation("Memuat data Credit selesai", true);
        }

        private void gvCredit_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
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
