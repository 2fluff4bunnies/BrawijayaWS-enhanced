using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.View;
using LINQtoCSV;
using System.Linq;

namespace BrawijayaWorkshop.Presenter
{
    public class UsedGoodTransactionListPresenter : BasePresenter<IUsedGoodTransactionListView, UsedGoodTransactionListModel>
    {
        public UsedGoodTransactionListPresenter(IUsedGoodTransactionListView view, UsedGoodTransactionListModel model)
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
            var exportUsedGoods =
                from us in View.UsedGoodTransactionListData
                select new
                {
                    Tanggal = us.TransactionDate.ToString("yyyyMMdd"),
                    Sparepart = us.UsedGood.Sparepart.Name,
                    StockKeluar = us.Qty,
                    Tipe = us.TypeReference.Name,
                };

            cc.Write(exportUsedGoods, View.ExportFileName, outputFileDescription);
        }

        public void LoadUsedGoodTransaction()
        {
            View.UsedGoodTransactionListData = Model.SearchUsedGoodTransaction(View.SparepartNameFilter);
        }

        public void DeleteUsedGoodTransaction()
        {
            Model.DeleteUsedGoodTransaction(View.SelectedUsedGoodTransaction);
        }
    }
}
