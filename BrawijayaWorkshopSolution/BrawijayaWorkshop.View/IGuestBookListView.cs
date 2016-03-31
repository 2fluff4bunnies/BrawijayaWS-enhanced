using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System;
using System.Collections.Generic;

namespace BrawijayaWorkshop.View
{
    public interface IGuestBookListView : IView
    {
        GuestBookViewModel SelectedGuestBook { get; set; }

        string ActiveLicenseNumberFilter { get; set; }

        List<GuestBookViewModel> GuestBookListData { get; set; }

        DateTime CreatedDateFilter { get; set; }
    }
}
