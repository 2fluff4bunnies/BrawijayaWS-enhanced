using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.View;

namespace BrawijayaWorkshop.Presenter
{
    public class UsedGoodTransactionListPresenter : BasePresenter<IUsedGoodTransactionListView, UsedGoodTransactionListModel>
    {
        public UsedGoodTransactionListPresenter(IUsedGoodTransactionListView view, UsedGoodTransactionListModel model)
            : base(view, model) { }

        public void LoadUsedGoodTransaction()
        {
            View.UsedGoodTransactionListData = Model.SearchUsedGoodTransaction(View.SparepartNameFilter);
        }

        public void DeleteUsedGoodTransaction()
        {
            Model.DeleteUsedGoodTransaction(View.SelectedUsedGoodTransaction);
        }
    }
}
