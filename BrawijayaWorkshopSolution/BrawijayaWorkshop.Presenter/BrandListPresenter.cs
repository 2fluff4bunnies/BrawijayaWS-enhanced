using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.View;
using LINQtoCSV;
using System.Linq;

namespace BrawijayaWorkshop.Presenter
{
    public class BrandListPresenter : BasePresenter<IBrandListView, BrandListModel>
    {
        public BrandListPresenter(IBrandListView view, BrandListModel model)
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
            var exportBrands =
                from pur in View.BrandListData
                select new
                {
                    Nama = pur.Name,
                    Deskripsi = pur.Description,
                };

            cc.Write(exportBrands, View.ExportFileName, outputFileDescription);
        }

        public void LoadBrand()
        {
            View.BrandListData = Model.SearchBrand(View.NameFilter);
        }

        public void DeleteBrand()
        {
            Model.DeleteBrand(View.SelectedBrand);
        }
    }
}
