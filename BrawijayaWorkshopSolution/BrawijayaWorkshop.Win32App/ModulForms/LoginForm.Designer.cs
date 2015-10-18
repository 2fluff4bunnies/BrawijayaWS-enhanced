namespace BrawijayaWorkshop.Win32App.ModulForms
{
    partial class LoginForm
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
            this.lblUserName = new DevExpress.XtraEditors.LabelControl();
            this.txtUserName = new DevExpress.XtraEditors.TextEdit();
            this.lblPassword = new DevExpress.XtraEditors.LabelControl();
            this.txtPassword = new DevExpress.XtraEditors.TextEdit();
            this.pnlLoginAction = new DevExpress.XtraEditors.PanelControl();
            this.btnAccept = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.peLogin = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlLoginAction)).BeginInit();
            this.pnlLoginAction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.peLogin.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUserName
            // 
            this.lblUserName.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblUserName.Location = new System.Drawing.Point(133, 23);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(71, 19);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "Username";
            // 
            // txtUserName
            // 
            this.txtUserName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUserName.Location = new System.Drawing.Point(246, 20);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtUserName.Properties.Appearance.Options.UseFont = true;
            this.txtUserName.Size = new System.Drawing.Size(196, 26);
            this.txtUserName.TabIndex = 1;
            // 
            // lblPassword
            // 
            this.lblPassword.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblPassword.Location = new System.Drawing.Point(133, 71);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(67, 19);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.Location = new System.Drawing.Point(246, 73);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtPassword.Properties.Appearance.Options.UseFont = true;
            this.txtPassword.Properties.UseSystemPasswordChar = true;
            this.txtPassword.Size = new System.Drawing.Size(196, 26);
            this.txtPassword.TabIndex = 3;
            // 
            // pnlLoginAction
            // 
            this.pnlLoginAction.Appearance.BackColor = System.Drawing.Color.Silver;
            this.pnlLoginAction.Appearance.Options.UseBackColor = true;
            this.pnlLoginAction.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlLoginAction.Controls.Add(this.btnAccept);
            this.pnlLoginAction.Controls.Add(this.btnCancel);
            this.pnlLoginAction.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlLoginAction.Location = new System.Drawing.Point(0, 117);
            this.pnlLoginAction.Name = "pnlLoginAction";
            this.pnlLoginAction.Size = new System.Drawing.Size(454, 63);
            this.pnlLoginAction.TabIndex = 6;
            // 
            // btnAccept
            // 
            this.btnAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAccept.Image = global::BrawijayaWorkshop.Win32App.Properties.Resources.apply_32x32;
            this.btnAccept.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnAccept.Location = new System.Drawing.Point(241, 12);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(91, 41);
            this.btnAccept.TabIndex = 5;
            this.btnAccept.Text = "Masuk";
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Image = global::BrawijayaWorkshop.Win32App.Properties.Resources.cancel_32x32;
            this.btnCancel.Location = new System.Drawing.Point(351, 12);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(91, 41);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Batal";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // peLogin
            // 
            this.peLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.peLogin.EditValue = global::BrawijayaWorkshop.Win32App.Properties.Resources.app_login;
            this.peLogin.Location = new System.Drawing.Point(12, 12);
            this.peLogin.Name = "peLogin";
            this.peLogin.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.peLogin.Properties.Appearance.Options.UseBackColor = true;
            this.peLogin.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.peLogin.Properties.ReadOnly = true;
            this.peLogin.Properties.ShowMenu = false;
            this.peLogin.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.peLogin.Size = new System.Drawing.Size(100, 96);
            this.peLogin.TabIndex = 7;
            // 
            // LoginForm
            // 
            this.AcceptButton = this.btnAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(454, 180);
            this.ControlBox = false;
            this.Controls.Add(this.peLogin);
            this.Controls.Add(this.pnlLoginAction);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.lblUserName);
            this.MinimumSize = new System.Drawing.Size(470, 219);
            this.Name = "LoginForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlLoginAction)).EndInit();
            this.pnlLoginAction.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.peLogin.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblUserName;
        private DevExpress.XtraEditors.TextEdit txtUserName;
        private DevExpress.XtraEditors.LabelControl lblPassword;
        private DevExpress.XtraEditors.TextEdit txtPassword;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnAccept;
        private DevExpress.XtraEditors.PanelControl pnlLoginAction;
        private DevExpress.XtraEditors.PictureEdit peLogin;
    }
}