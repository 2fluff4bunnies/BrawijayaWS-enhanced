namespace BrawijayaWorkshop.Win32App.ModulForms
{
    partial class RoleEditorForm
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
            this.gcRole = new DevExpress.XtraEditors.GroupControl();
            this.lblRoleName = new DevExpress.XtraEditors.LabelControl();
            this.txtRoleName = new DevExpress.XtraEditors.TextEdit();
            this.valRoleName = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gcRole)).BeginInit();
            this.gcRole.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRoleName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valRoleName)).BeginInit();
            this.SuspendLayout();
            // 
            // gcRole
            // 
            this.gcRole.Controls.Add(this.txtRoleName);
            this.gcRole.Controls.Add(this.lblRoleName);
            this.gcRole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcRole.Location = new System.Drawing.Point(0, 0);
            this.gcRole.Name = "gcRole";
            this.gcRole.Size = new System.Drawing.Size(371, 66);
            this.gcRole.TabIndex = 1;
            this.gcRole.Text = "Informasi Role";
            // 
            // lblRoleName
            // 
            this.lblRoleName.Location = new System.Drawing.Point(12, 35);
            this.lblRoleName.Name = "lblRoleName";
            this.lblRoleName.Size = new System.Drawing.Size(51, 13);
            this.lblRoleName.TabIndex = 0;
            this.lblRoleName.Text = "Nama Role";
            // 
            // txtRoleName
            // 
            this.txtRoleName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRoleName.Location = new System.Drawing.Point(88, 32);
            this.txtRoleName.Name = "txtRoleName";
            this.txtRoleName.Size = new System.Drawing.Size(271, 20);
            this.txtRoleName.TabIndex = 1;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "Nama Role harus diisi!";
            this.valRoleName.SetValidationRule(this.txtRoleName, conditionValidationRule1);
            // 
            // valRoleName
            // 
            this.valRoleName.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual;
            // 
            // RoleEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 115);
            this.Controls.Add(this.gcRole);
            this.Name = "RoleEditorForm";
            this.Text = "Role Editor";
            this.Controls.SetChildIndex(this.gcRole, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gcRole)).EndInit();
            this.gcRole.ResumeLayout(false);
            this.gcRole.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRoleName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valRoleName)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gcRole;
        private DevExpress.XtraEditors.TextEdit txtRoleName;
        private DevExpress.XtraEditors.LabelControl lblRoleName;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider valRoleName;
    }
}