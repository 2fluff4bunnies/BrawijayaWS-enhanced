namespace BrawijayaWorkshop.Win32App.ModulForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigEditorForm));
            this.configTabControl = new DevExpress.XtraTab.XtraTabControl();
            this.tpFingerprint = new DevExpress.XtraTab.XtraTabPage();
            this.tpSparepart = new DevExpress.XtraTab.XtraTabPage();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtIpAddress = new DevExpress.XtraEditors.TextEdit();
            this.lblPort = new DevExpress.XtraEditors.LabelControl();
            this.txtPort = new DevExpress.XtraEditors.TextEdit();
            this.btnCheckFingerprintConnection = new DevExpress.XtraEditors.SimpleButton();
            this.lblFingerprintStatus = new DevExpress.XtraEditors.LabelControl();
            this.bgwFingerprint = new System.ComponentModel.BackgroundWorker();
            this.bgwSaveData = new System.ComponentModel.BackgroundWorker();
            this.lblStockMinQty = new DevExpress.XtraEditors.LabelControl();
            this.txtMinStockQty = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.configTabControl)).BeginInit();
            this.configTabControl.SuspendLayout();
            this.tpFingerprint.SuspendLayout();
            this.tpSparepart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtIpAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPort.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMinStockQty.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // configTabControl
            // 
            this.configTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.configTabControl.Location = new System.Drawing.Point(0, 0);
            this.configTabControl.Name = "configTabControl";
            this.configTabControl.SelectedTabPage = this.tpFingerprint;
            this.configTabControl.Size = new System.Drawing.Size(452, 195);
            this.configTabControl.TabIndex = 1;
            this.configTabControl.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tpFingerprint,
            this.tpSparepart});
            // 
            // tpFingerprint
            // 
            this.tpFingerprint.Controls.Add(this.lblFingerprintStatus);
            this.tpFingerprint.Controls.Add(this.btnCheckFingerprintConnection);
            this.tpFingerprint.Controls.Add(this.txtPort);
            this.tpFingerprint.Controls.Add(this.lblPort);
            this.tpFingerprint.Controls.Add(this.txtIpAddress);
            this.tpFingerprint.Controls.Add(this.labelControl1);
            this.tpFingerprint.Name = "tpFingerprint";
            this.tpFingerprint.Size = new System.Drawing.Size(446, 167);
            this.tpFingerprint.Text = "Fingerprint";
            // 
            // tpSparepart
            // 
            this.tpSparepart.Controls.Add(this.txtMinStockQty);
            this.tpSparepart.Controls.Add(this.lblStockMinQty);
            this.tpSparepart.Name = "tpSparepart";
            this.tpSparepart.Size = new System.Drawing.Size(446, 167);
            this.tpSparepart.Text = "Sparepart";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(11, 17);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(10, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "IP";
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
            // lblPort
            // 
            this.lblPort.Location = new System.Drawing.Point(197, 17);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(20, 13);
            this.lblPort.TabIndex = 2;
            this.lblPort.Text = "Port";
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
            // btnCheckFingerprintConnection
            // 
            this.btnCheckFingerprintConnection.Location = new System.Drawing.Point(11, 52);
            this.btnCheckFingerprintConnection.Name = "btnCheckFingerprintConnection";
            this.btnCheckFingerprintConnection.Size = new System.Drawing.Size(75, 23);
            this.btnCheckFingerprintConnection.TabIndex = 4;
            this.btnCheckFingerprintConnection.Text = "Cek Koneksi";
            this.btnCheckFingerprintConnection.Click += new System.EventHandler(this.btnCheckFingerprintConnection_Click);
            // 
            // lblFingerprintStatus
            // 
            this.lblFingerprintStatus.Location = new System.Drawing.Point(101, 57);
            this.lblFingerprintStatus.Name = "lblFingerprintStatus";
            this.lblFingerprintStatus.Size = new System.Drawing.Size(83, 13);
            this.lblFingerprintStatus.TabIndex = 5;
            this.lblFingerprintStatus.Text = "Belum Terhubung";
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
            // lblStockMinQty
            // 
            this.lblStockMinQty.Location = new System.Drawing.Point(11, 17);
            this.lblStockMinQty.Name = "lblStockMinQty";
            this.lblStockMinQty.Size = new System.Drawing.Size(64, 13);
            this.lblStockMinQty.TabIndex = 0;
            this.lblStockMinQty.Text = "Stok Minimum";
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
            // ConfigEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 244);
            this.Controls.Add(this.configTabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConfigEditorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Konfigurasi";
            this.Controls.SetChildIndex(this.configTabControl, 0);
            ((System.ComponentModel.ISupportInitialize)(this.configTabControl)).EndInit();
            this.configTabControl.ResumeLayout(false);
            this.tpFingerprint.ResumeLayout(false);
            this.tpFingerprint.PerformLayout();
            this.tpSparepart.ResumeLayout(false);
            this.tpSparepart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtIpAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPort.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMinStockQty.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl configTabControl;
        private DevExpress.XtraTab.XtraTabPage tpFingerprint;
        private DevExpress.XtraTab.XtraTabPage tpSparepart;
        private DevExpress.XtraEditors.TextEdit txtPort;
        private DevExpress.XtraEditors.LabelControl lblPort;
        private DevExpress.XtraEditors.TextEdit txtIpAddress;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl lblFingerprintStatus;
        private DevExpress.XtraEditors.SimpleButton btnCheckFingerprintConnection;
        private System.ComponentModel.BackgroundWorker bgwFingerprint;
        private System.ComponentModel.BackgroundWorker bgwSaveData;
        private DevExpress.XtraEditors.LabelControl lblStockMinQty;
        private DevExpress.XtraEditors.TextEdit txtMinStockQty;
    }
}