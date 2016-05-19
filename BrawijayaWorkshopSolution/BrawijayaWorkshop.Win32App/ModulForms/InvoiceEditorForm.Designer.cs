namespace BrawijayaWorkshop.Win32App.ModulForms
{
    partial class InvoiceEditorForm
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
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoiceEditorForm));
            this.gcInvoiceInfo = new DevExpress.XtraEditors.GroupControl();
            this.deTransDate = new DevExpress.XtraEditors.DateEdit();
            this.txtFeeSparepart = new DevExpress.XtraEditors.TextEdit();
            this.lblFeeSparepart = new DevExpress.XtraEditors.LabelControl();
            this.txtValueAdded = new DevExpress.XtraEditors.TextEdit();
            this.lblValueAdded = new DevExpress.XtraEditors.LabelControl();
            this.txtFeeService = new DevExpress.XtraEditors.TextEdit();
            this.lblServiceFee = new DevExpress.XtraEditors.LabelControl();
            this.chkApplyToAll = new DevExpress.XtraEditors.CheckEdit();
            this.txtMasterFee = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.gridSparepart = new DevExpress.XtraGrid.GridControl();
            this.gvSparepart = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSparepartDetail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSparepartName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPurchasePrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFeePctg = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFinalSubTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtTotalSparepart = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtTotalSparepartPlusFee = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtTotalService = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtTotalServicePlusFee = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cbPaymentType = new DevExpress.XtraEditors.LookUpEdit();
            this.lblPaymentType = new DevExpress.XtraEditors.LabelControl();
            this.txtTotalPayment = new DevExpress.XtraEditors.TextEdit();
            this.lblTotalPayment = new DevExpress.XtraEditors.LabelControl();
            this.txtTotalTransaction = new DevExpress.XtraEditors.TextEdit();
            this.lblTotalTransaction = new DevExpress.XtraEditors.LabelControl();
            this.txtCustomer = new DevExpress.XtraEditors.TextEdit();
            this.lblCustomer = new DevExpress.XtraEditors.LabelControl();
            this.lblTransactionDate = new DevExpress.XtraEditors.LabelControl();
            this.bsSparepart = new System.Windows.Forms.BindingSource(this.components);
            this.valPaymentMethod = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.bgwSave = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.gcInvoiceInfo)).BeginInit();
            this.gcInvoiceInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deTransDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deTransDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFeeSparepart.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValueAdded.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFeeService.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkApplyToAll.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMasterFee.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSparepart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSparepart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalSparepart.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalSparepartPlusFee.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalService.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalServicePlusFee.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbPaymentType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalPayment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalTransaction.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSparepart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valPaymentMethod)).BeginInit();
            this.SuspendLayout();
            // 
            // gcInvoiceInfo
            // 
            this.gcInvoiceInfo.Controls.Add(this.deTransDate);
            this.gcInvoiceInfo.Controls.Add(this.txtFeeSparepart);
            this.gcInvoiceInfo.Controls.Add(this.lblFeeSparepart);
            this.gcInvoiceInfo.Controls.Add(this.txtValueAdded);
            this.gcInvoiceInfo.Controls.Add(this.lblValueAdded);
            this.gcInvoiceInfo.Controls.Add(this.txtFeeService);
            this.gcInvoiceInfo.Controls.Add(this.lblServiceFee);
            this.gcInvoiceInfo.Controls.Add(this.chkApplyToAll);
            this.gcInvoiceInfo.Controls.Add(this.txtMasterFee);
            this.gcInvoiceInfo.Controls.Add(this.labelControl5);
            this.gcInvoiceInfo.Controls.Add(this.gridSparepart);
            this.gcInvoiceInfo.Controls.Add(this.txtTotalSparepart);
            this.gcInvoiceInfo.Controls.Add(this.labelControl4);
            this.gcInvoiceInfo.Controls.Add(this.txtTotalSparepartPlusFee);
            this.gcInvoiceInfo.Controls.Add(this.labelControl3);
            this.gcInvoiceInfo.Controls.Add(this.txtTotalService);
            this.gcInvoiceInfo.Controls.Add(this.labelControl2);
            this.gcInvoiceInfo.Controls.Add(this.txtTotalServicePlusFee);
            this.gcInvoiceInfo.Controls.Add(this.labelControl1);
            this.gcInvoiceInfo.Controls.Add(this.cbPaymentType);
            this.gcInvoiceInfo.Controls.Add(this.lblPaymentType);
            this.gcInvoiceInfo.Controls.Add(this.txtTotalPayment);
            this.gcInvoiceInfo.Controls.Add(this.lblTotalPayment);
            this.gcInvoiceInfo.Controls.Add(this.txtTotalTransaction);
            this.gcInvoiceInfo.Controls.Add(this.lblTotalTransaction);
            this.gcInvoiceInfo.Controls.Add(this.txtCustomer);
            this.gcInvoiceInfo.Controls.Add(this.lblCustomer);
            this.gcInvoiceInfo.Controls.Add(this.lblTransactionDate);
            this.gcInvoiceInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcInvoiceInfo.Location = new System.Drawing.Point(0, 0);
            this.gcInvoiceInfo.Name = "gcInvoiceInfo";
            this.gcInvoiceInfo.Size = new System.Drawing.Size(755, 597);
            this.gcInvoiceInfo.TabIndex = 1;
            this.gcInvoiceInfo.Text = "Informasi Invoice";
            // 
            // deTransDate
            // 
            this.deTransDate.EditValue = null;
            this.deTransDate.Location = new System.Drawing.Point(172, 30);
            this.deTransDate.Name = "deTransDate";
            this.deTransDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deTransDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deTransDate.Properties.DisplayFormat.FormatString = "dd-MM-yyyy";
            this.deTransDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.deTransDate.Properties.HideSelection = false;
            this.deTransDate.Properties.Mask.EditMask = "dd-MM-yyyy";
            this.deTransDate.Properties.ReadOnly = true;
            this.deTransDate.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.deTransDate.Size = new System.Drawing.Size(171, 20);
            this.deTransDate.TabIndex = 38;
            // 
            // txtFeeSparepart
            // 
            this.txtFeeSparepart.Location = new System.Drawing.Point(219, 316);
            this.txtFeeSparepart.Name = "txtFeeSparepart";
            this.txtFeeSparepart.Properties.DisplayFormat.FormatString = "{0:#,#;(#,#);0}";
            this.txtFeeSparepart.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtFeeSparepart.Properties.ReadOnly = true;
            this.txtFeeSparepart.Size = new System.Drawing.Size(158, 20);
            this.txtFeeSparepart.TabIndex = 37;
            // 
            // lblFeeSparepart
            // 
            this.lblFeeSparepart.Location = new System.Drawing.Point(17, 319);
            this.lblFeeSparepart.Name = "lblFeeSparepart";
            this.lblFeeSparepart.Size = new System.Drawing.Size(96, 13);
            this.lblFeeSparepart.TabIndex = 36;
            this.lblFeeSparepart.Text = "Total Fee Sparepart";
            // 
            // txtValueAdded
            // 
            this.txtValueAdded.Location = new System.Drawing.Point(219, 473);
            this.txtValueAdded.Name = "txtValueAdded";
            this.txtValueAdded.Properties.DisplayFormat.FormatString = "{0:#,#;(#,#);0}";
            this.txtValueAdded.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtValueAdded.Properties.ReadOnly = true;
            this.txtValueAdded.Size = new System.Drawing.Size(158, 20);
            this.txtValueAdded.TabIndex = 35;
            // 
            // lblValueAdded
            // 
            this.lblValueAdded.Location = new System.Drawing.Point(17, 476);
            this.lblValueAdded.Name = "lblValueAdded";
            this.lblValueAdded.Size = new System.Drawing.Size(147, 13);
            this.lblValueAdded.TabIndex = 34;
            this.lblValueAdded.Text = "Total Pertambahan Nilai (10%)";
            // 
            // txtFeeService
            // 
            this.txtFeeService.Location = new System.Drawing.Point(219, 410);
            this.txtFeeService.Name = "txtFeeService";
            this.txtFeeService.Properties.DisplayFormat.FormatString = "{0:#,#;(#,#);0}";
            this.txtFeeService.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtFeeService.Properties.ReadOnly = true;
            this.txtFeeService.Size = new System.Drawing.Size(158, 20);
            this.txtFeeService.TabIndex = 33;
            // 
            // lblServiceFee
            // 
            this.lblServiceFee.Location = new System.Drawing.Point(17, 413);
            this.lblServiceFee.Name = "lblServiceFee";
            this.lblServiceFee.Size = new System.Drawing.Size(83, 13);
            this.lblServiceFee.TabIndex = 32;
            this.lblServiceFee.Text = "Total Fee Service";
            // 
            // chkApplyToAll
            // 
            this.chkApplyToAll.Location = new System.Drawing.Point(248, 100);
            this.chkApplyToAll.Name = "chkApplyToAll";
            this.chkApplyToAll.Properties.Caption = "Diaplikasikan ke semua item?";
            this.chkApplyToAll.Size = new System.Drawing.Size(169, 19);
            this.chkApplyToAll.TabIndex = 31;
            this.chkApplyToAll.EditValueChanged += new System.EventHandler(this.chkApplyToAll_EditValueChanged);
            // 
            // txtMasterFee
            // 
            this.txtMasterFee.Location = new System.Drawing.Point(172, 100);
            this.txtMasterFee.Name = "txtMasterFee";
            this.txtMasterFee.Properties.DisplayFormat.FormatString = "{0:#,#;(#,#);0}";
            this.txtMasterFee.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtMasterFee.Size = new System.Drawing.Size(61, 20);
            this.txtMasterFee.TabIndex = 30;
            this.txtMasterFee.EditValueChanged += new System.EventHandler(this.txtMasterFee_EditValueChanged);
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(14, 103);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(152, 13);
            this.labelControl5.TabIndex = 29;
            this.labelControl5.Text = "Tambahan Biaya Sparepart (%)";
            // 
            // gridSparepart
            // 
            this.gridSparepart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridSparepart.Location = new System.Drawing.Point(12, 135);
            this.gridSparepart.MainView = this.gvSparepart;
            this.gridSparepart.Name = "gridSparepart";
            this.gridSparepart.Size = new System.Drawing.Size(734, 146);
            this.gridSparepart.TabIndex = 28;
            this.gridSparepart.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSparepart,
            this.gridView1});
            // 
            // gvSparepart
            // 
            this.gvSparepart.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSparepartDetail,
            this.colSparepartName,
            this.colPurchasePrice,
            this.colFeePctg,
            this.colFinalSubTotal});
            this.gvSparepart.GridControl = this.gridSparepart;
            this.gvSparepart.Name = "gvSparepart";
            this.gvSparepart.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gvSparepart.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.gvSparepart.OptionsBehavior.AutoPopulateColumns = false;
            this.gvSparepart.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.Inplace;
            this.gvSparepart.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click;
            this.gvSparepart.OptionsView.EnableAppearanceEvenRow = true;
            this.gvSparepart.OptionsView.ShowGroupPanel = false;
            this.gvSparepart.OptionsView.ShowViewCaption = true;
            this.gvSparepart.ViewCaption = "Daftar Sparepart";
            this.gvSparepart.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gvSparepart_CellValueChanged);
            // 
            // colSparepartDetail
            // 
            this.colSparepartDetail.Caption = "Kode Item";
            this.colSparepartDetail.FieldName = "SPKDetailSparepartDetail.SparepartDetail.Code";
            this.colSparepartDetail.Name = "colSparepartDetail";
            this.colSparepartDetail.OptionsColumn.ReadOnly = true;
            this.colSparepartDetail.Visible = true;
            this.colSparepartDetail.VisibleIndex = 0;
            // 
            // colSparepartName
            // 
            this.colSparepartName.Caption = "Sparepart";
            this.colSparepartName.FieldName = "SPKDetailSparepartDetail.SparepartDetail.Sparepart.Name";
            this.colSparepartName.Name = "colSparepartName";
            this.colSparepartName.OptionsColumn.ReadOnly = true;
            this.colSparepartName.Visible = true;
            this.colSparepartName.VisibleIndex = 1;
            // 
            // colPurchasePrice
            // 
            this.colPurchasePrice.Caption = "Harga Beli";
            this.colPurchasePrice.DisplayFormat.FormatString = "{0:#,#}";
            this.colPurchasePrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPurchasePrice.FieldName = "ItemPrice";
            this.colPurchasePrice.Name = "colPurchasePrice";
            this.colPurchasePrice.OptionsColumn.ReadOnly = true;
            this.colPurchasePrice.Visible = true;
            this.colPurchasePrice.VisibleIndex = 2;
            // 
            // colFeePctg
            // 
            this.colFeePctg.Caption = "Tambahan Biaya (%)";
            this.colFeePctg.DisplayFormat.FormatString = "{0:#,#}";
            this.colFeePctg.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colFeePctg.FieldName = "FeePctg";
            this.colFeePctg.Name = "colFeePctg";
            this.colFeePctg.Visible = true;
            this.colFeePctg.VisibleIndex = 3;
            // 
            // colFinalSubTotal
            // 
            this.colFinalSubTotal.Caption = "Total + Fee";
            this.colFinalSubTotal.DisplayFormat.FormatString = "{0:#,#}";
            this.colFinalSubTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colFinalSubTotal.FieldName = "SubTotalPrice";
            this.colFinalSubTotal.Name = "colFinalSubTotal";
            this.colFinalSubTotal.OptionsColumn.ReadOnly = true;
            this.colFinalSubTotal.Visible = true;
            this.colFinalSubTotal.VisibleIndex = 4;
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridSparepart;
            this.gridView1.Name = "gridView1";
            // 
            // txtTotalSparepart
            // 
            this.txtTotalSparepart.Location = new System.Drawing.Point(219, 290);
            this.txtTotalSparepart.Name = "txtTotalSparepart";
            this.txtTotalSparepart.Properties.DisplayFormat.FormatString = "{0:#,#;(#,#);0}";
            this.txtTotalSparepart.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtTotalSparepart.Properties.ReadOnly = true;
            this.txtTotalSparepart.Size = new System.Drawing.Size(158, 20);
            this.txtTotalSparepart.TabIndex = 27;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(17, 292);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(75, 13);
            this.labelControl4.TabIndex = 26;
            this.labelControl4.Text = "Total Sparepart";
            // 
            // txtTotalSparepartPlusFee
            // 
            this.txtTotalSparepartPlusFee.Location = new System.Drawing.Point(219, 343);
            this.txtTotalSparepartPlusFee.Name = "txtTotalSparepartPlusFee";
            this.txtTotalSparepartPlusFee.Properties.DisplayFormat.FormatString = "{0:#,#;(#,#);0}";
            this.txtTotalSparepartPlusFee.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtTotalSparepartPlusFee.Properties.ReadOnly = true;
            this.txtTotalSparepartPlusFee.Size = new System.Drawing.Size(158, 20);
            this.txtTotalSparepartPlusFee.TabIndex = 25;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(17, 347);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(112, 13);
            this.labelControl3.TabIndex = 24;
            this.labelControl3.Text = "Total Sparepart (+Fee)";
            // 
            // txtTotalService
            // 
            this.txtTotalService.Location = new System.Drawing.Point(219, 383);
            this.txtTotalService.Name = "txtTotalService";
            this.txtTotalService.Properties.DisplayFormat.FormatString = "{0:#,#;(#,#);0}";
            this.txtTotalService.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtTotalService.Properties.ReadOnly = true;
            this.txtTotalService.Size = new System.Drawing.Size(158, 20);
            this.txtTotalService.TabIndex = 23;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(17, 390);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(62, 13);
            this.labelControl2.TabIndex = 22;
            this.labelControl2.Text = "Total Service";
            // 
            // txtTotalServicePlusFee
            // 
            this.txtTotalServicePlusFee.Location = new System.Drawing.Point(219, 436);
            this.txtTotalServicePlusFee.Name = "txtTotalServicePlusFee";
            this.txtTotalServicePlusFee.Properties.DisplayFormat.FormatString = "{0:#,#;(#,#);0}";
            this.txtTotalServicePlusFee.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtTotalServicePlusFee.Properties.ReadOnly = true;
            this.txtTotalServicePlusFee.Size = new System.Drawing.Size(158, 20);
            this.txtTotalServicePlusFee.TabIndex = 21;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(17, 439);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(99, 13);
            this.labelControl1.TabIndex = 20;
            this.labelControl1.Text = "Total Service (+Fee)";
            // 
            // cbPaymentType
            // 
            this.cbPaymentType.Location = new System.Drawing.Point(219, 524);
            this.cbPaymentType.Name = "cbPaymentType";
            this.cbPaymentType.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.cbPaymentType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbPaymentType.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Nama")});
            this.cbPaymentType.Properties.DisplayMember = "Name";
            this.cbPaymentType.Properties.HideSelection = false;
            this.cbPaymentType.Properties.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned;
            this.cbPaymentType.Properties.NullText = "";
            this.cbPaymentType.Properties.ValueMember = "Id";
            this.cbPaymentType.Size = new System.Drawing.Size(158, 20);
            this.cbPaymentType.TabIndex = 19;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "Pilih salah satu pembayaran";
            conditionValidationRule1.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.None;
            this.valPaymentMethod.SetValidationRule(this.cbPaymentType, conditionValidationRule1);
            this.cbPaymentType.EditValueChanged += new System.EventHandler(this.cbPaymentType_EditValueChanged);
            // 
            // lblPaymentType
            // 
            this.lblPaymentType.Location = new System.Drawing.Point(17, 527);
            this.lblPaymentType.Name = "lblPaymentType";
            this.lblPaymentType.Size = new System.Drawing.Size(87, 13);
            this.lblPaymentType.TabIndex = 18;
            this.lblPaymentType.Text = "Jenis Pembayaran";
            // 
            // txtTotalPayment
            // 
            this.txtTotalPayment.Location = new System.Drawing.Point(219, 550);
            this.txtTotalPayment.Name = "txtTotalPayment";
            this.txtTotalPayment.Properties.DisplayFormat.FormatString = "{0:#,#;(#,#);0}";
            this.txtTotalPayment.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtTotalPayment.Size = new System.Drawing.Size(158, 20);
            this.txtTotalPayment.TabIndex = 17;
            // 
            // lblTotalPayment
            // 
            this.lblTotalPayment.Location = new System.Drawing.Point(17, 553);
            this.lblTotalPayment.Name = "lblTotalPayment";
            this.lblTotalPayment.Size = new System.Drawing.Size(91, 13);
            this.lblTotalPayment.TabIndex = 16;
            this.lblTotalPayment.Text = "Total Akan Dibayar";
            // 
            // txtTotalTransaction
            // 
            this.txtTotalTransaction.Location = new System.Drawing.Point(219, 499);
            this.txtTotalTransaction.Name = "txtTotalTransaction";
            this.txtTotalTransaction.Properties.DisplayFormat.FormatString = "{0:#,#;(#,#);0}";
            this.txtTotalTransaction.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtTotalTransaction.Properties.ReadOnly = true;
            this.txtTotalTransaction.Size = new System.Drawing.Size(158, 20);
            this.txtTotalTransaction.TabIndex = 10;
            // 
            // lblTotalTransaction
            // 
            this.lblTotalTransaction.Location = new System.Drawing.Point(17, 502);
            this.lblTotalTransaction.Name = "lblTotalTransaction";
            this.lblTotalTransaction.Size = new System.Drawing.Size(72, 13);
            this.lblTotalTransaction.TabIndex = 9;
            this.lblTotalTransaction.Text = "Total Transaksi";
            // 
            // txtCustomer
            // 
            this.txtCustomer.Location = new System.Drawing.Point(172, 65);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Properties.ReadOnly = true;
            this.txtCustomer.Size = new System.Drawing.Size(247, 20);
            this.txtCustomer.TabIndex = 7;
            // 
            // lblCustomer
            // 
            this.lblCustomer.Location = new System.Drawing.Point(14, 68);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(46, 13);
            this.lblCustomer.TabIndex = 6;
            this.lblCustomer.Text = "Customer";
            // 
            // lblTransactionDate
            // 
            this.lblTransactionDate.Location = new System.Drawing.Point(14, 33);
            this.lblTransactionDate.Name = "lblTransactionDate";
            this.lblTransactionDate.Size = new System.Drawing.Size(86, 13);
            this.lblTransactionDate.TabIndex = 4;
            this.lblTransactionDate.Text = "Tanggal Transaksi";
            // 
            // bgwSave
            // 
            this.bgwSave.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwSave_DoWork);
            this.bgwSave.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwSave_RunWorkerCompleted);
            // 
            // InvoiceEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 646);
            this.Controls.Add(this.gcInvoiceInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InvoiceEditorForm";
            this.Text = "Form Editor Invoice";
            this.Controls.SetChildIndex(this.gcInvoiceInfo, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gcInvoiceInfo)).EndInit();
            this.gcInvoiceInfo.ResumeLayout(false);
            this.gcInvoiceInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deTransDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deTransDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFeeSparepart.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValueAdded.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFeeService.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkApplyToAll.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMasterFee.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSparepart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSparepart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalSparepart.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalSparepartPlusFee.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalService.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalServicePlusFee.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbPaymentType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalPayment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalTransaction.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSparepart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valPaymentMethod)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gcInvoiceInfo;
        private DevExpress.XtraEditors.TextEdit txtTotalTransaction;
        private DevExpress.XtraEditors.LabelControl lblTotalTransaction;
        private DevExpress.XtraEditors.TextEdit txtCustomer;
        private DevExpress.XtraEditors.LabelControl lblCustomer;
        private DevExpress.XtraEditors.LabelControl lblTransactionDate;
        private DevExpress.XtraEditors.LookUpEdit cbPaymentType;
        private DevExpress.XtraEditors.LabelControl lblPaymentType;
        private DevExpress.XtraEditors.TextEdit txtTotalPayment;
        private DevExpress.XtraEditors.LabelControl lblTotalPayment;
        private DevExpress.XtraEditors.TextEdit txtTotalSparepart;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtTotalSparepartPlusFee;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtTotalService;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtTotalServicePlusFee;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gridSparepart;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSparepart;
        private DevExpress.XtraGrid.Columns.GridColumn colSparepartDetail;
        private DevExpress.XtraGrid.Columns.GridColumn colSparepartName;
        private DevExpress.XtraGrid.Columns.GridColumn colPurchasePrice;
        private DevExpress.XtraGrid.Columns.GridColumn colFeePctg;
        private DevExpress.XtraGrid.Columns.GridColumn colFinalSubTotal;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.TextEdit txtMasterFee;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.CheckEdit chkApplyToAll;
        private System.Windows.Forms.BindingSource bsSparepart;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider valPaymentMethod;
        private System.ComponentModel.BackgroundWorker bgwSave;
        private DevExpress.XtraEditors.TextEdit txtFeeSparepart;
        private DevExpress.XtraEditors.LabelControl lblFeeSparepart;
        private DevExpress.XtraEditors.TextEdit txtValueAdded;
        private DevExpress.XtraEditors.LabelControl lblValueAdded;
        private DevExpress.XtraEditors.TextEdit txtFeeService;
        private DevExpress.XtraEditors.LabelControl lblServiceFee;
        private DevExpress.XtraEditors.DateEdit deTransDate;
    }
}