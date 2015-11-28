namespace BrawijayaWorkshop.Win32App.ModulForms
{
    partial class CustomerEditorForm
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
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule5 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule6 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerEditorForm));
            this.gcCustomerInfo = new DevExpress.XtraEditors.GroupControl();
            this.txtPhoneNumber = new DevExpress.XtraEditors.TextEdit();
            this.lblPhoneNumber = new DevExpress.XtraEditors.LabelControl();
            this.txtContactName = new DevExpress.XtraEditors.TextEdit();
            this.lblContactPerson = new DevExpress.XtraEditors.LabelControl();
            this.cbCity = new DevExpress.XtraEditors.LookUpEdit();
            this.lblCity = new DevExpress.XtraEditors.LabelControl();
            this.txtAddress = new DevExpress.XtraEditors.TextEdit();
            this.lblAddress = new DevExpress.XtraEditors.LabelControl();
            this.txtCompanyName = new DevExpress.XtraEditors.TextEdit();
            this.lblCompanyName = new DevExpress.XtraEditors.LabelControl();
            this.txtCode = new DevExpress.XtraEditors.TextEdit();
            this.lblCode = new DevExpress.XtraEditors.LabelControl();
            this.valCode = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.valCompanyName = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.valAddress = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.valCity = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.valContact = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.valPhone = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gcCustomerInfo)).BeginInit();
            this.gcCustomerInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhoneNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContactName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbCity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCompanyName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valCompanyName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valCity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valContact)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valPhone)).BeginInit();
            this.SuspendLayout();
            // 
            // gcCustomerInfo
            // 
            this.gcCustomerInfo.Controls.Add(this.txtPhoneNumber);
            this.gcCustomerInfo.Controls.Add(this.lblPhoneNumber);
            this.gcCustomerInfo.Controls.Add(this.txtContactName);
            this.gcCustomerInfo.Controls.Add(this.lblContactPerson);
            this.gcCustomerInfo.Controls.Add(this.cbCity);
            this.gcCustomerInfo.Controls.Add(this.lblCity);
            this.gcCustomerInfo.Controls.Add(this.txtAddress);
            this.gcCustomerInfo.Controls.Add(this.lblAddress);
            this.gcCustomerInfo.Controls.Add(this.txtCompanyName);
            this.gcCustomerInfo.Controls.Add(this.lblCompanyName);
            this.gcCustomerInfo.Controls.Add(this.txtCode);
            this.gcCustomerInfo.Controls.Add(this.lblCode);
            this.gcCustomerInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcCustomerInfo.Location = new System.Drawing.Point(0, 0);
            this.gcCustomerInfo.Name = "gcCustomerInfo";
            this.gcCustomerInfo.Size = new System.Drawing.Size(389, 210);
            this.gcCustomerInfo.TabIndex = 1;
            this.gcCustomerInfo.Text = "Informasi Customer";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(128, 177);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Properties.Mask.EditMask = "[0-9]*";
            this.txtPhoneNumber.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtPhoneNumber.Size = new System.Drawing.Size(162, 20);
            this.txtPhoneNumber.TabIndex = 11;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "No. Telp. harus diisi!";
            this.valPhone.SetValidationRule(this.txtPhoneNumber, conditionValidationRule1);
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.Location = new System.Drawing.Point(12, 180);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(44, 13);
            this.lblPhoneNumber.TabIndex = 10;
            this.lblPhoneNumber.Text = "No. Telp.";
            // 
            // txtContactName
            // 
            this.txtContactName.Location = new System.Drawing.Point(128, 147);
            this.txtContactName.Name = "txtContactName";
            this.txtContactName.Size = new System.Drawing.Size(247, 20);
            this.txtContactName.TabIndex = 9;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "Nama Kontak harus diisi!";
            this.valContact.SetValidationRule(this.txtContactName, conditionValidationRule2);
            // 
            // lblContactPerson
            // 
            this.lblContactPerson.Location = new System.Drawing.Point(12, 150);
            this.lblContactPerson.Name = "lblContactPerson";
            this.lblContactPerson.Size = new System.Drawing.Size(63, 13);
            this.lblContactPerson.TabIndex = 8;
            this.lblContactPerson.Text = "Nama Kontak";
            // 
            // cbCity
            // 
            this.cbCity.Location = new System.Drawing.Point(128, 117);
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
            this.cbCity.Size = new System.Drawing.Size(162, 20);
            this.cbCity.TabIndex = 7;
            conditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.NotEquals;
            conditionValidationRule3.ErrorText = "Pilih salah satu kota";
            conditionValidationRule3.Value1 = "-- Pilih Kota --";
            this.valCity.SetValidationRule(this.cbCity, conditionValidationRule3);
            // 
            // lblCity
            // 
            this.lblCity.Location = new System.Drawing.Point(12, 120);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(22, 13);
            this.lblCity.TabIndex = 6;
            this.lblCity.Text = "Kota";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(128, 87);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(247, 20);
            this.txtAddress.TabIndex = 5;
            conditionValidationRule4.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule4.ErrorText = "Alamat harus diisi!";
            this.valAddress.SetValidationRule(this.txtAddress, conditionValidationRule4);
            // 
            // lblAddress
            // 
            this.lblAddress.Location = new System.Drawing.Point(12, 90);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(33, 13);
            this.lblAddress.TabIndex = 4;
            this.lblAddress.Text = "Alamat";
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(128, 57);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(247, 20);
            this.txtCompanyName.TabIndex = 3;
            conditionValidationRule5.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule5.ErrorText = "Nama Perusahaan harus diisi!";
            this.valCompanyName.SetValidationRule(this.txtCompanyName, conditionValidationRule5);
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.Location = new System.Drawing.Point(12, 60);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(87, 13);
            this.lblCompanyName.TabIndex = 2;
            this.lblCompanyName.Text = "Nama Perusahaan";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(128, 29);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(115, 20);
            this.txtCode.TabIndex = 1;
            conditionValidationRule6.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule6.ErrorText = "Kode harus diisi!";
            this.valCode.SetValidationRule(this.txtCode, conditionValidationRule6);
            // 
            // lblCode
            // 
            this.lblCode.Location = new System.Drawing.Point(12, 30);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(24, 13);
            this.lblCode.TabIndex = 0;
            this.lblCode.Text = "Kode";
            // 
            // valCode
            // 
            this.valCode.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual;
            // 
            // valCompanyName
            // 
            this.valCompanyName.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual;
            // 
            // valAddress
            // 
            this.valAddress.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual;
            // 
            // valCity
            // 
            this.valCity.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual;
            // 
            // valContact
            // 
            this.valContact.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual;
            // 
            // valPhone
            // 
            this.valPhone.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual;
            // 
            // CustomerEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 259);
            this.Controls.Add(this.gcCustomerInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CustomerEditorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Editor";
            this.Controls.SetChildIndex(this.gcCustomerInfo, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gcCustomerInfo)).EndInit();
            this.gcCustomerInfo.ResumeLayout(false);
            this.gcCustomerInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhoneNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContactName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbCity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCompanyName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valCompanyName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valCity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valContact)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valPhone)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gcCustomerInfo;
        private DevExpress.XtraEditors.LabelControl lblCode;
        private DevExpress.XtraEditors.TextEdit txtAddress;
        private DevExpress.XtraEditors.LabelControl lblAddress;
        private DevExpress.XtraEditors.TextEdit txtCompanyName;
        private DevExpress.XtraEditors.LabelControl lblCompanyName;
        private DevExpress.XtraEditors.TextEdit txtCode;
        private DevExpress.XtraEditors.LookUpEdit cbCity;
        private DevExpress.XtraEditors.LabelControl lblCity;
        private DevExpress.XtraEditors.TextEdit txtContactName;
        private DevExpress.XtraEditors.LabelControl lblContactPerson;
        private DevExpress.XtraEditors.TextEdit txtPhoneNumber;
        private DevExpress.XtraEditors.LabelControl lblPhoneNumber;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider valCode;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider valPhone;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider valContact;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider valCity;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider valAddress;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider valCompanyName;
    }
}