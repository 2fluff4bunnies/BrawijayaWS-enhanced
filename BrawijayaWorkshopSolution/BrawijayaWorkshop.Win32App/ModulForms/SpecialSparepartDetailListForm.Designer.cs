namespace BrawijayaWorkshop.Win32App.ModulForms
{
    partial class SpecialSparepartDetailListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpecialSparepartDetailListForm));
            this.gridSpecialSparepartDetail = new DevExpress.XtraGrid.GridControl();
            this.gvSpecialSparepartDetail = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCodeDetail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSerialNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupInfo = new DevExpress.XtraEditors.GroupControl();
            this.lookupStatus = new DevExpress.XtraEditors.LookUpEdit();
            this.lblFilterStatus = new DevExpress.XtraEditors.LabelControl();
            this.bgwMain = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.gridSpecialSparepartDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSpecialSparepartDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupInfo)).BeginInit();
            this.groupInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookupStatus.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridSpecialSparepartDetail
            // 
            this.gridSpecialSparepartDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridSpecialSparepartDetail.Location = new System.Drawing.Point(0, 62);
            this.gridSpecialSparepartDetail.MainView = this.gvSpecialSparepartDetail;
            this.gridSpecialSparepartDetail.Name = "gridSpecialSparepartDetail";
            this.gridSpecialSparepartDetail.Size = new System.Drawing.Size(692, 237);
            this.gridSpecialSparepartDetail.TabIndex = 2;
            this.gridSpecialSparepartDetail.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSpecialSparepartDetail});
            // 
            // gvSpecialSparepartDetail
            // 
            this.gvSpecialSparepartDetail.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCodeDetail,
            this.colSerialNumber});
            this.gvSpecialSparepartDetail.GridControl = this.gridSpecialSparepartDetail;
            this.gvSpecialSparepartDetail.Name = "gvSpecialSparepartDetail";
            this.gvSpecialSparepartDetail.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvSpecialSparepartDetail.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvSpecialSparepartDetail.OptionsBehavior.AutoPopulateColumns = false;
            this.gvSpecialSparepartDetail.OptionsBehavior.Editable = false;
            this.gvSpecialSparepartDetail.OptionsBehavior.ReadOnly = true;
            this.gvSpecialSparepartDetail.OptionsCustomization.AllowColumnMoving = false;
            this.gvSpecialSparepartDetail.OptionsCustomization.AllowQuickHideColumns = false;
            this.gvSpecialSparepartDetail.OptionsMenu.EnableFooterMenu = false;
            this.gvSpecialSparepartDetail.OptionsView.EnableAppearanceEvenRow = true;
            this.gvSpecialSparepartDetail.OptionsView.ShowFooter = true;
            this.gvSpecialSparepartDetail.OptionsView.ShowGroupPanel = false;
            this.gvSpecialSparepartDetail.OptionsView.ShowViewCaption = true;
            this.gvSpecialSparepartDetail.ViewCaption = "Daftar Sparepart Spesial Per Item";
            // 
            // colCodeDetail
            // 
            this.colCodeDetail.Caption = "Kode";
            this.colCodeDetail.FieldName = "SparepartDetail.Code";
            this.colCodeDetail.Name = "colCodeDetail";
            this.colCodeDetail.Visible = true;
            this.colCodeDetail.VisibleIndex = 0;
            // 
            // colSerialNumber
            // 
            this.colSerialNumber.Caption = "Nomor Seri";
            this.colSerialNumber.FieldName = "SerialNumber";
            this.colSerialNumber.Name = "colSerialNumber";
            this.colSerialNumber.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "SerialNumber", "Jumlah Data: {0}")});
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
            // bgwMain
            // 
            this.bgwMain.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwMain_DoWork);
            this.bgwMain.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwMain_RunWorkerCompleted);
            // 
            // SpecialSparepartDetailListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 299);
            this.Controls.Add(this.gridSpecialSparepartDetail);
            this.Controls.Add(this.groupInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SpecialSparepartDetailListForm";
            this.Text = "Detil Sparepart Spesial: {0}";
            ((System.ComponentModel.ISupportInitialize)(this.gridSpecialSparepartDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSpecialSparepartDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupInfo)).EndInit();
            this.groupInfo.ResumeLayout(false);
            this.groupInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookupStatus.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridSpecialSparepartDetail;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSpecialSparepartDetail;
        private DevExpress.XtraGrid.Columns.GridColumn colCodeDetail;
        private DevExpress.XtraGrid.Columns.GridColumn colSerialNumber;
        private DevExpress.XtraEditors.GroupControl groupInfo;
        private DevExpress.XtraEditors.LookUpEdit lookupStatus;
        private DevExpress.XtraEditors.LabelControl lblFilterStatus;
        private System.ComponentModel.BackgroundWorker bgwMain;
    }
}