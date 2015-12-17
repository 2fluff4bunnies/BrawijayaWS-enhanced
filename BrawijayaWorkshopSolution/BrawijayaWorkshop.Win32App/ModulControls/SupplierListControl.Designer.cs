﻿namespace BrawijayaWorkshop.Win32App.ModulControls
{
    partial class SupplierListControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SupplierListControl));
            this.gcFilter = new DevExpress.XtraEditors.GroupControl();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.txtFilterSupplierName = new DevExpress.XtraEditors.TextEdit();
            this.lblFilterSupplierName = new DevExpress.XtraEditors.LabelControl();
            this.gridSupplier = new DevExpress.XtraGrid.GridControl();
            this.gvSupplier = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSupplierSupplier = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddressSupplier = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhoneSupplier = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnNewSupplier = new DevExpress.XtraEditors.SimpleButton();
            this.cmsEditor = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsEditData = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsDeleteData = new System.Windows.Forms.ToolStripMenuItem();
            this.bgwMain = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.gcFilter)).BeginInit();
            this.gcFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFilterSupplierName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSupplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSupplier)).BeginInit();
            this.cmsEditor.SuspendLayout();
            this.SuspendLayout();
            // 
            // gcFilter
            // 
            this.gcFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcFilter.Controls.Add(this.btnSearch);
            this.gcFilter.Controls.Add(this.txtFilterSupplierName);
            this.gcFilter.Controls.Add(this.lblFilterSupplierName);
            this.gcFilter.Location = new System.Drawing.Point(3, 3);
            this.gcFilter.Name = "gcFilter";
            this.gcFilter.Size = new System.Drawing.Size(575, 62);
            this.gcFilter.TabIndex = 0;
            this.gcFilter.Text = "Filter";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnSearch.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnSearch.Location = new System.Drawing.Point(508, 28);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(55, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "cari";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtFilterSupplierName
            // 
            this.txtFilterSupplierName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilterSupplierName.Location = new System.Drawing.Point(128, 30);
            this.txtFilterSupplierName.Name = "txtFilterSupplierName";
            this.txtFilterSupplierName.Size = new System.Drawing.Size(374, 20);
            this.txtFilterSupplierName.TabIndex = 1;
            this.txtFilterSupplierName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFilterSupplierName_KeyDown);
            // 
            // lblFilterSupplierName
            // 
            this.lblFilterSupplierName.Location = new System.Drawing.Point(12, 33);
            this.lblFilterSupplierName.Name = "lblFilterSupplierName";
            this.lblFilterSupplierName.Size = new System.Drawing.Size(68, 13);
            this.lblFilterSupplierName.TabIndex = 0;
            this.lblFilterSupplierName.Text = "Nama Supplier";
            // 
            // gridSupplier
            // 
            this.gridSupplier.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridSupplier.Location = new System.Drawing.Point(3, 100);
            this.gridSupplier.MainView = this.gvSupplier;
            this.gridSupplier.Name = "gridSupplier";
            this.gridSupplier.Size = new System.Drawing.Size(575, 224);
            this.gridSupplier.TabIndex = 1;
            this.gridSupplier.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSupplier});
            // 
            // gvSupplier
            // 
            this.gvSupplier.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSupplierSupplier,
            this.colAddressSupplier,
            this.colPhoneSupplier});
            this.gvSupplier.GridControl = this.gridSupplier;
            this.gvSupplier.Name = "gvSupplier";
            this.gvSupplier.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvSupplier.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvSupplier.OptionsBehavior.AutoPopulateColumns = false;
            this.gvSupplier.OptionsBehavior.Editable = false;
            this.gvSupplier.OptionsBehavior.ReadOnly = true;
            this.gvSupplier.OptionsCustomization.AllowColumnMoving = false;
            this.gvSupplier.OptionsCustomization.AllowFilter = false;
            this.gvSupplier.OptionsCustomization.AllowGroup = false;
            this.gvSupplier.OptionsCustomization.AllowQuickHideColumns = false;
            this.gvSupplier.OptionsView.ShowGroupPanel = false;
            this.gvSupplier.OptionsView.ShowViewCaption = true;
            this.gvSupplier.ViewCaption = "Daftar Supplier";
            // 
            // colSupplierSupplier
            // 
            this.colSupplierSupplier.Caption = "Nama Supplier";
            this.colSupplierSupplier.FieldName = "Name";
            this.colSupplierSupplier.Name = "colSupplierSupplier";
            this.colSupplierSupplier.Visible = true;
            this.colSupplierSupplier.VisibleIndex = 0;
            // 
            // colAddressSupplier
            // 
            this.colAddressSupplier.Caption = "Alamat";
            this.colAddressSupplier.FieldName = "Address";
            this.colAddressSupplier.Name = "colAddressSupplier";
            this.colAddressSupplier.Visible = true;
            this.colAddressSupplier.VisibleIndex = 1;
            // 
            // colPhoneSupplier
            // 
            this.colPhoneSupplier.Caption = "No. Telp.";
            this.colPhoneSupplier.FieldName = "PhoneNumber";
            this.colPhoneSupplier.Name = "colPhoneSupplier";
            this.colPhoneSupplier.Visible = true;
            this.colPhoneSupplier.VisibleIndex = 2;
            // 
            // btnNewSupplier
            // 
            this.btnNewSupplier.Image = ((System.Drawing.Image)(resources.GetObject("btnNewSupplier.Image")));
            this.btnNewSupplier.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnNewSupplier.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnNewSupplier.Location = new System.Drawing.Point(3, 71);
            this.btnNewSupplier.Name = "btnNewSupplier";
            this.btnNewSupplier.Size = new System.Drawing.Size(144, 23);
            this.btnNewSupplier.TabIndex = 2;
            this.btnNewSupplier.Text = "Buat Supplier Baru";
            this.btnNewSupplier.Click += new System.EventHandler(this.btnNewSupplier_Click);
            // 
            // cmsEditor
            // 
            this.cmsEditor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsEditData,
            this.cmsDeleteData});
            this.cmsEditor.Name = "cmsListEditor";
            this.cmsEditor.Size = new System.Drawing.Size(136, 48);
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
            // SupplierListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnNewSupplier);
            this.Controls.Add(this.gridSupplier);
            this.Controls.Add(this.gcFilter);
            this.Name = "SupplierListControl";
            this.Size = new System.Drawing.Size(581, 327);
            ((System.ComponentModel.ISupportInitialize)(this.gcFilter)).EndInit();
            this.gcFilter.ResumeLayout(false);
            this.gcFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFilterSupplierName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSupplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSupplier)).EndInit();
            this.cmsEditor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gcFilter;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.TextEdit txtFilterSupplierName;
        private DevExpress.XtraEditors.LabelControl lblFilterSupplierName;
        private DevExpress.XtraGrid.GridControl gridSupplier;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSupplier;
        private DevExpress.XtraEditors.SimpleButton btnNewSupplier;
        private DevExpress.XtraGrid.Columns.GridColumn colNameSupplier;
        private DevExpress.XtraGrid.Columns.GridColumn colAddressSupplier;
        private DevExpress.XtraGrid.Columns.GridColumn colPhoneSupplier;
        private System.Windows.Forms.ContextMenuStrip cmsEditor;
        private System.Windows.Forms.ToolStripMenuItem cmsEditData;
        private System.Windows.Forms.ToolStripMenuItem cmsDeleteData;
        private System.ComponentModel.BackgroundWorker bgwMain;
        private DevExpress.XtraGrid.Columns.GridColumn colSupplierSupplier;
    }
}