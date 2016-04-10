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
using System.Linq;
using BrawijayaWorkshop.Win32App.PrintItems;
using DevExpress.XtraReports.UI;
using BrawijayaWorkshop.SharedObject.ViewModels;
using DevExpress.XtraEditors;

namespace BrawijayaWorkshop.Win32App.ModulForms
{
    public partial class SPKScheduleEditorForm : BaseEditorForm, ISPKScheduleEditorView
    {
        private DateTime _today;
        private List<string> _availableMechanic;
        public zkemkeeper.CZKEMClass axCZKEM1 = new zkemkeeper.CZKEMClass();
        private bool _isFingerprintConnected = false;
        public string FingerprintIP { get; set; }
        public string FingerpringPort { get; set; }

        SPKScheduleEditorPresenter _presenter;

        public SPKScheduleEditorForm(SPKScheduleEditorModel model)
        {
            InitializeComponent();

            _presenter = new SPKScheduleEditorPresenter(this, model);
            _availableMechanic = new List<string>();
            _today = DateTime.Today;

            FieldValidator.SetIconAlignment(lookUpMechanic, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            FieldValidator.SetIconAlignment(lookUpSPK, System.Windows.Forms.ErrorIconAlignment.MiddleRight);

            lookUpSPK.EditValueChanged += lookUpSPK_EditValueChanged;

            this.Load += SPKScheduleEditorForm_Load;
        }

        void lookUpSPK_EditValueChanged(object sender, EventArgs e)
        {
            LookUpEdit lookup = sender as LookUpEdit;
            SPKViewModel selectedSPK = lookUpSPK.GetSelectedDataRow() as SPKViewModel;
            if(selectedSPK != null)
            {
                lblSPKCategoryValue.Text = selectedSPK.CategoryReference.Name;
                lblSPKDescriptionValue.Text = selectedSPK.Description;
                lblSPKVehicleCustomerValue.Text = selectedSPK.Vehicle.Customer.CompanyName;
            }
            else
            {
                lblSPKCategoryValue.Text = "--";
                lblSPKDescriptionValue.Text = "--";
                lblSPKVehicleCustomerValue.Text = "--";
            }  
        }

        void SPKScheduleEditorForm_Load(object sender, EventArgs e)
        {
            _presenter.InitFormData();
        }

        #region FingerPrint
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
        #endregion

        #region Properties
        public SPKScheduleViewModel SelectedSPKSchedule { get; set; }

        public string SPKVehicleCustomer
        {
            get
            {
                return lblSPKVehicleCustomerValue.Text;
            }
            set
            {
                lblSPKVehicleCustomerValue.Text = value;
            }
        }

        public string SPKCategory
        {
            get
            {
                return lblSPKCategoryValue.Text;
            }
            set
            {
                lblSPKCategoryValue.Text = value;
            }
        }

        public string SPKDescription
        {
            get
            {
                return lblSPKDescriptionValue.Text;
            }
            set
            {
                lblSPKDescriptionValue.Text = value;
            }
        }

        public int SPKId
        {
            get
            {
                return lookUpSPK.EditValue.AsInteger();
            }
            set
            {
                lookUpSPK.EditValue = value;
            }
        }

        public List<SPKViewModel> SPKList
        {
            get
            {
                return lookUpSPK.Properties.DataSource as List<SPKViewModel>;
            }
            set
            {
                lookUpSPK.Properties.DataSource = value;
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

        public List<MechanicViewModel> MechanicList
        {
            get
            {
                return lookUpMechanic.Properties.DataSource as List<MechanicViewModel>;
            }
            set
            {
                lookUpMechanic.Properties.DataSource = value;
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
        #endregion

        protected override void ExecuteSave()
        {
            if (FieldValidator.Validate())
            {
                try
                {
                    MethodBase.GetCurrentMethod().Info("Save SPK Schedule's changes");
                    _presenter.SaveChanges();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MethodBase.GetCurrentMethod().Fatal("An error occured while trying to save guestbook", ex);
                    this.ShowError("Proses simpan penjadwalan harian SPK gagal!");
                }
            }
        }

    }
}