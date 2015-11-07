using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Infrastructure.MVP;
using System.Collections.Generic;

namespace BrawijayaWorkshop.View
{
    public interface ICustomerListView : IView
    {
        string CompanyNameFilter { get; set; }

        List<Customer> CustomerListData { get; set; }

        Customer SelectedCustomer { get; set; }
    }
}
