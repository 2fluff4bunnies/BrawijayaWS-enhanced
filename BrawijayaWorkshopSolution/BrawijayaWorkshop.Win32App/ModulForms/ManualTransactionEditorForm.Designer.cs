﻿namespace BrawijayaWorkshop.Win32App.ModulForms
{
    partial class ManualTransactionEditorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManualTransactionEditorForm));
            this.gcTransactionParent = new DevExpress.XtraEditors.GroupControl();
            this.txtTransTotal = new DevExpress.XtraEditors.TextEdit();
            this.lblTransTotal = new DevExpress.XtraEditors.LabelControl();
            this.txtTransDesc = new DevExpress.XtraEditors.MemoEdit();
            this.lblTransDesc = new DevExpress.XtraEditors.LabelControl();
            this.deTransDate = new DevExpress.XtraEditors.DateEdit();
            this.lblTransDate = new DevExpress.XtraEditors.LabelControl();
            this.gcTransactionDetail = new DevExpress.XtraEditors.GroupControl();
            this.gridTransactionDetail = new DevExpress.XtraGrid.GridControl();
            this.gvTransactionDetail = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnNewTransDetail = new DevExpress.XtraEditors.SimpleButton();
            this.cmsEditor = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gcTransactionParent)).BeginInit();
            this.gcTransactionParent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTransTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTransDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deTransDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deTransDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTransactionDetail)).BeginInit();
            this.gcTransactionDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTransactionDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTransactionDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // gcTransactionParent
            // 
            this.gcTransactionParent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcTransactionParent.Controls.Add(this.txtTransTotal);
            this.gcTransactionParent.Controls.Add(this.lblTransTotal);
            this.gcTransactionParent.Controls.Add(this.txtTransDesc);
            this.gcTransactionParent.Controls.Add(this.lblTransDesc);
            this.gcTransactionParent.Controls.Add(this.deTransDate);
            this.gcTransactionParent.Controls.Add(this.lblTransDate);
            this.gcTransactionParent.Location = new System.Drawing.Point(12, 12);
            this.gcTransactionParent.Name = "gcTransactionParent";
            this.gcTransactionParent.Size = new System.Drawing.Size(722, 136);
            this.gcTransactionParent.TabIndex = 1;
            this.gcTransactionParent.Text = "Transaksi";
            // 
            // txtTransTotal
            // 
            this.txtTransTotal.Location = new System.Drawing.Point(494, 29);
            this.txtTransTotal.Name = "txtTransTotal";
            this.txtTransTotal.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtTransTotal.Properties.Appearance.Options.UseBackColor = true;
            this.txtTransTotal.Properties.DisplayFormat.FormatString = "{0:#,#}";
            this.txtTransTotal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtTransTotal.Properties.ReadOnly = true;
            this.txtTransTotal.Size = new System.Drawing.Size(216, 20);
            this.txtTransTotal.TabIndex = 5;
            // 
            // lblTransTotal
            // 
            this.lblTransTotal.Location = new System.Drawing.Point(397, 32);
            this.lblTransTotal.Name = "lblTransTotal";
            this.lblTransTotal.Size = new System.Drawing.Size(72, 13);
            this.lblTransTotal.TabIndex = 4;
            this.lblTransTotal.Text = "Total Transaksi";
            // 
            // txtTransDesc
            // 
            this.txtTransDesc.Location = new System.Drawing.Point(98, 56);
            this.txtTransDesc.Name = "txtTransDesc";
            this.txtTransDesc.Size = new System.Drawing.Size(248, 68);
            this.txtTransDesc.TabIndex = 3;
            // 
            // lblTransDesc
            // 
            this.lblTransDesc.Location = new System.Drawing.Point(12, 58);
            this.lblTransDesc.Name = "lblTransDesc";
            this.lblTransDesc.Size = new System.Drawing.Size(56, 13);
            this.lblTransDesc.TabIndex = 2;
            this.lblTransDesc.Text = "Keterangan";
            // 
            // deTransDate
            // 
            this.deTransDate.EditValue = null;
            this.deTransDate.Location = new System.Drawing.Point(98, 29);
            this.deTransDate.Name = "deTransDate";
            this.deTransDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deTransDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deTransDate.Properties.DisplayFormat.FormatString = "dd MMM yyyy";
            this.deTransDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.deTransDate.Properties.HideSelection = false;
            this.deTransDate.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.deTransDate.Size = new System.Drawing.Size(117, 20);
            this.deTransDate.TabIndex = 1;
            // 
            // lblTransDate
            // 
            this.lblTransDate.Location = new System.Drawing.Point(12, 32);
            this.lblTransDate.Name = "lblTransDate";
            this.lblTransDate.Size = new System.Drawing.Size(66, 13);
            this.lblTransDate.TabIndex = 0;
            this.lblTransDate.Text = "Tgl. Transaksi";
            // 
            // gcTransactionDetail
            // 
            this.gcTransactionDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcTransactionDetail.Controls.Add(this.gridTransactionDetail);
            this.gcTransactionDetail.Controls.Add(this.btnNewTransDetail);
            this.gcTransactionDetail.Location = new System.Drawing.Point(12, 154);
            this.gcTransactionDetail.Name = "gcTransactionDetail";
            this.gcTransactionDetail.Size = new System.Drawing.Size(722, 210);
            this.gcTransactionDetail.TabIndex = 2;
            this.gcTransactionDetail.Text = "Detail Transaksi";
            // 
            // gridTransactionDetail
            // 
            this.gridTransactionDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridTransactionDetail.Location = new System.Drawing.Point(5, 52);
            this.gridTransactionDetail.MainView = this.gvTransactionDetail;
            this.gridTransactionDetail.Name = "gridTransactionDetail";
            this.gridTransactionDetail.Size = new System.Drawing.Size(712, 153);
            this.gridTransactionDetail.TabIndex = 3;
            this.gridTransactionDetail.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvTransactionDetail});
            // 
            // gvTransactionDetail
            // 
            this.gvTransactionDetail.GridControl = this.gridTransactionDetail;
            this.gvTransactionDetail.Name = "gvTransactionDetail";
            this.gvTransactionDetail.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvTransactionDetail.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvTransactionDetail.OptionsBehavior.AutoPopulateColumns = false;
            this.gvTransactionDetail.OptionsBehavior.Editable = false;
            this.gvTransactionDetail.OptionsBehavior.ReadOnly = true;
            this.gvTransactionDetail.OptionsCustomization.AllowColumnMoving = false;
            this.gvTransactionDetail.OptionsCustomization.AllowFilter = false;
            this.gvTransactionDetail.OptionsCustomization.AllowGroup = false;
            this.gvTransactionDetail.OptionsCustomization.AllowQuickHideColumns = false;
            this.gvTransactionDetail.OptionsView.EnableAppearanceEvenRow = true;
            this.gvTransactionDetail.OptionsView.ShowGroupPanel = false;
            this.gvTransactionDetail.OptionsView.ShowViewCaption = true;
            this.gvTransactionDetail.ViewCaption = "Daftar Customer";
            // 
            // btnNewTransDetail
            // 
            this.btnNewTransDetail.Image = ((System.Drawing.Image)(resources.GetObject("btnNewTransDetail.Image")));
            this.btnNewTransDetail.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnNewTransDetail.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnNewTransDetail.Location = new System.Drawing.Point(5, 23);
            this.btnNewTransDetail.Name = "btnNewTransDetail";
            this.btnNewTransDetail.Size = new System.Drawing.Size(171, 23);
            this.btnNewTransDetail.TabIndex = 3;
            this.btnNewTransDetail.Text = "Tambah Detail Transaksi";
            // 
            // cmsEditor
            // 
            this.cmsEditor.Name = "cmsEditor";
            this.cmsEditor.Size = new System.Drawing.Size(61, 4);
            // 
            // ManualTransactionEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 419);
            this.Controls.Add(this.gcTransactionDetail);
            this.Controls.Add(this.gcTransactionParent);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManualTransactionEditorForm";
            this.Text = "Transaksi Manual Editor";
            this.Controls.SetChildIndex(this.gcTransactionParent, 0);
            this.Controls.SetChildIndex(this.gcTransactionDetail, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gcTransactionParent)).EndInit();
            this.gcTransactionParent.ResumeLayout(false);
            this.gcTransactionParent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTransTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTransDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deTransDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deTransDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTransactionDetail)).EndInit();
            this.gcTransactionDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridTransactionDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTransactionDetail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gcTransactionParent;
        private DevExpress.XtraEditors.GroupControl gcTransactionDetail;
        private DevExpress.XtraEditors.LabelControl lblTransDate;
        private DevExpress.XtraEditors.DateEdit deTransDate;
        private DevExpress.XtraEditors.TextEdit txtTransTotal;
        private DevExpress.XtraEditors.LabelControl lblTransTotal;
        private DevExpress.XtraEditors.MemoEdit txtTransDesc;
        private DevExpress.XtraEditors.LabelControl lblTransDesc;
        private DevExpress.XtraEditors.SimpleButton btnNewTransDetail;
        private DevExpress.XtraGrid.GridControl gridTransactionDetail;
        private DevExpress.XtraGrid.Views.Grid.GridView gvTransactionDetail;
        private System.Windows.Forms.ContextMenuStrip cmsEditor;
    }
}