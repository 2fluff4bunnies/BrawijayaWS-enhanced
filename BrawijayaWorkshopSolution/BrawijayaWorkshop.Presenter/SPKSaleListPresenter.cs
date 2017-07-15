using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.View;
using LINQtoCSV;
using System.Linq;

namespace BrawijayaWorkshop.Presenter
{
    public class SPKSaleListPresenter: BasePresenter<ISPKSaleListView, SPKSaleListModel>
    {
        public SPKSaleListPresenter(ISPKSaleListView view, SPKSaleListModel model)
            : base(view, model) { }

        public void ExportToCSV()
        {
            CsvContext cc = new CsvContext();
            CsvFileDescription outputFileDescription = new CsvFileDescription
            {
                QuoteAllFields = true,
                SeparatorChar = ';', // tab delimited
                FirstLineHasColumnNames = true,
                FileCultureName = "en-US"
            };

            // prepare invoices
            var exportSpKs =
                from spk in View.SPKListData
                select new
                {
                    TanggalBuat = spk.CreateDate.ToString("yyyyMMdd"),
                    Kode = spk.Code,
                    NoPol = spk.Vehicle.ActiveLicenseNumber,
                    TotalHargaSparepart = spk.TotalSparepartPrice
                };

            cc.Write(exportSpKs, View.ExportFileName, outputFileDescription);
        }

        public void LoadSPK()
        {
            View.SPKListData = Model.SearchSPKSales(View.DateFilterFrom, View.DateFilterTo);
        }

        public void loadSelectedInvoice()
        {
            View.SelectedInvoice= Model.GetInvoiceBySPKId(View.SelectedSPK.Id);
        }
    }
}
