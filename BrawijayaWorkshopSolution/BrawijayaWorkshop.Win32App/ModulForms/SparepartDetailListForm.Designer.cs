namespace BrawijayaWorkshop.Win32App.ModulForms
{
    partial class SparepartDetailListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SparepartDetailListForm));
            this.groupFilter = new DevExpress.XtraEditors.GroupControl();
            this.gridSparepartDetail = new DevExpress.XtraGrid.GridControl();
            this.gvSparepartDetail = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.groupFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSparepartDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSparepartDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // groupFilter
            // 
            this.groupFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupFilter.Location = new System.Drawing.Point(0, 0);
            this.groupFilter.Name = "groupFilter";
            this.groupFilter.Size = new System.Drawing.Size(693, 62);
            this.groupFilter.TabIndex = 0;
            this.groupFilter.Text = "Filter";
            // 
            // gridSparepartDetail
            // 
            this.gridSparepartDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridSparepartDetail.Location = new System.Drawing.Point(0, 62);
            this.gridSparepartDetail.MainView = this.gvSparepartDetail;
            this.gridSparepartDetail.Name = "gridSparepartDetail";
            this.gridSparepartDetail.Size = new System.Drawing.Size(693, 243);
            this.gridSparepartDetail.TabIndex = 1;
            this.gridSparepartDetail.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSparepartDetail});
            // 
            // gvSparepartDetail
            // 
            this.gvSparepartDetail.GridControl = this.gridSparepartDetail;
            this.gvSparepartDetail.Name = "gvSparepartDetail";
            // 
            // SparepartDetailListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 305);
            this.Controls.Add(this.gridSparepartDetail);
            this.Controls.Add(this.groupFilter);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SparepartDetailListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detil Sparepart : {0}";
            ((System.ComponentModel.ISupportInitialize)(this.groupFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSparepartDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSparepartDetail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupFilter;
        private DevExpress.XtraGrid.GridControl gridSparepartDetail;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSparepartDetail;
    }
}