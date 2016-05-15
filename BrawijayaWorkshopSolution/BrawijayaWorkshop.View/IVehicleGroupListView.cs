using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System.Collections.Generic;

namespace BrawijayaWorkshop.View
{
    public interface IVehicleGroupListView : IView
    {
        List<CustomerViewModel> ListCustomer { get; set; }
        int SelectedCustomerId { get; set; }
        string GroupNameFilter { get; set; }

        List<VehicleGroupViewModel> ListVehicleGroupData { get; set; }
        VehicleGroupViewModel SelectedGroup { get; set; }
    }
}
