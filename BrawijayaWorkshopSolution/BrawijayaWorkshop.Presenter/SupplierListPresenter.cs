using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.Runtime;
using BrawijayaWorkshop.View;

namespace BrawijayaWorkshop.Presenter
{
    public class SupplierListPresenter : BasePresenter<ISupplierListView, SupplierListModel>
    {
        public SupplierListPresenter(ISupplierListView view, SupplierListModel model)
            : base(view, model) { }

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
