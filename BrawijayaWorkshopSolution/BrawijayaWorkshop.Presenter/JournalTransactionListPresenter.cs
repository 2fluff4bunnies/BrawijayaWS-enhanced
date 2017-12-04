using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.View;
using LINQtoCSV;
using System;
using System.Linq;

namespace BrawijayaWorkshop.Presenter
{
    public class JournalTransactionListPresenter : BasePresenter<IJournalTransactionListView, JournalTransactionListModel>
    {
        public JournalTransactionListPresenter(IJournalTransactionListView view, JournalTransactionListModel model)
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
            var exportJournals =
                from jou in View.JournalTransactionList
                select new
                {
                    Tanggal = jou.Parent.TransactionDate.ToString("yyyyMMdd"),
                    KodeAkun = jou.Journal.Code,
                    Nama = jou.Journal.Name,
                    Debet = jou.Debit,
                    Kredit = jou.Credit
                };

            cc.Write(exportJournals, View.ExportFileName, outputFileDescription);
        }

        public void InitFormData()
        {
            View.ListMonth = Model.GenerateMonth();
            View.ListYear = Model.GenerateYear();
            View.SelectedMonth = DateTime.Today.Month;
            View.SelectedYear = DateTime.Today.Year;
        }

        public void LoadData()
        {
            if (View.SelectedMonth == 0 || View.SelectedYear == 0) return;

            View.JournalTransactionList = Model.RetrieveAllTransaction(View.SelectedMonth, View.SelectedYear);
        }
    }
}
