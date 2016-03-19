using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.Runtime;
using BrawijayaWorkshop.View;
using System;

namespace BrawijayaWorkshop.Presenter
{
    public class HPPListPresenter : BasePresenter<IHPPListView, HPPListModel>
    {
        public HPPListPresenter(IHPPListView view, HPPListModel model)
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
            View.AvailableHeader = Model.RetrieveHPPHeader(View.SelectedMonth, View.SelectedYear);
            if (View.AvailableHeader != null)
            {
                View.HPPDetailList = Model.RetrieveHPPDetailsByHeaderId(View.AvailableHeader.Id);
            }
        }

        public void Recalculate()
        {
            Model.RecalculateHPP(View.SelectedMonth, View.SelectedYear, LoginInformation.UserId);
        }
    }
}
