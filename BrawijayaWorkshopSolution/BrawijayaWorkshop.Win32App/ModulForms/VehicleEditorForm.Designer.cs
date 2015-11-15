namespace BrawijayaWorkshop.Win32App.ModulForms
{
    partial class VehicleEditorForm
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
            this.valCustomer = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.valBrand = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.valType = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.valYearOfBuy = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.lblCustomer = new DevExpress.XtraEditors.LabelControl();
            this.lblMerek = new DevExpress.XtraEditors.LabelControl();
            this.txtBrand = new DevExpress.XtraEditors.TextEdit();
            this.lblType = new DevExpress.XtraEditors.LabelControl();
            this.txtType = new DevExpress.XtraEditors.TextEdit();
            this.lblYearOfBuy = new DevExpress.XtraEditors.LabelControl();
            this.cbCustomer = new DevExpress.XtraEditors.LookUpEdit();
            this.dtpYearOfBuy = new DevExpress.XtraEditors.DateEdit();
            this.gcCustomerInfo = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.valCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valBrand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valYearOfBuy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBrand.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbCustomer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpYearOfBuy.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpYearOfBuy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCustomerInfo)).BeginInit();
            this.gcCustomerInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // valCustomer
            // 
            this.valCustomer.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual;
            // 
            // valBrand
            // 
            this.valBrand.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual;
            // 
            // valType
            // 
            this.valType.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual;
            // 
            // valYearOfBuy
            // 
            this.valYearOfBuy.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual;
            // 
            // lblCustomer
            // 
            this.lblCustomer.Location = new System.Drawing.Point(12, 30);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(46, 13);
            this.lblCustomer.TabIndex = 0;
            this.lblCustomer.Text = "Customer";
            // 
            // lblMerek
            // 
            this.lblMerek.Location = new System.Drawing.Point(12, 60);
            this.lblMerek.Name = "lblMerek";
            this.lblMerek.Size = new System.Drawing.Size(29, 13);
            this.lblMerek.TabIndex = 2;
            this.lblMerek.Text = "Merek";
            // 
            // txtBrand
            // 
            this.txtBrand.Location = new System.Drawing.Point(128, 57);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(162, 20);
            this.txtBrand.TabIndex = 3;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "Nama Perusahaan harus diisi!";
            this.valBrand.SetValidationRule(this.txtBrand, conditionValidationRule1);
            // 
            // lblType
            // 
            this.lblType.Location = new System.Drawing.Point(12, 90);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(20, 13);
            this.lblType.TabIndex = 4;
            this.lblType.Text = "Tipe";
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(128, 87);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(162, 20);
            this.txtType.TabIndex = 5;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "Alamat harus diisi!";
            this.valType.SetValidationRule(this.txtType, conditionValidationRule2);
            // 
            // lblYearOfBuy
            // 
            this.lblYearOfBuy.Location = new System.Drawing.Point(12, 120);
            this.lblYearOfBuy.Name = "lblYearOfBuy";
            this.lblYearOfBuy.Size = new System.Drawing.Size(49, 13);
            this.lblYearOfBuy.TabIndex = 6;
            this.lblYearOfBuy.Text = "Tahun Beli";
            // 
            // cbCustomer
            // 
            this.cbCustomer.Location = new System.Drawing.Point(128, 27);
            this.cbCustomer.Name = "cbCustomer";
            this.cbCustomer.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.cbCustomer.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbCustomer.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Kode Kota"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Nama")});
            this.cbCustomer.Properties.DisplayMember = "Name";
            this.cbCustomer.Properties.HideSelection = false;
            this.cbCustomer.Properties.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned;
            this.cbCustomer.Properties.NullText = "-- Pilih Kota --";
            this.cbCustomer.Properties.ValueMember = "Id";
            this.cbCustomer.Size = new System.Drawing.Size(162, 20);
            this.cbCustomer.TabIndex = 7;
            conditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.NotEquals;
            conditionValidationRule3.ErrorText = "Pilih salah satu kota";
            conditionValidationRule3.Value1 = "-- Pilih Kota --";
            this.valYearOfBuy.SetValidationRule(this.cbCustomer, conditionValidationRule3);
            // 
            // dtpYearOfBuy
            // 
            this.dtpYearOfBuy.EditValue = null;
            this.dtpYearOfBuy.Location = new System.Drawing.Point(128, 117);
            this.dtpYearOfBuy.Name = "dtpYearOfBuy";
            this.dtpYearOfBuy.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpYearOfBuy.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpYearOfBuy.Size = new System.Drawing.Size(100, 20);
            this.dtpYearOfBuy.TabIndex = 8;
            // 
            // gcCustomerInfo
            // 
            this.gcCustomerInfo.Controls.Add(this.dtpYearOfBuy);
            this.gcCustomerInfo.Controls.Add(this.cbCustomer);
            this.gcCustomerInfo.Controls.Add(this.lblYearOfBuy);
            this.gcCustomerInfo.Controls.Add(this.txtType);
            this.gcCustomerInfo.Controls.Add(this.lblType);
            this.gcCustomerInfo.Controls.Add(this.txtBrand);
            this.gcCustomerInfo.Controls.Add(this.lblMerek);
            this.gcCustomerInfo.Controls.Add(this.lblCustomer);
            this.gcCustomerInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcCustomerInfo.Location = new System.Drawing.Point(0, 0);
            this.gcCustomerInfo.Name = "gcCustomerInfo";
            this.gcCustomerInfo.Size = new System.Drawing.Size(309, 200);
            this.gcCustomerInfo.TabIndex = 1;
            this.gcCustomerInfo.Text = "Informasi Kendaraan";
            // 
            // CustomerEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 200);
            this.Controls.Add(this.gcCustomerInfo);
            this.Name = "CustomerEditorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vehicle Editor";
            this.Controls.SetChildIndex(this.gcCustomerInfo, 0);
            ((System.ComponentModel.ISupportInitialize)(this.valCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valBrand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valYearOfBuy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBrand.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbCustomer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpYearOfBuy.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpYearOfBuy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCustomerInfo)).EndInit();
            this.gcCustomerInfo.ResumeLayout(false);
            this.gcCustomerInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider valCustomer;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider valYearOfBuy;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider valType;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider valBrand;
        private DevExpress.XtraEditors.LabelControl lblCustomer;
        private DevExpress.XtraEditors.LabelControl lblMerek;
        private DevExpress.XtraEditors.TextEdit txtBrand;
        private DevExpress.XtraEditors.LabelControl lblType;
        private DevExpress.XtraEditors.TextEdit txtType;
        private DevExpress.XtraEditors.LabelControl lblYearOfBuy;
        private DevExpress.XtraEditors.LookUpEdit cbCustomer;
        private DevExpress.XtraEditors.DateEdit dtpYearOfBuy;
        private DevExpress.XtraEditors.GroupControl gcCustomerInfo;
    }
}