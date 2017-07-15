using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System.Collections.Generic;

namespace BrawijayaWorkshop.View
{
    public interface IBrandListView : IView
    {
        string NameFilter { get; set; }

        List<BrandViewModel> BrandListData { get; set; }

        BrandViewModel SelectedBrand { get; set; }

        string ExportFileName { get; }
    }
}
