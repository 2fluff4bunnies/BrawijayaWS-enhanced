using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.Runtime;
using BrawijayaWorkshop.View;
using System;

namespace BrawijayaWorkshop.Presenter
{
    public class ProfitLossPresenter : BasePresenter<IProfitLossView, ProfitLossModel>
    {
        public ProfitLossPresenter(IProfitLossView view, ProfitLossModel model)
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
            View.AvailableBalanceJournal = Model.RetrieveBalanceJournalHeader(View.SelectedMonth, View.SelectedYear);
            if (View.AvailableBalanceJournal != null)
            {
                View.ProfitLossList = Model.RetrieveProfitLoss(View.AvailableBalanceJournal.Id);
            }
        }

        public void Recalculate()
        {
            Model.RecalculateBalanceJournal(View.SelectedMonth, View.SelectedYear, LoginInformation.UserId);
        }
    }
}
