namespace BrawijayaWorkshop.Win32App.ModulForms
{
    partial class RoleAccessEditorForm
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
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.gcRoleAccessInfo = new DevExpress.XtraEditors.GroupControl();
            this.lblModulName = new DevExpress.XtraEditors.LabelControl();
            this.lblRoleName = new DevExpress.XtraEditors.LabelControl();
            this.cbxRead = new DevExpress.XtraEditors.CheckEdit();
            this.cbxCreate = new DevExpress.XtraEditors.CheckEdit();
            this.cbxUpdate = new DevExpress.XtraEditors.CheckEdit();
            this.cbxDelete = new DevExpress.XtraEditors.CheckEdit();
            this.lookUpModul = new DevExpress.XtraEditors.LookUpEdit();
            this.lookUpRole = new DevExpress.XtraEditors.LookUpEdit();
            this.valModul = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.valRole = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gcRoleAccessInfo)).BeginInit();
            this.gcRoleAccessInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxRead.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxCreate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxUpdate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxDelete.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpModul.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpRole.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valModul)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valRole)).BeginInit();
            this.SuspendLayout();
            // 
            // gcRoleAccessInfo
            // 
            this.gcRoleAccessInfo.Controls.Add(this.lookUpRole);
            this.gcRoleAccessInfo.Controls.Add(this.lookUpModul);
            this.gcRoleAccessInfo.Controls.Add(this.cbxDelete);
            this.gcRoleAccessInfo.Controls.Add(this.cbxUpdate);
            this.gcRoleAccessInfo.Controls.Add(this.cbxCreate);
            this.gcRoleAccessInfo.Controls.Add(this.cbxRead);
            this.gcRoleAccessInfo.Controls.Add(this.lblRoleName);
            this.gcRoleAccessInfo.Controls.Add(this.lblModulName);
            this.gcRoleAccessInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcRoleAccessInfo.Location = new System.Drawing.Point(0, 0);
            this.gcRoleAccessInfo.Name = "gcRoleAccessInfo";
            this.gcRoleAccessInfo.Size = new System.Drawing.Size(481, 136);
            this.gcRoleAccessInfo.TabIndex = 1;
            this.gcRoleAccessInfo.Text = "Informasi Akses Role";
            // 
            // lblModulName
            // 
            this.lblModulName.Location = new System.Drawing.Point(13, 31);
            this.lblModulName.Name = "lblModulName";
            this.lblModulName.Size = new System.Drawing.Size(58, 13);
            this.lblModulName.TabIndex = 0;
            this.lblModulName.Text = "Nama Modul";
            // 
            // lblRoleName
            // 
            this.lblRoleName.Location = new System.Drawing.Point(13, 64);
            this.lblRoleName.Name = "lblRoleName";
            this.lblRoleName.Size = new System.Drawing.Size(21, 13);
            this.lblRoleName.TabIndex = 2;
            this.lblRoleName.Text = "Role";
            // 
            // cbxRead
            // 
            this.cbxRead.Location = new System.Drawing.Point(104, 97);
            this.cbxRead.Name = "cbxRead";
            this.cbxRead.Properties.Caption = "Read";
            this.cbxRead.Size = new System.Drawing.Size(75, 19);
            this.cbxRead.TabIndex = 4;
            // 
            // cbxCreate
            // 
            this.cbxCreate.Location = new System.Drawing.Point(185, 97);
            this.cbxCreate.Name = "cbxCreate";
            this.cbxCreate.Properties.Caption = "Create";
            this.cbxCreate.Size = new System.Drawing.Size(75, 19);
            this.cbxCreate.TabIndex = 5;
            // 
            // cbxUpdate
            // 
            this.cbxUpdate.Location = new System.Drawing.Point(266, 97);
            this.cbxUpdate.Name = "cbxUpdate";
            this.cbxUpdate.Properties.Caption = "Update";
            this.cbxUpdate.Size = new System.Drawing.Size(75, 19);
            this.cbxUpdate.TabIndex = 6;
            // 
            // cbxDelete
            // 
            this.cbxDelete.Location = new System.Drawing.Point(347, 97);
            this.cbxDelete.Name = "cbxDelete";
            this.cbxDelete.Properties.Caption = "Delete";
            this.cbxDelete.Size = new System.Drawing.Size(75, 19);
            this.cbxDelete.TabIndex = 7;
            // 
            // lookUpModul
            // 
            this.lookUpModul.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lookUpModul.Location = new System.Drawing.Point(104, 28);
            this.lookUpModul.Name = "lookUpModul";
            this.lookUpModul.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.lookUpModul.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpModul.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ModulName", "Nama Modul"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ModulDescription", "Keterangan")});
            this.lookUpModul.Properties.DisplayMember = "ModulName";
            this.lookUpModul.Properties.HideSelection = false;
            this.lookUpModul.Properties.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned;
            this.lookUpModul.Properties.NullText = "-- Pilih Modul --";
            this.lookUpModul.Properties.ValueMember = "Id";
            this.lookUpModul.Size = new System.Drawing.Size(365, 20);
            this.lookUpModul.TabIndex = 1;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.NotEquals;
            conditionValidationRule2.ErrorText = "Pilih salah satu modul!";
            conditionValidationRule2.Value1 = "-- Pilih Modul --";
            this.valModul.SetValidationRule(this.lookUpModul, conditionValidationRule2);
            // 
            // lookUpRole
            // 
            this.lookUpRole.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lookUpRole.Location = new System.Drawing.Point(104, 61);
            this.lookUpRole.Name = "lookUpRole";
            this.lookUpRole.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.lookUpRole.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpRole.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Role")});
            this.lookUpRole.Properties.DisplayMember = "Name";
            this.lookUpRole.Properties.HideSelection = false;
            this.lookUpRole.Properties.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned;
            this.lookUpRole.Properties.NullText = "-- Pilih Role --";
            this.lookUpRole.Properties.ValueMember = "Id";
            this.lookUpRole.Size = new System.Drawing.Size(365, 20);
            this.lookUpRole.TabIndex = 3;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.NotEquals;
            conditionValidationRule1.ErrorText = "Pilih salah satu role!";
            conditionValidationRule1.Value1 = "-- Pilih Role --";
            this.valRole.SetValidationRule(this.lookUpRole, conditionValidationRule1);
            // 
            // valModul
            // 
            this.valModul.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual;
            // 
            // valRole
            // 
            this.valRole.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual;
            // 
            // RoleAccessEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 185);
            this.Controls.Add(this.gcRoleAccessInfo);
            this.Name = "RoleAccessEditorForm";
            this.Text = "Role Access Editor";
            this.Controls.SetChildIndex(this.gcRoleAccessInfo, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gcRoleAccessInfo)).EndInit();
            this.gcRoleAccessInfo.ResumeLayout(false);
            this.gcRoleAccessInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxRead.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxCreate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxUpdate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxDelete.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpModul.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpRole.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valModul)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valRole)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gcRoleAccessInfo;
        private DevExpress.XtraEditors.LabelControl lblModulName;
        private DevExpress.XtraEditors.LookUpEdit lookUpRole;
        private DevExpress.XtraEditors.LookUpEdit lookUpModul;
        private DevExpress.XtraEditors.CheckEdit cbxDelete;
        private DevExpress.XtraEditors.CheckEdit cbxUpdate;
        private DevExpress.XtraEditors.CheckEdit cbxCreate;
        private DevExpress.XtraEditors.CheckEdit cbxRead;
        private DevExpress.XtraEditors.LabelControl lblRoleName;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider valRole;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider valModul;
    }
}