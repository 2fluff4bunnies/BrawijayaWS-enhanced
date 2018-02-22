using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.Presenter;
using BrawijayaWorkshop.SharedObject.ViewModels;
using BrawijayaWorkshop.Utils;
using BrawijayaWorkshop.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Reflection;
using System.Windows.Forms;
using System.Linq;
using DevExpress.XtraEditors;


namespace BrawijayaWorkshop.Win32App.ModulForms
{
    public partial class SPKAssignMechanic : BaseEditorForm, ISPKScheduleEditorView
    {
        private DateTime _today;
        private List<string> _availableMechanic;
        public zkemkeeper.CZKEMClass axCZKEM1 = new zkemkeeper.CZKEMClass();
        private bool _isFingerprintConnected = false;
        public string FingerprintIP { get; set; }
        public string FingerpringPort { get; set; }
        private BindingList<MechanicViewModel> _bindMechanics;
        private BindingList<MechanicViewModel> _bindelectedMechanics;
        private SPKScheduleEditorPresenter _presenter;
        private SPKViewModel _selectedSPK;
        private List<SPKScheduleViewModel> _assignedSchedule;

        public SPKAssignMechanic(SPKScheduleEditorModel model)
        {
            InitializeComponent();

            _presenter = new SPKScheduleEditorPresenter(this, model);
            _availableMechanic = new List<string>();
            _today = DateTime.Today;
            this.Load += SPKAssignMechanic_Load;


            //bgwFingerPrint.RunWorkerAsync();
        }

        void SPKAssignMechanic_Load(object sender, EventArgs e)
        {
            _presenter.InitFormData();

            ReloadMechanics();
        }

        #region Properties
        public SPKScheduleViewModel SelectedSPKSchedule { get; set; }
        public List<SPKScheduleViewModel> AssignedSchedule
        {
            get
            {
                return this._assignedSchedule;
            }
            set
            {
                this._assignedSchedule = value;
            }
        }
        public string SPKVehicleCustomer { get; set; }
        public string SPKCategory { get; set; }

        public string SPKDescription { get; set; }

        public DateTime Date
        {
            get
            {
                return dtpDate.EditValue.AsDateTime();
            }
            set
            {
                dtpDate.EditValue = value;
            }
        }

        public int SPKId { get; set; }

        public List<SPKViewModel> SPKList { get; set; }

        public List<SPKVehicleModel> SPKVehicleList { get; set; }

        public int MechanicId { get; set; }

        public List<MechanicViewModel> MechanicList { get; set; }

        public List<MechanicViewModel> SelectedMechanicList { get; set; }

        public SPKViewModel SelectedSPK
        {
            get
            {
                return _selectedSPK;
            }
            set
            {
                _selectedSPK = value;
            }
        }

        public string Description
        {
            get
            {
                return txtDescription.EditValue.ToString();
            }
            set
            {
                txtDescription.EditValue = value;
            }
        }

        #endregion

        private void btnMoveRight_Click(object sender, EventArgs e)
        {
            if (lbxMechanics.SelectedItems != null)
            {
                foreach (var item in lbxMechanics.SelectedItems)
                {
                    SelectedMechanicList.Add((MechanicViewModel)item);
                }

                foreach (var item in SelectedMechanicList)
                {
                    MechanicList.Remove((MechanicViewModel)item);
                }

                RebindListboxes();
            }
        }

        private void btnMoveAllRight_Click(object sender, EventArgs e)
        {
            SelectedMechanicList.AddRange(MechanicList);
            MechanicList.Clear();
            RebindListboxes();
        }

        private void btnMoveLeft_Click(object sender, EventArgs e)
        {
            if (lbxSelectedMechanics != null)
            {
                foreach (var item in lbxSelectedMechanics.SelectedItems)
                {
                    MechanicList.Add(item as MechanicViewModel);
                }

                foreach (var item in MechanicList)
                {
                    SelectedMechanicList.Remove(item as MechanicViewModel);
                }

                RebindListboxes();
            }
        }

        private void btnMoveAllLeft_Click(object sender, EventArgs e)
        {
            MechanicList.AddRange(SelectedMechanicList);
            SelectedMechanicList.Clear();
            RebindListboxes();
        }

        private void bgwFingerPrint_DoWork(object sender, DoWorkEventArgs e)
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
                        List<string> attendedMechanics = new List<string>();
                        foreach (var item in MechanicList)
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
                                attendedMechanics.Add(currentMechanic);
                            }
                        }

                        if (attendedMechanics.Count > 0)
                        {
                            _availableMechanic = attendedMechanics;
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

        private void bgwFingerPrint_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Cursor = Cursors.Default;

            if (e.Result is Exception)
            {
                this.ShowError("Koneksi ke fingerprint gagal!");
                _isFingerprintConnected = false;
                this.ckeGetFingerPrint.Checked = false;
            }
            else
            {
                if (!e.Result.AsBoolean())
                {
                    this.ShowError("Koneksi ke fingerprint gagal! Data mekanik sekarang diambil dari master mekanik");
                    _isFingerprintConnected = false;
                    this.ckeGetFingerPrint.Checked = false;
                }
                else
                {
                    _isFingerprintConnected = true;
                    _presenter.UpdateMechanicList(_availableMechanic);
                    ReloadMechanics();
                }
            }
            this.Enabled = true;
        }

        protected override void ExecuteSave()
        {
            foreach (MechanicViewModel selected in SelectedMechanicList)
            {
                _assignedSchedule.Add(new SPKScheduleViewModel
                {
                    MechanicId = selected.Id,
                    Description = this.Description,
                    Date = this.Date,
                });
            }

            this.Close();
        }

        private void RebindListboxes()
        {
            lbxMechanics.DataSource = null;
            lbxMechanics.DataSource = MechanicList;
            lbxMechanics.ValueMember = "Id";
            lbxMechanics.DisplayMember = "Name";
            lbxMechanics.SelectionMode = SelectionMode.MultiSimple;

            lbxSelectedMechanics.DataSource = null;
            lbxSelectedMechanics.ValueMember = "Id";
            lbxSelectedMechanics.DisplayMember = "Name";
            lbxSelectedMechanics.DataSource = SelectedMechanicList;
            lbxSelectedMechanics.SelectionMode = SelectionMode.MultiSimple;
        }

        private void ckeGetFingerPrint_CheckedChanged(object sender, EventArgs e)
        {
            CheckEdit cke = (CheckEdit)sender;

            if (cke.Checked)
            {
                this.Enabled = false;
                Cursor = Cursors.WaitCursor;
                FormHelpers.CurrentMainForm.UpdateStatusInformation("Cek koneksi ke fingerprint", false);
                bgwFingerPrint.RunWorkerAsync();
            }
        }


        private void ReloadMechanics()
        {
            if (this.AssignedSchedule != null && this.AssignedSchedule.Count > 0)
            {
                foreach (var item in this.AssignedSchedule)
                {
                    MechanicViewModel mechanic = MechanicList.Where(m => m.Id == item.MechanicId).FirstOrDefault();

                    if (mechanic != null)
                    {
                        SelectedMechanicList.Add((MechanicViewModel)mechanic);
                    }
                }

                foreach (var item in SelectedMechanicList)
                {
                    MechanicList.Remove((MechanicViewModel)item);
                }

                RebindListboxes();
            }
            else
            {
                this.AssignedSchedule = new List<SPKScheduleViewModel>();
            }

            RebindListboxes();
        }
    }
}