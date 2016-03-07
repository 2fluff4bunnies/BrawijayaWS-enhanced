using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.Presenter;
using BrawijayaWorkshop.SharedObject.ViewModels;
using BrawijayaWorkshop.Utils;
using BrawijayaWorkshop.View;
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

            TransactionDateValidator.SetIconAlignment(deTransDate, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.Load += ManualTransactionEditorForm_Load;
        }

        void ManualTransactionEditorForm_Load(object sender, EventArgs e)
        {
            _presenter.InitFormData();
        }

        public TransactionViewModel SelectedTransaction { get; set; }

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

        public List<JournalMasterViewModel> JournalList {
        
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
                return deTransDate.Text.AsDateTime();
            }
            set
            {
                deTransDate.Text = value.ToString();
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
                return txtTransTotal.Text.AsDouble();
            }
            set
            {
                txtTransTotal.Text = value.ToString();
            }
        }

        private void btnNewTransDetail_Click(object sender, EventArgs e)
        {
            gvTransactionDetail.AddNewRow();
        }


        protected override void ExecuteSave()
        {
            if (TransactionDateValidator.Validate())
            {
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
        }
    }
}