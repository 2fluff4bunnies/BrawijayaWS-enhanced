using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.Presenter;
using BrawijayaWorkshop.View;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BrawijayaWorkshop.Utils;
using System.Reflection;

namespace BrawijayaWorkshop.Win32App.ModulForms
{
    public partial class SPKEditorForm : BaseEditorForm, ISPKEditorView
    {
        private SPKEditorPresenter _presenter;

        public SPKEditorForm(SPKEditorModel model)
        {
            InitializeComponent();
            _presenter = new SPKEditorPresenter(this, model);

            lookUpSparepart.MaskBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            lookUpSparepart.MaskBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            lookUpMechanic.MaskBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            lookUpMechanic.MaskBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;

            txtQty.ReadOnly = true;
            txtFee.ReadOnly = true;
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

        public List<SPKDetailMechanic> MechanicList
        {
            get
            {
                return gridMechanic.DataSource as List<SPKDetailMechanic>;
            }
            set
            {
                if (InvokeRequired)
                {
                    this.Invoke(new MethodInvoker(delegate { gridMechanic.DataSource = value; gvMechanic.BestFitColumns(); }));
                }
                else
                {
                    gridMechanic.DataSource = value;
                    gvMechanic.BestFitColumns();
                }
            }
        }

        public List<SPKDetailSparepart> SparepartList
        {

            get
            {
                return gridSparepart.DataSource as List<SPKDetailSparepart>;
            }
            set
            {
                if (InvokeRequired)
                {
                    this.Invoke(new MethodInvoker(delegate { gridSparepart.DataSource = value; gvSparepart.BestFitColumns(); }));
                }
                else
                {
                    gridSparepart.DataSource = value;
                    gvSparepart.BestFitColumns();
                }
            }
        }

        public List<SPKDetailSparepartDetail> SparepartDetailList { get; set; }


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

        public int SparepartId {
            get
            {
                return lookUpSparepart.EditValue.AsInteger();
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
                return lookUpMechanic.EditValue.AsInteger();
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
        #endregion

        #region Methods
        protected override void ExecuteSave()
        {
            if (valCategory.Validate() && valVehicle.Validate() && valDueDate.Validate() && SparepartList.Count > 0 && MechanicList.Count > 0)
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
            SparepartList.Add(new SPKDetailSparepart
            {
                SparepartId = SparepartId,
                quantity = SparepartQty
            });
        }

        private void btnAddMechanic_Click(object sender, EventArgs e)
        {
            MechanicList.Add(new SPKDetailMechanic
            {
                MechanicId = MechanicId,
                Fee = MechanicFee
            });
        }

        #endregion

        private void lookUpSparepart_KeyUp(object sender, KeyEventArgs e)
        {
            if (lookUpSparepart.SelectionLength > 3)
            {
                AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
                foreach (var item in _presenter.loadSparepart())
                {
                    collection.Add(item.Name);
                }
                lookUpSparepart.MaskBox.AutoCompleteCustomSource = collection;
            }
        }

        private void lookUpMechanic_KeyUp(object sender, KeyEventArgs e)
        {
            if (lookUpMechanic.SelectionLength > 3)
            {
                AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
                foreach (var item in _presenter.loadMechanic())
                {
                    collection.Add(item.Name);
                }
                lookUpMechanic.MaskBox.AutoCompleteCustomSource = collection;
            }
        }

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
            MechanicList.Remove(mechanicToRemove);
        }

        private void cmsEditDataSparepart_Click(object sender, EventArgs e)
        {
            SPKDetailSparepart sparepartToEdit = gvSparepart.GetFocusedRow() as SPKDetailSparepart;
            lookUpSparepart.Text = sparepartToEdit.Sparepart.Name;
            lookUpSparepart.EditValue = sparepartToEdit.Sparepart.Id;
            txtFee.Text = sparepartToEdit.quantity.ToString();
        }

        private void cmsDeleteDataSparepart_Click(object sender, EventArgs e)
        {
            SPKDetailSparepart SparepartToRemove = gvSparepart.GetFocusedRow() as SPKDetailSparepart;
            SparepartList.Remove(SparepartToRemove);
        }
    }
}