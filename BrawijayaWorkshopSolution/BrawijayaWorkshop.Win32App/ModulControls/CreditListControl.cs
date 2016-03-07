using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.Presenter;
using BrawijayaWorkshop.SharedObject.ViewModels;
using BrawijayaWorkshop.Utils;
using BrawijayaWorkshop.View;
using BrawijayaWorkshop.Win32App.ModulForms;
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
            btnSearch.PerformClick();
        }

        private void gvCredit_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            this.SelectedInvoice = gvCredit.GetFocusedRow() as InvoiceViewModel;
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
                txtDateFilterFrom.EditValue = value;
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

        private void txtFilterCompanyName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch.PerformClick();
            }
        }


        private void cmsNewPayment_Click(object sender, EventArgs e)
        {
            if (_selectedInvoice != null)
            {
                //CreditEditorForm editor = Bootstrapper.Resolve<CreditEditorForm>();
                //editor.SelectedCredit = _selectedCredit;
                //editor.ShowDialog(this);

                btnSearch.PerformClick();
            }
        }

        private void cmsListPayment_Click(object sender, EventArgs e)
        {
            if (_selectedInvoice != null)
            {
                //CreditEditorForm editor = Bootstrapper.Resolve<CreditEditorForm>();
                //editor.SelectedCredit = _selectedCredit;
                //editor.ShowDialog(this);

                btnSearch.PerformClick();
            }
        }

        private void bgwMain_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                _presenter.LoadSPKList();
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
    }
}
