using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System.Collections.Generic;

namespace BrawijayaWorkshop.View
{
    public interface IBrandEditorView : IView
    {
        BrandViewModel SelectedBrand { get; set; }

        string BrandName { get; set; }
        string Description { get; set; }
    }
}
