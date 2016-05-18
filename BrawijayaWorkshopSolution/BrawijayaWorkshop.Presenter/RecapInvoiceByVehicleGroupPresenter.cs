﻿using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.Runtime;
using BrawijayaWorkshop.View;

namespace BrawijayaWorkshop.Presenter
{
    public class RecapInvoiceByVehicleGroupPresenter : BasePresenter<IRecapInvoiceByVehicleGroupView, RecapInvoiceByVehicleGroupModel>
    {
        public RecapInvoiceByVehicleGroupPresenter(IRecapInvoiceByVehicleGroupView view, RecapInvoiceByVehicleGroupModel model)
            : base(view, model) { }

        public void InitFormData()
        {
            View.DateFrom = View.DateTo = System.DateTime.Today;
            View.ListCategory = Model.RetrieveCategories();
            View.ListCustomer = Model.RetrieveCustomers();
        }

        public void OnCustomerSelected()
        {
            View.ListVehicleGroup = Model.RetrieveVehicleGroupsByCustomerId(View.SelectedCustomer);
        }

        public void LoadData()
        {
            View.ListInvoices = Model.RetrieveRecap(View.DateFrom, View.DateTo,
                View.SelectedCategory, View.SelectedCustomer, View.SelectedVehicleGroup);
        }
    }
}