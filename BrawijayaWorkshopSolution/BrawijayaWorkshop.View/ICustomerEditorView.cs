using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System.Collections.Generic;

namespace BrawijayaWorkshop.View
{
    public interface ICustomerEditorView : IView
    {
        CustomerViewModel SelectedCustomer { get; set; }

        string Code { get; set; }
        string CompanyName { get; set; }
        string Address { get; set; }
        string PhoneNumber { get; set; }
        string ContactPerson { get; set; }
        int CityId { get; set; }

        List<CityViewModel> ListCity { get; set; }
    }
}
