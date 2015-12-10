using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Infrastructure.MVP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrawijayaWorkshop.View
{
   public interface ISPKListView : IView
    {
        int StatusFilter { get; set; }

        string CodeFilter { get; set; }

        List<Reference> CategoryDropdownList { get; set; }

        List<SPK> SPKListData { get; set; }

        SPK SelectedSPK { get; set; }
    }
}
