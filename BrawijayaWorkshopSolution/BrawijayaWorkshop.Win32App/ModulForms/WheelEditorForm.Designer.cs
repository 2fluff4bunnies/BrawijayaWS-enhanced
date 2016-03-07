namespace BrawijayaWorkshop.Win32App.ModulForms
{
    partial class WheelEditorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WheelEditorForm));
            this.gcSparepartInfo = new DevExpress.XtraEditors.GroupControl();
            this.lblUnitValue = new DevExpress.XtraEditors.LabelControl();
            this.lblCategoryValue = new DevExpress.XtraEditors.LabelControl();
            this.lblUnit = new DevExpress.XtraEditors.LabelControl();
            this.lblCode = new DevExpress.XtraEditors.LabelControl();
            this.lblSparepart = new DevExpress.XtraEditors.LabelControl();
            this.lblCategory = new DevExpress.XtraEditors.LabelControl();
            this.valSparepart = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.lblCodeValue = new DevExpress.XtraEditors.LabelControl();
            this.lookUpSparepart = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSparepartInfo)).BeginInit();
            this.gcSparepartInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.valSparepart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpSparepart.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gcSparepartInfo
            // 
            this.gcSparepartInfo.Controls.Add(this.lookUpSparepart);
            this.gcSparepartInfo.Controls.Add(this.lblCodeValue);
            this.gcSparepartInfo.Controls.Add(this.lblUnitValue);
            this.gcSparepartInfo.Controls.Add(this.lblCategoryValue);
            this.gcSparepartInfo.Controls.Add(this.lblUnit);
            this.gcSparepartInfo.Controls.Add(this.lblCode);
            this.gcSparepartInfo.Controls.Add(this.lblSparepart);
            this.gcSparepartInfo.Controls.Add(this.lblCategory);
            this.gcSparepartInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcSparepartInfo.Location = new System.Drawing.Point(0, 0);
            this.gcSparepartInfo.Name = "gcSparepartInfo";
            this.gcSparepartInfo.Size = new System.Drawing.Size(316, 149);
            this.gcSparepartInfo.TabIndex = 2;
            this.gcSparepartInfo.Text = "Informasi Ban";
            // 
            // lblUnitValue
            // 
            this.lblUnitValue.Location = new System.Drawing.Point(113, 122);
            this.lblUnitValue.Name = "lblUnitValue";
            this.lblUnitValue.Size = new System.Drawing.Size(8, 13);
            this.lblUnitValue.TabIndex = 10;
            this.lblUnitValue.Text = "--";
            // 
            // lblCategoryValue
            // 
            this.lblCategoryValue.Location = new System.Drawing.Point(113, 95);
            this.lblCategoryValue.Name = "lblCategoryValue";
            this.lblCategoryValue.Size = new System.Drawing.Size(8, 13);
            this.lblCategoryValue.TabIndex = 9;
            this.lblCategoryValue.Text = "--";
            // 
            // lblUnit
            // 
            this.lblUnit.Location = new System.Drawing.Point(13, 122);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(57, 13);
            this.lblUnit.TabIndex = 8;
            this.lblUnit.Text = "Unit/Satuan";
            // 
            // lblCode
            // 
            this.lblCode.Location = new System.Drawing.Point(13, 63);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(24, 13);
            this.lblCode.TabIndex = 6;
            this.lblCode.Text = "Kode";
            // 
            // lblSparepart
            // 
            this.lblSparepart.Location = new System.Drawing.Point(13, 32);
            this.lblSparepart.Name = "lblSparepart";
            this.lblSparepart.Size = new System.Drawing.Size(48, 13);
            this.lblSparepart.TabIndex = 4;
            this.lblSparepart.Text = "Sparepart";
            // 
            // lblCategory
            // 
            this.lblCategory.Location = new System.Drawing.Point(13, 95);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(40, 13);
            this.lblCategory.TabIndex = 2;
            this.lblCategory.Text = "Kategori";
            // 
            // valSparepart
            // 
            this.valSparepart.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual;
            // 
            // lblCodeValue
            // 
            this.lblCodeValue.Location = new System.Drawing.Point(113, 63);
            this.lblCodeValue.Name = "lblCodeValue";
            this.lblCodeValue.Size = new System.Drawing.Size(8, 13);
            this.lblCodeValue.TabIndex = 11;
            this.lblCodeValue.Text = "--";
            // 
            // lookUpSparepart
            // 
            this.lookUpSparepart.Location = new System.Drawing.Point(113, 29);
            this.lookUpSparepart.Name = "lookUpSparepart";
            this.lookUpSparepart.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.lookUpSparepart.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpSparepart.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Value", "Unit/Satuan")});
            this.lookUpSparepart.Properties.DisplayMember = "Value";
            this.lookUpSparepart.Properties.HideSelection = false;
            this.lookUpSparepart.Properties.NullText = "-- Pilih Sparepart  --";
            this.lookUpSparepart.Properties.ValueMember = "Id";
            this.lookUpSparepart.Size = new System.Drawing.Size(186, 20);
            this.lookUpSparepart.TabIndex = 12;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "Sparepart harus dipilih!";
            this.valSparepart.SetValidationRule(this.lookUpSparepart, conditionValidationRule1);
            // 
            // WheelEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 198);
            this.Controls.Add(this.gcSparepartInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WheelEditorForm";
            this.Text = "Ban Editor";
            this.Controls.SetChildIndex(this.gcSparepartInfo, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gcSparepartInfo)).EndInit();
            this.gcSparepartInfo.ResumeLayout(false);
            this.gcSparepartInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.valSparepart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpSparepart.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gcSparepartInfo;
        private DevExpress.XtraEditors.LabelControl lblUnitValue;
        private DevExpress.XtraEditors.LabelControl lblCategoryValue;
        private DevExpress.XtraEditors.LabelControl lblUnit;
        private DevExpress.XtraEditors.LabelControl lblCode;
        private DevExpress.XtraEditors.LabelControl lblSparepart;
        private DevExpress.XtraEditors.LabelControl lblCategory;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider valSparepart;
        private DevExpress.XtraEditors.LabelControl lblCodeValue;
        private DevExpress.XtraEditors.LookUpEdit lookUpSparepart;
    }
}