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

    }
}
