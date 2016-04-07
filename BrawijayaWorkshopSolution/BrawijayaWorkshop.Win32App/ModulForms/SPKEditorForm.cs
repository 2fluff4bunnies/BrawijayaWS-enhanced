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
using System.Data;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace BrawijayaWorkshop.Win32App.ModulForms
{
    public partial class SPKEditorForm : BaseEditorForm, ISPKEditorView
    {
        private DateTime _today;
        private List<string> _availableMechanic;
        public zkemkeeper.CZKEMClass axCZKEM1 = new zkemkeeper.CZKEMClass();
        //private bool _isFingerprintConnected = false;

        private SPKEditorPresenter _presenter;

        public string FingerprintIP { get; set; }

        public string FingerpringPort { get; set; }

        public bool IsSPKSales { get; set; }

        public SPKEditorForm(SPKEditorModel model)
        {
            InitializeComponent();
            _presenter = new SPKEditorPresenter(this, model);
            _availableMechanic = new List<string>();
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

            txtContractWorkFee.Enabled = false;
            groupSparepart.Enabled = false;
            gridVehicleWheel.Enabled = false;
            ckeIsReturnRequired.Enabled = false;
            lookUpSerialNumber.Enabled = false;
            txtTotalSparepartPrice.ReadOnly = true;

            //collumn setting for lookup specialSparepart in grid
            LookUpColumnInfoCollection coll = lookupWheelDetailGv.Columns;

            coll.Add(new LookUpColumnInfo("SerialNumber", 0, "Nomor Seri"));
            coll.Add(new LookUpColumnInfo("SparepartDetail", 0, "Nama"));
            lookupWheelDetailGv.BestFitMode = BestFitMode.BestFitResizePopup;
            lookupWheelDetailGv.SearchMode = SearchMode.AutoComplete;
            lookupWheelDetailGv.AutoSearchColumnIndex = 1;

            //Vehicle wheel handler
            ckeIsUsedWheelRetrieved.CheckedChanged += ckeIsUsedWheelRetrieved_CheckedChanged;
            gvVehicleWheel.ShowingEditor += gvVehicleWheel_ShowingEditor;
            lookupWheelDetailGv.EditValueChanged += lookupWheelDetailGv_EditValueChanged;

        }

        #region Field Editor

        public SPKViewModel SelectedSPK { get; set; }
        public SPKViewModel ParentSPK { get; set; }
        public List<SPKDetailSparepartDetailViewModel> SPKSparepartDetailList { get; set; }
        public string Code { get; set; }
        public SparepartViewModel SelectedSparepart { get; set; }
        public MechanicViewModel SelectedMechanic { get; set; }
        public decimal RepairThreshold { get; set; }
        public decimal ServiceThreshold { get; set; }
        public bool IsNeedApproval { get; set; }
        public List<SpecialSparepartDetailViewModel> RemovedWHeelDetailList { get; set; }

        public decimal TotalSparepartPrice
        {
            get
            {
                return txtTotalSparepartPrice.Text.AsDecimal();
            }
            set
            {

                txtTotalSparepartPrice.Text = value.ToString();
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

        public bool IsUsedSparepartRequired
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
                return txtContractWorkFee.Text.AsDecimal();
            }
            set
            {
                txtContractWorkFee.Text = value.ToString();
            }
        }
        #endregion

        #region EmailProperties
        public string ApprovalEmailBody { get; set; }

        public string ApprovalEmailFrom { get; set; }

        public string ApprovalEmailTo { get; set; }
        #endregion

        #region Methods
        protected override void ExecuteSave()
        {
            if (valCategory.Validate() && valVehicle.Validate() && valDueDate.Validate() && SPKSparepartList.Count > 0)// && SPKMechanicList.Count > 0)
            {
                try
                {
                    MethodBase.GetCurrentMethod().Info("Save SPK's changes");
                    this.IsNeedApproval = ApprovalCheck();
                    _presenter.SaveChanges();
                    if (this.IsNeedApproval)
                    {
                        _presenter.SendApproval();
                    }
                    else
                    {
                        SPKPrintItem report = new SPKPrintItem();
                        List<SPKViewModel> _dataSource = new List<SPKViewModel>();
                        _dataSource.Add(SelectedSPK);
                        report.DataSource = _dataSource;
                        report.FillDataSource();
                        _presenter.Print();

                        using (ReportPrintTool printTool = new ReportPrintTool(report))
                        {
                            // Invoke the Print dialog.
                            printTool.PrintDialog();
                        }
                    }

                    this.Close();
                }
                catch (Exception ex)
                {
                    MethodBase.GetCurrentMethod().Fatal("An error occored while trying to save SPK", ex);
                    this.ShowError("Proses simpan SPK gagal!");
                }
            }
            else
            {
                if (SPKSparepartList.Count == 0)// && SPKMechanicList.Count == 0)
                {
                    this.ShowError("Daftar sparepart dan mekanik kosong! masing-masing harus terisi, minimal 1");
                }
                else
                {
                    if (SPKSparepartList.Count == 0)
                    {
                        this.ShowError("Daftar sparepart kosong! Harus ada sparepart yang digunakan, minimal 1");
                    }
                }
            }
        }

        private void btnAddSparepart_Click(object sender, EventArgs e)
        {
            if (SparepartToInsert == null || txtQty.Text == "0" || string.IsNullOrEmpty(txtQty.Text))
            {
                this.ShowWarning("Sparepart atau Jumlah harus diisi");
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

                    foreach (var item in SPKSparepartDetailList.Where(ssd => ssd.SparepartDetail.Sparepart.Id == SparepartToInsert.Id))
                    {
                        totalPrice = totalPrice + item.SparepartDetail.PurchasingDetail.Price;
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
        }


        private void cmsDeleteDataSparepart_Click(object sender, EventArgs e)
        {
            SPKDetailSparepartViewModel SparepartToRemove = gvSparepart.GetFocusedRow() as SPKDetailSparepartViewModel;
            SPKSparepartList.Remove(SparepartToRemove);

            RefreshSparepartGrid();
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
            this.SelectedSparepart = gvSparepart.GetFocusedRow() as SparepartViewModel;
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
                this.lookUpCategory.Enabled = false;
            }
        }

        bool ApprovalCheck()
        {
            bool result = false;

            ReferenceViewModel selectedReference = lookUpCategory.Properties.GetDataSourceRowByKeyValue(lookUpCategory.EditValue) as ReferenceViewModel;

            if (selectedReference.Code == DbConstant.REF_SPK_CATEGORY_SERVICE && this.TotalSparepartPrice >= this.ServiceThreshold)
            {
                result = true;
            }

            if (selectedReference.Code == DbConstant.REF_SPK_CATEGORY_REPAIR && this.TotalSparepartPrice >= this.RepairThreshold)
            {
                result = true;
            }

            return result;
        }

        private void lookUpSparepart_EditValueChanged(object sender, EventArgs e)
        {
            if (this.SparepartId > 0)
            {
                //check if special sparepart
                SpecialSparepartViewModel ss = _presenter.GetSpecialSparepart();
                if (ss != null)
                {
                    lookUpSerialNumber.Enabled = true;
                    _presenter.LoadSSDetails(ss.Id);
                    txtQty.Text = "1";
                    txtQty.Enabled = false;
                }
                else
                {
                    lookUpSerialNumber.Enabled = false;
                    txtQty.Text = "0";
                    txtQty.Enabled = true;
                }

                //check if used good
                _presenter.CheckIsUsedSparepartRequired();
                ckeIsReturnRequired.Enabled = this.IsUsedSparepartRequired;

                //get last usage info
                _presenter.GetLastUsageRecord();
                if (this.LastUsageRecord != null)
                {
                    lblValLastUsageDate.Text = this.LastUsageRecord.CreateDate.ToShortDateString();
                    lblValLastUsageQty.Text = this.LastUsageRecord.TotalQuantity.ToString();
                }
            }
        }

        private void LookUpVehicle_EditValueChanged(object sender, EventArgs e)
        {
            _presenter.LoadVehicleWheel();
            if (this.VehicleId > 0)
            {
                groupSparepart.Enabled = true;
                gridVehicleWheel.Enabled = true;
            }
            else
            {
                groupSparepart.Enabled = false;
                gridVehicleWheel.Enabled = false;
            }
        }

        private void ckeIsContractWork_CheckedChanged(object sender, EventArgs e)
        {
            CheckEdit edit = sender as CheckEdit;
            bool currenValue = edit.Checked;

            if (currenValue)
            {
                txtContractWorkFee.Enabled = true;
            }
            else
            {
                txtContractWorkFee.Enabled = false;
            }

        }

        private void cmsVehicleWheelItemReset_Click(object sender, EventArgs e)
        {
            this.SelectedVehicleWheel.ReplaceWithWheelDetailId = 0;
            SpecialSparepartDetailViewModel wheelToAdd = this.RemovedWHeelDetailList.Where(wd => wd.Id == this.SelectedWheelDetailToChange.Id).FirstOrDefault();
            this.WheelDetailList.Add(wheelToAdd);
            RemovedWHeelDetailList.Remove(wheelToAdd);
            ResetSelecteVehicleWheel();
            RefreshSparepartGrid();
            CalculateTotalSparepart();
        }


        private void ResetSelecteVehicleWheel()
        {
            this.SelectedVehicleWheel.IsUsedWheelRetrieved = false;
            this.SelectedVehicleWheel.Price = 0;
            gvVehicleWheel.SetFocusedRowCellValue("Price", this.SelectedVehicleWheel.Price);
            gvVehicleWheel.SetFocusedRowCellValue("IsUsedWheelRetrieved", this.SelectedVehicleWheel.IsUsedWheelRetrieved);

            SPKDetailSparepartDetailViewModel detailToRemove = this.SPKSparepartDetailList.Where(d => d.SparepartDetail.SparepartId == this.SelectedWheelDetailToChange.SparepartDetail.SparepartId).FirstOrDefault();
            if (detailToRemove != null)
            {
                this.SPKSparepartList.Remove(new SPKDetailSparepartViewModel
                {
                    Sparepart = this.SelectedWheelDetailToChange.SparepartDetail.Sparepart,
                    SparepartId = this.SelectedWheelDetailToChange.SparepartDetail.SparepartId,
                    TotalQuantity = 1,
                    TotalPrice = this.SelectedWheelDetailToChange.SparepartDetail.PurchasingDetail.Price,
                });

                this.SPKSparepartDetailList.Remove(detailToRemove);
                SPKDetailSparepartViewModel sparepartToRemove = this.SPKSparepartList.Where(sp => sp.Id == detailToRemove.SparepartDetail.SparepartId).FirstOrDefault();

                if (sparepartToRemove != null)
                {
                    this.SPKSparepartList.Remove(sparepartToRemove);
                }
            }
        }


        void lookupWheelDetailGv_EditValueChanged(object sender, EventArgs e)
        {
            LookUpEdit lookup = sender as LookUpEdit;
            VehicleWheelViewModel duplicateVwToChange = this.VehicleWheelList.Where(vw => vw.ReplaceWithWheelDetailId == lookup.EditValue.AsInteger()).FirstOrDefault();

            if (duplicateVwToChange != null)
            {
                this.ShowWarning("Terdapat duplikasi dalam pemilih ban untuk diganti!");
                lookup.EditValue = null;
            }
            else
            {
                _presenter.SetSelectedWheelDetailToChange(lookup.EditValue.AsInteger());
            }

            ResetSelecteVehicleWheel();
        }

        void gvVehicleWheel_ShowingEditor(object sender, System.ComponentModel.CancelEventArgs e)
        {
            GridView View = sender as GridView;
            if (View.FocusedColumn.FieldName == "IsUsedWheelRetrieved" && (this.SelectedVehicleWheel.ReplaceWithWheelDetailId == 0 || this.SelectedVehicleWheel.Price > 0))
            {
                e.Cancel = true;
            }

            if (View.FocusedColumn.FieldName == "Price")
            {
                e.Cancel = true;
            }

            if (View.FocusedColumn.FieldName == "WheelDetail.SparepartDetail.Sparepart.Name")
            {
                e.Cancel = true;
            }

            if (View.FocusedColumn.FieldName == "WheelDetail.SerialNumber")
            {
                e.Cancel = true;
            }
        }

        void ckeIsUsedWheelRetrieved_CheckedChanged(object sender, EventArgs e)
        {
            CheckEdit check = sender as CheckEdit;

            if (this.SelectedVehicleWheel.ReplaceWithWheelDetailId > 0)
            {
                if (check.Checked)
                {
                    this.SelectedVehicleWheel.Price = this.SelectedWheelDetailToChange.SparepartDetail.PurchasingDetail.Price;
                    gvVehicleWheel.SetFocusedRowCellValue("Price", this.SelectedVehicleWheel.Price);

                    this.SPKSparepartList.Add(new SPKDetailSparepartViewModel
                    {
                        Sparepart = this.SelectedWheelDetailToChange.SparepartDetail.Sparepart,
                        SparepartId = this.SelectedWheelDetailToChange.SparepartDetail.SparepartId,
                        TotalQuantity = 1,
                        TotalPrice = this.SelectedWheelDetailToChange.SparepartDetail.PurchasingDetail.Price,
                    });

                    this.SPKSparepartDetailList.Add(new SPKDetailSparepartDetailViewModel
                    {
                        SparepartDetailId = this.SelectedWheelDetailToChange.SparepartDetail.Id,
                        SparepartDetail = this.SelectedWheelDetailToChange.SparepartDetail
                    });

                    RefreshSparepartGrid();
                    CalculateTotalSparepart();

                    SpecialSparepartDetailViewModel wheelToRemove = this.WheelDetailList.Where(wd => wd.Id == this.SelectedWheelDetailToChange.Id).FirstOrDefault();
                    RemovedWHeelDetailList.Add(wheelToRemove);
                    this.WheelDetailList.Remove(wheelToRemove);
                }
            }
            check.Enabled = false;

        }

        #endregion
    }
}