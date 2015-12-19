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
        List<SPKDetailMechanic> SPKMechanicList { get; set; }
        List<SPKDetailSparepart> SPKSparepartList { get; set; }
        List<SPKDetailSparepartDetail> SPKSparepartDetailList { get; set; }

        List<Sparepart> SparepartLookupList { get; set; }
        List<Mechanic> MechanicLookupList { get; set; }

        Sparepart SparepartToInsert { get; }
        Mechanic MechanicToInsert { get;}

        Sparepart SelectedSparepart { get; set; }
        Mechanic SelectedMechanic { get; set; }

        string Code { get; set; }
        DateTime DueDate { get; set; }
        int VehicleId { get; set; }
        int CategoryId { get; set; }

        int SparepartId { get; set; }
        string SparepartName { get; set; }
        int SparepartQty { get; set; }

        int MechanicId { get; set; }
        string MechanicName { get; set; }
        decimal MechanicFee { get; set; }

    }
}
