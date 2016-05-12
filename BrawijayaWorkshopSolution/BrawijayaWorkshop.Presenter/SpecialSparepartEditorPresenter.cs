using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.Runtime;
using BrawijayaWorkshop.SharedObject.ViewModels;
using BrawijayaWorkshop.View;

namespace BrawijayaWorkshop.Presenter
{
    public class SpecialSparepartEditorPresenter : BasePresenter<ISpecialSparepartEditorView, SpecialSparepartEditorModel>
    {
        public SpecialSparepartEditorPresenter(ISpecialSparepartEditorView view, SpecialSparepartEditorModel model)
            : base(view, model) { }

        public void InitFormData()
        {
            View.SparepartList = Model.GetSparepartLookupList();
            View.CategoryReferenceList = Model.GetSpecialSparepartCategoryList();

            if (View.SelectedSpecialSparepart != null)
            {
                View.Unit = View.SelectedSpecialSparepart.Sparepart.UnitReference.Name;
                View.Code = View.SelectedSpecialSparepart.Sparepart.Code;
                View.SparepartId = View.SelectedSpecialSparepart.SparepartId;
                View.CategoryReferenceId = View.SelectedSpecialSparepart.ReferenceCategoryId;
            }
        }

        public void SaveChanges()
        {
            if (View.SelectedSpecialSparepart == null)
            {
                View.SelectedSpecialSparepart = new SpecialSparepartViewModel();
            }

            View.SelectedSpecialSparepart.SparepartId = View.SparepartId;
            View.SelectedSpecialSparepart.ReferenceCategoryId = View.CategoryReferenceId;

            if (View.SelectedSpecialSparepart.Id > 0)
            {
                Model.UpdateWheel(View.SelectedSpecialSparepart, LoginInformation.UserId);
            }
            else
            {
                Model.InsertWheel(View.SelectedSpecialSparepart, LoginInformation.UserId);
            }
        }
    }
}
