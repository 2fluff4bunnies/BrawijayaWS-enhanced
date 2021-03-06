﻿using System;
using System.Collections.Generic;
using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.Presenter;
using BrawijayaWorkshop.SharedObject.ViewModels;
using BrawijayaWorkshop.Utils;
using BrawijayaWorkshop.View;
using System.Windows.Forms;
using System.Reflection;
using BrawijayaWorkshop.Win32App.PrintItems;
using DevExpress.XtraReports.UI;

namespace BrawijayaWorkshop.Win32App.ModulForms
{
    public partial class FIFOSparepartStockCardListForm : BaseDefaultForm, IFIFOSparepartStockCardListView
    {
        private string _formatFormTitle = "FIFO Sparepart: {0}";
        private FIFOSparepartStockCardListPresenter _presenter;

        protected override string ModulName
        {
            get
            {
                return DbConstant.MODUL_STOCK_CARD;
            }
        }

        public DateTime DateFromFilter { get; set; }

        public DateTime DateToFilter { get; set; }

        public SparepartViewModel SelectedSparepart { get; set; }

        public List<GroupSparepartStockCardViewModel> ListStockCard
        {
            get
            {
                return gcFIFOSparepart.DataSource as List<GroupSparepartStockCardViewModel>;
            }
            set
            {
                if (InvokeRequired)
                {
                    this.Invoke(new MethodInvoker(delegate { gcFIFOSparepart.DataSource = value; gvFIFOSparepart.BestFitColumns(); }));
                }
                else
                {
                    gcFIFOSparepart.DataSource = value;
                    gvFIFOSparepart.BestFitColumns();
                }
            }
        }

        public FIFOSparepartStockCardListForm(FIFOSparepartStockCardListModel model)
        {
            InitializeComponent();

            _presenter = new FIFOSparepartStockCardListPresenter(this, model);

            this.Load += FIFOSparepartStockCardListForm_Load;
            exportFileDialog.FileOk += ExportFileDialog_FileOk;
        }

        private void ExportFileDialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            gcFIFOSparepart.ExportToXlsx(exportFileDialog.FileName);
        }

        private void FIFOSparepartStockCardListForm_Load(object sender, EventArgs e)
        {
            this.Text = string.Format(_formatFormTitle, SelectedSparepart.Code + " - " + SelectedSparepart.Name);
            gvFIFOSparepart.ViewCaption = string.Format("Daftar FIFO: {0}", SelectedSparepart.Code + " - " + SelectedSparepart.Name);

            RefreshDataView();
        }

        public override void RefreshDataView()
        {
            if (!bgwMain.IsBusy)
            {
                MethodBase.GetCurrentMethod().Info("Fecthing FIFO data...");
                FormHelpers.CurrentMainForm.UpdateStatusInformation("Memuat data FIFO sparepart...", false);
                bgwMain.RunWorkerAsync();
            }
        }

        private void bgwMain_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            try
            {
                _presenter.LoadFIFOData();
            }
            catch (Exception ex)
            {
                MethodBase.GetCurrentMethod().Fatal("An error occured while trying to execute _presenter.LoadFIFOData()", ex);
                e.Result = ex;
            }
        }

        private void bgwMain_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            if (e.Result is Exception)
            {
                this.ShowError("Proses memuat data gagal!");
            }

            FormHelpers.CurrentMainForm.UpdateStatusInformation("Memuat data FIFO selesai", true);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            FIFOSparepartStockCardPrintItem report = new FIFOSparepartStockCardPrintItem(DateFromFilter, DateToFilter, SelectedSparepart.Name);
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
    }
}
