﻿using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.Presenter;
using BrawijayaWorkshop.Utils;
using BrawijayaWorkshop.View;
using BrawijayaWorkshop.Win32App.ModulForms;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Windows.Forms;

namespace BrawijayaWorkshop.Win32App.ModulControls
{
    public partial class SPKListControl : BaseAppUserControl, ISPKListView
    {
        private SPKListPresenter _presenter;
        private SPK _selectedSPK;

        public SPKListControl(SPKListModel model)
        {
            InitializeComponent();

            _presenter = new SPKListPresenter(this, model);

            gvSPK.FocusedRowChanged += gvSPK_FocusedRowChanged;
            gvSPK.PopupMenuShowing += gvSPK_PopupMenuShowing;

            // init editor control accessibility
            btnNewSPK.Enabled = AllowInsert;
            cmsEditData.Enabled = AllowEdit;
            cmsDeleteData.Enabled = AllowDelete;

            this.Load += SPKListControl_Load;

            //by default pending spk will displayed
            this.StatusFilter = 0;
        }

        protected override string ModulName
        {
            get
            {
                return DbConstant.MODUL_SPK;
            }
        }

        #region Filter Fields
        public int StatusFilter
        {
            get
            {
                return lookUpStatus.EditValue.AsInteger();
            }
            set
            {
                lookUpStatus.EditValue = value;
            }
        }

        public string CodeFilter
        {
            get
            {
                return txtCode.Text;
            }
            set
            {
                txtCode.Text = value;
            }
        }

        public DateTime? CreateDateFilter
        {
            get
            {
                if (string.IsNullOrEmpty(dtpCreateDate.Text))
                {
                    return null;
                }
                else
                {
                    return dtpCreateDate.Text.AsDateTime();
                }
            }
            set
            {
                dtpCreateDate.Text = value.ToString();
            }
        }

        public DateTime? DueDateFilter
        {
            get
            {
                if (string.IsNullOrEmpty(dtpDueDate.Text))
                {
                    return null;
                }
                else
                {
                    return dtpDueDate.Text.AsDateTime();
                }
            }
            set
            {
                dtpDueDate.Text = value.ToString();
            }
        }

        public int CategoryFilter
        {
            get
            {
                return lookUpCategory.EditValue.AsInteger();
            }
            set
            {
                lookUpCategory.EditValue = value;
            }
        }

        public string LicenseNumberFilter
        {
            get
            {
                return txtLicenseNumber.Text;
            }
            set
            {
                txtLicenseNumber.Text = value;
            }
        }

        public List<Reference> CategoryDropdownList
        {
            get
            {
                return lookUpCategory.Properties.DataSource as List<Reference>;
            }
            set
            {
                lookUpCategory.Properties.DataSource = value;
            }
        }

        public List<SPK> SPKListData
        {
            get
            {
                return gcSPK.DataSource as List<SPK>;
            }
            set
            {
                if (InvokeRequired)
                {
                    this.Invoke(new MethodInvoker(delegate { gcSPK.DataSource = value; gvSPK.BestFitColumns(); }));
                }
                else
                {
                    gcSPK.DataSource = value;
                    gvSPK.BestFitColumns();
                }
            }
        }

        public SPK SelectedSPK { get; set; }

        public List<SPKStatusItem> StatusDropdownList
        {
            get
            {
                return lookUpStatus.Properties.DataSource as List<SPKStatusItem>;
            }
            set
            {
                lookUpStatus.Properties.DataSource = value;
            }
        }
        #endregion

        void gvSPK_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            GridView view = (GridView)sender;
            GridHitInfo hitInfo = view.CalcHitInfo(e.Point);
            if (hitInfo.InRow)
            {
                view.FocusedRowHandle = hitInfo.RowHandle;
                cmsEditor.Show(view.GridControl, e.Point);
            }
        }

        void gvSPK_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            this.SelectedSPK = gvSPK.GetFocusedRow() as SPK;
        }

        void SPKListControl_Load(object sender, EventArgs e)
        {
            btnSearch.PerformClick();
        }

        public override void RefreshDataView()
        {
            if (!bgwMain.IsBusy)
            {
                MethodBase.GetCurrentMethod().Info("Fecthing SPK data...");
                _selectedSPK = null;
                FormHelpers.CurrentMainForm.UpdateStatusInformation("Memuat data SPK...", false);
                bgwMain.RunWorkerAsync();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            RefreshDataView();
        }

        private void bgwMain_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                _presenter.LoadSPK();
            }
            catch (Exception ex)
            {
                MethodBase.GetCurrentMethod().Fatal("An error occured while trying to execute _presenter.LoadSPK()", ex);
                e.Result = ex;
            }
        }

        private void bgwMain_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Result is Exception)
            {
                this.ShowError("Proses memuat data gagal!");
            }

            FormHelpers.CurrentMainForm.UpdateStatusInformation("Memuat data SPK selesai", true);
        }

        private void btnNewSPK_Click(object sender, EventArgs e)
        {
            SPKEditorForm editor = Bootstrapper.Resolve<SPKEditorForm>();
            editor.ShowDialog(this);

            btnSearch.PerformClick();
        }       
    }
}
