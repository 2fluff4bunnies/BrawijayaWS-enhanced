using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.Runtime;
using BrawijayaWorkshop.View;
using LINQtoCSV;
using System.Linq;

namespace BrawijayaWorkshop.Presenter
{
    public class ManageUserListPresenter : BasePresenter<IManageUserListView, ManageUserListModel>
    {
        public ManageUserListPresenter(IManageUserListView view, ManageUserListModel model)
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
            var exportRoles =
                from ro in View.UserRoleListData
                select new
                {
                    NamaDepan = ro.User.FirstName,
                    NamaBelakang = ro.User.LastName,
                    Username = ro.User.UserName,
                    Role = ro.Role.Name,
                    StatusActive = ro.User.IsActive ? "Aktif" : "Tidak Aktif"
                };

            cc.Write(exportRoles, View.ExportFileName, outputFileDescription);
        }

        public void InitFormData()
        {
            View.IsActive = true;
            View.RoleDropdownListData = Model.RetrieveRoles();
        }

        public void LoadData()
        {
            View.UserRoleListData = Model.RetrieveUsers(LoginInformation.UserId, View.SelectedRoleId, View.FilterName);
        }

        public void DeleteUser()
        {
            if (View.SelectedUserRole != null)
            {
                Model.DeleteUser(View.SelectedUserRole.UserId);
            }
        }
    }
}
