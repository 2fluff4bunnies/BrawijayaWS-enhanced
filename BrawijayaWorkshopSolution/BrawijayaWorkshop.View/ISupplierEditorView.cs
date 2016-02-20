using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.SharedObject.ViewModels;

namespace BrawijayaWorkshop.View
{
    public interface ISupplierEditorView : IView
    {
        SupplierViewModel SelectedSupplier { get; set; }

        string SupplierName { get; set; }
        string Address { get; set; }
        string PhoneNumber { get; set; }
    }
}
