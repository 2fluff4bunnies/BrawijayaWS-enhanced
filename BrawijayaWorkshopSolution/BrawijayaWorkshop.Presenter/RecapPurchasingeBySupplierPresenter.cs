using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.Runtime;
using BrawijayaWorkshop.View;

namespace BrawijayaWorkshop.Presenter
{
    public class RecapPurchasingBySupplierPresenter : BasePresenter<IRecapPurchasingBySupplierView, RecapPurchasingModel>
    {
        public RecapPurchasingBySupplierPresenter(IRecapPurchasingBySupplierView view, RecapPurchasingModel model)
            : base(view, model) { }

        public void InitFormData()
        {
            View.DateFrom = View.DateTo = System.DateTime.Today;
            View.ListSupplier = Model.RetrieveSuppliers();
        }

        public void LoadData()
        {
            View.ListPurchasing = Model.RetrieveRecap(View.DateFrom, View.DateTo, View.SelectedSupplier);
        }
    }
}
