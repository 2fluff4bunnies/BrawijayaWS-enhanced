using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Infrastructure.MVP;
using System.Collections.Generic;

namespace BrawijayaWorkshop.View
{
    public interface IConfigEditorView : IView
    {
        List<Setting> ListSettings { get; set; }

        string MinStockQuantity { get; set; }

        string FingerprintIpAddress { get; set; }

        string FingerprintPort { get; set; }
    }
}
