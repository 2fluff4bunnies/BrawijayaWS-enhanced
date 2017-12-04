using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.Runtime;
using BrawijayaWorkshop.View;
using LINQtoCSV;
using System;
using System.Linq;

namespace BrawijayaWorkshop.Presenter
{
    public class ManualTransactionListPresenter : BasePresenter<IManualTransactionListView, ManualTransactionListModel>
    {
        public ManualTransactionListPresenter(IManualTransactionListView view, ManualTransactionListModel model)
            : base(view, model) { }

        public void ExportToCSV()
        {
            CsvContext cc = new CsvContext();
            CsvFileDescription outputFileDescription = new CsvFileDescription
            {
                QuoteAllFields = true,
                SeparatorChar = ',', // tab delimited
                FirstLineHasColumnNames = true,
                FileCultureName = "en-US"
            };

            // prepare invoices
            var exportTransactions =
                from trans in View.TransactionListData
                select new
                {
                    Tanggal = trans.TransactionDate.ToString("yyyyMMdd"),
                    Jumlah = trans.TotalTransaction,
                    Keterangan = trans.Description
                };

            cc.Write(exportTransactions, View.ExportFileName, outputFileDescription);
        }

        public void InitFormData()
        {
            DateTime today = DateTime.Today;
            View.From = new DateTime(today.Year, today.Month, 1);
            DateTime endDate = View.From.AddMonths(1).AddDays(-1);
            View.To = new DateTime(endDate.Year, endDate.Month, endDate.Day);
        }

        public void LoadData()
        {
            View.TransactionListData = Model.RetrieveManualTransaction(View.From, View.To);
        }

        public void DeleteManualTransaction()
        {
            Model.DeleteManualTransaction(View.SelectedTransaction, LoginInformation.UserId);
        }
    }
}
