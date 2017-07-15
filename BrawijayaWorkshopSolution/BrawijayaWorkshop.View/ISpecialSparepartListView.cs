using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System.Collections.Generic;

namespace BrawijayaWorkshop.View
{
    public interface ISpecialSparepartListView : IView
    {
        string NameFilter { get; set; }

        List<SpecialSparepartViewModel> SpecialSparepartListData { get; set; }

        SpecialSparepartViewModel SelectedSpecialSparepart { get; set; }

        string ExportFileName { get; }

    }
}
