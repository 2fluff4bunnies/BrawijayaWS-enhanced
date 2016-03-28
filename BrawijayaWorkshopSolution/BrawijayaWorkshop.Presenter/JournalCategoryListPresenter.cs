using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.SharedObject.ViewModels;
using BrawijayaWorkshop.View;
using System.Collections.Generic;

namespace BrawijayaWorkshop.Presenter
{
    public class JournalCategoryListPresenter : BasePresenter<IJournalCategoryListView, JournalCategoryListModel>
    {
        public JournalCategoryListPresenter(IJournalCategoryListView view, JournalCategoryListModel model)
            : base(view, model) { }

        public void InitFormData()
        {
            List<ReferenceViewModel> listAllJournalCategory = Model.RetrieveAllJournalCategory();
            listAllJournalCategory.Insert(0, new ReferenceViewModel
            {
                Id = 0,
                Description = "-- Pilih Jurnal Kategori --"
            });
            View.ParentDropdownList = listAllJournalCategory;
        }

        public void LoadData()
        {
            View.ChildrenListData = Model.RetrieveCategoriesByParentId(View.ParentId);
        }

        public void DeleteData()
        {
            if (View.SelectedChildren == null) return;

            Model.DeleteJournalCategory(View.SelectedChildren.Id);
        }
    }
}
