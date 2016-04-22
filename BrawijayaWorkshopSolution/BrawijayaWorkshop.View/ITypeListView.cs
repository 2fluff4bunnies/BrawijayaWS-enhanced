using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System.Collections.Generic;

namespace BrawijayaWorkshop.View
{
    public interface ITypeListView : IView
    {
        string NameFilter { get; set; }

        List<TypeViewModel> TypeListData { get; set; }

        TypeViewModel SelectedType { get; set; }
    }
}
