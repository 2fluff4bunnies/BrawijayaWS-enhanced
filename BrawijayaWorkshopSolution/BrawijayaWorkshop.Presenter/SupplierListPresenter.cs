using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.Runtime;
using BrawijayaWorkshop.View;
using LINQtoCSV;
using System.Linq;

namespace BrawijayaWorkshop.Presenter
{
    public class SupplierListPresenter : BasePresenter<ISupplierListView, SupplierListModel>
    {
        public SupplierListPresenter(ISupplierListView view, SupplierListModel model)
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
            var exportSuppliers =
                from sup in View.SupplierListData
                select new
                {
                    Nama = sup.Name,
                    Alamat = sup.Address,
                    Telepon = sup.PhoneNumber,
                    Kota = sup.City.Name
                };

            cc.Write(exportSuppliers, View.ExportFileName, outputFileDescription);
        }

        public void LoadSupplier()
        {
            View.SupplierListData = Model.SearchSupplier(View.SupplierNameFilter);
        }

        public void DeleteSupplier()
        {
            Model.DeleteSupplier(View.SelectedSupplier, LoginInformation.UserId);
        }
    }
}
