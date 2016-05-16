namespace BrawijayaWorkshop.Win32App.ModulForms
{
    partial class SPKScheduleEditorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SPKScheduleEditorForm));
            this.gcVehicleInfo = new DevExpress.XtraEditors.GroupControl();
            this.memoDescription = new DevExpress.XtraEditors.MemoEdit();
            this.lookUpMechanic = new DevExpress.XtraEditors.LookUpEdit();
            this.lblDescription = new DevExpress.XtraEditors.LabelControl();
            this.lookUpSPK = new DevExpress.XtraEditors.LookUpEdit();
            this.lblSPKDescriptionValue = new DevExpress.XtraEditors.LabelControl();
            this.lblSPKVehicleCustomerValue = new DevExpress.XtraEditors.LabelControl();
            this.lblSPKCategoryValue = new DevExpress.XtraEditors.LabelControl();
            this.lblSPKDescription = new DevExpress.XtraEditors.LabelControl();
            this.lblLicenseNumber = new DevExpress.XtraEditors.LabelControl();
            this.lblSPKVehicleCustomer = new DevExpress.XtraEditors.LabelControl();
            this.lblSPKCategory = new DevExpress.XtraEditors.LabelControl();
            this.lblMechanic = new DevExpress.XtraEditors.LabelControl();
            this.bgwFingerPrint = new System.ComponentModel.BackgroundWorker();
            this.FieldValidator = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.dtpDate = new DevExpress.XtraEditors.DateEdit();
            this.lblDate = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gcVehicleInfo)).BeginInit();
            this.gcVehicleInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpMechanic.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpSPK.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FieldValidator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDate.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gcVehicleInfo
            // 
            this.gcVehicleInfo.Controls.Add(this.lblDate);
            this.gcVehicleInfo.Controls.Add(this.dtpDate);
            this.gcVehicleInfo.Controls.Add(this.memoDescription);
            this.gcVehicleInfo.Controls.Add(this.lookUpMechanic);
            this.gcVehicleInfo.Controls.Add(this.lblDescription);
            this.gcVehicleInfo.Controls.Add(this.lookUpSPK);
            this.gcVehicleInfo.Controls.Add(this.lblSPKDescriptionValue);
            this.gcVehicleInfo.Controls.Add(this.lblSPKVehicleCustomerValue);
            this.gcVehicleInfo.Controls.Add(this.lblSPKCategoryValue);
            this.gcVehicleInfo.Controls.Add(this.lblSPKDescription);
            this.gcVehicleInfo.Controls.Add(this.lblLicenseNumber);
            this.gcVehicleInfo.Controls.Add(this.lblSPKVehicleCustomer);
            this.gcVehicleInfo.Controls.Add(this.lblSPKCategory);
            this.gcVehicleInfo.Controls.Add(this.lblMechanic);
            this.gcVehicleInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcVehicleInfo.Location = new System.Drawing.Point(0, 0);
            this.gcVehicleInfo.Name = "gcVehicleInfo";
            this.gcVehicleInfo.Size = new System.Drawing.Size(636, 226);
            this.gcVehicleInfo.TabIndex = 3;
            this.gcVehicleInfo.Text = "Informasi Kendaraan";
            // 
            // memoDescription
            // 
            this.memoDescription.Location = new System.Drawing.Point(143, 128);
            this.memoDescription.Name = "memoDescription";
            this.memoDescription.Size = new System.Drawing.Size(154, 82);
            this.memoDescription.TabIndex = 23;
            // 
            // lookUpMechanic
            // 
            this.lookUpMechanic.Location = new System.Drawing.Point(143, 64);
            this.lookUpMechanic.Name = "lookUpMechanic";
            this.lookUpMechanic.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.lookUpMechanic.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.lookUpMechanic.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpMechanic.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Nama")});
            this.lookUpMechanic.Properties.DisplayMember = "Name";
            this.lookUpMechanic.Properties.HideSelection = false;
            this.lookUpMechanic.Properties.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned;
            this.lookUpMechanic.Properties.NullText = "-- Pilih Mekanik --";
            this.lookUpMechanic.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lookUpMechanic.Properties.ValueMember = "Id";
            this.lookUpMechanic.Size = new System.Drawing.Size(154, 20);
            this.lookUpMechanic.TabIndex = 22;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "Mekanik Harus Dipilih";
            this.FieldValidator.SetValidationRule(this.lookUpMechanic, conditionValidationRule1);
            // 
            // lblDescription
            // 
            this.lblDescription.Location = new System.Drawing.Point(12, 130);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(114, 13);
            this.lblDescription.TabIndex = 20;
            this.lblDescription.Text = "Keterangan Pengerjaan";
            // 
            // lookUpSPK
            // 
            this.lookUpSPK.Location = new System.Drawing.Point(143, 32);
            this.lookUpSPK.Name = "lookUpSPK";
            this.lookUpSPK.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.lookUpSPK.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.lookUpSPK.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpSPK.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Kode"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ActiveLicenseNumber", "Nopol"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CompanyName", "Customer")});
            this.lookUpSPK.Properties.DisplayMember = "Code";
            this.lookUpSPK.Properties.HideSelection = false;
            this.lookUpSPK.Properties.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned;
            this.lookUpSPK.Properties.NullText = "-- Pilih SPK --";
            this.lookUpSPK.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lookUpSPK.Properties.ValueMember = "Id";
            this.lookUpSPK.Size = new System.Drawing.Size(154, 20);
            this.lookUpSPK.TabIndex = 19;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "SPK Harus dipilih";
            this.FieldValidator.SetValidationRule(this.lookUpSPK, conditionValidationRule2);
            // 
            // lblSPKDescriptionValue
            // 
            this.lblSPKDescriptionValue.Location = new System.Drawing.Point(456, 99);
            this.lblSPKDescriptionValue.Name = "lblSPKDescriptionValue";
            this.lblSPKDescriptionValue.Size = new System.Drawing.Size(8, 13);
            this.lblSPKDescriptionValue.TabIndex = 18;
            this.lblSPKDescriptionValue.Text = "--";
            // 
            // lblSPKVehicleCustomerValue
            // 
            this.lblSPKVehicleCustomerValue.Location = new System.Drawing.Point(456, 35);
            this.lblSPKVehicleCustomerValue.Name = "lblSPKVehicleCustomerValue";
            this.lblSPKVehicleCustomerValue.Size = new System.Drawing.Size(8, 13);
            this.lblSPKVehicleCustomerValue.TabIndex = 16;
            this.lblSPKVehicleCustomerValue.Text = "--";
            // 
            // lblSPKCategoryValue
            // 
            this.lblSPKCategoryValue.Location = new System.Drawing.Point(456, 67);
            this.lblSPKCategoryValue.Name = "lblSPKCategoryValue";
            this.lblSPKCategoryValue.Size = new System.Drawing.Size(8, 13);
            this.lblSPKCategoryValue.TabIndex = 15;
            this.lblSPKCategoryValue.Text = "--";
            // 
            // lblSPKDescription
            // 
            this.lblSPKDescription.Location = new System.Drawing.Point(341, 99);
            this.lblSPKDescription.Name = "lblSPKDescription";
            this.lblSPKDescription.Size = new System.Drawing.Size(77, 13);
            this.lblSPKDescription.TabIndex = 11;
            this.lblSPKDescription.Text = "Keterangan SPK";
            // 
            // lblLicenseNumber
            // 
            this.lblLicenseNumber.Location = new System.Drawing.Point(12, 35);
            this.lblLicenseNumber.Name = "lblLicenseNumber";
            this.lblLicenseNumber.Size = new System.Drawing.Size(18, 13);
            this.lblLicenseNumber.TabIndex = 9;
            this.lblLicenseNumber.Text = "SPK";
            // 
            // lblSPKVehicleCustomer
            // 
            this.lblSPKVehicleCustomer.Location = new System.Drawing.Point(341, 35);
            this.lblSPKVehicleCustomer.Name = "lblSPKVehicleCustomer";
            this.lblSPKVehicleCustomer.Size = new System.Drawing.Size(77, 13);
            this.lblSPKVehicleCustomer.TabIndex = 6;
            this.lblSPKVehicleCustomer.Text = "Nopol/Customer";
            // 
            // lblSPKCategory
            // 
            this.lblSPKCategory.Location = new System.Drawing.Point(341, 67);
            this.lblSPKCategory.Name = "lblSPKCategory";
            this.lblSPKCategory.Size = new System.Drawing.Size(40, 13);
            this.lblSPKCategory.TabIndex = 4;
            this.lblSPKCategory.Text = "Kategori";
            // 
            // lblMechanic
            // 
            this.lblMechanic.Location = new System.Drawing.Point(12, 67);
            this.lblMechanic.Name = "lblMechanic";
            this.lblMechanic.Size = new System.Drawing.Size(38, 13);
            this.lblMechanic.TabIndex = 2;
            this.lblMechanic.Text = "Mekanik";
            // 
            // bgwFingerPrint
            // 
            this.bgwFingerPrint.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwFingerPrint_DoWork);
            this.bgwFingerPrint.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwFingerPrint_RunWorkerCompleted);
            // 
            // dtpDate
            // 
            this.dtpDate.EditValue = null;
            this.dtpDate.Location = new System.Drawing.Point(143, 96);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.dtpDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpDate.Properties.DisplayFormat.FormatString = "dd-MM-yyyy";
            this.dtpDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpDate.Properties.Mask.EditMask = "dd-MM-yyyy";
            this.dtpDate.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.dtpDate.Size = new System.Drawing.Size(154, 20);
            this.dtpDate.TabIndex = 24;
            // 
            // lblDate
            // 
            this.lblDate.Location = new System.Drawing.Point(12, 99);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(66, 13);
            this.lblDate.TabIndex = 25;
            this.lblDate.Text = "Tanggal Kerja";
            // 
            // SPKScheduleEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 275);
            this.Controls.Add(this.gcVehicleInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SPKScheduleEditorForm";
            this.Text = "Form Penjadwalan Harian SPK";
            this.Controls.SetChildIndex(this.gcVehicleInfo, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gcVehicleInfo)).EndInit();
            this.gcVehicleInfo.ResumeLayout(false);
            this.gcVehicleInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpMechanic.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpSPK.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FieldValidator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDate.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gcVehicleInfo;
        private DevExpress.XtraEditors.LookUpEdit lookUpMechanic;
        private DevExpress.XtraEditors.LabelControl lblDescription;
        private DevExpress.XtraEditors.LookUpEdit lookUpSPK;
        private DevExpress.XtraEditors.LabelControl lblSPKDescriptionValue;
        private DevExpress.XtraEditors.LabelControl lblSPKVehicleCustomerValue;
        private DevExpress.XtraEditors.LabelControl lblSPKCategoryValue;
        private DevExpress.XtraEditors.LabelControl lblLicenseNumber;
        private DevExpress.XtraEditors.LabelControl lblSPKVehicleCustomer;
        private DevExpress.XtraEditors.LabelControl lblSPKCategory;
        private DevExpress.XtraEditors.LabelControl lblMechanic;
        private DevExpress.XtraEditors.MemoEdit memoDescription;
        private System.ComponentModel.BackgroundWorker bgwFingerPrint;
        private DevExpress.XtraEditors.LabelControl lblSPKDescription;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider FieldValidator;
        private DevExpress.XtraEditors.LabelControl lblDate;
        private DevExpress.XtraEditors.DateEdit dtpDate;
    }
}