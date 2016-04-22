using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.Presenter;
using BrawijayaWorkshop.SharedObject.ViewModels;
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
    public partial class TypeListControl : BaseAppUserControl, ITypeListView
    {
        private TypeListPresenter _presenter;
        private TypeViewModel _selectedType;

        protected override string ModulName
        {
            get
            {
                return DbConstant.MODUL_BRAND;
            }
        }

        public TypeListControl(TypeListModel model)
        {
            InitializeComponent();
            _presenter = new TypeListPresenter(this, model);

            gvType.PopupMenuShowing += gvType_PopupMenuShowing;
            gvType.FocusedRowChanged += gvType_FocusedRowChanged;

            // init editor control accessibility
            btnNewType.Enabled = AllowInsert;
            cmsEditData.Enabled = AllowEdit;
            cmsDeleteData.Enabled = AllowDelete;

            this.Load += TypeListControl_Load;
        }

        private void TypeListControl_Load(object sender, EventArgs e)
        {
            btnSearch.PerformClick();
        }

        private void gvType_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            this.SelectedType = gvType.GetFocusedRow() as TypeViewModel;
        }

        private void gvType_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            GridView view = (GridView)sender;
            GridHitInfo hitInfo = view.CalcHitInfo(e.Point);
            if (hitInfo.InRow)
            {
                view.FocusedRowHandle = hitInfo.RowHandle;
                cmsEditor.Show(view.GridControl, e.Point);
            }
        }

        public string NameFilter
        {
            get
            {
                return txtFilterName.Text;
            }
            set
            {
                txtFilterName.Text = value;
            }
        }

        public List<TypeViewModel> TypeListData
        {
            get
            {
                return gridType.DataSource as List<TypeViewModel>;
            }
            set
            {
                if (InvokeRequired)
                {
                    this.Invoke(new MethodInvoker(delegate { gridType.DataSource = value; gvType.BestFitColumns(); }));
                }
                else
                {
                    gridType.DataSource = value;
                    gvType.BestFitColumns();
                }
            }
        }

        public TypeViewModel SelectedType
        {
            get
            {
                return _selectedType;
            }
            set
            {
                _selectedType = value;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            RefreshDataView();
        }

        public override void RefreshDataView()
        {
            if (!bgwMain.IsBusy)
            {
                MethodBase.GetCurrentMethod().Info("Fecthing type data...");
                _selectedType = null;
                FormHelpers.CurrentMainForm.UpdateStatusInformation("Memuat data type...", false);
                bgwMain.RunWorkerAsync();
            }
        }

        private void txtFilter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch.PerformClick();
            }
        }

        private void btnNewType_Click(object sender, EventArgs e)
        {
            TypeEditorForm editor = Bootstrapper.Resolve<TypeEditorForm>();
            editor.ShowDialog(this);

            btnSearch.PerformClick();
        }

        private void cmsEditData_Click(object sender, EventArgs e)
        {
            if (_selectedType != null)
            {
                TypeEditorForm editor = Bootstrapper.Resolve<TypeEditorForm>();
                editor.SelectedType = _selectedType;
                editor.ShowDialog(this);

                btnSearch.PerformClick();
            }
        }

        private void cmsDeleteData_Click(object sender, EventArgs e)
        {
            if (SelectedType == null) return;

            if (this.ShowConfirmation("Apakah anda yakin ingin menghapus type: '" + SelectedType.Name + "'?") == DialogResult.Yes)
            {
                try
                {
                    MethodBase.GetCurrentMethod().Info("Deleting type: " + SelectedType.Name);

                    _presenter.DeleteType();

                    btnSearch.PerformClick(); // refresh data
                }
                catch (Exception ex)
                {
                    MethodBase.GetCurrentMethod().Fatal("An error occured while trying to delete type: '" + SelectedType.Name + "'", ex);
                    this.ShowError("Proses hapus data type: '" + SelectedType.Name + "' gagal!");
                }
            }
        }

        private void bgwMain_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                _presenter.LoadType();
            }
            catch (Exception ex)
            {
                MethodBase.GetCurrentMethod().Fatal("An error occured while trying to execute _presenter.LoadType()", ex);
                e.Result = ex;
            }
        }

        private void bgwMain_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Result is Exception)
            {
                this.ShowError("Proses memuat data gagal!");
            }

            if (gvType.RowCount > 0)
            {
                SelectedType = gvType.GetRow(0) as TypeViewModel;
            }

            FormHelpers.CurrentMainForm.UpdateStatusInformation("Memuat data type selesai", true);
        }
    }
}
