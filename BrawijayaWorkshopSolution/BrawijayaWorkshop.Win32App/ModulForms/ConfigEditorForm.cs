﻿using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.Presenter;
using BrawijayaWorkshop.Utils;
using BrawijayaWorkshop.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Windows.Forms;

namespace BrawijayaWorkshop.Win32App.ModulForms
{
    public partial class ConfigEditorForm : BaseEditorForm, IConfigEditorView
    {
        private ConfigEditorPresenter _presenter;

        public zkemkeeper.CZKEMClass axCZKEM1 = new zkemkeeper.CZKEMClass();

        public ConfigEditorForm(ConfigEditorModel model)
        {
            InitializeComponent();

            _presenter = new ConfigEditorPresenter(this, model);

            this.Load += ConfigEditorForm_Load;
        }

        private void ConfigEditorForm_Load(object sender, EventArgs e)
        {
            _presenter.InitFormData();
        }

        public List<Setting> ListSettings { get; set; }

        public string MinStockQuantity
        {
            get
            {
                return txtMinStockQty.Text;
            }
            set
            {
                txtMinStockQty.Text = value;
            }
        }

        public string FingerprintIpAddress
        {
            get
            {
                return txtIpAddress.Text;
            }
            set
            {
                txtIpAddress.Text = value;
            }
        }

        public string FingerprintPort
        {
            get
            {
                return txtPort.Text;
            }
            set
            {
                txtPort.Text = value;
            }
        }

        private void btnCheckFingerprintConnection_Click(object sender, EventArgs e)
        {
            if(!bgwFingerprint.IsBusy)
            {
                Cursor = Cursors.WaitCursor;
                lblFingerprintStatus.Text = "Sedang memproses";
                bgwFingerprint.RunWorkerAsync();
            }
        }

        private void bgwFingerprint_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                bool isConnected = axCZKEM1.Connect_Net(txtIpAddress.Text, Convert.ToInt32(txtPort.Text));
                e.Result = isConnected;
            }
            catch (Exception ex)
            {
                MethodBase.GetCurrentMethod().Fatal("An error occured while trying to connect to fingerprint device", ex);
                e.Result = ex;
            }
        }

        private void bgwFingerprint_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Cursor = Cursors.Default;
            if (e.Result is Exception)
            {
                this.ShowError("Koneksi ke fingerprint gagal!");
                lblFingerprintStatus.Text = "Belum terhubung";
            }
            else
            {
                if (e.Result.AsBoolean())
                {
                    lblFingerprintStatus.Text = "Sukses";
                }
                else
                {
                    lblFingerprintStatus.Text = "Gagal";
                }
                axCZKEM1.Disconnect();
            }
        }

        protected override void ExecuteSave()
        {
            if (!bgwSaveData.IsBusy)
            {
                Cursor = Cursors.WaitCursor;
                bgwSaveData.RunWorkerAsync();
            }
        }

        private void bgwSaveData_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                _presenter.SaveAllConfig();
            }
            catch (Exception ex)
            {
                MethodBase.GetCurrentMethod().Fatal("An error occured while trying to save all settings", ex);
                e.Result = ex;
            }
        }

        private void bgwSaveData_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Cursor = Cursors.Default;
            if (e.Result is Exception)
            {
                this.ShowError("Proses simpan gagal");
            }
            else
            {
                this.ShowInformation("Proses simpan berhasil");
            }
        }
    }
}