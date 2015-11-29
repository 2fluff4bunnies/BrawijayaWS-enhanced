namespace BrawijayaWorkshop.Win32App.ModulForms
{
    partial class SparepartDetailListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SparepartDetailListForm));
            this.groupFilter = new DevExpress.XtraEditors.GroupControl();
            this.lookupStatus = new DevExpress.XtraEditors.LookUpEdit();
            this.lblFilterStatus = new DevExpress.XtraEditors.LabelControl();
            this.gridSparepartDetail = new DevExpress.XtraGrid.GridControl();
            this.gvSparepartDetail = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCodeDetail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bgwMain = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.groupFilter)).BeginInit();
            this.groupFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookupStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSparepartDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSparepartDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // groupFilter
            // 
            this.groupFilter.Controls.Add(this.lookupStatus);
            this.groupFilter.Controls.Add(this.lblFilterStatus);
            this.groupFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupFilter.Location = new System.Drawing.Point(0, 0);
            this.groupFilter.Name = "groupFilter";
            this.groupFilter.Size = new System.Drawing.Size(693, 62);
            this.groupFilter.TabIndex = 0;
            this.groupFilter.Text = "Filter";
            // 
            // lookupStatus
            // 
            this.lookupStatus.Location = new System.Drawing.Point(63, 29);
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
            this.lookupStatus.TabIndex = 1;
            this.lookupStatus.EditValueChanged += new System.EventHandler(this.lookupStatus_EditValueChanged);
            // 
            // lblFilterStatus
            // 
            this.lblFilterStatus.Location = new System.Drawing.Point(12, 32);
            this.lblFilterStatus.Name = "lblFilterStatus";
            this.lblFilterStatus.Size = new System.Drawing.Size(31, 13);
            this.lblFilterStatus.TabIndex = 0;
            this.lblFilterStatus.Text = "Status";
            // 
            // gridSparepartDetail
            // 
            this.gridSparepartDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridSparepartDetail.Location = new System.Drawing.Point(0, 62);
            this.gridSparepartDetail.MainView = this.gvSparepartDetail;
            this.gridSparepartDetail.Name = "gridSparepartDetail";
            this.gridSparepartDetail.Size = new System.Drawing.Size(693, 243);
            this.gridSparepartDetail.TabIndex = 1;
            this.gridSparepartDetail.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSparepartDetail});
            // 
            // gvSparepartDetail
            // 
            this.gvSparepartDetail.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCodeDetail});
            this.gvSparepartDetail.GridControl = this.gridSparepartDetail;
            this.gvSparepartDetail.Name = "gvSparepartDetail";
            this.gvSparepartDetail.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvSparepartDetail.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvSparepartDetail.OptionsBehavior.AutoPopulateColumns = false;
            this.gvSparepartDetail.OptionsBehavior.Editable = false;
            this.gvSparepartDetail.OptionsBehavior.ReadOnly = true;
            this.gvSparepartDetail.OptionsCustomization.AllowColumnMoving = false;
            this.gvSparepartDetail.OptionsCustomization.AllowQuickHideColumns = false;
            this.gvSparepartDetail.OptionsMenu.EnableFooterMenu = false;
            this.gvSparepartDetail.OptionsView.EnableAppearanceEvenRow = true;
            this.gvSparepartDetail.OptionsView.ShowFooter = true;
            this.gvSparepartDetail.OptionsView.ShowGroupPanel = false;
            this.gvSparepartDetail.OptionsView.ShowViewCaption = true;
            this.gvSparepartDetail.ViewCaption = "Daftar Detil Sparepart";
            // 
            // colCodeDetail
            // 
            this.colCodeDetail.Caption = "Nomor Seri";
            this.colCodeDetail.FieldName = "Code";
            this.colCodeDetail.Name = "colCodeDetail";
            this.colCodeDetail.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "Code", "Jumlah Data: {0}")});
            this.colCodeDetail.Visible = true;
            this.colCodeDetail.VisibleIndex = 0;
            // 
            // bgwMain
            // 
            this.bgwMain.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwMain_DoWork);
            this.bgwMain.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwMain_RunWorkerCompleted);
            // 
            // SparepartDetailListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 305);
            this.Controls.Add(this.gridSparepartDetail);
            this.Controls.Add(this.groupFilter);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SparepartDetailListForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detil Sparepart : {0}";
            ((System.ComponentModel.ISupportInitialize)(this.groupFilter)).EndInit();
            this.groupFilter.ResumeLayout(false);
            this.groupFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookupStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSparepartDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSparepartDetail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupFilter;
        private DevExpress.XtraGrid.GridControl gridSparepartDetail;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSparepartDetail;
        private DevExpress.XtraEditors.LabelControl lblFilterStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colCodeDetail;
        private DevExpress.XtraEditors.LookUpEdit lookupStatus;
        private System.ComponentModel.BackgroundWorker bgwMain;
    }
}