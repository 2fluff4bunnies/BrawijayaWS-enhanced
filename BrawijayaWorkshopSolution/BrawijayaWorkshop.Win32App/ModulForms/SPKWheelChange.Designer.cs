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
            this.gbChangeWheel = new System.Windows.Forms.GroupBox();
            this.lookUpChangedSerialNumber = new DevExpress.XtraEditors.LookUpEdit();
            this.btnCancelChange = new DevExpress.XtraEditors.SimpleButton();
            this.txtChangedCode = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnConfirmChange = new DevExpress.XtraEditors.SimpleButton();
            this.ckeUsedGoodRetrieved = new DevExpress.XtraEditors.CheckEdit();
            this.txtPrice = new DevExpress.XtraEditors.TextEdit();
            this.lblPrice = new DevExpress.XtraEditors.LabelControl();
            this.lookUpChangedWheel = new DevExpress.XtraEditors.LookUpEdit();
            this.lblExchangedSparepart = new DevExpress.XtraEditors.LabelControl();
            this.lblExchangedSerial = new DevExpress.XtraEditors.LabelControl();
            this.gridVehicleWheel = new DevExpress.XtraGrid.GridControl();
            this.gvVehicleWheel = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWheelDetail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSparepart = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWheelDetailChanged = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsUsedGoodReceived = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lookUpSparepartWheelGv = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gbDetailWheel = new System.Windows.Forms.GroupBox();
            this.txtSelectedWheelCode = new DevExpress.XtraEditors.TextEdit();
            this.lblCode = new DevExpress.XtraEditors.LabelControl();
            this.txtSelectedWheelSerial = new DevExpress.XtraEditors.TextEdit();
            this.lblAppliedSerial = new DevExpress.XtraEditors.LabelControl();
            this.txtSelectedWheelName = new DevExpress.XtraEditors.TextEdit();
            this.lblAppliedWheel = new DevExpress.XtraEditors.LabelControl();
            this.colWheelDetailReplace = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmsVehicleWheel = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsVehicleWheelItemReset = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlWheelSPK)).BeginInit();
            this.gridControlWheelSPK.SuspendLayout();
            this.gbChangeWheel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpChangedSerialNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChangedCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckeUsedGoodRetrieved.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpChangedWheel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridVehicleWheel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvVehicleWheel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpSparepartWheelGv)).BeginInit();
            this.gbDetailWheel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSelectedWheelCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSelectedWheelSerial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSelectedWheelName.Properties)).BeginInit();
            this.cmsVehicleWheel.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControlWheelSPK
            // 
            this.gridControlWheelSPK.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlWheelSPK.Controls.Add(this.gbChangeWheel);
            this.gridControlWheelSPK.Controls.Add(this.gridVehicleWheel);
            this.gridControlWheelSPK.Controls.Add(this.gbDetailWheel);
            this.gridControlWheelSPK.Location = new System.Drawing.Point(1, 0);
            this.gridControlWheelSPK.Name = "gridControlWheelSPK";
            this.gridControlWheelSPK.Size = new System.Drawing.Size(1082, 402);
            this.gridControlWheelSPK.TabIndex = 0;
            this.gridControlWheelSPK.Text = "Ban Kendaraan";
            // 
            // gbChangeWheel
            // 
            this.gbChangeWheel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbChangeWheel.Controls.Add(this.lookUpChangedSerialNumber);
            this.gbChangeWheel.Controls.Add(this.btnCancelChange);
            this.gbChangeWheel.Controls.Add(this.txtChangedCode);
            this.gbChangeWheel.Controls.Add(this.labelControl1);
            this.gbChangeWheel.Controls.Add(this.btnConfirmChange);
            this.gbChangeWheel.Controls.Add(this.ckeUsedGoodRetrieved);
            this.gbChangeWheel.Controls.Add(this.txtPrice);
            this.gbChangeWheel.Controls.Add(this.lblPrice);
            this.gbChangeWheel.Controls.Add(this.lookUpChangedWheel);
            this.gbChangeWheel.Controls.Add(this.lblExchangedSparepart);
            this.gbChangeWheel.Controls.Add(this.lblExchangedSerial);
            this.gbChangeWheel.Location = new System.Drawing.Point(776, 134);
            this.gbChangeWheel.Name = "gbChangeWheel";
            this.gbChangeWheel.Size = new System.Drawing.Size(301, 189);
            this.gbChangeWheel.TabIndex = 32;
            this.gbChangeWheel.TabStop = false;
            this.gbChangeWheel.Text = "Ban Pengganti";
            // 
            // lookUpChangedSerialNumber
            // 
            this.lookUpChangedSerialNumber.Location = new System.Drawing.Point(103, 46);
            this.lookUpChangedSerialNumber.Name = "lookUpChangedSerialNumber";
            this.lookUpChangedSerialNumber.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.lookUpChangedSerialNumber.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.lookUpChangedSerialNumber.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpChangedSerialNumber.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SerialNumber", "Nomor Seri")});
            this.lookUpChangedSerialNumber.Properties.DisplayMember = "SerialNumber";
            this.lookUpChangedSerialNumber.Properties.HideSelection = false;
            this.lookUpChangedSerialNumber.Properties.NullText = "-- Pilih Nomor Seri --";
            this.lookUpChangedSerialNumber.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lookUpChangedSerialNumber.Properties.ValueMember = "Id";
            this.lookUpChangedSerialNumber.Size = new System.Drawing.Size(192, 20);
            this.lookUpChangedSerialNumber.TabIndex = 57;
            this.lookUpChangedSerialNumber.EditValueChanged += new System.EventHandler(this.lookUpChangedSerialNumber_EditValueChanged);
            this.lookUpChangedSerialNumber.Enter += new System.EventHandler(this.lookUpChangedSerialNumber_Enter);
            // 
            // btnCancelChange
            // 
            this.btnCancelChange.Image = global::BrawijayaWorkshop.Win32App.Properties.Resources.delete_icon;
            this.btnCancelChange.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnCancelChange.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnCancelChange.Location = new System.Drawing.Point(101, 158);
            this.btnCancelChange.Name = "btnCancelChange";
            this.btnCancelChange.Size = new System.Drawing.Size(94, 25);
            this.btnCancelChange.TabIndex = 56;
            this.btnCancelChange.Text = "Batalkan";
            this.btnCancelChange.Click += new System.EventHandler(this.btnCancelChange_Click);
            // 
            // txtChangedCode
            // 
            this.txtChangedCode.Enabled = false;
            this.txtChangedCode.Location = new System.Drawing.Point(103, 72);
            this.txtChangedCode.Name = "txtChangedCode";
            this.txtChangedCode.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtChangedCode.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtChangedCode.Properties.DisplayFormat.FormatString = "{0:#,#;(#,#);0}";
            this.txtChangedCode.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtChangedCode.Size = new System.Drawing.Size(192, 20);
            this.txtChangedCode.TabIndex = 27;
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Location = new System.Drawing.Point(7, 75);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(75, 13);
            this.labelControl1.TabIndex = 28;
            this.labelControl1.Text = "Kode Sparepart";
            // 
            // btnConfirmChange
            // 
            this.btnConfirmChange.Image = global::BrawijayaWorkshop.Win32App.Properties.Resources.Apply_16x16;
            this.btnConfirmChange.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnConfirmChange.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnConfirmChange.Location = new System.Drawing.Point(201, 158);
            this.btnConfirmChange.Name = "btnConfirmChange";
            this.btnConfirmChange.Size = new System.Drawing.Size(94, 25);
            this.btnConfirmChange.TabIndex = 55;
            this.btnConfirmChange.Text = "Konfirmasi";
            this.btnConfirmChange.Click += new System.EventHandler(this.btnConfirmChange_Click);
            // 
            // ckeUsedGoodRetrieved
            // 
            this.ckeUsedGoodRetrieved.Location = new System.Drawing.Point(5, 98);
            this.ckeUsedGoodRetrieved.Name = "ckeUsedGoodRetrieved";
            this.ckeUsedGoodRetrieved.Properties.Caption = "Ban Bekas Diterima";
            this.ckeUsedGoodRetrieved.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ckeUsedGoodRetrieved.Size = new System.Drawing.Size(116, 19);
            this.ckeUsedGoodRetrieved.TabIndex = 54;
            // 
            // txtPrice
            // 
            this.txtPrice.Enabled = false;
            this.txtPrice.Location = new System.Drawing.Point(103, 124);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtPrice.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPrice.Properties.DisplayFormat.FormatString = "{0:#,#;(#,#);0}";
            this.txtPrice.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtPrice.Size = new System.Drawing.Size(192, 20);
            this.txtPrice.TabIndex = 52;
            // 
            // lblPrice
            // 
            this.lblPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrice.Location = new System.Drawing.Point(7, 127);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(29, 13);
            this.lblPrice.TabIndex = 53;
            this.lblPrice.Text = "Harga";
            // 
            // lookUpChangedWheel
            // 
            this.lookUpChangedWheel.Location = new System.Drawing.Point(103, 20);
            this.lookUpChangedWheel.Name = "lookUpChangedWheel";
            this.lookUpChangedWheel.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.lookUpChangedWheel.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.lookUpChangedWheel.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpChangedWheel.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Ban")});
            this.lookUpChangedWheel.Properties.DisplayMember = "Name";
            this.lookUpChangedWheel.Properties.HideSelection = false;
            this.lookUpChangedWheel.Properties.NullText = "-- PIlih Jenis Ban --";
            this.lookUpChangedWheel.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lookUpChangedWheel.Properties.ValueMember = "Id";
            this.lookUpChangedWheel.Size = new System.Drawing.Size(192, 20);
            this.lookUpChangedWheel.TabIndex = 50;
            this.lookUpChangedWheel.EditValueChanged += new System.EventHandler(this.lookUpChangedWheel_EditValueChanged);
            this.lookUpChangedWheel.Enter += new System.EventHandler(this.lookUpChangedWheel_Enter);
            // 
            // lblExchangedSparepart
            // 
            this.lblExchangedSparepart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblExchangedSparepart.Location = new System.Drawing.Point(7, 23);
            this.lblExchangedSparepart.Name = "lblExchangedSparepart";
            this.lblExchangedSparepart.Size = new System.Drawing.Size(45, 13);
            this.lblExchangedSparepart.TabIndex = 49;
            this.lblExchangedSparepart.Text = "Jenis Ban";
            // 
            // lblExchangedSerial
            // 
            this.lblExchangedSerial.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblExchangedSerial.Location = new System.Drawing.Point(7, 49);
            this.lblExchangedSerial.Name = "lblExchangedSerial";
            this.lblExchangedSerial.Size = new System.Drawing.Size(52, 13);
            this.lblExchangedSerial.TabIndex = 48;
            this.lblExchangedSerial.Text = "Nomor Seri";
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
            this.gridVehicleWheel.Size = new System.Drawing.Size(770, 365);
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
            this.colWheelDetailChanged,
            this.colIsUsedGoodReceived,
            this.colPrice});
            this.gvVehicleWheel.GridControl = this.gridVehicleWheel;
            this.gvVehicleWheel.Name = "gvVehicleWheel";
            this.gvVehicleWheel.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gvVehicleWheel.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.gvVehicleWheel.OptionsBehavior.AutoPopulateColumns = false;
            this.gvVehicleWheel.OptionsBehavior.Editable = false;
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
            this.colSparepart.Caption = "Jenis Ban (Pengganti)";
            this.colSparepart.FieldName = "ReplaceWithWheelDetailName";
            this.colSparepart.Name = "colSparepart";
            this.colSparepart.Visible = true;
            this.colSparepart.VisibleIndex = 2;
            // 
            // colWheelDetailChanged
            // 
            this.colWheelDetailChanged.Caption = "Nomor Seri (Pengganti)";
            this.colWheelDetailChanged.FieldName = "ReplaceWithWheelDetailSerialNumber";
            this.colWheelDetailChanged.Name = "colWheelDetailChanged";
            this.colWheelDetailChanged.Visible = true;
            this.colWheelDetailChanged.VisibleIndex = 3;
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
            this.gbDetailWheel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDetailWheel.Controls.Add(this.txtSelectedWheelCode);
            this.gbDetailWheel.Controls.Add(this.lblCode);
            this.gbDetailWheel.Controls.Add(this.txtSelectedWheelSerial);
            this.gbDetailWheel.Controls.Add(this.lblAppliedSerial);
            this.gbDetailWheel.Controls.Add(this.txtSelectedWheelName);
            this.gbDetailWheel.Controls.Add(this.lblAppliedWheel);
            this.gbDetailWheel.Location = new System.Drawing.Point(776, 23);
            this.gbDetailWheel.Name = "gbDetailWheel";
            this.gbDetailWheel.Size = new System.Drawing.Size(301, 105);
            this.gbDetailWheel.TabIndex = 13;
            this.gbDetailWheel.TabStop = false;
            this.gbDetailWheel.Text = "Ban Terpasang";
            // 
            // txtSelectedWheelCode
            // 
            this.txtSelectedWheelCode.Enabled = false;
            this.txtSelectedWheelCode.Location = new System.Drawing.Point(106, 72);
            this.txtSelectedWheelCode.Name = "txtSelectedWheelCode";
            this.txtSelectedWheelCode.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtSelectedWheelCode.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSelectedWheelCode.Properties.DisplayFormat.FormatString = "{0:#,#;(#,#);0}";
            this.txtSelectedWheelCode.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtSelectedWheelCode.Size = new System.Drawing.Size(189, 20);
            this.txtSelectedWheelCode.TabIndex = 23;
            // 
            // lblCode
            // 
            this.lblCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCode.Location = new System.Drawing.Point(10, 75);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(75, 13);
            this.lblCode.TabIndex = 24;
            this.lblCode.Text = "Kode Sparepart";
            // 
            // txtSelectedWheelSerial
            // 
            this.txtSelectedWheelSerial.Enabled = false;
            this.txtSelectedWheelSerial.Location = new System.Drawing.Point(106, 46);
            this.txtSelectedWheelSerial.Name = "txtSelectedWheelSerial";
            this.txtSelectedWheelSerial.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtSelectedWheelSerial.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSelectedWheelSerial.Properties.DisplayFormat.FormatString = "{0:#,#;(#,#);0}";
            this.txtSelectedWheelSerial.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtSelectedWheelSerial.Size = new System.Drawing.Size(189, 20);
            this.txtSelectedWheelSerial.TabIndex = 21;
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
            // txtSelectedWheelName
            // 
            this.txtSelectedWheelName.Enabled = false;
            this.txtSelectedWheelName.Location = new System.Drawing.Point(106, 20);
            this.txtSelectedWheelName.Name = "txtSelectedWheelName";
            this.txtSelectedWheelName.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtSelectedWheelName.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSelectedWheelName.Properties.DisplayFormat.FormatString = "{0:#,#;(#,#);0}";
            this.txtSelectedWheelName.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtSelectedWheelName.Size = new System.Drawing.Size(189, 20);
            this.txtSelectedWheelName.TabIndex = 19;
            // 
            // lblAppliedWheel
            // 
            this.lblAppliedWheel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAppliedWheel.Location = new System.Drawing.Point(10, 23);
            this.lblAppliedWheel.Name = "lblAppliedWheel";
            this.lblAppliedWheel.Size = new System.Drawing.Size(45, 13);
            this.lblAppliedWheel.TabIndex = 20;
            this.lblAppliedWheel.Text = "Jenis Ban";
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
            this.cmsVehicleWheel.Size = new System.Drawing.Size(174, 26);
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
            this.ClientSize = new System.Drawing.Size(1081, 443);
            this.Controls.Add(this.gridControlWheelSPK);
            this.Name = "SPKWheelChange";
            this.Text = "SPK Ban Kendaran";
            this.Controls.SetChildIndex(this.gridControlWheelSPK, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlWheelSPK)).EndInit();
            this.gridControlWheelSPK.ResumeLayout(false);
            this.gbChangeWheel.ResumeLayout(false);
            this.gbChangeWheel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpChangedSerialNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChangedCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckeUsedGoodRetrieved.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpChangedWheel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridVehicleWheel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvVehicleWheel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpSparepartWheelGv)).EndInit();
            this.gbDetailWheel.ResumeLayout(false);
            this.gbDetailWheel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSelectedWheelCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSelectedWheelSerial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSelectedWheelName.Properties)).EndInit();
            this.cmsVehicleWheel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gridControlWheelSPK;
        private System.Windows.Forms.GroupBox gbDetailWheel;
        private DevExpress.XtraGrid.Columns.GridColumn colWheelDetailReplace;
        private DevExpress.XtraEditors.TextEdit txtSelectedWheelSerial;
        private DevExpress.XtraEditors.LabelControl lblAppliedSerial;
        private DevExpress.XtraEditors.TextEdit txtSelectedWheelName;
        private DevExpress.XtraEditors.LabelControl lblAppliedWheel;
        private DevExpress.XtraGrid.GridControl gridVehicleWheel;
        private DevExpress.XtraGrid.Views.Grid.GridView gvVehicleWheel;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colWheelDetail;
        private DevExpress.XtraGrid.Columns.GridColumn colSparepart;
        private DevExpress.XtraGrid.Columns.GridColumn colWheelDetailChanged;
        private DevExpress.XtraGrid.Columns.GridColumn colIsUsedGoodReceived;
        private DevExpress.XtraGrid.Columns.GridColumn colPrice;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lookUpSparepartWheelGv;
        private System.Windows.Forms.ContextMenuStrip cmsVehicleWheel;
        private System.Windows.Forms.ToolStripMenuItem cmsVehicleWheelItemReset;
        private System.Windows.Forms.GroupBox gbChangeWheel;
        private DevExpress.XtraEditors.TextEdit txtChangedCode;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnConfirmChange;
        private DevExpress.XtraEditors.CheckEdit ckeUsedGoodRetrieved;
        private DevExpress.XtraEditors.TextEdit txtPrice;
        private DevExpress.XtraEditors.LabelControl lblPrice;
        private DevExpress.XtraEditors.LookUpEdit lookUpChangedWheel;
        private DevExpress.XtraEditors.LabelControl lblExchangedSparepart;
        private DevExpress.XtraEditors.LabelControl lblExchangedSerial;
        private DevExpress.XtraEditors.TextEdit txtSelectedWheelCode;
        private DevExpress.XtraEditors.LabelControl lblCode;
        private DevExpress.XtraEditors.SimpleButton btnCancelChange;
        private DevExpress.XtraEditors.LookUpEdit lookUpChangedSerialNumber;
    }
}