using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.Presenter;
using BrawijayaWorkshop.View;
using BrawijayaWorkshop.Utils;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;

namespace BrawijayaWorkshop.Win32App.ModulForms
{
    public partial class MechanicEditorForm : BaseEditorForm, IMechanicEditorView
    {
        public zkemkeeper.CZKEMClass axCZKEM1 = new zkemkeeper.CZKEMClass();

        private MechanicEditorPresenter _presenter;
        private bool _isFingerprintConnected;

        public MechanicEditorForm(MechanicEditorModel model)
        {
            InitializeComponent();

            _presenter = new MechanicEditorPresenter(this, model);

            // set validation alignment
            valCode.SetIconAlignment(txtCode, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            valMechanicName.SetIconAlignment(txtMechanicName, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            valAddress.SetIconAlignment(txtAddress, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            valPhone.SetIconAlignment(txtPhoneNumber, System.Windows.Forms.ErrorIconAlignment.MiddleRight);

            this.Load += MechanicEditorForm_Load;
        }

        private void MechanicEditorForm_Load(object sender, EventArgs e)
        {
            _presenter.InitFormData();

            if (SelectedMechanic == null)
            {
                txtMechanicName.Properties.ReadOnly = true;
                txtPhoneNumber.Properties.ReadOnly = true;
                txtAddress.Properties.ReadOnly = true;
            }
            else
            {
                txtCode.ReadOnly = true;
                btnEnroll.Enabled = false;
                Cursor = Cursors.WaitCursor;
                bgwFingerprintConnection.RunWorkerAsync();
            }
        }

        public string FingerprintIP { get; set; }

        public string FingerpringPort { get; set; }

        public Mechanic SelectedMechanic { get; set; }

        #region Field Editor

        public string Code
        {
            get
            {
                return txtCode.Text;
            }
            set
            {
                txtCode.Text = value;
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

        public string Address
        {
            get
            {
                return txtAddress.Text;
            }
            set
            {
                txtAddress.Text = value;
            }
        }

        public string PhoneNumber
        {
            get
            {
                return txtPhoneNumber.Text;
            }
            set
            {
                txtPhoneNumber.Text = value;
            }
        }

        #endregion

        protected override void ExecuteSave()
        {
            if (bgwSave.IsBusy) return;

            if (valCode.Validate() && valMechanicName.Validate() && valAddress.Validate() && valPhone.Validate())
            {
                Cursor = Cursors.WaitCursor;
                bgwSave.RunWorkerAsync();
            }
        }

        private void bgwSave_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            try
            {
                string name = string.Empty;
                string pass = string.Empty;
                int priv = 0;
                bool enable = false;

                axCZKEM1.GetUserInfo(1, txtCode.Text.AsInteger(), ref name, ref pass, ref priv, ref enable);

                MethodBase.GetCurrentMethod().Info("Save mechanic's changes");
                _presenter.SaveChanges();

                axCZKEM1.SetUserInfo(1, txtCode.Text.AsInteger(), txtMechanicName.Text, pass, priv, true);

                e.Result = true;
            }
            catch (Exception ex)
            {
                MethodBase.GetCurrentMethod().Fatal("An error occured while trying to save mechanic: '" + SelectedMechanic.Name + "'", ex);
                e.Result = false;
            }
        }

        private void bgwSave_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            if (e.Result.AsBoolean())
            {
                axCZKEM1.Disconnect();
                this.Close();
            }
            else
            {
                this.ShowError("Proses simpan data mekanik: '" + SelectedMechanic.Name + "' gagal!");
            }
            Cursor = Cursors.Default;
        }

        private void btnEnroll_Click(object sender, EventArgs e)
        {
            if (!_isFingerprintConnected)
            {
                this.ShowWarning("Tidak ada koneksi dengan fingerprint device!");
                return;
            }

            try
            {
                int userId = txtCode.Text.AsInteger();
                int fingerIndex = 1;

                axCZKEM1.CancelOperation();
                axCZKEM1.DelUserTmp(1, userId, fingerIndex);
                if (axCZKEM1.StartEnroll(userId, fingerIndex))
                {
                    this.ShowWarning("Mohon letakkan jari pada fingerprint, lalu ikuti langkah-langkah verifikasi sampai selesai!");
                    axCZKEM1.StartIdentify();

                    txtCode.Properties.ReadOnly = true;
                    txtMechanicName.Properties.ReadOnly = false;
                    txtAddress.Properties.ReadOnly = false;
                    txtPhoneNumber.Properties.ReadOnly = false;
                }
                else
                {
                    int errorCode = 0;
                    axCZKEM1.GetLastError(ref errorCode);
                    MethodBase.GetCurrentMethod().Error("Unable to enroll user. Error Code: " + errorCode);
                    this.ShowError("Operasi gagal! Kode Error=" + errorCode.ToString());
                }
            }
            catch (Exception ex)
            {
                MethodBase.GetCurrentMethod().Fatal("An error occured while trying to enroll data", ex);
                this.ShowError("Operasi gagal!");
            }
        }

        private void bgwFingerprintConnection_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            try
            {
                bool isConnected = axCZKEM1.Connect_Net(FingerprintIP, Convert.ToInt32(FingerpringPort));
                e.Result = isConnected;
            }
            catch (Exception ex)
            {
                MethodBase.GetCurrentMethod().Fatal("An error occured while trying to connect to fingerprint device", ex);
                e.Result = ex;
            }
        }

        private void bgwFingerprintConnection_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            Cursor = Cursors.Default;
            if (e.Result is Exception)
            {
                this.ShowError("Koneksi ke fingerprint gagal!");
                _isFingerprintConnected = false;
            }
            else
            {
                if (e.Result.AsBoolean())
                {
                    _isFingerprintConnected = true;
                    axCZKEM1.RegEvent(1, 65535);
                }
                else
                {
                    int errorCode = 0;
                    axCZKEM1.GetLastError(ref errorCode);
                    this.ShowError("Koneksi ke fingerprint gagal! Kode Error=" + errorCode);
                    _isFingerprintConnected = false;
                }
            }
        }
    }
}