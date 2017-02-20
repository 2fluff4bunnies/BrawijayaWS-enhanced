﻿namespace BrawijayaWorkshop.Win32App.ModulForms
{
    partial class ConfigEditorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.CompareAgainstControlValidationRule compareAgainstControlValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.CompareAgainstControlValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigEditorForm));
            this.txtNewPassword = new DevExpress.XtraEditors.TextEdit();
            this.configTabControl = new DevExpress.XtraTab.XtraTabControl();
            this.tpFingerprint = new DevExpress.XtraTab.XtraTabPage();
            this.lblFingerprintStatus = new DevExpress.XtraEditors.LabelControl();
            this.btnCheckFingerprintConnection = new DevExpress.XtraEditors.SimpleButton();
            this.txtPort = new DevExpress.XtraEditors.TextEdit();
            this.lblPort = new DevExpress.XtraEditors.LabelControl();
            this.txtIpAddress = new DevExpress.XtraEditors.TextEdit();
            this.lblIpAddress = new DevExpress.XtraEditors.LabelControl();
            this.tpUserAccount = new DevExpress.XtraTab.XtraTabPage();
            this.gcChangePassword = new DevExpress.XtraEditors.GroupControl();
            this.btnChangePassword = new DevExpress.XtraEditors.SimpleButton();
            this.txtReTypeNewPassword = new DevExpress.XtraEditors.TextEdit();
            this.lblReTypeNewPass = new DevExpress.XtraEditors.LabelControl();
            this.lblNewPass = new DevExpress.XtraEditors.LabelControl();
            this.txtOldPassword = new DevExpress.XtraEditors.TextEdit();
            this.lblOldPassword = new DevExpress.XtraEditors.LabelControl();
            this.tpSparepart = new DevExpress.XtraTab.XtraTabPage();
            this.txtMinStockQty = new DevExpress.XtraEditors.TextEdit();
            this.lblStockMinQty = new DevExpress.XtraEditors.LabelControl();
            this.tpSPK = new DevExpress.XtraTab.XtraTabPage();
            this.txtSPKRepairLimit = new DevExpress.XtraEditors.TextEdit();
            this.lblSPKRepairLimit = new DevExpress.XtraEditors.LabelControl();
            this.txtSPKServiceLimit = new DevExpress.XtraEditors.TextEdit();
            this.lblSPKServiceLimit = new DevExpress.XtraEditors.LabelControl();
            this.bgwFingerprint = new System.ComponentModel.BackgroundWorker();
            this.bgwSaveData = new System.ComponentModel.BackgroundWorker();
            this.valOldPassword = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.valNewPassword = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.valReTypeNewPass = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.txtSPKContractLimit = new DevExpress.XtraEditors.TextEdit();
            this.lblSPKContractLimit = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtNewPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.configTabControl)).BeginInit();
            this.configTabControl.SuspendLayout();
            this.tpFingerprint.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPort.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIpAddress.Properties)).BeginInit();
            this.tpUserAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcChangePassword)).BeginInit();
            this.gcChangePassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtReTypeNewPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOldPassword.Properties)).BeginInit();
            this.tpSparepart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMinStockQty.Properties)).BeginInit();
            this.tpSPK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSPKRepairLimit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSPKServiceLimit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valOldPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valNewPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valReTypeNewPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSPKContractLimit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point(147, 64);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Properties.UseSystemPasswordChar = true;
            this.txtNewPassword.Size = new System.Drawing.Size(232, 20);
            this.txtNewPassword.TabIndex = 3;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "Password Baru harus diisi";
            this.valNewPassword.SetValidationRule(this.txtNewPassword, conditionValidationRule1);
            // 
            // configTabControl
            // 
            this.configTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.configTabControl.Location = new System.Drawing.Point(0, 0);
            this.configTabControl.Name = "configTabControl";
            this.configTabControl.SelectedTabPage = this.tpFingerprint;
            this.configTabControl.Size = new System.Drawing.Size(408, 193);
            this.configTabControl.TabIndex = 1;
            this.configTabControl.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tpUserAccount,
            this.tpFingerprint,
            this.tpSparepart,
            this.tpSPK});
            // 
            // tpFingerprint
            // 
            this.tpFingerprint.Controls.Add(this.lblFingerprintStatus);
            this.tpFingerprint.Controls.Add(this.btnCheckFingerprintConnection);
            this.tpFingerprint.Controls.Add(this.txtPort);
            this.tpFingerprint.Controls.Add(this.lblPort);
            this.tpFingerprint.Controls.Add(this.txtIpAddress);
            this.tpFingerprint.Controls.Add(this.lblIpAddress);
            this.tpFingerprint.Name = "tpFingerprint";
            this.tpFingerprint.Size = new System.Drawing.Size(402, 165);
            this.tpFingerprint.Text = "Fingerprint";
            // 
            // lblFingerprintStatus
            // 
            this.lblFingerprintStatus.Location = new System.Drawing.Point(101, 57);
            this.lblFingerprintStatus.Name = "lblFingerprintStatus";
            this.lblFingerprintStatus.Size = new System.Drawing.Size(83, 13);
            this.lblFingerprintStatus.TabIndex = 5;
            this.lblFingerprintStatus.Text = "Belum Terhubung";
            // 
            // btnCheckFingerprintConnection
            // 
            this.btnCheckFingerprintConnection.Location = new System.Drawing.Point(11, 52);
            this.btnCheckFingerprintConnection.Name = "btnCheckFingerprintConnection";
            this.btnCheckFingerprintConnection.Size = new System.Drawing.Size(75, 23);
            this.btnCheckFingerprintConnection.TabIndex = 4;
            this.btnCheckFingerprintConnection.Text = "Cek Koneksi";
            this.btnCheckFingerprintConnection.Click += new System.EventHandler(this.btnCheckFingerprintConnection_Click);
            // 
            // txtPort
            // 
            this.txtPort.EditValue = "4370";
            this.txtPort.Location = new System.Drawing.Point(234, 14);
            this.txtPort.Name = "txtPort";
            this.txtPort.Properties.Mask.EditMask = "\\d{1,4}";
            this.txtPort.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular;
            this.txtPort.Size = new System.Drawing.Size(51, 20);
            this.txtPort.TabIndex = 3;
            // 
            // lblPort
            // 
            this.lblPort.Location = new System.Drawing.Point(197, 17);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(20, 13);
            this.lblPort.TabIndex = 2;
            this.lblPort.Text = "Port";
            // 
            // txtIpAddress
            // 
            this.txtIpAddress.EditValue = "192.168.1.201";
            this.txtIpAddress.Location = new System.Drawing.Point(37, 14);
            this.txtIpAddress.Name = "txtIpAddress";
            this.txtIpAddress.Properties.Mask.EditMask = "\\d{1,3}\\.\\d{1,3}\\.\\d{1,3}\\.\\d{1,3}";
            this.txtIpAddress.Properties.Mask.IgnoreMaskBlank = false;
            this.txtIpAddress.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular;
            this.txtIpAddress.Size = new System.Drawing.Size(109, 20);
            this.txtIpAddress.TabIndex = 1;
            // 
            // lblIpAddress
            // 
            this.lblIpAddress.Location = new System.Drawing.Point(11, 17);
            this.lblIpAddress.Name = "lblIpAddress";
            this.lblIpAddress.Size = new System.Drawing.Size(10, 13);
            this.lblIpAddress.TabIndex = 0;
            this.lblIpAddress.Text = "IP";
            // 
            // tpUserAccount
            // 
            this.tpUserAccount.Controls.Add(this.gcChangePassword);
            this.tpUserAccount.Name = "tpUserAccount";
            this.tpUserAccount.Size = new System.Drawing.Size(402, 165);
            this.tpUserAccount.Text = "User Account";
            // 
            // gcChangePassword
            // 
            this.gcChangePassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcChangePassword.Controls.Add(this.btnChangePassword);
            this.gcChangePassword.Controls.Add(this.txtReTypeNewPassword);
            this.gcChangePassword.Controls.Add(this.lblReTypeNewPass);
            this.gcChangePassword.Controls.Add(this.txtNewPassword);
            this.gcChangePassword.Controls.Add(this.lblNewPass);
            this.gcChangePassword.Controls.Add(this.txtOldPassword);
            this.gcChangePassword.Controls.Add(this.lblOldPassword);
            this.gcChangePassword.Location = new System.Drawing.Point(3, 3);
            this.gcChangePassword.Name = "gcChangePassword";
            this.gcChangePassword.Size = new System.Drawing.Size(396, 159);
            this.gcChangePassword.TabIndex = 0;
            this.gcChangePassword.Text = "Ganti Password";
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Location = new System.Drawing.Point(147, 128);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(131, 23);
            this.btnChangePassword.TabIndex = 6;
            this.btnChangePassword.Text = "Ubah Password";
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // txtReTypeNewPassword
            // 
            this.txtReTypeNewPassword.Location = new System.Drawing.Point(147, 96);
            this.txtReTypeNewPassword.Name = "txtReTypeNewPassword";
            this.txtReTypeNewPassword.Properties.UseSystemPasswordChar = true;
            this.txtReTypeNewPassword.Size = new System.Drawing.Size(232, 20);
            this.txtReTypeNewPassword.TabIndex = 5;
            compareAgainstControlValidationRule1.CompareControlOperator = DevExpress.XtraEditors.DXErrorProvider.CompareControlOperator.Equals;
            compareAgainstControlValidationRule1.Control = this.txtNewPassword;
            compareAgainstControlValidationRule1.ErrorText = "Isian Password Baru harus sama";
            this.valReTypeNewPass.SetValidationRule(this.txtReTypeNewPassword, compareAgainstControlValidationRule1);
            // 
            // lblReTypeNewPass
            // 
            this.lblReTypeNewPass.Location = new System.Drawing.Point(12, 99);
            this.lblReTypeNewPass.Name = "lblReTypeNewPass";
            this.lblReTypeNewPass.Size = new System.Drawing.Size(103, 13);
            this.lblReTypeNewPass.TabIndex = 4;
            this.lblReTypeNewPass.Text = "Ulangi Password Baru";
            // 
            // lblNewPass
            // 
            this.lblNewPass.Location = new System.Drawing.Point(12, 67);
            this.lblNewPass.Name = "lblNewPass";
            this.lblNewPass.Size = new System.Drawing.Size(71, 13);
            this.lblNewPass.TabIndex = 2;
            this.lblNewPass.Text = "Password Baru";
            // 
            // txtOldPassword
            // 
            this.txtOldPassword.Location = new System.Drawing.Point(147, 32);
            this.txtOldPassword.Name = "txtOldPassword";
            this.txtOldPassword.Properties.UseSystemPasswordChar = true;
            this.txtOldPassword.Size = new System.Drawing.Size(232, 20);
            this.txtOldPassword.TabIndex = 1;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "Password Lama harus diisi";
            this.valOldPassword.SetValidationRule(this.txtOldPassword, conditionValidationRule2);
            // 
            // lblOldPassword
            // 
            this.lblOldPassword.Location = new System.Drawing.Point(12, 35);
            this.lblOldPassword.Name = "lblOldPassword";
            this.lblOldPassword.Size = new System.Drawing.Size(74, 13);
            this.lblOldPassword.TabIndex = 0;
            this.lblOldPassword.Text = "Password Lama";
            // 
            // tpSparepart
            // 
            this.tpSparepart.Controls.Add(this.txtMinStockQty);
            this.tpSparepart.Controls.Add(this.lblStockMinQty);
            this.tpSparepart.Name = "tpSparepart";
            this.tpSparepart.Size = new System.Drawing.Size(402, 165);
            this.tpSparepart.Text = "Sparepart";
            // 
            // txtMinStockQty
            // 
            this.txtMinStockQty.EditValue = "50";
            this.txtMinStockQty.Location = new System.Drawing.Point(137, 14);
            this.txtMinStockQty.Name = "txtMinStockQty";
            this.txtMinStockQty.Properties.Mask.EditMask = "[0-9]*";
            this.txtMinStockQty.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular;
            this.txtMinStockQty.Size = new System.Drawing.Size(110, 20);
            this.txtMinStockQty.TabIndex = 1;
            // 
            // lblStockMinQty
            // 
            this.lblStockMinQty.Location = new System.Drawing.Point(11, 17);
            this.lblStockMinQty.Name = "lblStockMinQty";
            this.lblStockMinQty.Size = new System.Drawing.Size(64, 13);
            this.lblStockMinQty.TabIndex = 0;
            this.lblStockMinQty.Text = "Stok Minimum";
            // 
            // tpSPK
            // 
            this.tpSPK.Controls.Add(this.txtSPKContractLimit);
            this.tpSPK.Controls.Add(this.lblSPKContractLimit);
            this.tpSPK.Controls.Add(this.txtSPKRepairLimit);
            this.tpSPK.Controls.Add(this.lblSPKRepairLimit);
            this.tpSPK.Controls.Add(this.txtSPKServiceLimit);
            this.tpSPK.Controls.Add(this.lblSPKServiceLimit);
            this.tpSPK.Name = "tpSPK";
            this.tpSPK.Size = new System.Drawing.Size(402, 165);
            this.tpSPK.Text = "SPK";
            // 
            // txtSPKRepairLimit
            // 
            this.txtSPKRepairLimit.Location = new System.Drawing.Point(103, 52);
            this.txtSPKRepairLimit.Name = "txtSPKRepairLimit";
            this.txtSPKRepairLimit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtSPKRepairLimit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtSPKRepairLimit.Size = new System.Drawing.Size(199, 20);
            this.txtSPKRepairLimit.TabIndex = 3;
            // 
            // lblSPKRepairLimit
            // 
            this.lblSPKRepairLimit.Location = new System.Drawing.Point(11, 55);
            this.lblSPKRepairLimit.Name = "lblSPKRepairLimit";
            this.lblSPKRepairLimit.Size = new System.Drawing.Size(71, 13);
            this.lblSPKRepairLimit.TabIndex = 2;
            this.lblSPKRepairLimit.Text = "Limit Perbaikan";
            // 
            // txtSPKServiceLimit
            // 
            this.txtSPKServiceLimit.Location = new System.Drawing.Point(103, 14);
            this.txtSPKServiceLimit.Name = "txtSPKServiceLimit";
            this.txtSPKServiceLimit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtSPKServiceLimit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtSPKServiceLimit.Size = new System.Drawing.Size(199, 20);
            this.txtSPKServiceLimit.TabIndex = 1;
            // 
            // lblSPKServiceLimit
            // 
            this.lblSPKServiceLimit.Location = new System.Drawing.Point(11, 17);
            this.lblSPKServiceLimit.Name = "lblSPKServiceLimit";
            this.lblSPKServiceLimit.Size = new System.Drawing.Size(59, 13);
            this.lblSPKServiceLimit.TabIndex = 0;
            this.lblSPKServiceLimit.Text = "Limit Service";
            // 
            // bgwFingerprint
            // 
            this.bgwFingerprint.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwFingerprint_DoWork);
            this.bgwFingerprint.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwFingerprint_RunWorkerCompleted);
            // 
            // bgwSaveData
            // 
            this.bgwSaveData.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwSaveData_DoWork);
            this.bgwSaveData.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwSaveData_RunWorkerCompleted);
            // 
            // valOldPassword
            // 
            this.valOldPassword.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual;
            // 
            // valNewPassword
            // 
            this.valNewPassword.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual;
            // 
            // valReTypeNewPass
            // 
            this.valReTypeNewPass.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual;
            // 
            // txtSPKContractLimit
            // 
            this.txtSPKContractLimit.Location = new System.Drawing.Point(103, 89);
            this.txtSPKContractLimit.Name = "txtSPKContractLimit";
            this.txtSPKContractLimit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtSPKContractLimit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtSPKContractLimit.Size = new System.Drawing.Size(199, 20);
            this.txtSPKContractLimit.TabIndex = 5;
            // 
            // lblSPKContractLimit
            // 
            this.lblSPKContractLimit.Location = new System.Drawing.Point(11, 92);
            this.lblSPKContractLimit.Name = "lblSPKContractLimit";
            this.lblSPKContractLimit.Size = new System.Drawing.Size(70, 13);
            this.lblSPKContractLimit.TabIndex = 4;
            this.lblSPKContractLimit.Text = "Limit Borongan";
            // 
            // ConfigEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 242);
            this.Controls.Add(this.configTabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConfigEditorForm";
            this.Text = "Konfigurasi";
            this.Controls.SetChildIndex(this.configTabControl, 0);
            ((System.ComponentModel.ISupportInitialize)(this.txtNewPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.configTabControl)).EndInit();
            this.configTabControl.ResumeLayout(false);
            this.tpFingerprint.ResumeLayout(false);
            this.tpFingerprint.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPort.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIpAddress.Properties)).EndInit();
            this.tpUserAccount.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcChangePassword)).EndInit();
            this.gcChangePassword.ResumeLayout(false);
            this.gcChangePassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtReTypeNewPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOldPassword.Properties)).EndInit();
            this.tpSparepart.ResumeLayout(false);
            this.tpSparepart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMinStockQty.Properties)).EndInit();
            this.tpSPK.ResumeLayout(false);
            this.tpSPK.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSPKRepairLimit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSPKServiceLimit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valOldPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valNewPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valReTypeNewPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSPKContractLimit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl configTabControl;
        private DevExpress.XtraTab.XtraTabPage tpFingerprint;
        private DevExpress.XtraTab.XtraTabPage tpSparepart;
        private DevExpress.XtraEditors.TextEdit txtPort;
        private DevExpress.XtraEditors.LabelControl lblPort;
        private DevExpress.XtraEditors.TextEdit txtIpAddress;
        private DevExpress.XtraEditors.LabelControl lblIpAddress;
        private DevExpress.XtraEditors.LabelControl lblFingerprintStatus;
        private DevExpress.XtraEditors.SimpleButton btnCheckFingerprintConnection;
        private System.ComponentModel.BackgroundWorker bgwFingerprint;
        private System.ComponentModel.BackgroundWorker bgwSaveData;
        private DevExpress.XtraEditors.LabelControl lblStockMinQty;
        private DevExpress.XtraEditors.TextEdit txtMinStockQty;
        private DevExpress.XtraTab.XtraTabPage tpUserAccount;
        private DevExpress.XtraEditors.GroupControl gcChangePassword;
        private DevExpress.XtraEditors.LabelControl lblOldPassword;
        private DevExpress.XtraEditors.SimpleButton btnChangePassword;
        private DevExpress.XtraEditors.TextEdit txtReTypeNewPassword;
        private DevExpress.XtraEditors.LabelControl lblReTypeNewPass;
        private DevExpress.XtraEditors.TextEdit txtNewPassword;
        private DevExpress.XtraEditors.LabelControl lblNewPass;
        private DevExpress.XtraEditors.TextEdit txtOldPassword;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider valOldPassword;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider valNewPassword;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider valReTypeNewPass;
        private DevExpress.XtraTab.XtraTabPage tpSPK;
        private DevExpress.XtraEditors.TextEdit txtSPKRepairLimit;
        private DevExpress.XtraEditors.LabelControl lblSPKRepairLimit;
        private DevExpress.XtraEditors.TextEdit txtSPKServiceLimit;
        private DevExpress.XtraEditors.LabelControl lblSPKServiceLimit;
        private DevExpress.XtraEditors.TextEdit txtSPKContractLimit;
        private DevExpress.XtraEditors.LabelControl lblSPKContractLimit;
    }
}