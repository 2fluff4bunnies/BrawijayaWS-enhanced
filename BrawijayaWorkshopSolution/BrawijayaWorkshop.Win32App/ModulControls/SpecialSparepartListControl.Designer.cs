﻿namespace BrawijayaWorkshop.Win32App.ModulControls
{
    partial class SpecialSparepartListControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpecialSparepartListControl));
            this.groupFilter = new DevExpress.XtraEditors.GroupControl();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.txtFilter = new DevExpress.XtraEditors.TextEdit();
            this.lblName = new DevExpress.XtraEditors.LabelControl();
            this.gcSpecialSparepart = new DevExpress.XtraGrid.GridControl();
            this.gvSpecialSparepart = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSparepartName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSparepartCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSparepartUnit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSparepartStock = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnNewSpecialSparepart = new DevExpress.XtraEditors.SimpleButton();
            this.cmsEditor = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.viewDetailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cmsEditData = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsDeleteData = new System.Windows.Forms.ToolStripMenuItem();
            this.bgwMain = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.groupFilter)).BeginInit();
            this.groupFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFilter.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSpecialSparepart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSpecialSparepart)).BeginInit();
            this.cmsEditor.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupFilter
            // 
            this.groupFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupFilter.Controls.Add(this.btnSearch);
            this.groupFilter.Controls.Add(this.txtFilter);
            this.groupFilter.Controls.Add(this.lblName);
            this.groupFilter.Location = new System.Drawing.Point(3, 3);
            this.groupFilter.Name = "groupFilter";
            this.groupFilter.Size = new System.Drawing.Size(825, 63);
            this.groupFilter.TabIndex = 1;
            this.groupFilter.Text = "Filter";
            // 
            // btnSearch
            // 
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnSearch.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnSearch.Location = new System.Drawing.Point(445, 28);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(55, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "cari";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(82, 31);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(345, 20);
            this.txtFilter.TabIndex = 3;
            this.txtFilter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSpecialSparepartName_KeyDown);
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(10, 34);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(48, 13);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Nama Ban";
            // 
            // gcSpecialSparepart
            // 
            this.gcSpecialSparepart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcSpecialSparepart.Location = new System.Drawing.Point(3, 101);
            this.gcSpecialSparepart.MainView = this.gvSpecialSparepart;
            this.gcSpecialSparepart.Name = "gcSpecialSparepart";
            this.gcSpecialSparepart.Size = new System.Drawing.Size(825, 337);
            this.gcSpecialSparepart.TabIndex = 5;
            this.gcSpecialSparepart.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSpecialSparepart});
            // 
            // gvSpecialSparepart
            // 
            this.gvSpecialSparepart.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSparepartName,
            this.colSparepartCode,
            this.colSparepartUnit,
            this.colSparepartStock});
            this.gvSpecialSparepart.GridControl = this.gcSpecialSparepart;
            this.gvSpecialSparepart.Name = "gvSpecialSparepart";
            this.gvSpecialSparepart.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvSpecialSparepart.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvSpecialSparepart.OptionsBehavior.AutoPopulateColumns = false;
            this.gvSpecialSparepart.OptionsBehavior.Editable = false;
            this.gvSpecialSparepart.OptionsBehavior.ReadOnly = true;
            this.gvSpecialSparepart.OptionsCustomization.AllowColumnMoving = false;
            this.gvSpecialSparepart.OptionsCustomization.AllowQuickHideColumns = false;
            this.gvSpecialSparepart.OptionsView.EnableAppearanceEvenRow = true;
            this.gvSpecialSparepart.OptionsView.ShowGroupPanel = false;
            this.gvSpecialSparepart.OptionsView.ShowViewCaption = true;
            this.gvSpecialSparepart.ViewCaption = "Daftar Ban";
            // 
            // colSparepartName
            // 
            this.colSparepartName.Caption = "Nama";
            this.colSparepartName.FieldName = "Sparepart.Name";
            this.colSparepartName.Name = "colSparepartName";
            this.colSparepartName.Visible = true;
            this.colSparepartName.VisibleIndex = 0;
            // 
            // colSparepartCode
            // 
            this.colSparepartCode.Caption = "Kode Sparepart";
            this.colSparepartCode.FieldName = "Sparepart.Code";
            this.colSparepartCode.Name = "colSparepartCode";
            this.colSparepartCode.Visible = true;
            this.colSparepartCode.VisibleIndex = 1;
            // 
            // colSparepartUnit
            // 
            this.colSparepartUnit.Caption = "Unit/Satuan";
            this.colSparepartUnit.FieldName = "Sparepart.UnitReference.Name";
            this.colSparepartUnit.Name = "colSparepartUnit";
            this.colSparepartUnit.Visible = true;
            this.colSparepartUnit.VisibleIndex = 2;
            // 
            // colSparepartStock
            // 
            this.colSparepartStock.Caption = "Stok";
            this.colSparepartStock.FieldName = "Sparepart.StockQty";
            this.colSparepartStock.Name = "colSparepartStock";
            this.colSparepartStock.Visible = true;
            this.colSparepartStock.VisibleIndex = 3;
            // 
            // btnNewSpecialSparepart
            // 
            this.btnNewSpecialSparepart.Image = ((System.Drawing.Image)(resources.GetObject("btnNewSpecialSparepart.Image")));
            this.btnNewSpecialSparepart.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnNewSpecialSparepart.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnNewSpecialSparepart.Location = new System.Drawing.Point(3, 72);
            this.btnNewSpecialSparepart.Name = "btnNewSpecialSparepart";
            this.btnNewSpecialSparepart.Size = new System.Drawing.Size(105, 23);
            this.btnNewSpecialSparepart.TabIndex = 6;
            this.btnNewSpecialSparepart.Text = "Buat Ban Baru";
            this.btnNewSpecialSparepart.Click += new System.EventHandler(this.btnNewSpecialSparepart_Click);
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
            // SpecialSparepartListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnNewSpecialSparepart);
            this.Controls.Add(this.gcSpecialSparepart);
            this.Controls.Add(this.groupFilter);
            this.Name = "SpecialSparepartListControl";
            this.Size = new System.Drawing.Size(831, 441);
            ((System.ComponentModel.ISupportInitialize)(this.groupFilter)).EndInit();
            this.groupFilter.ResumeLayout(false);
            this.groupFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFilter.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSpecialSparepart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSpecialSparepart)).EndInit();
            this.cmsEditor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupFilter;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.TextEdit txtFilter;
        private DevExpress.XtraEditors.LabelControl lblName;
        private DevExpress.XtraGrid.GridControl gcSpecialSparepart;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSpecialSparepart;
        private DevExpress.XtraGrid.Columns.GridColumn colSparepartCode;
        private DevExpress.XtraGrid.Columns.GridColumn colSparepartName;
        private DevExpress.XtraGrid.Columns.GridColumn colSparepartUnit;
        private DevExpress.XtraGrid.Columns.GridColumn colSparepartStock;
        private DevExpress.XtraEditors.SimpleButton btnNewSpecialSparepart;
        private System.Windows.Forms.ContextMenuStrip cmsEditor;
        private System.Windows.Forms.ToolStripMenuItem viewDetailToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem cmsEditData;
        private System.Windows.Forms.ToolStripMenuItem cmsDeleteData;
        private System.ComponentModel.BackgroundWorker bgwMain;

    }
}
