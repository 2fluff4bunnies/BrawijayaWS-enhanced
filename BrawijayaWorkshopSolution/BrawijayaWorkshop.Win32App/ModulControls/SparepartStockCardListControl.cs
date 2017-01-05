using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.Presenter;
using BrawijayaWorkshop.SharedObject.ViewModels;
using BrawijayaWorkshop.Utils;
using BrawijayaWorkshop.View;
using BrawijayaWorkshop.Win32App.ModulForms;
using BrawijayaWorkshop.Win32App.PrintItems;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Windows.Forms;

namespace BrawijayaWorkshop.Win32App.ModulControls
{
    public partial class SparepartStockCardListControl : BaseAppUserControl, ISparepartStockCardListView
    {
        private SparepartStockCardListPresenter _presenter;

        protected override string ModulName
        {
            get
            {
                return DbConstant.MODUL_STOCK_CARD;
            }
        }

        public SparepartViewModel SelectedSparepart { get; set; }

        public SparepartStockCardListControl(SparepartStockCardListModel model)
        {
            InitializeComponent();

            _presenter = new SparepartStockCardListPresenter(this, model);

            deFrom.EditValueChanged += DatePickerValueChanged;
            deTo.EditValueChanged += DatePickerValueChanged;

            DateTime serverTime = DateTime.Today;
            deFrom.EditValue = new DateTime(serverTime.Year, serverTime.Month, 1);
            deTo.EditValue = new DateTime(serverTime.Year, serverTime.Month, DateTime.DaysInMonth(serverTime.Year, serverTime.Month));

            gvStockCard.PopupMenuShowing += GvStockCard_PopupMenuShowing;
            gvStockCard.FocusedRowChanged += GvStockCard_FocusedRowChanged;

            this.Load += SparepartStockCardListControl_Load;
            exportFileDialog.FileOk += ExportFileDialog_FileOk;
        }

        private void GvStockCard_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            SelectedSparepart = (gvStockCard.GetFocusedRow() as GroupSparepartStockCardViewModel).Sparepart;
        }

        private void GvStockCard_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            GridView view = (GridView)sender;
            GridHitInfo hitInfo = view.CalcHitInfo(e.Point);
            if (hitInfo.InRow)
            {
                view.FocusedRowHandle = hitInfo.RowHandle;
                cmsEditor.Show(view.GridControl, e.Point);
            }
        }

        private void SparepartStockCardListControl_Load(object sender, EventArgs e)
        {
            if (!bgwInit.IsBusy)
            {
                MethodBase.GetCurrentMethod().Info("Fecthing sparepart data...");
                FormHelpers.CurrentMainForm.UpdateStatusInformation("Memuat data sparepart...", false);
                bgwInit.RunWorkerAsync();
            }
        }

        private void DatePickerValueChanged(object sender, EventArgs e)
        {
            if ((sender as DateEdit).Name == "deFrom")
            {
                deTo.Properties.MinValue = deFrom.EditValue.AsDateTime();
            }
            else
            {
                deFrom.Properties.MaxValue = deTo.EditValue.AsDateTime();
            }
        }

        public DateTime DateFromFilter
        {
            get
            {
                return deFrom.EditValue.AsDateTime();
            }

            set
            {
                deFrom.EditValue = value;
            }
        }

        public DateTime DateToFilter
        {
            get
            {
                return deTo.EditValue.AsDateTime();
            }

            set
            {
                deTo.EditValue = value;
            }
        }

        public List<SparepartViewModel> ListSparepart
        {
            get
            {
                return lookupSparepart.Properties.DataSource as List<SparepartViewModel>;
            }

            set
            {
                if (InvokeRequired)
                {
                    this.Invoke(new MethodInvoker(delegate { lookupSparepart.Properties.DataSource = value; lookupSparepart.Properties.BestFit(); }));
                }
                else
                {
                    lookupSparepart.Properties.DataSource = value;
                    lookupSparepart.Properties.BestFit();
                }
            }
        }

        public List<GroupSparepartStockCardViewModel> ListStockCard
        {
            get
            {
                return gcStockCard.DataSource as List<GroupSparepartStockCardViewModel>;
            }

            set
            {
                if (InvokeRequired)
                {
                    this.Invoke(new MethodInvoker(delegate { gcStockCard.DataSource = value; gvStockCard.BestFitColumns(); }));
                }
                else
                {
                    gcStockCard.DataSource = value;
                    gvStockCard.BestFitColumns();
                }
            }
        }

        public int SelectedSparepartId
        {
            get
            {
                return lookupSparepart.EditValue.AsInteger();
            }

            set
            {
                lookupSparepart.EditValue = value;
            }
        }

        public override void RefreshDataView()
        {
            if (!bgwMain.IsBusy)
            {
                MethodBase.GetCurrentMethod().Info("Fecthing stock card data...");
                FormHelpers.CurrentMainForm.UpdateStatusInformation("Memuat data stok...", false);
                bgwMain.RunWorkerAsync();
            }
        }

        private void bgwMain_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                _presenter.LoadStockCard();
            }
            catch (Exception ex)
            {
                MethodBase.GetCurrentMethod().Fatal("An error occured while trying to execute _presenter.LoadStockCard()", ex);
                e.Result = ex;
            }
        }

        private void bgwMain_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Result is Exception)
            {
                this.ShowError("Proses memuat data gagal!");
            }

            FormHelpers.CurrentMainForm.UpdateStatusInformation("Memuat data stok selesai", true);
        }

        private void bgwInit_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                _presenter.LoadSparepart();
            }
            catch (Exception ex)
            {
                MethodBase.GetCurrentMethod().Fatal("An error occured while trying to execute _presenter.LoadSparepart()", ex);
                e.Result = ex;
            }
        }

        private void bgwInit_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Result is Exception)
            {
                this.ShowError("Proses memuat data gagal!");
            }

            FormHelpers.CurrentMainForm.UpdateStatusInformation("Memuat data sparepart selesai", true);

            btnSearch.PerformClick();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            RefreshDataView();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            SparepartStockCardPrintItem report = new SparepartStockCardPrintItem(DateFromFilter, DateToFilter);
            report.DataSource = ListStockCard;
            report.FillDataSource();

            using (ReportPrintTool printTool = new ReportPrintTool(report))
            {
                printTool.PrintDialog();
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            exportFileDialog.ShowDialog(this);
        }

        private void ExportFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            gcStockCard.ExportToXlsx(exportFileDialog.FileName);
        }

        private void cmsLoadFifoData_Click(object sender, EventArgs e)
        {
            FIFOSparepartStockCardListForm fifoForm = Bootstrapper.Resolve<FIFOSparepartStockCardListForm>();
            fifoForm.DateFromFilter = DateFromFilter;
            fifoForm.DateToFilter = DateToFilter;
            fifoForm.SelectedSparepart = SelectedSparepart;
            fifoForm.ShowDialog(this);
        }
    }
}
