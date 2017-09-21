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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpecialSparepartDetailListForm));
            this.gridSpecialSparepartDetail = new DevExpress.XtraGrid.GridControl();
            this.gvSpecialSparepartDetail = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCodeDetail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSerialNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupInfo = new DevExpress.XtraEditors.GroupControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.txtSerialNumberUpdate = new DevExpress.XtraEditors.TextEdit();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.lookupStatus = new DevExpress.XtraEditors.LookUpEdit();
            this.txtSerialNumber = new DevExpress.XtraEditors.TextEdit();
            this.lblSerialNumber = new DevExpress.XtraEditors.LabelControl();
            this.lblFilterStatus = new DevExpress.XtraEditors.LabelControl();
            this.bgwMain = new System.ComponentModel.BackgroundWorker();
            this.cmsEditor = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsDeleteData = new System.Windows.Forms.ToolStripMenuItem();
            this.bgwDelete = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.gridSpecialSparepartDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSpecialSparepartDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupInfo)).BeginInit();
            this.groupInfo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSerialNumberUpdate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSerialNumber.Properties)).BeginInit();
            this.cmsEditor.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridSpecialSparepartDetail
            // 
            this.gridSpecialSparepartDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridSpecialSparepartDetail.Location = new System.Drawing.Point(0, 95);
            this.gridSpecialSparepartDetail.MainView = this.gvSpecialSparepartDetail;
            this.gridSpecialSparepartDetail.Name = "gridSpecialSparepartDetail";
            this.gridSpecialSparepartDetail.Size = new System.Drawing.Size(664, 318);
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
            this.groupInfo.Controls.Add(this.groupBox1);
            this.groupInfo.Controls.Add(this.btnSearch);
            this.groupInfo.Controls.Add(this.lookupStatus);
            this.groupInfo.Controls.Add(this.txtSerialNumber);
            this.groupInfo.Controls.Add(this.lblSerialNumber);
            this.groupInfo.Controls.Add(this.lblFilterStatus);
            this.groupInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupInfo.Location = new System.Drawing.Point(0, 0);
            this.groupInfo.Name = "groupInfo";
            this.groupInfo.Size = new System.Drawing.Size(664, 95);
            this.groupInfo.TabIndex = 1;
            this.groupInfo.Text = "Info";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.txtSerialNumberUpdate);
            this.groupBox1.Location = new System.Drawing.Point(353, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 60);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Update Nomor Seri";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnSave.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnSave.Location = new System.Drawing.Point(247, 24);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(55, 23);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "simpan";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtSerialNumberUpdate
            // 
            this.txtSerialNumberUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSerialNumberUpdate.Location = new System.Drawing.Point(6, 26);
            this.txtSerialNumberUpdate.Name = "txtSerialNumberUpdate";
            this.txtSerialNumberUpdate.Size = new System.Drawing.Size(235, 20);
            this.txtSerialNumberUpdate.TabIndex = 10;
            // 
            // btnSearch
            // 
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnSearch.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnSearch.Location = new System.Drawing.Point(246, 30);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(55, 23);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "cari";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lookupStatus
            // 
            this.lookupStatus.Location = new System.Drawing.Point(77, 31);
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
            // txtSerialNumber
            // 
            this.txtSerialNumber.Location = new System.Drawing.Point(77, 63);
            this.txtSerialNumber.Name = "txtSerialNumber";
            this.txtSerialNumber.Size = new System.Drawing.Size(160, 20);
            this.txtSerialNumber.TabIndex = 6;
            // 
            // lblSerialNumber
            // 
            this.lblSerialNumber.Location = new System.Drawing.Point(14, 66);
            this.lblSerialNumber.Name = "lblSerialNumber";
            this.lblSerialNumber.Size = new System.Drawing.Size(52, 13);
            this.lblSerialNumber.TabIndex = 5;
            this.lblSerialNumber.Text = "Nomor Seri";
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
            // cmsEditor
            // 
            this.cmsEditor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsDeleteData});
            this.cmsEditor.Name = "cmsListEditor";
            this.cmsEditor.Size = new System.Drawing.Size(136, 26);
            // 
            // cmsDeleteData
            // 
            this.cmsDeleteData.Image = global::BrawijayaWorkshop.Win32App.Properties.Resources.delete_icon;
            this.cmsDeleteData.Name = "cmsDeleteData";
            this.cmsDeleteData.Size = new System.Drawing.Size(135, 22);
            this.cmsDeleteData.Text = "Hapus Data";
            this.cmsDeleteData.Click += new System.EventHandler(this.cmsDeleteData_Click);
            // 
            // bgwDelete
            // 
            this.bgwDelete.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwDelete_DoWork);
            this.bgwDelete.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwDelete_RunWorkerCompleted);
            // 
            // SpecialSparepartDetailListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 413);
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
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtSerialNumberUpdate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSerialNumber.Properties)).EndInit();
            this.cmsEditor.ResumeLayout(false);
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
        private System.Windows.Forms.ContextMenuStrip cmsEditor;
        private System.Windows.Forms.ToolStripMenuItem cmsDeleteData;
        private System.ComponentModel.BackgroundWorker bgwDelete;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.TextEdit txtSerialNumber;
        private DevExpress.XtraEditors.LabelControl lblSerialNumber;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.TextEdit txtSerialNumberUpdate;
        private DevExpress.XtraEditors.SimpleButton btnSave;
    }
}