using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.SharedObject.ViewModels;

namespace BrawijayaWorkshop.View
{
    public interface IMechanicEditorView : IView
    {
        string FingerprintIP { get; set; }
        string FingerpringPort { get; set; }

        MechanicViewModel SelectedMechanic { get; set; }

        string Code { get; set; }
        string MechanicName { get; set; }
        string Address { get; set; }
        string PhoneNumber { get; set; }
    }
}
