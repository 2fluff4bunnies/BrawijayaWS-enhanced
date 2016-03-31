using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.SharedObject.ViewModels;
using BrawijayaWorkshop.View;
using System.Collections.Generic;
using System.Linq;

namespace BrawijayaWorkshop.Presenter
{
    public class JournalCategoryEditorPresenter : BasePresenter<IJournalCategoryEditorView, JournalCategoryEditorModel>
    {
        public JournalCategoryEditorPresenter(IJournalCategoryEditorView view, JournalCategoryEditorModel model)
            : base(view, model) { }

        public void InitFormData()
        {
            View.JournalMasterList = Model.RetrieveAllMasterJournal();
            View.ParentDropdownList = Model.RetrieveAllJournalCategory();

            if(View.SelectedChildren != null)
            {
                View.Code = View.SelectedChildren.Code;
                View.CategoryName = View.SelectedChildren.Name;
                View.CategoryDescription = View.SelectedChildren.Description;

                View.SelectedParentId = View.SelectedChildren.ParentId.Value;
                View.SelectedJournal = View.JournalMasterList.Where(j => j.Code == View.SelectedChildren.Value).FirstOrDefault();
            }
        }

        public void SaveChanges()
        {
            if(View.SelectedChildren == null)
            {
                View.SelectedChildren = new ReferenceViewModel();
            }

            View.SelectedChildren.Code = View.Code;
            View.SelectedChildren.Name = View.CategoryName;
            View.SelectedChildren.Description = View.CategoryDescription;

            View.SelectedChildren.ParentId = View.SelectedParentId;
            View.SelectedChildren.Value = View.SelectedJournal.Code;

            if(View.SelectedChildren.Id > 0)
            {
                Model.UpdateChildren(View.SelectedChildren);
            }
            else
            {
                Model.InsertChildren(View.SelectedChildren);
            }
        }
    }
}
