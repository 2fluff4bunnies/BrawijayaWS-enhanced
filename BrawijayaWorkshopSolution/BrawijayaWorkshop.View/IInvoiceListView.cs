using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System;
using System.Collections.Generic;

namespace BrawijayaWorkshop.View
{
    public interface IInvoiceListView : IView
    {
        DateTime? DateFromFilter { get; set; }

        DateTime? DateToFilter { get; set; }

        int InvoiceStatusFilter { get; set; }

        int SelectedCustomerId { get; }

        string InvoiceStatusPayment { get; }

        string ExportFileName { get; set; }

        List<InvoiceViewModel> InvoiceListData { get; set; }

        InvoiceViewModel SelectedInvoice { get; set; }

        List<InvoiceStatusItem> InvoiceStatusList { get; set; }

        List<CustomerViewModel> CustomerListOption { get; set; }

        List<ReferenceViewModel> ServiceCategoryList { get; set; }

        int ServiceCategoryFilter { get;}
        List<VehicleGroupViewModel> VehicleGroupListOption { get; set; }
        int SelectedVehicleGroupId { get; }
        string LicenseNumberFilter { get; }





    }

    public class InvoiceStatusItem
    {
        public int Status { get; set; }
        public string Description { get; set; }
    }
}
