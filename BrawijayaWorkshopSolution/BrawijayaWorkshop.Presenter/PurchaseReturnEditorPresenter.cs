using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.SharedObject.ViewModels;
using BrawijayaWorkshop.View;
using BrawijayaWorkshop.Utils;
using System.Linq;
using BrawijayaWorkshop.Runtime;

namespace BrawijayaWorkshop.Presenter
{
    public class PurchaseReturnEditorPresenter : BasePresenter<IPurchaseReturnEditorView, PurchaseReturnEditorModel>
    {
        public PurchaseReturnEditorPresenter(IPurchaseReturnEditorView view, PurchaseReturnEditorModel model)
            : base(view, model) { }

        public void InitFormData()
        {
            if (View.SelectedPurchaseReturn != null)
            {
                View.ListPurchaseReturnDetail = Model.RetrievePurchaseReturnDetail(View.SelectedPurchaseReturn.Id);
                View.Date = View.SelectedPurchaseReturn.CreateDate;
                View.SupplierName = View.SelectedPurchaseReturn.Purchasing.Supplier.Name;
            }
        }

        public void SaveChanges()
        {
            
        }
    }
}
