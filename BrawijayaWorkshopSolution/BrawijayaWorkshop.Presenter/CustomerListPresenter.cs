using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.Runtime;
using BrawijayaWorkshop.View;
using LINQtoCSV;
using System.Linq;

namespace BrawijayaWorkshop.Presenter
{
    public class CustomerListPresenter : BasePresenter<ICustomerListView, CustomerListModel>
    {
        public CustomerListPresenter(ICustomerListView view, CustomerListModel model)
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
            var exportCustomers =
                from cs in View.CustomerListData
                select new
                {
                    Kode = cs.Code,
                    Perusahaan = cs.CompanyName,
                    Alamat = cs.Address,
                    Kota = cs.City.Name,
                    Telepon = cs.PhoneNumber,
                    NamaKontak = cs.ContactPerson
                };

            cc.Write(exportCustomers, View.ExportFileName, outputFileDescription);
        }

        public void LoadCustomer()
        {
            View.CustomerListData = Model.SearchCustomer(View.CompanyNameFilter);
        }

        public void DeleteCustomer()
        {
            Model.DeleteCustomer(View.SelectedCustomer, LoginInformation.UserId);
        }
    }
}
