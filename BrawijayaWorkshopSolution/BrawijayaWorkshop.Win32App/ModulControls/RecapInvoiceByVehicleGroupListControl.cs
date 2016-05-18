using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.Presenter;
using BrawijayaWorkshop.SharedObject.ViewModels;
using BrawijayaWorkshop.Utils;
using BrawijayaWorkshop.View;
using BrawijayaWorkshop.Win32App.PrintItems;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace BrawijayaWorkshop.Win32App.ModulControls
{
    public partial class RecapInvoiceByVehicleGroupListControl : BaseAppUserControl, IRecapInvoiceByVehicleGroupView
    {
        private RecapInvoiceByVehicleGroupPresenter _presenter;
        public RecapInvoiceByVehicleGroupListControl(RecapInvoiceByVehicleGroupModel model)
        {
            InitializeComponent();
            _presenter = new RecapInvoiceByVehicleGroupPresenter(this, model);
            lookupCustomer.EditValueChanged += lookupCustomer_EditValueChanged;

            this.Load += RecapInvoiceByVehicleGroupListControl_Load;
        }

        private void lookupCustomer_EditValueChanged(object sender, EventArgs e)
        {
            _presenter.OnCustomerSelected();
        }

        private void RecapInvoiceByVehicleGroupListControl_Load(object sender, EventArgs e)
        {
            _presenter.InitFormData();
        }

        public DateTime DateFrom
        {
            get
            {
                return dePeriodFrom.EditValue.AsDateTime();
            }
            set
            {
                dePeriodFrom.EditValue = value;
            }
        }

        public DateTime DateTo
        {
            get
            {
                return dePeriodeTo.EditValue.AsDateTime();
            }
            set
            {
                dePeriodeTo.EditValue = value;
            }
        }

        public int SelectedCustomer
        {
            get
            {
                return lookupCustomer.EditValue.AsInteger();
            }
            set
            {
                lookupCustomer.EditValue = value;
            }
        }

        public List<CustomerViewModel> ListCustomer
        {
            get
            {
                return lookupCustomer.Properties.DataSource as List<CustomerViewModel>;
            }
            set
            {
                lookupCustomer.Properties.DataSource = value;
            }
        }

        public int SelectedCategory
        {
            get
            {
                return lookupCategory.EditValue.AsInteger();
            }
            set
            {
                lookupCategory.EditValue = value;
            }
        }

        public List<ReferenceViewModel> ListCategory
        {
            get
            {
                return lookupCategory.Properties.DataSource as List<ReferenceViewModel>;
            }
            set
            {
                lookupCategory.Properties.DataSource = value;
            }
        }

        public int SelectedVehicleGroup
        {
            get
            {
                return lookupVehicleGroup.EditValue.AsInteger();
            }
            set
            {
                lookupVehicleGroup.EditValue = value;
            }
        }

        public List<VehicleGroupViewModel> ListVehicleGroup
        {
            get
            {
                return lookupVehicleGroup.Properties.DataSource as List<VehicleGroupViewModel>;
            }
            set
            {
                lookupVehicleGroup.Properties.DataSource = value;
            }
        }

        public List<RecapInvoiceItemViewModel> ListInvoices
        {
            get
            {
                return gridRecapInvoice.DataSource as List<RecapInvoiceItemViewModel>;
            }
            set
            {
                if (InvokeRequired)
                {
                    this.Invoke(new MethodInvoker(delegate { gridRecapInvoice.DataSource = value; gvRecapInvoice.BestFitColumns(); }));
                }
                else
                {
                    gridRecapInvoice.DataSource = value;
                    gvRecapInvoice.BestFitColumns();
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (SelectedCategory > 0 && SelectedCustomer > 0)
            {
                RefreshDataView();
            }
            else
            {
                this.ShowWarning("Pilih salah satu Kategori dan Customer");
            }
        }

        public override void RefreshDataView()
        {
            if (!bgwMain.IsBusy)
            {
                MethodBase.GetCurrentMethod().Info("Fecthing invoice data...");
                FormHelpers.CurrentMainForm.UpdateStatusInformation("Memuat data invoice...", false);
                bgwMain.RunWorkerAsync();
            }
        }

        private void btnPrintAll_Click(object sender, EventArgs e)
        {
            if (ListInvoices.Count == 0)
            {
                this.ShowInformation("Data Invoice tidak ada");
                return;
            }

            ReferenceViewModel category = lookupCategory.GetSelectedDataRow() as ReferenceViewModel;
            VehicleGroupViewModel vehicleGroup = lookupVehicleGroup.GetSelectedDataRow() as VehicleGroupViewModel;

            List<RecapInvoiceBySPKItemViewModel> reportDataSource = new List<RecapInvoiceBySPKItemViewModel>();
            foreach (var item in this.ListInvoices)
            {
                if (item.ItemName == "Gaji Tukang Harian" || item.ItemName == "Gaji Tukang Borongan")
                {
                    RecapInvoiceBySPKItemViewModel itemWorker = reportDataSource.Where(ds =>
                        ds.Category == category.Name && ds.VehicleGroup == vehicleGroup.Name &&
                        ds.LicenseNumber == item.Invoice.SPK.Vehicle.ActiveLicenseNumber &&
                        (ds.Description == "ONGKOS TUKANG HARIAN" ||
                        ds.Description == "ONGKOS TUKANG BORONGAN")).FirstOrDefault();
                    if (itemWorker != null)
                    {
                        int currentIndex = reportDataSource.IndexOf(itemWorker);
                        if (item.ItemName == "Gaji Tukang Borongan")
                        {
                            decimal commission = item.SubTotalWithoutFee - ((100M / 120M) * item.SubTotalWithoutFee);
                            itemWorker.CommisionNominal = commission;
                            itemWorker.Nominal += (item.SubTotalWithoutFee - commission);
                            itemWorker.Total += item.SubTotalWithFee;
                            itemWorker.Fee += (item.SubTotalWithFee - item.SubTotalWithoutFee);
                        }
                        else
                        {
                            itemWorker.Nominal += item.SubTotalWithoutFee;
                            itemWorker.Total += item.SubTotalWithFee;
                            itemWorker.Fee += (item.SubTotalWithFee - item.SubTotalWithoutFee);
                        }
                        reportDataSource[currentIndex] = itemWorker;
                    }
                    else
                    {
                        itemWorker = new RecapInvoiceBySPKItemViewModel();
                        itemWorker.Category = category.Name;
                        itemWorker.VehicleGroup = vehicleGroup.Name;
                        itemWorker.LicenseNumber = item.Invoice.SPK.Vehicle.ActiveLicenseNumber;
                        itemWorker.Description = item.ItemName == "Gaji Tukang Harian" ?
                            "ONGKOS TUKANG HARIAN" : "ONGKOS TUKANG BORONGAN";
                        if (item.ItemName == "Gaji Tukang Borongan")
                        {
                            decimal commission = item.SubTotalWithoutFee - ((100M / 120M) * item.SubTotalWithoutFee);
                            itemWorker.CommisionNominal = commission;
                            itemWorker.Nominal = item.SubTotalWithoutFee - commission;
                            itemWorker.Total = item.SubTotalWithFee;
                            itemWorker.Fee = (item.SubTotalWithFee - item.SubTotalWithoutFee);
                        }
                        else
                        {
                            itemWorker.Nominal = item.SubTotalWithoutFee;
                            itemWorker.Total = item.SubTotalWithFee;
                            itemWorker.Fee = (item.SubTotalWithFee - item.SubTotalWithoutFee);
                        }
                        reportDataSource.Add(itemWorker);
                    }
                }
                else
                {
                    RecapInvoiceBySPKItemViewModel itemSparepart = reportDataSource.Where(ds =>
                        ds.Category == category.Name && ds.VehicleGroup == vehicleGroup.Name &&
                        ds.LicenseNumber == item.Invoice.SPK.Vehicle.ActiveLicenseNumber &&
                        ds.Description == "ONDERDIL").FirstOrDefault();
                    if (itemSparepart != null)
                    {
                        int currentIndex = reportDataSource.IndexOf(itemSparepart);
                        itemSparepart.Nominal += item.SubTotalWithoutFee;
                        itemSparepart.Total += item.SubTotalWithFee;
                        itemSparepart.Fee += (item.SubTotalWithFee - item.SubTotalWithoutFee);
                        reportDataSource[currentIndex] = itemSparepart;
                    }
                    else
                    {
                        itemSparepart = new RecapInvoiceBySPKItemViewModel();
                        itemSparepart.Category = category.Name;
                        itemSparepart.VehicleGroup = vehicleGroup.Name;
                        itemSparepart.LicenseNumber = item.Invoice.SPK.Vehicle.ActiveLicenseNumber;
                        itemSparepart.Description = "ONDERDIL";
                        itemSparepart.Nominal = item.SubTotalWithoutFee;
                        itemSparepart.Total = item.SubTotalWithFee;
                        itemSparepart.Fee = (item.SubTotalWithFee - item.SubTotalWithoutFee);
                        reportDataSource.Add(itemSparepart);
                    }
                }
            }

            RecapInvoiceByVehicleGroupPrintItem report = new RecapInvoiceByVehicleGroupPrintItem(category.Name, DateFrom, DateTo);
            report.DataSource = reportDataSource;
            report.FillDataSource();

            using (ReportPrintTool printTool = new ReportPrintTool(report))
            {
                printTool.PrintDialog();
            }
        }

        private void bgwMain_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                _presenter.LoadData();
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

            FormHelpers.CurrentMainForm.UpdateStatusInformation("Memuat data invoice selesai", true);
        }
    }
}
