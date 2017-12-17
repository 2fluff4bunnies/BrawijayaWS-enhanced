using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.Runtime;
using BrawijayaWorkshop.View;
using LINQtoCSV;
using System.Linq;

namespace BrawijayaWorkshop.Presenter
{
    public class UserRoleListPresenter : BasePresenter<IUserRoleListView, UserRoleListModel>
    {
        public UserRoleListPresenter(IUserRoleListView view, UserRoleListModel model)
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
            var exportUserRoles =
                from us in View.UserRoleListData
                select new
                {
                    NamaDepan = us.User.FirstName,
                    NamaBelakang = us.User.LastName,
                    Username = us.User.UserName,
                    Role = us.Role.Name,
                    StatusAktif = us.User.IsActive ? "Aktif" : "Tidak Aktif"
                };

            cc.Write(exportUserRoles, View.ExportFileName, outputFileDescription);
        }

        public void InitData()
        {
            View.RoleDropdownListData = Model.RetrieveAllRole();
        }

        public void LoadUserRole()
        {
            View.UserRoleListData = Model.RetrieveUserRoleByRoleId(LoginInformation.UserId, View.SelectedRoleId);
        }

        public void DeleteUserRole()
        {
            Model.DeleteUserRole(View.SelectedUserRole);
        }
    }
}
