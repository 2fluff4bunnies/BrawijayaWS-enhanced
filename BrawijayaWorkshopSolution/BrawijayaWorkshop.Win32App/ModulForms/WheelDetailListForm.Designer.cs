namespace BrawijayaWorkshop.Win32App.ModulForms
{
    partial class WheelDetailListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WheelDetailListForm));
            this.gridWheelDetail = new DevExpress.XtraGrid.GridControl();
            this.gvWheelDetail = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCodeDetail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSerialNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupInfo = new DevExpress.XtraEditors.GroupControl();
            this.lookupStatus = new DevExpress.XtraEditors.LookUpEdit();
            this.lblFilterStatus = new DevExpress.XtraEditors.LabelControl();
            this.bgwMain = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.gridWheelDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvWheelDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupInfo)).BeginInit();
            this.groupInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookupStatus.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridWheelDetail
            // 
            this.gridWheelDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridWheelDetail.Location = new System.Drawing.Point(0, 62);
            this.gridWheelDetail.MainView = this.gvWheelDetail;
            this.gridWheelDetail.Name = "gridWheelDetail";
            this.gridWheelDetail.Size = new System.Drawing.Size(692, 237);
            this.gridWheelDetail.TabIndex = 2;
            this.gridWheelDetail.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvWheelDetail});
            // 
            // gvWheelDetail
            // 
            this.gvWheelDetail.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCodeDetail,
            this.colSerialNumber});
            this.gvWheelDetail.GridControl = this.gridWheelDetail;
            this.gvWheelDetail.Name = "gvWheelDetail";
            this.gvWheelDetail.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvWheelDetail.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvWheelDetail.OptionsBehavior.AutoPopulateColumns = false;
            this.gvWheelDetail.OptionsBehavior.Editable = false;
            this.gvWheelDetail.OptionsBehavior.ReadOnly = true;
            this.gvWheelDetail.OptionsCustomization.AllowColumnMoving = false;
            this.gvWheelDetail.OptionsCustomization.AllowQuickHideColumns = false;
            this.gvWheelDetail.OptionsMenu.EnableFooterMenu = false;
            this.gvWheelDetail.OptionsView.EnableAppearanceEvenRow = true;
            this.gvWheelDetail.OptionsView.ShowFooter = true;
            this.gvWheelDetail.OptionsView.ShowGroupPanel = false;
            this.gvWheelDetail.OptionsView.ShowViewCaption = true;
            this.gvWheelDetail.ViewCaption = "Daftar Ban Satuan";
            // 
            // colCodeDetail
            // 
            this.colCodeDetail.Caption = "Kode";
            this.colCodeDetail.FieldName = "Code";
            this.colCodeDetail.Name = "colCodeDetail";
            this.colCodeDetail.Visible = true;
            this.colCodeDetail.VisibleIndex = 0;
            // 
            // colSerialNumber
            // 
            this.colSerialNumber.Caption = "Nomor Seri";
            this.colSerialNumber.Name = "colSerialNumber";
            this.colSerialNumber.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "", "Jumlah Data: {0}")});
            this.colSerialNumber.Visible = true;
            this.colSerialNumber.VisibleIndex = 1;
            // 
            // groupInfo
            // 
            this.groupInfo.Controls.Add(this.lookupStatus);
            this.groupInfo.Controls.Add(this.lblFilterStatus);
            this.groupInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupInfo.Location = new System.Drawing.Point(0, 0);
            this.groupInfo.Name = "groupInfo";
            this.groupInfo.Size = new System.Drawing.Size(692, 62);
            this.groupInfo.TabIndex = 1;
            this.groupInfo.Text = "Info";
            // 
            // lookupStatus
            // 
            this.lookupStatus.Location = new System.Drawing.Point(65, 31);
            this.lookupStatus.Name = "lookupStatus";
            this.lookupStatus.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.lookupStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookupStatus.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Status")});
            this.lookupStatus.Properties.DisplayMember = "Description";
            this.lookupStatus.Properties.HideSelection = false;
            this.lookupStatus.Properties.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned;
            this.lookupStatus.Properties.NullText = "-- Pilih Status --";
            this.lookupStatus.Properties.ShowFooter = false;
            this.lookupStatus.Properties.ValueMember = "Status";
            this.lookupStatus.Size = new System.Drawing.Size(160, 20);
            this.lookupStatus.TabIndex = 3;
            this.lookupStatus.EditValueChanged += new System.EventHandler(this.lookupStatus_EditValueChanged);
            // 
            // lblFilterStatus
            // 
            this.lblFilterStatus.Location = new System.Drawing.Point(14, 34);
            this.lblFilterStatus.Name = "lblFilterStatus";
            this.lblFilterStatus.Size = new System.Drawing.Size(31, 13);
            this.lblFilterStatus.TabIndex = 2;
            this.lblFilterStatus.Text = "Status";
            // 
            // WheelDetailListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 299);
            this.Controls.Add(this.gridWheelDetail);
            this.Controls.Add(this.groupInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WheelDetailListForm";
            this.Text = "Detil Ban : {0}";
            ((System.ComponentModel.ISupportInitialize)(this.gridWheelDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvWheelDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupInfo)).EndInit();
            this.groupInfo.ResumeLayout(false);
            this.groupInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookupStatus.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridWheelDetail;
        private DevExpress.XtraGrid.Views.Grid.GridView gvWheelDetail;
        private DevExpress.XtraGrid.Columns.GridColumn colCodeDetail;
        private DevExpress.XtraGrid.Columns.GridColumn colSerialNumber;
        private DevExpress.XtraEditors.GroupControl groupInfo;
        private DevExpress.XtraEditors.LookUpEdit lookupStatus;
        private DevExpress.XtraEditors.LabelControl lblFilterStatus;
        private System.ComponentModel.BackgroundWorker bgwMain;
    }
}