namespace BrawijayaWorkshop.Win32App.ModulForms
{
    partial class VehicleWheelEditorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VehicleWheelEditorForm));
            this.btnUpdateVehicleWheel = new DevExpress.XtraEditors.SimpleButton();
            this.gridWheelDetail = new DevExpress.XtraGrid.GridControl();
            this.gvWheelDetail = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCodeDetail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSerialNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bgwMain = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.gridWheelDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvWheelDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdateVehicleWheel
            // 
            this.btnUpdateVehicleWheel.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateVehicleWheel.Image")));
            this.btnUpdateVehicleWheel.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnUpdateVehicleWheel.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnUpdateVehicleWheel.Location = new System.Drawing.Point(12, 12);
            this.btnUpdateVehicleWheel.Name = "btnUpdateVehicleWheel";
            this.btnUpdateVehicleWheel.Size = new System.Drawing.Size(144, 23);
            this.btnUpdateVehicleWheel.TabIndex = 10;
            this.btnUpdateVehicleWheel.Text = "Update Ban Kendaraan";
            this.btnUpdateVehicleWheel.Click += new System.EventHandler(this.btnUpdateVehicleWheel_Click);
            // 
            // gridWheelDetail
            // 
            this.gridWheelDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridWheelDetail.Location = new System.Drawing.Point(12, 41);
            this.gridWheelDetail.MainView = this.gvWheelDetail;
            this.gridWheelDetail.Name = "gridWheelDetail";
            this.gridWheelDetail.Size = new System.Drawing.Size(528, 237);
            this.gridWheelDetail.TabIndex = 11;
            this.gridWheelDetail.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvWheelDetail});
            // 
            // gvWheelDetail
            // 
            this.gvWheelDetail.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCodeDetail,
            this.colSerialNumber});
            this.gvWheelDetail.GridControl = this.gridWheelDetail;
            this.gvWheelDetail.Name = "gvWheelDetail";
            this.gvWheelDetail.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvWheelDetail.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvWheelDetail.OptionsBehavior.AutoPopulateColumns = false;
            this.gvWheelDetail.OptionsBehavior.Editable = false;
            this.gvWheelDetail.OptionsBehavior.ReadOnly = true;
            this.gvWheelDetail.OptionsCustomization.AllowColumnMoving = false;
            this.gvWheelDetail.OptionsCustomization.AllowQuickHideColumns = false;
            this.gvWheelDetail.OptionsMenu.EnableFooterMenu = false;
            this.gvWheelDetail.OptionsView.EnableAppearanceEvenRow = true;
            this.gvWheelDetail.OptionsView.ShowFooter = true;
            this.gvWheelDetail.OptionsView.ShowGroupPanel = false;
            this.gvWheelDetail.OptionsView.ShowViewCaption = true;
            this.gvWheelDetail.ViewCaption = "Daftar Ban Satuan";
            // 
            // colCodeDetail
            // 
            this.colCodeDetail.Caption = "Kode";
            this.colCodeDetail.FieldName = "Code";
            this.colCodeDetail.Name = "colCodeDetail";
            this.colCodeDetail.Visible = true;
            this.colCodeDetail.VisibleIndex = 0;
            // 
            // colSerialNumber
            // 
            this.colSerialNumber.Caption = "Nomor Seri";
            this.colSerialNumber.Name = "colSerialNumber";
            this.colSerialNumber.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "", "Jumlah Data: {0}")});
            this.colSerialNumber.Visible = true;
            this.colSerialNumber.VisibleIndex = 1;
            // 
            // VehicleWheelEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 283);
            this.Controls.Add(this.gridWheelDetail);
            this.Controls.Add(this.btnUpdateVehicleWheel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VehicleWheelEditorForm";
            this.Text = "Editor Ban Kendaraan";
            ((System.ComponentModel.ISupportInitialize)(this.gridWheelDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvWheelDetail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnUpdateVehicleWheel;
        private DevExpress.XtraGrid.GridControl gridWheelDetail;
        private DevExpress.XtraGrid.Views.Grid.GridView gvWheelDetail;
        private DevExpress.XtraGrid.Columns.GridColumn colCodeDetail;
        private DevExpress.XtraGrid.Columns.GridColumn colSerialNumber;
        private System.ComponentModel.BackgroundWorker bgwMain;
    }
}