using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.Runtime;
using BrawijayaWorkshop.View;
using System;

namespace BrawijayaWorkshop.Presenter
{
    public class ManualTransactionListPresenter : BasePresenter<IManualTransactionListView, ManualTransactionListModel>
    {
        public ManualTransactionListPresenter(IManualTransactionListView view, ManualTransactionListModel model)
            : base(view, model) { }

        public void InitFormData()
        {
            DateTime today = DateTime.Today;
            View.From = new DateTime(today.Year, today.Month, 1);
            DateTime endDate = View.From.AddMonths(1).AddDays(-1);
            View.To = new DateTime(endDate.Year, endDate.Month, endDate.Day);
        }

        public void LoadData()
        {
            View.TransactionListData = Model.RetrieveManualTransaction(View.From, View.To);
        }

        public void DeleteManualTransaction()
        {
            Model.DeleteManualTransaction(View.SelectedTransaction, LoginInformation.UserId);
        }
    }
}
