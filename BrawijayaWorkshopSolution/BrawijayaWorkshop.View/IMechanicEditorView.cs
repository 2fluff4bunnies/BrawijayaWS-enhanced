using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Infrastructure.MVP;

namespace BrawijayaWorkshop.View
{
    public interface IMechanicEditorView : IView
    {
        Mechanic SelectedMechanic { get; set; }

        string Code { get; set; }
        string MechanicName { get; set; }
        string Address { get; set; }
        string PhoneNumber { get; set; }
    }
}
