using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Infrastructure.MVP;
using System.Collections.Generic;

namespace BrawijayaWorkshop.View
{
    public interface ISupplierListView : IView
    {
        string SupplierNameFilter { get; set; }

        List<Supplier> SupplierListData { get; set; }

        Supplier SelectedSupplier { get; set; }
    }
}
