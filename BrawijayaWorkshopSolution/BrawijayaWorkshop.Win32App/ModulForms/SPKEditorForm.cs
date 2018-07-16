using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.Presenter;
using BrawijayaWorkshop.SharedObject.ViewModels;
using BrawijayaWorkshop.Utils;
using BrawijayaWorkshop.View;
using BrawijayaWorkshop.Win32App.PrintItems;
using BrawijayaWorkshop.Win32App.Properties;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace BrawijayaWorkshop.Win32App.ModulForms
{
    public partial class SPKEditorForm : BaseEditorForm, ISPKEditorView
    {
        private DateTime _today;
        //private List<string> _availableMechanic;
        //public zkemkeeper.CZKEMClass axCZKEM1 = new zkemkeeper.CZKEMClass();
        //private bool _isFingerprintConnected = false;

        private SPKEditorPresenter _presenter;

        public string FingerprintIP { get; set; }

        public string FingerpringPort { get; set; }

        public bool IsSPKSales { get; set; }

        public bool IsSaveComplete { get; set; }

        public SPKEditorForm(SPKEditorModel model)
        {
            InitializeComponent();
            _presenter = new SPKEditorPresenter(this, model);
            //_availableMechanic = new List<string>();
            _today = DateTime.Today;

            dtpDueDate.EditValue = _today;

            valCategory.SetIconAlignment(lookUpCategory, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            valVehicle.SetIconAlignment(LookUpVehicle, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            valDueDate.SetIconAlignment(dtpDueDate, System.Windows.Forms.ErrorIconAlignment.MiddleRight);

            this.Load += SPKEditorForm_Load;

            gvSparepart.PopupMenuShowing += gvSparepart_PopupMenuShowing;
            gvSparepart.FocusedRowChanged += gvSparepart_FocusedRowChanged;

            gvVehicleWheel.PopupMenuShowing += gvVehicleWheel_PopupMenuShowing;
            gvVehicleWheel.FocusedRowChanged += gvVehicleWheel_FocusedRowChanged;

            SPKSparepartList = new List<SPKDetailSparepartViewModel>();
            SPKSparepartDetailList = new List<SPKDetailSparepartDetailViewModel>();
            RemovedWHeelDetailList = new List<SpecialSparepartDetailViewModel>();

            this.TotalSparepartPrice = 0;
            this.ContractWorkFee = 0;
            this.CostEstimation = 0;

            txtContractWorkFee.Enabled = false;
            txtContractor.Enabled = false;
            splitContainerMain.Panel2.Enabled = false;
            gridVehicleWheel.Enabled = false;
            ckeIsReturnRequired.Enabled = false;
            lookUpSerialNumber.Enabled = false;
            txtTotalSparepartPrice.ReadOnly = true;

            //column setting for lookup specialSparepart in grid
            LookUpColumnInfoCollection wheelDetailColl = lookupWheelDetailGv.Columns;

            wheelDetailColl.Add(new LookUpColumnInfo("SerialNumber", 0, "Nomor Seri"));
            lookupWheelDetailGv.BestFitMode = BestFitMode.BestFitResizePopup;
            lookupWheelDetailGv.SearchMode = SearchMode.AutoComplete;
            lookupWheelDetailGv.AutoSearchColumnIndex = 1;

            LookUpColumnInfoCollection SparepartWheelColl = lookUpSparepartWheelGv.Columns;

            SparepartWheelColl.Add(new LookUpColumnInfo("Name", 0, "Jenis Ban"));
            lookUpSparepartWheelGv.BestFitMode = BestFitMode.BestFitResizePopup;
            lookUpSparepartWheelGv.SearchMode = SearchMode.AutoComplete;
            lookUpSparepartWheelGv.AutoSearchColumnIndex = 1;

            //Vehicle wheel handler
            ckeIsUsedWheelRetrieved.CheckedChanged += ckeIsUsedWheelRetrieved_CheckedChanged;
            gvVehicleWheel.ShowingEditor += gvVehicleWheel_ShowingEditor;
            lookupWheelDetailGv.EditValueChanged += lookupWheelDetailGv_EditValueChanged;
            lookupWheelDetailGv.EditValueChanging += lookupWheelDetailGv_EditValueChanging;
        }

        #region Field Editor
        public DateTime Date
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

        public SPKViewModel SelectedSPK { get; set; }
        public SPKViewModel ParentSPK { get; set; }
        public List<SPKDetailSparepartDetailViewModel> SPKSparepartDetailList { get; set; }
        public string Code { get; set; }
        public SparepartViewModel SelectedSparepart { get; set; }
        public MechanicViewModel SelectedMechanic { get; set; }
        public decimal RepairThreshold { get; set; }
        public decimal ServiceThreshold { get; set; }
        public decimal ContractThreshold { get; set; }
        public bool IsNeedApproval { get; set; }
        public bool IsUsedSparepartRequired { get; set; }
        public List<SpecialSparepartDetailViewModel> RemovedWHeelDetailList { get; set; }
        public string MechanicDesc { get; set; }

        public decimal TotalSparepartPrice
        {
            get
            {
                return txtTotalSparepartPrice.EditValue.AsDecimal();
            }
            set
            {

                txtTotalSparepartPrice.EditValue = value;
            }
        }

        public List<VehicleViewModel> VehicleDropdownList
        {
            get
            {
                return LookUpVehicle.Properties.DataSource as List<VehicleViewModel>;
            }
            set
            {
                LookUpVehicle.Properties.DataSource = value;
            }
        }

        public VehicleViewModel SelectedVehicle
        {
            get
            {
                return LookUpVehicle.GetSelectedDataRow() as VehicleViewModel;
            }
        }

        public List<ReferenceViewModel> CategoryDropdownList
        {
            get
            {
                return lookUpCategory.Properties.DataSource as List<ReferenceViewModel>;
            }
            set
            {
                lookUpCategory.Properties.DataSource = value;
            }
        }

        public List<SPKDetailSparepartViewModel> SPKSparepartList
        {

            get
            {
                return gcSparepart.DataSource as List<SPKDetailSparepartViewModel>;
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

        public DateTime DueDate
        {
            get
            {
                return dtpDueDate.EditValue.AsDateTime();
            }
            set
            {
                dtpDueDate.EditValue = value;
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
                SparepartViewModel selected = lookUpSparepart.GetSelectedDataRow() as SparepartViewModel;
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

        public List<SparepartViewModel> SparepartLookupList
        {
            get
            {
                return lookUpSparepart.Properties.DataSource as List<SparepartViewModel>;
            }
            set
            {
                lookUpSparepart.Properties.DataSource = value;
            }
        }

        public SparepartViewModel SparepartToInsert
        {
            get
            {
                return lookUpSparepart.GetSelectedDataRow() as SparepartViewModel;
            }

        }

        public string Description
        {
            get
            {
                return memoDescription.Text;
            }

            set
            {
                memoDescription.Text = value;
            }
        }

        public bool IsUsedSparepartRetrieved
        {
            get
            {
                return ckeIsReturnRequired.Checked;
            }
            set
            {
                ckeIsReturnRequired.Checked = value;
            }
        }
        public SPKDetailSparepartViewModel LastUsageRecord { get; set; }

        public List<SpecialSparepartDetailViewModel> SSDetailList
        {
            get
            {
                return lookUpSerialNumber.Properties.DataSource as List<SpecialSparepartDetailViewModel>;
            }
            set
            {
                lookUpSerialNumber.Properties.DataSource = value;
            }
        }

        public int SSDetailId
        {
            get
            {
                return lookUpSerialNumber.EditValue.AsInteger();
            }
            set
            {
                lookUpSerialNumber.EditValue = value;
            }
        }

        public string SparepartLastUsageDate
        {
            get
            {
                return lblValLastUsageDate.Text;
            }
            set
            {
                lblValLastUsageDate.Text = value;
            }
        }

        public string SparepartLastUsageQty
        {
            get
            {
                return lblValLastUsageQty.Text;
            }
            set
            {
                lblValLastUsageQty.Text = value;
            }
        }

        public List<VehicleWheelViewModel> VehicleWheelList
        {
            get
            {
                return bsVehicleWheel.DataSource as List<VehicleWheelViewModel>;
            }
            set
            {
                if (InvokeRequired)
                {
                    this.Invoke(new MethodInvoker(delegate
                    {
                        bsVehicleWheel.DataSource = value;
                        gridVehicleWheel.DataSource = bsVehicleWheel;
                        gvVehicleWheel.BestFitColumns();
                    }));
                }
                else
                {
                    bsVehicleWheel.DataSource = value;
                    gridVehicleWheel.DataSource = bsVehicleWheel;
                    gvVehicleWheel.BestFitColumns();
                }
            }
        }

        public List<SpecialSparepartDetailViewModel> WheelDetailList
        {
            get
            {
                return lookupWheelDetailGv.DataSource as List<SpecialSparepartDetailViewModel>;
            }
            set
            {
                lookupWheelDetailGv.DataSource = value;
            }
        }

        public List<SparepartViewModel> SparepartWheelLookupList
        {
            get
            {
                return lookUpSparepartWheelGv.DataSource as List<SparepartViewModel>;
            }
            set
            {
                lookUpSparepartWheelGv.DataSource = value;
            }
        }

        public SparepartViewModel SelectedSparepartWheel { get; set; }

        public VehicleWheelViewModel SelectedVehicleWheel { get; set; }

        public SpecialSparepartDetailViewModel SelectedWheelDetailToChange { get; set; }

        public bool isContractWork
        {
            get
            {
                return ckeIsContractWork.Checked;
            }
            set
            {
                ckeIsContractWork.Checked = value;
            }
        }

        public decimal ContractWorkFee
        {
            get
            {
                return txtContractWorkFee.EditValue.AsDecimal();
            }
            set
            {
                txtContractWorkFee.EditValue = value.ToString();
            }
        }

        public string Contractor
        {
            get
            {
                return txtContractor.EditValue.ToString();
            }
            set
            {
                txtContractor.EditValue = value;
            }
        }

        public int Kilometers
        {
            get
            {
                return txtKilometer.EditValue.AsInteger();
            }
            set
            {
                txtKilometer.EditValue = value.ToString();
            }
        }

        public double CostEstimation
        {
            get
            {
                return txtCostEstimation.EditValue.AsDouble();
            }
            set
            {
                txtCostEstimation.EditValue = value.ToString();
            }
        }

        public List<SPKScheduleViewModel> AssignedSchedule { get; set; }
        #endregion

        #region EmailProperties
        public string ApprovalEmailBody { get; set; }

        public string ApprovalEmailFrom { get; set; }

        public string ApprovalEmailTo { get; set; }
        #endregion

        #region Methods
        protected override void ExecuteSave()
        {
            if (!bgwSave.IsBusy)
            {
                if (valCategory.Validate() && valVehicle.Validate() && valDueDate.Validate() && valDate.Validate())
                {
                    MethodBase.GetCurrentMethod().Info("Save SPK's changes");
                    this.IsNeedApproval = ApprovalCheck();
                    bgwSave.RunWorkerAsync();
                }
            }
        }

        private void btnAddSparepart_Click(object sender, EventArgs e)
        {

            if (_presenter.IsUsedSparepartRequired() && !ckeIsReturnRequired.Checked)
            {
                this.ShowWarning("Pastikan barang bekas sudah diterima.");
                return;
            }

            if (SparepartToInsert == null || txtQty.Text == "0" || string.IsNullOrEmpty(txtQty.Text))
            {
                this.ShowWarning("Sparepart atau Jumlah harus diisi.");
                return;
            }

            int duplicateSparepartFound = SPKSparepartList.Where(s => s.Sparepart.Id == SparepartToInsert.Id).Count();

            if (duplicateSparepartFound < 1)
            {
                int pendingRequestSparepart = _presenter.getPendingSparpartQty();

                if (this.SparepartQty + pendingRequestSparepart <= SparepartToInsert.StockQty)
                {
                    _presenter.populateSparepartDetail();

                    decimal totalPrice = 0;

                    foreach (var item in SPKSparepartDetailList)
                    {
                        if (item.PurchasingDetailId > 0)
                        {
                            totalPrice = totalPrice + (item.PurchasingDetail.Price * item.Qty);
                        }
                        else if (item.SparepartManualTransactionId > 0)
                        {
                            totalPrice = totalPrice + (item.SparepartManualTransaction.Price * item.Qty);
                        }
                    }

                    SPKSparepartList.Add(new SPKDetailSparepartViewModel
                    {
                        Sparepart = SparepartToInsert,
                        SparepartId = SparepartId,
                        TotalQuantity = SparepartQty,
                        TotalPrice = totalPrice
                    });

                    RefreshSparepartGrid();
                    CalculateTotalSparepart();
                }
                else
                {
                    this.ShowError(string.Format("Jumlah sparepart yang dimasukkan melebihi stok yang ada! \n Stok yang diminta : {0} \n Permintaan tertunda : {1} \n Stok tersedia : {2}", SparepartQty, pendingRequestSparepart, SparepartToInsert.StockQty));
                }
            }
            else
            {
                this.ShowError("Sparepart yang dimasukkan dalam daftar tidak boleh ada yang sama!");
            }

            ClearSparepart();
        }

        public void ClearSparepart()
        {
            this.lookUpSparepart.EditValue = null;
            this.lookUpSparepart.Text = string.Empty;
            this.SparepartQty = 0;
            this.SparepartName = string.Empty;
            this.ckeIsReturnRequired.Enabled = false;
            this.ckeIsReturnRequired.Checked = false;
            lblValLastUsageDate.Text = "";
            lblValLastUsageQty.Text = "";
        }

        public void CalculateTotalSparepart()
        {
            this.TotalSparepartPrice = 0;

            foreach (var item in SPKSparepartList)
            {
                this.TotalSparepartPrice = this.TotalSparepartPrice + item.TotalPrice;
            }
        }

        public void RefreshSparepartGrid()
        {
            gcSparepart.DataSource = SPKSparepartList;
            gvSparepart.BestFitColumns();
            if (gvSparepart.RowCount > 0)
            {
                gvSparepart.FocusedRowHandle = 0;
            }
        }

        private void cmsDeleteDataSparepart_Click(object sender, EventArgs e)
        {
            List<SPKDetailSparepartViewModel> listCurrent = SPKSparepartList;

            SPKDetailSparepartViewModel SparepartToRemove = gvSparepart.GetFocusedRow() as SPKDetailSparepartViewModel;


            List<SPKDetailSparepartDetailViewModel> listCurrentDetail = new List<SPKDetailSparepartDetailViewModel>();

            foreach (var item in this.SPKSparepartDetailList.Where(spd => spd.SPKDetailSparepartId == SparepartToRemove.SparepartId))
            {
                listCurrentDetail.Add(item);
            }

            foreach (var item in listCurrentDetail)
            {
                this.SPKSparepartDetailList.Remove(item);
            }

            listCurrent.Remove(SparepartToRemove);
            SPKSparepartList = listCurrent;

            RefreshSparepartGrid();
            CalculateTotalSparepart();
        }

        #region fingerprint
        //private void bgwFingerPrint_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        //{
        //    try
        //    {
        //        bool isConnected = axCZKEM1.Connect_Net(FingerprintIP, Convert.ToInt32(FingerpringPort));
        //        if (isConnected)
        //        {
        //            _isFingerprintConnected = true;
        //            axCZKEM1.RegEvent(1, 65535);

        //            DataTable dtAttLog = new DataTable();
        //            dtAttLog.Columns.Add("idwTMachineNumber");
        //            dtAttLog.Columns.Add("idwEnrollNumber");
        //            dtAttLog.Columns.Add("idwVerifyMode");
        //            dtAttLog.Columns.Add("idwInOutMode");
        //            dtAttLog.Columns.Add("idwDateTime");

        //            if (axCZKEM1.ReadGeneralLogData(1))//read all the attendance records to the memory
        //            {
        //                string sdwEnrollNumber = "";
        //                int idwTMachineNumber = 0;
        //                int idwVerifyMode = 0;
        //                int idwInOutMode = 0;
        //                int idwYear = 0;
        //                int idwMonth = 0;
        //                int idwDay = 0;
        //                int idwHour = 0;
        //                int idwMinute = 0;
        //                int idwSecond = 0;
        //                int idwWorkcode = 0;

        //                axCZKEM1.EnableDevice(1, false);
        //                while (axCZKEM1.SSR_GetGeneralLogData(1, out sdwEnrollNumber, out idwVerifyMode,
        //                   out idwInOutMode, out idwYear, out idwMonth, out idwDay, out idwHour, out idwMinute, out idwSecond, ref idwWorkcode))//get records from the memory
        //                {
        //                    DataRow newRow = dtAttLog.NewRow();
        //                    newRow["idwTMachineNumber"] = idwTMachineNumber;
        //                    newRow["idwEnrollNumber"] = sdwEnrollNumber;
        //                    newRow["idwVerifyMode"] = idwVerifyMode;
        //                    newRow["idwInOutMode"] = idwInOutMode;
        //                    newRow["idwDateTime"] = idwYear.ToString() + "-" + idwMonth.ToString() + "-" + idwDay.ToString() + " " + idwHour.ToString() + ":" + idwMinute.ToString();

        //                    dtAttLog.Rows.Add(newRow);
        //                }
        //                axCZKEM1.EnableDevice(1, true);
        //            }

        //            if (dtAttLog.Rows.Count > 0)
        //            {
        //                foreach (var item in MechanicLookupList)
        //                {
        //                    string currentMechanic = string.Empty;
        //                    foreach (DataRow row in dtAttLog.Rows)
        //                    {
        //                        DateTime currDate = row["idwDateTime"].AsDateTime();
        //                        if (currDate.Date.CompareTo(_today) == 0)
        //                        {
        //                            if (string.Compare(item.Code, row["idwEnrollNumber"].ToString()) == 0)
        //                            {
        //                                currentMechanic = row["idwEnrollNumber"].ToString();
        //                                break;
        //                            }
        //                        }
        //                    }

        //                    if (!string.IsNullOrEmpty(currentMechanic))
        //                    {
        //                        _availableMechanic.Add(currentMechanic);
        //                    }
        //                }
        //            }
        //            e.Result = true;
        //        }
        //        else
        //        {
        //            e.Result = false;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MethodBase.GetCurrentMethod().Fatal("An error occured while trying to connect to fingerprint device", ex);
        //        e.Result = ex;
        //    }
        //}

        //private void bgwFingerPrint_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        //{
        //    Cursor = Cursors.Default;
        //    if (e.Result is Exception)
        //    {
        //        this.ShowError("Koneksi ke fingerprint gagal!");
        //        _isFingerprintConnected = false;
        //    }
        //    else
        //    {
        //        if (!e.Result.AsBoolean())
        //        {
        //            this.ShowError("Koneksi ke fingerprint gagal! Data akan diambil dari database");
        //            _isFingerprintConnected = false;
        //        }
        //        else
        //        {
        //            _isFingerprintConnected = true;
        //            _presenter.UpdateMechanicList(_availableMechanic);
        //        }
        //    }
        //} 
        #endregion

        void gvSparepart_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            this.SelectedSparepart = gvSparepart.GetRow(e.FocusedRowHandle) as SparepartViewModel;
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

        void gvVehicleWheel_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            this.SelectedVehicleWheel = gvVehicleWheel.GetFocusedRow() as VehicleWheelViewModel;

            //GridView View = sender as GridView;
            //var rowHandle = View.FocusedRowHandle;
            //_presenter.LoadWheelDetail(View.GetRowCellValue(rowHandle, "SparepartId").AsInteger());
        }

        void gvVehicleWheel_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            GridView view = (GridView)sender;
            GridHitInfo hitInfo = view.CalcHitInfo(e.Point);
            if (hitInfo.InRow)
            {
                view.FocusedRowHandle = hitInfo.RowHandle;
                cmsVehicleWheel.Show(view.GridControl, e.Point);
            }
        }

        void SPKEditorForm_Load(object sender, EventArgs e)
        {
            _presenter.InitFormData();
            this.ApprovalEmailBody = Resources.SPKApprovalEmailTemplate;
            this.ApprovalEmailFrom = ConfigurationManager.AppSettings[ConfigurationConstant.APP_SETTING_MAIL_FROM].Decrypt();
            this.ApprovalEmailTo = ConfigurationManager.AppSettings[ConfigurationConstant.APP_SETTING_MANAGER_MAIL].Decrypt();

            //SPK sales handler
            if (this.IsSPKSales)
            {
                this.CategoryId = _presenter.SPKSalesCategoryReferenceId();
                lookUpCategory.Enabled = false;
                ckeIsContractWork.Enabled = false;
            }
        }

        bool ApprovalCheck()
        {
            bool result = false;

            ReferenceViewModel selectedReference = lookUpCategory.Properties.GetDataSourceRowByKeyValue(lookUpCategory.EditValue) as ReferenceViewModel;
            decimal vehicleBills = _presenter.GetAllPurchaseByVehicleToday();

            #region contract as high priority
            //if (this.isContractWork && (this.ContractWorkFee + vehicleBills) + this.CostEstimation.AsDecimal() >= this.ContractThreshold)
            //{
            //    result = true;
            //}
            //else
            //{
            //    if (selectedReference.Code == DbConstant.REF_SPK_CATEGORY_SERVICE &&
            //        (this.TotalSparepartPrice + vehicleBills) + this.CostEstimation.AsDecimal() >= this.ServiceThreshold)
            //    {
            //        result = true;
            //    }

            //    if (selectedReference.Code == DbConstant.REF_SPK_CATEGORY_REPAIR &&
            //        (this.TotalSparepartPrice + vehicleBills) + this.CostEstimation.AsDecimal() >= this.RepairThreshold)
            //    {
            //        result = true;
            //    }
            //}
            #endregion

            if (selectedReference.Code == DbConstant.REF_SPK_CATEGORY_SERVICE)
            {
                if (isContractWork && ContractWorkFee >= this.ContractThreshold)
                {
                    result = true;
                }
                else if ((this.TotalSparepartPrice + vehicleBills) + this.CostEstimation.AsDecimal() >= this.ServiceThreshold)
                {
                    result = true;
                }
            }

            if (selectedReference.Code == DbConstant.REF_SPK_CATEGORY_REPAIR)
            {
                if (isContractWork && ContractWorkFee >= this.ContractThreshold)
                {
                    result = true;
                }
                else if ((this.TotalSparepartPrice + vehicleBills) + this.CostEstimation.AsDecimal() >= this.RepairThreshold)
                {
                    result = true;
                }

                //always true?
                //result = true;
            }

            return result;
        }

        private void lookUpSparepart_EditValueChanged(object sender, EventArgs e)
        {
            if (this.SparepartId > 0)
            {
                //check if special sparepart

                LookUpEdit lookup = (LookUpEdit)sender;
                SparepartViewModel sparepart = (SparepartViewModel)lookup.GetSelectedDataRow();
               
                if (sparepart.IsSpecialSparepart)
                {
                    lookUpSerialNumber.Enabled = true;
                    txtQty.Text = "1";
                    txtQty.Enabled = false;

                    _presenter.LoadSSDetails(sparepart.Id);
                }
                else
                {
                    lookUpSerialNumber.Enabled = false;
                    txtQty.Text = "0";
                    txtQty.Enabled = true;
                }

                //check if used good
                ckeIsReturnRequired.Enabled = _presenter.IsUsedSparepartRequired();
                ckeIsReturnRequired.Checked = false;

                //get last usage info
                _presenter.GetLastUsageRecord();
                if (this.LastUsageRecord != null)
                {
                    lblValLastUsageDate.Text = this.LastUsageRecord.CreateDate.ToShortDateString();
                    lblValLastUsageQty.Text = this.LastUsageRecord.TotalQuantity.ToString();
                }
                else
                {
                    lblValLastUsageDate.Text = "--";
                    lblValLastUsageQty.Text = "--";
                }
            }
        }

        private void LookUpVehicle_EditValueChanged(object sender, EventArgs e)
        {
            _presenter.LoadVehicleWheel();
            VehicleViewModel vehicle = LookUpVehicle.GetSelectedDataRow() as VehicleViewModel;
            Kilometers = vehicle.Kilometers;

            if (this.VehicleWheelList.Count <= 0)
            {
                this.ShowWarning("Kendaraan yang dipilih tidak memiliki ban, pembuatan SPK tidak dapat dilanjutkan");
                splitContainerMain.Panel2.Enabled = false;
                gridVehicleWheel.Enabled = false;
            }
            else if (this.VehicleId > 0)
            {
                splitContainerMain.Panel2.Enabled = true;
                gridVehicleWheel.Enabled = true;
                btnChangeWheel.Enabled = true;
            }
            else
            {
                splitContainerMain.Panel2.Enabled = false;
                gridVehicleWheel.Enabled = false;
                btnChangeWheel.Enabled = false;
            }
        }

        private void ckeIsContractWork_CheckedChanged(object sender, EventArgs e)
        {
            CheckEdit edit = sender as CheckEdit;
            bool currenValue = edit.Checked;

            if (currenValue)
            {
                txtContractWorkFee.Enabled = true;
                txtContractor.Enabled = true;
            }
            else
            {
                txtContractWorkFee.Enabled = false;
                txtContractor.Enabled = false;
            }

        }

        private void cmsVehicleWheelItemReset_Click(object sender, EventArgs e)
        {
            //this.SelectedVehicleWheel.ReplaceWithWheelDetailId = 0;
            //this.SelectedVehicleWheel.SparepartId = 0;
            //SpecialSparepartDetailViewModel wheelToAdd = this.RemovedWHeelDetailList.Where(wd => wd.Id == this.SelectedWheelDetailToChange.Id).FirstOrDefault();
            //this.WheelDetailList.Add(wheelToAdd);
            //RemovedWHeelDetailList.Remove(wheelToAdd);
            //ResetSelecteVehicleWheel();
            //RefreshSparepartGrid();
            //CalculateTotalSparepart();
        }


        private void ResetSelecteVehicleWheel()
        {
            //this.SelectedVehicleWheel.IsUsedWheelRetrieved = false;
            //this.SelectedVehicleWheel.Price = 0;
            //gvVehicleWheel.SetFocusedRowCellValue("Price", this.SelectedVehicleWheel.Price);
            //gvVehicleWheel.SetFocusedRowCellValue("IsUsedWheelRetrieved", this.SelectedVehicleWheel.IsUsedWheelRetrieved);
            //gvVehicleWheel.SetFocusedRowCellValue("Sparepart", null);

            //SPKDetailSparepartDetailViewModel detailToRemove = this.SPKSparepartDetailList.Where(d => d.SparepartDetail.SparepartId == this.SelectedWheelDetailToChange.SparepartDetail.SparepartId).FirstOrDefault();
            //if (detailToRemove != null)
            //{
            //    this.SPKSparepartDetailList.Remove(detailToRemove);
            //    SPKDetailSparepartViewModel sparepartToRemove = this.SPKSparepartList.Where(sp => sp.SparepartId == detailToRemove.SparepartDetail.SparepartId).FirstOrDefault();

            //    if (sparepartToRemove != null)
            //    {
            //        this.SPKSparepartList.Remove(sparepartToRemove);
            //    }
            //}
        }


        void lookupWheelDetailGv_EditValueChanged(object sender, EventArgs e)
        {
            //LookUpEdit lookup = sender as LookUpEdit;

            //VehicleWheelViewModel duplicateVwToChange = this.VehicleWheelList.Where(vw => vw.ReplaceWithWheelDetailId == lookup.EditValue.AsInteger()).FirstOrDefault();

            //if (duplicateVwToChange != null && lookup.EditValue.AsInteger() > 0)
            //{
            //    this.ShowWarning("Terdapat duplikasi dalam pemilihan ban!");
            //}
            //else
            //{
            //    _presenter.SetSelectedWheelDetailToChange(lookup.EditValue.AsInteger());
            //}

            //ResetSelecteVehicleWheel();
        }

        void lookupWheelDetailGv_EditValueChanging(object sender, ChangingEventArgs e)
        {

        }

        void gvVehicleWheel_ShowingEditor(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //VehicleWheelViewModel focusedvehicleWheel = gvVehicleWheel.GetFocusedRow() as VehicleWheelViewModel;

            //GridView View = sender as GridView;
            //if (View.FocusedColumn.FieldName == "IsUsedWheelRetrieved" && (focusedvehicleWheel.ReplaceWithWheelDetailId == 0 || focusedvehicleWheel.Price > 0 || this.IsSPKSales))
            //{
            //    e.Cancel = true;
            //}

            //if (View.FocusedColumn.FieldName == "Price")
            //{
            //    e.Cancel = true;
            //}

            //if (View.FocusedColumn.FieldName == "SparepartId" && this.IsSPKSales)
            //{
            //    e.Cancel = true;
            //}

            //if (View.FocusedColumn.FieldName == "WheelDetail.SerialNumber")
            //{
            //    e.Cancel = true;
            //}

            //if (View.FocusedColumn.FieldName == "ReplaceWithWheelDetailId")
            //{
            //    var rowHandle = View.FocusedRowHandle;
            //    _presenter.LoadWheelDetail(View.GetRowCellValue(rowHandle, "SparepartId").AsInteger());
            //}
        }

        void ckeIsUsedWheelRetrieved_CheckedChanged(object sender, EventArgs e)
        {
            //CheckEdit check = sender as CheckEdit;

            //if (this.SelectedVehicleWheel.ReplaceWithWheelDetailId > 0)
            //{
            //    if (check.Checked)
            //    {
            //        if (this.SelectedWheelDetailToChange.SparepartDetail.PurchasingDetailId > 0)
            //        {
            //            this.SelectedVehicleWheel.Price = this.SelectedWheelDetailToChange.SparepartDetail.PurchasingDetail.Price;
            //        }
            //        else if (this.SelectedWheelDetailToChange.SparepartDetail.SparepartManualTransactionId > 0)
            //        {
            //            this.SelectedVehicleWheel.Price = this.SelectedWheelDetailToChange.SparepartDetail.SparepartManualTransaction.Price;
            //        }

            //        gvVehicleWheel.SetFocusedRowCellValue("Price", this.SelectedVehicleWheel.Price);

            //        this.SPKSparepartList.Add(new SPKDetailSparepartViewModel
            //        {
            //            Sparepart = this.SelectedWheelDetailToChange.SparepartDetail.Sparepart,
            //            SparepartId = this.SelectedWheelDetailToChange.SparepartDetail.SparepartId,
            //            TotalQuantity = 1,
            //            TotalPrice = this.SelectedVehicleWheel.Price
            //        });

            //        this.SPKSparepartDetailList.Add(new SPKDetailSparepartDetailViewModel
            //        {
            //            SparepartDetailId = this.SelectedWheelDetailToChange.SparepartDetail.Id,
            //            SparepartDetail = this.SelectedWheelDetailToChange.SparepartDetail
            //        });

            //        RefreshSparepartGrid();
            //        CalculateTotalSparepart();

            //        SpecialSparepartDetailViewModel wheelToRemove = this.WheelDetailList.Where(wd => wd.Id == this.SelectedWheelDetailToChange.Id).FirstOrDefault();
            //        RemovedWHeelDetailList.Add(wheelToRemove);
            //        this.WheelDetailList.Remove(wheelToRemove);
            //    }
            //}
            //check.Enabled = false;

        }

        #endregion

        private void bgwSave_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

            try
            {
                _presenter.SaveChanges();
                if (this.IsNeedApproval)
                {
                    _presenter.SendApproval();
                }
                else
                {
                    List<SPKViewModel> _dataSource = new List<SPKViewModel>();
                    _dataSource.Add(SelectedSPK);

                    if (isContractWork)
                    {
                        SPKContractPrintItem report = new SPKContractPrintItem();
                        report.DataSource = _dataSource;
                        report.FillDataSource();
                        if (!this.IsSPKSales)
                        {
                            _presenter.Print();
                            using (ReportPrintTool printTool = new ReportPrintTool(report))
                            {
                                // Invoke the Print dialog.
                                printTool.PrintDialog();
                            }
                        }
                    }
                    else
                    {
                        SPKPrintItem report = new SPKPrintItem();
                        report.DataSource = _dataSource;
                        report.FillDataSource();
                        if (!this.IsSPKSales)
                        {
                            _presenter.Print();
                            using (ReportPrintTool printTool = new ReportPrintTool(report))
                            {
                                // Invoke the Print dialog.
                                printTool.PrintDialog();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MethodBase.GetCurrentMethod().Fatal("An error occured while trying to save spk with vehicleID: '" + this.VehicleId + "'", ex);
                e.Result = ex;
            }
        }

        private void bgwSave_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            if (e.Result is Exception)
            {
                this.ShowError("Proses simpan data spk gagal!");
                FormHelpers.CurrentMainForm.UpdateStatusInformation("simpan data spk gagal", true);
            }
            else
            {
                FormHelpers.CurrentMainForm.UpdateStatusInformation("simpan data spk selesai", true);
                this.IsSaveComplete = true;
                this.Close();
            }
        }

        private void lookUpCategory_EditValueChanged(object sender, EventArgs e)
        {
            LookUpEdit lookup = sender as LookUpEdit;

            ReferenceViewModel category = lookup.GetSelectedDataRow() as ReferenceViewModel;

            if (category.Code == DbConstant.REF_SPK_CATEGORY_SALE)
            {
                this.IsSPKSales = true;
            }

        }

        private void btnAssignMechanic_Click(object sender, EventArgs e)
        {
            SPKAssignMechanic editor = Bootstrapper.Resolve<SPKAssignMechanic>();

            if (this.AssignedSchedule != null)
            {
                editor.AssignedSchedule = this.AssignedSchedule;
                editor.Description = this.MechanicDesc;
            }

            editor.SelectedSPK = this.SelectedSPK;
            editor.ShowDialog(this);
            this.AssignedSchedule = editor.AssignedSchedule;
            this.MechanicDesc = editor.Description;
        }

        private void btnChangeWheel_Click(object sender, EventArgs e)
        {
            SPKWheelChange editor = Bootstrapper.Resolve<SPKWheelChange>();
            editor.SelectedSPK = this.SelectedSPK;
            editor.VehicleId = this.VehicleId;

            if (this.VehicleWheelList != null)
            {
                editor.VehicleWheelList = this.VehicleWheelList;
            }

            editor.ShowDialog(this);
            this.VehicleWheelList = editor.VehicleWheelList;

            foreach (VehicleWheelViewModel vw in VehicleWheelList.Where(w => w.ReplaceWithWheelDetailId > 0))
            {
                if (!SPKSparepartList.Any(sp => sp.SparepartId == vw.SparepartId))
                {
                    this.SPKSparepartList.Add(new SPKDetailSparepartViewModel
                    {
                        Sparepart = new SparepartViewModel
                        {
                            Id = vw.SparepartId,
                            Name = vw.ReplaceWithWheelDetailName
                        },
                        SparepartId = vw.SparepartId,
                    });
                }

                //temp remove by Tegar

                SpecialSparepartDetailViewModel changedVwDetail = _presenter.GetSpecialSparepartDetail(vw.ReplaceWithWheelDetailId);
                if (changedVwDetail.PurchasingDetail != null)
                {
                    if (!SPKSparepartDetailList.Any(spd => spd.PurchasingDetail != null && spd.PurchasingDetailId == changedVwDetail.PurchasingDetailId))
                    {
                        this.SPKSparepartDetailList.Add(new SPKDetailSparepartDetailViewModel
                        {
                            PurchasingDetailId = changedVwDetail.PurchasingDetailId,
                            PurchasingDetail = changedVwDetail.PurchasingDetail,
                            Qty = 1
                        });
                    }
                    else
                    {
                        SPKDetailSparepartDetailViewModel detail = SPKSparepartDetailList.Where(spd => spd.PurchasingDetail != null && spd.PurchasingDetailId == changedVwDetail.PurchasingDetailId).FirstOrDefault();
                        detail.Qty += 1;
                    }
                }

                if (changedVwDetail.SparepartManualTransaction != null)
                {
                    if (!SPKSparepartDetailList.Any(spd => spd.SparepartManualTransaction != null && spd.SparepartManualTransactionId == changedVwDetail.SparepartManualTransactionId))
                    {
                        this.SPKSparepartDetailList.Add(new SPKDetailSparepartDetailViewModel
                        {
                            SparepartManualTransactionId = changedVwDetail.SparepartManualTransactionId,
                            SparepartManualTransaction = changedVwDetail.SparepartManualTransaction,
                            Qty = 1
                        });
                    }
                    else
                    {
                        SPKDetailSparepartDetailViewModel detail = SPKSparepartDetailList.Where(spd => spd.SparepartManualTransaction != null && spd.SparepartManualTransactionId == changedVwDetail.SparepartManualTransactionId).FirstOrDefault();
                        detail.Qty += 1;
                    }
                }

                SPKDetailSparepartViewModel spkSp = SPKSparepartList.Where(sp => sp.SparepartId == vw.SparepartId).FirstOrDefault();

                if (spkSp != null)
                {
                    spkSp.TotalQuantity++;
                    spkSp.TotalPrice = spkSp.TotalPrice + vw.Price;
                }

            }

            RefreshSparepartGrid();
            CalculateTotalSparepart();
        }
    }
}