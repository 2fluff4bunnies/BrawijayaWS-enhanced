using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.Runtime;
using BrawijayaWorkshop.SharedObject.ViewModels;
using BrawijayaWorkshop.View;
using BrawijayaWorkshop.Utils;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BrawijayaWorkshop.Presenter
{
    public class ManualTransactionEditorPresenter : BasePresenter<IManualTransactionEditorView, ManualTransactionEditorModel>
    {
        public ManualTransactionEditorPresenter(IManualTransactionEditorView view, ManualTransactionEditorModel model)
            : base(view, model) { }

        public void InitFormData()
        {
            View.JournalList = Model.RetrieveAllJournal();
            View.TransactionDate = DateTime.Today;

            if(View.SelectedTransaction != null)
            {
                View.TransactionDate = View.SelectedTransaction.TransactionDate;
                View.TotalTransaction = View.SelectedTransaction.TotalTransaction;
                View.TransactionDescription = View.SelectedTransaction.Description;
                View.TransactionDetailList = Model.RetrieveTransactionDetail(View.SelectedTransaction.Id);
            }
            else
            {
                View.TransactionDetailList = new List<TransactionDetailViewModel>();
            }
        }

        public void SaveChanges()
        {
            if (!ValidateTransaction()) return;

            if (View.SelectedTransaction == null)
            {
                View.SelectedTransaction = new TransactionViewModel();
            }

            View.SelectedTransaction.TransactionDate = View.TransactionDate;
            View.SelectedTransaction.Description = View.TransactionDescription;
            View.SelectedTransaction.TotalTransaction = View.TotalTransaction;
            View.SelectedTransaction.TotalPayment = View.TotalTransaction;

            if(View.SelectedTransaction.Id > 0)
            {
                Model.UpdateTransaction(View.SelectedTransaction, View.TransactionDetailList, 
                    LoginInformation.UserId);
            }
            else
            {
                Model.InsertTransaction(View.SelectedTransaction, View.TransactionDetailList,
                    LoginInformation.UserId);
            }
        }

        public void CalculateTotalTransaction()
        {
            double result = 0;
            foreach (var item in View.TransactionDetailList)
            {
                if(item.Debit.HasValue)
                {
                    result += item.Debit.AsDouble();
                }
            }
            View.TotalTransaction = result;
        }

        public bool ValidateTransaction()
        {
            if(View.TransactionDetailList.Count > 0)
            {
                double totalTransaction = View.TransactionDetailList.Sum(td => td.Credit - td.Debit).AsDouble();
                return totalTransaction == 0;
            }
            return false;
        }
    }
}
