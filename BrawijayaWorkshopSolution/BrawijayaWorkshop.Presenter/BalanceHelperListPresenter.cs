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
    public class BalanceHelperListPresenter : BasePresenter<IBalanceHelperListView, BalanceHelperListModel>
    {
        public BalanceHelperListPresenter(IBalanceHelperListView view, BalanceHelperListModel model)
            : base(view, model) { }

        public void InitFormData()
        {
            View.ListMonth = Model.GenerateMonth();
            View.ListYear = Model.GenerateYear();
            View.SelectedMonth = DateTime.Today.Month;
            View.SelectedYear = DateTime.Today.Year;
            View.ListJournal = Model.RetrieveAllJournal();
        }

        public void LoadData()
        {
            if(View.SelectedJournal > 0)
            {
                View.ListHelper = Model.RetrieveBalanceHelper(View.SelectedYear, View.SelectedMonth, View.SelectedJournal);
            }
        }
    }
}
