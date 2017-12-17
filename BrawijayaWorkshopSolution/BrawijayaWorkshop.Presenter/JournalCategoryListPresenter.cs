using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.SharedObject.ViewModels;
using BrawijayaWorkshop.View;
using LINQtoCSV;
using System.Collections.Generic;
using System.Linq;

namespace BrawijayaWorkshop.Presenter
{
    public class JournalCategoryListPresenter : BasePresenter<IJournalCategoryListView, JournalCategoryListModel>
    {
        public JournalCategoryListPresenter(IJournalCategoryListView view, JournalCategoryListModel model)
            : base(view, model) { }

        public void ExportToCSV()
        {
            CsvContext cc = new CsvContext();
            CsvFileDescription outputFileDescription = new CsvFileDescription
            {
                QuoteAllFields = false,
                SeparatorChar = ',', // tab delimited
                FirstLineHasColumnNames = true,
                FileCultureName = "en-US"
            };

            // prepare invoices
            var exportJournals =
                from jour in View.ChildrenListData
                select new
                {
                    Kategori = jour.Parent.Description,
                    Kode = jour.Value,
                    Nama = jour.Description
                };

            cc.Write(exportJournals, View.ExportFileName, outputFileDescription);
        }

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
