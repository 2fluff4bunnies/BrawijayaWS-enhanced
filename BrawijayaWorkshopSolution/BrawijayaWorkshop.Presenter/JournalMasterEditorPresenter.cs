using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrawijayaWorkshop.Presenter
{
    public class JournalMasterEditorPresenter : BasePresenter<IJournalMasterEditorView, JournalMasterEditorModel>
    {
        public JournalMasterEditorPresenter(IJournalMasterEditorView view, JournalMasterEditorModel model)
            : base(view, model) { }

        public void InitData()
        {
            View.ParentDropdownList = Model.GetAllParentJournal();
            if(View.SelectedJournalMaster != null)
            {
                View.ParentId = View.SelectedJournalMaster.ParentId;
                View.Code = View.SelectedJournalMaster.Code;
                View.JournalName = View.SelectedJournalMaster.Name;
            }
        }

        public void SaveChanges()
        {
            if(View.SelectedJournalMaster == null)
            {
                View.SelectedJournalMaster = new JournalMaster();
            }

            View.SelectedJournalMaster.ParentId = View.ParentId;
            View.SelectedJournalMaster.Code = View.Code;
            View.SelectedJournalMaster.Name = View.JournalName;

            if(View.SelectedJournalMaster.Id > 0)
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
