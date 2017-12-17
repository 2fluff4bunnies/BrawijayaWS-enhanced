using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.Runtime;
using BrawijayaWorkshop.View;
using LINQtoCSV;
using System.Linq;

namespace BrawijayaWorkshop.Presenter
{
    public class VehicleListPresenter : BasePresenter<IVehicleListView, VehicleListModel>
    {
        public VehicleListPresenter(IVehicleListView view, VehicleListModel model) : base(view, model) { }

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
            var exportVehicles =
                from ve in View.VehicleListData
                select new
                {
                    Nopol = ve.ActiveLicenseNumber,
                    Customer = ve.Customer.CompanyName,
                    Kelompok = ve.VehicleGroup.Name,
                    Merek = ve.Brand.Name,
                    Tipe = ve.Type.Name,
                    TahunPembelian = ve.YearOfPurchase
                };

            cc.Write(exportVehicles, View.ExportFileName, outputFileDescription);
        }

        public void LoadVehicle()
        {
            View.VehicleListData = Model.SearchVehicle(View.ActiveLicenseNumberFilter);
        }

        public void DeleteVehicle()
        {
            Model.DeleteVehicle(View.SelectedVehicle, LoginInformation.UserId);
        }
    }
}
