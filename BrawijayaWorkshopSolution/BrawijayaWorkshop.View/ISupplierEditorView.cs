using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Infrastructure.MVP;

namespace BrawijayaWorkshop.View
{
    public interface ISupplierEditorView : IView
    {
        Supplier SelectedSupplier { get; set; }

        string SupplierName { get; set; }
        string Address { get; set; }
        string PhoneNumber { get; set; }
    }
}
