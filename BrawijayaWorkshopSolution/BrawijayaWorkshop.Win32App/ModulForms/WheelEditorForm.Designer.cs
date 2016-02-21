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
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WheelEditorForm));
            this.gcSparepartInfo = new DevExpress.XtraEditors.GroupControl();
            this.lblUnitValue = new DevExpress.XtraEditors.LabelControl();
            this.lblCategoryValue = new DevExpress.XtraEditors.LabelControl();
            this.lblUnit = new DevExpress.XtraEditors.LabelControl();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.lblName = new DevExpress.XtraEditors.LabelControl();
            this.txtCode = new DevExpress.XtraEditors.TextEdit();
            this.lblCode = new DevExpress.XtraEditors.LabelControl();
            this.lblCategory = new DevExpress.XtraEditors.LabelControl();
            this.valCode = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.valName = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gcSparepartInfo)).BeginInit();
            this.gcSparepartInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valName)).BeginInit();
            this.SuspendLayout();
            // 
            // gcSparepartInfo
            // 
            this.gcSparepartInfo.Controls.Add(this.lblUnitValue);
            this.gcSparepartInfo.Controls.Add(this.lblCategoryValue);
            this.gcSparepartInfo.Controls.Add(this.lblUnit);
            this.gcSparepartInfo.Controls.Add(this.txtName);
            this.gcSparepartInfo.Controls.Add(this.lblName);
            this.gcSparepartInfo.Controls.Add(this.txtCode);
            this.gcSparepartInfo.Controls.Add(this.lblCode);
            this.gcSparepartInfo.Controls.Add(this.lblCategory);
            this.gcSparepartInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcSparepartInfo.Location = new System.Drawing.Point(0, 0);
            this.gcSparepartInfo.Name = "gcSparepartInfo";
            this.gcSparepartInfo.Size = new System.Drawing.Size(404, 149);
            this.gcSparepartInfo.TabIndex = 2;
            this.gcSparepartInfo.Text = "Informasi Sparepart";
            // 
            // lblUnitValue
            // 
            this.lblUnitValue.Location = new System.Drawing.Point(113, 122);
            this.lblUnitValue.Name = "lblUnitValue";
            this.lblUnitValue.Size = new System.Drawing.Size(0, 13);
            this.lblUnitValue.TabIndex = 10;
            // 
            // lblCategoryValue
            // 
            this.lblCategoryValue.Location = new System.Drawing.Point(113, 95);
            this.lblCategoryValue.Name = "lblCategoryValue";
            this.lblCategoryValue.Size = new System.Drawing.Size(0, 13);
            this.lblCategoryValue.TabIndex = 9;
            // 
            // lblUnit
            // 
            this.lblUnit.Location = new System.Drawing.Point(13, 122);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(57, 13);
            this.lblUnit.TabIndex = 8;
            this.lblUnit.Text = "Unit/Satuan";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(113, 60);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(274, 20);
            this.txtName.TabIndex = 7;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "Nama harus diisi";
            this.valName.SetValidationRule(this.txtName, conditionValidationRule1);
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(13, 63);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(27, 13);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Nama";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(113, 29);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(274, 20);
            this.txtCode.TabIndex = 5;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "Kode harus diisi";
            this.valCode.SetValidationRule(this.txtCode, conditionValidationRule2);
            // 
            // lblCode
            // 
            this.lblCode.Location = new System.Drawing.Point(13, 32);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(24, 13);
            this.lblCode.TabIndex = 4;
            this.lblCode.Text = "Kode";
            // 
            // lblCategory
            // 
            this.lblCategory.Location = new System.Drawing.Point(13, 95);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(40, 13);
            this.lblCategory.TabIndex = 2;
            this.lblCategory.Text = "Kategori";
            // 
            // valCode
            // 
            this.valCode.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual;
            // 
            // valName
            // 
            this.valName.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual;
            // 
            // WheelEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 198);
            this.Controls.Add(this.gcSparepartInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WheelEditorForm";
            this.Text = "Ban Editor";
            this.Controls.SetChildIndex(this.gcSparepartInfo, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gcSparepartInfo)).EndInit();
            this.gcSparepartInfo.ResumeLayout(false);
            this.gcSparepartInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valName)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gcSparepartInfo;
        private DevExpress.XtraEditors.LabelControl lblUnitValue;
        private DevExpress.XtraEditors.LabelControl lblCategoryValue;
        private DevExpress.XtraEditors.LabelControl lblUnit;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraEditors.LabelControl lblName;
        private DevExpress.XtraEditors.TextEdit txtCode;
        private DevExpress.XtraEditors.LabelControl lblCode;
        private DevExpress.XtraEditors.LabelControl lblCategory;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider valName;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider valCode;
    }
}