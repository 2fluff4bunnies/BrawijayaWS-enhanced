namespace BrawijayaWorkshop.Win32App.ModulForms
{
    partial class SPKWheelChange
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
            this.gridControlWheelSPK = new DevExpress.XtraEditors.GroupControl();
            this.gridVehicleWheel = new DevExpress.XtraGrid.GridControl();
            this.gvVehicleWheel = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWheelDetail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSparepart = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsUsedGoodReceived = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lookUpSparepartWheelGv = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gbDetailWheel = new System.Windows.Forms.GroupBox();
            this.btnAddSparepart = new DevExpress.XtraEditors.SimpleButton();
            this.ckeUsedGoodRetrieved = new DevExpress.XtraEditors.CheckEdit();
            this.txtPrice = new DevExpress.XtraEditors.TextEdit();
            this.lblPrice = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.lookUpSerial = new DevExpress.XtraEditors.LookUpEdit();
            this.lookUpSparepart = new DevExpress.XtraEditors.LookUpEdit();
            this.lblExchangedSparepart = new DevExpress.XtraEditors.LabelControl();
            this.lblExchangedSerial = new DevExpress.XtraEditors.LabelControl();
            this.txtAppliedSerial = new DevExpress.XtraEditors.TextEdit();
            this.lblAppliedSerial = new DevExpress.XtraEditors.LabelControl();
            this.txtAppliedWheel = new DevExpress.XtraEditors.TextEdit();
            this.lblAppliedWheel = new DevExpress.XtraEditors.LabelControl();
            this.colWheelDetailReplace = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmsVehicleWheel = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsVehicleWheelItemReset = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlWheelSPK)).BeginInit();
            this.gridControlWheelSPK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridVehicleWheel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvVehicleWheel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpSparepartWheelGv)).BeginInit();
            this.gbDetailWheel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ckeUsedGoodRetrieved.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpSerial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpSparepart.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAppliedSerial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAppliedWheel.Properties)).BeginInit();
            this.cmsVehicleWheel.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControlWheelSPK
            // 
            this.gridControlWheelSPK.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlWheelSPK.Controls.Add(this.gridVehicleWheel);
            this.gridControlWheelSPK.Controls.Add(this.gbDetailWheel);
            this.gridControlWheelSPK.Location = new System.Drawing.Point(1, 0);
            this.gridControlWheelSPK.Name = "gridControlWheelSPK";
            this.gridControlWheelSPK.Size = new System.Drawing.Size(1082, 460);
            this.gridControlWheelSPK.TabIndex = 0;
            this.gridControlWheelSPK.Text = "Ban Kendaraan";
            // 
            // gridVehicleWheel
            // 
            this.gridVehicleWheel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridVehicleWheel.Location = new System.Drawing.Point(0, 23);
            this.gridVehicleWheel.MainView = this.gvVehicleWheel;
            this.gridVehicleWheel.Name = "gridVehicleWheel";
            this.gridVehicleWheel.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.lookUpSparepartWheelGv});
            this.gridVehicleWheel.Size = new System.Drawing.Size(770, 423);
            this.gridVehicleWheel.TabIndex = 31;
            this.gridVehicleWheel.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvVehicleWheel});
            // 
            // gvVehicleWheel
            // 
            this.gvVehicleWheel.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName,
            this.colWheelDetail,
            this.colSparepart,
            this.gridColumn1,
            this.colIsUsedGoodReceived,
            this.colPrice});
            this.gvVehicleWheel.GridControl = this.gridVehicleWheel;
            this.gvVehicleWheel.Name = "gvVehicleWheel";
            this.gvVehicleWheel.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gvVehicleWheel.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.gvVehicleWheel.OptionsBehavior.AutoPopulateColumns = false;
            this.gvVehicleWheel.OptionsView.EnableAppearanceEvenRow = true;
            this.gvVehicleWheel.OptionsView.ShowGroupPanel = false;
            this.gvVehicleWheel.OptionsView.ShowViewCaption = true;
            this.gvVehicleWheel.ViewCaption = "Daftar Ban Kendaraan";
            // 
            // colName
            // 
            this.colName.Caption = "Jenis Ban (Terpasang)";
            this.colName.FieldName = "WheelDetail.SparepartDetail.Sparepart.Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            // 
            // colWheelDetail
            // 
            this.colWheelDetail.Caption = "Nomor Seri (Terpasang)";
            this.colWheelDetail.FieldName = "WheelDetail.SerialNumber";
            this.colWheelDetail.Name = "colWheelDetail";
            this.colWheelDetail.Visible = true;
            this.colWheelDetail.VisibleIndex = 1;
            // 
            // colSparepart
            // 
            this.colSparepart.Caption = "Jenis Ban (Ganti)";
            this.colSparepart.FieldName = "SparepartId";
            this.colSparepart.Name = "colSparepart";
            this.colSparepart.Visible = true;
            this.colSparepart.VisibleIndex = 2;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Nomor Seri (Ganti)";
            this.gridColumn1.FieldName = "ReplaceWithWheelDetailId";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 3;
            // 
            // colIsUsedGoodReceived
            // 
            this.colIsUsedGoodReceived.Caption = "Ban Bekas Diterima";
            this.colIsUsedGoodReceived.FieldName = "IsUsedWheelRetrieved";
            this.colIsUsedGoodReceived.Name = "colIsUsedGoodReceived";
            this.colIsUsedGoodReceived.Visible = true;
            this.colIsUsedGoodReceived.VisibleIndex = 4;
            // 
            // colPrice
            // 
            this.colPrice.Caption = "Harga";
            this.colPrice.DisplayFormat.FormatString = "#,#";
            this.colPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPrice.FieldName = "Price";
            this.colPrice.Name = "colPrice";
            this.colPrice.Visible = true;
            this.colPrice.VisibleIndex = 5;
            // 
            // lookUpSparepartWheelGv
            // 
            this.lookUpSparepartWheelGv.AutoHeight = false;
            this.lookUpSparepartWheelGv.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpSparepartWheelGv.DisplayMember = "Name";
            this.lookUpSparepartWheelGv.Name = "lookUpSparepartWheelGv";
            this.lookUpSparepartWheelGv.NullText = "-- Pilih Jenis Ban --";
            this.lookUpSparepartWheelGv.ValueMember = "Id";
            // 
            // gbDetailWheel
            // 
            this.gbDetailWheel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDetailWheel.Controls.Add(this.btnAddSparepart);
            this.gbDetailWheel.Controls.Add(this.ckeUsedGoodRetrieved);
            this.gbDetailWheel.Controls.Add(this.txtPrice);
            this.gbDetailWheel.Controls.Add(this.lblPrice);
            this.gbDetailWheel.Controls.Add(this.labelControl3);
            this.gbDetailWheel.Controls.Add(this.lookUpSerial);
            this.gbDetailWheel.Controls.Add(this.lookUpSparepart);
            this.gbDetailWheel.Controls.Add(this.lblExchangedSparepart);
            this.gbDetailWheel.Controls.Add(this.lblExchangedSerial);
            this.gbDetailWheel.Controls.Add(this.txtAppliedSerial);
            this.gbDetailWheel.Controls.Add(this.lblAppliedSerial);
            this.gbDetailWheel.Controls.Add(this.txtAppliedWheel);
            this.gbDetailWheel.Controls.Add(this.lblAppliedWheel);
            this.gbDetailWheel.Location = new System.Drawing.Point(776, 23);
            this.gbDetailWheel.Name = "gbDetailWheel";
            this.gbDetailWheel.Size = new System.Drawing.Size(304, 423);
            this.gbDetailWheel.TabIndex = 13;
            this.gbDetailWheel.TabStop = false;
            this.gbDetailWheel.Text = "Detail Ban";
            // 
            // btnAddSparepart
            // 
            this.btnAddSparepart.Image = global::BrawijayaWorkshop.Win32App.Properties.Resources.Apply_16x16;
            this.btnAddSparepart.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnAddSparepart.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnAddSparepart.Location = new System.Drawing.Point(201, 219);
            this.btnAddSparepart.Name = "btnAddSparepart";
            this.btnAddSparepart.Size = new System.Drawing.Size(97, 34);
            this.btnAddSparepart.TabIndex = 39;
            this.btnAddSparepart.Text = "Konfirmasi";
            // 
            // ckeUsedGoodRetrieved
            // 
            this.ckeUsedGoodRetrieved.Location = new System.Drawing.Point(8, 157);
            this.ckeUsedGoodRetrieved.Name = "ckeUsedGoodRetrieved";
            this.ckeUsedGoodRetrieved.Properties.Caption = "Ban Bekas Diterima";
            this.ckeUsedGoodRetrieved.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ckeUsedGoodRetrieved.Size = new System.Drawing.Size(116, 19);
            this.ckeUsedGoodRetrieved.TabIndex = 38;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(106, 183);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtPrice.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPrice.Properties.DisplayFormat.FormatString = "{0:#,#;(#,#);0}";
            this.txtPrice.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtPrice.Size = new System.Drawing.Size(192, 20);
            this.txtPrice.TabIndex = 36;
            // 
            // lblPrice
            // 
            this.lblPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrice.Location = new System.Drawing.Point(10, 186);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(29, 13);
            this.lblPrice.TabIndex = 37;
            this.lblPrice.Text = "Harga";
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl3.Location = new System.Drawing.Point(106, 78);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(132, 13);
            this.labelControl3.TabIndex = 35;
            this.labelControl3.Text = "---------- Ganti Ban ----------";
            // 
            // lookUpSerial
            // 
            this.lookUpSerial.Location = new System.Drawing.Point(106, 131);
            this.lookUpSerial.Name = "lookUpSerial";
            this.lookUpSerial.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.lookUpSerial.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.lookUpSerial.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpSerial.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Sparepart"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("StockQty", "Stok"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Kode")});
            this.lookUpSerial.Properties.DisplayMember = "Name";
            this.lookUpSerial.Properties.HideSelection = false;
            this.lookUpSerial.Properties.NullText = "-- Pilih Nomor Seri --";
            this.lookUpSerial.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lookUpSerial.Properties.ValueMember = "Id";
            this.lookUpSerial.Size = new System.Drawing.Size(192, 20);
            this.lookUpSerial.TabIndex = 34;
            // 
            // lookUpSparepart
            // 
            this.lookUpSparepart.Location = new System.Drawing.Point(106, 105);
            this.lookUpSparepart.Name = "lookUpSparepart";
            this.lookUpSparepart.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.lookUpSparepart.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.lookUpSparepart.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpSparepart.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Sparepart"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("StockQty", "Stok"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Kode")});
            this.lookUpSparepart.Properties.DisplayMember = "Name";
            this.lookUpSparepart.Properties.HideSelection = false;
            this.lookUpSparepart.Properties.NullText = "-- PIlih Jenis Ban --";
            this.lookUpSparepart.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lookUpSparepart.Properties.ValueMember = "Id";
            this.lookUpSparepart.Size = new System.Drawing.Size(192, 20);
            this.lookUpSparepart.TabIndex = 31;
            // 
            // lblExchangedSparepart
            // 
            this.lblExchangedSparepart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblExchangedSparepart.Location = new System.Drawing.Point(10, 108);
            this.lblExchangedSparepart.Name = "lblExchangedSparepart";
            this.lblExchangedSparepart.Size = new System.Drawing.Size(45, 13);
            this.lblExchangedSparepart.TabIndex = 29;
            this.lblExchangedSparepart.Text = "Jenis Ban";
            // 
            // lblExchangedSerial
            // 
            this.lblExchangedSerial.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblExchangedSerial.Location = new System.Drawing.Point(10, 134);
            this.lblExchangedSerial.Name = "lblExchangedSerial";
            this.lblExchangedSerial.Size = new System.Drawing.Size(52, 13);
            this.lblExchangedSerial.TabIndex = 24;
            this.lblExchangedSerial.Text = "Nomor Seri";
            // 
            // txtAppliedSerial
            // 
            this.txtAppliedSerial.Enabled = false;
            this.txtAppliedSerial.Location = new System.Drawing.Point(106, 46);
            this.txtAppliedSerial.Name = "txtAppliedSerial";
            this.txtAppliedSerial.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtAppliedSerial.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAppliedSerial.Properties.DisplayFormat.FormatString = "{0:#,#;(#,#);0}";
            this.txtAppliedSerial.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtAppliedSerial.Size = new System.Drawing.Size(192, 20);
            this.txtAppliedSerial.TabIndex = 21;
            // 
            // lblAppliedSerial
            // 
            this.lblAppliedSerial.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAppliedSerial.Location = new System.Drawing.Point(10, 49);
            this.lblAppliedSerial.Name = "lblAppliedSerial";
            this.lblAppliedSerial.Size = new System.Drawing.Size(52, 13);
            this.lblAppliedSerial.TabIndex = 22;
            this.lblAppliedSerial.Text = "Nomor Seri";
            // 
            // txtAppliedWheel
            // 
            this.txtAppliedWheel.Enabled = false;
            this.txtAppliedWheel.Location = new System.Drawing.Point(106, 20);
            this.txtAppliedWheel.Name = "txtAppliedWheel";
            this.txtAppliedWheel.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtAppliedWheel.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAppliedWheel.Properties.DisplayFormat.FormatString = "{0:#,#;(#,#);0}";
            this.txtAppliedWheel.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtAppliedWheel.Size = new System.Drawing.Size(192, 20);
            this.txtAppliedWheel.TabIndex = 19;
            // 
            // lblAppliedWheel
            // 
            this.lblAppliedWheel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAppliedWheel.Location = new System.Drawing.Point(10, 23);
            this.lblAppliedWheel.Name = "lblAppliedWheel";
            this.lblAppliedWheel.Size = new System.Drawing.Size(72, 13);
            this.lblAppliedWheel.TabIndex = 20;
            this.lblAppliedWheel.Text = "Ban Terpasang";
            // 
            // colWheelDetailReplace
            // 
            this.colWheelDetailReplace.Caption = "Nomor Seri (Ganti)";
            this.colWheelDetailReplace.FieldName = "ReplaceWithWheelDetailId";
            this.colWheelDetailReplace.Name = "colWheelDetailReplace";
            // 
            // cmsVehicleWheel
            // 
            this.cmsVehicleWheel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsVehicleWheelItemReset});
            this.cmsVehicleWheel.Name = "cmsListEditor";
            this.cmsVehicleWheel.Size = new System.Drawing.Size(174, 48);
            // 
            // cmsVehicleWheelItemReset
            // 
            this.cmsVehicleWheelItemReset.Image = global::BrawijayaWorkshop.Win32App.Properties.Resources._1459465829_refresh;
            this.cmsVehicleWheelItemReset.Name = "cmsVehicleWheelItemReset";
            this.cmsVehicleWheelItemReset.Size = new System.Drawing.Size(173, 22);
            this.cmsVehicleWheelItemReset.Text = "Batalkan Ganti Ban";
            this.cmsVehicleWheelItemReset.Click += new System.EventHandler(this.cmsVehicleWheelItemReset_Click);
            // 
            // SPKWheelChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 501);
            this.Controls.Add(this.gridControlWheelSPK);
            this.Name = "SPKWheelChange";
            this.Text = "SPK Ban Kendaran";
            this.Controls.SetChildIndex(this.gridControlWheelSPK, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlWheelSPK)).EndInit();
            this.gridControlWheelSPK.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridVehicleWheel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvVehicleWheel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpSparepartWheelGv)).EndInit();
            this.gbDetailWheel.ResumeLayout(false);
            this.gbDetailWheel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ckeUsedGoodRetrieved.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpSerial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpSparepart.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAppliedSerial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAppliedWheel.Properties)).EndInit();
            this.cmsVehicleWheel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gridControlWheelSPK;
        private System.Windows.Forms.GroupBox gbDetailWheel;
        private DevExpress.XtraGrid.Columns.GridColumn colWheelDetailReplace;
        private DevExpress.XtraEditors.LabelControl lblExchangedSparepart;
        private DevExpress.XtraEditors.LabelControl lblExchangedSerial;
        private DevExpress.XtraEditors.TextEdit txtAppliedSerial;
        private DevExpress.XtraEditors.LabelControl lblAppliedSerial;
        private DevExpress.XtraEditors.TextEdit txtAppliedWheel;
        private DevExpress.XtraEditors.LabelControl lblAppliedWheel;
        private DevExpress.XtraGrid.GridControl gridVehicleWheel;
        private DevExpress.XtraGrid.Views.Grid.GridView gvVehicleWheel;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colWheelDetail;
        private DevExpress.XtraGrid.Columns.GridColumn colSparepart;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn colIsUsedGoodReceived;
        private DevExpress.XtraGrid.Columns.GridColumn colPrice;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lookUpSparepartWheelGv;
        private DevExpress.XtraEditors.LookUpEdit lookUpSparepart;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LookUpEdit lookUpSerial;
        private DevExpress.XtraEditors.TextEdit txtPrice;
        private DevExpress.XtraEditors.LabelControl lblPrice;
        private DevExpress.XtraEditors.CheckEdit ckeUsedGoodRetrieved;
        private DevExpress.XtraEditors.SimpleButton btnAddSparepart;
        private System.Windows.Forms.ContextMenuStrip cmsVehicleWheel;
        private System.Windows.Forms.ToolStripMenuItem cmsVehicleWheelItemReset;
    }
}