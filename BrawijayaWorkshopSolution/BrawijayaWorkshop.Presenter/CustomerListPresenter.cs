using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.View;

namespace BrawijayaWorkshop.Presenter
{
    public class CustomerListPresenter : BasePresenter<ICustomerListView, CustomerListModel>
    {
        public CustomerListPresenter(ICustomerListView view, CustomerListModel model)
            : base(view, model) { }

        public void LoadCustomer()
        {
            View.CustomerListData = Model.SearchCustomer(View.CompanyNameFilter);
        }

        public void DeleteCustomer()
        {
            Model.DeleteCustomer(View.SelectedCustomer);
        }
    }
}
