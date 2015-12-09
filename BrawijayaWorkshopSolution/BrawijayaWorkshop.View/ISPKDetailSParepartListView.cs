using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Infrastructure.MVP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrawijayaWorkshop.View
{
    public interface ISPKDetailSParepartListView : IView
    {

        SPK selectedSPK { get; set; }

        SPKDetailSparepart slectedSparepartDetail { get; set; }

        int SelectedStatus { get; set; }

        List<SPKDetailSparepartStatusItem> ListStatus { get; set; }

        List<SPKDetailSparepart> SPKDetailSparepartListDropdownList { get; set; }

        List<SPKDetailSparepartDetail> SPKDetailSparepartListDetailData { get; set; }
    }

    public class SPKDetailSparepartStatusItem
    {
        public int Status { get; set; }
        public string Description { get; set; }
    }
}
