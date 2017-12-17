using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.Runtime;
using BrawijayaWorkshop.View;
using LINQtoCSV;
using System.Linq;

namespace BrawijayaWorkshop.Presenter
{
    public class VehicleGroupListPresenter : BasePresenter<IVehicleGroupListView, VehicleGroupListModel>
    {
        public VehicleGroupListPresenter(IVehicleGroupListView view, VehicleGroupListModel model)
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
            var exportVehicleGroups =
                from ve in View.ListVehicleGroupData
                select new
                {
                    NamaPerusahaan = ve.Customer.CompanyName,
                    NamaKelompok = ve.Name,
                };

            cc.Write(exportVehicleGroups, View.ExportFileName, outputFileDescription);
        }

        public void InitFormData()
        {
            View.ListCustomer = Model.RetrieveAllCustomer();
        }

        public void LoadData()
        {
            View.ListVehicleGroupData = Model.RetrieveVehicleGroup(View.SelectedCustomerId, View.GroupNameFilter);
        }

        public void DeleteSelectedGroup()
        {
            Model.DeleteVehicleGroup(View.SelectedGroup, LoginInformation.UserId);
        }
    }
}
