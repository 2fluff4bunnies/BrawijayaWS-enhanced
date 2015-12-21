using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Infrastructure.MVP;
using System;
using System.Collections.Generic;

namespace BrawijayaWorkshop.View
{
    public interface ISPKViewDetailView : IView
    {
        SPK SelectedSPK { get; set; }
        SPK ParentSPK { get; set; }

        List<SPKDetailMechanic> SPKMechanicList { get; set; }
        List<SPKDetailSparepart> SPKSparepartList { get; set; }
        List<SPKDetailSparepartDetail> SPKSparepartDetailList { get; set; }

        string Code { get; set; }
        string DueDate { get; set; }
        string CreateDate { get; set; }
        string Vehicle { get; set; }
        string Customer { get; set; }
        string Category { get; set; }
    }
}
