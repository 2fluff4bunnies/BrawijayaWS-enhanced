namespace BrawijayaWorkshop.Win32App.ModulControls
{
    partial class NotificationListControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupPendingSPK = new DevExpress.XtraEditors.GroupControl();
            this.gridPendingSPK = new DevExpress.XtraGrid.GridControl();
            this.gvPendingSPK = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.groupPendingSPK)).BeginInit();
            this.groupPendingSPK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPendingSPK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPendingSPK)).BeginInit();
            this.SuspendLayout();
            // 
            // groupPendingSPK
            // 
            this.groupPendingSPK.Controls.Add(this.gridPendingSPK);
            this.groupPendingSPK.Location = new System.Drawing.Point(3, 3);
            this.groupPendingSPK.Name = "groupPendingSPK";
            this.groupPendingSPK.Size = new System.Drawing.Size(813, 232);
            this.groupPendingSPK.TabIndex = 0;
            this.groupPendingSPK.Text = "Daftar Pending SPK";
            // 
            // gridPendingSPK
            // 
            this.gridPendingSPK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridPendingSPK.Location = new System.Drawing.Point(2, 20);
            this.gridPendingSPK.MainView = this.gvPendingSPK;
            this.gridPendingSPK.Name = "gridPendingSPK";
            this.gridPendingSPK.Size = new System.Drawing.Size(809, 210);
            this.gridPendingSPK.TabIndex = 0;
            this.gridPendingSPK.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPendingSPK});
            // 
            // gvPendingSPK
            // 
            this.gvPendingSPK.GridControl = this.gridPendingSPK;
            this.gvPendingSPK.Name = "gvPendingSPK";
            this.gvPendingSPK.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvPendingSPK.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvPendingSPK.OptionsBehavior.AutoPopulateColumns = false;
            this.gvPendingSPK.OptionsBehavior.Editable = false;
            this.gvPendingSPK.OptionsBehavior.ReadOnly = true;
            this.gvPendingSPK.OptionsCustomization.AllowColumnMoving = false;
            this.gvPendingSPK.OptionsCustomization.AllowQuickHideColumns = false;
            this.gvPendingSPK.OptionsView.EnableAppearanceEvenRow = true;
            this.gvPendingSPK.OptionsView.ShowGroupPanel = false;
            this.gvPendingSPK.OptionsView.ShowViewCaption = true;
            this.gvPendingSPK.ViewCaption = "Daftar Pending SPK";
            // 
            // NotificationListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupPendingSPK);
            this.Name = "NotificationListControl";
            this.Size = new System.Drawing.Size(819, 423);
            ((System.ComponentModel.ISupportInitialize)(this.groupPendingSPK)).EndInit();
            this.groupPendingSPK.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridPendingSPK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPendingSPK)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupPendingSPK;
        private DevExpress.XtraGrid.GridControl gridPendingSPK;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPendingSPK;
    }
}
