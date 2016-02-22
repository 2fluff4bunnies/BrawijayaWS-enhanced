using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.Runtime;
using BrawijayaWorkshop.SharedObject.ViewModels;
using BrawijayaWorkshop.View;

namespace BrawijayaWorkshop.Presenter
{
    public class WheelEditorPresenter : BasePresenter<IWheelEditorView, WheelEditorModel>
    {
        public WheelEditorPresenter(IWheelEditorView view, WheelEditorModel model)
            : base(view, model) { }

        public void InitFormData()
        {
            if (View.SelectedWheel != null)
            {
                View.Category = View.SelectedWheel.Sparepart.CategoryReference.Name;
                View.Unit = View.SelectedWheel.Sparepart.UnitReference.Name;
                View.Code = View.SelectedWheel.Sparepart.Code;
                View.WheelName = View.SelectedWheel.Sparepart.Name;
            }
        }

        public void SaveChanges()
        {
            if (View.SelectedWheel == null)
            {
                View.SelectedWheel = new WheelViewModel();
            }

            View.SelectedWheel.Sparepart.Code = View.Code;
            View.SelectedWheel.Sparepart.Name = View.WheelName;

            if (View.SelectedWheel.Id > 0)
            {
                Model.UpdateWheel(View.SelectedWheel, LoginInformation.UserId);
            }
            else
            {
                Model.InsertWheel(View.SelectedWheel, LoginInformation.UserId);
            }
        }
    }
}
