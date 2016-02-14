namespace BrawijayaWorkshop.Win32App.ModulForms
{
    partial class UserEditorForm
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
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule4 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule3 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.CompareAgainstControlValidationRule compareAgainstControlValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.CompareAgainstControlValidationRule();
            this.gcUserInfo = new DevExpress.XtraEditors.GroupControl();
            this.lblUserName = new DevExpress.XtraEditors.LabelControl();
            this.txtUserName = new DevExpress.XtraEditors.TextEdit();
            this.lblFirstName = new DevExpress.XtraEditors.LabelControl();
            this.txtFirstName = new DevExpress.XtraEditors.TextEdit();
            this.lblMiddleName = new DevExpress.XtraEditors.LabelControl();
            this.txtMiddleName = new DevExpress.XtraEditors.TextEdit();
            this.lblLastName = new DevExpress.XtraEditors.LabelControl();
            this.txtLastName = new DevExpress.XtraEditors.TextEdit();
            this.lblPassword = new DevExpress.XtraEditors.LabelControl();
            this.txtPassword = new DevExpress.XtraEditors.TextEdit();
            this.lblReTypePassword = new DevExpress.XtraEditors.LabelControl();
            this.txtReTypePassword = new DevExpress.XtraEditors.TextEdit();
            this.cbxIsActive = new DevExpress.XtraEditors.CheckEdit();
            this.valUserName = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.valFirstName = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.valLastName = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.valPassword = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.valReTypePassword = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gcUserInfo)).BeginInit();
            this.gcUserInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFirstName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMiddleName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLastName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReTypePassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxIsActive.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valUserName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valFirstName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valLastName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valReTypePassword)).BeginInit();
            this.SuspendLayout();
            // 
            // gcUserInfo
            // 
            this.gcUserInfo.Controls.Add(this.cbxIsActive);
            this.gcUserInfo.Controls.Add(this.txtReTypePassword);
            this.gcUserInfo.Controls.Add(this.lblReTypePassword);
            this.gcUserInfo.Controls.Add(this.txtPassword);
            this.gcUserInfo.Controls.Add(this.lblPassword);
            this.gcUserInfo.Controls.Add(this.txtLastName);
            this.gcUserInfo.Controls.Add(this.lblLastName);
            this.gcUserInfo.Controls.Add(this.txtMiddleName);
            this.gcUserInfo.Controls.Add(this.lblMiddleName);
            this.gcUserInfo.Controls.Add(this.txtFirstName);
            this.gcUserInfo.Controls.Add(this.lblFirstName);
            this.gcUserInfo.Controls.Add(this.txtUserName);
            this.gcUserInfo.Controls.Add(this.lblUserName);
            this.gcUserInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcUserInfo.Location = new System.Drawing.Point(0, 0);
            this.gcUserInfo.Name = "gcUserInfo";
            this.gcUserInfo.Size = new System.Drawing.Size(370, 287);
            this.gcUserInfo.TabIndex = 1;
            this.gcUserInfo.Text = "Informasi User";
            // 
            // lblUserName
            // 
            this.lblUserName.Location = new System.Drawing.Point(12, 32);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(48, 13);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "Username";
            // 
            // txtUserName
            // 
            this.txtUserName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUserName.Location = new System.Drawing.Point(116, 29);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(242, 20);
            this.txtUserName.TabIndex = 1;
            conditionValidationRule4.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule4.ErrorText = "Username harus diisi!";
            this.valUserName.SetValidationRule(this.txtUserName, conditionValidationRule4);
            // 
            // lblFirstName
            // 
            this.lblFirstName.Location = new System.Drawing.Point(12, 69);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(61, 13);
            this.lblFirstName.TabIndex = 2;
            this.lblFirstName.Text = "Nama Depan";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFirstName.Location = new System.Drawing.Point(116, 66);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(242, 20);
            this.txtFirstName.TabIndex = 3;
            conditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule3.ErrorText = "Nama Depan harus diisi!";
            this.valFirstName.SetValidationRule(this.txtFirstName, conditionValidationRule3);
            // 
            // lblMiddleName
            // 
            this.lblMiddleName.Location = new System.Drawing.Point(12, 106);
            this.lblMiddleName.Name = "lblMiddleName";
            this.lblMiddleName.Size = new System.Drawing.Size(66, 13);
            this.lblMiddleName.TabIndex = 4;
            this.lblMiddleName.Text = "Nama Tengah";
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMiddleName.Location = new System.Drawing.Point(116, 103);
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Size = new System.Drawing.Size(242, 20);
            this.txtMiddleName.TabIndex = 5;
            // 
            // lblLastName
            // 
            this.lblLastName.Location = new System.Drawing.Point(12, 143);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(73, 13);
            this.lblLastName.TabIndex = 6;
            this.lblLastName.Text = "Nama Belakang";
            // 
            // txtLastName
            // 
            this.txtLastName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLastName.Location = new System.Drawing.Point(116, 140);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(242, 20);
            this.txtLastName.TabIndex = 7;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "Nama Belakang harus diisi!";
            this.valLastName.SetValidationRule(this.txtLastName, conditionValidationRule2);
            // 
            // lblPassword
            // 
            this.lblPassword.Location = new System.Drawing.Point(12, 180);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(46, 13);
            this.lblPassword.TabIndex = 8;
            this.lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(116, 177);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Properties.UseSystemPasswordChar = true;
            this.txtPassword.Size = new System.Drawing.Size(149, 20);
            this.txtPassword.TabIndex = 9;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "Password harus diisi!";
            this.valPassword.SetValidationRule(this.txtPassword, conditionValidationRule1);
            // 
            // lblReTypePassword
            // 
            this.lblReTypePassword.Location = new System.Drawing.Point(12, 217);
            this.lblReTypePassword.Name = "lblReTypePassword";
            this.lblReTypePassword.Size = new System.Drawing.Size(90, 13);
            this.lblReTypePassword.TabIndex = 10;
            this.lblReTypePassword.Text = "Re-Type Password";
            // 
            // txtReTypePassword
            // 
            this.txtReTypePassword.Location = new System.Drawing.Point(116, 214);
            this.txtReTypePassword.Name = "txtReTypePassword";
            this.txtReTypePassword.Properties.UseSystemPasswordChar = true;
            this.txtReTypePassword.Size = new System.Drawing.Size(149, 20);
            this.txtReTypePassword.TabIndex = 11;
            compareAgainstControlValidationRule1.CompareControlOperator = DevExpress.XtraEditors.DXErrorProvider.CompareControlOperator.Equals;
            compareAgainstControlValidationRule1.Control = this.txtPassword;
            compareAgainstControlValidationRule1.ErrorText = "Re-Type Password harus sama dengan Password!";
            this.valReTypePassword.SetValidationRule(this.txtReTypePassword, compareAgainstControlValidationRule1);
            // 
            // cbxIsActive
            // 
            this.cbxIsActive.Location = new System.Drawing.Point(116, 250);
            this.cbxIsActive.Name = "cbxIsActive";
            this.cbxIsActive.Properties.Caption = "Aktif";
            this.cbxIsActive.Size = new System.Drawing.Size(75, 19);
            this.cbxIsActive.TabIndex = 12;
            // 
            // valUserName
            // 
            this.valUserName.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual;
            // 
            // valFirstName
            // 
            this.valFirstName.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual;
            // 
            // valLastName
            // 
            this.valLastName.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual;
            // 
            // valPassword
            // 
            this.valPassword.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual;
            // 
            // valReTypePassword
            // 
            this.valReTypePassword.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual;
            // 
            // UserEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 336);
            this.Controls.Add(this.gcUserInfo);
            this.Name = "UserEditorForm";
            this.Text = "User Editor";
            this.Controls.SetChildIndex(this.gcUserInfo, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gcUserInfo)).EndInit();
            this.gcUserInfo.ResumeLayout(false);
            this.gcUserInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFirstName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMiddleName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLastName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReTypePassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxIsActive.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valUserName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valFirstName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valLastName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valReTypePassword)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gcUserInfo;
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
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider valReTypePassword;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider valPassword;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider valLastName;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider valFirstName;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider valUserName;
    }
}