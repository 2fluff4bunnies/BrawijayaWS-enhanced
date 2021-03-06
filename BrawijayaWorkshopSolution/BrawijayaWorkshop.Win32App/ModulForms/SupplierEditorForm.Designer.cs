﻿namespace BrawijayaWorkshop.Win32App.ModulForms
{
    partial class SupplierEditorForm
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
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule3 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule4 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SupplierEditorForm));
            this.gcSupplierInfo = new DevExpress.XtraEditors.GroupControl();
            this.cbCity = new DevExpress.XtraEditors.LookUpEdit();
            this.lblCity = new DevExpress.XtraEditors.LabelControl();
            this.txtPhoneNumber = new DevExpress.XtraEditors.TextEdit();
            this.lblPhoneNumber = new DevExpress.XtraEditors.LabelControl();
            this.txtAddress = new DevExpress.XtraEditors.TextEdit();
            this.lblAddress = new DevExpress.XtraEditors.LabelControl();
            this.txtSupplierName = new DevExpress.XtraEditors.TextEdit();
            this.lblSupplierName = new DevExpress.XtraEditors.LabelControl();
            this.valSupplierName = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.valAddress = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.valPhone = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.valCity = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gcSupplierInfo)).BeginInit();
            this.gcSupplierInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbCity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhoneNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSupplierName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valSupplierName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valPhone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valCity)).BeginInit();
            this.SuspendLayout();
            // 
            // gcSupplierInfo
            // 
            this.gcSupplierInfo.Controls.Add(this.cbCity);
            this.gcSupplierInfo.Controls.Add(this.lblCity);
            this.gcSupplierInfo.Controls.Add(this.txtPhoneNumber);
            this.gcSupplierInfo.Controls.Add(this.lblPhoneNumber);
            this.gcSupplierInfo.Controls.Add(this.txtAddress);
            this.gcSupplierInfo.Controls.Add(this.lblAddress);
            this.gcSupplierInfo.Controls.Add(this.txtSupplierName);
            this.gcSupplierInfo.Controls.Add(this.lblSupplierName);
            this.gcSupplierInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcSupplierInfo.Location = new System.Drawing.Point(0, 0);
            this.gcSupplierInfo.Name = "gcSupplierInfo";
            this.gcSupplierInfo.Size = new System.Drawing.Size(363, 154);
            this.gcSupplierInfo.TabIndex = 1;
            this.gcSupplierInfo.Text = "Informasi Supplier";
            // 
            // cbCity
            // 
            this.cbCity.Location = new System.Drawing.Point(104, 122);
            this.cbCity.Name = "cbCity";
            this.cbCity.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.cbCity.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbCity.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Kode Kota"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Nama")});
            this.cbCity.Properties.DisplayMember = "Name";
            this.cbCity.Properties.HideSelection = false;
            this.cbCity.Properties.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned;
            this.cbCity.Properties.NullText = "-- Pilih Kota --";
            this.cbCity.Properties.ValueMember = "Id";
            this.cbCity.Size = new System.Drawing.Size(246, 20);
            this.cbCity.TabIndex = 13;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "Pilih kota!";
            this.valCity.SetValidationRule(this.cbCity, conditionValidationRule1);
            // 
            // lblCity
            // 
            this.lblCity.Location = new System.Drawing.Point(12, 125);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(22, 13);
            this.lblCity.TabIndex = 12;
            this.lblCity.Text = "Kota";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(104, 91);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Properties.Mask.EditMask = "[0-9]*";
            this.txtPhoneNumber.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtPhoneNumber.Size = new System.Drawing.Size(246, 20);
            this.txtPhoneNumber.TabIndex = 11;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "No. Telp. harus diisi!";
            this.valPhone.SetValidationRule(this.txtPhoneNumber, conditionValidationRule2);
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.Location = new System.Drawing.Point(12, 94);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(44, 13);
            this.lblPhoneNumber.TabIndex = 10;
            this.lblPhoneNumber.Text = "No. Telp.";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(104, 60);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(246, 20);
            this.txtAddress.TabIndex = 5;
            conditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule3.ErrorText = "Alamat harus diisi!";
            this.valAddress.SetValidationRule(this.txtAddress, conditionValidationRule3);
            // 
            // lblAddress
            // 
            this.lblAddress.Location = new System.Drawing.Point(12, 63);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(33, 13);
            this.lblAddress.TabIndex = 4;
            this.lblAddress.Text = "Alamat";
            // 
            // txtSupplierName
            // 
            this.txtSupplierName.Location = new System.Drawing.Point(104, 29);
            this.txtSupplierName.Name = "txtSupplierName";
            this.txtSupplierName.Size = new System.Drawing.Size(246, 20);
            this.txtSupplierName.TabIndex = 3;
            conditionValidationRule4.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule4.ErrorText = "Nama Supplier harus diisi!";
            this.valSupplierName.SetValidationRule(this.txtSupplierName, conditionValidationRule4);
            // 
            // lblSupplierName
            // 
            this.lblSupplierName.Location = new System.Drawing.Point(12, 32);
            this.lblSupplierName.Name = "lblSupplierName";
            this.lblSupplierName.Size = new System.Drawing.Size(68, 13);
            this.lblSupplierName.TabIndex = 2;
            this.lblSupplierName.Text = "Nama Supplier";
            // 
            // valSupplierName
            // 
            this.valSupplierName.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual;
            // 
            // valAddress
            // 
            this.valAddress.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual;
            // 
            // valPhone
            // 
            this.valPhone.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual;
            // 
            // SupplierEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 203);
            this.Controls.Add(this.gcSupplierInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SupplierEditorForm";
            this.Text = "Supplier Editor";
            this.Controls.SetChildIndex(this.gcSupplierInfo, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gcSupplierInfo)).EndInit();
            this.gcSupplierInfo.ResumeLayout(false);
            this.gcSupplierInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbCity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhoneNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSupplierName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valSupplierName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valPhone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valCity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gcSupplierInfo;
        private DevExpress.XtraEditors.LabelControl lblCode;
        private DevExpress.XtraEditors.TextEdit txtAddress;
        private DevExpress.XtraEditors.LabelControl lblAddress;
        private DevExpress.XtraEditors.TextEdit txtSupplierName;
        private DevExpress.XtraEditors.LabelControl lblSupplierName;
        private DevExpress.XtraEditors.TextEdit txtPhoneNumber;
        private DevExpress.XtraEditors.LabelControl lblPhoneNumber;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider valPhone;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider valAddress;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider valSupplierName;
        private DevExpress.XtraEditors.LookUpEdit cbCity;
        private DevExpress.XtraEditors.LabelControl lblCity;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider valCity;
    }
}