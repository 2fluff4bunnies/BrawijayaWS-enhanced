using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.View;
using LINQtoCSV;
using System.Linq;

namespace BrawijayaWorkshop.Presenter
{
    public class GuestBookListPresenter : BasePresenter<IGuestBookListView, GuestBookListModel>
    {
        public GuestBookListPresenter(IGuestBookListView view, GuestBookListModel model) : base(view, model) { }

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
            var exportGuestBooks =
                from gb in View.GuestBookListData
                select new
                {
                    Nopol = gb.Vehicle.ActiveLicenseNumber,
                    Customer = gb.Vehicle.Customer.CompanyName,
                    Merek = gb.Vehicle.Brand.Name,
                    Tipe = gb.Vehicle.Type.Name,
                    WaktuKedatangan = gb.ArrivalTime,
                    Keterangan = gb.Description
                };

            cc.Write(exportGuestBooks, View.ExportFileName, outputFileDescription);
        }

        public void LoadGuestBook()
        {
            View.GuestBookListData = Model.SearchGuestBook(View.ActiveLicenseNumberFilter, View.CreatedDateFilter);
        }

        public void DeleteGuestBook()
        {
            Model.DeleteGuestBook(View.SelectedGuestBook);
        }
    }
}
