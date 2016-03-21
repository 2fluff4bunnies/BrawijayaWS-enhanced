﻿using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.SharedObject.ViewModels;
using BrawijayaWorkshop.View;

namespace BrawijayaWorkshop.Presenter
{
    public class JournalMasterEditorPresenter : BasePresenter<IJournalMasterEditorView, JournalMasterEditorModel>
    {
        public JournalMasterEditorPresenter(IJournalMasterEditorView view, JournalMasterEditorModel model)
            : base(view, model) { }

        public void InitFormData()
        {
            View.ParentDropdownList = Model.GetAllParentJournal();
            if (View.SelectedJournalMaster != null)
            {
                if (View.SelectedJournalMaster.ParentId.HasValue)
                {
                    View.ParentId = View.SelectedJournalMaster.ParentId.Value;
                }
                View.Code = View.SelectedJournalMaster.Code;
                View.JournalName = View.SelectedJournalMaster.Name;
                View.IsProfitLoss = View.SelectedJournalMaster.IsProfitLoss;
            }
        }

        public void SaveChanges()
        {
            if (View.SelectedJournalMaster == null)
            {
                View.SelectedJournalMaster = new JournalMasterViewModel();
            }

            View.SelectedJournalMaster.ParentId = View.ParentId;
            View.SelectedJournalMaster.Code = View.Code;
            View.SelectedJournalMaster.Name = View.JournalName;
            View.SelectedJournalMaster.IsProfitLoss = View.IsProfitLoss;

            if (View.SelectedJournalMaster.Id > 0)
            {
                Model.UpdateJournal(View.SelectedJournalMaster);
            }
            else
            {
                Model.InsertJournal(View.SelectedJournalMaster);
            }
        }
    }
}
