using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.SharedObject.ViewModels;
using BrawijayaWorkshop.View;
using LINQtoCSV;
using System;
using System.Linq;

namespace BrawijayaWorkshop.Presenter
{
    public class HistorySparepartListPresenter : BasePresenter<IHistorySparepartListView, HistorySparepartListModel>
    {
        public HistorySparepartListPresenter(IHistorySparepartListView view, HistorySparepartListModel model)
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
            var exportSpareparts =
                from sp in View.SparepartListData
                select new
                {
                    Tanggal = sp.SPK.CreateDate.ToString("yyyyMMdd"),
                    Nopol = sp.SPK.Vehicle.ActiveLicenseNumber,
                    Kode = sp.Sparepart.Code,
                    Nama = sp.Sparepart.Name,
                    Unit = sp.Sparepart.UnitReference.Name ,
                    Qty = sp.TotalQuantity,
                    SubTotal = sp.TotalPrice,
                    Kategori = sp.Category
                };

            cc.Write(exportSpareparts, View.ExportFileName, outputFileDescription);
        }

        public void InitData()
        {
            View.DateFromFilter = DateTime.Now;
            View.DateToFilter = DateTime.Now;
            View.SparepartFilterList = Model.GetAllSparepart();
            View.VehicleFilterList = Model.GetAllVehicle();
        }

        public void LoadHistorySparepartList()
        {
            View.SparepartListData = Model.SearchHistorySparepart(View.DateFromFilter, View.DateToFilter, View.VehicleFilter, View.SparepartFilter);
        }
    }
}
