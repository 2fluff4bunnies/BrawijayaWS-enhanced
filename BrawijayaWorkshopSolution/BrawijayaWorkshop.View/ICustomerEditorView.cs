using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Infrastructure.MVP;
using System.Collections.Generic;

namespace BrawijayaWorkshop.View
{
    public interface ICustomerEditorView : IView
    {
        Customer SelectedCustomer { get; set; }

        string Code { get; set; }
        string CompanyName { get; set; }
        string Address { get; set; }
        string PhoneNumber { get; set; }
        string ContactPerson { get; set; }
        int CityId { get; set; }

        List<City> ListCity { get; set; }
    }
}
