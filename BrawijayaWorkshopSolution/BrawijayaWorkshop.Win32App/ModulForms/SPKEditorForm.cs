using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.Presenter;
using BrawijayaWorkshop.View;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BrawijayaWorkshop.Utils;
using System.Reflection;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace BrawijayaWorkshop.Win32App.ModulForms
{
    public partial class SPKEditorForm : BaseEditorForm, ISPKEditorView
    {
        private SPKEditorPresenter _presenter;

        public SPKEditorForm(SPKEditorModel model)
        {
            InitializeComponent();
            _presenter = new SPKEditorPresenter(this, model);

            //txtQty.ReadOnly = true;
            //txtFee.ReadOnly = true;

            this.Load += SPKEditorForm_Load;

            gvSparepart.PopupMenuShowing += gvSparepart_PopupMenuShowing;
            gvSparepart.FocusedRowChanged += gvSparepart_FocusedRowChanged;

            gvMechanic.PopupMenuShowing += gvMechanic_PopupMenuShowing;
            gvMechanic.FocusedRowChanged += gvMechanic_FocusedRowChanged;

            SPKSparepartList = new List<SPKDetailSparepart>();
            SPKMechanicList = new List<SPKDetailMechanic>();
        }

        void gvMechanic_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            this.SelectedMechanic = gvMechanic.GetFocusedRow() as Mechanic;
        }

        void gvMechanic_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            GridView view = (GridView)sender;
            GridHitInfo hitInfo = view.CalcHitInfo(e.Point);
            if (hitInfo.InRow)
            {
                view.FocusedRowHandle = hitInfo.RowHandle;
                cmsMechanicEditor.Show(view.GridControl, e.Point);
            }
        }

        void gvSparepart_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            this.SelectedSparepart = gvSparepart.GetFocusedRow() as Sparepart;
        }

        void gvSparepart_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            GridView view = (GridView)sender;
            GridHitInfo hitInfo = view.CalcHitInfo(e.Point);
            if (hitInfo.InRow)
            {
                view.FocusedRowHandle = hitInfo.RowHandle;
                cmsSparepartEditor.Show(view.GridControl, e.Point);
            }
        }

        void SPKEditorForm_Load(object sender, EventArgs e)
        {
            _presenter.InitFormData();
        }

        #region Field Editor

        public SPK SelectedSPK { get; set; }

        public SPK ParentSPK { get; set; }

        public List<Vehicle> VehicleDropdownList
        {
            get
            {
                return LookUpVehicle.Properties.DataSource as List<Vehicle>;
            }
            set
            {
                LookUpVehicle.Properties.DataSource = value;
            }
        }

        public List<Reference> CategoryDropdownList
        {
            get
            {
                return lookUpCategory.Properties.DataSource as List<Reference>;
            }
            set
            {
                lookUpCategory.Properties.DataSource = value;
            }
        }

        public List<SPKDetailMechanic> SPKMechanicList
        {
            get
            {
                return gcMechanic.DataSource as List<SPKDetailMechanic>;
            }
            set
            {
                if (InvokeRequired)
                {
                    this.Invoke(new MethodInvoker(delegate { gcMechanic.DataSource = value; gvMechanic.BestFitColumns(); }));
                }
                else
                {
                    gcMechanic.DataSource = value;
                    gvMechanic.BestFitColumns();
                }
            }
        }

        public List<SPKDetailSparepart> SPKSparepartList
        {

            get
            {
                return gcSparepart.DataSource as List<SPKDetailSparepart>;
            }
            set
            {
                if (InvokeRequired)
                {
                    this.Invoke(new MethodInvoker(delegate { gcSparepart.DataSource = value; gvSparepart.BestFitColumns(); }));
                }
                else
                {
                    gcSparepart.DataSource = value;
                    gvSparepart.BestFitColumns();
                }
            }
        }

        public List<SPKDetailSparepartDetail> SPKSparepartDetailList { get; set; }


        public string Code { get; set; }

        public DateTime DueDate
        {
            get
            {
                return dtpDueDate.Text.AsDateTime();
            }
            set
            {
                dtpDueDate.Text = value.ToString();
            }
        }

        public int VehicleId
        {
            get
            {
                return LookUpVehicle.EditValue.AsInteger();
            }
            set
            {
                LookUpVehicle.EditValue = value;
            }
        }

        public int CategoryId
        {
            get
            {
                return lookUpCategory.EditValue.AsInteger();
            }
            set
            {
                lookUpCategory.EditValue = value;
            }
        }

        public int SparepartId
        {
            get
            {
                Sparepart selected = lookUpSparepart.GetSelectedDataRow() as Sparepart;
                if (selected == null) return 0;
                return selected.Id;
            }
            set
            {
                lookUpSparepart.EditValue = value;
            }
        }

        public string SparepartName
        {
            get
            {
                return lookUpSparepart.Text;
            }
            set
            {
                lookUpSparepart.Text = value;
            }
        }

        public int SparepartQty
        {
            get
            {
                return txtQty.Text.AsInteger();
            }
            set
            {
                txtQty.Text = value.ToString();
            }
        }

        public int MechanicId
        {
            get
            {
                Mechanic selected = lookUpMechanic.GetSelectedDataRow() as Mechanic;
                if (selected == null) return 0;
                return selected.Id;
            }
            set
            {
                lookUpMechanic.EditValue = value;
            }
        }

        public string MechanicName
        {
            get
            {
                return lookUpMechanic.Text;
            }
            set
            {
                lookUpMechanic.Text = value;
            }
        }

        public decimal MechanicFee
        {
            get
            {
                return txtFee.Text.AsDecimal();
            }
            set
            {
                txtFee.Text = value.ToString();
            }
        }

        public List<Sparepart> SparepartLookupList
        {
            get
            {
                return lookUpSparepart.Properties.DataSource as List<Sparepart>;
            }
            set
            {
                lookUpSparepart.Properties.DataSource = value;
            }

        }
        public List<Mechanic> MechanicLookupList
        {
            get
            {
                return lookUpMechanic.Properties.DataSource as List<Mechanic>;
            }
            set
            {
                lookUpMechanic.Properties.DataSource = value;
            }
        }

        public Mechanic MechanicToInsert
        {
            get
            {
                return lookUpMechanic.GetSelectedDataRow() as Mechanic;
            }
        }

        public Sparepart SparepartToInsert
        {
            get
            {
                return lookUpSparepart.GetSelectedDataRow() as Sparepart;
            }
        }

        public Sparepart SelectedSparepart { get; set; }
        public Mechanic SelectedMechanic { get; set; }
        #endregion

        #region Methods
        protected override void ExecuteSave()
        {
            if (valCategory.Validate() && valVehicle.Validate() && valDueDate.Validate() && SPKSparepartList.Count > 0 && SPKMechanicList.Count > 0)
            {
                try
                {
                    MethodBase.GetCurrentMethod().Info("Save SPK's changes");
                    _presenter.SaveChanges();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MethodBase.GetCurrentMethod().Fatal("An error occored while trying to save SPK", ex);
                    this.ShowError("Proses simpan SPK gagal!");
                }
            }
        }

        private void btnAddSparepart_Click(object sender, EventArgs e)
        {
            _presenter.populateSparepartDetail();

            decimal totalPrice = 0;

            foreach (var item in SPKSparepartDetailList)
            {
                totalPrice = totalPrice + item.SparepartDetail.PurchasingDetail.Price;
            }

            SPKSparepartList.Add(new SPKDetailSparepart
            {
                Sparepart = SparepartToInsert,
                SparepartId = SparepartId,
                TotalQuantity = SparepartQty,
                TotalPrice = totalPrice
            });

            gcSparepart.DataSource = SPKSparepartList;
            gvSparepart.BestFitColumns();

            ClearSparepart();

        }

        public void ClearSparepart()
        {
            this.SparepartQty = 0;
            this.SparepartName = string.Empty;
        }

        private void btnAddMechanic_Click(object sender, EventArgs e)
        {
            SPKMechanicList.Add(new SPKDetailMechanic
            {
                Mechanic = MechanicToInsert,
                MechanicId = MechanicId,
                Fee = MechanicFee
            });

            gcMechanic.DataSource = SPKMechanicList;
            gvMechanic.BestFitColumns();

            ClearMechanic();
        }

        public void ClearMechanic()
        {
            this.MechanicFee = 0;
            this.MechanicName = string.Empty;
        }

        #endregion

        private void editDataMechanic_Click(object sender, EventArgs e)
        {
            SPKDetailMechanic mechanicToEdit = gvMechanic.GetFocusedRow() as SPKDetailMechanic;
            lookUpMechanic.Text = mechanicToEdit.Mechanic.Name;
            lookUpMechanic.EditValue = mechanicToEdit.Mechanic.Id;
            txtFee.Text = mechanicToEdit.Fee.ToString();
        }

        private void cmsDeleteDataMechanic_Click(object sender, EventArgs e)
        {
            SPKDetailMechanic mechanicToRemove = gvMechanic.GetFocusedRow() as SPKDetailMechanic;
            SPKMechanicList.Remove(mechanicToRemove);
        }

        private void cmsEditDataSparepart_Click(object sender, EventArgs e)
        {
            SPKDetailSparepart sparepartToEdit = gvSparepart.GetFocusedRow() as SPKDetailSparepart;
            lookUpSparepart.Text = sparepartToEdit.Sparepart.Name;
            lookUpSparepart.EditValue = sparepartToEdit.Sparepart.Id;
            txtFee.Text = sparepartToEdit.TotalQuantity.ToString();
        }

        private void cmsDeleteDataSparepart_Click(object sender, EventArgs e)
        {
            SPKDetailSparepart SparepartToRemove = gvSparepart.GetFocusedRow() as SPKDetailSparepart;
            SPKSparepartList.Remove(SparepartToRemove);
        }
    }
}