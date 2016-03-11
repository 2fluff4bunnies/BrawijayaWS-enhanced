using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.SharedObject.ViewModels;
using BrawijayaWorkshop.View;

namespace BrawijayaWorkshop.Presenter
{
    public class  SparepartManualTransactionEditorPresenter : BasePresenter<ISparepartManualTransactionEditorView, SparepartManualTransactionEditorModel>
    {
        public SparepartManualTransactionEditorPresenter(ISparepartManualTransactionEditorView view, SparepartManualTransactionEditorModel model)
            : base(view, model) { }

        public void InitFormData()
        {
            View.ListTransactionTypeReference = Model.RetrieveTransactionType();
            if(View.Sparepart != null)
            {
                View.SparepartId = View.Sparepart.Id;
                View.SparepartName = View.Sparepart.Name;
                View.Stock = View.Sparepart.StockQty;
            }
            if (View.SelectedSparepartManualTransaction != null)
            {
                View.TransactionTypeId = View.SelectedSparepartManualTransaction.UpdateTypeId;
                View.StockUpdate = View.SelectedSparepartManualTransaction.Qty;
                View.Remark = View.SelectedSparepartManualTransaction.Remark;
            }
        }

        public void SaveChanges()
        {
            if (View.SelectedSparepartManualTransaction == null)
            {
                View.SelectedSparepartManualTransaction = new SparepartManualTransactionViewModel();
            }

            View.SelectedSparepartManualTransaction.SparepartId = View.SparepartId;
            View.SelectedSparepartManualTransaction.Qty = View.StockUpdate;
            View.SelectedSparepartManualTransaction.Remark = View.Remark;
            View.SelectedSparepartManualTransaction.UpdateTypeId = View.TransactionTypeId;
            View.SelectedSparepartManualTransaction.Sparepart = View.Sparepart;
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
