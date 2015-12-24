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
            this.components = new System.ComponentModel.Container();
            this.groupPendingSPK = new DevExpress.XtraEditors.GroupControl();
            this.gridPendingSPK = new DevExpress.XtraGrid.GridControl();
            this.gvPendingSPK = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreateDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDueDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLicenseNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCategory = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmsEditor = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.approveToolStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bgwMain = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.groupPendingSPK)).BeginInit();
            this.groupPendingSPK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPendingSPK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPendingSPK)).BeginInit();
            this.cmsEditor.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupPendingSPK
            // 
            this.groupPendingSPK.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupPendingSPK.Controls.Add(this.gridPendingSPK);
            this.groupPendingSPK.Location = new System.Drawing.Point(3, 3);
            this.groupPendingSPK.Name = "groupPendingSPK";
            this.groupPendingSPK.Size = new System.Drawing.Size(813, 226);
            this.groupPendingSPK.TabIndex = 0;
            this.groupPendingSPK.Text = "Daftar Pending SPK";
            // 
            // gridPendingSPK
            // 
            this.gridPendingSPK.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridPendingSPK.Location = new System.Drawing.Point(4, 23);
            this.gridPendingSPK.MainView = this.gvPendingSPK;
            this.gridPendingSPK.Name = "gridPendingSPK";
            this.gridPendingSPK.Size = new System.Drawing.Size(809, 204);
            this.gridPendingSPK.TabIndex = 0;
            this.gridPendingSPK.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPendingSPK});
            // 
            // gvPendingSPK
            // 
            this.gvPendingSPK.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCode,
            this.colCreateDate,
            this.colDueDate,
            this.colLicenseNumber,
            this.colCategory});
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
            this.gvPendingSPK.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.gvPendingSPK_PopupMenuShowing);
            this.gvPendingSPK.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvPendingSPK_FocusedRowChanged);
            // 
            // colCode
            // 
            this.colCode.Caption = "Kode";
            this.colCode.FieldName = "Code";
            this.colCode.Name = "colCode";
            this.colCode.Visible = true;
            this.colCode.VisibleIndex = 0;
            // 
            // colCreateDate
            // 
            this.colCreateDate.Caption = "Tanggal Pembuatan";
            this.colCreateDate.FieldName = "CreateDate";
            this.colCreateDate.Name = "colCreateDate";
            this.colCreateDate.Visible = true;
            this.colCreateDate.VisibleIndex = 1;
            // 
            // colDueDate
            // 
            this.colDueDate.Caption = "Batas Waktu";
            this.colDueDate.FieldName = "DueDate";
            this.colDueDate.Name = "colDueDate";
            this.colDueDate.Visible = true;
            this.colDueDate.VisibleIndex = 2;
            // 
            // colLicenseNumber
            // 
            this.colLicenseNumber.Caption = "Nopol";
            this.colLicenseNumber.FieldName = "Vehicle.ActiveLicenseNumber";
            this.colLicenseNumber.Name = "colLicenseNumber";
            this.colLicenseNumber.Visible = true;
            this.colLicenseNumber.VisibleIndex = 3;
            // 
            // colCategory
            // 
            this.colCategory.Caption = "Kategori";
            this.colCategory.FieldName = "CategoryReference.Name";
            this.colCategory.Name = "colCategory";
            this.colCategory.Visible = true;
            this.colCategory.VisibleIndex = 4;
            // 
            // cmsEditor
            // 
            this.cmsEditor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.approveToolStripItem});
            this.cmsEditor.Name = "cmsEditor";
            this.cmsEditor.Size = new System.Drawing.Size(221, 26);
            // 
            // approveToolStripItem
            // 
            this.approveToolStripItem.Image = global::BrawijayaWorkshop.Win32App.Properties.Resources.approve_16x16;
            this.approveToolStripItem.Name = "approveToolStripItem";
            this.approveToolStripItem.Size = new System.Drawing.Size(220, 22);
            this.approveToolStripItem.Text = "Lakukan Proses Persetujuan";
            this.approveToolStripItem.Click += new System.EventHandler(this.approveToolStripItem_Click);
            // 
            // bgwMain
            // 
            this.bgwMain.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwMain_DoWork);
            this.bgwMain.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwMain_RunWorkerCompleted);
            // 
            // NotificationListControl
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.groupPendingSPK);
            this.Name = "NotificationListControl";
            this.Size = new System.Drawing.Size(819, 276);
            this.Load += new System.EventHandler(this.NotificationListControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupPendingSPK)).EndInit();
            this.groupPendingSPK.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridPendingSPK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPendingSPK)).EndInit();
            this.cmsEditor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupPendingSPK;
        private DevExpress.XtraGrid.GridControl gridPendingSPK;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPendingSPK;
        private System.Windows.Forms.ContextMenuStrip cmsEditor;
        private System.Windows.Forms.ToolStripMenuItem approveToolStripItem;
        private System.ComponentModel.BackgroundWorker bgwMain;
        private DevExpress.XtraGrid.Columns.GridColumn colCode;
        private DevExpress.XtraGrid.Columns.GridColumn colCreateDate;
        private DevExpress.XtraGrid.Columns.GridColumn colDueDate;
        private DevExpress.XtraGrid.Columns.GridColumn colLicenseNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colCategory;
    }
}
