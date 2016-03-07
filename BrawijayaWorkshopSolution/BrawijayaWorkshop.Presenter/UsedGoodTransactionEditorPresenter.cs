using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
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

            if (View.SelectedUsedGoodTransaction != null)
            {
                View.UsedGoodId = View.SelectedUsedGoodTransaction.UsedGoodId;
            }
        }

        public void SaveChanges()
        {
            if (View.SelectedUsedGoodTransaction == null)
            {
                View.SelectedUsedGoodTransaction = new UsedGoodTransactionViewModel();
            }

            View.SelectedUsedGoodTransaction.UsedGoodId = View.UsedGoodId;

            if (View.SelectedUsedGoodTransaction.Id > 0)
            {
                Model.UpdateUsedGoodTransaction(View.SelectedUsedGoodTransaction);
            }
            else
            {
                Model.InsertUsedGoodTransaction(View.SelectedUsedGoodTransaction);
            }
        }
    }
}
