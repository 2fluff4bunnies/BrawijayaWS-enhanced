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
            this.Load += PurchasingEditorForm_Load;
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

        private void PurchasingEditorForm_Load(object sender, EventArgs e)
        {
            _presenter.InitFormData();
        }

        public Purchasing SelectedPurchasing { get; set; }
        public PurchasingDetail SelectedPurchasingDetail { get; set; }

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
                Supplier selected = cbSupplier.GetSelectedDataRow() as Supplier;
                if (selected == null) return 0;
                return selected.Id;
            }
            set
            {
                cbSupplier.EditValue = value;
            }
        }
        #endregion

        public List<Supplier> ListSupplier
        {
            get
            {
                return cbSupplier.Properties.DataSource as List<Supplier>;
            }
            set
            {
                cbSupplier.Properties.DataSource = value;
            }
        }

        public List<Sparepart> ListSparepart
        {
            get
            {
                return cbSparepartGv.DataSource as List<Sparepart>;
            }
            set
            {
                cbSparepartGv.DataSource = value;
            }
        }

        public List<PurchasingDetail> ListPurchasingDetail
        {
            get
            {
                //return gridPurchasingDetail.DataSource as List<PurchasingDetail>;
                return bsDetails.DataSource as List<PurchasingDetail>;
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
            if (valSupplier.Validate() && valDate.Validate())
            {
                try
                {
                    MethodBase.GetCurrentMethod().Info("Save Purchasing's changes");
                    _presenter.SaveChanges();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MethodBase.GetCurrentMethod().Fatal("An error occured while trying to save purchasing in supplier: '" + SelectedPurchasing.SupplierId + "'" + "at date :'" + SelectedPurchasing.Date + "'", ex);
                    this.ShowError("Proses simpan data customer: '" + SelectedPurchasing.SupplierId + "' gagal!");
                }
            }
        }

        private void btnAddSparepart_Click(object sender, EventArgs e)
        {
            //PurchasingDetail newItem = ListPurchasingDetail.FirstOrDefault();
            //newItem.Id = 0;
            //newItem.Price = 0;
            //newItem.Qty = 0;
            //newItem.Sparepart = ListSparepart.FirstOrDefault();

            //ListPurchasingDetail.Add(newItem);
            //gridPurchasingDetail.DataSource = ListPurchasingDetail;
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
    }
}