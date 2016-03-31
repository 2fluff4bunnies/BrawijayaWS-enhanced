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
    public partial class PurchasingEditorForm : BaseEditorForm, IPurchasingEditorView
    {
        private PurchasingEditorPresenter _presenter;

        public PurchasingEditorForm(PurchasingEditorModel model)
        {
            InitializeComponent();
            _presenter = new PurchasingEditorPresenter(this, model);

            // set validation alignment
            valSupplier.SetIconAlignment(cbSupplier, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            valDate.SetIconAlignment(txtDate, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            gvPurchasingDetail.PopupMenuShowing += gvPurchasingDetail_PopupMenuShowing;
            gvPurchasingDetail.FocusedRowChanged += gvPurchasingDetail_FocusedRowChanged;
            cbSparepartGv.EditValueChanged += cbSparepartGv_EditValueChanged;
            gvPurchasingDetail.ShowingEditor += gvPurchasingDetail_ShowingEditor;

            this.Load += PurchasingEditorForm_Load;
        }

        void gvPurchasingDetail_ShowingEditor(object sender, CancelEventArgs e)
        {
            GridView View = sender as GridView;
            if (View.FocusedColumn.FieldName == "SerialNumber" && !this.SelectedPurchasingDetail.IsSpecialSparepart)
            {
                e.Cancel = true;
            }

            if (View.FocusedColumn.FieldName == "Qty" && this.SelectedPurchasingDetail.IsSpecialSparepart)
            {
                e.Cancel = true;
            }
        }

        void cbSparepartGv_EditValueChanged(object sender, EventArgs e)
        {
            DevExpress.XtraEditors.LookUpEdit lookup = sender as DevExpress.XtraEditors.LookUpEdit;
            if (_presenter.IsSparepartSpecial(lookup.EditValue.AsInteger()))
            {
                this.SelectedPurchasingDetail.IsSpecialSparepart = true;
                this.SelectedPurchasingDetail.Qty = 1;
                this.SelectedPurchasingDetail.SparepartId = lookup.EditValue.AsInteger();
            }
            else
            {
                this.SelectedPurchasingDetail.Qty = 0;
                this.SelectedPurchasingDetail.IsSpecialSparepart = false;
            }
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

        private void PurchasingEditorForm_Load(object sender, EventArgs e)
        {
            _presenter.InitFormData();
        }

        public PurchasingViewModel SelectedPurchasing { get; set; }
        public PurchasingDetailViewModel SelectedPurchasingDetail { get; set; }

        #region Field Editor
        public DateTime Date
        {
            get
            {
                return Convert.ToDateTime(txtDate.EditValue);
            }
            set
            {
                txtDate.EditValue = value;
            }
        }

        public decimal TotalPrice
        {
            get
            {
                return SelectedPurchasing.TotalPrice;
            }
            set
            {
                SelectedPurchasing.TotalPrice = value;
            }
        }

        public int SupplierId
        {
            get
            {
                SupplierViewModel selected = cbSupplier.GetSelectedDataRow() as SupplierViewModel;
                if (selected == null) return 0;
                return selected.Id;
            }
            set
            {
                cbSupplier.EditValue = value;
            }
        }
        #endregion

        public List<SupplierViewModel> ListSupplier
        {
            get
            {
                return cbSupplier.Properties.DataSource as List<SupplierViewModel>;
            }
            set
            {
                cbSupplier.Properties.DataSource = value;
            }
        }

        public List<SparepartViewModel> ListSparepart
        {
            get
            {
                return cbSparepartGv.DataSource as List<SparepartViewModel>;
            }
            set
            {
                cbSparepartGv.DataSource = value;
            }
        }

        public List<PurchasingDetailViewModel> ListPurchasingDetail
        {
            get
            {
                return bsDetails.DataSource as List<PurchasingDetailViewModel>;
            }
            set
            {
                if (InvokeRequired)
                {
                    this.Invoke(new MethodInvoker(delegate
                    {
                        bsDetails.DataSource = value;
                        gridPurchasingDetail.DataSource = bsDetails;
                        gvPurchasingDetail.BestFitColumns();
                    }));
                }
                else
                {
                    bsDetails.DataSource = value;
                    gridPurchasingDetail.DataSource = bsDetails;
                    gvPurchasingDetail.BestFitColumns();
                }
            }
        }

        protected override void ExecuteSave()
        {
            if (!bgwSave.IsBusy)
            {
                List<PurchasingDetailViewModel> missingSerialNumber = new List<PurchasingDetailViewModel>();

                List<string> duplicatedSerialNumber = ListPurchasingDetail.GroupBy(x => x.SerialNumber)
                        .Where(group => group.Count() > 1)
                        .Select(group => group.Key).ToList();

                bool isValid = false;
                if (ListPurchasingDetail != null && ListPurchasingDetail.Count > 0)
                {
                    int rowGvPurchasingDetailNotValid = 0;
                    rowGvPurchasingDetailNotValid = ListPurchasingDetail.Where(i => i.SparepartId == 0 || i.Qty == 0 || i.Price == 0).Count();
                    if (valSupplier.Validate() && valDate.Validate() && rowGvPurchasingDetailNotValid == 0)
                    {
                        foreach (var item in this.ListPurchasingDetail)
                        {
                            if (item.IsSpecialSparepart && string.IsNullOrEmpty(item.SerialNumber))
                            {
                                missingSerialNumber.Add(item);
                            }


                        }
                        if (missingSerialNumber.Count == 0 && duplicatedSerialNumber.Count == 0)
                        {
                            isValid = true;
                        }
                    }
                }

                if (isValid)
                {
                    MethodBase.GetCurrentMethod().Info("Save Purchasing's changes");
                    FormHelpers.CurrentMainForm.UpdateStatusInformation("Proses penyimpanan data pembelian...", false);
                    bgwSave.RunWorkerAsync();
                }
                else
                {
                    if (missingSerialNumber.Count > 0 || duplicatedSerialNumber.Count > 0 && !string.IsNullOrEmpty(duplicatedSerialNumber[0]))
                    {
                        string message = "";
                        string duplicate = "";

                        if (missingSerialNumber.Count > 0)
                        {
                            message = "Terdapat sparepart spesial yang belum memiliki serial number";
                        }

                        if (duplicatedSerialNumber.Count > 0 && !string.IsNullOrEmpty(duplicatedSerialNumber[0]))
                        {
                            foreach (var item in duplicatedSerialNumber)
                            {
                                if (!string.IsNullOrEmpty(item))
                                {
                                    duplicate = duplicate + item + "\n";
                                }
                            }

                            duplicate = "Terdapat nomor seri sama : " + duplicate;

                        }

                        this.ShowWarning(message + "\n" + duplicate);
                        FormHelpers.CurrentMainForm.UpdateStatusInformation("simpan data pembelian gagal", true);
                    }
                    else
                    {
                        this.ShowError("Proses simpan data pembelian gagal!");
                        FormHelpers.CurrentMainForm.UpdateStatusInformation("simpan data pembelian gagal", true);
                    }
                }
            }
        }

        private void bgwSave_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                _presenter.SaveChanges();
            }
            catch (Exception ex)
            {
                MethodBase.GetCurrentMethod().Fatal("An error occured while trying to save purchasing in supplier: '" + SelectedPurchasing.SupplierId + "'" + "at date :'" + SelectedPurchasing.Date + "'", ex);
                e.Result = ex;
            }

        }

        private void bgwSave_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Result is Exception)
            {
                this.ShowError("Proses simpan data pembelian gagal!");
                FormHelpers.CurrentMainForm.UpdateStatusInformation("simpan data pembelian gagal", true);
            }
            else
            {
                FormHelpers.CurrentMainForm.UpdateStatusInformation("simpan data pembelian selesai", true);
                this.Close();
            }
        }

        private void btnAddSparepart_Click(object sender, EventArgs e)
        {
            gvPurchasingDetail.AddNewRow();
        }

        private void gvPurchasingDetail_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            gvPurchasingDetail.SetRowCellValue(e.RowHandle, "Qty", 0);
            gvPurchasingDetail.SetRowCellValue(e.RowHandle, "Price", 0);
        }

        private void deleteSparepartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gvPurchasingDetail.DeleteSelectedRows();
        }

        private void viewSparepartDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SelectedPurchasingDetail != null)
            {
                SparepartDetailListForm editor = Bootstrapper.Resolve<SparepartDetailListForm>();
                SparepartViewModel sparepart = ListSparepart.Where(c => c.Id == SelectedPurchasingDetail.SparepartId).FirstOrDefault();
                editor.SelectedSparepart = sparepart;
                editor.SelectedStatus = (int)DbConstant.SparepartDetailDataStatus.NotVerified;
                editor.PurchasingDetailID = SelectedPurchasingDetail.Id;
                editor.ShowDialog(this);
            }
        }
    }
}