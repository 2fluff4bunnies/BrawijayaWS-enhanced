using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.Presenter;
using BrawijayaWorkshop.Utils;
using BrawijayaWorkshop.View;
using BrawijayaWorkshop.Win32App.Properties;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Reflection;
using System.Windows.Forms;

namespace BrawijayaWorkshop.Win32App.ModulForms
{
    public partial class SPKEditorForm : BaseEditorForm, ISPKEditorView
    {
        private DateTime _today;
        private List<string> _availableMechanic;
        public zkemkeeper.CZKEMClass axCZKEM1 = new zkemkeeper.CZKEMClass();
        private bool _isFingerprintConnected = false;

        private SPKEditorPresenter _presenter;

        public string FingerprintIP { get; set; }

        public string FingerpringPort { get; set; }

        public SPKEditorForm(SPKEditorModel model)
        {
            InitializeComponent();
            _presenter = new SPKEditorPresenter(this, model);
            _availableMechanic = new List<string>();
            _today = DateTime.Today;

            valCategory.SetIconAlignment(lookUpCategory, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            valVehicle.SetIconAlignment(LookUpVehicle, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            valDueDate.SetIconAlignment(dtpDueDate, System.Windows.Forms.ErrorIconAlignment.MiddleRight);

            this.Load += SPKEditorForm_Load;

            gvSparepart.PopupMenuShowing += gvSparepart_PopupMenuShowing;
            gvSparepart.FocusedRowChanged += gvSparepart_FocusedRowChanged;

            gvMechanic.PopupMenuShowing += gvMechanic_PopupMenuShowing;
            gvMechanic.FocusedRowChanged += gvMechanic_FocusedRowChanged;

            SPKSparepartList = new List<SPKDetailSparepart>();
            SPKMechanicList = new List<SPKDetailMechanic>();

            this.TotalSparepartPrice = 0;
            this.IsMechanicRegistered = true;
            ApplyMechanicSetting();
        }

        #region Field Editor

        public SPK SelectedSPK { get; set; }
        public SPK ParentSPK { get; set; }
        public List<SPKDetailSparepartDetail> SPKSparepartDetailList { get; set; }
        public string Code { get; set; }
        public Sparepart SelectedSparepart { get; set; }
        public Mechanic SelectedMechanic { get; set; }
        public decimal RepairThreshold { get; set; }
        public decimal ServiceThreshold { get; set; }
        public bool IsNeedApproval { get; set; }

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

        public bool IsMechanicRegistered
        {
            get
            {
                return chxIsRegistered.Checked;
            }
            set
            {
                chxIsRegistered.Checked = value;
            }
        }

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
                return txtMechanicName.Text;
            }
            set
            {
                txtMechanicName.Text = value;
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

        #endregion

        #region EmailProperties
        public string ApprovalEmailBody { get; set; }

        public string ApprovalEmailFrom { get; set; }

        public string ApprovalEmailTo { get; set; }
        #endregion

        #region Methods
        protected override void ExecuteSave()
        {
            if (valCategory.Validate() && valVehicle.Validate() && valDueDate.Validate() && SPKSparepartList.Count > 0 && SPKMechanicList.Count > 0)
            {
                try
                {
                    MethodBase.GetCurrentMethod().Info("Save SPK's changes");
                    this.IsNeedApproval = ApprovalCheck();
                    _presenter.SaveChanges();
                    if(this.IsNeedApproval)
                    {
                        _presenter.SendApproval();
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
                if (SPKSparepartList.Count == 0)
                {
                    this.ShowError("Tidak ada sparepart dalam daftar penggunaan sparepart! Harus ada sparepart yang digunakan, minimal 1");
                }
                if (SPKMechanicList.Count == 0)
                {
                    this.ShowError("Tidak ada mekanik yang terlibat! Harus ada mekanik yang terlibat, minimal 1");
                }
            }
        }

        private void btnAddSparepart_Click(object sender, EventArgs e)
        {
            int pendingRequestSparepart = _presenter.getPendingSparpartQty();

            if (this.SparepartQty + pendingRequestSparepart <= SparepartToInsert.StockQty)
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

                RefreshSparepartGrid();

                ClearSparepart();

                this.TotalSparepartPrice = this.TotalSparepartPrice + totalPrice;
            }
            else
            {
                this.ShowError(string.Format("Jumlah sparepart yang dimasukkan melebihi stok yang ada! \n Stok yang diminta : {0} \n Permintaan tertunda : {1} \n Stok tersedia : {2}", SparepartQty, pendingRequestSparepart, SparepartToInsert.StockQty));
            }
        }

        public void ClearSparepart()
        {
            this.SparepartQty = 0;
            this.SparepartName = string.Empty;
        }

        private void btnAddMechanic_Click(object sender, EventArgs e)
        {
            if (this.IsMechanicRegistered)
            {
                if (MechanicToInsert != null)
                {
                    SPKMechanicList.Add(new SPKDetailMechanic
                    {
                        Name = this.MechanicToInsert.Name,
                        Mechanic = MechanicToInsert,
                        MechanicId = MechanicId

                    });
                }
            }
            else
            {
                if (!string.IsNullOrEmpty(MechanicName))
                {
                    SPKMechanicList.Add(new SPKDetailMechanic
                    {

                        Name = this.MechanicName
                    });
                }
            }

            RefreshMechanicGrid();

            ClearMechanic();
        }

        public void ClearMechanic()
        {
            this.SelectedMechanic = null;
            this.MechanicName = string.Empty;
        }

        #endregion

        public void RefreshMechanicGrid()
        {
            gcMechanic.DataSource = SPKMechanicList;
            gvMechanic.BestFitColumns();
        }

        public void RefreshSparepartGrid()
        {
            gcSparepart.DataSource = SPKMechanicList;
            gvSparepart.BestFitColumns();
        }

        private void cmsDeleteDataMechanic_Click(object sender, EventArgs e)
        {
            SPKDetailMechanic mechanicToRemove = gvMechanic.GetFocusedRow() as SPKDetailMechanic;
            SPKMechanicList.Remove(mechanicToRemove);

            RefreshMechanicGrid();
        }

        private void cmsDeleteDataSparepart_Click(object sender, EventArgs e)
        {
            SPKDetailSparepart SparepartToRemove = gvSparepart.GetFocusedRow() as SPKDetailSparepart;
            SPKSparepartList.Remove(SparepartToRemove);

            RefreshSparepartGrid();
        }

        private void bgwFingerPrint_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            try
            {
                bool isConnected = axCZKEM1.Connect_Net(FingerprintIP, Convert.ToInt32(FingerpringPort));
                if (isConnected)
                {
                    _isFingerprintConnected = true;
                    axCZKEM1.RegEvent(1, 65535);

                    DataTable dtAttLog = new DataTable();
                    dtAttLog.Columns.Add("idwTMachineNumber");
                    dtAttLog.Columns.Add("idwEnrollNumber");
                    dtAttLog.Columns.Add("idwVerifyMode");
                    dtAttLog.Columns.Add("idwInOutMode");
                    dtAttLog.Columns.Add("idwDateTime");

                    if (axCZKEM1.ReadGeneralLogData(1))//read all the attendance records to the memory
                    {
                        string sdwEnrollNumber = "";
                        int idwTMachineNumber = 0;
                        int idwVerifyMode = 0;
                        int idwInOutMode = 0;
                        int idwYear = 0;
                        int idwMonth = 0;
                        int idwDay = 0;
                        int idwHour = 0;
                        int idwMinute = 0;
                        int idwSecond = 0;
                        int idwWorkcode = 0;

                        axCZKEM1.EnableDevice(1, false);
                        while (axCZKEM1.SSR_GetGeneralLogData(1, out sdwEnrollNumber, out idwVerifyMode,
                           out idwInOutMode, out idwYear, out idwMonth, out idwDay, out idwHour, out idwMinute, out idwSecond, ref idwWorkcode))//get records from the memory
                        {
                            DataRow newRow = dtAttLog.NewRow();
                            newRow["idwTMachineNumber"] = idwTMachineNumber;
                            newRow["idwEnrollNumber"] = sdwEnrollNumber;
                            newRow["idwVerifyMode"] = idwVerifyMode;
                            newRow["idwInOutMode"] = idwInOutMode;
                            newRow["idwDateTime"] = idwYear.ToString() + "-" + idwMonth.ToString() + "-" + idwDay.ToString() + " " + idwHour.ToString() + ":" + idwMinute.ToString();

                            dtAttLog.Rows.Add(newRow);
                        }
                        axCZKEM1.EnableDevice(1, true);
                    }

                    if (dtAttLog.Rows.Count > 0)
                    {
                        foreach (var item in MechanicLookupList)
                        {
                            string currentMechanic = string.Empty;
                            foreach (DataRow row in dtAttLog.Rows)
                            {
                                DateTime currDate = row["idwDateTime"].AsDateTime();
                                if (currDate.Date.CompareTo(_today) == 0)
                                {
                                    if (string.Compare(item.Code, row["idwEnrollNumber"].ToString()) == 0)
                                    {
                                        currentMechanic = row["idwEnrollNumber"].ToString();
                                        break;
                                    }
                                }
                            }

                            if (!string.IsNullOrEmpty(currentMechanic))
                            {
                                _availableMechanic.Add(currentMechanic);
                            }
                        }
                    }
                    e.Result = true;
                }
                else
                {
                    e.Result = false;
                }
            }
            catch (Exception ex)
            {
                MethodBase.GetCurrentMethod().Fatal("An error occured while trying to connect to fingerprint device", ex);
                e.Result = ex;
            }
        }

        private void bgwFingerPrint_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            Cursor = Cursors.Default;
            if (e.Result is Exception)
            {
                this.ShowError("Koneksi ke fingerprint gagal!");
                _isFingerprintConnected = false;
            }
            else
            {
                if (!e.Result.AsBoolean())
                {
                    this.ShowError("Koneksi ke fingerprint gagal! Data akan diambil dari database");
                    _isFingerprintConnected = false;
                }
                else
                {
                    _isFingerprintConnected = true;
                    _presenter.UpdateMechanicList(_availableMechanic);
                }
            }
        }

        private void chxIsRegistered_CheckedChanged(object sender, EventArgs e)
        {
            ApplyMechanicSetting();
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
            this.ApprovalEmailBody = Resources.SPKApprovalEmailTemplate;
            this.ApprovalEmailFrom = ConfigurationManager.AppSettings[ConfigurationConstant.APP_SETTING_MAIL_FROM].Decrypt();
            this.ApprovalEmailTo = ConfigurationManager.AppSettings[ConfigurationConstant.APP_SETTING_MANAGER_MAIL].Decrypt();

            if (!bgwFingerPrint.IsBusy)
            {
                Cursor = Cursors.WaitCursor;
                bgwFingerPrint.RunWorkerAsync();
            }
        }

        void ApplyMechanicSetting()
        {
            if (IsMechanicRegistered)
            {
                lookUpMechanic.Visible = true;
                txtMechanicName.Visible = false;
            }
            else
            {
                lookUpMechanic.Visible = false;
                txtMechanicName.Visible = true;
            }
        }

        bool ApprovalCheck()
        {
            bool result = false;

            if (this.CategoryId == 20 && this.TotalSparepartPrice >= this.ServiceThreshold)
            {
                result = true;
            }

            if (this.CategoryId == 21 && this.TotalSparepartPrice >= this.RepairThreshold)
            {
                result = true;
            }

            return result;
        }


    }
}