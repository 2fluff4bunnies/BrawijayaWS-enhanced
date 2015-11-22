using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.View;

namespace BrawijayaWorkshop.Presenter
{
    public class JournalMasterListPresenter : BasePresenter<IJournalMasterListView, JournalMasterListModel>
    {
        public JournalMasterListPresenter(IJournalMasterListView view, JournalMasterListModel model)
            : base(view, model) { }

        public void InitData()
        {
            View.ParentDropdownList = Model.GetAllParentJournal();
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
