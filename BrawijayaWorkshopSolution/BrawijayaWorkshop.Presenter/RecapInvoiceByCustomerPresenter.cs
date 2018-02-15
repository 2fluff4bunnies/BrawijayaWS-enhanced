using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.Runtime;
using BrawijayaWorkshop.SharedObject.ViewModels;
using BrawijayaWorkshop.View;

namespace BrawijayaWorkshop.Presenter
{
    public class RecapInvoiceByCustomerPresenter : BasePresenter<IRecapInvoiceByCustomerView, RecapInvoiceByCustomerModel>
    {
        public RecapInvoiceByCustomerPresenter(IRecapInvoiceByCustomerView view, RecapInvoiceByCustomerModel model)
            : base(view, model) { }

        public void InitFormData()
        {
            View.DateFrom = View.DateTo = System.DateTime.Today;
            View.ListCategory = Model.RetrieveCategories();
            View.ListCategory.Add(new ReferenceViewModel
            {
                Id = -1,
                Description = "Semua Kategori",
                Name = "Semua Kategori"
            });
            View.ListCustomer = Model.RetrieveCustomers();
        }

        public void LoadData()
        {
            View.ListInvoices = Model.RetrieveRecap(View.DateFrom, View.DateTo,
                View.SelectedCategory, View.SelectedCustomer);
        }
    }
}
