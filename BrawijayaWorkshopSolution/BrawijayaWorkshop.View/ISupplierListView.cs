using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System.Collections.Generic;

namespace BrawijayaWorkshop.View
{
    public interface ISupplierListView : IView
    {
        string SupplierNameFilter { get; set; }

        List<SupplierViewModel> SupplierListData { get; set; }

        SupplierViewModel SelectedSupplier { get; set; }

        string ExportFileName { get; }
    }
}
