using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.View;
using LINQtoCSV;
using System.Linq;

namespace BrawijayaWorkshop.Presenter
{
    public class RoleListPresenter : BasePresenter<IRoleListView, RoleListModel>
    {
        public RoleListPresenter(IRoleListView view, RoleListModel model)
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
            var exportRoles =
                from role in View.RoleListData
                select new
                {
                    Nama = role.Name
                };

            cc.Write(exportRoles, View.ExportFileName, outputFileDescription);
        }

        public void LoadRole()
        {
            View.RoleListData = Model.SearchRole(View.NameFilter);
        }

        public void DeleteRole()
        {
            Model.DeleteRole(View.SelectedRole);
        }
    }
}
