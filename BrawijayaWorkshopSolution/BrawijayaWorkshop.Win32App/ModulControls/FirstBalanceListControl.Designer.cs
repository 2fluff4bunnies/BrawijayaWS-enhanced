namespace BrawijayaWorkshop.Win32App.ModulControls
{
    partial class FirstBalanceListControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FirstBalanceListControl));
            this.btnNewData = new DevExpress.XtraEditors.SimpleButton();
            this.gcFirstBalance = new DevExpress.XtraEditors.GroupControl();
            this.txtMonthYear = new DevExpress.XtraEditors.LabelControl();
            this.lblMonth = new DevExpress.XtraEditors.LabelControl();
            this.gridFirstBalance = new DevExpress.XtraGrid.GridControl();
            this.gvFirstBalance = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnEditData = new DevExpress.XtraEditors.SimpleButton();
            this.bgwMain = new System.ComponentModel.BackgroundWorker();
            this.btnDeleteData = new DevExpress.XtraEditors.SimpleButton();
            this.colJournalCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colJournalName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastDebit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastCredit = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gcFirstBalance)).BeginInit();
            this.gcFirstBalance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridFirstBalance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvFirstBalance)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNewData
            // 
            this.btnNewData.Image = ((System.Drawing.Image)(resources.GetObject("btnNewData.Image")));
            this.btnNewData.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnNewData.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnNewData.Location = new System.Drawing.Point(3, 3);
            this.btnNewData.Name = "btnNewData";
            this.btnNewData.Size = new System.Drawing.Size(144, 23);
            this.btnNewData.TabIndex = 3;
            this.btnNewData.Text = "Tambah Saldo Awal";
            this.btnNewData.Click += new System.EventHandler(this.btnNewData_Click);
            // 
            // gcFirstBalance
            // 
            this.gcFirstBalance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcFirstBalance.Controls.Add(this.txtMonthYear);
            this.gcFirstBalance.Controls.Add(this.lblMonth);
            this.gcFirstBalance.Location = new System.Drawing.Point(3, 32);
            this.gcFirstBalance.Name = "gcFirstBalance";
            this.gcFirstBalance.Size = new System.Drawing.Size(846, 58);
            this.gcFirstBalance.TabIndex = 4;
            this.gcFirstBalance.Text = "Informasi Saldo Awal";
            // 
            // txtMonthYear
            // 
            this.txtMonthYear.Location = new System.Drawing.Point(101, 31);
            this.txtMonthYear.Name = "txtMonthYear";
            this.txtMonthYear.Size = new System.Drawing.Size(16, 13);
            this.txtMonthYear.TabIndex = 1;
            this.txtMonthYear.Text = "{0}";
            // 
            // lblMonth
            // 
            this.lblMonth.Location = new System.Drawing.Point(12, 31);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(70, 13);
            this.lblMonth.TabIndex = 0;
            this.lblMonth.Text = "Bulan / Tahun:";
            // 
            // gridFirstBalance
            // 
            this.gridFirstBalance.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridFirstBalance.Location = new System.Drawing.Point(3, 96);
            this.gridFirstBalance.MainView = this.gvFirstBalance;
            this.gridFirstBalance.Name = "gridFirstBalance";
            this.gridFirstBalance.Size = new System.Drawing.Size(846, 346);
            this.gridFirstBalance.TabIndex = 5;
            this.gridFirstBalance.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvFirstBalance});
            // 
            // gvFirstBalance
            // 
            this.gvFirstBalance.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colJournalCode,
            this.colJournalName,
            this.colLastDebit,
            this.colLastCredit});
            this.gvFirstBalance.GridControl = this.gridFirstBalance;
            this.gvFirstBalance.Name = "gvFirstBalance";
            this.gvFirstBalance.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvFirstBalance.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvFirstBalance.OptionsBehavior.AutoPopulateColumns = false;
            this.gvFirstBalance.OptionsBehavior.Editable = false;
            this.gvFirstBalance.OptionsBehavior.ReadOnly = true;
            this.gvFirstBalance.OptionsCustomization.AllowColumnMoving = false;
            this.gvFirstBalance.OptionsCustomization.AllowFilter = false;
            this.gvFirstBalance.OptionsCustomization.AllowGroup = false;
            this.gvFirstBalance.OptionsCustomization.AllowQuickHideColumns = false;
            this.gvFirstBalance.OptionsView.EnableAppearanceEvenRow = true;
            this.gvFirstBalance.OptionsView.ShowGroupPanel = false;
            this.gvFirstBalance.OptionsView.ShowViewCaption = true;
            this.gvFirstBalance.ViewCaption = "Detail Saldo Awal";
            // 
            // btnEditData
            // 
            this.btnEditData.Image = global::BrawijayaWorkshop.Win32App.Properties.Resources.edit_icon;
            this.btnEditData.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnEditData.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnEditData.Location = new System.Drawing.Point(168, 3);
            this.btnEditData.Name = "btnEditData";
            this.btnEditData.Size = new System.Drawing.Size(144, 23);
            this.btnEditData.TabIndex = 6;
            this.btnEditData.Text = "Revisi Saldo Awal";
            this.btnEditData.Click += new System.EventHandler(this.btnEditData_Click);
            // 
            // bgwMain
            // 
            this.bgwMain.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwMain_DoWork);
            this.bgwMain.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwMain_RunWorkerCompleted);
            // 
            // btnDeleteData
            // 
            this.btnDeleteData.Image = global::BrawijayaWorkshop.Win32App.Properties.Resources.delete_icon;
            this.btnDeleteData.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnDeleteData.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnDeleteData.Location = new System.Drawing.Point(333, 3);
            this.btnDeleteData.Name = "btnDeleteData";
            this.btnDeleteData.Size = new System.Drawing.Size(144, 23);
            this.btnDeleteData.TabIndex = 7;
            this.btnDeleteData.Text = "Hapus Saldo Awal";
            this.btnDeleteData.Click += new System.EventHandler(this.btnDeleteData_Click);
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
            // colLastDebit
            // 
            this.colLastDebit.Caption = "Debet";
            this.colLastDebit.FieldName = "LastDebit";
            this.colLastDebit.Name = "colLastDebit";
            this.colLastDebit.Visible = true;
            this.colLastDebit.VisibleIndex = 2;
            // 
            // colLastCredit
            // 
            this.colLastCredit.Caption = "Kredit";
            this.colLastCredit.FieldName = "LastCredit";
            this.colLastCredit.Name = "colLastCredit";
            this.colLastCredit.Visible = true;
            this.colLastCredit.VisibleIndex = 3;
            // 
            // FirstBalanceListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDeleteData);
            this.Controls.Add(this.btnEditData);
            this.Controls.Add(this.gridFirstBalance);
            this.Controls.Add(this.gcFirstBalance);
            this.Controls.Add(this.btnNewData);
            this.Name = "FirstBalanceListControl";
            this.Size = new System.Drawing.Size(852, 445);
            ((System.ComponentModel.ISupportInitialize)(this.gcFirstBalance)).EndInit();
            this.gcFirstBalance.ResumeLayout(false);
            this.gcFirstBalance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridFirstBalance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvFirstBalance)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnNewData;
        private DevExpress.XtraEditors.GroupControl gcFirstBalance;
        private DevExpress.XtraEditors.LabelControl txtMonthYear;
        private DevExpress.XtraEditors.LabelControl lblMonth;
        private DevExpress.XtraGrid.GridControl gridFirstBalance;
        private DevExpress.XtraGrid.Views.Grid.GridView gvFirstBalance;
        private DevExpress.XtraEditors.SimpleButton btnEditData;
        private System.ComponentModel.BackgroundWorker bgwMain;
        private DevExpress.XtraEditors.SimpleButton btnDeleteData;
        private DevExpress.XtraGrid.Columns.GridColumn colJournalCode;
        private DevExpress.XtraGrid.Columns.GridColumn colJournalName;
        private DevExpress.XtraGrid.Columns.GridColumn colLastDebit;
        private DevExpress.XtraGrid.Columns.GridColumn colLastCredit;
    }
}
