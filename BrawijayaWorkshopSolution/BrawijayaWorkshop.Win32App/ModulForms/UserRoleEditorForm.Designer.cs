namespace BrawijayaWorkshop.Win32App.ModulForms
{
    partial class UserRoleEditorForm
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
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule3 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.valUser = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.lookUpUser = new DevExpress.XtraEditors.LookUpEdit();
            this.valRole = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.lookUpRole = new DevExpress.XtraEditors.LookUpEdit();
            this.gcUserRoleInfo = new DevExpress.XtraEditors.GroupControl();
            this.lblRole = new DevExpress.XtraEditors.LabelControl();
            this.lblUser = new DevExpress.XtraEditors.LabelControl();
            this.bgwMain = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.valUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpUser.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valRole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpRole.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcUserRoleInfo)).BeginInit();
            this.gcUserRoleInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // valUser
            // 
            this.valUser.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual;
            // 
            // lookUpUser
            // 
            this.lookUpUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lookUpUser.Location = new System.Drawing.Point(67, 32);
            this.lookUpUser.Name = "lookUpUser";
            this.lookUpUser.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.lookUpUser.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpUser.Properties.HideSelection = false;
            this.lookUpUser.Properties.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned;
            this.lookUpUser.Properties.NullText = "-- Pilih User --";
            this.lookUpUser.Size = new System.Drawing.Size(274, 20);
            this.lookUpUser.TabIndex = 1;
            conditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.NotEquals;
            conditionValidationRule3.ErrorText = "Pilih salah satu user";
            conditionValidationRule3.Value1 = "-- Pilih User --";
            this.valUser.SetValidationRule(this.lookUpUser, conditionValidationRule3);
            // 
            // valRole
            // 
            this.valRole.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual;
            // 
            // lookUpRole
            // 
            this.lookUpRole.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lookUpRole.Location = new System.Drawing.Point(67, 64);
            this.lookUpRole.Name = "lookUpRole";
            this.lookUpRole.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.lookUpRole.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpRole.Properties.HideSelection = false;
            this.lookUpRole.Properties.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned;
            this.lookUpRole.Properties.NullText = "-- Pilih Role --";
            this.lookUpRole.Size = new System.Drawing.Size(274, 20);
            this.lookUpRole.TabIndex = 3;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.NotEquals;
            conditionValidationRule1.ErrorText = "Pilih salah satu role";
            conditionValidationRule1.Value1 = "-- Pilih Role --";
            this.valRole.SetValidationRule(this.lookUpRole, conditionValidationRule1);
            // 
            // gcUserRoleInfo
            // 
            this.gcUserRoleInfo.Controls.Add(this.lookUpRole);
            this.gcUserRoleInfo.Controls.Add(this.lblRole);
            this.gcUserRoleInfo.Controls.Add(this.lookUpUser);
            this.gcUserRoleInfo.Controls.Add(this.lblUser);
            this.gcUserRoleInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcUserRoleInfo.Location = new System.Drawing.Point(0, 0);
            this.gcUserRoleInfo.Name = "gcUserRoleInfo";
            this.gcUserRoleInfo.Size = new System.Drawing.Size(353, 97);
            this.gcUserRoleInfo.TabIndex = 1;
            this.gcUserRoleInfo.Text = "Informasi User Role";
            // 
            // lblRole
            // 
            this.lblRole.Location = new System.Drawing.Point(12, 67);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(21, 13);
            this.lblRole.TabIndex = 2;
            this.lblRole.Text = "Role";
            // 
            // lblUser
            // 
            this.lblUser.Location = new System.Drawing.Point(12, 35);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(22, 13);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "User";
            // 
            // bgwMain
            // 
            this.bgwMain.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwMain_DoWork);
            this.bgwMain.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwMain_RunWorkerCompleted);
            // 
            // UserRoleEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 146);
            this.Controls.Add(this.gcUserRoleInfo);
            this.Name = "UserRoleEditorForm";
            this.Text = "User Role Editor";
            this.Controls.SetChildIndex(this.gcUserRoleInfo, 0);
            ((System.ComponentModel.ISupportInitialize)(this.valUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpUser.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valRole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpRole.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcUserRoleInfo)).EndInit();
            this.gcUserRoleInfo.ResumeLayout(false);
            this.gcUserRoleInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider valUser;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider valRole;
        private DevExpress.XtraEditors.GroupControl gcUserRoleInfo;
        private DevExpress.XtraEditors.LookUpEdit lookUpRole;
        private DevExpress.XtraEditors.LabelControl lblRole;
        private DevExpress.XtraEditors.LookUpEdit lookUpUser;
        private DevExpress.XtraEditors.LabelControl lblUser;
        private System.ComponentModel.BackgroundWorker bgwMain;
    }
}