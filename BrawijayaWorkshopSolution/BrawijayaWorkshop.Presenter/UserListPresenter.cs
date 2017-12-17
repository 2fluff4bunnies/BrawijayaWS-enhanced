using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.Runtime;
using BrawijayaWorkshop.View;
using LINQtoCSV;
using System.Linq;

namespace BrawijayaWorkshop.Presenter
{
    public class UserListPresenter : BasePresenter<IUserListView, UserListModel>
    {
        public UserListPresenter(IUserListView view, UserListModel model) : base(view, model) { }

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
            var exportUsers =
                from us in View.UserListData
                select new
                {
                    NamaDepan = us.FirstName,
                    NamaBelakang = us.LastName,
                    Username = us.UserName,
                    StatusAktif = us.IsActive ? "Aktif" : "Tidak Aktif"
                };

            cc.Write(exportUsers, View.ExportFileName, outputFileDescription);
        }

        public void LoadUser()
        {
            View.UserListData = Model.SearchUser(LoginInformation.UserId, View.FilterName, View.FilterIsActive);
        }

        public void DeleteUser()
        {
            Model.DeleteUser(View.SelectedUser.Id);
        }
    }
}
