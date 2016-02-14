namespace BrawijayaWorkshop.Win32App.ModulForms
{
    partial class UsedGoodsTransactionForm
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
            this.cbMode = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cbSparepart = new DevExpress.XtraEditors.LookUpEdit();
            this.txtQtyUpdate = new DevExpress.XtraEditors.TextEdit();
            this.lblQtyUpdaate = new DevExpress.XtraEditors.LabelControl();
            this.lblRemark = new DevExpress.XtraEditors.LabelControl();
            this.txtRemark = new DevExpress.XtraEditors.MemoEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStok.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcUsedGoodsManualEditor)).BeginInit();
            this.gcUsedGoodsManualEditor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbMode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSparepart.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQtyUpdate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemark.Properties)).BeginInit();
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
            this.txtStok.Size = new System.Drawing.Size(104, 20);
            this.txtStok.TabIndex = 12;
            // 
            // gcUsedGoodsManualEditor
            // 
            this.gcUsedGoodsManualEditor.Controls.Add(this.txtRemark);
            this.gcUsedGoodsManualEditor.Controls.Add(this.lblRemark);
            this.gcUsedGoodsManualEditor.Controls.Add(this.cbMode);
            this.gcUsedGoodsManualEditor.Controls.Add(this.labelControl1);
            this.gcUsedGoodsManualEditor.Controls.Add(this.cbSparepart);
            this.gcUsedGoodsManualEditor.Controls.Add(this.txtQtyUpdate);
            this.gcUsedGoodsManualEditor.Controls.Add(this.lblQtyUpdaate);
            this.gcUsedGoodsManualEditor.Controls.Add(this.lblSparepart);
            this.gcUsedGoodsManualEditor.Controls.Add(this.lblStok);
            this.gcUsedGoodsManualEditor.Controls.Add(this.txtStok);
            this.gcUsedGoodsManualEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcUsedGoodsManualEditor.Location = new System.Drawing.Point(0, 0);
            this.gcUsedGoodsManualEditor.Name = "gcUsedGoodsManualEditor";
            this.gcUsedGoodsManualEditor.Size = new System.Drawing.Size(335, 258);
            this.gcUsedGoodsManualEditor.TabIndex = 13;
            this.gcUsedGoodsManualEditor.Text = "Informasi Stok Barang Bekas";
            // 
            // cbMode
            // 
            this.cbMode.Location = new System.Drawing.Point(130, 130);
            this.cbMode.Name = "cbMode";
            this.cbMode.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.cbMode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbMode.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Sparepart.Id", "Sparepart ID"),
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
            // cbSparepart
            // 
            this.cbSparepart.Location = new System.Drawing.Point(130, 27);
            this.cbSparepart.Name = "cbSparepart";
            this.cbSparepart.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.cbSparepart.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbSparepart.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Sparepart.Id", "Sparepart ID"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Nama")});
            this.cbSparepart.Properties.DisplayMember = "Name";
            this.cbSparepart.Properties.HideSelection = false;
            this.cbSparepart.Properties.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned;
            this.cbSparepart.Properties.NullText = "-- Pilih Sparepart --";
            this.cbSparepart.Properties.ValueMember = "Id";
            this.cbSparepart.Size = new System.Drawing.Size(193, 20);
            this.cbSparepart.TabIndex = 15;
            // 
            // txtQtyUpdate
            // 
            this.txtQtyUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQtyUpdate.Location = new System.Drawing.Point(130, 93);
            this.txtQtyUpdate.Name = "txtQtyUpdate";
            this.txtQtyUpdate.Size = new System.Drawing.Size(104, 20);
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
            // lblRemark
            // 
            this.lblRemark.Location = new System.Drawing.Point(12, 170);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(56, 13);
            this.lblRemark.TabIndex = 18;
            this.lblRemark.Text = "Keterangan";
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(130, 168);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(193, 51);
            this.txtRemark.TabIndex = 20;
            // 
            // UsedGoodsTransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 307);
            this.Controls.Add(this.gcUsedGoodsManualEditor);
            this.Name = "UsedGoodsTransactionForm";
            this.Text = "Form Stok Barang Bekas";
            this.Controls.SetChildIndex(this.gcUsedGoodsManualEditor, 0);
            ((System.ComponentModel.ISupportInitialize)(this.txtStok.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcUsedGoodsManualEditor)).EndInit();
            this.gcUsedGoodsManualEditor.ResumeLayout(false);
            this.gcUsedGoodsManualEditor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbMode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSparepart.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQtyUpdate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemark.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblSparepart;
        private DevExpress.XtraEditors.LabelControl lblStok;
        private DevExpress.XtraEditors.TextEdit txtStok;
        private DevExpress.XtraEditors.GroupControl gcUsedGoodsManualEditor;
        private DevExpress.XtraEditors.TextEdit txtQtyUpdate;
        private DevExpress.XtraEditors.LabelControl lblQtyUpdaate;
        private DevExpress.XtraEditors.LookUpEdit cbSparepart;
        private DevExpress.XtraEditors.LookUpEdit cbMode;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl lblRemark;
        private DevExpress.XtraEditors.MemoEdit txtRemark;
    }
}