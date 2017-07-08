using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.SharedObject.ViewModels;
using BrawijayaWorkshop.View;
using System;
using System.Collections.Generic;

namespace BrawijayaWorkshop.Presenter
{
    public class CreditListPresenter : BasePresenter<ICreditListView, CreditListModel>
    {
        public CreditListPresenter(ICreditListView view, CreditListModel model)
            : base(view, model) { }

        public void InitData()
        {
            View.DateFromFilter = DateTime.Now;
            View.DateToFilter = DateTime.Now;
            List<CustomerViewModel> listCustomer = Model.GetAllCustomer();
            listCustomer.Insert(0, new CustomerViewModel
            {
                Id = 0,
                CompanyName = "Semua",
                Address = "Semua"
            });
            View.CustomerListOption = listCustomer;
            List<VehicleGroupViewModel> listVehicleGroup = new List<VehicleGroupViewModel>();
            listVehicleGroup.Insert(0, new VehicleGroupViewModel
            {
                Id = 0,
                Name = "Semua"
            });
            View.VehicleGroupListOption = listVehicleGroup;
        }

        public void LoadVehicleGroups()
        {
            List<VehicleGroupViewModel> listVehicleGroup = new List<VehicleGroupViewModel>();
            if (View.SelectedCustomerId > 0)
            {
                listVehicleGroup = Model.GetVehicleGroupByCustomer(View.SelectedCustomerId);
            }
            listVehicleGroup.Insert(0, new VehicleGroupViewModel
            {
                Id = 0,
                Name = "Semua"
            });
            View.VehicleGroupListOption = listVehicleGroup;
        }

        public void LoadInvoiceList()
        {
            int paymentStatus = -1;
            if (string.Compare(View.CreditStatusPayment, "Belum Lunas", true) == 0)
            {
                paymentStatus = 0;
            }
            if (string.Compare(View.CreditStatusPayment, "Lunas", true) == 0)
            {
                paymentStatus = 1;
            }

            View.InvoiceListData = Model.SearchTransaction(View.DateFromFilter, View.DateToFilter, View.SelectedCustomerId,
            View.SelectedVehicleGroupId, View.LicenseNumberFilter, paymentStatus);
        }
    }
}
