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
    public partial class InvoiceListControl : BaseAppUserControl, IInvoiceListView
    {
        private InvoiceListPresenter _presenter;
        private InvoiceViewModel _selectedInvoice;

        protected override string ModulName
        {
            get
            {
                return DbConstant.MODUL_INVOICE;
            }
        }

        public InvoiceListControl(InvoiceListModel model)
        {
            InitializeComponent();
            _presenter = new InvoiceListPresenter(this, model);

            gvInvoice.PopupMenuShowing += gvInvoice_PopupMenuShowing;
            gvInvoice.FocusedRowChanged += gvInvoice_FocusedRowChanged;

            // init editor control accessibility
            cmsAddData.Enabled = AllowInsert;
            cmsEditData.Enabled = AllowEdit;
            cmsPrint.Enabled = AllowEdit;

            this.Load += InvoiceListControl_Load;
            this.InvoiceStatusFilter = 9;
        }

        private void InvoiceListControl_Load(object sender, EventArgs e)
        {
            btnSearch.PerformClick();
        }

        private void gvInvoice_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            this.SelectedInvoice = gvInvoice.GetFocusedRow() as InvoiceViewModel;
        }

        private void gvInvoice_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
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

        public int InvoiceStatusFilter
        {
            get
            {
                return cbStatus.EditValue.AsInteger();
            }
            set
            {
                cbStatus.EditValue = value;
            }
        }

        public List<InvoiceViewModel> InvoiceListData
        {
            get
            {
                return gridInvoice.DataSource as List<InvoiceViewModel>;
            }
            set
            {
                if (InvokeRequired)
                {
                    this.Invoke(new MethodInvoker(delegate { gridInvoice.DataSource = value; gvInvoice.BestFitColumns(); }));
                }
                else
                {
                    gridInvoice.DataSource = value;
                    gvInvoice.BestFitColumns();
                }
            }
        }
        public List<InvoiceStatusItem> InvoiceStatusList
        {
            get
            {
                return cbStatus.Properties.DataSource as List<InvoiceStatusItem>;
            }
            set
            {
                cbStatus.Properties.DataSource = value;
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
                MethodBase.GetCurrentMethod().Info("Fecthing Invoice data...");
                _selectedInvoice = null;
                FormHelpers.CurrentMainForm.UpdateStatusInformation("Memuat data Invoice...", false);
                bgwMain.RunWorkerAsync();
            }
        }

        private void cmsNewData_Click(object sender, EventArgs e)
        {
            if (_selectedInvoice != null)
            {
                //InvoiceEditorForm editor = Bootstrapper.Resolve<InvoiceEditorForm>();
                //editor.SelectedInvoice = _selectedInvoice;
                //editor.ShowDialog(this);

                btnSearch.PerformClick();
            }
        }

        private void cmEditData_Click(object sender, EventArgs e)
        {
            if (_selectedInvoice != null)
            {
                //InvoiceEditorForm editor = Bootstrapper.Resolve<InvoiceEditorForm>();
                //editor.SelectedInvoice = _selectedInvoice;
                //editor.ShowDialog(this);

                btnSearch.PerformClick();
            }
        }

        private void cmsPrint_Click(object sender, EventArgs e)
        {
            if (_selectedInvoice != null)
            {
                //InvoiceEditorForm editor = Bootstrapper.Resolve<InvoiceEditorForm>();
                //editor.SelectedInvoice = _selectedInvoice;
                //editor.ShowDialog(this);

                btnSearch.PerformClick();
            }
        }

        private void bgwMain_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                _presenter.LoadInvoiceList();
                _presenter.GetInvoiceStatusDropdownList();
            }
            catch (Exception ex)
            {
                MethodBase.GetCurrentMethod().Fatal("An error occured while trying to execute _presenter.LoadInvoice()", ex);
                e.Result = ex;
            }
        }

        private void bgwMain_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Result is Exception)
            {
                this.ShowError("Proses memuat data gagal!");
            }

            if (gvInvoice.RowCount > 0)
            {
                SelectedInvoice = gvInvoice.GetRow(0) as InvoiceViewModel;
            }

            FormHelpers.CurrentMainForm.UpdateStatusInformation("Memuat data Invoice selesai", true);
        }
    }
}
