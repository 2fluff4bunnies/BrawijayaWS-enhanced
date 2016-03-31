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
using System.Linq;

namespace BrawijayaWorkshop.Win32App.ModulControls
{
    public partial class CreditPaymentListForm : BaseDefaultForm, ICreditPaymentListView
    {
        private CreditPaymentListPresenter _presenter;
        private TransactionViewModel _selectedTransaction;

        protected override string ModulName
        {
            get
            {
                return DbConstant.MODUL_CREDIT;
            }
        }

        public CreditPaymentListForm(CreditPaymentListModel model)
        {
            InitializeComponent();
            _presenter = new CreditPaymentListPresenter(this, model);

            gvCreditPayment.PopupMenuShowing += gvCreditPayment_PopupMenuShowing;
            gvCreditPayment.FocusedRowChanged += gvCreditPayment_FocusedRowChanged;

            // init editor control accessibility
            cmsEdit.Enabled = AllowInsert;
            cmsDelete.Enabled = AllowEdit;

            this.Load += CreditPaymentListControl_Load;
        }

        private void CreditPaymentListControl_Load(object sender, EventArgs e)
        {
            RefreshDataView();
        }

        private void gvCreditPayment_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            this.SelectedTransaction = gvCreditPayment.GetFocusedRow() as TransactionViewModel;
        }

        private void gvCreditPayment_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            GridView view = (GridView)sender;
            GridHitInfo hitInfo = view.CalcHitInfo(e.Point);
            if (hitInfo.InRow)
            {
                view.FocusedRowHandle = hitInfo.RowHandle;
                cmsEditor.Show(view.GridControl, e.Point);
            }
        }

        public List<TransactionViewModel> TransactionListData
        {
            get
            {
                return gridCreditPayment.DataSource as List<TransactionViewModel>;
            }
            set
            {
                if (InvokeRequired)
                {
                    this.Invoke(new MethodInvoker(delegate { gridCreditPayment.DataSource = value; gvCreditPayment.BestFitColumns(); }));
                }
                else
                {
                    gridCreditPayment.DataSource = value;
                    gvCreditPayment.BestFitColumns();
                }
            }
        }

        public InvoiceViewModel SelectedInvoice { get; set; }

        public TransactionViewModel SelectedTransaction
        {
            get
            {
                return _selectedTransaction;
            }
            set
            {
                _selectedTransaction = value;
            }
        }

        public DateTime TransactionDate
        {
            get
            {
                return txtTransactionDate.Text.AsDateTime();
            }
            set
            {
                txtTransactionDate.Text = value.ToString("dd/MM/yyyy");
            }
        }

        public string CustomerName
        {
            get
            {
                return txtCustomer.Text;
            }
            set
            {
                txtCustomer.Text = value;
            }
        }

        public decimal TotalPrice
        {
            get
            {
                return txtTotalTransaction.Text.AsDecimal();
            }
            set
            {
                txtTotalTransaction.Text = value.ToString("#,#");
            }
        }

        public decimal TotalHasPaid
        {
            get
            {
                return ttTotalPaid.Text.AsDecimal();
            }
            set
            {
                ttTotalPaid.Text = value.ToString("#,#");
            }
        }

        public decimal TotalNotPaid
        {
            get
            {
                return txtTotalNotPaid.Text.AsDecimal();
            }
            set
            {
                txtTotalNotPaid.Text = value.ToString("#,#");
            }
        }

        public override void RefreshDataView()
        {
            MethodBase.GetCurrentMethod().Info("Fecthing Credit data...");
            FormHelpers.CurrentMainForm.UpdateStatusInformation("Memuat data Credit...", false);
            _presenter.LoadTransactionList();
        }

        private void cmsEditData_Click(object sender, EventArgs e)
        {
            if (_selectedTransaction != null)
            {
                if (_selectedTransaction == TransactionListData.First())
                {
                    this.ShowError("Data pembayaran invoice tidak dapat diubah pada menu ini");
                }
                else
                {
                    CreditEditorForm editor = Bootstrapper.Resolve<CreditEditorForm>();
                    editor.SelectedCredit = _selectedTransaction;
                    editor.ShowDialog(this);
                    RefreshDataView();
                }
            }
        }

        private void cmsDeleteData_Click(object sender, EventArgs e)
        {
            if (SelectedTransaction == null) return;

            if (this.ShowConfirmation("Apakah anda yakin ingin menghapus pembayaran piutang: '" + SelectedTransaction.Description + "'?") == DialogResult.Yes)
            {
                try
                {
                    if (_selectedTransaction == TransactionListData.First())
                    {
                        this.ShowError("Data pembayaran invoice tidak dapat diubah pada menu ini");
                    }
                    else
                    {
                        MethodBase.GetCurrentMethod().Info("Deleting credit: " + SelectedTransaction.Description);

                        _presenter.DeleteData();
                        RefreshDataView();
                    } 
                }
                catch (Exception ex)
                {
                    MethodBase.GetCurrentMethod().Fatal("An error occured while trying to delete debt: '" + SelectedTransaction.Description + "'", ex);
                    this.ShowError("Proses hapus data pembayaran hutang: '" + SelectedTransaction.Description + "' gagal!");
                }
            }
        }
    }
}
