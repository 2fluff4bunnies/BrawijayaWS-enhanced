namespace BrawijayaWorkshop.Win32App.ModulControls
{
    partial class HPPListControl
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
            this.bgwMain = new System.ComponentModel.BackgroundWorker();
            this.bgwRecalculate = new System.ComponentModel.BackgroundWorker();
            this.gcFilter = new DevExpress.XtraEditors.GroupControl();
            this.comboYear = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblFilterYear = new DevExpress.XtraEditors.LabelControl();
            this.lookupMonth = new DevExpress.XtraEditors.LookUpEdit();
            this.lblFilterMonth = new DevExpress.XtraEditors.LabelControl();
            this.btnRecalculateHPP = new DevExpress.XtraEditors.SimpleButton();
            this.gridHPP = new DevExpress.XtraGrid.GridControl();
            this.gvHPP = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colJournalCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colJournalName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBaseAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colServiceAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gcFilter)).BeginInit();
            this.gcFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboYear.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupMonth.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridHPP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvHPP)).BeginInit();
            this.SuspendLayout();
            // 
            // gcFilter
            // 
            this.gcFilter.Controls.Add(this.comboYear);
            this.gcFilter.Controls.Add(this.lblFilterYear);
            this.gcFilter.Controls.Add(this.lookupMonth);
            this.gcFilter.Controls.Add(this.lblFilterMonth);
            this.gcFilter.Location = new System.Drawing.Point(3, 3);
            this.gcFilter.Name = "gcFilter";
            this.gcFilter.Size = new System.Drawing.Size(828, 66);
            this.gcFilter.TabIndex = 0;
            this.gcFilter.Text = "Filter";
            // 
            // comboYear
            // 
            this.comboYear.Location = new System.Drawing.Point(248, 32);
            this.comboYear.Name = "comboYear";
            this.comboYear.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboYear.Size = new System.Drawing.Size(81, 20);
            this.comboYear.TabIndex = 3;
            // 
            // lblFilterYear
            // 
            this.lblFilterYear.Location = new System.Drawing.Point(208, 35);
            this.lblFilterYear.Name = "lblFilterYear";
            this.lblFilterYear.Size = new System.Drawing.Size(34, 13);
            this.lblFilterYear.TabIndex = 2;
            this.lblFilterYear.Text = "Tahun:";
            // 
            // lookupMonth
            // 
            this.lookupMonth.Location = new System.Drawing.Point(48, 32);
            this.lookupMonth.Name = "lookupMonth";
            this.lookupMonth.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookupMonth.Size = new System.Drawing.Size(128, 20);
            this.lookupMonth.TabIndex = 1;
            // 
            // lblFilterMonth
            // 
            this.lblFilterMonth.Location = new System.Drawing.Point(12, 35);
            this.lblFilterMonth.Name = "lblFilterMonth";
            this.lblFilterMonth.Size = new System.Drawing.Size(30, 13);
            this.lblFilterMonth.TabIndex = 0;
            this.lblFilterMonth.Text = "Bulan:";
            // 
            // btnRecalculateHPP
            // 
            this.btnRecalculateHPP.Image = global::BrawijayaWorkshop.Win32App.Properties.Resources.calculator_16x16;
            this.btnRecalculateHPP.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnRecalculateHPP.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnRecalculateHPP.Location = new System.Drawing.Point(3, 75);
            this.btnRecalculateHPP.Name = "btnRecalculateHPP";
            this.btnRecalculateHPP.Size = new System.Drawing.Size(96, 29);
            this.btnRecalculateHPP.TabIndex = 1;
            this.btnRecalculateHPP.Text = "Hitung HPP";
            // 
            // gridHPP
            // 
            this.gridHPP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridHPP.Location = new System.Drawing.Point(3, 110);
            this.gridHPP.MainView = this.gvHPP;
            this.gridHPP.Name = "gridHPP";
            this.gridHPP.Size = new System.Drawing.Size(828, 359);
            this.gridHPP.TabIndex = 6;
            this.gridHPP.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvHPP});
            // 
            // gvHPP
            // 
            this.gvHPP.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colJournalCode,
            this.colJournalName,
            this.colBaseAmount,
            this.colServiceAmount,
            this.colTotal});
            this.gvHPP.GridControl = this.gridHPP;
            this.gvHPP.Name = "gvHPP";
            this.gvHPP.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvHPP.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvHPP.OptionsBehavior.AutoPopulateColumns = false;
            this.gvHPP.OptionsBehavior.Editable = false;
            this.gvHPP.OptionsBehavior.ReadOnly = true;
            this.gvHPP.OptionsCustomization.AllowColumnMoving = false;
            this.gvHPP.OptionsCustomization.AllowFilter = false;
            this.gvHPP.OptionsCustomization.AllowGroup = false;
            this.gvHPP.OptionsCustomization.AllowQuickHideColumns = false;
            this.gvHPP.OptionsView.EnableAppearanceEvenRow = true;
            this.gvHPP.OptionsView.ShowGroupPanel = false;
            this.gvHPP.OptionsView.ShowViewCaption = true;
            this.gvHPP.ViewCaption = "Harga Pokok Penjualan";
            // 
            // colJournalCode
            // 
            this.colJournalCode.Caption = "Kode Akun";
            this.colJournalCode.FieldName = "Journal.Code";
            this.colJournalCode.Name = "colJournalCode";
            this.colJournalCode.Visible = true;
            this.colJournalCode.VisibleIndex = 0;
            // 
            // colJournalName
            // 
            this.colJournalName.Caption = "Nama";
            this.colJournalName.FieldName = "Journal.Name";
            this.colJournalName.Name = "colJournalName";
            this.colJournalName.Visible = true;
            this.colJournalName.VisibleIndex = 1;
            // 
            // colBaseAmount
            // 
            this.colBaseAmount.Caption = "Jumlah";
            this.colBaseAmount.FieldName = "BaseAmount";
            this.colBaseAmount.Name = "colBaseAmount";
            this.colBaseAmount.Visible = true;
            this.colBaseAmount.VisibleIndex = 2;
            // 
            // colServiceAmount
            // 
            this.colServiceAmount.Caption = "Jasa 10%";
            this.colServiceAmount.FieldName = "ServiceAmount";
            this.colServiceAmount.Name = "colServiceAmount";
            this.colServiceAmount.Visible = true;
            this.colServiceAmount.VisibleIndex = 3;
            // 
            // colTotal
            // 
            this.colTotal.Caption = "Total";
            this.colTotal.FieldName = "TotalAmount";
            this.colTotal.Name = "colTotal";
            this.colTotal.Visible = true;
            this.colTotal.VisibleIndex = 4;
            // 
            // HPPListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridHPP);
            this.Controls.Add(this.btnRecalculateHPP);
            this.Controls.Add(this.gcFilter);
            this.Name = "HPPListControl";
            this.Size = new System.Drawing.Size(834, 472);
            ((System.ComponentModel.ISupportInitialize)(this.gcFilter)).EndInit();
            this.gcFilter.ResumeLayout(false);
            this.gcFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboYear.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupMonth.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridHPP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvHPP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker bgwMain;
        private System.ComponentModel.BackgroundWorker bgwRecalculate;
        private DevExpress.XtraEditors.GroupControl gcFilter;
        private DevExpress.XtraEditors.ComboBoxEdit comboYear;
        private DevExpress.XtraEditors.LabelControl lblFilterYear;
        private DevExpress.XtraEditors.LookUpEdit lookupMonth;
        private DevExpress.XtraEditors.LabelControl lblFilterMonth;
        private DevExpress.XtraEditors.SimpleButton btnRecalculateHPP;
        private DevExpress.XtraGrid.GridControl gridHPP;
        private DevExpress.XtraGrid.Views.Grid.GridView gvHPP;
        private DevExpress.XtraGrid.Columns.GridColumn colJournalCode;
        private DevExpress.XtraGrid.Columns.GridColumn colJournalName;
        private DevExpress.XtraGrid.Columns.GridColumn colBaseAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colServiceAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colTotal;
    }
}
