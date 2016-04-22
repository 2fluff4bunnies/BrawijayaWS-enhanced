namespace BrawijayaWorkshop.Win32App.ModulForms
{
    partial class TypeEditorForm
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
            this.gcTypeInfo = new DevExpress.XtraEditors.GroupControl();
            this.txtDescription = new DevExpress.XtraEditors.MemoEdit();
            this.lblDescription = new DevExpress.XtraEditors.LabelControl();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.lblName = new DevExpress.XtraEditors.LabelControl();
            this.valName = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.valDescription = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gcTypeInfo)).BeginInit();
            this.gcTypeInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valDescription)).BeginInit();
            this.SuspendLayout();
            // 
            // gcTypeInfo
            // 
            this.gcTypeInfo.Controls.Add(this.txtDescription);
            this.gcTypeInfo.Controls.Add(this.lblDescription);
            this.gcTypeInfo.Controls.Add(this.txtName);
            this.gcTypeInfo.Controls.Add(this.lblName);
            this.gcTypeInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcTypeInfo.Location = new System.Drawing.Point(0, 0);
            this.gcTypeInfo.Name = "gcTypeInfo";
            this.gcTypeInfo.Size = new System.Drawing.Size(481, 136);
            this.gcTypeInfo.TabIndex = 3;
            this.gcTypeInfo.Text = "Informasi Tipe";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(128, 55);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(237, 58);
            this.txtDescription.TabIndex = 3;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "Deskripsi harus diisi";
            this.valDescription.SetValidationRule(this.txtDescription, conditionValidationRule1);
            // 
            // lblDescription
            // 
            this.lblDescription.Location = new System.Drawing.Point(12, 60);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(42, 13);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Deskripsi";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(128, 29);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(187, 20);
            this.txtName.TabIndex = 1;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "Nama harus diisi";
            this.valName.SetValidationRule(this.txtName, conditionValidationRule2);
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(12, 30);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(27, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Nama";
            // 
            // valName
            // 
            this.valName.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual;
            // 
            // valDescription
            // 
            this.valDescription.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual;
            // 
            // TypeEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 185);
            this.Controls.Add(this.gcTypeInfo);
            this.Name = "TypeEditorForm";
            this.Text = "Tipe Editor";
            this.Controls.SetChildIndex(this.gcTypeInfo, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gcTypeInfo)).EndInit();
            this.gcTypeInfo.ResumeLayout(false);
            this.gcTypeInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valDescription)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gcTypeInfo;
        private DevExpress.XtraEditors.MemoEdit txtDescription;
        private DevExpress.XtraEditors.LabelControl lblDescription;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraEditors.LabelControl lblName;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider valDescription;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider valName;
    }
}