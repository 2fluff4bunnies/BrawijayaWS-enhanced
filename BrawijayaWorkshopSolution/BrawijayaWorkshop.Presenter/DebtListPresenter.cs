using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.View;
using LINQtoCSV;
using System.Linq;

namespace BrawijayaWorkshop.Presenter
{
    public class DebtListPresenter : BasePresenter<IDebtListView, DebtListModel>
    {
        public DebtListPresenter(IDebtListView view, DebtListModel model)
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
            var exportPurchasings =
                from pur in View.PurchasingListData
                select new
                {
                    Tanggal = pur.Date.ToString("yyyyMMdd"),
                    Supplier = pur.Supplier.Name,
                    TotalTransaksi = pur.TotalPrice,
                    TotalDibayar = pur.TotalHasPaid,
                    StatusBayar = pur.PaymentMethodId == 0 ? "Belum Lunas" : "Lunas"
                };

            cc.Write(exportPurchasings, View.ExportFileName, outputFileDescription);
        }

        public void LoadPurchasingList()
        {
            int paymentStatus = -1;
            if (string.Compare(View.DebtStatusPayment, "Belum Lunas", true) == 0)
            {
                paymentStatus = 0;
            }
            if (string.Compare(View.DebtStatusPayment, "Lunas", true) == 0)
            {
                paymentStatus = 1;
            }
            View.PurchasingListData = Model.SearchTransaction(View.DateFromFilter, View.DateToFilter, paymentStatus);
            
        }
    }
}
