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
    public partial class MechanicListControl : BaseAppUserControl, IMechanicListView
    {
        private MechanicListPresenter _presenter;
        private Mechanic _selectedMechanic;

        protected override string ModulName
        {
            get
            {
                return DbConstant.MODUL_MECHANIC;
            }
        }

        public MechanicListControl(MechanicListModel model)
        {
            InitializeComponent();
            _presenter = new MechanicListPresenter(this, model);

            gvMechanic.PopupMenuShowing += gvMechanic_PopupMenuShowing;
            gvMechanic.FocusedRowChanged += gvMechanic_FocusedRowChanged;

            // init editor control accessibility
            btnNewMechanic.Enabled = AllowInsert;
            cmsEditData.Enabled = AllowEdit;
            cmsDeleteData.Enabled = AllowDelete;

            _presenter.LoadMechanic();
        }

        private void gvMechanic_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            this.SelectedMechanic = gvMechanic.GetFocusedRow() as Mechanic;
        }

        private void gvMechanic_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            GridView view = (GridView)sender;
            GridHitInfo hitInfo = view.CalcHitInfo(e.Point);
            if (hitInfo.InRow)
            {
                view.FocusedRowHandle = hitInfo.RowHandle;
                cmsEditor.Show(view.GridControl, e.Point);
            }
        }

        public string MechanicNameFilter
        {
            get
            {
                return txtFilterMechanicName.Text;
            }
            set
            {
                txtFilterMechanicName.Text = value;
            }
        }

        public List<Mechanic> MechanicListData
        {
            get
            {
                return gridMechanic.DataSource as List<Mechanic>;
            }
            set
            {
                if (InvokeRequired)
                {
                    this.Invoke(new MethodInvoker(delegate { gridMechanic.DataSource = value; }));
                }
                else
                {
                    gridMechanic.DataSource = value;
                }
            }
        }

        public Mechanic SelectedMechanic
        {
            get
            {
                return _selectedMechanic;
            }
            set
            {
                _selectedMechanic = value;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!bgwMain.IsBusy)
            {
                MethodBase.GetCurrentMethod().Info("Fecthing Mechanic data...");
                _selectedMechanic = null;
                FormHelpers.CurrentMainForm.UpdateStatusInformation("Memuat data Mechanic...", false);
                bgwMain.RunWorkerAsync();
            }
        }

        private void txtFilterMechanicName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch.PerformClick();
            }
        }

        private void btnNewMechanic_Click(object sender, EventArgs e)
        {
            MechanicEditorForm editor = Bootstrapper.Resolve<MechanicEditorForm>();
            editor.ShowDialog(this);

            btnSearch.PerformClick();
        }

        private void cmsEditData_Click(object sender, EventArgs e)
        {
            if (_selectedMechanic != null)
            {
                MechanicEditorForm editor = Bootstrapper.Resolve<MechanicEditorForm>();
                editor.SelectedMechanic = _selectedMechanic;
                editor.ShowDialog(this);

                btnSearch.PerformClick();
            }
        }

        private void cmsDeleteData_Click(object sender, EventArgs e)
        {
            if (SelectedMechanic == null) return;

            if (this.ShowConfirmation("Apakah anda yakin ingin Mechanic: '" + SelectedMechanic.Name + "'?") == DialogResult.Yes)
            {
                try
                {
                    MethodBase.GetCurrentMethod().Info("Deleting Mechanic: " + SelectedMechanic.Name);

                    _presenter.DeleteMechanic();

                    btnSearch.PerformClick(); // refresh data
                }
                catch (Exception ex)
                {
                    MethodBase.GetCurrentMethod().Fatal("An error occured while trying to delete Mechanic: '" + SelectedMechanic.Name + "'", ex);
                    this.ShowError("Proses hapus data Mechanic: '" + SelectedMechanic.Name + "' gagal!");
                }
            }
        }

        private void bgwMain_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                _presenter.LoadMechanic();
            }
            catch (Exception ex)
            {
                MethodBase.GetCurrentMethod().Fatal("An error occured while trying to execute _presenter.LoadData()", ex);
                e.Result = ex;
            }
        }

        private void bgwMain_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Result is Exception)
            {
                this.ShowError("Proses memuat data gagal!");
            }
            if (MechanicListData.Count > 0)
            {
                gvMechanic.FocusedRowHandle = 0;
                _selectedMechanic = gvMechanic.GetRow(0) as Mechanic;
            }
            FormHelpers.CurrentMainForm.UpdateStatusInformation("Memuat data Mechanic selesai", true);
        }
    }
}