using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.SharedObject.ViewModels;
using BrawijayaWorkshop.View;

namespace BrawijayaWorkshop.Presenter
{
    public class TypeEditorPresenter : BasePresenter<ITypeEditorView, TypeEditorModel>
    {
        public TypeEditorPresenter(ITypeEditorView view, TypeEditorModel model)
            : base(view, model) { }

        public void InitFormData()
        {
            if (View.SelectedType != null)
            {
                View.TypeName = View.SelectedType.Name;
                View.Description = View.SelectedType.Description;
            }
        }

        public void SaveChanges()
        {
            if (View.SelectedType == null)
            {
                View.SelectedType = new TypeViewModel();
            }

            View.SelectedType.Name = View.TypeName;
            View.SelectedType.Description = View.Description;

            if (View.SelectedType.Id > 0)
            {
                Model.UpdateType(View.SelectedType);
            }
            else
            {
                Model.InsertType(View.SelectedType);
            }
        }
    }
}
