using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.Runtime;
using BrawijayaWorkshop.View;
using LINQtoCSV;
using System;
using System.Linq;

namespace BrawijayaWorkshop.Presenter
{
    public class SalesReturnListPresenter : BasePresenter<ISalesReturnListView, SalesReturnListModel>
    {
        public SalesReturnListPresenter(ISalesReturnListView view, SalesReturnListModel model)
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
            var exportSalesReturns =
                from sal in View.SalesReturnListData
                select new
                {
                    Tanggal = sal.CreateDate.ToString("yyyyMMdd"),
                    Customer = sal.Invoice.SPK.Vehicle.Customer.CompanyName,
                    TotalTransaksi = sal.Invoice.TotalPrice,
                    TotalRetur = sal.TotalPriceReturn
                };

            cc.Write(exportSalesReturns, View.ExportFileName, outputFileDescription);
        }

        public void InitData()
        {
            View.CustomerFilterList = Model.GetCustomerFilterList();
            View.DateFilterFrom = DateTime.Now;
            View.DateFilterTo = DateTime.Now;
            View.CustomerFilter = 0;
        }

        public void LoadSalesReturn()
        {
            View.SalesReturnListData = Model.SearchSalesReturnList(View.DateFilterFrom, View.DateFilterTo, View.CustomerFilter);
        }

        public void DeleteData()
        {
            if (View.SelectedSalesReturn != null)
            {
                Model.DeleteSalesReturn(View.SelectedSalesReturn.Id, LoginInformation.UserId);
            }

        }
        public void GetReturnList()
        {
            View.SelectedSalesReturn.ReturnList = Model.GetReturnListDetail(View.SelectedSalesReturn.Id, View.SelectedSalesReturn.Invoice.Id);
            View.SelectedSalesReturn.SalesReturnDetails = Model.RetrieveSalesReturnDetailView(View.SelectedSalesReturn.Id);
        }
    }
}
