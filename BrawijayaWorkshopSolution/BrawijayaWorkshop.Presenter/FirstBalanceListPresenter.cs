using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.Runtime;
using BrawijayaWorkshop.View;

namespace BrawijayaWorkshop.Presenter
{
    public class FirstBalanceListPresenter : BasePresenter<IFirstBalanceListView, FirstBalanceListModel>
    {
        public FirstBalanceListPresenter(IFirstBalanceListView view, FirstBalanceListModel model)
            : base(view, model) { }

        public void LoadData()
        {
            View.SelectedFirstBalanceJournal = Model.RetrieveFirstBalance();
            if(View.SelectedFirstBalanceJournal != null)
            {
                View.FirstBalanceJournalDetailList = Model.RetrieveFirstBalanceDetail(View.SelectedFirstBalanceJournal.Id);
            }
        }

        public void DeleteSelectedBalance()
        {
            Model.DeleteFirstBalanceJournal(View.SelectedFirstBalanceJournal, LoginInformation.UserId);
        }
    }
}
