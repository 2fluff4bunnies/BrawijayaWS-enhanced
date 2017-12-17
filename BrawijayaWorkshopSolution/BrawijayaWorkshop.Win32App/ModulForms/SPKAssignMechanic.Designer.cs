namespace BrawijayaWorkshop.Win32App.ModulForms
{
    partial class SPKAssignMechanic
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
            this.groupControl = new DevExpress.XtraEditors.GroupControl();
            this.lbxSelectedMechanics = new System.Windows.Forms.ListBox();
            this.lbxMechanics = new System.Windows.Forms.ListBox();
            this.lblDate = new DevExpress.XtraEditors.LabelControl();
            this.dtpDate = new DevExpress.XtraEditors.DateEdit();
            this.txtDescription = new DevExpress.XtraEditors.MemoEdit();
            this.lblDescription = new DevExpress.XtraEditors.LabelControl();
            this.btnMoveAllLeft = new DevExpress.XtraEditors.SimpleButton();
            this.btnMoveLeft = new DevExpress.XtraEditors.SimpleButton();
            this.btnMoveAllRight = new DevExpress.XtraEditors.SimpleButton();
            this.btnMoveRight = new DevExpress.XtraEditors.SimpleButton();
            this.bgwFingerPrint = new System.ComponentModel.BackgroundWorker();
            this.ckeGetFingerPrint = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl)).BeginInit();
            this.groupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckeGetFingerPrint.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl
            // 
            this.groupControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl.Controls.Add(this.ckeGetFingerPrint);
            this.groupControl.Controls.Add(this.lbxSelectedMechanics);
            this.groupControl.Controls.Add(this.lbxMechanics);
            this.groupControl.Controls.Add(this.lblDate);
            this.groupControl.Controls.Add(this.dtpDate);
            this.groupControl.Controls.Add(this.txtDescription);
            this.groupControl.Controls.Add(this.lblDescription);
            this.groupControl.Controls.Add(this.btnMoveAllLeft);
            this.groupControl.Controls.Add(this.btnMoveLeft);
            this.groupControl.Controls.Add(this.btnMoveAllRight);
            this.groupControl.Controls.Add(this.btnMoveRight);
            this.groupControl.Location = new System.Drawing.Point(0, 0);
            this.groupControl.Name = "groupControl";
            this.groupControl.Size = new System.Drawing.Size(441, 391);
            this.groupControl.TabIndex = 0;
            this.groupControl.Text = "Mekanik";
            // 
            // lbxSelectedMechanics
            // 
            this.lbxSelectedMechanics.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbxSelectedMechanics.FormattingEnabled = true;
            this.lbxSelectedMechanics.Location = new System.Drawing.Point(249, 49);
            this.lbxSelectedMechanics.Name = "lbxSelectedMechanics";
            this.lbxSelectedMechanics.Size = new System.Drawing.Size(180, 212);
            this.lbxSelectedMechanics.TabIndex = 52;
            // 
            // lbxMechanics
            // 
            this.lbxMechanics.FormattingEnabled = true;
            this.lbxMechanics.Location = new System.Drawing.Point(12, 49);
            this.lbxMechanics.Name = "lbxMechanics";
            this.lbxMechanics.Size = new System.Drawing.Size(180, 212);
            this.lbxMechanics.TabIndex = 51;
            // 
            // lblDate
            // 
            this.lblDate.Location = new System.Drawing.Point(13, 26);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(66, 13);
            this.lblDate.TabIndex = 50;
            this.lblDate.Text = "Tanggal Kerja";
            // 
            // dtpDate
            // 
            this.dtpDate.EditValue = null;
            this.dtpDate.Location = new System.Drawing.Point(94, 23);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.dtpDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpDate.Properties.DisplayFormat.FormatString = "dd-MM-yyyy";
            this.dtpDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpDate.Properties.Mask.EditMask = "dd-MM-yyyy";
            this.dtpDate.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.dtpDate.Size = new System.Drawing.Size(98, 20);
            this.dtpDate.TabIndex = 49;
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.Location = new System.Drawing.Point(12, 291);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(417, 89);
            this.txtDescription.TabIndex = 46;
            // 
            // lblDescription
            // 
            this.lblDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescription.Location = new System.Drawing.Point(12, 272);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(56, 13);
            this.lblDescription.TabIndex = 45;
            this.lblDescription.Text = "Keterangan";
            // 
            // btnMoveAllLeft
            // 
            this.btnMoveAllLeft.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnMoveAllLeft.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnMoveAllLeft.Location = new System.Drawing.Point(208, 213);
            this.btnMoveAllLeft.Name = "btnMoveAllLeft";
            this.btnMoveAllLeft.Size = new System.Drawing.Size(25, 25);
            this.btnMoveAllLeft.TabIndex = 43;
            this.btnMoveAllLeft.Text = "<<";
            this.btnMoveAllLeft.Click += new System.EventHandler(this.btnMoveAllLeft_Click);
            // 
            // btnMoveLeft
            // 
            this.btnMoveLeft.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnMoveLeft.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnMoveLeft.Location = new System.Drawing.Point(207, 173);
            this.btnMoveLeft.Name = "btnMoveLeft";
            this.btnMoveLeft.Size = new System.Drawing.Size(25, 25);
            this.btnMoveLeft.TabIndex = 42;
            this.btnMoveLeft.Text = "<";
            this.btnMoveLeft.Click += new System.EventHandler(this.btnMoveLeft_Click);
            // 
            // btnMoveAllRight
            // 
            this.btnMoveAllRight.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnMoveAllRight.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnMoveAllRight.Location = new System.Drawing.Point(207, 130);
            this.btnMoveAllRight.Name = "btnMoveAllRight";
            this.btnMoveAllRight.Size = new System.Drawing.Size(25, 25);
            this.btnMoveAllRight.TabIndex = 41;
            this.btnMoveAllRight.Text = ">>";
            this.btnMoveAllRight.Click += new System.EventHandler(this.btnMoveAllRight_Click);
            // 
            // btnMoveRight
            // 
            this.btnMoveRight.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnMoveRight.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnMoveRight.Location = new System.Drawing.Point(207, 87);
            this.btnMoveRight.Name = "btnMoveRight";
            this.btnMoveRight.Size = new System.Drawing.Size(25, 25);
            this.btnMoveRight.TabIndex = 40;
            this.btnMoveRight.Text = ">";
            this.btnMoveRight.Click += new System.EventHandler(this.btnMoveRight_Click);
            // 
            // bgwFingerPrint
            // 
            this.bgwFingerPrint.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwFingerPrint_DoWork);
            this.bgwFingerPrint.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwFingerPrint_RunWorkerCompleted);
            // 
            // ckeGetFingerPrint
            // 
            this.ckeGetFingerPrint.Location = new System.Drawing.Point(249, 26);
            this.ckeGetFingerPrint.Name = "ckeGetFingerPrint";
            this.ckeGetFingerPrint.Properties.Caption = "Ambil data dari finger print";
            this.ckeGetFingerPrint.Size = new System.Drawing.Size(180, 19);
            this.ckeGetFingerPrint.TabIndex = 53;
            this.ckeGetFingerPrint.CheckedChanged += new System.EventHandler(this.ckeGetFingerPrint_CheckedChanged);
            // 
            // SPKAssignMechanic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 429);
            this.Controls.Add(this.groupControl);
            this.Name = "SPKAssignMechanic";
            this.Text = "SPK Penugasan Mekanik";
            this.Controls.SetChildIndex(this.groupControl, 0);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl)).EndInit();
            this.groupControl.ResumeLayout(false);
            this.groupControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckeGetFingerPrint.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl;
        private DevExpress.XtraEditors.SimpleButton btnMoveAllLeft;
        private DevExpress.XtraEditors.SimpleButton btnMoveLeft;
        private DevExpress.XtraEditors.SimpleButton btnMoveAllRight;
        private DevExpress.XtraEditors.SimpleButton btnMoveRight;
        private DevExpress.XtraEditors.LabelControl lblDescription;
        private DevExpress.XtraEditors.MemoEdit txtDescription;
        private DevExpress.XtraEditors.LabelControl lblDate;
        private DevExpress.XtraEditors.DateEdit dtpDate;
        private System.ComponentModel.BackgroundWorker bgwFingerPrint;
        private System.Windows.Forms.ListBox lbxSelectedMechanics;
        private System.Windows.Forms.ListBox lbxMechanics;
        private DevExpress.XtraEditors.CheckEdit ckeGetFingerPrint;
    }
}