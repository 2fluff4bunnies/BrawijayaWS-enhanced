using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.Runtime;
using BrawijayaWorkshop.SharedObject.ViewModels;
using BrawijayaWorkshop.View;

namespace BrawijayaWorkshop.Presenter
{
    public class UsedGoodTransactionEditorPresenter : BasePresenter<IUsedGoodTransactionEditorView, UsedGoodTransactionEditorModel>
    {
        public UsedGoodTransactionEditorPresenter(IUsedGoodTransactionEditorView view, UsedGoodTransactionEditorModel model)
            : base(view, model) { }

        public void InitFormData()
        {
            View.ListTransactionTypeReference = Model.RetrieveTransactionType(View.IsManual);
            View.UsedGoodListCombo = Model.RetrieveUsedGoodList();
            if (View.UsedGood != null)
            {
                View.UsedGoodId = View.UsedGood.Id;
                View.Stock = View.UsedGood.Stock;
            }
            if (View.SelectedUsedGoodTransaction != null)
            {
                View.TransactionTypeId = View.SelectedUsedGoodTransaction.TypeReferenceId;
                View.StockUpdate = View.SelectedUsedGoodTransaction.Qty;
                View.ItemPrice = View.SelectedUsedGoodTransaction.ItemPrice;
                View.Remark = View.SelectedUsedGoodTransaction.Remark;
            }
        }

        public void SaveChanges()
        {
            if (View.SelectedUsedGoodTransaction == null)
            {
                View.SelectedUsedGoodTransaction = new UsedGoodTransactionViewModel();
            }

            View.SelectedUsedGoodTransaction.UsedGoodId = View.UsedGoodId;
            View.SelectedUsedGoodTransaction.Qty = View.StockUpdate;
            View.SelectedUsedGoodTransaction.ItemPrice = View.ItemPrice;
            View.SelectedUsedGoodTransaction.Remark = View.Remark;
            View.SelectedUsedGoodTransaction.TypeReferenceId = View.TransactionTypeId;
            if (View.SelectedUsedGoodTransaction.Id > 0)
            {
                Model.UpdateUsedGoodTransaction(View.SelectedUsedGoodTransaction, LoginInformation.UserId);
            }
            else
            {
                Model.InsertUsedGoodTransaction(View.SelectedUsedGoodTransaction, LoginInformation.UserId);
            }
        }
    }
}
