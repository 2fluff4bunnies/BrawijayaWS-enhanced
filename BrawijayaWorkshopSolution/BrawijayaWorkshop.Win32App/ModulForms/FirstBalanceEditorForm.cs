using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.Presenter;
using BrawijayaWorkshop.SharedObject.ViewModels;
using BrawijayaWorkshop.Utils;
using BrawijayaWorkshop.View;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;

namespace BrawijayaWorkshop.Win32App.ModulForms
{
    public partial class FirstBalanceEditorForm : BaseEditorForm, IFirstBalanceEditorView
    {
        private FirstBalanceEditorPresenter _presenter;
        public FirstBalanceEditorForm(FirstBalanceEditorModel model)
        {
            InitializeComponent();
            _presenter = new FirstBalanceEditorPresenter(this, model);

            gvFirstBalanceDetail.FocusedRowChanged += gvFirstBalanceDetail_FocusedRowChanged;
            gvFirstBalanceDetail.PopupMenuShowing += gvFirstBalanceDetail_PopupMenuShowing;

            this.Load += FirstBalanceEditorForm_Load;
        }

        private void gvFirstBalanceDetail_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            GridView view = (GridView)sender;
            GridHitInfo hitInfo = view.CalcHitInfo(e.Point);
            if (hitInfo.InRow)
            {
                view.FocusedRowHandle = hitInfo.RowHandle;
                cmsEditor.Show(view.GridControl, e.Point);
            }
        }

        private void gvFirstBalanceDetail_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            SelectedFirstBalanceDetailJournal = gvFirstBalanceDetail.GetFocusedRow() as BalanceJournalDetailViewModel;
        }

        private void FirstBalanceEditorForm_Load(object sender, EventArgs e)
        {
            _presenter.InitFormData();
        }

        public DateTime FirstBalanceDate
        {
            get
            {
                return deFirstBalanceDate.EditValue.AsDateTime();
            }
            set
            {
                deFirstBalanceDate.EditValue = value;
            }
        }

        public List<JournalMasterViewModel> JournalList
        {
            get
            {
                return lookUpJournalGv.DataSource as List<JournalMasterViewModel>;
            }
            set
            {
                lookUpJournalGv.DataSource = value;
            }
        }

        public BalanceJournalViewModel SelectedFirstBalanceJournal { get; set; }

        public BalanceJournalDetailViewModel SelectedFirstBalanceDetailJournal { get; set; }

        public List<BalanceJournalDetailViewModel> FirstBalanceJournalDetailList
        {
            get
            {
                return gridFirstBalanceDetail.DataSource as List<BalanceJournalDetailViewModel>;
            }
            set
            {
                if (InvokeRequired)
                {
                    this.Invoke(new MethodInvoker(delegate { gridFirstBalanceDetail.DataSource = value; gvFirstBalanceDetail.BestFitColumns(); }));
                }
                else
                {
                    gridFirstBalanceDetail.DataSource = value;
                    gvFirstBalanceDetail.BestFitColumns();
                }
            }
        }

        public List<BalanceJournalDetailViewModel> DeletedDetailList { get; set; }

        private void btnNewDetailData_Click(object sender, EventArgs e)
        {
            _presenter.InsertNewRecord();
        }

        private void cmsDeleteData_Click(object sender, EventArgs e)
        {
            if (SelectedFirstBalanceDetailJournal != null)
            {
                if (this.ShowConfirmation("Apakah anda yakin ingin menghapus detail berikut?") == System.Windows.Forms.DialogResult.Yes)
                {
                    _presenter.RemoveDetail();
                }
            }
        }

        protected override void ExecuteSave()
        {
            if (_presenter.ValidateBalanceData())
            {
                try
                {
                    MethodBase.GetCurrentMethod().Info("Save First Balance's changes");
                    _presenter.SaveChanges();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MethodBase.GetCurrentMethod().Fatal("An error occured while trying to save first balance", ex);
                    this.ShowError("Proses simpan data saldo awal gagal!");
                }
            }
            else
            {
                this.ShowWarning("Jurnal harus dipilih atau Total debit dan credit harus sama!");
            }
        }
    }
}