using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Infrastructure.MVP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrawijayaWorkshop.View
{
    public interface ISPKEditorView : IView
    {
        SPK SelectedSPK { get; set; }
        SPK ParentSPK { get; set; }

        List<Vehicle> VehicleDropdownList { get; set; }
        List<Reference> CategoryDropdownList { get; set; }
        List<SPKDetailMechanic> MechanicList { get; set; }
        List<SPKDetailSparepartDetail> SparepartList { get; set; }

        string Code { get; set; }
        DateTime DueDate { get; set; }
        int VehicleId { get; set; }
        int CategoryId { get; set; }

    }
}
