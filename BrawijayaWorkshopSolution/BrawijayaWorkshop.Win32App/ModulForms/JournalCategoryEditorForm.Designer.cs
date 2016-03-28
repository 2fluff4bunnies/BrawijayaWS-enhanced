namespace BrawijayaWorkshop.Win32App.ModulForms
{
    partial class JournalCategoryEditorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JournalCategoryEditorForm));
            this.gcCategoryInfo = new DevExpress.XtraEditors.GroupControl();
            this.txtCatCode = new DevExpress.XtraEditors.TextEdit();
            this.lblCatCode = new DevExpress.XtraEditors.LabelControl();
            this.txtCatDescription = new DevExpress.XtraEditors.TextEdit();
            this.lblDescription = new DevExpress.XtraEditors.LabelControl();
            this.txtCatName = new DevExpress.XtraEditors.TextEdit();
            this.lblCatName = new DevExpress.XtraEditors.LabelControl();
            this.lookUpJournal = new DevExpress.XtraEditors.LookUpEdit();
            this.lblSelectedJournal = new DevExpress.XtraEditors.LabelControl();
            this.lookUpCategory = new DevExpress.XtraEditors.LookUpEdit();
            this.lblParentId = new DevExpress.XtraEditors.LabelControl();
            this.valCategory = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.valJournal = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.valCatName = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.valCatDescription = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.valCatCode = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gcCategoryInfo)).BeginInit();
            this.gcCategoryInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCatCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCatDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCatName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpJournal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpCategory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valJournal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valCatName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valCatDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valCatCode)).BeginInit();
            this.SuspendLayout();
            // 
            // gcCategoryInfo
            // 
            this.gcCategoryInfo.Controls.Add(this.txtCatCode);
            this.gcCategoryInfo.Controls.Add(this.lblCatCode);
            this.gcCategoryInfo.Controls.Add(this.txtCatDescription);
            this.gcCategoryInfo.Controls.Add(this.lblDescription);
            this.gcCategoryInfo.Controls.Add(this.txtCatName);
            this.gcCategoryInfo.Controls.Add(this.lblCatName);
            this.gcCategoryInfo.Controls.Add(this.lookUpJournal);
            this.gcCategoryInfo.Controls.Add(this.lblSelectedJournal);
            this.gcCategoryInfo.Controls.Add(this.lookUpCategory);
            this.gcCategoryInfo.Controls.Add(this.lblParentId);
            this.gcCategoryInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcCategoryInfo.Location = new System.Drawing.Point(0, 0);
            this.gcCategoryInfo.Name = "gcCategoryInfo";
            this.gcCategoryInfo.Size = new System.Drawing.Size(413, 206);
            this.gcCategoryInfo.TabIndex = 1;
            this.gcCategoryInfo.Text = "Informasi Kategori Akun Jurnal";
            // 
            // txtCatCode
            // 
            this.txtCatCode.Location = new System.Drawing.Point(101, 170);
            this.txtCatCode.Name = "txtCatCode";
            this.txtCatCode.Size = new System.Drawing.Size(298, 20);
            this.txtCatCode.TabIndex = 9;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "Kode harus diisi";
            this.valCatCode.SetValidationRule(this.txtCatCode, conditionValidationRule1);
            // 
            // lblCatCode
            // 
            this.lblCatCode.Location = new System.Drawing.Point(12, 173);
            this.lblCatCode.Name = "lblCatCode";
            this.lblCatCode.Size = new System.Drawing.Size(24, 13);
            this.lblCatCode.TabIndex = 8;
            this.lblCatCode.Text = "Kode";
            // 
            // txtCatDescription
            // 
            this.txtCatDescription.Location = new System.Drawing.Point(101, 135);
            this.txtCatDescription.Name = "txtCatDescription";
            this.txtCatDescription.Size = new System.Drawing.Size(298, 20);
            this.txtCatDescription.TabIndex = 7;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "Keterangan harus diisi";
            this.valCatDescription.SetValidationRule(this.txtCatDescription, conditionValidationRule2);
            // 
            // lblDescription
            // 
            this.lblDescription.Location = new System.Drawing.Point(13, 138);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(56, 13);
            this.lblDescription.TabIndex = 6;
            this.lblDescription.Text = "Keterangan";
            // 
            // txtCatName
            // 
            this.txtCatName.Location = new System.Drawing.Point(101, 100);
            this.txtCatName.Name = "txtCatName";
            this.txtCatName.Size = new System.Drawing.Size(298, 20);
            this.txtCatName.TabIndex = 5;
            conditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule3.ErrorText = "Nama harus diisi";
            this.valCatName.SetValidationRule(this.txtCatName, conditionValidationRule3);
            // 
            // lblCatName
            // 
            this.lblCatName.Location = new System.Drawing.Point(13, 103);
            this.lblCatName.Name = "lblCatName";
            this.lblCatName.Size = new System.Drawing.Size(27, 13);
            this.lblCatName.TabIndex = 4;
            this.lblCatName.Text = "Nama";
            // 
            // lookUpJournal
            // 
            this.lookUpJournal.Location = new System.Drawing.Point(101, 65);
            this.lookUpJournal.Name = "lookUpJournal";
            this.lookUpJournal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpJournal.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Kode Akun"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Nama")});
            this.lookUpJournal.Properties.DisplayMember = "Name";
            this.lookUpJournal.Properties.HideSelection = false;
            this.lookUpJournal.Properties.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned;
            this.lookUpJournal.Properties.NullText = "-- Pilih Akun Jurnal --";
            this.lookUpJournal.Properties.ValueMember = "Code";
            this.lookUpJournal.Size = new System.Drawing.Size(298, 20);
            this.lookUpJournal.TabIndex = 3;
            conditionValidationRule4.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.NotEquals;
            conditionValidationRule4.ErrorText = "Pilih Akun Jurnal";
            conditionValidationRule4.Value1 = "-- Pilih Akun Jurnal --";
            this.valJournal.SetValidationRule(this.lookUpJournal, conditionValidationRule4);
            // 
            // lblSelectedJournal
            // 
            this.lblSelectedJournal.Location = new System.Drawing.Point(13, 68);
            this.lblSelectedJournal.Name = "lblSelectedJournal";
            this.lblSelectedJournal.Size = new System.Drawing.Size(56, 13);
            this.lblSelectedJournal.TabIndex = 2;
            this.lblSelectedJournal.Text = "Akun Jurnal";
            // 
            // lookUpCategory
            // 
            this.lookUpCategory.Location = new System.Drawing.Point(101, 30);
            this.lookUpCategory.Name = "lookUpCategory";
            this.lookUpCategory.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpCategory.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Keterangan")});
            this.lookUpCategory.Properties.DisplayMember = "Description";
            this.lookUpCategory.Properties.HideSelection = false;
            this.lookUpCategory.Properties.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned;
            this.lookUpCategory.Properties.NullText = "-- Pilih Kategori Jurnal --";
            this.lookUpCategory.Properties.ValueMember = "Id";
            this.lookUpCategory.Size = new System.Drawing.Size(298, 20);
            this.lookUpCategory.TabIndex = 1;
            conditionValidationRule5.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.NotEquals;
            conditionValidationRule5.ErrorText = "Pilih Kategori";
            conditionValidationRule5.Value1 = "-- Pilih Kategori Jurnal --";
            this.valCategory.SetValidationRule(this.lookUpCategory, conditionValidationRule5);
            // 
            // lblParentId
            // 
            this.lblParentId.Location = new System.Drawing.Point(13, 33);
            this.lblParentId.Name = "lblParentId";
            this.lblParentId.Size = new System.Drawing.Size(40, 13);
            this.lblParentId.TabIndex = 0;
            this.lblParentId.Text = "Kategori";
            // 
            // valCategory
            // 
            this.valCategory.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual;
            // 
            // valJournal
            // 
            this.valJournal.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual;
            // 
            // valCatName
            // 
            this.valCatName.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual;
            // 
            // valCatDescription
            // 
            this.valCatDescription.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual;
            // 
            // valCatCode
            // 
            this.valCatCode.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual;
            // 
            // JournalCategoryEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 255);
            this.Controls.Add(this.gcCategoryInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "JournalCategoryEditorForm";
            this.Text = "Kategori Akun Jurnal Editor";
            this.Controls.SetChildIndex(this.gcCategoryInfo, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gcCategoryInfo)).EndInit();
            this.gcCategoryInfo.ResumeLayout(false);
            this.gcCategoryInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCatCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCatDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCatName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpJournal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpCategory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valJournal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valCatName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valCatDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valCatCode)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gcCategoryInfo;
        private DevExpress.XtraEditors.LookUpEdit lookUpCategory;
        private DevExpress.XtraEditors.LabelControl lblParentId;
        private DevExpress.XtraEditors.LookUpEdit lookUpJournal;
        private DevExpress.XtraEditors.LabelControl lblSelectedJournal;
        private DevExpress.XtraEditors.LabelControl lblCatName;
        private DevExpress.XtraEditors.TextEdit txtCatCode;
        private DevExpress.XtraEditors.LabelControl lblCatCode;
        private DevExpress.XtraEditors.TextEdit txtCatDescription;
        private DevExpress.XtraEditors.LabelControl lblDescription;
        private DevExpress.XtraEditors.TextEdit txtCatName;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider valCategory;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider valJournal;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider valCatName;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider valCatDescription;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider valCatCode;
    }
}