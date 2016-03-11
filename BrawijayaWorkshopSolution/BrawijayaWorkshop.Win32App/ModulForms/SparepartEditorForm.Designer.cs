namespace BrawijayaWorkshop.Win32App.ModulForms
{
    partial class SparepartEditorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SparepartEditorForm));
            this.gcSparepartInfo = new DevExpress.XtraEditors.GroupControl();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.lblName = new DevExpress.XtraEditors.LabelControl();
            this.txtCode = new DevExpress.XtraEditors.TextEdit();
            this.lblCode = new DevExpress.XtraEditors.LabelControl();
            this.lookUpUnit = new DevExpress.XtraEditors.LookUpEdit();
            this.lblUnit = new DevExpress.XtraEditors.LabelControl();
            this.lookUpCategory = new DevExpress.XtraEditors.LookUpEdit();
            this.lblCategory = new DevExpress.XtraEditors.LabelControl();
            this.valCategory = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.valUnit = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.valCode = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.valName = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gcSparepartInfo)).BeginInit();
            this.gcSparepartInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpUnit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpCategory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valUnit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valName)).BeginInit();
            this.SuspendLayout();
            // 
            // gcSparepartInfo
            // 
            this.gcSparepartInfo.Controls.Add(this.txtName);
            this.gcSparepartInfo.Controls.Add(this.lblName);
            this.gcSparepartInfo.Controls.Add(this.txtCode);
            this.gcSparepartInfo.Controls.Add(this.lblCode);
            this.gcSparepartInfo.Controls.Add(this.lookUpUnit);
            this.gcSparepartInfo.Controls.Add(this.lblUnit);
            this.gcSparepartInfo.Controls.Add(this.lookUpCategory);
            this.gcSparepartInfo.Controls.Add(this.lblCategory);
            this.gcSparepartInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcSparepartInfo.Location = new System.Drawing.Point(0, 0);
            this.gcSparepartInfo.Name = "gcSparepartInfo";
            this.gcSparepartInfo.Size = new System.Drawing.Size(406, 160);
            this.gcSparepartInfo.TabIndex = 1;
            this.gcSparepartInfo.Text = "Informasi Sparepart";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(113, 123);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(274, 20);
            this.txtName.TabIndex = 7;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "Nama harus diisi!";
            this.valName.SetValidationRule(this.txtName, conditionValidationRule1);
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(13, 126);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(27, 13);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Nama";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(113, 92);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(274, 20);
            this.txtCode.TabIndex = 5;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "Kode harus diisi!";
            this.valCode.SetValidationRule(this.txtCode, conditionValidationRule2);
            // 
            // lblCode
            // 
            this.lblCode.Location = new System.Drawing.Point(13, 95);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(24, 13);
            this.lblCode.TabIndex = 4;
            this.lblCode.Text = "Kode";
            // 
            // lookUpUnit
            // 
            this.lookUpUnit.Location = new System.Drawing.Point(113, 61);
            this.lookUpUnit.Name = "lookUpUnit";
            this.lookUpUnit.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.lookUpUnit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpUnit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Value", "Unit/Satuan")});
            this.lookUpUnit.Properties.DisplayMember = "Value";
            this.lookUpUnit.Properties.HideSelection = false;
            this.lookUpUnit.Properties.NullText = "-- Pilih Unit/Satuan --";
            this.lookUpUnit.Properties.ValueMember = "Id";
            this.lookUpUnit.Size = new System.Drawing.Size(274, 20);
            this.lookUpUnit.TabIndex = 3;
            conditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.NotEquals;
            conditionValidationRule3.ErrorText = "Pilih salah satu Unit/Satuan!";
            conditionValidationRule3.Value1 = "-- Pilih Unit/Satuan --";
            this.valUnit.SetValidationRule(this.lookUpUnit, conditionValidationRule3);
            // 
            // lblUnit
            // 
            this.lblUnit.Location = new System.Drawing.Point(13, 64);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(57, 13);
            this.lblUnit.TabIndex = 2;
            this.lblUnit.Text = "Unit/Satuan";
            // 
            // lookUpCategory
            // 
            this.lookUpCategory.Location = new System.Drawing.Point(113, 30);
            this.lookUpCategory.Name = "lookUpCategory";
            this.lookUpCategory.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.lookUpCategory.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpCategory.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Value", "Kategori")});
            this.lookUpCategory.Properties.DisplayMember = "Value";
            this.lookUpCategory.Properties.HideSelection = false;
            this.lookUpCategory.Properties.NullText = "-- Pilih Kategori --";
            this.lookUpCategory.Properties.ValueMember = "Id";
            this.lookUpCategory.Size = new System.Drawing.Size(274, 20);
            this.lookUpCategory.TabIndex = 1;
            conditionValidationRule4.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.NotEquals;
            conditionValidationRule4.ErrorText = "Pilih salah satu Kategori!";
            conditionValidationRule4.Value1 = "-- Pilih Kategori --";
            this.valCategory.SetValidationRule(this.lookUpCategory, conditionValidationRule4);
            // 
            // lblCategory
            // 
            this.lblCategory.Location = new System.Drawing.Point(13, 33);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(40, 13);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.Text = "Kategori";
            // 
            // valCategory
            // 
            this.valCategory.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual;
            // 
            // valUnit
            // 
            this.valUnit.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual;
            // 
            // valCode
            // 
            this.valCode.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual;
            // 
            // valName
            // 
            this.valName.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual;
            // 
            // SparepartEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 209);
            this.Controls.Add(this.gcSparepartInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SparepartEditorForm";
            this.Text = "Sparepart Editor";
            this.Load += new System.EventHandler(this.SparepartEditorForm_Load);
            this.Controls.SetChildIndex(this.gcSparepartInfo, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gcSparepartInfo)).EndInit();
            this.gcSparepartInfo.ResumeLayout(false);
            this.gcSparepartInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpUnit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpCategory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valUnit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valName)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gcSparepartInfo;
        private DevExpress.XtraEditors.LookUpEdit lookUpCategory;
        private DevExpress.XtraEditors.LabelControl lblCategory;
        private DevExpress.XtraEditors.LookUpEdit lookUpUnit;
        private DevExpress.XtraEditors.LabelControl lblUnit;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraEditors.LabelControl lblName;
        private DevExpress.XtraEditors.TextEdit txtCode;
        private DevExpress.XtraEditors.LabelControl lblCode;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider valCategory;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider valUnit;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider valCode;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider valName;
    }
}