namespace BrawijayaWorkshop.Win32App.ModulForms
{
    partial class PurchasingEditorForm
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
            this.txtDate = new DevExpress.XtraEditors.DateEdit();
            this.gcPurchasingInfo = new DevExpress.XtraEditors.GroupControl();
            this.lblDate = new DevExpress.XtraEditors.LabelControl();
            this.lookUpSupplier = new DevExpress.XtraEditors.LookUpEdit();
            this.lblSupplier = new DevExpress.XtraEditors.LabelControl();
            this.gridPurchasingDetail = new DevExpress.XtraGrid.GridControl();
            this.gvPurchasingDetail = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.txtDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPurchasingInfo)).BeginInit();
            this.gcPurchasingInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpSupplier.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPurchasingDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPurchasingDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDate
            // 
            this.txtDate.EditValue = null;
            this.txtDate.Location = new System.Drawing.Point(148, 27);
            this.txtDate.Name = "txtDate";
            this.txtDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDate.Size = new System.Drawing.Size(159, 20);
            this.txtDate.TabIndex = 0;
            // 
            // gcPurchasingInfo
            // 
            this.gcPurchasingInfo.Controls.Add(this.gridPurchasingDetail);
            this.gcPurchasingInfo.Controls.Add(this.lblSupplier);
            this.gcPurchasingInfo.Controls.Add(this.lookUpSupplier);
            this.gcPurchasingInfo.Controls.Add(this.lblDate);
            this.gcPurchasingInfo.Controls.Add(this.txtDate);
            this.gcPurchasingInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcPurchasingInfo.Location = new System.Drawing.Point(0, 0);
            this.gcPurchasingInfo.Name = "gcPurchasingInfo";
            this.gcPurchasingInfo.Size = new System.Drawing.Size(580, 334);
            this.gcPurchasingInfo.TabIndex = 1;
            this.gcPurchasingInfo.Text = "Informasi Penerimaan";
            // 
            // lblDate
            // 
            this.lblDate.Location = new System.Drawing.Point(19, 30);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(97, 13);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Tanggal Penerimaan";
            // 
            // lookUpSupplier
            // 
            this.lookUpSupplier.Location = new System.Drawing.Point(148, 60);
            this.lookUpSupplier.Name = "lookUpSupplier";
            this.lookUpSupplier.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpSupplier.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Value", "Supplier")});
            this.lookUpSupplier.Properties.DisplayMember = "Value";
            this.lookUpSupplier.Properties.ValueMember = "Id";
            this.lookUpSupplier.Size = new System.Drawing.Size(100, 20);
            this.lookUpSupplier.TabIndex = 2;
            // 
            // lblSupplier
            // 
            this.lblSupplier.Location = new System.Drawing.Point(19, 63);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(38, 13);
            this.lblSupplier.TabIndex = 3;
            this.lblSupplier.Text = "Supplier";
            // 
            // gridPurchasingDetail
            // 
            this.gridPurchasingDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridPurchasingDetail.Location = new System.Drawing.Point(5, 100);
            this.gridPurchasingDetail.MainView = this.gvPurchasingDetail;
            this.gridPurchasingDetail.Name = "gridPurchasingDetail";
            this.gridPurchasingDetail.Size = new System.Drawing.Size(570, 147);
            this.gridPurchasingDetail.TabIndex = 4;
            this.gridPurchasingDetail.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPurchasingDetail});
            // 
            // gvPurchasingDetail
            // 
            this.gvPurchasingDetail.GridControl = this.gridPurchasingDetail;
            this.gvPurchasingDetail.Name = "gvPurchasingDetail";
            this.gvPurchasingDetail.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvPurchasingDetail.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvPurchasingDetail.OptionsBehavior.AutoPopulateColumns = false;
            this.gvPurchasingDetail.OptionsBehavior.Editable = false;
            this.gvPurchasingDetail.OptionsBehavior.ReadOnly = true;
            this.gvPurchasingDetail.OptionsCustomization.AllowColumnMoving = false;
            this.gvPurchasingDetail.OptionsCustomization.AllowFilter = false;
            this.gvPurchasingDetail.OptionsCustomization.AllowGroup = false;
            this.gvPurchasingDetail.OptionsCustomization.AllowQuickHideColumns = false;
            // 
            // PurchasingEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 334);
            this.Controls.Add(this.gcPurchasingInfo);
            this.Name = "PurchasingEditorForm";
            this.Text = "PurchasingEditorForm";
            ((System.ComponentModel.ISupportInitialize)(this.txtDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPurchasingInfo)).EndInit();
            this.gcPurchasingInfo.ResumeLayout(false);
            this.gcPurchasingInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpSupplier.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPurchasingDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPurchasingDetail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.DateEdit txtDate;
        private DevExpress.XtraEditors.GroupControl gcPurchasingInfo;
        private DevExpress.XtraEditors.LabelControl lblDate;
        private DevExpress.XtraEditors.LabelControl lblSupplier;
        private DevExpress.XtraEditors.LookUpEdit lookUpSupplier;
        private DevExpress.XtraGrid.GridControl gridPurchasingDetail;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPurchasingDetail;
    }
}