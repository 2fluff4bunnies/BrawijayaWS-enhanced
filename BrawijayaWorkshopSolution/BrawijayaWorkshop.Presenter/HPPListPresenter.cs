using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.Runtime;
using BrawijayaWorkshop.View;

namespace BrawijayaWorkshop.Presenter
{
    public class HPPListPresenter : BasePresenter<IHPPListView, HPPListModel>
    {
        public HPPListPresenter(IHPPListView view, HPPListModel model)
            : base(view, model) { }

        public void LoadData()
        {

        }

        public void Recalculate()
        {

        }
    }
}
