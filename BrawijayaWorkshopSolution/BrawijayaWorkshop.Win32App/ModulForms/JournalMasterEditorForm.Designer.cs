namespace BrawijayaWorkshop.Win32App.ModulForms
{
    partial class JournalMasterEditorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JournalMasterEditorForm));
            this.groupJournalInfo = new DevExpress.XtraEditors.GroupControl();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.lblName = new DevExpress.XtraEditors.LabelControl();
            this.txtCode = new DevExpress.XtraEditors.TextEdit();
            this.lblCode = new DevExpress.XtraEditors.LabelControl();
            this.lookupJournalParent = new DevExpress.XtraEditors.LookUpEdit();
            this.lblParent = new DevExpress.XtraEditors.LabelControl();
            this.valCode = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.valName = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.groupJournalInfo)).BeginInit();
            this.groupJournalInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupJournalParent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valName)).BeginInit();
            this.SuspendLayout();
            // 
            // groupJournalInfo
            // 
            this.groupJournalInfo.Controls.Add(this.txtName);
            this.groupJournalInfo.Controls.Add(this.lblName);
            this.groupJournalInfo.Controls.Add(this.txtCode);
            this.groupJournalInfo.Controls.Add(this.lblCode);
            this.groupJournalInfo.Controls.Add(this.lookupJournalParent);
            this.groupJournalInfo.Controls.Add(this.lblParent);
            this.groupJournalInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupJournalInfo.Location = new System.Drawing.Point(0, 0);
            this.groupJournalInfo.Name = "groupJournalInfo";
            this.groupJournalInfo.Size = new System.Drawing.Size(403, 129);
            this.groupJournalInfo.TabIndex = 1;
            this.groupJournalInfo.Text = "Informasi Account";
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Location = new System.Drawing.Point(126, 92);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(265, 20);
            this.txtName.TabIndex = 7;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "Nama account harus diisi!";
            this.valName.SetValidationRule(this.txtName, conditionValidationRule1);
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(12, 95);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(27, 13);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Nama";
            // 
            // txtCode
            // 
            this.txtCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCode.Location = new System.Drawing.Point(126, 58);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(265, 20);
            this.txtCode.TabIndex = 5;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "Kode account harus diisi!";
            this.valCode.SetValidationRule(this.txtCode, conditionValidationRule2);
            // 
            // lblCode
            // 
            this.lblCode.Location = new System.Drawing.Point(12, 61);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(24, 13);
            this.lblCode.TabIndex = 4;
            this.lblCode.Text = "Kode";
            // 
            // lookupJournalParent
            // 
            this.lookupJournalParent.Location = new System.Drawing.Point(126, 28);
            this.lookupJournalParent.Name = "lookupJournalParent";
            this.lookupJournalParent.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.lookupJournalParent.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookupJournalParent.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Kode"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Nama")});
            this.lookupJournalParent.Properties.DisplayMember = "Code";
            this.lookupJournalParent.Properties.HideSelection = false;
            this.lookupJournalParent.Properties.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned;
            this.lookupJournalParent.Properties.NullText = "-- Induk Account --";
            this.lookupJournalParent.Properties.ValueMember = "Id";
            this.lookupJournalParent.Size = new System.Drawing.Size(115, 20);
            this.lookupJournalParent.TabIndex = 3;
            // 
            // lblParent
            // 
            this.lblParent.Location = new System.Drawing.Point(12, 31);
            this.lblParent.Name = "lblParent";
            this.lblParent.Size = new System.Drawing.Size(69, 13);
            this.lblParent.TabIndex = 2;
            this.lblParent.Text = "Induk Account";
            // 
            // valCode
            // 
            this.valCode.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual;
            // 
            // valName
            // 
            this.valName.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual;
            // 
            // JournalMasterEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 178);
            this.Controls.Add(this.groupJournalInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "JournalMasterEditorForm";
            this.Text = "Account Journal Editor";
            this.Controls.SetChildIndex(this.groupJournalInfo, 0);
            ((System.ComponentModel.ISupportInitialize)(this.groupJournalInfo)).EndInit();
            this.groupJournalInfo.ResumeLayout(false);
            this.groupJournalInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupJournalParent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valName)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupJournalInfo;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraEditors.LabelControl lblName;
        private DevExpress.XtraEditors.TextEdit txtCode;
        private DevExpress.XtraEditors.LabelControl lblCode;
        private DevExpress.XtraEditors.LookUpEdit lookupJournalParent;
        private DevExpress.XtraEditors.LabelControl lblParent;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider valName;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider valCode;
    }
}