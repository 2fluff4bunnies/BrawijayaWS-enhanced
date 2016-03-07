using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.SharedObject.ViewModels;
using BrawijayaWorkshop.View;

namespace BrawijayaWorkshop.Presenter
{
    public class UsedGoodEditorPresenter : BasePresenter<IUsedGoodEditorView, UsedGoodEditorModel>
    {
        public UsedGoodEditorPresenter(IUsedGoodEditorView view, UsedGoodEditorModel model)
            : base(view, model) { }

        public void InitFormData()
        {
            View.ListSparepart = Model.RetrieveSparepart();

            if (View.SelectedUsedGood != null)
            {
                View.SparepartId = View.SelectedUsedGood.SparepartId;
            }
        }

        public void SaveChanges()
        {
            if (View.SelectedUsedGood == null)
            {
                View.SelectedUsedGood = new UsedGoodViewModel();
            }

            View.SelectedUsedGood.SparepartId = View.SparepartId;

            if (View.SelectedUsedGood.Id > 0)
            {
                Model.UpdateUsedGood(View.SelectedUsedGood);
            }
            else
            {
                Model.InsertUsedGood(View.SelectedUsedGood);
            }
        }
    }
}
