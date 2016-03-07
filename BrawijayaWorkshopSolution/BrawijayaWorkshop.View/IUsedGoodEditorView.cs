using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System.Collections.Generic;

namespace BrawijayaWorkshop.View
{
    public interface IUsedGoodEditorView : IView
    {
        UsedGoodViewModel SelectedUsedGood { get; set; }

        int SparepartId { get; set; }

        List<SparepartViewModel> ListSparepart { get; set; }
    }
}
