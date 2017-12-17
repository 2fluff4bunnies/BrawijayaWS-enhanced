using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.Runtime;
using BrawijayaWorkshop.View;
using LINQtoCSV;
using System;
using System.Linq;

namespace BrawijayaWorkshop.Presenter
{
    public class PurchaseReturnListPresenter : BasePresenter<IPurchaseReturnListView, PurchaseReturnListModel>
    {
        public PurchaseReturnListPresenter(IPurchaseReturnListView view, PurchaseReturnListModel model)
            : base(view, model) { }

        public void ExportToCSV()
        {
            CsvContext cc = new CsvContext();
            CsvFileDescription outputFileDescription = new CsvFileDescription
            {
                QuoteAllFields = false,
                SeparatorChar = ',', // tab delimited
                FirstLineHasColumnNames = true,
                FileCultureName = "en-US"
            };

            // prepare invoices
            var exportPurchasingReturns =
                from pur in View.PurchaseReturnListData
                select new
                {
                    Tanggal = pur.Date.ToString("yyyyMMdd"),
                    Supplier = pur.Purchasing.Supplier.Name,
                    TotalTransaksi = pur.Purchasing.TotalPrice,
                    TotalRetur = pur.TotalPriceReturn
                };

            cc.Write(exportPurchasingReturns, View.ExportFileName, outputFileDescription);
        }

        public void InitData()
        {
            View.SupplierFilterList = Model.GetSupplierFilterList();
            View.DateFilterFrom = DateTime.Now;
            View.DateFilterTo = DateTime.Now;
            View.SupplierFilter = 0;
        }

        public void LoadPurchaseReturn()
        {
            View.PurchaseReturnListData = Model.SearchPurchaseReturnList(View.DateFilterFrom, View.DateFilterTo, View.SupplierFilter);
        }

        public void DeleteData()
        {
            if (View.SelectedPurchaseReturn != null)
            {
                Model.DeletePurchaseReturn(View.SelectedPurchaseReturn.Id, LoginInformation.UserId);
            }

        }
        public void GetReturnList()
        {
            View.SelectedPurchaseReturn.ReturnList = Model.GetReturnListDetail(View.SelectedPurchaseReturn.Id, View.SelectedPurchaseReturn.PurchasingId);
        }
    }
}
