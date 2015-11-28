using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.View;

namespace BrawijayaWorkshop.Presenter
{
    public class SparepartDetailListPresenter : BasePresenter<ISparepartDetailListView, SparepartDetailListModel>
    {
        public SparepartDetailListPresenter(ISparepartDetailListView view, SparepartDetailListModel model)
            : base(view, model) { }

        public void LoadDetailList()
        {
            View.SparepartDetailListData = Model.SearchSparepart(View.SelectedSparepart.Id,
                (DbConstant.SparepartDetailDataStatus)View.SelectedStatus);
        }
    }
}
