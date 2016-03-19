﻿using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System.Collections.Generic;

namespace BrawijayaWorkshop.View
{
    public interface ISpecialSparepartEditorView : IView
    {
        SpecialSparepartViewModel SelectedSpecialSparepart { get; set; }

        List<SparepartViewModel> SparepartList { get; set; }
        int SparepartId { get; set; }

        string Unit { get; set; }

        string Code { get; set; }

        int CategoryReferenceId { get; set; }
        List<ReferenceViewModel> CategoryReferenceList { get; set; }
    }
}