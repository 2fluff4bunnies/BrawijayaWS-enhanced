using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.SharedObject.ViewModels;
using BrawijayaWorkshop.View;

namespace BrawijayaWorkshop.Presenter
{
    public class SparepartManualTransactionEditorPresenter : BasePresenter<ISparepartManualTransactionEditorView, SparepartManualTransactionEditorModel>
    {
        public SparepartManualTransactionEditorPresenter(ISparepartManualTransactionEditorView view, SparepartManualTransactionEditorModel model)
            : base(view, model) { }

        public void InitFormData()
        {
            View.ListTransactionTypeReference = Model.RetrieveTransactionType();

            if (View.SelectedSparepartManualTransaction != null)
            {
                View.SparepartId = View.SelectedSparepartManualTransaction.SparepartId;
            }
        }

        public void SaveChanges()
        {
            if (View.SelectedSparepartManualTransaction == null)
            {
                View.SelectedSparepartManualTransaction = new SparepartManualTransactionViewModel();
            }

            View.SelectedSparepartManualTransaction.SparepartId = View.SparepartId;

            if (View.SelectedSparepartManualTransaction.Id > 0)
            {
                Model.UpdateSparepartManualTransaction(View.SelectedSparepartManualTransaction);
            }
            else
            {
                Model.InsertSparepartManualTransaction(View.SelectedSparepartManualTransaction);
            }
        }
    }
}
