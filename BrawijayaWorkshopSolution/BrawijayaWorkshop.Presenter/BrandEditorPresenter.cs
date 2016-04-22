using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.SharedObject.ViewModels;
using BrawijayaWorkshop.View;

namespace BrawijayaWorkshop.Presenter
{
    public class BrandEditorPresenter : BasePresenter<IBrandEditorView, BrandEditorModel>
    {
        public BrandEditorPresenter(IBrandEditorView view, BrandEditorModel model)
            : base(view, model) { }

        public void InitFormData()
        {
            if (View.SelectedBrand != null)
            {
                View.BrandName = View.SelectedBrand.Name;
                View.Description = View.SelectedBrand.Description;
            }
        }

        public void SaveChanges()
        {
            if (View.SelectedBrand == null)
            {
                View.SelectedBrand = new BrandViewModel();
            }

            View.SelectedBrand.Name = View.BrandName;
            View.SelectedBrand.Description = View.Description;

            if (View.SelectedBrand.Id > 0)
            {
                Model.UpdateBrand(View.SelectedBrand);
            }
            else
            {
                Model.InsertBrand(View.SelectedBrand);
            }
        }
    }
}
