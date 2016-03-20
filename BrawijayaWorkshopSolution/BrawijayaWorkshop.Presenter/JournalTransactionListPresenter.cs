using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.View;
using System;

namespace BrawijayaWorkshop.Presenter
{
    public class JournalTransactionListPresenter : BasePresenter<IJournalTransactionListView, JournalTransactionListModel>
    {
        public JournalTransactionListPresenter(IJournalTransactionListView view, JournalTransactionListModel model)
            : base(view, model) { }

        public void InitFormData()
        {
            View.ListMonth = Model.GenerateMonth();
            View.ListYear = Model.GenerateYear();
            View.SelectedMonth = DateTime.Today.Month;
            View.SelectedYear = DateTime.Today.Year;
        }

        public void LoadData()
        {
            if (View.SelectedMonth == 0 || View.SelectedYear == 0) return;

            View.JournalTransactionList = Model.RetrieveAllTransaction(View.SelectedMonth, View.SelectedYear);
        }
    }
}
