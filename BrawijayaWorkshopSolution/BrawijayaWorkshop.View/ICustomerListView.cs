using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System.Collections.Generic;

namespace BrawijayaWorkshop.View
{
    public interface ICustomerListView : IView
    {
        string CompanyNameFilter { get; set; }

        List<CustomerViewModel> CustomerListData { get; set; }

        CustomerViewModel SelectedCustomer { get; set; }

        string ExportFileName { get; }
    }
}
