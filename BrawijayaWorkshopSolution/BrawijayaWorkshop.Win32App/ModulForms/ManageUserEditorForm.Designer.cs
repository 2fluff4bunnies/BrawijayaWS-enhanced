﻿namespace BrawijayaWorkshop.Win32App.ModulForms
{
    partial class ManageUserEditorForm
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
            this.gcUserRoleInfo = new DevExpress.XtraEditors.GroupControl();
            this.cbxIsActive = new DevExpress.XtraEditors.CheckEdit();
            this.txtReTypePassword = new DevExpress.XtraEditors.TextEdit();
            this.lblReTypePassword = new DevExpress.XtraEditors.LabelControl();
            this.txtPassword = new DevExpress.XtraEditors.TextEdit();
            this.lblPassword = new DevExpress.XtraEditors.LabelControl();
            this.txtLastName = new DevExpress.XtraEditors.TextEdit();
            this.lblLastName = new DevExpress.XtraEditors.LabelControl();
            this.txtMiddleName = new DevExpress.XtraEditors.TextEdit();
            this.lblMiddleName = new DevExpress.XtraEditors.LabelControl();
            this.txtFirstName = new DevExpress.XtraEditors.TextEdit();
            this.lblFirstName = new DevExpress.XtraEditors.LabelControl();
            this.txtUserName = new DevExpress.XtraEditors.TextEdit();
            this.lblUserName = new DevExpress.XtraEditors.LabelControl();
            this.lblRole = new DevExpress.XtraEditors.LabelControl();
            this.lookUpRole = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gcUserRoleInfo)).BeginInit();
            this.gcUserRoleInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxIsActive.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReTypePassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLastName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMiddleName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFirstName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpRole.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gcUserRoleInfo
            // 
            this.gcUserRoleInfo.Controls.Add(this.lookUpRole);
            this.gcUserRoleInfo.Controls.Add(this.lblRole);
            this.gcUserRoleInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcUserRoleInfo.Location = new System.Drawing.Point(0, 0);
            this.gcUserRoleInfo.Name = "gcUserRoleInfo";
            this.gcUserRoleInfo.Size = new System.Drawing.Size(370, 326);
            this.gcUserRoleInfo.TabIndex = 1;
            this.gcUserRoleInfo.Text = "Informasi User";
            // 
            // cbxIsActive
            // 
            this.cbxIsActive.Location = new System.Drawing.Point(116, 254);
            this.cbxIsActive.Name = "cbxIsActive";
            this.cbxIsActive.Properties.Caption = "Aktif";
            this.cbxIsActive.Size = new System.Drawing.Size(75, 19);
            this.cbxIsActive.TabIndex = 25;
            // 
            // txtReTypePassword
            // 
            this.txtReTypePassword.Location = new System.Drawing.Point(116, 218);
            this.txtReTypePassword.Name = "txtReTypePassword";
            this.txtReTypePassword.Properties.UseSystemPasswordChar = true;
            this.txtReTypePassword.Size = new System.Drawing.Size(149, 20);
            this.txtReTypePassword.TabIndex = 24;
            // 
            // lblReTypePassword
            // 
            this.lblReTypePassword.Location = new System.Drawing.Point(12, 221);
            this.lblReTypePassword.Name = "lblReTypePassword";
            this.lblReTypePassword.Size = new System.Drawing.Size(90, 13);
            this.lblReTypePassword.TabIndex = 23;
            this.lblReTypePassword.Text = "Re-Type Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(116, 181);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Properties.UseSystemPasswordChar = true;
            this.txtPassword.Size = new System.Drawing.Size(149, 20);
            this.txtPassword.TabIndex = 22;
            // 
            // lblPassword
            // 
            this.lblPassword.Location = new System.Drawing.Point(12, 184);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(46, 13);
            this.lblPassword.TabIndex = 21;
            this.lblPassword.Text = "Password";
            // 
            // txtLastName
            // 
            this.txtLastName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLastName.Location = new System.Drawing.Point(116, 144);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(242, 20);
            this.txtLastName.TabIndex = 20;
            // 
            // lblLastName
            // 
            this.lblLastName.Location = new System.Drawing.Point(12, 147);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(73, 13);
            this.lblLastName.TabIndex = 19;
            this.lblLastName.Text = "Nama Belakang";
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMiddleName.Location = new System.Drawing.Point(116, 107);
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Size = new System.Drawing.Size(242, 20);
            this.txtMiddleName.TabIndex = 18;
            // 
            // lblMiddleName
            // 
            this.lblMiddleName.Location = new System.Drawing.Point(12, 110);
            this.lblMiddleName.Name = "lblMiddleName";
            this.lblMiddleName.Size = new System.Drawing.Size(66, 13);
            this.lblMiddleName.TabIndex = 17;
            this.lblMiddleName.Text = "Nama Tengah";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFirstName.Location = new System.Drawing.Point(116, 70);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(242, 20);
            this.txtFirstName.TabIndex = 16;
            // 
            // lblFirstName
            // 
            this.lblFirstName.Location = new System.Drawing.Point(12, 73);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(61, 13);
            this.lblFirstName.TabIndex = 15;
            this.lblFirstName.Text = "Nama Depan";
            // 
            // txtUserName
            // 
            this.txtUserName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUserName.Location = new System.Drawing.Point(116, 33);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(242, 20);
            this.txtUserName.TabIndex = 14;
            // 
            // lblUserName
            // 
            this.lblUserName.Location = new System.Drawing.Point(12, 36);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(48, 13);
            this.lblUserName.TabIndex = 13;
            this.lblUserName.Text = "Username";
            // 
            // lblRole
            // 
            this.lblRole.Location = new System.Drawing.Point(12, 290);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(21, 13);
            this.lblRole.TabIndex = 0;
            this.lblRole.Text = "Role";
            // 
            // lookUpRole
            // 
            this.lookUpRole.Location = new System.Drawing.Point(116, 287);
            this.lookUpRole.Name = "lookUpRole";
            this.lookUpRole.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.lookUpRole.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpRole.Properties.HideSelection = false;
            this.lookUpRole.Properties.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned;
            this.lookUpRole.Properties.NullText = "-- Pilih Role --";
            this.lookUpRole.Size = new System.Drawing.Size(149, 20);
            this.lookUpRole.TabIndex = 1;
            // 
            // ManageUserEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 375);
            this.Controls.Add(this.cbxIsActive);
            this.Controls.Add(this.txtReTypePassword);
            this.Controls.Add(this.lblReTypePassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtMiddleName);
            this.Controls.Add(this.lblMiddleName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.gcUserRoleInfo);
            this.Name = "ManageUserEditorForm";
            this.Text = "Manage User Editor";
            this.Controls.SetChildIndex(this.gcUserRoleInfo, 0);
            this.Controls.SetChildIndex(this.lblUserName, 0);
            this.Controls.SetChildIndex(this.txtUserName, 0);
            this.Controls.SetChildIndex(this.lblFirstName, 0);
            this.Controls.SetChildIndex(this.txtFirstName, 0);
            this.Controls.SetChildIndex(this.lblMiddleName, 0);
            this.Controls.SetChildIndex(this.txtMiddleName, 0);
            this.Controls.SetChildIndex(this.lblLastName, 0);
            this.Controls.SetChildIndex(this.txtLastName, 0);
            this.Controls.SetChildIndex(this.lblPassword, 0);
            this.Controls.SetChildIndex(this.txtPassword, 0);
            this.Controls.SetChildIndex(this.lblReTypePassword, 0);
            this.Controls.SetChildIndex(this.txtReTypePassword, 0);
            this.Controls.SetChildIndex(this.cbxIsActive, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gcUserRoleInfo)).EndInit();
            this.gcUserRoleInfo.ResumeLayout(false);
            this.gcUserRoleInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxIsActive.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReTypePassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLastName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMiddleName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFirstName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpRole.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gcUserRoleInfo;
        private DevExpress.XtraEditors.LookUpEdit lookUpRole;
        private DevExpress.XtraEditors.LabelControl lblRole;
        private DevExpress.XtraEditors.CheckEdit cbxIsActive;
        private DevExpress.XtraEditors.TextEdit txtReTypePassword;
        private DevExpress.XtraEditors.LabelControl lblReTypePassword;
        private DevExpress.XtraEditors.TextEdit txtPassword;
        private DevExpress.XtraEditors.LabelControl lblPassword;
        private DevExpress.XtraEditors.TextEdit txtLastName;
        private DevExpress.XtraEditors.LabelControl lblLastName;
        private DevExpress.XtraEditors.TextEdit txtMiddleName;
        private DevExpress.XtraEditors.LabelControl lblMiddleName;
        private DevExpress.XtraEditors.TextEdit txtFirstName;
        private DevExpress.XtraEditors.LabelControl lblFirstName;
        private DevExpress.XtraEditors.TextEdit txtUserName;
        private DevExpress.XtraEditors.LabelControl lblUserName;
    }
}