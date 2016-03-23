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
    public partial class DebtPaymentListForm : BaseDefaultForm, IDebtPaymentListView
    {
        private DebtPaymentListPresenter _presenter;
        private PurchasingViewModel _selectedPurchasing;
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
            //cmsNewPayment.Enabled = AllowInsert;
            //cmsListPayment.Enabled = AllowEdit;

            this.Load += DebtPaymentListControl_Load;
        }

        private void DebtPaymentListControl_Load(object sender, EventArgs e)
        {
            RefreshDataView();
        }

        private void gvDebtPayment_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            this.SelectedPurchasing = gvDebtPayment.GetFocusedRow() as PurchasingViewModel;
        }

        private void gvDebtPayment_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            GridView view = (GridView)sender;
            GridHitInfo hitInfo = view.CalcHitInfo(e.Point);
            if (hitInfo.InRow)
            {
                view.FocusedRowHandle = hitInfo.RowHandle;
                //cmsEditor.Show(view.GridControl, e.Point);
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
                return txtTotalTransaction.Text.AsDecimal();
            }
            set
            {
                txtTotalTransaction.Text = value.ToString("#.###");
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
                ttTotalPaid.Text = value.ToString("#.###");
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
                txtTotalNotPaid.Text = value.ToString("#.###");
            }
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

        private void cmsListPayment_Click(object sender, EventArgs e)
        {
            if (_selectedPurchasing != null)
            {
                //DebtEditorForm editor = Bootstrapper.Resolve<DebtEditorForm>();
                //editor.SelectedDebt = _selectedDebt;
                //editor.ShowDialog(this);
            }
        }

        private void bgwMain_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                _presenter.LoadTransactionList();
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

            if (gvDebtPayment.RowCount > 0)
            {
                SelectedPurchasing = gvDebtPayment.GetRow(0) as PurchasingViewModel;
            }

            FormHelpers.CurrentMainForm.UpdateStatusInformation("Memuat data Debt selesai", true);
        }
    }
}
