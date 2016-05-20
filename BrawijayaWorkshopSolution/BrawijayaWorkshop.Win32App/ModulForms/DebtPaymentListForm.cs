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
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace BrawijayaWorkshop.Win32App.ModulControls
{
    public partial class DebtPaymentListForm : BaseDefaultForm, IDebtPaymentListView
    {
        private DebtPaymentListPresenter _presenter;
        private TransactionViewModel _selectedTransaction;

        protected override string ModulName
        {
            get
            {
                return DbConstant.MODUL_DEBT;
            }
        }

        public DebtPaymentListForm(DebtPaymentListModel model)
        {
            InitializeComponent();
            _presenter = new DebtPaymentListPresenter(this, model);

            gvDebtPayment.PopupMenuShowing += gvDebtPayment_PopupMenuShowing;
            gvDebtPayment.FocusedRowChanged += gvDebtPayment_FocusedRowChanged;

            // init editor control accessibility
            cmsEdit.Enabled = AllowInsert;
            cmsDelete.Enabled = AllowEdit;

            this.Load += DebtPaymentListControl_Load;
        }

        private void DebtPaymentListControl_Load(object sender, EventArgs e)
        {
            RefreshDataView();
        }

        private void gvDebtPayment_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            this.SelectedTransaction = gvDebtPayment.GetFocusedRow() as TransactionViewModel;
        }

        private void gvDebtPayment_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
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
                return gridDebtPayment.DataSource as List<TransactionViewModel>;
            }
            set
            {
                if (InvokeRequired)
                {
                    this.Invoke(new MethodInvoker(delegate { gridDebtPayment.DataSource = value; gvDebtPayment.BestFitColumns(); }));
                }
                else
                {
                    gridDebtPayment.DataSource = value;
                    gvDebtPayment.BestFitColumns();
                }
            }
        }

        public PurchasingViewModel SelectedPurchasing { get; set; }

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
                return deTransDate.EditValue.AsDateTime();
            }
            set
            {
                deTransDate.EditValue = value;
            }
        }

        public string SupplierName
        {
            get
            {
                return txtSupplier.Text;
            }
            set
            {
                txtSupplier.Text = value;
            }
        }

        public decimal TotalPrice
        {
            get
            {
                return txtTotalTransaction.EditValue.AsDecimal();
            }
            set
            {
                txtTotalTransaction.EditValue = value;
            }
        }

        public decimal TotalHasPaid
        {
            get
            {
                return ttTotalPaid.EditValue.AsDecimal();
            }
            set
            {
                ttTotalPaid.EditValue = value;
            }
        }

        public decimal TotalNotPaid
        {
            get
            {
                return txtTotalNotPaid.EditValue.AsDecimal();
            }
            set
            {
                txtTotalNotPaid.EditValue = value;
            }
        }

        public override void RefreshDataView()
        {
            MethodBase.GetCurrentMethod().Info("Fecthing Debt data...");
            FormHelpers.CurrentMainForm.UpdateStatusInformation("Memuat data Debt...", false);
            _presenter.LoadTransactionList();
        }

        private void cmsEditData_Click(object sender, EventArgs e)
        {
            if (_selectedTransaction != null)
            {
                if(_selectedTransaction == TransactionListData.First())
                {
                    this.ShowError("Data pembayaran purchasing tidak dapat diubah pada menu ini");
                }
                else
                {
                    DebtEditorForm editor = Bootstrapper.Resolve<DebtEditorForm>();
                    editor.SelectedDebt = _selectedTransaction;
                    editor.ShowDialog(this);
                    RefreshDataView();
                }
            }
        }

        private void cmsDeleteData_Click(object sender, EventArgs e)
        {
            if (SelectedTransaction == null) return;

            if (this.ShowConfirmation("Apakah anda yakin ingin menghapus pembayaran hutang: '" + SelectedTransaction.Description + "'?") == DialogResult.Yes)
            {
                try
                {
                    if (_selectedTransaction == TransactionListData.First())
                    {
                        this.ShowError("Data pembayaran purchasing tidak dapat diubah pada menu ini");
                    }
                    else
                    {
                        MethodBase.GetCurrentMethod().Info("Deleting debt: " + SelectedTransaction.Description);

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
