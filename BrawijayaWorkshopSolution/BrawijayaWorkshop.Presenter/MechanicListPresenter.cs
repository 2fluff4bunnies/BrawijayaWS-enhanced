using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.Runtime;
using BrawijayaWorkshop.View;
using LINQtoCSV;
using System.Linq;

namespace BrawijayaWorkshop.Presenter
{
    public class MechanicListPresenter : BasePresenter<IMechanicListView, MechanicListModel>
    {
        public MechanicListPresenter(IMechanicListView view, MechanicListModel model)
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
            var exportMechanics =
                from m in View.MechanicListData
                select new
                {
                    Kode = m.Code,
                    Nama = m.Name,
                    Alamat = m.Address,
                    Telepon = m.PhoneNumber
                };

            cc.Write(exportMechanics, View.ExportFileName, outputFileDescription);
        }

        public void LoadMechanic()
        {
            View.FingerprintIP = Model.GetFingerprintIpAddress();
            View.FingerpringPort = Model.GetFingerprintPort();
            View.MechanicListData = Model.SearchMechanic(View.MechanicNameFilter);
        }

        public void DeleteMechanic()
        {
            Model.DeleteMechanic(View.SelectedMechanic, LoginInformation.UserId);
        }
    }
}
