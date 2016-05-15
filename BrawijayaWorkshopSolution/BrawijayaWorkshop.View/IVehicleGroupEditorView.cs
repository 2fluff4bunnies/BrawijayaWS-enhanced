using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System.Collections.Generic;

namespace BrawijayaWorkshop.View
{
    public interface IVehicleGroupEditorView : IView
    {
        VehicleGroupViewModel SelectedGroup { get; set; }

        List<CustomerViewModel> ListCustomer { get; set; }

        int CustomerId { get; set; }
        string GroupName { get; set; }
    }
}
