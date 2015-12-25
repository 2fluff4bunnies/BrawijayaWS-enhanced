﻿using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Infrastructure.MVP;
using System;
using System.Collections.Generic;

namespace BrawijayaWorkshop.View
{
    public interface ISPKEditorView : IView
    {
        string ApprovalEmailBody { get; set; }
        string ApprovalEmailFrom { get; set; }
        string ApprovalEmailTo { get; set; }

        string FingerprintIP { get; set; }
        string FingerpringPort { get; set; }

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
         string MechanicDescription { get; set; }

        decimal RepairThreshold { get; set; }
        decimal ServiceThreshold { get; set; }

        bool IsNeedApproval { get; set; }

        decimal TotalSparepartPrice { get; set; }

        string Description { get; set; }

    }
}
