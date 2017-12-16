namespace BrawijayaWorkshop.Win32App.ModulForms
{
    partial class VehicleWheelSwapForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VehicleWheelSwapForm));
            this.LookUpVehicle1 = new DevExpress.XtraEditors.LookUpEdit();
            this.btnMoveRight = new DevExpress.XtraEditors.SimpleButton();
            this.LookUpVehicle2 = new DevExpress.XtraEditors.LookUpEdit();
            this.btnMoveAllRight = new DevExpress.XtraEditors.SimpleButton();
            this.lblVehicle1 = new DevExpress.XtraEditors.LabelControl();
            this.btnMoveLeft = new DevExpress.XtraEditors.SimpleButton();
            this.lbxVehicleWheel1 = new System.Windows.Forms.ListBox();
            this.btnMoveAllLeft = new DevExpress.XtraEditors.SimpleButton();
            this.lblVehicle2 = new DevExpress.XtraEditors.LabelControl();
            this.lbxVehicleWheel2 = new System.Windows.Forms.ListBox();
            this.gcVehicleInfo = new DevExpress.XtraEditors.GroupControl();
            this.bgwSave = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpVehicle1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpVehicle2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcVehicleInfo)).BeginInit();
            this.gcVehicleInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // LookUpVehicle1
            // 
            this.LookUpVehicle1.Location = new System.Drawing.Point(12, 42);
            this.LookUpVehicle1.Name = "LookUpVehicle1";
            this.LookUpVehicle1.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.LookUpVehicle1.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.LookUpVehicle1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LookUpVehicle1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ActiveLicenseNumber", "Nopol"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("VehicleGroupName", "Kelompok"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Kode"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kilometers", "Kilometer"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CompanyName", "Customer")});
            this.LookUpVehicle1.Properties.DisplayMember = "ActiveLicenseNumber";
            this.LookUpVehicle1.Properties.HideSelection = false;
            this.LookUpVehicle1.Properties.NullText = "-- Pilih Kendaraan --";
            this.LookUpVehicle1.Properties.ValueMember = "Id";
            this.LookUpVehicle1.Size = new System.Drawing.Size(429, 20);
            this.LookUpVehicle1.TabIndex = 3;
            this.LookUpVehicle1.EditValueChanged += new System.EventHandler(this.LookUpVehicle1_EditValueChanged);
            // 
            // btnMoveRight
            // 
            this.btnMoveRight.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnMoveRight.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnMoveRight.Location = new System.Drawing.Point(447, 114);
            this.btnMoveRight.Name = "btnMoveRight";
            this.btnMoveRight.Size = new System.Drawing.Size(33, 25);
            this.btnMoveRight.TabIndex = 53;
            this.btnMoveRight.Text = ">";
            this.btnMoveRight.Click += new System.EventHandler(this.btnMoveRight_Click);
            // 
            // LookUpVehicle2
            // 
            this.LookUpVehicle2.Location = new System.Drawing.Point(486, 42);
            this.LookUpVehicle2.Name = "LookUpVehicle2";
            this.LookUpVehicle2.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.LookUpVehicle2.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.LookUpVehicle2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LookUpVehicle2.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ActiveLicenseNumber", "Nopol"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("VehicleGroupName", "Kelompok"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Kode"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kilometers", "Kilometer"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CompanyName", "Customer")});
            this.LookUpVehicle2.Properties.DisplayMember = "ActiveLicenseNumber";
            this.LookUpVehicle2.Properties.HideSelection = false;
            this.LookUpVehicle2.Properties.NullText = "-- Pilih Kendaraan --";
            this.LookUpVehicle2.Properties.ValueMember = "Id";
            this.LookUpVehicle2.Size = new System.Drawing.Size(429, 20);
            this.LookUpVehicle2.TabIndex = 3;
            this.LookUpVehicle2.EditValueChanged += new System.EventHandler(this.LookUpVehicle2_EditValueChanged);
            // 
            // btnMoveAllRight
            // 
            this.btnMoveAllRight.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnMoveAllRight.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnMoveAllRight.Location = new System.Drawing.Point(447, 154);
            this.btnMoveAllRight.Name = "btnMoveAllRight";
            this.btnMoveAllRight.Size = new System.Drawing.Size(33, 25);
            this.btnMoveAllRight.TabIndex = 54;
            this.btnMoveAllRight.Text = ">>";
            this.btnMoveAllRight.Click += new System.EventHandler(this.btnMoveAllRight_Click);
            // 
            // lblVehicle1
            // 
            this.lblVehicle1.Location = new System.Drawing.Point(12, 23);
            this.lblVehicle1.Name = "lblVehicle1";
            this.lblVehicle1.Size = new System.Drawing.Size(61, 13);
            this.lblVehicle1.TabIndex = 2;
            this.lblVehicle1.Text = "Kendaraan 1";
            // 
            // btnMoveLeft
            // 
            this.btnMoveLeft.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnMoveLeft.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnMoveLeft.Location = new System.Drawing.Point(447, 198);
            this.btnMoveLeft.Name = "btnMoveLeft";
            this.btnMoveLeft.Size = new System.Drawing.Size(33, 25);
            this.btnMoveLeft.TabIndex = 55;
            this.btnMoveLeft.Text = "<";
            this.btnMoveLeft.Click += new System.EventHandler(this.btnMoveLeft_Click);
            // 
            // lbxVehicleWheel1
            // 
            this.lbxVehicleWheel1.FormattingEnabled = true;
            this.lbxVehicleWheel1.Location = new System.Drawing.Point(12, 69);
            this.lbxVehicleWheel1.Name = "lbxVehicleWheel1";
            this.lbxVehicleWheel1.Size = new System.Drawing.Size(429, 264);
            this.lbxVehicleWheel1.TabIndex = 57;
            // 
            // btnMoveAllLeft
            // 
            this.btnMoveAllLeft.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnMoveAllLeft.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnMoveAllLeft.Location = new System.Drawing.Point(447, 243);
            this.btnMoveAllLeft.Name = "btnMoveAllLeft";
            this.btnMoveAllLeft.Size = new System.Drawing.Size(33, 25);
            this.btnMoveAllLeft.TabIndex = 56;
            this.btnMoveAllLeft.Text = "<<";
            this.btnMoveAllLeft.Click += new System.EventHandler(this.btnMoveAllLeft_Click);
            // 
            // lblVehicle2
            // 
            this.lblVehicle2.Location = new System.Drawing.Point(486, 23);
            this.lblVehicle2.Name = "lblVehicle2";
            this.lblVehicle2.Size = new System.Drawing.Size(61, 13);
            this.lblVehicle2.TabIndex = 2;
            this.lblVehicle2.Text = "Kendaraan 2";
            // 
            // lbxVehicleWheel2
            // 
            this.lbxVehicleWheel2.FormattingEnabled = true;
            this.lbxVehicleWheel2.Location = new System.Drawing.Point(486, 69);
            this.lbxVehicleWheel2.Name = "lbxVehicleWheel2";
            this.lbxVehicleWheel2.Size = new System.Drawing.Size(429, 264);
            this.lbxVehicleWheel2.TabIndex = 58;
            // 
            // gcVehicleInfo
            // 
            this.gcVehicleInfo.Controls.Add(this.lbxVehicleWheel2);
            this.gcVehicleInfo.Controls.Add(this.lblVehicle2);
            this.gcVehicleInfo.Controls.Add(this.btnMoveAllLeft);
            this.gcVehicleInfo.Controls.Add(this.lbxVehicleWheel1);
            this.gcVehicleInfo.Controls.Add(this.btnMoveLeft);
            this.gcVehicleInfo.Controls.Add(this.lblVehicle1);
            this.gcVehicleInfo.Controls.Add(this.btnMoveAllRight);
            this.gcVehicleInfo.Controls.Add(this.LookUpVehicle2);
            this.gcVehicleInfo.Controls.Add(this.btnMoveRight);
            this.gcVehicleInfo.Controls.Add(this.LookUpVehicle1);
            this.gcVehicleInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcVehicleInfo.Location = new System.Drawing.Point(0, 0);
            this.gcVehicleInfo.Name = "gcVehicleInfo";
            this.gcVehicleInfo.Size = new System.Drawing.Size(927, 347);
            this.gcVehicleInfo.TabIndex = 1;
            this.gcVehicleInfo.Text = "Pindah Ban Kendaraan";
            // 
            // bgwSave
            // 
            this.bgwSave.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwSave_DoWork);
            this.bgwSave.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwSave_RunWorkerCompleted);
            // 
            // VehicleWheelSwapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 396);
            this.Controls.Add(this.gcVehicleInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "VehicleWheelSwapForm";
            this.Text = "Tukar Ban Kendaraan";
            this.Load += new System.EventHandler(this.VehicleWheelSwapForm_Load);
            this.Controls.SetChildIndex(this.gcVehicleInfo, 0);
            ((System.ComponentModel.ISupportInitialize)(this.LookUpVehicle1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpVehicle2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcVehicleInfo)).EndInit();
            this.gcVehicleInfo.ResumeLayout(false);
            this.gcVehicleInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LookUpEdit LookUpVehicle1;
        private DevExpress.XtraEditors.SimpleButton btnMoveRight;
        private DevExpress.XtraEditors.LookUpEdit LookUpVehicle2;
        private DevExpress.XtraEditors.SimpleButton btnMoveAllRight;
        private DevExpress.XtraEditors.LabelControl lblVehicle1;
        private DevExpress.XtraEditors.SimpleButton btnMoveLeft;
        private System.Windows.Forms.ListBox lbxVehicleWheel1;
        private DevExpress.XtraEditors.SimpleButton btnMoveAllLeft;
        private DevExpress.XtraEditors.LabelControl lblVehicle2;
        private System.Windows.Forms.ListBox lbxVehicleWheel2;
        private DevExpress.XtraEditors.GroupControl gcVehicleInfo;
        private System.ComponentModel.BackgroundWorker bgwSave;


    }
}