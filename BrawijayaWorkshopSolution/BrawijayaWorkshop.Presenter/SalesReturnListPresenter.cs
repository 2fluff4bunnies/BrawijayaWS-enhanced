﻿using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.View;

namespace BrawijayaWorkshop.Presenter
{
    public class SalesReturnListPresenter : BasePresenter<ISalesReturnListView, SalesReturnListModel>
    {
        public SalesReturnListPresenter(ISalesReturnListView view, SalesReturnListModel model)
            : base(view, model) { }

        public void LoadSalesReturn()
        {
            View.SalesReturnListData = Model.SearchSalesReturnList(View.DateFilterFrom, View.DateFilterTo);
        }
    }
}