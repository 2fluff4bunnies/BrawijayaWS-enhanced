namespace BrawijayaWorkshop.Win32App.ModulForms
{
    partial class SparepartManualTransactionEditorForm
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
            this.lblSparepart = new DevExpress.XtraEditors.LabelControl();
            this.lblStok = new DevExpress.XtraEditors.LabelControl();
            this.txtStok = new DevExpress.XtraEditors.TextEdit();
            this.gcUsedGoodsManualEditor = new DevExpress.XtraEditors.GroupControl();
            this.txtSerialNumber = new DevExpress.XtraEditors.TextEdit();
            this.lblSerialNumber = new DevExpress.XtraEditors.LabelControl();
            this.txtSparepartName = new DevExpress.XtraEditors.TextEdit();
            this.txtTotalPrice = new DevExpress.XtraEditors.TextEdit();
            this.lblTotalPrice = new DevExpress.XtraEditors.LabelControl();
            this.txtItemPrice = new DevExpress.XtraEditors.TextEdit();
            this.lblItemPrice = new DevExpress.XtraEditors.LabelControl();
            this.txtRemark = new DevExpress.XtraEditors.MemoEdit();
            this.lblRemark = new DevExpress.XtraEditors.LabelControl();
            this.cbMode = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtQtyUpdate = new DevExpress.XtraEditors.TextEdit();
            this.lblQtyUpdaate = new DevExpress.XtraEditors.LabelControl();
            this.valQty = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider();
            this.valMode = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider();
            ((System.ComponentModel.ISupportInitialize)(this.txtStok.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcUsedGoodsManualEditor)).BeginInit();
            this.gcUsedGoodsManualEditor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSerialNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSparepartName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtItemPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemark.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQtyUpdate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valMode)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSparepart
            // 
            this.lblSparepart.Location = new System.Drawing.Point(13, 30);
            this.lblSparepart.Name = "lblSparepart";
            this.lblSparepart.Size = new System.Drawing.Size(48, 13);
            this.lblSparepart.TabIndex = 9;
            this.lblSparepart.Text = "Sparepart";
            // 
            // lblStok
            // 
            this.lblStok.Location = new System.Drawing.Point(12, 63);
            this.lblStok.Name = "lblStok";
            this.lblStok.Size = new System.Drawing.Size(57, 13);
            this.lblStok.TabIndex = 11;
            this.lblStok.Text = "Jumlah Stok";
            // 
            // txtStok
            // 
            this.txtStok.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStok.Location = new System.Drawing.Point(130, 60);
            this.txtStok.Name = "txtStok";
            this.txtStok.Properties.ReadOnly = true;
            this.txtStok.Size = new System.Drawing.Size(193, 20);
            this.txtStok.TabIndex = 12;
            // 
            // gcUsedGoodsManualEditor
            // 
            this.gcUsedGoodsManualEditor.Controls.Add(this.txtSerialNumber);
            this.gcUsedGoodsManualEditor.Controls.Add(this.lblSerialNumber);
            this.gcUsedGoodsManualEditor.Controls.Add(this.txtSparepartName);
            this.gcUsedGoodsManualEditor.Controls.Add(this.txtTotalPrice);
            this.gcUsedGoodsManualEditor.Controls.Add(this.lblTotalPrice);
            this.gcUsedGoodsManualEditor.Controls.Add(this.txtItemPrice);
            this.gcUsedGoodsManualEditor.Controls.Add(this.lblItemPrice);
            this.gcUsedGoodsManualEditor.Controls.Add(this.txtRemark);
            this.gcUsedGoodsManualEditor.Controls.Add(this.lblRemark);
            this.gcUsedGoodsManualEditor.Controls.Add(this.cbMode);
            this.gcUsedGoodsManualEditor.Controls.Add(this.labelControl1);
            this.gcUsedGoodsManualEditor.Controls.Add(this.txtQtyUpdate);
            this.gcUsedGoodsManualEditor.Controls.Add(this.lblQtyUpdaate);
            this.gcUsedGoodsManualEditor.Controls.Add(this.lblSparepart);
            this.gcUsedGoodsManualEditor.Controls.Add(this.lblStok);
            this.gcUsedGoodsManualEditor.Controls.Add(this.txtStok);
            this.gcUsedGoodsManualEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcUsedGoodsManualEditor.Location = new System.Drawing.Point(0, 0);
            this.gcUsedGoodsManualEditor.Name = "gcUsedGoodsManualEditor";
            this.gcUsedGoodsManualEditor.Size = new System.Drawing.Size(335, 340);
            this.gcUsedGoodsManualEditor.TabIndex = 13;
            this.gcUsedGoodsManualEditor.Text = "Informasi Stok Barang Bekas";
            // 
            // txtSerialNumber
            // 
            this.txtSerialNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSerialNumber.Location = new System.Drawing.Point(130, 165);
            this.txtSerialNumber.Name = "txtSerialNumber";
            this.txtSerialNumber.Size = new System.Drawing.Size(193, 20);
            this.txtSerialNumber.TabIndex = 27;
            // 
            // lblSerialNumber
            // 
            this.lblSerialNumber.Location = new System.Drawing.Point(12, 168);
            this.lblSerialNumber.Name = "lblSerialNumber";
            this.lblSerialNumber.Size = new System.Drawing.Size(81, 13);
            this.lblSerialNumber.TabIndex = 26;
            this.lblSerialNumber.Text = "Nomor Seri (Ban)";
            // 
            // txtSparepartName
            // 
            this.txtSparepartName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSparepartName.Location = new System.Drawing.Point(130, 27);
            this.txtSparepartName.Name = "txtSparepartName";
            this.txtSparepartName.Properties.ReadOnly = true;
            this.txtSparepartName.Size = new System.Drawing.Size(193, 20);
            this.txtSparepartName.TabIndex = 25;
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalPrice.Location = new System.Drawing.Point(130, 309);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.Properties.ReadOnly = true;
            this.txtTotalPrice.Size = new System.Drawing.Size(193, 20);
            this.txtTotalPrice.TabIndex = 24;
            this.txtTotalPrice.Visible = false;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.Location = new System.Drawing.Point(12, 312);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(56, 13);
            this.lblTotalPrice.TabIndex = 23;
            this.lblTotalPrice.Text = "Total Harga";
            this.lblTotalPrice.Visible = false;
            // 
            // txtItemPrice
            // 
            this.txtItemPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtItemPrice.Location = new System.Drawing.Point(130, 271);
            this.txtItemPrice.Name = "txtItemPrice";
            this.txtItemPrice.Size = new System.Drawing.Size(193, 20);
            this.txtItemPrice.TabIndex = 22;
            this.txtItemPrice.Visible = false;
            // 
            // lblItemPrice
            // 
            this.lblItemPrice.Location = new System.Drawing.Point(12, 274);
            this.lblItemPrice.Name = "lblItemPrice";
            this.lblItemPrice.Size = new System.Drawing.Size(73, 13);
            this.lblItemPrice.TabIndex = 21;
            this.lblItemPrice.Text = "Harga per Item";
            this.lblItemPrice.Visible = false;
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(130, 203);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(193, 51);
            this.txtRemark.TabIndex = 20;
            // 
            // lblRemark
            // 
            this.lblRemark.Location = new System.Drawing.Point(12, 205);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(56, 13);
            this.lblRemark.TabIndex = 18;
            this.lblRemark.Text = "Keterangan";
            // 
            // cbMode
            // 
            this.cbMode.Location = new System.Drawing.Point(130, 130);
            this.cbMode.Name = "cbMode";
            this.cbMode.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.cbMode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbMode.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Nama")});
            this.cbMode.Properties.DisplayMember = "Name";
            this.cbMode.Properties.HideSelection = false;
            this.cbMode.Properties.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned;
            this.cbMode.Properties.NullText = "-- Pilih Jenis Transaksi --";
            this.cbMode.Properties.ValueMember = "Id";
            this.cbMode.Size = new System.Drawing.Size(193, 20);
            this.cbMode.TabIndex = 17;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 133);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(72, 13);
            this.labelControl1.TabIndex = 16;
            this.labelControl1.Text = "Jenis Transaksi";
            // 
            // txtQtyUpdate
            // 
            this.txtQtyUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQtyUpdate.Location = new System.Drawing.Point(130, 93);
            this.txtQtyUpdate.Name = "txtQtyUpdate";
            this.txtQtyUpdate.Size = new System.Drawing.Size(193, 20);
            this.txtQtyUpdate.TabIndex = 14;
            // 
            // lblQtyUpdaate
            // 
            this.lblQtyUpdaate.Location = new System.Drawing.Point(12, 96);
            this.lblQtyUpdaate.Name = "lblQtyUpdaate";
            this.lblQtyUpdaate.Size = new System.Drawing.Size(71, 13);
            this.lblQtyUpdaate.TabIndex = 13;
            this.lblQtyUpdaate.Text = "Jumlah Update";
            // 
            // SparepartManualTransactionEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 389);
            this.Controls.Add(this.gcUsedGoodsManualEditor);
            this.Name = "SparepartManualTransactionEditorForm";
            this.Text = "Form Stok Barang Bekas";
            this.Controls.SetChildIndex(this.gcUsedGoodsManualEditor, 0);
            ((System.ComponentModel.ISupportInitialize)(this.txtStok.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcUsedGoodsManualEditor)).EndInit();
            this.gcUsedGoodsManualEditor.ResumeLayout(false);
            this.gcUsedGoodsManualEditor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSerialNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSparepartName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtItemPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemark.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQtyUpdate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valMode)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblSparepart;
        private DevExpress.XtraEditors.LabelControl lblStok;
        private DevExpress.XtraEditors.TextEdit txtStok;
        private DevExpress.XtraEditors.GroupControl gcUsedGoodsManualEditor;
        private DevExpress.XtraEditors.TextEdit txtQtyUpdate;
        private DevExpress.XtraEditors.LabelControl lblQtyUpdaate;
        private DevExpress.XtraEditors.LookUpEdit cbMode;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl lblRemark;
        private DevExpress.XtraEditors.MemoEdit txtRemark;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider valQty;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider valMode;
        private DevExpress.XtraEditors.TextEdit txtTotalPrice;
        private DevExpress.XtraEditors.LabelControl lblTotalPrice;
        private DevExpress.XtraEditors.TextEdit txtItemPrice;
        private DevExpress.XtraEditors.LabelControl lblItemPrice;
        private DevExpress.XtraEditors.TextEdit txtSparepartName;
        private DevExpress.XtraEditors.TextEdit txtSerialNumber;
        private DevExpress.XtraEditors.LabelControl lblSerialNumber;
    }
}