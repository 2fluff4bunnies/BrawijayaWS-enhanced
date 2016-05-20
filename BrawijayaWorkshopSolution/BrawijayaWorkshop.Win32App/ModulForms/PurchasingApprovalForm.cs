using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.Presenter;
using BrawijayaWorkshop.SharedObject.ViewModels;
using BrawijayaWorkshop.Utils;
using BrawijayaWorkshop.View;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

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
            this.SelectedPurchasingDetail = gvPurchasingDetail.GetFocusedRow() as PurchasingDetailViewModel;
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
            if (SelectedPurchasing != null && SelectedPurchasing.Status == (int)DbConstant.PurchasingStatus.Active)
            {
                this.Text = "Informasi Pembelian Detail";
                btnApprove.Visible = false;
                btnReject.Visible = false;
                cbPayment.ReadOnly = true;
                txtDP.ReadOnly = true;
                PaymentMethodId = SelectedPurchasing.PaymentMethodId;
                TotalHasPaid = SelectedPurchasing.TotalHasPaid;
                if (SelectedPurchasing.PaymentMethod.Code == DbConstant.REF_PURCHASE_PAYMENTMETHOD_UANGMUKA_KAS ||
                    SelectedPurchasing.PaymentMethod.Code == DbConstant.REF_PURCHASE_PAYMENTMETHOD_UANGMUKA_BANK_EKONOMI ||
                    SelectedPurchasing.PaymentMethod.Code == DbConstant.REF_PURCHASE_PAYMENTMETHOD_UANGMUKA_BANK_BCA1 ||
                    SelectedPurchasing.PaymentMethod.Code == DbConstant.REF_PURCHASE_PAYMENTMETHOD_UANGMUKA_BANK_BCA2)
                {
                    lblDP.Visible = true;
                    txtDP.Visible = true;
                }
            }
        }
        private bool _isApprove = false;

        public PurchasingViewModel SelectedPurchasing { get; set; }
        public PurchasingDetailViewModel SelectedPurchasingDetail { get; set; }
        public List<SparepartViewModel> ListSparepart { get; set; }
        public int PaymentMethodId
        {
            get
            {
                ReferenceViewModel selected = cbPayment.GetSelectedDataRow() as ReferenceViewModel;
                if (selected == null) return 0;
                return selected.Id;
            }
            set
            {
                cbPayment.EditValue = value;
            }
        }

        public List<ReferenceViewModel> ListPaymentMethod
        {
            get
            {
                return cbPayment.Properties.DataSource as List<ReferenceViewModel>;
            }
            set
            {
                cbPayment.Properties.DataSource = value;
            }
        }

        #region Field Editor
        public DateTime Date { get; set; }


        public decimal TotalPrice
        {
            get
            {
                return txtTotalPrice.EditValue.AsDecimal();
            }
            set
            {
                txtTotalPrice.EditValue = value;
            }
        }

        public int SupplierId { get; set; }

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
                return txtDP.EditValue.AsDecimal();
            }
            set
            {
                txtDP.EditValue = value;
            }
        }

        #endregion

        public List<PurchasingDetailViewModel> ListPurchasingDetail
        {
            get
            {
                return gridPurchasingDetail.DataSource as List<PurchasingDetailViewModel>;
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

        private void viewSparepartDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SelectedPurchasingDetail != null)
            {
                SparepartDetailListForm editor = Bootstrapper.Resolve<SparepartDetailListForm>();
                SparepartViewModel sparepart = ListSparepart.Where(c => c.Id == SelectedPurchasingDetail.SparepartId).FirstOrDefault();
                editor.SelectedSparepart = sparepart;
                if (SelectedPurchasingDetail.Status == (int)DbConstant.PurchasingStatus.NotVerified)
                {
                    editor.SelectedStatus = (int)DbConstant.SparepartDetailDataStatus.NotVerified;
                }
                else
                {
                    editor.SelectedStatus = (int)DbConstant.SparepartDetailDataStatus.Active;
                }

                editor.PurchasingDetailID = SelectedPurchasingDetail.Id;
                editor.ShowDialog(this);
            }
        }

        private void cbPayment_EditValueChanged(object sender, EventArgs e)
        {
            ReferenceViewModel refSelected = (sender as DevExpress.XtraEditors.LookUpEdit).GetSelectedDataRow() as ReferenceViewModel;
            if (refSelected != null)
            {
                if (refSelected.Code == DbConstant.REF_PURCHASE_PAYMENTMETHOD_UANGMUKA_KAS ||
                    refSelected.Code == DbConstant.REF_PURCHASE_PAYMENTMETHOD_UANGMUKA_BANK_EKONOMI ||
                    refSelected.Code == DbConstant.REF_PURCHASE_PAYMENTMETHOD_UANGMUKA_BANK_BCA1 ||
                    refSelected.Code == DbConstant.REF_PURCHASE_PAYMENTMETHOD_UANGMUKA_BANK_BCA2)
                {
                    txtDP.Visible = true;
                    lblDP.Visible = true;
                }
                else
                {
                    txtDP.Visible = false;
                    lblDP.Visible = false;
                }

            }
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            if(cbPayment.EditValue == null)
            {
                this.ShowWarning("Pilih Metode Pembayaran");
                return;
            }
            if (!bgwSave.IsBusy)
            {
                bool isValid = false;
                if (SelectedPurchasing != null)
                {
                    if(valPayment.Validate())
                    {
                        if(txtDP.Visible == true)
                        {
                            if(TotalHasPaid > 0 && TotalHasPaid <= TotalPrice)
                            {
                                isValid = true;
                            }
                            else
                            {
                                isValid = false;
                            }
                        }
                        else
                        {
                            isValid = true;
                        }
                    }
                }
                if (isValid)
                {
                    MethodBase.GetCurrentMethod().Info("Approve Purchasing's changes");
                    FormHelpers.CurrentMainForm.UpdateStatusInformation("Proses persetujuan data pembelian...", false);
                    _isApprove = true;
                    bgwSave.RunWorkerAsync();
                }
                else
                {
                    this.ShowError("Proses persetujuan data pembelian gagal!");
                }
            }
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            if (!bgwSave.IsBusy)
            {
                MethodBase.GetCurrentMethod().Info("Reject Purchasing's changes");
                FormHelpers.CurrentMainForm.UpdateStatusInformation("Proses penolakan data pembelian...", false);
                _isApprove = false;
                bgwSave.RunWorkerAsync();
            }
        }

        private void bgwSave_DoWork(object sender, DoWorkEventArgs e)
        {
            if (_isApprove)
            {
                try
                {
                    _presenter.Approve();
                }
                catch (Exception ex)
                {
                    MethodBase.GetCurrentMethod().Fatal("An error occured while trying to approve purchasing in supplier: '" + SelectedPurchasing.SupplierId + "'" + "at date :'" + SelectedPurchasing.Date + "'", ex);
                    e.Result = ex;
                }
            }
            else
            {
                try
                {
                    _presenter.Reject();
                }
                catch (Exception ex)
                {
                    MethodBase.GetCurrentMethod().Fatal("An error occured while trying to approve purchasing in supplier: '" + SelectedPurchasing.SupplierId + "'" + "at date :'" + SelectedPurchasing.Date + "'", ex);
                    e.Result = ex;
                }
            }

        }

        private void bgwSave_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (_isApprove)
            {
                if (e.Result is Exception)
                {
                    this.ShowError("Proses persetujuan data pembelian gagal!");
                }
                else
                {
                    FormHelpers.CurrentMainForm.UpdateStatusInformation("proses persetujuan data pembelian selesai", true);
                    this.Close();
                }
            }
            else
            {
                if (e.Result is Exception)
                {
                    this.ShowError("Proses penolakan data pembelian gagal!");
                }
                else
                {
                    FormHelpers.CurrentMainForm.UpdateStatusInformation("proses penolakan data pembelian selesai", true);
                    this.Close();
                }
            }
        }
    }
}