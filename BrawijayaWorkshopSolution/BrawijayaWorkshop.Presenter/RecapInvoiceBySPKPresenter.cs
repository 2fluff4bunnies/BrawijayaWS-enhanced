using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.Runtime;
using BrawijayaWorkshop.View;

namespace BrawijayaWorkshop.Presenter
{
    public class RecapInvoiceBySPKPresenter : BasePresenter<IRecapInvoiceBySPKView, RecapInvoiceBySPKModel>
    {
        public RecapInvoiceBySPKPresenter(IRecapInvoiceBySPKView view, RecapInvoiceBySPKModel model)
            : base(view, model) { }

        public void InitFormData()
        {
            View.ListCustomer = Model.RetrieveCustomers();
        }

        public void LoadData()
        {
            View.ListInvoices = Model.RetrieveRecap(View.DateFrom, View.DateTo, View.SelectedCustomer);
        }
    }
}
