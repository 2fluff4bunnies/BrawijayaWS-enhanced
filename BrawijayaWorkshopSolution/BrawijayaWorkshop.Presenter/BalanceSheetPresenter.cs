using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.Runtime;
using BrawijayaWorkshop.SharedObject.ViewModels;
using BrawijayaWorkshop.View;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BrawijayaWorkshop.Presenter
{
    public class BalanceSheetPresenter : BasePresenter<IBalanceSheetView, BalanceSheetModel>
    {
        public BalanceSheetPresenter(IBalanceSheetView view, BalanceSheetModel model)
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
                View.ActivaList = Model.RetrieveBalance(View.AvailableBalanceJournal.Id, true);
                View.PassivaList = Model.RetrieveBalance(View.AvailableBalanceJournal.Id, false);
            }
        }

        public void Recalculate()
        {
            Model.RecalculateBalanceJournal(View.SelectedMonth, View.SelectedYear, LoginInformation.UserId);
        }
    }
}
