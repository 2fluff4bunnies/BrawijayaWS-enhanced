namespace BrawijayaWorkshop.Win32App.ModulForms
{
    partial class VehicleDetailEditorForm
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
            this.gcVehicleDetail = new DevExpress.XtraEditors.GroupControl();
            this.txtLicenseNumber = new DevExpress.XtraEditors.TextEdit();
            this.lblLicenseNumber = new DevExpress.XtraEditors.LabelControl();
            this.lblExpirationDate = new DevExpress.XtraEditors.LabelControl();
            this.valLicenseNumber = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.valExpirationDate = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.dtpExpirationDate = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gcVehicleDetail)).BeginInit();
            this.gcVehicleDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtLicenseNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valLicenseNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valExpirationDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpExpirationDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpExpirationDate.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gcVehicleDetail
            // 
            this.gcVehicleDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcVehicleDetail.Controls.Add(this.dtpExpirationDate);
            this.gcVehicleDetail.Controls.Add(this.lblExpirationDate);
            this.gcVehicleDetail.Controls.Add(this.lblLicenseNumber);
            this.gcVehicleDetail.Controls.Add(this.txtLicenseNumber);
            this.gcVehicleDetail.Location = new System.Drawing.Point(0, 2);
            this.gcVehicleDetail.Name = "gcVehicleDetail";
            this.gcVehicleDetail.Size = new System.Drawing.Size(309, 83);
            this.gcVehicleDetail.TabIndex = 1;
            this.gcVehicleDetail.Text = "Informasi Kendaraan";
            // 
            // txtLicenseNumber
            // 
            this.txtLicenseNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLicenseNumber.Location = new System.Drawing.Point(122, 27);
            this.txtLicenseNumber.Name = "txtLicenseNumber";
            this.txtLicenseNumber.Size = new System.Drawing.Size(175, 20);
            this.txtLicenseNumber.TabIndex = 0;
            // 
            // lblLicenseNumber
            // 
            this.lblLicenseNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLicenseNumber.Location = new System.Drawing.Point(12, 30);
            this.lblLicenseNumber.Name = "lblLicenseNumber";
            this.lblLicenseNumber.Size = new System.Drawing.Size(57, 13);
            this.lblLicenseNumber.TabIndex = 3;
            this.lblLicenseNumber.Text = "Nomor Polisi";
            // 
            // lblExpirationDate
            // 
            this.lblExpirationDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblExpirationDate.Location = new System.Drawing.Point(12, 55);
            this.lblExpirationDate.Name = "lblExpirationDate";
            this.lblExpirationDate.Size = new System.Drawing.Size(94, 13);
            this.lblExpirationDate.TabIndex = 4;
            this.lblExpirationDate.Text = "Tanggal Kadaluarsa";
            // 
            // dtpExpirationDate
            // 
            this.dtpExpirationDate.EditValue = null;
            this.dtpExpirationDate.Location = new System.Drawing.Point(122, 52);
            this.dtpExpirationDate.Name = "dtpExpirationDate";
            this.dtpExpirationDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpExpirationDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpExpirationDate.Size = new System.Drawing.Size(175, 20);
            this.dtpExpirationDate.TabIndex = 5;
            // 
            // VehicleDetailEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 137);
            this.Controls.Add(this.gcVehicleDetail);
            this.Name = "VehicleDetailEditorForm";
            this.Text = "Detail Kendaraan Editor";
            this.Controls.SetChildIndex(this.gcVehicleDetail, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gcVehicleDetail)).EndInit();
            this.gcVehicleDetail.ResumeLayout(false);
            this.gcVehicleDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtLicenseNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valLicenseNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valExpirationDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpExpirationDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpExpirationDate.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gcVehicleDetail;
        private DevExpress.XtraEditors.LabelControl lblExpirationDate;
        private DevExpress.XtraEditors.LabelControl lblLicenseNumber;
        private DevExpress.XtraEditors.TextEdit txtLicenseNumber;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider valLicenseNumber;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider valExpirationDate;
        private DevExpress.XtraEditors.DateEdit dtpExpirationDate;

    }
}