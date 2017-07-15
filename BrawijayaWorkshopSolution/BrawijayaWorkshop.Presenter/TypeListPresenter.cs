using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.View;
using LINQtoCSV;
using System.Linq;

namespace BrawijayaWorkshop.Presenter
{
    public class TypeListPresenter : BasePresenter<ITypeListView, TypeListModel>
    {
        public TypeListPresenter(ITypeListView view, TypeListModel model)
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
            var exportTypes =
                from ty in View.TypeListData
                select new
                {
                    Nama = ty.Name,
                    Deskipsi = ty.Description,
                };

            cc.Write(exportTypes, View.ExportFileName, outputFileDescription);
        }

        public void LoadType()
        {
            View.TypeListData = Model.SearchType(View.NameFilter);
        }

        public void DeleteType()
        {
            Model.DeleteType(View.SelectedType);
        }
    }
}
