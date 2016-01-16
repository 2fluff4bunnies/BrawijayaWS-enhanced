using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Database.Entities;
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
    public partial class CustomerListControl : BaseAppUserControl, ICustomerListView
    {
        private CustomerListPresenter _presenter;
        private CustomerViewModel _selectedCustomer;

        protected override string ModulName
        {
            get
            {
                return DbConstant.MODUL_CUSTOMER;
            }
        }

        public CustomerListControl(CustomerListModel model)
        {
            InitializeComponent();
            _presenter = new CustomerListPresenter(this, model);

            gvCustomer.PopupMenuShowing += gvCustomer_PopupMenuShowing;
            gvCustomer.FocusedRowChanged += gvCustomer_FocusedRowChanged;

            // init editor control accessibility
            btnNewCustomer.Enabled = AllowInsert;
            cmsEditData.Enabled = AllowEdit;
            cmsDeleteData.Enabled = AllowDelete;

            this.Load += CustomerListControl_Load;
        }

        private void CustomerListControl_Load(object sender, EventArgs e)
        {
            btnSearch.PerformClick();
        }

        private void gvCustomer_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            this.SelectedCustomer = gvCustomer.GetFocusedRow() as CustomerViewModel;
        }

        private void gvCustomer_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            GridView view = (GridView)sender;
            GridHitInfo hitInfo = view.CalcHitInfo(e.Point);
            if (hitInfo.InRow)
            {
                view.FocusedRowHandle = hitInfo.RowHandle;
                cmsEditor.Show(view.GridControl, e.Point);
            }
        }

        public string CompanyNameFilter
        {
            get
            {
                return txtFilterCompanyName.Text;
            }
            set
            {
                txtFilterCompanyName.Text = value;
            }
        }

        public List<CustomerViewModel> CustomerListData
        {
            get
            {
                return gridCustomer.DataSource as List<CustomerViewModel>;
            }
            set
            {
                if(InvokeRequired)
                {
                    this.Invoke(new MethodInvoker(delegate { gridCustomer.DataSource = value; gvCustomer.BestFitColumns(); }));
                }
                else
                {
                    gridCustomer.DataSource = value;
                    gvCustomer.BestFitColumns();
                }
            }
        }

        public CustomerViewModel SelectedCustomer
        {
            get
            {
                return _selectedCustomer;
            }
            set
            {
                _selectedCustomer = value;
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
                MethodBase.GetCurrentMethod().Info("Fecthing customer data...");
                _selectedCustomer = null;
                FormHelpers.CurrentMainForm.UpdateStatusInformation("Memuat data customer...", false);
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

        private void btnNewCustomer_Click(object sender, EventArgs e)
        {
            CustomerEditorForm editor = Bootstrapper.Resolve<CustomerEditorForm>();
            editor.ShowDialog(this);

            btnSearch.PerformClick();
        }

        private void cmsEditData_Click(object sender, EventArgs e)
        {
            if (_selectedCustomer != null)
            {
                CustomerEditorForm editor = Bootstrapper.Resolve<CustomerEditorForm>();
                editor.SelectedCustomer = _selectedCustomer;
                editor.ShowDialog(this);

                btnSearch.PerformClick();
            }
        }

        private void cmsDeleteData_Click(object sender, EventArgs e)
        {
            if (SelectedCustomer == null) return;

            if (this.ShowConfirmation("Apakah anda yakin ingin menghapus customer: '" + SelectedCustomer.CompanyName + "'?") == DialogResult.Yes)
            {
                try
                {
                    MethodBase.GetCurrentMethod().Info("Deleting customer: " + SelectedCustomer.CompanyName);

                    _presenter.DeleteCustomer();

                    btnSearch.PerformClick(); // refresh data
                }
                catch (Exception ex)
                {
                    MethodBase.GetCurrentMethod().Fatal("An error occured while trying to delete customer: '" + SelectedCustomer.CompanyName + "'", ex);
                    this.ShowError("Proses hapus data customer: '" + SelectedCustomer.CompanyName + "' gagal!");
                }
            }
        }

        private void bgwMain_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                _presenter.LoadCustomer();
            }
            catch (Exception ex)
            {
                MethodBase.GetCurrentMethod().Fatal("An error occured while trying to execute _presenter.LoadCustomer()", ex);
                e.Result = ex;
            }
        }

        private void bgwMain_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Result is Exception)
            {
                this.ShowError("Proses memuat data gagal!");
            }

            if(gvCustomer.RowCount > 0)
            {
                SelectedCustomer = gvCustomer.GetRow(0) as CustomerViewModel;
            }

            FormHelpers.CurrentMainForm.UpdateStatusInformation("Memuat data customer selesai", true);
        }
    }
}
