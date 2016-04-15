namespace BrawijayaWorkshop.Win32App.ModulForms
{
    partial class UsedGoodTransactionEditorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsedGoodTransactionEditorForm));
            this.lblSparepart = new DevExpress.XtraEditors.LabelControl();
            this.lblStok = new DevExpress.XtraEditors.LabelControl();
            this.txtStok = new DevExpress.XtraEditors.TextEdit();
            this.gcUsedGoodsManualEditor = new DevExpress.XtraEditors.GroupControl();
            this.cbUsedGood = new DevExpress.XtraEditors.LookUpEdit();
            this.txtItemPrice = new DevExpress.XtraEditors.TextEdit();
            this.lblItemPrice = new DevExpress.XtraEditors.LabelControl();
            this.txtRemark = new DevExpress.XtraEditors.MemoEdit();
            this.lblRemark = new DevExpress.XtraEditors.LabelControl();
            this.cbMode = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtQtyUpdate = new DevExpress.XtraEditors.TextEdit();
            this.lblQtyUpdaate = new DevExpress.XtraEditors.LabelControl();
            this.valQty = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.valMode = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txtStok.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcUsedGoodsManualEditor)).BeginInit();
            this.gcUsedGoodsManualEditor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbUsedGood.Properties)).BeginInit();
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
            this.lblSparepart.Location = new System.Drawing.Point(13, 35);
            this.lblSparepart.Name = "lblSparepart";
            this.lblSparepart.Size = new System.Drawing.Size(48, 13);
            this.lblSparepart.TabIndex = 9;
            this.lblSparepart.Text = "Sparepart";
            // 
            // lblStok
            // 
            this.lblStok.Location = new System.Drawing.Point(13, 70);
            this.lblStok.Name = "lblStok";
            this.lblStok.Size = new System.Drawing.Size(57, 13);
            this.lblStok.TabIndex = 11;
            this.lblStok.Text = "Jumlah Stok";
            // 
            // txtStok
            // 
            this.txtStok.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStok.Location = new System.Drawing.Point(122, 67);
            this.txtStok.Name = "txtStok";
            this.txtStok.Properties.ReadOnly = true;
            this.txtStok.Size = new System.Drawing.Size(98, 20);
            this.txtStok.TabIndex = 12;
            // 
            // gcUsedGoodsManualEditor
            // 
            this.gcUsedGoodsManualEditor.Controls.Add(this.cbUsedGood);
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
            this.gcUsedGoodsManualEditor.Size = new System.Drawing.Size(329, 270);
            this.gcUsedGoodsManualEditor.TabIndex = 13;
            this.gcUsedGoodsManualEditor.Text = "Informasi Stok Barang Bekas";
            // 
            // cbUsedGood
            // 
            this.cbUsedGood.Location = new System.Drawing.Point(122, 32);
            this.cbUsedGood.Name = "cbUsedGood";
            this.cbUsedGood.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.cbUsedGood.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbUsedGood.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Sparepart.Name", "Nama")});
            this.cbUsedGood.Properties.DisplayMember = "Sparepart.Name";
            this.cbUsedGood.Properties.HideSelection = false;
            this.cbUsedGood.Properties.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned;
            this.cbUsedGood.Properties.NullText = "";
            this.cbUsedGood.Properties.ReadOnly = true;
            this.cbUsedGood.Properties.ValueMember = "Id";
            this.cbUsedGood.Size = new System.Drawing.Size(193, 20);
            this.cbUsedGood.TabIndex = 23;
            this.cbUsedGood.EditValueChanged += new System.EventHandler(this.cbUsedGood_EditValueChanged);
            // 
            // txtItemPrice
            // 
            this.txtItemPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtItemPrice.Location = new System.Drawing.Point(122, 235);
            this.txtItemPrice.Name = "txtItemPrice";
            this.txtItemPrice.Size = new System.Drawing.Size(139, 20);
            this.txtItemPrice.TabIndex = 22;
            this.txtItemPrice.Visible = false;
            // 
            // lblItemPrice
            // 
            this.lblItemPrice.Location = new System.Drawing.Point(13, 238);
            this.lblItemPrice.Name = "lblItemPrice";
            this.lblItemPrice.Size = new System.Drawing.Size(73, 13);
            this.lblItemPrice.TabIndex = 21;
            this.lblItemPrice.Text = "Harga per Item";
            this.lblItemPrice.Visible = false;
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(122, 173);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(193, 51);
            this.txtRemark.TabIndex = 20;
            // 
            // lblRemark
            // 
            this.lblRemark.Location = new System.Drawing.Point(13, 175);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(56, 13);
            this.lblRemark.TabIndex = 18;
            this.lblRemark.Text = "Keterangan";
            // 
            // cbMode
            // 
            this.cbMode.Location = new System.Drawing.Point(122, 137);
            this.cbMode.Name = "cbMode";
            this.cbMode.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.cbMode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbMode.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Nama")});
            this.cbMode.Properties.DisplayMember = "Name";
            this.cbMode.Properties.HideSelection = false;
            this.cbMode.Properties.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned;
            this.cbMode.Properties.NullText = "";
            this.cbMode.Properties.ValueMember = "Id";
            this.cbMode.Size = new System.Drawing.Size(193, 20);
            this.cbMode.TabIndex = 17;
            this.cbMode.EditValueChanged += new System.EventHandler(this.cbMode_EditValueChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(13, 140);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(72, 13);
            this.labelControl1.TabIndex = 16;
            this.labelControl1.Text = "Jenis Transaksi";
            // 
            // txtQtyUpdate
            // 
            this.txtQtyUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQtyUpdate.Location = new System.Drawing.Point(122, 102);
            this.txtQtyUpdate.Name = "txtQtyUpdate";
            this.txtQtyUpdate.Size = new System.Drawing.Size(98, 20);
            this.txtQtyUpdate.TabIndex = 14;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "Jumlah Update Harus Diisi";
            this.valQty.SetValidationRule(this.txtQtyUpdate, conditionValidationRule1);
            // 
            // lblQtyUpdaate
            // 
            this.lblQtyUpdaate.Location = new System.Drawing.Point(13, 105);
            this.lblQtyUpdaate.Name = "lblQtyUpdaate";
            this.lblQtyUpdaate.Size = new System.Drawing.Size(71, 13);
            this.lblQtyUpdaate.TabIndex = 13;
            this.lblQtyUpdaate.Text = "Jumlah Update";
            // 
            // UsedGoodTransactionEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 319);
            this.Controls.Add(this.gcUsedGoodsManualEditor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UsedGoodTransactionEditorForm";
            this.Text = "Form Stok Barang Bekas";
            this.Controls.SetChildIndex(this.gcUsedGoodsManualEditor, 0);
            ((System.ComponentModel.ISupportInitialize)(this.txtStok.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcUsedGoodsManualEditor)).EndInit();
            this.gcUsedGoodsManualEditor.ResumeLayout(false);
            this.gcUsedGoodsManualEditor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbUsedGood.Properties)).EndInit();
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
        private DevExpress.XtraEditors.TextEdit txtItemPrice;
        private DevExpress.XtraEditors.LabelControl lblItemPrice;
        private DevExpress.XtraEditors.LookUpEdit cbUsedGood;
    }
}