namespace BrawijayaWorkshop.Win32App.ModulControls
{
    partial class ManageUserListControl
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
            this.gcFilter = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.gcFilter)).BeginInit();
            this.SuspendLayout();
            // 
            // gcFilter
            // 
            this.gcFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcFilter.Location = new System.Drawing.Point(3, 3);
            this.gcFilter.Name = "gcFilter";
            this.gcFilter.Size = new System.Drawing.Size(816, 83);
            this.gcFilter.TabIndex = 0;
            this.gcFilter.Text = "Filter";
            // 
            // ManageUserListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gcFilter);
            this.Name = "ManageUserListControl";
            this.Size = new System.Drawing.Size(822, 394);
            ((System.ComponentModel.ISupportInitialize)(this.gcFilter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gcFilter;
    }
}
