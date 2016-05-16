using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System;
using System.Collections.Generic;

namespace BrawijayaWorkshop.View
{
    public interface IRecapInvoiceBySPKView : IView
    {
        DateTime DateFrom { get; set; }
        DateTime DateTo { get; set; }

        int SelectedVehicle { get; set; }
        List<VehicleViewModel> ListVehicles { get; set; }

        List<InvoiceViewModel> ListInvoices { get; set; }
    }
}
