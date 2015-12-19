using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.Presenter;
using BrawijayaWorkshop.Utils;
using BrawijayaWorkshop.View;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;
using System.Linq;
using BrawijayaWorkshop.SharedObject.ViewModels;
using BrawijayaWorkshop.Constant;

namespace BrawijayaWorkshop.Win32App.ModulForms
{
    public partial class PurchasingApprovalForm : BaseDefaultForm, IPurchasingApprovalView
    {
        private PurchasingApprovalPresenter _presenter;

        public PurchasingApprovalForm(PurchasingApprovalModel model)
        {
            InitializeComponent();
            _presenter = new PurchasingApprovalPresenter(this, model);

            // set validation alignment
            valPayment.SetIconAlignment(cbPayment, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            gvPurchasingDetail.PopupMenuShowing += gvPurchasingDetail_PopupMenuShowing;
            gvPurchasingDetail.FocusedRowChanged += gvPurchasingDetail_FocusedRowChanged;
            this.Load += PurchasingApprovalForm_Load;
        }

        private void gvPurchasingDetail_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            this.SelectedPurchasingDetail = gvPurchasingDetail.GetFocusedRow() as PurchasingDetail;
        }

        private void gvPurchasingDetail_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            GridView view = (GridView)sender;
            GridHitInfo hitInfo = view.CalcHitInfo(e.Point);
            if (hitInfo.InRow)
            {
                view.FocusedRowHandle = hitInfo.RowHandle;
                cmsEditor.Show(view.GridControl, e.Point);
            }
        }

        private void PurchasingApprovalForm_Load(object sender, EventArgs e)
        {
            _presenter.InitFormData();

            
        }

        public Purchasing SelectedPurchasing { get; set; }
        public PurchasingDetail SelectedPurchasingDetail { get; set; }
        public List<Sparepart> ListSparepart { get; set; }

        #region Field Editor
        public DateTime Date { get; set; }


        public decimal TotalPrice 
        {
            get 
            {
                return Convert.ToDecimal(txtTotalPrice.EditValue);
            }
            set
            {
                txtTotalPrice.EditValue = value.ToString("C");
            }
        }

        public int SupplierId { get; set; }
        public int PurchasingPayment { get; set; }

        public string SupplierName
        {
            get
            {
                return txtSupplier.EditValue.ToString();
            }
            set
            {
                txtSupplier.EditValue = value;
            }
        }

        public string DateStr
        {
            get
            {
                return txtDate.EditValue.ToString();
            }
            set
            {
                txtDate.EditValue = value;
            }
        }

        public decimal TotalHasPaid
        {
            get
            {
                return txtDP.EditValue == null ? 0 : Convert.ToDecimal(txtDP.EditValue);
            }
            set
            {
                txtDP.EditValue = value;
            }
        }

        #endregion

        public List<PurchasingDetail> ListPurchasingDetail
        {
            get
            {
                return gridPurchasingDetail.DataSource as List<PurchasingDetail>;
            }
            set
            {
                if (InvokeRequired)
                {
                    this.Invoke(new MethodInvoker(delegate
                    {
                        gridPurchasingDetail.DataSource = value;
                        gvPurchasingDetail.BestFitColumns();
                    }));
                }
                else
                {
                    gridPurchasingDetail.DataSource = value;
                    gvPurchasingDetail.BestFitColumns();
                }
            }
        }

        public void Approve()
        {
            if (valPayment.Validate())
            {
                try
                {
                    MethodBase.GetCurrentMethod().Info("Approve Purchasing's changes");
                    _presenter.Approve();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MethodBase.GetCurrentMethod().Fatal("An error occured while trying to approve purchasing in supplier: '" + SelectedPurchasing.SupplierId + "'" + "at date :'" + SelectedPurchasing.Date + "'", ex);
                    this.ShowError("Proses persetujuan data pembelian dengan supplier: '" + SelectedPurchasing.SupplierId + "' gagal!");
                }
            }
        }

        private void viewSparepartDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SelectedPurchasingDetail != null)
            {
                SparepartDetailListForm editor = Bootstrapper.Resolve<SparepartDetailListForm>();
                Sparepart sparepart = ListSparepart.Where(c => c.Id == SelectedPurchasingDetail.SparepartId).FirstOrDefault();
                editor.SelectedSparepart = sparepart;
                editor.SelectedStatus = (int)DbConstant.SparepartDetailDataStatus.NotVerified;
                editor.PurchasingDetailID = SelectedPurchasingDetail.Id;
                editor.ShowDialog(this);
            }
        }
    }
}