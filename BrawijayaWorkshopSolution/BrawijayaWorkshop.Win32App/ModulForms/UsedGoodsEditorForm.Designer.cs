namespace BrawijayaWorkshop.Win32App.ModulForms
{
    partial class UsedGoodsEditorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsedGoodsEditorForm));
            this.cbSparepart = new DevExpress.XtraEditors.LookUpEdit();
            this.lblSparepart = new DevExpress.XtraEditors.LabelControl();
            this.gcUsedGoodsEditor = new DevExpress.XtraEditors.GroupControl();
            this.valSparepart = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.cbSparepart.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcUsedGoodsEditor)).BeginInit();
            this.gcUsedGoodsEditor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.valSparepart)).BeginInit();
            this.SuspendLayout();
            // 
            // cbSparepart
            // 
            this.cbSparepart.Location = new System.Drawing.Point(81, 29);
            this.cbSparepart.Name = "cbSparepart";
            this.cbSparepart.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.cbSparepart.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbSparepart.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Nama")});
            this.cbSparepart.Properties.DisplayMember = "Name";
            this.cbSparepart.Properties.HideSelection = false;
            this.cbSparepart.Properties.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned;
            this.cbSparepart.Properties.NullText = "";
            this.cbSparepart.Properties.ValueMember = "Id";
            this.cbSparepart.Size = new System.Drawing.Size(208, 20);
            this.cbSparepart.TabIndex = 9;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.NotEquals;
            conditionValidationRule1.ErrorText = "Pilih salah satu sparepart";
            conditionValidationRule1.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.None;
            conditionValidationRule1.Value1 = "--Pilih Sparepart--";
            this.valSparepart.SetValidationRule(this.cbSparepart, conditionValidationRule1);
            // 
            // lblSparepart
            // 
            this.lblSparepart.Location = new System.Drawing.Point(14, 32);
            this.lblSparepart.Name = "lblSparepart";
            this.lblSparepart.Size = new System.Drawing.Size(48, 13);
            this.lblSparepart.TabIndex = 8;
            this.lblSparepart.Text = "Sparepart";
            // 
            // gcUsedGoodsEditor
            // 
            this.gcUsedGoodsEditor.Controls.Add(this.lblSparepart);
            this.gcUsedGoodsEditor.Controls.Add(this.cbSparepart);
            this.gcUsedGoodsEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcUsedGoodsEditor.Location = new System.Drawing.Point(0, 0);
            this.gcUsedGoodsEditor.Name = "gcUsedGoodsEditor";
            this.gcUsedGoodsEditor.Size = new System.Drawing.Size(301, 73);
            this.gcUsedGoodsEditor.TabIndex = 10;
            this.gcUsedGoodsEditor.Text = "Informasi Barang Bekas";
            // 
            // UsedGoodsEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 122);
            this.Controls.Add(this.gcUsedGoodsEditor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UsedGoodsEditorForm";
            this.Text = "Form Barang Bekas";
            this.Load += new System.EventHandler(this.UsedGoodEditorForm_Load);
            this.Controls.SetChildIndex(this.gcUsedGoodsEditor, 0);
            ((System.ComponentModel.ISupportInitialize)(this.cbSparepart.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcUsedGoodsEditor)).EndInit();
            this.gcUsedGoodsEditor.ResumeLayout(false);
            this.gcUsedGoodsEditor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.valSparepart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LookUpEdit cbSparepart;
        private DevExpress.XtraEditors.LabelControl lblSparepart;
        private DevExpress.XtraEditors.GroupControl gcUsedGoodsEditor;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider valSparepart;
    }
}