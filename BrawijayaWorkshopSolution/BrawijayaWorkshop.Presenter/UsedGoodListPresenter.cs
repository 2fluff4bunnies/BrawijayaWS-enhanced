using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.View;
using LINQtoCSV;
using System.Linq;

namespace BrawijayaWorkshop.Presenter
{
    public class UsedGoodListPresenter : BasePresenter<IUsedGoodListView, UsedGoodListModel>
    {
        public UsedGoodListPresenter(IUsedGoodListView view, UsedGoodListModel model)
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
            var exportSpareparts =
                from sp in View.UsedGoodListData
                select new
                {
                    Sparepart = sp.Sparepart.Name,
                    Stock = sp.Stock
                };

            cc.Write(exportSpareparts, View.ExportFileName, outputFileDescription);
        }

        public void LoadUsedGood()
        {
            View.UsedGoodListData = Model.SearchUsedGood(View.SparepartNameFilter);
        }

        public void DeleteUsedGood()
        {
            Model.DeleteUsedGood(View.SelectedUsedGood);
        }
    }
}
