using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System;
using System.Collections.Generic;

namespace BrawijayaWorkshop.View
{
    public interface IGuestBookEditorView : IView
    {
        int VehicleId { get; set; }

        List<VehicleViewModel> VehicleList { get; set; }

        GuestBookViewModel SelectedGuestBook { get; set; }

        string Description { get; set; }
    }
}
