namespace BrawijayaWorkshop.Win32App.ModulForms
{
    partial class PurchasingApprovalForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PurchasingApprovalForm));
            this.gcPurchasingInfo = new DevExpress.XtraEditors.GroupControl();
            this.lblDP = new DevExpress.XtraEditors.LabelControl();
            this.txtTotalPrice = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.gridPurchasingDetail = new DevExpress.XtraGrid.GridControl();
            this.gvPurchasingDetail = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSparepart = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtDP = new DevExpress.XtraEditors.TextEdit();
            this.cbPayment = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtSupplier = new DevExpress.XtraEditors.TextEdit();
            this.txtDate = new DevExpress.XtraEditors.TextEdit();
            this.lblSupplier = new DevExpress.XtraEditors.LabelControl();
            this.lblDate = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnReject = new DevExpress.XtraEditors.SimpleButton();
            this.btnApprove = new DevExpress.XtraEditors.SimpleButton();
            this.cmsEditor = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lihatSparepartDetailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.valPayment = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.bgwSave = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.gcPurchasingInfo)).BeginInit();
            this.gcPurchasingInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPurchasingDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPurchasingDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbPayment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSupplier.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.cmsEditor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.valPayment)).BeginInit();
            this.SuspendLayout();
            // 
            // gcPurchasingInfo
            // 
            this.gcPurchasingInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcPurchasingInfo.Controls.Add(this.lblDP);
            this.gcPurchasingInfo.Controls.Add(this.txtTotalPrice);
            this.gcPurchasingInfo.Controls.Add(this.labelControl2);
            this.gcPurchasingInfo.Controls.Add(this.gridPurchasingDetail);
            this.gcPurchasingInfo.Controls.Add(this.txtDP);
            this.gcPurchasingInfo.Controls.Add(this.cbPayment);
            this.gcPurchasingInfo.Controls.Add(this.labelControl1);
            this.gcPurchasingInfo.Controls.Add(this.txtSupplier);
            this.gcPurchasingInfo.Controls.Add(this.txtDate);
            this.gcPurchasingInfo.Controls.Add(this.lblSupplier);
            this.gcPurchasingInfo.Controls.Add(this.lblDate);
            this.gcPurchasingInfo.Location = new System.Drawing.Point(0, 0);
            this.gcPurchasingInfo.Name = "gcPurchasingInfo";
            this.gcPurchasingInfo.Size = new System.Drawing.Size(612, 339);
            this.gcPurchasingInfo.TabIndex = 0;
            this.gcPurchasingInfo.Text = "Informasi Pembelian";
            // 
            // lblDP
            // 
            this.lblDP.Location = new System.Drawing.Point(12, 128);
            this.lblDP.Name = "lblDP";
            this.lblDP.Size = new System.Drawing.Size(49, 13);
            this.lblDP.TabIndex = 6;
            this.lblDP.Text = "Jumlah DP";
            this.lblDP.Visible = false;
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTotalPrice.Location = new System.Drawing.Point(155, 301);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.Properties.ReadOnly = true;
            this.txtTotalPrice.Size = new System.Drawing.Size(167, 20);
            this.txtTotalPrice.TabIndex = 10;
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelControl2.Location = new System.Drawing.Point(12, 304);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(56, 13);
            this.labelControl2.TabIndex = 9;
            this.labelControl2.Text = "Total Harga";
            // 
            // gridPurchasingDetail
            // 
            this.gridPurchasingDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridPurchasingDetail.Location = new System.Drawing.Point(3, 157);
            this.gridPurchasingDetail.MainView = this.gvPurchasingDetail;
            this.gridPurchasingDetail.Name = "gridPurchasingDetail";
            this.gridPurchasingDetail.Size = new System.Drawing.Size(607, 130);
            this.gridPurchasingDetail.TabIndex = 8;
            this.gridPurchasingDetail.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPurchasingDetail});
            // 
            // gvPurchasingDetail
            // 
            this.gvPurchasingDetail.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSparepart,
            this.colQty,
            this.colPrice});
            this.gvPurchasingDetail.GridControl = this.gridPurchasingDetail;
            this.gvPurchasingDetail.Name = "gvPurchasingDetail";
            this.gvPurchasingDetail.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvPurchasingDetail.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvPurchasingDetail.OptionsBehavior.Editable = false;
            this.gvPurchasingDetail.OptionsBehavior.ReadOnly = true;
            this.gvPurchasingDetail.OptionsCustomization.AllowColumnMoving = false;
            this.gvPurchasingDetail.OptionsCustomization.AllowFilter = false;
            this.gvPurchasingDetail.OptionsCustomization.AllowGroup = false;
            this.gvPurchasingDetail.OptionsCustomization.AllowQuickHideColumns = false;
            this.gvPurchasingDetail.OptionsView.EnableAppearanceEvenRow = true;
            this.gvPurchasingDetail.OptionsView.ShowGroupPanel = false;
            this.gvPurchasingDetail.OptionsView.ShowViewCaption = true;
            this.gvPurchasingDetail.ViewCaption = "Daftar Sparepart";
            this.gvPurchasingDetail.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.gvPurchasingDetail_PopupMenuShowing);
            this.gvPurchasingDetail.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvPurchasingDetail_FocusedRowChanged);
            // 
            // colSparepart
            // 
            this.colSparepart.Caption = "Sparepart";
            this.colSparepart.FieldName = "Sparepart.Name";
            this.colSparepart.Name = "colSparepart";
            this.colSparepart.Visible = true;
            this.colSparepart.VisibleIndex = 0;
            // 
            // colQty
            // 
            this.colQty.Caption = "Jumlah";
            this.colQty.FieldName = "Qty";
            this.colQty.Name = "colQty";
            this.colQty.Visible = true;
            this.colQty.VisibleIndex = 1;
            // 
            // colPrice
            // 
            this.colPrice.Caption = "Harga per Item";
            this.colPrice.DisplayFormat.FormatString = " {0:#,#;(#,#);0}";
            this.colPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPrice.FieldName = "Price";
            this.colPrice.Name = "colPrice";
            this.colPrice.Visible = true;
            this.colPrice.VisibleIndex = 2;
            // 
            // txtDP
            // 
            this.txtDP.Location = new System.Drawing.Point(155, 125);
            this.txtDP.Name = "txtDP";
            this.txtDP.Properties.DisplayFormat.FormatString = " {0:#,#;(#,#);0}";
            this.txtDP.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtDP.Size = new System.Drawing.Size(167, 20);
            this.txtDP.TabIndex = 7;
            this.txtDP.Visible = false;
            // 
            // cbPayment
            // 
            this.cbPayment.Location = new System.Drawing.Point(155, 93);
            this.cbPayment.Name = "cbPayment";
            this.cbPayment.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbPayment.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Metode")});
            this.cbPayment.Properties.DisplayMember = "Name";
            this.cbPayment.Properties.NullText = "";
            this.cbPayment.Properties.ValueMember = "Id";
            this.cbPayment.Size = new System.Drawing.Size(167, 20);
            this.cbPayment.TabIndex = 5;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "Pilih salah satu pembayaran";
            this.valPayment.SetValidationRule(this.cbPayment, conditionValidationRule1);
            this.cbPayment.EditValueChanged += new System.EventHandler(this.cbPayment_EditValueChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 96);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(99, 13);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Metode Pembayaran";
            // 
            // txtSupplier
            // 
            this.txtSupplier.Location = new System.Drawing.Point(155, 61);
            this.txtSupplier.Name = "txtSupplier";
            this.txtSupplier.Properties.ReadOnly = true;
            this.txtSupplier.Size = new System.Drawing.Size(167, 20);
            this.txtSupplier.TabIndex = 3;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(155, 29);
            this.txtDate.Name = "txtDate";
            this.txtDate.Properties.ReadOnly = true;
            this.txtDate.Size = new System.Drawing.Size(167, 20);
            this.txtDate.TabIndex = 1;
            // 
            // lblSupplier
            // 
            this.lblSupplier.Location = new System.Drawing.Point(12, 64);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(38, 13);
            this.lblSupplier.TabIndex = 2;
            this.lblSupplier.Text = "Supplier";
            // 
            // lblDate
            // 
            this.lblDate.Location = new System.Drawing.Point(12, 32);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(89, 13);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "Tanggal Pembelian";
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.Silver;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.btnReject);
            this.panelControl1.Controls.Add(this.btnApprove);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 337);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(612, 39);
            this.panelControl1.TabIndex = 0;
            // 
            // btnReject
            // 
            this.btnReject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReject.Location = new System.Drawing.Point(526, 8);
            this.btnReject.Name = "btnReject";
            this.btnReject.Size = new System.Drawing.Size(75, 23);
            this.btnReject.TabIndex = 1;
            this.btnReject.Text = "Tolak";
            this.btnReject.Click += new System.EventHandler(this.btnReject_Click);
            // 
            // btnApprove
            // 
            this.btnApprove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApprove.Location = new System.Drawing.Point(435, 8);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(75, 23);
            this.btnApprove.TabIndex = 0;
            this.btnApprove.Text = "Setuju";
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click);
            // 
            // cmsEditor
            // 
            this.cmsEditor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lihatSparepartDetailToolStripMenuItem});
            this.cmsEditor.Name = "cmsEditor";
            this.cmsEditor.Size = new System.Drawing.Size(187, 26);
            // 
            // lihatSparepartDetailToolStripMenuItem
            // 
            this.lihatSparepartDetailToolStripMenuItem.Image = global::BrawijayaWorkshop.Win32App.Properties.Resources.history_16x16;
            this.lihatSparepartDetailToolStripMenuItem.Name = "lihatSparepartDetailToolStripMenuItem";
            this.lihatSparepartDetailToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.lihatSparepartDetailToolStripMenuItem.Text = "Lihat Sparepart Detail";
            this.lihatSparepartDetailToolStripMenuItem.Click += new System.EventHandler(this.viewSparepartDetailToolStripMenuItem_Click);
            // 
            // valPayment
            // 
            this.valPayment.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual;
            // 
            // bgwSave
            // 
            this.bgwSave.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwSave_DoWork);
            this.bgwSave.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwSave_RunWorkerCompleted);
            // 
            // PurchasingApprovalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 376);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.gcPurchasingInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PurchasingApprovalForm";
            this.ShowInTaskbar = false;
            this.Text = "Form Persetujuan Pembelian";
            this.Load += new System.EventHandler(this.PurchasingApprovalForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcPurchasingInfo)).EndInit();
            this.gcPurchasingInfo.ResumeLayout(false);
            this.gcPurchasingInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPurchasingDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPurchasingDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbPayment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSupplier.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.cmsEditor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.valPayment)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gcPurchasingInfo;
        private DevExpress.XtraEditors.LabelControl lblDate;
        private DevExpress.XtraEditors.LabelControl lblSupplier;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtSupplier;
        private DevExpress.XtraEditors.TextEdit txtDate;
        private DevExpress.XtraEditors.TextEdit txtDP;
        private DevExpress.XtraEditors.LookUpEdit cbPayment;
        private DevExpress.XtraGrid.GridControl gridPurchasingDetail;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPurchasingDetail;
        private DevExpress.XtraGrid.Columns.GridColumn colSparepart;
        private DevExpress.XtraGrid.Columns.GridColumn colQty;
        private DevExpress.XtraGrid.Columns.GridColumn colPrice;
        private System.Windows.Forms.ContextMenuStrip cmsEditor;
        private DevExpress.XtraEditors.TextEdit txtTotalPrice;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.ToolStripMenuItem lihatSparepartDetailToolStripMenuItem;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnReject;
        private DevExpress.XtraEditors.SimpleButton btnApprove;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider valPayment;
        private DevExpress.XtraEditors.LabelControl lblDP;
        private System.ComponentModel.BackgroundWorker bgwSave;
    }
}