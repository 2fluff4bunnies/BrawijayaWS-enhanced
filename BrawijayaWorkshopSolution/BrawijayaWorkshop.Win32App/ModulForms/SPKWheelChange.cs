using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BrawijayaWorkshop.View;
using BrawijayaWorkshop.SharedObject.ViewModels;
using BrawijayaWorkshop.Presenter;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.Utils;

namespace BrawijayaWorkshop.Win32App.ModulForms
{
    public partial class SPKWheelChange : BaseEditorForm, ISPKWheelChangeView
    {
        private SPKWheelChangePresenter _presenter;
        private List<SpecialSparepartDetailViewModel> _wheelDetailChanged;

        public SPKWheelChange(SPKEditorModel model)
        {
            InitializeComponent();
            this._presenter = new SPKWheelChangePresenter(this, model);
            this.Load += SPKWheelChange_Load;

            this.gvVehicleWheel.FocusedRowChanged += gvVehicleWheel_FocusedRowChanged;
            _wheelDetailChanged = new List<SpecialSparepartDetailViewModel>();
        }

        void gvVehicleWheel_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            //ClearSelection();

            VehicleWheelViewModel vw = gvVehicleWheel.GetRow(e.FocusedRowHandle) as VehicleWheelViewModel;
            this.SelectedVehicleWheel = vw;
            this.SelectedWheelName = vw.WheelDetail.SparepartDetail.Sparepart.Name;
            this.SelectedWHeelSerialNumber = vw.WheelDetail.SerialNumber;
            this.SelectedWHeelSparepartCode = vw.WheelDetail.SparepartDetail.Sparepart.Code;

            this.txtChangedCode.EditValue = string.Empty;
            this.lookUpChangedWheel.EditValue = vw.SparepartId;
            this.lookUpChangedSerialNumber.EditValue = vw.ReplaceWithWheelDetailId;
            this.ckeUsedGoodRetrieved.Checked = vw.IsUsedWheelRetrieved;
            this.Price = vw.Price;

        }

        void SPKWheelChange_Load(object sender, EventArgs e)
        {
            _presenter.InitFormData();
        }

        #region Field Editor

        public SPKViewModel SelectedSPK { get; set; }


        public List<VehicleWheelViewModel> VehicleWheelList
        {
            get
            {
                return gridVehicleWheel.DataSource as List<VehicleWheelViewModel>;
            }
            set
            {
                if (InvokeRequired)
                {
                    this.Invoke(new MethodInvoker(delegate { gridVehicleWheel.DataSource = value; gvVehicleWheel.BestFitColumns(); }));
                }
                else
                {
                    gridVehicleWheel.DataSource = value;
                    gvVehicleWheel.BestFitColumns();
                }
            }
        }

        public List<SpecialSparepartDetailViewModel> WheelDetailList
        {
            get
            {
                return lookUpChangedSerialNumber.Properties.DataSource as List<SpecialSparepartDetailViewModel>;
            }
            set
            {
                lookUpChangedSerialNumber.Properties.DataSource = value;
            }
        }

        public List<SparepartViewModel> SparepartWheelLookupList
        {
            get
            {
                return lookUpChangedWheel.Properties.DataSource as List<SparepartViewModel>;
            }
            set
            {
                lookUpChangedWheel.Properties.DataSource = value;
            }
        }


        public string SelectedWheelName
        {
            get
            {
                return txtSelectedWheelName.EditValue.ToString();
            }
            set
            {
                txtSelectedWheelName.EditValue = value;
            }
        }

        public string SelectedWHeelSerialNumber
        {
            get
            {
                return txtSelectedWheelSerial.EditValue.ToString();
            }
            set
            {
                txtSelectedWheelSerial.EditValue = value;
            }
        }

        public string SelectedWHeelSparepartCode
        {
            get
            {
                return txtSelectedWheelCode.EditValue.ToString();
            }
            set
            {
                txtSelectedWheelCode.EditValue = value;
            }
        }

        public decimal Price
        {
            get
            {
                return txtPrice.EditValue.AsDecimal();
            }
            set
            {

                txtPrice.EditValue = value;
            }
        }

        public SparepartViewModel SelectedSparepartWheel { get; set; }
        public VehicleWheelViewModel SelectedVehicleWheel { get; set; }
        public SpecialSparepartDetailViewModel SelectedWheelDetailToChange { get; set; }
        public List<SpecialSparepartDetailViewModel> WheelDetailChangedList { get; set; }

        public int VehicleId { get; set; }
        #endregion

        protected override void ExecuteSave()
        {
            this.Close();
        }

        private void cmsVehicleWheelItemReset_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelChange_Click(object sender, EventArgs e)
        {
            VehicleWheelViewModel vwChanged = VehicleWheelList.Where(vw => vw.Id == this.SelectedVehicleWheel.Id).FirstOrDefault();

            if (vwChanged != null)
            {
                SpecialSparepartDetailViewModel wheelDetail = lookUpChangedSerialNumber.GetSelectedDataRow() as SpecialSparepartDetailViewModel;

                if (wheelDetail != null)
                {
                    _wheelDetailChanged.Remove(wheelDetail);

                    vwChanged.ReplaceWithWheelDetailName = string.Empty;
                    vwChanged.ReplaceWithWheelDetailId = 0;
                    vwChanged.ReplaceWithWheelDetailSerialNumber = string.Empty;
                    vwChanged.IsUsedWheelRetrieved = false;
                    vwChanged.Price = 0;
                    vwChanged.SparepartId = 0;

                    ClearSelection();
                }
            }

            gvVehicleWheel.RefreshData();
        }

        private void btnConfirmChange_Click(object sender, EventArgs e)
        {
            if (this.SelectedVehicleWheel != null)
            {
                if (this.SelectedVehicleWheel.ReplaceWithWheelDetailId > 0)
                {
                    SpecialSparepartDetailViewModel vw = _wheelDetailChanged.Where(wdc => wdc.Id == this.SelectedVehicleWheel.ReplaceWithWheelDetailId).FirstOrDefault();

                    if (vw != null)
                    {
                        _wheelDetailChanged.Remove(vw);
                    }

                }

                SparepartViewModel sparepartWheel = lookUpChangedWheel.GetSelectedDataRow() as SparepartViewModel;
                SpecialSparepartDetailViewModel wheelDetail = lookUpChangedSerialNumber.GetSelectedDataRow() as SpecialSparepartDetailViewModel;
                if (sparepartWheel != null && wheelDetail != null)
                {
                    this.SelectedVehicleWheel.ReplaceWithWheelDetailName = sparepartWheel.Name;
                    this.SelectedVehicleWheel.SparepartId = sparepartWheel.Id;
                    this.SelectedVehicleWheel.ReplaceWithWheelDetailId = wheelDetail.Id;
                    this.SelectedVehicleWheel.ReplaceWithWheelDetailSerialNumber = wheelDetail.SerialNumber;
                    this.SelectedVehicleWheel.IsUsedWheelRetrieved = ckeUsedGoodRetrieved.Checked;
                    this.SelectedVehicleWheel.Price = this.Price;

                    _wheelDetailChanged.Add(wheelDetail);
                }
            }

            gvVehicleWheel.RefreshData();
        }

        private void lookUpChangedWheel_EditValueChanged(object sender, EventArgs e)
        {
            _presenter.LoadWheelDetail(lookUpChangedWheel.EditValue.AsInteger());
        }

        private void lookUpChangedSerialNumber_EditValueChanged(object sender, EventArgs e)
        {
            LookUpEdit lookup = sender as LookUpEdit;
            SpecialSparepartDetailViewModel wheelDetail = lookup.GetSelectedDataRow() as SpecialSparepartDetailViewModel;

            if (wheelDetail != null)
            {
                if (wheelDetail.SparepartDetail.PurchasingDetailId > 0)
                {
                    this.Price = wheelDetail.SparepartDetail.PurchasingDetail.Price;
                }
                else if (wheelDetail.SparepartDetail.SparepartManualTransactionId > 0)
                {
                    this.Price = wheelDetail.SparepartDetail.SparepartManualTransaction.Price;
                }
                this.txtChangedCode.EditValue = wheelDetail.SparepartDetail.Sparepart.Code;
            }
        }

        private void lookUpChangedWheel_Enter(object sender, EventArgs e)
        {

        }

        private void lookUpChangedSerialNumber_Enter(object sender, EventArgs e)
        {
            if (this.WheelDetailList != null)
            {
                var result = WheelDetailList.Where(wd => !_wheelDetailChanged.Any(wdc => wdc.Id == wd.Id && wdc.Id != this.SelectedVehicleWheel.ReplaceWithWheelDetailId)).ToList();
                this.WheelDetailList = result;
            }
            else
            {
                this.WheelDetailList = new List<SpecialSparepartDetailViewModel>();
            }

            this.lookUpChangedSerialNumber.Refresh();
        }

        private void ClearSelection()
        {
            this.lookUpChangedWheel.EditValue = null;
            this.lookUpChangedSerialNumber.EditValue = null;
            this.ckeUsedGoodRetrieved.Checked = false;
            this.txtChangedCode.EditValue = string.Empty;
            this.Price = 0;
        }

    }
}