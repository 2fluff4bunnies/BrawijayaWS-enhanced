using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.Presenter;
using BrawijayaWorkshop.SharedObject.ViewModels;
using BrawijayaWorkshop.Utils;
using BrawijayaWorkshop.View;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;

namespace BrawijayaWorkshop.Win32App.ModulForms
{
    public partial class ManualTransactionEditorForm : BaseEditorForm, IManualTransactionEditorView
    {
        private ManualTransactionEditorPresenter _presenter;

        public ManualTransactionEditorForm(ManualTransactionEditorModel model)
        {
            InitializeComponent();
            _presenter = new ManualTransactionEditorPresenter(this, model);

            gvTransactionDetail.FocusedRowChanged += gvTransactionDetail_FocusedRowChanged;
            gvTransactionDetail.PopupMenuShowing += gvTransactionDetail_PopupMenuShowing;

            this.Load += ManualTransactionEditorForm_Load;
        }

        private void gvTransactionDetail_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            GridView view = (GridView)sender;
            GridHitInfo hitInfo = view.CalcHitInfo(e.Point);
            if (hitInfo.InRow)
            {
                view.FocusedRowHandle = hitInfo.RowHandle;
                cmsEditor.Show(view.GridControl, e.Point);
            }
        }

        private void gvTransactionDetail_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            SelectedTransactionDetail = gvTransactionDetail.GetFocusedRow() as TransactionDetailViewModel;
        }

        void ManualTransactionEditorForm_Load(object sender, EventArgs e)
        {
            _presenter.InitFormData();
        }

        public TransactionViewModel SelectedTransaction { get; set; }
        public TransactionDetailViewModel SelectedTransactionDetail { get; set; }

        public List<TransactionDetailViewModel> TransactionDetailList
        {
            get
            {
                return gridTransactionDetail.DataSource as List<TransactionDetailViewModel>;
            }
            set
            {
                if (InvokeRequired)
                {
                    this.Invoke(new MethodInvoker(delegate { gridTransactionDetail.DataSource = value; gvTransactionDetail.BestFitColumns(); }));
                }
                else
                {
                    gridTransactionDetail.DataSource = value;
                    gvTransactionDetail.BestFitColumns();
                }
            }
        }

        public List<TransactionDetailViewModel> DeletedDetailList { get; set; }

        public List<JournalMasterViewModel> JournalList
        {
            get
            {
                return lookUpJournalGv.DataSource as List<JournalMasterViewModel>;
            }
            set
            {
                lookUpJournalGv.DataSource = value;
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

        public string TransactionDescription
        {
            get
            {
                return txtTransDesc.Text;
            }
            set
            {
                txtTransDesc.Text = value;
            }
        }

        public double TotalTransaction
        {
            get
            {
                return txtTransTotal.EditValue.AsDouble();
            }
            set
            {
                txtTransTotal.EditValue = value;
            }
        }

        public bool IsReconciliation
        {
            get
            {
                return cbxIsReconciliation.Checked;
            }
            set
            {
                cbxIsReconciliation.Checked = value;
            }
        }

        private void btnNewTransDetail_Click(object sender, EventArgs e)
        {
            _presenter.InsertNewRecord();
        }

        protected override void ExecuteSave()
        {
            if (_presenter.ValidateTransaction())
            {
                _presenter.CalculateTotalTransaction();
                try
                {
                    MethodBase.GetCurrentMethod().Info("Save Manual Transaction's changes");
                    _presenter.SaveChanges();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MethodBase.GetCurrentMethod().Fatal("An error occured while trying to save manual transaction", ex);
                    this.ShowError("Proses simpan data transaksi manual gagal!");
                }
            }
            else
            {
                this.ShowWarning("Jurnal harus dipilih atau Total debit dan credit harus sama!");
            }
        }

        private void cmsDeleteData_Click(object sender, EventArgs e)
        {
            if (SelectedTransactionDetail != null)
            {
                if (this.ShowConfirmation("Apakah anda yakin ingin menghapus detail berikut?") == System.Windows.Forms.DialogResult.Yes)
                {
                    _presenter.RemoveDetail();
                }
            }
        }
    }
}