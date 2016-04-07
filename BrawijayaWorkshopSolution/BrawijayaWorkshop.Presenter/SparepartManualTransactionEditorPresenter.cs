using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.Runtime;
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
                View.IsWheel = Model.IsThisWheel(View.SparepartId);
            }
            if (View.SelectedSparepartManualTransaction != null)
            {
                View.TransactionTypeId = View.SelectedSparepartManualTransaction.UpdateTypeId;
                View.StockUpdate = View.SelectedSparepartManualTransaction.Qty;
                View.Price = View.SelectedSparepartManualTransaction.Price;
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
            View.SelectedSparepartManualTransaction.Price = View.Price;
            View.SelectedSparepartManualTransaction.Remark = View.Remark;
            View.SelectedSparepartManualTransaction.UpdateTypeId = View.TransactionTypeId;
            View.SelectedSparepartManualTransaction.SerialNumber = View.SerialNumber;

            if (View.SelectedSparepartManualTransaction.Id > 0)
            {
                Model.UpdateSparepartManualTransaction(View.SelectedSparepartManualTransaction, LoginInformation.UserId);
            }
            else
            {
                Model.InsertSparepartManualTransaction(View.SelectedSparepartManualTransaction, View.TotalPrice, LoginInformation.UserId);
            }
        }
    }
}
