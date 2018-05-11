using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.Runtime;
using BrawijayaWorkshop.SharedObject.ViewModels;
using BrawijayaWorkshop.View;

namespace BrawijayaWorkshop.Presenter
{
    public class SparepartEditorPresenter : BasePresenter<ISparepartEditorView, SparepartEditorModel>
    {
        public SparepartEditorPresenter(ISparepartEditorView view, SparepartEditorModel model)
            : base(view, model) { }

        public void InitFormData()
        {
            View.CategoryDropdownList = Model.GetSparepartCategoryList();
            View.UnitDropdownList = Model.GetSparepartUnitList();

            if(View.SelectedSparepart != null)
            {
                View.CategoryId = View.SelectedSparepart.CategoryReferenceId;
                View.UnitId = View.SelectedSparepart.UnitReferenceId;
                View.Code = View.SelectedSparepart.Code;
                View.SparepartName = View.SelectedSparepart.Name;
            }
        }

        public void SaveChanges()
        {
            if (View.SelectedSparepart == null)
            {
                View.SelectedSparepart = new SparepartViewModel();
            }

            View.SelectedSparepart.CategoryReferenceId = View.CategoryId;
            View.SelectedSparepart.UnitReferenceId = View.UnitId;
            View.SelectedSparepart.Code = View.Code;
            View.SelectedSparepart.Name = View.SparepartName;
            View.SelectedSparepart.IsSpecialSparepart = View.IsSpecialSparepart;

            if (View.SelectedSparepart.Id > 0)
            {
                Model.UpdateSparepart(View.SelectedSparepart, LoginInformation.UserId);
            }
            else
            {
                Model.InsertSparepart(View.SelectedSparepart, LoginInformation.UserId);
            }
        }
    }
}
