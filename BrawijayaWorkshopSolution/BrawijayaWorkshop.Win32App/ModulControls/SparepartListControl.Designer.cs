namespace BrawijayaWorkshop.Win32App.ModulControls
{
    partial class SparepartListControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SparepartListControl));
            this.groupFilter = new DevExpress.XtraEditors.GroupControl();
            this.lookUpCategory = new DevExpress.XtraEditors.LookUpEdit();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.txtSparepartName = new DevExpress.XtraEditors.TextEdit();
            this.lblName = new DevExpress.XtraEditors.LabelControl();
            this.lblCategory = new DevExpress.XtraEditors.LabelControl();
            this.btnNewSparepart = new DevExpress.XtraEditors.SimpleButton();
            this.gridSparepart = new DevExpress.XtraGrid.GridControl();
            this.gvSparepart = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSparepartCategory = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSparepartCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSparepartName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSparepartUnit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSparepartStock = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmsEditor = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.viewDetailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cmsEditData = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsDeleteData = new System.Windows.Forms.ToolStripMenuItem();
            this.bgwMain = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.groupFilter)).BeginInit();
            this.groupFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpCategory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSparepartName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSparepart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSparepart)).BeginInit();
            this.cmsEditor.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupFilter
            // 
            this.groupFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupFilter.Controls.Add(this.lookUpCategory);
            this.groupFilter.Controls.Add(this.btnSearch);
            this.groupFilter.Controls.Add(this.txtSparepartName);
            this.groupFilter.Controls.Add(this.lblName);
            this.groupFilter.Controls.Add(this.lblCategory);
            this.groupFilter.Location = new System.Drawing.Point(3, 3);
            this.groupFilter.Name = "groupFilter";
            this.groupFilter.Size = new System.Drawing.Size(853, 63);
            this.groupFilter.TabIndex = 0;
            this.groupFilter.Text = "Filter";
            // 
            // lookUpCategory
            // 
            this.lookUpCategory.Location = new System.Drawing.Point(69, 31);
            this.lookUpCategory.Name = "lookUpCategory";
            this.lookUpCategory.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.lookUpCategory.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpCategory.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Value", "Kode"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Kategori")});
            this.lookUpCategory.Properties.DisplayMember = "Name";
            this.lookUpCategory.Properties.HideSelection = false;
            this.lookUpCategory.Properties.NullText = "-- Kategori --";
            this.lookUpCategory.Properties.ValueMember = "Id";
            this.lookUpCategory.Size = new System.Drawing.Size(141, 20);
            this.lookUpCategory.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnSearch.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnSearch.Location = new System.Drawing.Point(787, 28);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(55, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "cari";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSparepartName
            // 
            this.txtSparepartName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSparepartName.Location = new System.Drawing.Point(355, 31);
            this.txtSparepartName.Name = "txtSparepartName";
            this.txtSparepartName.Size = new System.Drawing.Size(426, 20);
            this.txtSparepartName.TabIndex = 3;
            this.txtSparepartName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSparepartName_KeyDown);
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(258, 34);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(78, 13);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Nama Sparepart";
            // 
            // lblCategory
            // 
            this.lblCategory.Location = new System.Drawing.Point(11, 34);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(40, 13);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.Text = "Kategori";
            // 
            // btnNewSparepart
            // 
            this.btnNewSparepart.Image = ((System.Drawing.Image)(resources.GetObject("btnNewSparepart.Image")));
            this.btnNewSparepart.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnNewSparepart.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnNewSparepart.Location = new System.Drawing.Point(3, 72);
            this.btnNewSparepart.Name = "btnNewSparepart";
            this.btnNewSparepart.Size = new System.Drawing.Size(144, 23);
            this.btnNewSparepart.TabIndex = 3;
            this.btnNewSparepart.Text = "Buat Sparepart Baru";
            this.btnNewSparepart.Click += new System.EventHandler(this.btnNewSparepart_Click);
            // 
            // gridSparepart
            // 
            this.gridSparepart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridSparepart.Location = new System.Drawing.Point(3, 101);
            this.gridSparepart.MainView = this.gvSparepart;
            this.gridSparepart.Name = "gridSparepart";
            this.gridSparepart.Size = new System.Drawing.Size(853, 355);
            this.gridSparepart.TabIndex = 4;
            this.gridSparepart.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSparepart});
            // 
            // gvSparepart
            // 
            this.gvSparepart.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSparepartCategory,
            this.colSparepartCode,
            this.colSparepartName,
            this.colSparepartUnit,
            this.colSparepartStock});
            this.gvSparepart.GridControl = this.gridSparepart;
            this.gvSparepart.Name = "gvSparepart";
            this.gvSparepart.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvSparepart.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvSparepart.OptionsBehavior.AutoPopulateColumns = false;
            this.gvSparepart.OptionsBehavior.Editable = false;
            this.gvSparepart.OptionsBehavior.ReadOnly = true;
            this.gvSparepart.OptionsCustomization.AllowColumnMoving = false;
            this.gvSparepart.OptionsCustomization.AllowQuickHideColumns = false;
            this.gvSparepart.OptionsView.EnableAppearanceEvenRow = true;
            this.gvSparepart.OptionsView.ShowGroupPanel = false;
            this.gvSparepart.OptionsView.ShowViewCaption = true;
            this.gvSparepart.ViewCaption = "Daftar Sparepart";
            // 
            // colSparepartCategory
            // 
            this.colSparepartCategory.Caption = "Kategori";
            this.colSparepartCategory.FieldName = "CategoryReference.Name";
            this.colSparepartCategory.Name = "colSparepartCategory";
            this.colSparepartCategory.Visible = true;
            this.colSparepartCategory.VisibleIndex = 0;
            // 
            // colSparepartCode
            // 
            this.colSparepartCode.Caption = "Kode";
            this.colSparepartCode.FieldName = "Code";
            this.colSparepartCode.Name = "colSparepartCode";
            this.colSparepartCode.Visible = true;
            this.colSparepartCode.VisibleIndex = 1;
            // 
            // colSparepartName
            // 
            this.colSparepartName.Caption = "Nama";
            this.colSparepartName.FieldName = "Name";
            this.colSparepartName.Name = "colSparepartName";
            this.colSparepartName.Visible = true;
            this.colSparepartName.VisibleIndex = 2;
            // 
            // colSparepartUnit
            // 
            this.colSparepartUnit.Caption = "Unit/Satuan";
            this.colSparepartUnit.FieldName = "UnitReference.Value";
            this.colSparepartUnit.Name = "colSparepartUnit";
            this.colSparepartUnit.Visible = true;
            this.colSparepartUnit.VisibleIndex = 3;
            // 
            // colSparepartStock
            // 
            this.colSparepartStock.Caption = "Stok";
            this.colSparepartStock.FieldName = "StockQty";
            this.colSparepartStock.Name = "colSparepartStock";
            this.colSparepartStock.Visible = true;
            this.colSparepartStock.VisibleIndex = 4;
            // 
            // cmsEditor
            // 
            this.cmsEditor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewDetailToolStripMenuItem,
            this.toolStripSeparator1,
            this.cmsEditData,
            this.cmsDeleteData});
            this.cmsEditor.Name = "cmsListEditor";
            this.cmsEditor.Size = new System.Drawing.Size(136, 76);
            // 
            // viewDetailToolStripMenuItem
            // 
            this.viewDetailToolStripMenuItem.Image = global::BrawijayaWorkshop.Win32App.Properties.Resources.zoom_icon;
            this.viewDetailToolStripMenuItem.Name = "viewDetailToolStripMenuItem";
            this.viewDetailToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.viewDetailToolStripMenuItem.Text = "Lihat Detail";
            this.viewDetailToolStripMenuItem.Click += new System.EventHandler(this.viewDetailToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(132, 6);
            // 
            // cmsEditData
            // 
            this.cmsEditData.Image = global::BrawijayaWorkshop.Win32App.Properties.Resources.edit_icon;
            this.cmsEditData.Name = "cmsEditData";
            this.cmsEditData.Size = new System.Drawing.Size(135, 22);
            this.cmsEditData.Text = "Ubah Data";
            this.cmsEditData.Click += new System.EventHandler(this.cmsEditData_Click);
            // 
            // cmsDeleteData
            // 
            this.cmsDeleteData.Image = global::BrawijayaWorkshop.Win32App.Properties.Resources.delete_icon;
            this.cmsDeleteData.Name = "cmsDeleteData";
            this.cmsDeleteData.Size = new System.Drawing.Size(135, 22);
            this.cmsDeleteData.Text = "Hapus Data";
            this.cmsDeleteData.Click += new System.EventHandler(this.cmsDeleteData_Click);
            // 
            // bgwMain
            // 
            this.bgwMain.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwMain_DoWork);
            this.bgwMain.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwMain_RunWorkerCompleted);
            // 
            // SparepartListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridSparepart);
            this.Controls.Add(this.btnNewSparepart);
            this.Controls.Add(this.groupFilter);
            this.Name = "SparepartListControl";
            this.Size = new System.Drawing.Size(859, 459);
            ((System.ComponentModel.ISupportInitialize)(this.groupFilter)).EndInit();
            this.groupFilter.ResumeLayout(false);
            this.groupFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpCategory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSparepartName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSparepart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSparepart)).EndInit();
            this.cmsEditor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupFilter;
        private DevExpress.XtraEditors.LabelControl lblCategory;
        private DevExpress.XtraEditors.TextEdit txtSparepartName;
        private DevExpress.XtraEditors.LabelControl lblName;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.SimpleButton btnNewSparepart;
        private DevExpress.XtraGrid.GridControl gridSparepart;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSparepart;
        private System.Windows.Forms.ContextMenuStrip cmsEditor;
        private System.Windows.Forms.ToolStripMenuItem cmsEditData;
        private System.Windows.Forms.ToolStripMenuItem cmsDeleteData;
        private System.ComponentModel.BackgroundWorker bgwMain;
        private DevExpress.XtraGrid.Columns.GridColumn colSparepartCategory;
        private DevExpress.XtraGrid.Columns.GridColumn colSparepartCode;
        private DevExpress.XtraGrid.Columns.GridColumn colSparepartName;
        private DevExpress.XtraGrid.Columns.GridColumn colSparepartUnit;
        private DevExpress.XtraGrid.Columns.GridColumn colSparepartStock;
        private DevExpress.XtraEditors.LookUpEdit lookUpCategory;
        private System.Windows.Forms.ToolStripMenuItem viewDetailToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}
