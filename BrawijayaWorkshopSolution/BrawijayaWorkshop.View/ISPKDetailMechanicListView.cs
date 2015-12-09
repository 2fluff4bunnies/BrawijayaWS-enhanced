using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Infrastructure.MVP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrawijayaWorkshop.View
{
    public interface ISPKDetailMechanicListView : IView
    {
        SPK SelectedSPK { get; set; }

        int SelectedStatus { get; set; }

        List<SPKDetailMechanicStatusItem> ListStatus { get; set; }

        List<SPKDetailMechanic> SPKDetailMechanicListData { get; set; }
    }

    public class SPKDetailMechanicStatusItem
    {
        public int Status { get; set; }
        public string Description { get; set; }
    }
}
