﻿namespace BrawijayaWorkshop.Win32App.ModulForms
{
    partial class MechanicEditorForm
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
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule3 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule4 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule5 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.gcMechanicInfo = new DevExpress.XtraEditors.GroupControl();
            this.txtPhoneNumber = new DevExpress.XtraEditors.TextEdit();
            this.lblPhoneNumber = new DevExpress.XtraEditors.LabelControl();
            this.txtAddress = new DevExpress.XtraEditors.TextEdit();
            this.lblAddress = new DevExpress.XtraEditors.LabelControl();
            this.txtMechanicName = new DevExpress.XtraEditors.TextEdit();
            this.lblMechanicName = new DevExpress.XtraEditors.LabelControl();
            this.valMechanicName = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.valAddress = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.valPhone = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.valCode = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.txtCode = new DevExpress.XtraEditors.TextEdit();
            this.lblMechanicCode = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gcMechanicInfo)).BeginInit();
            this.gcMechanicInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhoneNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMechanicName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valMechanicName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valPhone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gcMechanicInfo
            // 
            this.gcMechanicInfo.Controls.Add(this.lblMechanicCode);
            this.gcMechanicInfo.Controls.Add(this.txtCode);
            this.gcMechanicInfo.Controls.Add(this.txtPhoneNumber);
            this.gcMechanicInfo.Controls.Add(this.lblPhoneNumber);
            this.gcMechanicInfo.Controls.Add(this.txtAddress);
            this.gcMechanicInfo.Controls.Add(this.lblAddress);
            this.gcMechanicInfo.Controls.Add(this.txtMechanicName);
            this.gcMechanicInfo.Controls.Add(this.lblMechanicName);
            this.gcMechanicInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcMechanicInfo.Location = new System.Drawing.Point(0, 0);
            this.gcMechanicInfo.Name = "gcMechanicInfo";
            this.gcMechanicInfo.Size = new System.Drawing.Size(386, 221);
            this.gcMechanicInfo.TabIndex = 1;
            this.gcMechanicInfo.Text = "Informasi Mechanic";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(127, 131);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Properties.Mask.EditMask = "[0-9]*";
            this.txtPhoneNumber.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtPhoneNumber.Size = new System.Drawing.Size(162, 20);
            this.txtPhoneNumber.TabIndex = 11;
            conditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule3.ErrorText = "No. Telp. harus diisi!";
            this.valPhone.SetValidationRule(this.txtPhoneNumber, conditionValidationRule3);
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.Location = new System.Drawing.Point(11, 134);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(44, 13);
            this.lblPhoneNumber.TabIndex = 10;
            this.lblPhoneNumber.Text = "No. Telp.";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(127, 99);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(247, 20);
            this.txtAddress.TabIndex = 5;
            conditionValidationRule4.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule4.ErrorText = "Alamat harus diisi!";
            this.valAddress.SetValidationRule(this.txtAddress, conditionValidationRule4);
            // 
            // lblAddress
            // 
            this.lblAddress.Location = new System.Drawing.Point(11, 102);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(33, 13);
            this.lblAddress.TabIndex = 4;
            this.lblAddress.Text = "Alamat";
            // 
            // txtMechanicName
            // 
            this.txtMechanicName.Location = new System.Drawing.Point(127, 69);
            this.txtMechanicName.Name = "txtMechanicName";
            this.txtMechanicName.Size = new System.Drawing.Size(247, 20);
            this.txtMechanicName.TabIndex = 3;
            conditionValidationRule5.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule5.ErrorText = "Nama Mechanic harus diisi!";
            this.valMechanicName.SetValidationRule(this.txtMechanicName, conditionValidationRule5);
            // 
            // lblMechanicName
            // 
            this.lblMechanicName.Location = new System.Drawing.Point(11, 72);
            this.lblMechanicName.Name = "lblMechanicName";
            this.lblMechanicName.Size = new System.Drawing.Size(74, 13);
            this.lblMechanicName.TabIndex = 2;
            this.lblMechanicName.Text = "Nama Mechanic";
            // 
            // valMechanicName
            // 
            this.valMechanicName.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual;
            // 
            // valAddress
            // 
            this.valAddress.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual;
            // 
            // valPhone
            // 
            this.valPhone.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual;
            // 
            // valCode
            // 
            this.valCode.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual;
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(127, 32);
            this.txtCode.Name = "txtCode";
            this.txtCode.Properties.Mask.EditMask = "[0-9]*";
            this.txtCode.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtCode.Size = new System.Drawing.Size(162, 20);
            this.txtCode.TabIndex = 12;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "Code harus diisi!";
            this.valCode.SetValidationRule(this.txtCode, conditionValidationRule1);
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "No. Telp. harus diisi!";
            this.valPhone.SetValidationRule(this.txtCode, conditionValidationRule2);
            // 
            // lblMechanicCode
            // 
            this.lblMechanicCode.Location = new System.Drawing.Point(11, 35);
            this.lblMechanicCode.Name = "lblMechanicCode";
            this.lblMechanicCode.Size = new System.Drawing.Size(25, 13);
            this.lblMechanicCode.TabIndex = 13;
            this.lblMechanicCode.Text = "Code";
            // 
            // MechanicEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 221);
            this.Controls.Add(this.gcMechanicInfo);
            this.Name = "MechanicEditorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mechanic Editor";
            this.Controls.SetChildIndex(this.gcMechanicInfo, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gcMechanicInfo)).EndInit();
            this.gcMechanicInfo.ResumeLayout(false);
            this.gcMechanicInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhoneNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMechanicName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valMechanicName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valPhone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gcMechanicInfo;
        private DevExpress.XtraEditors.LabelControl lblCode;
        private DevExpress.XtraEditors.TextEdit txtAddress;
        private DevExpress.XtraEditors.LabelControl lblAddress;
        private DevExpress.XtraEditors.TextEdit txtMechanicName;
        private DevExpress.XtraEditors.LabelControl lblMechanicName;
        private DevExpress.XtraEditors.TextEdit txtPhoneNumber;
        private DevExpress.XtraEditors.LabelControl lblPhoneNumber;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider valPhone;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider valAddress;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider valMechanicName;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider valCode;
        private DevExpress.XtraEditors.LabelControl lblMechanicCode;
        private DevExpress.XtraEditors.TextEdit txtCode;
    }
}