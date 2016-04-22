using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System.Collections.Generic;

namespace BrawijayaWorkshop.View
{
    public interface ITypeEditorView : IView
    {
        TypeViewModel SelectedType { get; set; }

        string TypeName { get; set; }
        string Description { get; set; }
    }
}
