using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System.Collections.Generic;

namespace BrawijayaWorkshop.View
{
    public interface IConfigEditorView : IView
    {
        List<SettingViewModel> ListSettings { get; set; }

        string MinStockQuantity { get; set; }

        string FingerprintIpAddress { get; set; }
        string FingerprintPort { get; set; }

        string OldPassword { get; set; }
        string NewPassword { get; set; }
        string ReTypeNewPassword { get; set; }

        string SPKServiceLimit { get; set; }
        string SPKRepairLimit { get; set; }
    }
}
