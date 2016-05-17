using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System;
using System.Collections.Generic;

namespace BrawijayaWorkshop.View
{
    public interface IRecapInvoiceByVehicleGroupView : IView
    {
        DateTime DateFrom { get; set; }
        DateTime DateTo { get; set; }

        int SelectedCategory { get; set; }
        List<ReferenceViewModel> ListCategory { get; set; }

        int SelectedCustomer { get; set; }
        List<CustomerViewModel> ListCustomer { get; set; }

        int SelectedVehicleGroup { get; set; }
        List<VehicleGroupViewModel> ListVehicleGroup { get; set; }

        List<RecapInvoiceItemViewModel> ListInvoices { get; set; }
    }
}
