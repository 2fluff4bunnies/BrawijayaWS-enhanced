using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.SharedObject.ViewModels;
using BrawijayaWorkshop.View;
using System.Collections.Generic;

namespace BrawijayaWorkshop.Presenter
{
    public class JournalMasterListPresenter : BasePresenter<IJournalMasterListView, JournalMasterListModel>
    {
        public JournalMasterListPresenter(IJournalMasterListView view, JournalMasterListModel model)
            : base(view, model) { }

        public void InitData()
        {
            List<JournalMasterViewModel> listParent = Model.GetAllParentJournal();
            listParent.Insert(0, new JournalMasterViewModel
            {
                Id = 0,
                Code = "-- Pilih Account --",
                Name = "-- Pilih Account --"
            });
            View.ParentDropdownList = listParent;
        }

        public void LoadData()
        {
            View.JournalMasterListData = Model.GetAllJournal(View.ParentId, View.NameFilter);
        }

        public void DeleteData()
        {
            Model.DeleteJournal(View.SelectedJournalMaster);
        }
    }
}
