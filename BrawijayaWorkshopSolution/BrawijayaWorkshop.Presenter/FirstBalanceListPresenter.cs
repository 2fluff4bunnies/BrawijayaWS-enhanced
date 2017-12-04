using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.Runtime;
using BrawijayaWorkshop.View;
using LINQtoCSV;
using System.Linq;

namespace BrawijayaWorkshop.Presenter
{
    public class FirstBalanceListPresenter : BasePresenter<IFirstBalanceListView, FirstBalanceListModel>
    {
        public FirstBalanceListPresenter(IFirstBalanceListView view, FirstBalanceListModel model)
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
                from jour in View.FirstBalanceJournalDetailList
                select new
                {
                    KodeAkun = jour.Journal.Code,
                    Nama = jour.Journal.Name,
                    Debet = jour.LastDebit,
                    Kredit = jour.LastCredit
                };

            cc.Write(exportJournals, View.ExportFileName, outputFileDescription);
        }

        public void LoadData()
        {
            View.SelectedFirstBalanceJournal = Model.RetrieveFirstBalance();
            if(View.SelectedFirstBalanceJournal != null)
            {
                View.FirstBalanceJournalDetailList = Model.RetrieveFirstBalanceDetail(View.SelectedFirstBalanceJournal.Id);
            }
        }

        public void DeleteSelectedBalance()
        {
            Model.DeleteFirstBalanceJournal(View.SelectedFirstBalanceJournal, LoginInformation.UserId);
        }
    }
}
