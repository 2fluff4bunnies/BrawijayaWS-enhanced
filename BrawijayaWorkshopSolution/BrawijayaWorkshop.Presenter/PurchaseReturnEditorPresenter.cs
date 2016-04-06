using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.SharedObject.ViewModels;
using BrawijayaWorkshop.View;
using BrawijayaWorkshop.Utils;
using System.Linq;
using BrawijayaWorkshop.Runtime;
using System;

namespace BrawijayaWorkshop.Presenter
{
    public class PurchaseReturnEditorPresenter : BasePresenter<IPurchaseReturnEditorView, PurchaseReturnEditorModel>
    {
        public PurchaseReturnEditorPresenter(IPurchaseReturnEditorView view, PurchaseReturnEditorModel model)
            : base(view, model) { }

        public void InitFormData()
        {
            if(View.SelectedPurchasing != null)
            {
                View.SupplierName = View.SelectedPurchasing.Supplier.Name;
                if (View.SelectedPurchaseReturn != null)
                {
                    View.Date = View.SelectedPurchaseReturn.CreateDate;
                    View.ListReturn = Model.RetrieveReturnList(View.SelectedPurchaseReturn.Id, View.SelectedPurchasing.Id);
                }
                else
                {
                    View.Date = DateTime.Now;
                    View.ListReturn = Model.RetrieveReturnList(0, View.SelectedPurchasing.Id);
                }
            }
        }

        public void SaveChanges()
        {
            if (View.SelectedPurchaseReturn == null)
            {
                Model.InsertPurchaseReturn(View.SelectedPurchasing.Id, View.ListReturn, LoginInformation.UserId);
            }
            else
            {
                Model.UpdatePurchaseReturn(View.SelectedPurchasing.Id, View.SelectedPurchaseReturn.Id, View.ListReturn, LoginInformation.UserId);
            }
        }
    }
}
