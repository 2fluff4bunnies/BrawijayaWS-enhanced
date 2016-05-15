namespace BrawijayaWorkshop.Win32App.ModulForms
{
    partial class VehicleGroupEditorForm
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
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VehicleGroupEditorForm));
            this.gcVehicleGroup = new DevExpress.XtraEditors.GroupControl();
            this.txtGroupName = new DevExpress.XtraEditors.TextEdit();
            this.lblGroupName = new DevExpress.XtraEditors.LabelControl();
            this.lookupCustomer = new DevExpress.XtraEditors.LookUpEdit();
            this.lblCustomer = new DevExpress.XtraEditors.LabelControl();
            this.valCustomer = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.valName = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gcVehicleGroup)).BeginInit();
            this.gcVehicleGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtGroupName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupCustomer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valName)).BeginInit();
            this.SuspendLayout();
            // 
            // gcVehicleGroup
            // 
            this.gcVehicleGroup.Controls.Add(this.txtGroupName);
            this.gcVehicleGroup.Controls.Add(this.lblGroupName);
            this.gcVehicleGroup.Controls.Add(this.lookupCustomer);
            this.gcVehicleGroup.Controls.Add(this.lblCustomer);
            this.gcVehicleGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcVehicleGroup.Location = new System.Drawing.Point(0, 0);
            this.gcVehicleGroup.Name = "gcVehicleGroup";
            this.gcVehicleGroup.Size = new System.Drawing.Size(390, 100);
            this.gcVehicleGroup.TabIndex = 1;
            this.gcVehicleGroup.Text = "Informasi Kelompok";
            // 
            // txtGroupName
            // 
            this.txtGroupName.Location = new System.Drawing.Point(111, 66);
            this.txtGroupName.Name = "txtGroupName";
            this.txtGroupName.Size = new System.Drawing.Size(265, 20);
            this.txtGroupName.TabIndex = 3;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "Nama Kelompok harus diisi!";
            this.valName.SetValidationRule(this.txtGroupName, conditionValidationRule1);
            // 
            // lblGroupName
            // 
            this.lblGroupName.Location = new System.Drawing.Point(14, 69);
            this.lblGroupName.Name = "lblGroupName";
            this.lblGroupName.Size = new System.Drawing.Size(75, 13);
            this.lblGroupName.TabIndex = 2;
            this.lblGroupName.Text = "Nama Kelompok";
            // 
            // lookupCustomer
            // 
            this.lookupCustomer.Location = new System.Drawing.Point(111, 30);
            this.lookupCustomer.Name = "lookupCustomer";
            this.lookupCustomer.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.lookupCustomer.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookupCustomer.Properties.HideSelection = false;
            this.lookupCustomer.Properties.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned;
            this.lookupCustomer.Properties.NullText = "-- Pilih Customer --";
            this.lookupCustomer.Size = new System.Drawing.Size(265, 20);
            this.lookupCustomer.TabIndex = 1;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.NotEquals;
            conditionValidationRule2.ErrorText = "Pilih Customer";
            conditionValidationRule2.Value1 = "-- Pilih Customer --";
            this.valCustomer.SetValidationRule(this.lookupCustomer, conditionValidationRule2);
            // 
            // lblCustomer
            // 
            this.lblCustomer.Location = new System.Drawing.Point(14, 33);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(46, 13);
            this.lblCustomer.TabIndex = 0;
            this.lblCustomer.Text = "Customer";
            // 
            // VehicleGroupEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 149);
            this.Controls.Add(this.gcVehicleGroup);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VehicleGroupEditorForm";
            this.Text = "Kelompok Editor";
            this.Controls.SetChildIndex(this.gcVehicleGroup, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gcVehicleGroup)).EndInit();
            this.gcVehicleGroup.ResumeLayout(false);
            this.gcVehicleGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtGroupName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupCustomer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valName)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gcVehicleGroup;
        private DevExpress.XtraEditors.TextEdit txtGroupName;
        private DevExpress.XtraEditors.LabelControl lblGroupName;
        private DevExpress.XtraEditors.LookUpEdit lookupCustomer;
        private DevExpress.XtraEditors.LabelControl lblCustomer;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider valCustomer;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider valName;
    }
}