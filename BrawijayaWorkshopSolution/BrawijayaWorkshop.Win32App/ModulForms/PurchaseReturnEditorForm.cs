using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.Presenter;
using BrawijayaWorkshop.SharedObject.ViewModels;
using BrawijayaWorkshop.Utils;
using BrawijayaWorkshop.View;
using DevExpress.XtraGrid.Views.Base;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using System.Windows.Forms;
using BrawijayaWorkshop.Constant;

namespace BrawijayaWorkshop.Win32App.ModulForms
{
    public partial class PurchaseReturnEditorForm : BaseEditorForm, IPurchaseReturnEditorView
    {
        private PurchaseReturnEditorPresenter _presenter;

        public PurchaseReturnEditorForm(PurchaseReturnEditorModel model)
        {
            InitializeComponent();
            _presenter = new PurchaseReturnEditorPresenter(this, model);

            // set validation alignment

            this.Load += PurchaseReturnEditorForm_Load;
        }

        private void PurchaseReturnEditorForm_Load(object sender, EventArgs e)
        {
            _presenter.InitFormData();
        }

        public PurchasingViewModel SelectedPurchasing { get; set; }
        public PurchaseReturnViewModel SelectedPurchaseReturn { get; set; }

        #region Field Editor
        public DateTime Date
        {
            get
            {
                return Convert.ToDateTime(txtTransactionDate.Text);
            }
            set
            {
                txtTransactionDate.Text = value.ToString("dd-MM-yyyy");
            }
        }

        public new string SupplierName
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

        public List<ReturnViewModel> ListReturn
        {
            get
            {
                return bsSparepart.DataSource as List<ReturnViewModel>;
            }
            set
            {
                if (InvokeRequired)
                {
                    this.Invoke(new MethodInvoker(delegate
                    {
                        bsSparepart.DataSource = value;
                        gridSparepart.DataSource = bsSparepart;
                        gvSparepart.BestFitColumns();
                    }));
                }
                else
                {
                    bsSparepart.DataSource = value;
                    gridSparepart.DataSource = bsSparepart;
                    gvSparepart.BestFitColumns();
                }
            }
        }
        #endregion
        protected override void ExecuteSave()
        {
            if (ListReturn.Where(x=>x.ReturQty > x.ReturQtyLimit).Count() == 0)
            {
                try
                {
                    MethodBase.GetCurrentMethod().Info("Save Purchase Return's changes");
                    _presenter.SaveChanges();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MethodBase.GetCurrentMethod().Fatal("An error occured while trying to save Purchase Return in Purchasing: '" + SelectedPurchasing.Id + "'", ex);
                    this.ShowError("Proses simpan data Purchase Return in Purchasing: '" + SelectedPurchasing.Id + "' gagal!");
                }
            }
            else
            {
                this.ShowError("Proses simpan data gagal! jumlah qty retur melebihi jumlah qty pada saat pembelian");
            }
        }
    }
}